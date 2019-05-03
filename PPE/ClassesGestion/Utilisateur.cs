using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class Utilisateur
    {
        public string Login { private set; get; }
        public string MotDePasse { set; get; }

        public string Nom { set; get; }
        public string Prenom { set; get; }

        public int MeilleurScore { set; get; }
        public bool EstAdministrateur { set; get; }

        public Utilisateur(string login, string motDePasse, string nom, string prenom, bool role)
        {
            Login = login;
            MotDePasse = motDePasse;

            Nom = nom;
            Prenom = prenom;

            MeilleurScore = 0;
            EstAdministrateur = role;
        }

        public Utilisateur(string login, string motDePasse, string nom, string prenom, int meilleurScore, bool role)
        {
            Login = login;
            MotDePasse = motDePasse;

            Nom = nom;
            Prenom = prenom;

            MeilleurScore = meilleurScore;
            EstAdministrateur = role;
        }
    }
}
