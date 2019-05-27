using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE
{
    public partial class Form_AjoutMot : Form
    {
        private Utilisateur utilisateurEnCours;

        Dictionary<ComboBox, int> comboBoxes = new Dictionary<ComboBox, int> { };
        Mot[] motDansPhrase = null;

        public Form_AjoutMot(Utilisateur utilisateurEnCours)
        {
            this.utilisateurEnCours = utilisateurEnCours;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Mot> lesMots = PPEDataBase.Mot.SelectAll();
            foreach (Mot unMot in lesMots)
            {
                if (unMot != null)
                {
                    string[] row = new string[] { unMot.Texte,
                        unMot is Nom ? "Nom" :
                        unMot is Adjectif ? "Adjectif" :
                        unMot is Verbe ? "Verbe" :
                        unMot is Conjugaison ? "Conjugaison" :
                        unMot is Pronom ? "Pronom" :
                        unMot is Adverbe ? "Adverbe" :
                        unMot is Preposition ? "Préposition" :
                        "Autre"
                    };
                    listeMots.Rows.Add(row);
                }
            }

            UpdateListePhrases();
        }

        private void ajoutNom_Click(object sender, EventArgs e)
        {
            Nom unNom = new Nom(texteNom.Text, genreNom.Text, nombreNom.Text, natureNom.Text);

            string[] row = new string[] { texteNom.Text, "Nom" };
            listeMots.Rows.Add(row);

            PPEDataBase.Mot.InsertOne(unNom);
        }

        private void ajoutVerbe_Click(object sender, EventArgs e)
        {
            Conjugaison S1 = new Conjugaison(pers1SVerbe.Text, "Mixte", "Singulier");
            Conjugaison S2 = new Conjugaison(pers2SVerbe.Text, "Mixte", "Singulier");
            Conjugaison S3 = new Conjugaison(pers3SVerbe.Text, "Mixte", "Singulier");
            Conjugaison P1 = new Conjugaison(pers1PVerbe.Text, "Mixte", "Pluriel");
            Conjugaison P2 = new Conjugaison(pers2PVerbe.Text, "Mixte", "Pluriel");
            Conjugaison P3 = new Conjugaison(pers3PVerbe.Text, "Mixte", "Pluriel");

            Conjugaison[] conjugaisonVerbe = new Conjugaison[] { S1, S2, S3, P1, P2, P3 };
			
            Verbe unVerbe = new Verbe(infinitifVerbe.Text, fonctionVerbe.Text, conjugaisonVerbe);

            string[] row = new string[] { infinitifVerbe.Text, "Verbe" };
            listeMots.Rows.Add(row);

            PPEDataBase.Mot.InsertOne(unVerbe);
        }

        private void ajoutAdjectif_Click(object sender, EventArgs e)
        {
            Adjectif unAdjectif = new Adjectif(texteAdjectif.Text, genreAdjectif.Text, nombreAdjectif.Text, fonctionAdjectif.Text);

            string[] row = new string[] { texteAdjectif.Text, "Adjectif" };
            listeMots.Rows.Add(row);

            PPEDataBase.Mot.InsertOne(unAdjectif);
        }

        private void ajoutMot_Click(object sender, EventArgs e)
        {
            switch (typeMot.Text)
            {
                case "Pronom":
                    Pronom unPronom = new Pronom(texteMot.Text, genreMot.Text, nombreMot.Text);

                    listeMots.Rows.Add(new string[] { texteMot.Text, "Pronom" });

                    PPEDataBase.Mot.InsertOne(unPronom);

                    break;

                case "Préposition":
                    Preposition unePreposition = new Preposition(texteMot.Text, genreMot.Text, nombreMot.Text);

                    listeMots.Rows.Add(new string[] { texteMot.Text, "Préposition" });

                    PPEDataBase.Mot.InsertOne(unePreposition);

                    break;

                case "Adverbe":
                    Adverbe unAdverbe = new Adverbe(texteMot.Text, genreMot.Text, nombreMot.Text);

                    listeMots.Rows.Add(new string[] { texteMot.Text, "Adverbe" });

                    PPEDataBase.Mot.InsertOne(unAdverbe);

                    break;

                default:
                    Mot unMot = new Mot(texteMot.Text, genreMot.Text, nombreMot.Text);

                    listeMots.Rows.Add(new string[] { texteMot.Text, "Autre" });

                    PPEDataBase.Mot.InsertOne(unMot);

                    break;
            }
        }

        private void AnalyserPhrase_Click(object sender, EventArgs e)
        {
            ValiderPhrase.Visible = true;

            string[] phrase = inputPhrase.Text.ToLower().Replace("'", "' ").Replace(".", "").Replace("'  ", "' ").Split(new char[] { ' ' });
            motDansPhrase = new Mot[phrase.Length];
            comboBoxes = new Dictionary<ComboBox, int> { };

            formulaireComplementPhrase.Controls.Clear();

            for (int i = 0; i < phrase.Length; i++)
            {
                string unMot = phrase[i];
                int y = i * 30;

                List<Mot> res = PPEDataBase.Mot.SelectByText(unMot);
                if (res.Count > 1)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Text = "Différents mots trouvés pour " + unMot + ": ";
                    label.Location = new Point(0, y);

                    formulaireComplementPhrase.Controls.Add(label);

                    motDansPhrase[i] = null;

                    //Création d'une ComboBox pour régler le conflit de mots
                    ComboBox choix = new ComboBox();
                    choix.DropDownStyle = ComboBoxStyle.DropDownList;
                    choix.FormattingEnabled = true;

                    choix.Items.AddRange(res.ToArray());

                    choix.Location = new Point(label.Size.Width + 20, y);
                    choix.Size = new Size(450, 25);

                    formulaireComplementPhrase.Controls.Add(choix);

                    //Ajout de la ComboBox dans le dictionnaire
                    comboBoxes.Add(choix, i);

                    //EventHandler pour la gestion des conflits
                    choix.SelectedIndexChanged += new EventHandler(ComboBoxConflictChangedIndex);
                }
                else if (res.Count > 0)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Text = "Un seul mot trouvé pour " + res[0];
                    label.Location = new Point(0, y);

                    formulaireComplementPhrase.Controls.Add(label);

                    motDansPhrase[i] = res[0];
                }
                else
                {
                    ValiderPhrase.Visible = false;

                    Label label = new Label();
                    label.AutoSize = true;
                    label.Text = "Aucun mot trouvé pour " + unMot + ".";
                    label.Location = new Point(0, y);

                    formulaireComplementPhrase.Controls.Add(label);

                    motDansPhrase[i] = null;
                }
                y += 30;
            }
        }

        private void ComboBoxConflictChangedIndex(object sender, EventArgs e)
        {
            ComboBox maComboBox = (ComboBox)sender;

            //On récupère la position du mot concerné par le conflit
            int res = comboBoxes[maComboBox];

            motDansPhrase[res] = (Mot)maComboBox.SelectedItem;
        }

        private void ValiderPhrase_Click(object sender, EventArgs e)
        {
            bool validation = true;
            MotDansPhrase[] lesMots = new MotDansPhrase[motDansPhrase.Length];

            for(int i = 0; i < motDansPhrase.Length; i++)
            {
                if (motDansPhrase[i] != null)
                {
                    lesMots[i] = new MotDansPhrase(motDansPhrase[i], i);
                }
                else
                {
                    validation = false;
                    break;
                }
            }

            if(validation)
            {
                PPEDataBase.Phrase.InsertOne(new Phrase(inputPhrase.Text, lesMots));
                MessageBox.Show("Insertion réussie.", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Suppression du contenu du panel + de la TextBox
                formulaireComplementPhrase.Controls.Clear();
                inputPhrase.Text = "";

                //Mise à jour de la liste
                UpdateListePhrases();

                ValiderPhrase.Visible = false;
            }
            else
            {
                MessageBox.Show("La phrase comporte des conflits de mots ou des mots inexistants.", "Erreur d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateListePhrases()
        {
            List<Phrase> lesPhrases = PPEDataBase.Phrase.SelectAll();

            listePhrases.Items.Clear();

            foreach (Phrase unePhrase in lesPhrases)
            {
                listePhrases.Items.Add(new ListViewPhrase(unePhrase));
            }
        }

        //Suppression d'une phrase
        private void supprimerPhrase_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Supprimer les éléments sélectionnés ?", "Suppression", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                foreach (ListViewItem item in listePhrases.SelectedItems)
                {
                    ListViewPhrase itemPhrase = (ListViewPhrase)item;

                    PPEDataBase.Phrase.DeleteOne(itemPhrase.Phrase);
                }
            }

            UpdateListePhrases();
        }
    }
}