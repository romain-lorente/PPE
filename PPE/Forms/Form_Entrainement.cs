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
    public partial class Form_Entrainement : Form
    {
        private Phrase phrase = null;
        private Dictionary<Label, int> indexs = null;

        public Form_Entrainement()
        {
            InitializeComponent();
        }

        private void Form_Jeu_Load(object sender, EventArgs e)
        {
            generatePhrase();
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

            panelWordInfos.Controls.Clear();

            string wordInfos = mot.GetWordInfos();
            wordInfos = wordInfos.Replace("\t", "    ");

            string[] lines = wordInfos.Split(new char[] { '\n' });
            for (int i = 0; i < lines.Length; i++)
            {
                Label labelWordInfo = new Label();
                labelWordInfo.AutoSize = true;
                labelWordInfo.Text = lines[i];
                labelWordInfo.Location = new Point(10, i * 35);
                labelWordInfo.Font = new Font("Arial", 18F);

                panelWordInfos.Controls.Add(labelWordInfo);
            }
        }

        private void generatePhrase()
        {
            Random rand = new Random();

            List<Phrase> phrases = PPEDataBase.Phrase.SelectAll();
            phrase = phrases[rand.Next(phrases.Count)];
            indexs = new Dictionary<Label, int>();

            panelPhrase.Controls.Clear();

            int x = 10;
            for(int i = 0; i < phrase.Length; i++)
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
}
