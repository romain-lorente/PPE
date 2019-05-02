using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class Verbe : Mot
    {
        //Verbe d'action ou d'état
        public string Fonction { set; get; }
        public Mot[] Conjugaisons { set; get; }

        public Verbe(string texte, string fonction, Mot[] conjugaisons) : base(texte, "mixte", "inveriable")
        {
            Fonction = fonction;
            Conjugaisons = conjugaisons;
        }

        public Verbe(int id, string texte, string fonction, Mot[] conjugaisons) : base(id, texte, "mixte", "inveriable")
        {
            Fonction = fonction;
            Conjugaisons = conjugaisons;
        }
    }
}
