﻿using System;
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

        //Trouve les différents mots dans la phrase
        private void AnalyserPhrase_Click(object sender, EventArgs e)
        {
            string[] phrase = inputPhrase.Text.ToLower().Split(new char[] { ' ' });
            Mot[] motDansPhrase = new Mot[phrase.Length];

            formulaireComplementPhrase.Controls.Clear();

            //Dictionary<int, ComboBox> comboBoxs = new

            for (int i = 0; i < phrase.Length; i++)
            {
                string unMot = phrase[i];
                int y = i * 30;

                List<Mot> res = PPEDataBase.Mot.SelectByText(unMot);
                if (res.Count > 1)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Text = "Different mot trouvés pour " + unMot + ":";
                    label.Location = new Point(0, y);

                    formulaireComplementPhrase.Controls.Add(label);
                    //Console.WriteLine();
                    /*for(int i = 0; i < res.Count; i++)
                    {
                        Console.WriteLine("\t[" + (i + 1) + "] " + GetWordInfos(res[i]) + ".");
                    }*/

                    motDansPhrase[i] = null;
                }
                else if (res.Count > 0)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Text = "Un seul mot trouvé pour " + unMot + ": ";
                    label.Location = new Point(0, y);

                    formulaireComplementPhrase.Controls.Add(label);

                    motDansPhrase[i] = res[0];
                    //Console.WriteLine("Un seul mot trouvé pour " + unMot + ": ");
                    //Console.WriteLine("\t" + GetWordInfos(res[0]) + ".");
                }
                else
                {
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

        private void ValiderPhrase_Click(object sender, EventArgs e)
        {

        }

        public void OnComboBoxChangeWord(object sender, EventArgs e)
        {

        }

        private string GetWordInfos(Mot mot)
        {
            if (mot is Verbe verbe)
            {
                return "verbe " + verbe.Texte;
            }
            if (mot is Conjugaison conjugaison)
            {
                return "conjugaison " + conjugaison.Personne + " du verbe " + conjugaison.Verbe.Texte;
            }

            return "?";
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}