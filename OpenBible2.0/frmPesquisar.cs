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
