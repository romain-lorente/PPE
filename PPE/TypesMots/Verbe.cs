using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class Verbe : Mot
    {
        //Verbe d'action ou d'état
        private string fonction;
        private string[] conjugaison;

        public Verbe(string texte, string fonction, string[] conjugaison) : base(texte)
        {
            this.fonction = fonction;
            this.conjugaison = conjugaison;
        }

        public string getFonction()
        {
            return this.fonction;
        }

        public void setFonction(string fonction)
        {
            this.fonction = fonction;
        }

        public string[] getConjugaison()
        {
            return this.conjugaison;
        }

        public void setConjugaison(string[] conjugaison)
        {
            this.conjugaison = conjugaison;
        }
    }
}
