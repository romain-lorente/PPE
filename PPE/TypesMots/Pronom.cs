using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE.TypesMots
{
    class Pronom : Mot
    {
        public Pronom(int id, string texte, string genre, string nombre) : base(id, texte, genre, nombre) { }

        public Pronom(string texte, string genre, string nombre) : base(texte, genre, nombre) { }


    }
}
