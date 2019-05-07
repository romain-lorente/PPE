using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE.Forms
{
    public partial class Form_Jeu : Form
    {
        public Form_Jeu()
        {
            InitializeComponent();
        }

        private void Form_Jeu_Load(object sender, EventArgs e)
        {

        }

        private void generatePhrase()
        {
            Random rand = new Random();

            List<Phrase> phrases = PPEDataBase.Phrase.SelectAll();

            int index = rand.Next(phrases.Count);


        }
    }
}
