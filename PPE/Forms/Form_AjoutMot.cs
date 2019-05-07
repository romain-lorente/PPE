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
                        "?"
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
            Conjugaison S1 = new Conjugaison(pers1SVerbe.Text, "mixte", "singulier");
            Conjugaison S2 = new Conjugaison(pers2SVerbe.Text, "mixte", "singulier");
            Conjugaison S3 = new Conjugaison(pers3SVerbe.Text, "mixte", "singulier");
            Conjugaison P1 = new Conjugaison(pers1PVerbe.Text, "mixte", "pluriel");
            Conjugaison P2 = new Conjugaison(pers2PVerbe.Text, "mixte", "pluriel");
            Conjugaison P3 = new Conjugaison(pers3PVerbe.Text, "mixte", "pluriel");

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

        Dictionary<ComboBox, int> comboBoxes = new Dictionary<ComboBox, int> { };
        Mot[] motDansPhrase = null;

        private void AnalyserPhrase_Click(object sender, EventArgs e)
        {
            ValiderPhrase.Visible = true;

            string[] phrase = inputPhrase.Text.ToLower().Split(new char[] { ' ' });
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

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void UpdateListePhrases()
        {
            List<Phrase> lesPhrases = PPEDataBase.Phrase.SelectAll();

            listePhrases.Items.Clear();

            foreach (Phrase unePhrase in lesPhrases)
            {
                Console.WriteLine(unePhrase.Texte);
                listePhrases.Items.Add(new ListViewItem(unePhrase.Texte));
            }
        }
    }
}