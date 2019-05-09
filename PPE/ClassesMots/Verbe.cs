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
        public Conjugaison[] Conjugaisons { set; get; }

        public Verbe(string texte, string fonction, Conjugaison[] conjugaisons) : base(texte, "mixte", "inveriable")
        {
            Fonction = fonction;
            Conjugaisons = conjugaisons;

            foreach (Conjugaison conjugaison in conjugaisons)
            {
                conjugaison.Verbe = this;
            }
        }

        public Verbe(int id, string texte, string fonction, Conjugaison[] conjugaisons) : base(id, texte, "mixte", "inveriable")
        {
            Fonction = fonction;
            Conjugaisons = conjugaisons;

            foreach(Conjugaison conjugaison in conjugaisons)
            {
                conjugaison.Verbe = this;
            }
        }

        public override string ToString()
        {
            return Texte + " : verbe d'" + Fonction;
        }

        public override string GetWordInfos()
        {
            return "Verbe \"" + Texte + "\":\n" +
                "\tFonction:\t" + Fonction + "\n" +
                "\tGenre:\t" + Genre + "\n" +
                "\tNombre:\t" + Nombre;
        }
    }
}
