using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenBible2._0
{
    public partial class frmSplashScreen : PerPixelAlphaForm
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            #region Carrega o BG da splash screen
            Bitmap b = new Bitmap(Application.StartupPath+ "\\splash.png");
            SetBitmap(b);
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region ProgressBar não funciona
            progressBar1.Value += 1;
            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                this.DialogResult = DialogResult.OK;
            }
            #endregion
        }

        private void frmSplashScreen_Click(object sender, EventArgs e)
        {
            #region Fecha o form caso clique
            timer1.Stop();
            this.DialogResult = DialogResult.OK;
            #endregion
        }
    }
}
