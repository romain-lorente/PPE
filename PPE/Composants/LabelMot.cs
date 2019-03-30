using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE.Composants
{
    class LabelMot : Label
    {
        private Mot mot;

        public Mot Mot
        {
            get
            {
                return mot;
            }
            set
            {
                mot = value;
                Text = mot.getTexte();
            }
        }

        public LabelMot(Mot mot)
        {
            Mot = mot;
        }
    }
}