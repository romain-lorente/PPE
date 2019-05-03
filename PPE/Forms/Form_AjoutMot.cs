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