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
        private List<Utilisateur> lesUtilisateurs; //Temporaire

        public Utilisateur Utilisateur { private set; get; } = null;

        public Form_Connexion()
        {
            this.lesUtilisateurs = new List<Utilisateur>(); //Temporaire
            lesUtilisateurs.Add(new Utilisateur("eleve", "4cdfd556037e71f444cec02bf05421e860141c49d5701afdd109d29ab9c8ed29", "Lorente", "Romain", true));
            InitializeComponent();
        }

        private void Form_Connexion_Load(object sender, EventArgs e)
        {
            
        }

        private void boutonInscription_Click(object sender, EventArgs e)
        {
            Form_Inscription inscription = new Form_Inscription(this.lesUtilisateurs);
            inscription.ShowDialog();
        }

        private void boutonConnexion_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateurEnCours = TrouverUtilisateur();

            if(utilisateurEnCours != null)
            {
                if(Encodage.ConversionSHA256(inputMDP.Text) == utilisateurEnCours.getMotDePasse())
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

        private Utilisateur TrouverUtilisateur()
        {
            foreach (Utilisateur unUtilisateur in lesUtilisateurs)
            {
                if (unUtilisateur.getLogin() == inputLogin.Text)
                {
                    return unUtilisateur;
                }
            }
            return null;
        }
    }
}
