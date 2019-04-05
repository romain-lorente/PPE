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
    public partial class Form_Profil : Form
    {
        private Utilisateur utilisateurEnCours;

        public Form_Profil(Utilisateur utilisateurEnCours)
        {
            this.utilisateurEnCours = utilisateurEnCours;
            InitializeComponent();
            actualiserInformations();
        }

        public void actualiserInformations()
        {
            titreProfil.Text = "Profil de " + utilisateurEnCours.getLogin();
            labelNom.Text = utilisateurEnCours.getNom() + " " + utilisateurEnCours.getPrenom();
            labelScore.Text = "Score : " + utilisateurEnCours.getScore();

            string role = utilisateurEnCours.getRole() ? "Administrateur" : "Utilisateur";

            labelRole.Text = "Vous êtes " + role;
        }

        private void validerNom_Click(object sender, EventArgs e)
        {
            if(inputNom.Text != "" && inputPrenom.Text != "")
            {
                utilisateurEnCours.setNom(inputNom.Text);
                utilisateurEnCours.setPrenom(inputPrenom.Text);

                MessageBox.Show("Modification réussie.", "Modification des informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ControleProfil.SelectedTab = consulterProfil;

                actualiserInformations();
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nom et un prénom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validerMDP_Click(object sender, EventArgs e)
        {
            if(Encodage.ConversionSHA256(inputMDPold.Text) == utilisateurEnCours.getMotDePasse())
            {
                if (inputMDP.Text.Length > 3)
                {
                    string encodageMDP = Encodage.ConversionSHA256(inputMDP.Text);
                    utilisateurEnCours.setMotDePasse(encodageMDP);

                    MessageBox.Show("Modification réussie.", "Changement de mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ControleProfil.SelectedTab = consulterProfil;

                    actualiserInformations();
                }
                else
                {
                    MessageBox.Show("Impossible d'utiliser un mot de passe de moins de 4 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
