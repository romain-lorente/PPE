using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class Mot
    {
        private string texte;
        //Masculin, féminin
        private string genre;
        //Singulier, pluriel, invariable
        private string nombre;

        public Mot(string texte, string genre, string nombre)
        {
            this.texte = texte;
            this.genre = genre;
            this.nombre = nombre;
        }

        public Mot(string texte)
        {
            this.texte = texte;
            this.genre = "";
            this.nombre = "";
        }

        public string getTexte()
        {
            return this.texte;
        }

        public void setTexte(string texte)
        {
            this.texte = texte;
        }
    }
}