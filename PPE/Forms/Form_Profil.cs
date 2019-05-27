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

        private void validerNom_Click(object sender, EventArgs e)
        {
            if(inputNom.Text != "" && inputPrenom.Text != "")
            {
                utilisateurEnCours.Nom = inputNom.Text;
                utilisateurEnCours.Prenom = inputPrenom.Text;

                MessageBox.Show("Modification réussie.", "Modification des informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ControleProfil.SelectedTab = consulterProfil;

                PPEDataBase.Utilisateur.UpdateOne(utilisateurEnCours);

                actualiserInformations();
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nom et un prénom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validerMDP_Click(object sender, EventArgs e)
        {
            if(Encodage.ConversionSHA256(inputMDPold.Text) == utilisateurEnCours.MotDePasse)
            {
                if (inputMDP.Text.Length >= 4)
                {
                    string encodageMDP = Encodage.ConversionSHA256(inputMDP.Text);
                    utilisateurEnCours.MotDePasse = encodageMDP;

                    MessageBox.Show("Modification réussie.", "Changement de mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ControleProfil.SelectedTab = consulterProfil;

                    PPEDataBase.Utilisateur.UpdateOne(utilisateurEnCours);

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

        public void actualiserInformations()
        {
            titreProfil.Text = "Profil de " + utilisateurEnCours.Login;
            labelNom.Text = utilisateurEnCours.Nom + " " + utilisateurEnCours.Prenom;
            labelScore.Text = "Score : " + utilisateurEnCours.MeilleurScore;

            string role = utilisateurEnCours.EstAdministrateur ? "Administrateur" : "Utilisateur";

            labelRole.Text = "Vous êtes " + role;

            //Suppression du texte dans les formulaires
            inputMDP.Text = "";
            inputMDPold.Text = "";
            inputNom.Text = utilisateurEnCours.Nom;
            inputPrenom.Text = utilisateurEnCours.Prenom;
        }

        private void Form_Profil_Load(object sender, EventArgs e)
        {

        }
    }
}
