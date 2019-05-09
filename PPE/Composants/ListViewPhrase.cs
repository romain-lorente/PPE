using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE
{
    public partial class ListViewPhrase : ListViewItem
    {
        public Phrase Phrase { get; private set; }

        public ListViewPhrase(Phrase unePhrase) : base(unePhrase.Texte)
        {
            Phrase = unePhrase;
        }
    }
}
