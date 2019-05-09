using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class Conjugaison : Mot
    {
        public Verbe mVerbe;

        public string Personne { get; set; }
        public Verbe Verbe
        {
            get { return mVerbe; }
            set
            {
                mVerbe = value;
                SetPersonne();
            }
        }


        public Conjugaison(int id, string texte, string genre, string nombre): base(id, texte, genre, nombre) { }

        public Conjugaison(string texte, string genre, string nombre) : base(texte, genre, nombre) { }

        public void SetPersonne()
        {
            for (int i = 0; i < mVerbe.Conjugaisons.Length; i++)
            {
                if (Id == mVerbe.Conjugaisons[i].Id)
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

        public override string ToString()
        {
            return Texte + " : conjugaison à la " + Personne + " du verbe " + Verbe.Texte;
        }

        public override string GetWordInfos()
        {
            return "Conjugaison \"" + Texte + "\":\n" +
                "\tVerbe \"" + Verbe.Texte + "\":\n" +
                "\t\tFonction: " + Verbe.Fonction + "\n" +
                "\tPersonne: " + Personne + "\n" +
                "\tGenre:\t" + Genre + "\n" +
                "\tNombre:\t" + Nombre;
        }
    }
}
