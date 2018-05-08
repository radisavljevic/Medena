using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medena
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PanelGlavni panelGlavni = new PanelGlavni();
            Form1 form = new Form1();
            panelGlavni.ucitajFormu(form);
            Application.Run(form);
        }
    }
}
