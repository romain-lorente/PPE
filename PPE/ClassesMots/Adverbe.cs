using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class Adverbe : Mot
    {
        public Adverbe(int id, string texte, string genre, string nombre) : base(id, texte, genre, nombre) { }

        public Adverbe(string texte, string genre, string nombre) : base(texte, genre, nombre) { }

        public override string ToString()
        {
            return Texte + " adverbe " + Genre + " " + Nombre;
        }
    }
}
