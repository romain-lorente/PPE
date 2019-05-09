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
    public partial class Form1 : Form
    {
        private Utilisateur utilisateurEnCours;

        public Form1(Utilisateur utilisateurEnCours)
        {
            this.utilisateurEnCours = utilisateurEnCours;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] texte = texteMenu.Lines;
            texte[0] = "Bienvenue " + utilisateurEnCours.Prenom + " !";
            texteMenu.Lines = texte;
        }

        private void ajouterMotToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(utilisateurEnCours.EstAdministrateur)
            {
                Form_AjoutMot ajoutMot = new Form_AjoutMot(utilisateurEnCours);
                ajoutMot.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas accès à cette fonctionnalité.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void voirMonProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Profil profil = new Form_Profil(utilisateurEnCours);
            profil.ShowDialog();
        }

        private void entraînementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Entrainement jeu = new Form_Entrainement();
            jeu.ShowDialog();
        }

        private void classementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Classement classement = new Form_Classement();
            classement.ShowDialog();
        }
    }
}
