using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class Phrase
    {
        public int Id { get; set; }
        public string Texte { set; get; }
        public Mot[] MotsDansPhrases { set; get; }

        public Mot this[int index]{
            get
            {
                return MotsDansPhrases[index];
            }
            set
            {
                MotsDansPhrases[index] = value;
            }
        }

        public Phrase(int id, string texte, Mot[] mots)
        {
            Id = id;
            MotsDansPhrases = mots;
            Texte = texte;
        }

        public Phrase(string texte, Mot[] mots)
        {
            MotsDansPhrases = mots;
            Texte = texte;
        }
    }
}
