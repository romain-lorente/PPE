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
    public partial class Form_Inscription : Form
    {
        private List<Utilisateur> lesUtilisateurs;

        public Form_Inscription(List<Utilisateur> lesUtilisateurs)
        {
            this.lesUtilisateurs = lesUtilisateurs;
            InitializeComponent();
        }

        private void boutonValider_Click(object sender, EventArgs e)
        {
            if(VerificationLogin())
            {
                if (inputMDP.Text == inputConfirmerMDP.Text)
                {
                    string encodageMDP = Encodage.ConversionSHA256(inputMDP.Text);
                    lesUtilisateurs.Add(new Utilisateur(inputLogin.Text, encodageMDP, inputNom.Text, inputPrenom.Text, false));

                    MessageBox.Show("Inscription réussie.", "Inscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Cet utilisateur existe déjà. Veuillez utiliser un autre identifiant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificationLogin()
        {
            foreach (Utilisateur unUtilisateur in lesUtilisateurs)
            {
                if (unUtilisateur.getLogin() == inputLogin.Text)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
