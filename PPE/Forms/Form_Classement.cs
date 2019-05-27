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
    public partial class Form_Classement : Form
    {
        public Form_Classement()
        {
            InitializeComponent();
        }

        private void Form_Classement_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> liste = PPEDataBase.Utilisateur.SelectLeaderboard();

            listeJoueurs.Items.Clear();

            foreach(KeyValuePair<string, string> unJoueur in liste)
            {
                listeJoueurs.Items.Add(new ListViewItem(new string[] { unJoueur.Key, unJoueur.Value }));
            }
        }
    }
}
