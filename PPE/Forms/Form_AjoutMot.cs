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
                //Console.WriteLine( (unMot ?? new PPE.Mot("null", "", "")).Texte );
                
                string[] row = new string[] { unMot.Texte,
                    unMot is Nom ? "Nom" :
                    unMot is Adjectif ? "Adjectif" :
                    unMot is Verbe ? "Verbe" :
                    "?"
                };
                listeMots.Rows.Add(row);
            }
        }

        private void ajoutNom_Click(object sender, EventArgs e)
        {
            Nom unNom = new Nom(texteNom.Text, genreNom.Text, nombreNom.Text, natureNom.Text);
            string[] row = new string[] { texteNom.Text, "Nom" };
            listeMots.Rows.Add(row);
            //lesMots.Add(unNom);
        }

        private void ajoutVerbe_Click(object sender, EventArgs e)
        {
            Mot S1 = new Mot(pers1SVerbe.Text, "mixte", "singulier");
            Mot S2 = new Mot(pers2SVerbe.Text, "mixte", "singulier");
            Mot S3 = new Mot(pers3SVerbe.Text, "mixte", "singulier");
            Mot P1 = new Mot(pers1PVerbe.Text, "mixte", "pluriel");
            Mot P2 = new Mot(pers2PVerbe.Text, "mixte", "pluriel");
            Mot P3 = new Mot(pers3PVerbe.Text, "mixte", "pluriel");

            Mot[] conjugaisonVerbe = new Mot[] { S1, S2, S3, P1, P2, P3 };
            Verbe unVerbe = new Verbe(infinitifVerbe.Text, fonctionVerbe.Text, conjugaisonVerbe);
            string[] row = new string[] { infinitifVerbe.Text, "Verbe" };
            listeMots.Rows.Add(row);
            //lesMots.Add(unVerbe);
        }

        private void ajoutAdjectif_Click(object sender, EventArgs e)
        {
            Adjectif unAdjectif = new Adjectif(texteAdjectif.Text, genreAdjectif.Text, nombreAdjectif.Text, fonctionAdjectif.Text);
            string[] row = new string[] { texteAdjectif.Text, "Adjectif" };
            listeMots.Rows.Add(row);
            //lesMots.Add(unAdjectif);
        }

        private void ValiderPhrase_Click(object sender, EventArgs e)
        {
            string[] phrase = inputPhrase.Text.ToLower().Split(new char[] { ' ' });
            foreach(string unMot in phrase)
            {
                Mot res = PPEDataBase.Mot.SelectOneByText(unMot);
                if (res != null)
                {
                    Console.WriteLine("Mot trouvé : " + unMot);
                }
            }
        }
    }
}