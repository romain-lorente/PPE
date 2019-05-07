using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class Mot
    {
        public int Id { set; get; }

        public string Texte { set; get; }
        //Masculin, féminin, mixte
        public string Genre { set; get; }
        //Singulier, pluriel, invariable
        public string Nombre { set; get; }

        public Mot(int id, string texte, string genre, string nombre)
        {
            Id = id;
            Texte = texte;
            Genre = genre;
            Nombre = nombre;
        }

        public Mot(string texte, string genre, string nombre)
        {
            Texte = texte;
            Genre = genre;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Texte + " : mot " + Genre + " " + Nombre;
        }

        public virtual string GetWordInfos()
        {
            return "Mot " + Texte + ":\n" +
                "\tGenre:\t" + Genre + "\n" +
                "\tNombre:\t" + Nombre;
        }
    }
}