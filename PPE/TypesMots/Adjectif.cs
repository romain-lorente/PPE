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
    }
}
