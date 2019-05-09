using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class Preposition : Mot
    {
        public Preposition(int id, string texte, string genre, string nombre) : base(id, texte, genre, nombre) { }

        public Preposition(string texte, string genre, string nombre) : base(texte, genre, nombre) { }

        public override string ToString()
        {
            return Texte + " préposition " + Genre + " " + Nombre;
        }

        public override string GetWordInfos()
        {
            return "Préposition \"" + Texte + "\":\n" +
                "\tGenre:\t" + Genre + "\n" +
                "\tNombre:\t" + Nombre;
        }
    }
}
