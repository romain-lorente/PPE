using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class Conjugaison : Mot
    {
        public Verbe Verbe { get; set; }

        public Conjugaison(int id, string texte, string genre, string nombre): base(id, texte, genre, nombre) { }

        public Conjugaison(string texte, string genre, string nombre) : base(texte, genre, nombre) { }
    }
}
