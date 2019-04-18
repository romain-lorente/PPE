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
        private List<Mot> lesMots;
        private Utilisateur utilisateurEnCours;

        public Form1(List<Mot> lesMots, Utilisateur utilisateurEnCours)
        {
            this.lesMots = lesMots;
            this.utilisateurEnCours = utilisateurEnCours;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] texte = texteMenu.Lines;
            texte[0] = "Bienvenue " + utilisateurEnCours.Prenom + " !";
            texteMenu.Lines = texte;

            lesMots.Add(new Verbe("Être", "État", new string[] { "suis", "es", "est", "sommes", "êtes", "sont"}));
            lesMots.Add(new Verbe("Avoir", "Action", new string[] { "ai", "as", "a", "avons", "avez", "ont" }));
            lesMots.Add(new Verbe("Faire", "Action", new string[] { "fais", "fais", "fait", "faisons", "faites", "font"}));
            lesMots.Add(new Verbe("Dormir", "Action", new string[] { "dors", "dors", "dort", "dormons", "dormez", "dorment"}));
            lesMots.Add(new Verbe("Jouer", "Action", new string[] { "joue", "joues", "joue", "jouons", "jouez", "jouent"}));
            lesMots.Add(new Verbe("Marcher", "Action", new string[] { "marche", "marches", "marche", "marchons", "marchez", "marchent"}));
            lesMots.Add(new Nom("pomme", "Féminin", "Singulier", "Commun"));
            lesMots.Add(new Nom("table", "Féminin", "Singulier", "Commun"));
            lesMots.Add(new Nom("crayon", "Masculin", "Singulier", "Commun"));
            lesMots.Add(new Nom("Quentin", "Masculin", "Singulier", "Propre"));
            lesMots.Add(new Nom("Romain", "Masculin", "Singulier", "Propre"));
            lesMots.Add(new Adjectif("beau", "Masculin", "Singulier", "Qualificatif"));
            lesMots.Add(new Adjectif("grand", "Masculin", "Singulier", "Qualificatif"));
            lesMots.Add(new Adjectif("petit", "Masculin", "Singulier", "Qualificatif"));
            lesMots.Add(new Adjectif("jeune", "Masculin", "Singulier", "Qualificatif"));
            lesMots.Add(new Adjectif("vieux", "Masculin", "Singulier", "Qualificatif"));
        }

        private void ajouterMotToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(utilisateurEnCours.EstAdministrateur)
            {
                Form_AjoutMot ajoutMot = new Form_AjoutMot(this.lesMots, utilisateurEnCours);
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
    }
}
