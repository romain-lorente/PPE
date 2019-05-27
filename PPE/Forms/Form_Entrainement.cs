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
    public partial class Form_Jeu : Form
    {
        private Phrase phrase = null;
        private Dictionary<Label, int> indexs = null;

        private Type[] aTrouver = null;

        private Utilisateur utilisateurEnJeu;

        int score = 0;

        public Form_Jeu(Utilisateur utilisateurEnJeu)
        {
            InitializeComponent();
            this.utilisateurEnJeu = utilisateurEnJeu;
        }

        private void Form_Jeu_Load(object sender, EventArgs e)
        {
            generatePhrase();
            generateQuestion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generatePhrase();
        }

        private void labelBorderVisible(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            label.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelBorderInvisible(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            label.BorderStyle = BorderStyle.None;
        }

        private void labelClick(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            int index = indexs[label];
            Mot mot = phrase[index];

            bool typetrouver = false;
            foreach(Type typeMot in aTrouver)
            {
                if(mot.GetType() == typeMot)
                {
                    AddScore();
                    NextQuestion();
                    typetrouver = true;
                }
            }

            if(!typetrouver)
            {
                MessageBox.Show("Faux", "Resultat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NextQuestion();
            }
        }

        private void generatePhrase()
        {
            Random rand = new Random();

            List<Phrase> phrases = PPEDataBase.Phrase.SelectAll();
            if(phrases.Count > 0)
            {
                phrase = phrases[rand.Next(phrases.Count)];
                indexs = new Dictionary<Label, int>();

                panelPhrase.Controls.Clear();

                int x = 10;
                for (int i = 0; i < phrase.Length; i++)
                {
                    Mot mot = phrase[i];

                    Label label = new Label();
                    label.AutoSize = true;
                    label.Text = mot.Texte;
                    label.Location = new Point(x, 10);
                    label.Font = new Font("Arial", 25F);

                    label.MouseEnter += new EventHandler(labelBorderVisible);
                    label.MouseLeave += new EventHandler(labelBorderInvisible);
                    label.Click += new EventHandler(labelClick);

                    Graphics labelGraphics = label.CreateGraphics();
                    int size = (int)labelGraphics.MeasureString(mot.Texte, label.Font).Width;
                    int spaceSize = (int)labelGraphics.MeasureString(" ", label.Font).Width;
                    x += spaceSize + size;

                    panelPhrase.Controls.Add(label);

                    indexs.Add(label, i);
                }
            }
        }

        private void generateQuestion()
        {
            Dictionary<string, Type[]> questions = new Dictionary<string, Type[]>
            {
                { "Clique sur un verbe.", new Type[] { typeof(Conjugaison), typeof(Verbe) } },
                { "Clique sur un adjectif.", new Type[] {typeof(Adjectif) } },
                { "Clique sur un nom", new Type[] {typeof(Nom) } },
                { "Clique sur un pronom", new Type[] { typeof(Pronom) } },
                { "Clique sur une preposition", new Type[] { typeof(Preposition) } },
            };

            Random rand = new Random();

            KeyValuePair<string, Type[]> question = questions.ElementAt(rand.Next(0, questions.Count));

            aTrouver = question.Value;
            labelQuestion.Text = question.Key;
        }

        private void AddScore()
        {
            score += 1;
            labelScore.Text = "Score: " + score;
            MessageBox.Show("Vrai", "Resultat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            NextQuestion();
        }

        private void NextQuestion()
        {
            generatePhrase();
            generateQuestion();
        }

        private void buttonAucun_Click(object sender, EventArgs e)
        {
            bool aucun = true;
            foreach (Mot mot in phrase)
            {
                foreach (Type typeMot in aTrouver)
                {
                    if (mot.GetType() == typeMot)
                    {
                        aucun = false;
                    }
                }   
            }

            if(aucun)
            {
                AddScore();
            }
            else
            {
                MessageBox.Show("Faux", "Resultat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NextQuestion();
            }
            
        }

        private void Form_Jeu_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(utilisateurEnJeu.MeilleurScore < score)
            {
                utilisateurEnJeu.MeilleurScore = score;
                PPEDataBase.Utilisateur.UpdateOne(utilisateurEnJeu);
            }
        }
    }
}
