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

        public Form1()
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
