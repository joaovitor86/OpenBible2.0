using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenBible2._0
{
    public partial class Form1 : MaterialForm
    {
        #region Cores personalizadas
        Color Cor1 = Color.FromArgb(55, 71, 79);
        Color Cor2 = Color.FromArgb(38, 50, 56);
        #endregion

        #region Instâncias globais
        OpenBiblieFunctions _functions = new OpenBiblieFunctions();
        AccessDB _access = new AccessDB();
        #endregion

        #region Declarações/Variáveis globais
        public string _LIVRO = "1";
        public string _CAPITULO = "1";
        public string _VERSICULO = "1";
        public string _NOME_LIVRO = "Genesis";
        #endregion

        #region Promessas
        private void Promessas()
        {
            #region Método para achar um texto de promessas
            Random rnd = new Random();
            int livro = rnd.Next(1, 66);

            string _SQL = "SELECT TOP 1 * FROM Versiculos WHERE Livro=" + livro + " ORDER BY Rnd(Capitulo)";
            DataTable _DT = _access.getDados(_SQL);
            foreach (DataRow _ROW in _DT.Rows)
            {
                string _SQL2 = "select * from Livros where Livro=" + _ROW["Livro"].ToString() + "";
                string _LIVRO = "";
                DataTable _DT2 = _access.getDados(_SQL2);
                foreach (DataRow _ROW2 in _DT2.Rows)
                {
                    _LIVRO = _ROW2["Descricao"].ToString();
                }
                resBiblia.DocumentText = "";
                resBiblia.Document.OpenNew(true);
                resBiblia.Document.Write(_functions.CaixaPromessas(_LIVRO + " - " +_ROW["Capitulo"].ToString() + " : " + _ROW["Versiculo"].ToString(), _ROW["Descricao"].ToString()));
                resBiblia.Refresh();
            }
            #endregion
        }
        #endregion

        #region Sombra do Form
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        /*
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00050000; //0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 10,
                            leftWidth = 10,
                            rightWidth = 10,
                            topHeight = 10
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;
        }
        */
        #endregion

        public Form1()
        {
            /*
            #region Sombra ao form
            m_aeroEnabled = true;
            #endregion
            */

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Seta as cores personalizadas
            this.labelLivros.BackColor = Cor1;
            this.labelCapitulos.BackColor = Cor1;
            this.labelVersiculos.BackColor = Cor1;
            this.labelBiblia.BackColor = Cor1;
            #endregion

            #region Chamada de métodos
            _functions.PreencheLivros(this.lstLivros);
            this.Promessas();
            #endregion

            #region Tooltiop's
            toolTip.SetToolTip(btnAleatorio, "Mostrar novas promessas");
            toolTip.SetToolTip(btnAbrePesquisa, "Abrir caixa de pesquisas");
            toolTip.SetToolTip(btnImprimir, "Abrir janela de impressão");
            toolTip.SetToolTip(btnAbrirEmNovaJanela, "Abrir texto atual em nova janela");
            toolTip.SetToolTip(btnSobre, "Informações legais");
            #endregion
        }

        #region Ações para quando escolhe Livro, Capítulo e/ou Versículo
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstLivros_Click(object sender, EventArgs e)
        {
            string id = lstLivros.SelectedItems[0].Text;
            string nome = lstLivros.SelectedItems[0].SubItems[1].Text;

            _LIVRO = id;
            _NOME_LIVRO = nome;

            resBiblia.DocumentText = "";
            resBiblia.Document.OpenNew(true);

            _functions.PreencheCapitulos(_LIVRO, lstCapitulos);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCapitulos_Click(object sender, EventArgs e)
        {
            string id = lstCapitulos.SelectedItems[0].Text;

            _CAPITULO = id;

            _functions.PreencheVersiculos(_LIVRO, _CAPITULO, lstVersiculos);
            _functions.ExibeTextoBiblico(_LIVRO, _CAPITULO, _VERSICULO, _NOME_LIVRO, _CAPITULO, false, resBiblia);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstVersiculos_Click(object sender, EventArgs e)
        {
            string id = lstVersiculos.SelectedItems[0].Text;

            _VERSICULO = id;

            _functions.ExibeTextoBiblico(_LIVRO, _CAPITULO, _VERSICULO, _NOME_LIVRO, _CAPITULO, true, resBiblia);
        }
        #endregion

        #region Click dos botões
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            #region Imprimir conteúdo da bíblia
            if (resBiblia.Document != null)
                resBiblia.Document.Title = _NOME_LIVRO + " - " + _CAPITULO;

            resBiblia.ShowPrintPreviewDialog();
            #endregion
        }

        private void btnAbrirEmNovaJanela_Click(object sender, EventArgs e)
        {
            #region Abre em nova Janela o texto bíblico
            if (resBiblia.Document != null)
            {
                new frmNovaJanela(this.resBiblia.DocumentText).Show();
            }
            #endregion
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            #region Abre o formulário Sobre
            new frmSobre().ShowDialog(this);
            #endregion
        }

        private void btnAbrePesquisa_Click(object sender, EventArgs e)
        {
            #region Abre o formulário de pesquisa
            new frmPesquisar().Show();
            #endregion
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            #region Mostrar promessas
            this.Promessas();
            #endregion
        }
        #endregion

        
    }
}
