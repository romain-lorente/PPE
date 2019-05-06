using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class Nom : Mot
    {
        //Propre, commun
        public string Nature { get; set; }

        public Nom(string texte, string genre, string nombre, string nature) : base(texte, genre, nombre)
        {
            Nature = nature;
        }

        public Nom(int id, string texte, string genre, string nombre, string nature) : base(id, texte, genre, nombre)
        {
            Nature = nature;
        }

        public override string ToString()
        {
            return Texte + " nom " + Nature + ", " + Genre + " " + Nombre;
        }
    }
}