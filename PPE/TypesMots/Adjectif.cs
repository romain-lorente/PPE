using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class Adjectif : Mot
    {
        //Qualificatif, démonstratif, possessif...
        public string Fonction;

        public Adjectif(string texte, string genre, string nombre, string fonction) : base(texte, genre, nombre)
        {
            Fonction = fonction;
        }

        public Adjectif(int id, string texte, string genre, string nombre, string fonction) : base(id, texte, genre, nombre)
        {
            Fonction = fonction;
        }

        public override string ToString()
        {
            return Texte + " : adjectif " + Fonction + ", " + Genre + " " + Nombre;
        }

        public override string GetWordInfos()
        {
            return "Adjectif " + Texte + ":\n" +
                "\tFonction:\t " + Fonction + "\n" +
                "\tGenre:\t" + Genre + "\n" +
                "\tNombre:\t" + Nombre;
        }
    }
}
