using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class PhraseEnum : IEnumerator
    {
        public MotDansPhrase[] mots;
        public int index = -1;

        public PhraseEnum(MotDansPhrase[] mots)
        {
            this.mots = mots;
        }

        public object Current
        {
            get
            {
                if (mots[index] != null)
                    return mots[index].Mot;
                return null;
            }
        }

        public bool MoveNext()
        {
            index++;
            return index < mots.Length;
        }

        public void Reset()
        {
            index = -1;
        }
    }

    public class Phrase : IEnumerable
    {
        public int Id { get; set; }
        public string Texte { set; get; }
        public MotDansPhrase[] MotsDansPhrases { set; get; }

        public int Length
        {
            get
            {
                if (MotsDansPhrases != null)
                    return MotsDansPhrases.Length;
                return 0;
            }
        }

        public Mot this[int index]{
            get
            {
                return MotsDansPhrases[index].Mot;
            }
            set
            {
                MotsDansPhrases[index].Mot = value;
            }
        }

        public Phrase(int id, string texte, MotDansPhrase[] mots)
        {
            Id = id;
            MotsDansPhrases = mots;
            Texte = texte;
        }

        public Phrase(string texte, MotDansPhrase[] mots)
        {
            MotsDansPhrases = mots;
            Texte = texte;
        }

        public IEnumerator GetEnumerator()
        {
            return new PhraseEnum(MotsDansPhrases);
        }
    }
}
