using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class Utilisateur
    {
        private string login;
        private string motDePasse;

        private string nom;
        private string prenom;

        private int meilleurScore;
        private bool estAdministrateur;

        public Utilisateur(string login, string motDePasse, string nom, string prenom, bool role)
        {
            this.login = login;
            this.motDePasse = motDePasse;

            this.nom = nom;
            this.prenom = prenom;

            this.meilleurScore = 0;
            this.estAdministrateur = role;
        }

        public string getLogin()
        {
            return this.login;
        }

        public string getMotDePasse()
        {
            return this.motDePasse;
        }

        public void setMotDePasse(string motDePasse)
        {
            this.motDePasse = motDePasse;
        }

        public string getNom()
        {
            return this.nom;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
        }

        public int getScore()
        {
            return this.meilleurScore;
        }

        public bool getRole()
        {
            return this.estAdministrateur;
        }
    }
}
