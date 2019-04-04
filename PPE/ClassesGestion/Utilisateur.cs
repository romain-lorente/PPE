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

        public string getPrenom()
        {
            return this.prenom;
        }
    }
}
