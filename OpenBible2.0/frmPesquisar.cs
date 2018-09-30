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
    public partial class frmPesquisar : MaterialForm
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
        string _LIVRO = "1";
        string _CAPITULO = "1";
        string _VERSICULO = "1";
        string _NOME_LIVRO = "Genesis";
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

        public frmPesquisar()
        {
            InitializeComponent();

            #region Skin manager do form
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey50, Accent.LightBlue200, TextShade.WHITE);
            #endregion
        }

        private void frmPesquisar_Load(object sender, EventArgs e)
        {
            #region Seta as cores personalizadas
            this.labelBiblia.BackColor = Cor1;
            #endregion
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            #region Pesquisar
            if(txtPesquisa.Text.Length >= 2)
            {
                this.Cursor = Cursors.WaitCursor;
                lblTotalResultados.Text = String.Format("Total encontrado: {0}", _functions.PesquisaBiblica(txtPesquisa.Text, dgvDados));
                this.Cursor = Cursors.Default;
            }
            #endregion
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            #region Exibir o conteúdo selecionado ou pesquisado
            try
            {
                DataGridViewRow _ROW = dgvDados.SelectedRows[0];
                object id = _ROW.Cells[0].Value;
                object Livro = _ROW.Cells[1].Value;
                object Capitulo = _ROW.Cells[2].Value;
                object Versiculo = _ROW.Cells[3].Value;
                object Descricao = _ROW.Cells[4].Value;

                // Pega o nome do livro
                string _SQL_LIVRO = "SELECT Descricao FROM Livros WHERE Livro=" + Livro + "";
                DataTable _DT_LIVRO = _access.getDados(_SQL_LIVRO);
                foreach (DataRow _ROW_LIVRO in _DT_LIVRO.Rows)
                {
                    _NOME_LIVRO = _ROW_LIVRO["Descricao"].ToString();
                }

                // Pega o capítulo
                string _SQL_CAPITULO = "SELECT Capitulo FROM Versiculos WHERE Livro=" + Livro + " AND Capitulo=" + Capitulo + "";
                DataTable _DT_CAPITULO = _access.getDados(_SQL_CAPITULO);
                foreach (DataRow _ROW_CAPITULO in _DT_CAPITULO.Rows)
                {
                    _CAPITULO = _ROW_CAPITULO["Capitulo"].ToString();
                }

                Form1 frm1 = new Form1();
                _functions.ExibeTextoBiblico(Livro.ToString(), Capitulo.ToString(), Versiculo.ToString(), _NOME_LIVRO, _CAPITULO, true, resBiblia);
            }
            catch { }
            #endregion
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            #region Fecha o Form
            this.Dispose();
            this.Close();
            #endregion
        }
    }
}
