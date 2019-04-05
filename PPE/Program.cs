using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Mot> lesMots;
            lesMots = new List<Mot>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form_Connexion connexion = new Form_Connexion();

            Application.Run(connexion);

            if (connexion.Utilisateur != null)
            {
                Application.Run(new Form1(lesMots, connexion.Utilisateur));
            }
        }
    }
}