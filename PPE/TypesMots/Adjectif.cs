using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class Adjectif : Mot
    {
        //Qualificatif, démonstratif, possessif...
        private string fonction;

        public Adjectif(string texte, string genre, string nombre, string fonction) : base(texte, genre, nombre)
        {
            this.fonction = fonction;
        }

        public string getFonction()
        {
            return this.fonction;
        }

        public void setFonction(string fonction)
        {
            this.fonction = fonction;
        }

        public override string ToString()
        {
            return Texte + " : adjectif " + fonction + ", " + Genre + " " + Nombre;
        }
    }
}
