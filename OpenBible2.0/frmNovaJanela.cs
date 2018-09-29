using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class frmNovaJanela : MaterialForm
    {
        #region Cores personalizadas
        Color Cor1 = Color.FromArgb(55, 71, 79);
        Color Cor2 = Color.FromArgb(38, 50, 56);
        #endregion

        #region Instâncias globais
        AccessDB _access = new AccessDB();
        OpenBiblieFunctions _functions = new OpenBiblieFunctions();
        #endregion

        #region Declarações/Variáveis globais
        string documentBiblia = string.Empty;
        #endregion

        public frmNovaJanela(string documentBiblia)
        {
            InitializeComponent();

            #region Skin manager do form
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey50, Accent.LightBlue200, TextShade.WHITE);
            #endregion

            #region Configuração do browser da bíblia
            resBiblia.IsWebBrowserContextMenuEnabled = false;
            resBiblia.AllowWebBrowserDrop = false;
            #endregion

            this.documentBiblia = documentBiblia;
        }

        private void frmNovaJanela_Load(object sender, EventArgs e)
        {
            #region Seta as cores personalizadas
            this.labelBiblia.BackColor = Cor1;
            #endregion

            #region  Atribuindo o texto ao componente resBiblia
            resBiblia.DocumentText = "";
            resBiblia.Document.OpenNew(true);
            resBiblia.Document.Write(this.documentBiblia);
            resBiblia.Refresh();
            #endregion
        }
    }
}
