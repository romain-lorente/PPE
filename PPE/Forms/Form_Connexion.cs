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
    public partial class Form_Connexion : Form
    {
        public Utilisateur Utilisateur { private set; get; } = null;

        public Form_Connexion()
        {
            InitializeComponent();
        }

        private void boutonInscription_Click(object sender, EventArgs e)
        {
            Form_Inscription inscription = new Form_Inscription();
            inscription.ShowDialog();
        }

        private void boutonConnexion_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateurEnCours = PPEDataBase.Utilisateur.SelectOne(inputLogin.Text);

            if(utilisateurEnCours != null)
            {
                if (Encodage.ConversionSHA256(inputMDP.Text) == utilisateurEnCours.MotDePasse)
                {
                    Utilisateur = utilisateurEnCours;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Mauvais mot de passe. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Cet utilisateur n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
