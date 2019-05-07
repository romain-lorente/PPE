using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class MotDansPhrase
    {
        public int Id { get; set; }
        public Mot Mot { get; set; }
        public int Position { get; set; }

        public MotDansPhrase(int id, Mot mot, int pos)
        {
            this.Id = id;
            this.Mot = mot;
            this.Position = pos;
        }

        public MotDansPhrase(Mot mot, int pos)
        {
            this.Mot = mot;
            this.Position = pos;
        }
    }
}
