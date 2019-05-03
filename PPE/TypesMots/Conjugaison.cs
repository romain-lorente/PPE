using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class Conjugaison : Mot
    {
        private Verbe mVerbe;

        public string Personne { get; set; }
        public Verbe Verbe {
            get { return mVerbe; }
            set
            {
                mVerbe = value;
                for(int i = 0; i < value.Conjugaisons.Length; i++)
                {
                    if(value.Conjugaisons[i].Id == Id)
                    {
                        switch(i)
                        {
                            case 0:
                                Personne = "1ère personne du singulier";
                                break;
                            case 1:
                                Personne = "2ème personne du singulier";
                                break;
                            case 2:
                                Personne = "3ème personne du singulier";
                                break;
                            case 3:
                                Personne = "1ère personne du pluriel";
                                break;
                            case 4:
                                Personne = "2ème personne du pluriel";
                                break;
                            case 5:
                                Personne = "3ème personne du pluriel";
                                break;
                        }
                        break;
                    }
                }
            }
        }

        public Conjugaison(int id, string texte, string genre, string nombre): base(id, texte, genre, nombre) { }

        public Conjugaison(string texte, string genre, string nombre) : base(texte, genre, nombre) { }
    }
}
