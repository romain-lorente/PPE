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
        private List<Mot> lesMots;

        public Form_AjoutMot(List<Mot> lesMots)
        {
            this.lesMots = lesMots;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Mot unMot in lesMots)
            {
                string[] row = new string[] { unMot.getTexte(),
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
            lesMots.Add(unNom);
        }

        private void ajoutVerbe_Click(object sender, EventArgs e)
        {
            string[] conjugaisonVerbe = new string[] { pers1SVerbe.Text, pers2SVerbe.Text, pers3SVerbe.Text,
            pers1PVerbe.Text, pers2PVerbe.Text, pers3PVerbe.Text, };
            Verbe unVerbe = new Verbe(infinitifVerbe.Text, fonctionVerbe.Text, conjugaisonVerbe);
            string[] row = new string[] { infinitifVerbe.Text, "Verbe" };
            listeMots.Rows.Add(row);
            lesMots.Add(unVerbe);
        }

        private void ajoutAdjectif_Click(object sender, EventArgs e)
        {
            Adjectif unAdjectif = new Adjectif(texteAdjectif.Text, genreAdjectif.Text, nombreAdjectif.Text, fonctionAdjectif.Text);
            string[] row = new string[] { texteAdjectif.Text, "Adjectif" };
            listeMots.Rows.Add(row);
            lesMots.Add(unAdjectif);
        }
    }
}