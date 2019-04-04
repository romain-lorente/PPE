using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class Nom : Mot
    {
        //Propre, commun
        private string nature;

        public Nom(string texte, string genre, string nombre, string nature) : base(texte, genre, nombre)
        {
            this.nature = nature;
        }

        public string getNature()
        {
            return this.nature;
        }

        public void setNature(string nature)
        {
            this.nature = nature;
        }
    }
}