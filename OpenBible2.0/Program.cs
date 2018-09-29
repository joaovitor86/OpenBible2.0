using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenBible2._0
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmSplashScreen fSplash = new frmSplashScreen();
            if(fSplash.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
        }
    }
}
