using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenBible2._0
{
    class OpenBiblieFunctions
    {
        #region Declarações
        AccessDB _access = new AccessDB();
        #endregion

        #region Métodos Públicos da Classe
        /// <summary>
        /// Método para preencher o listview (lstLivros) com os nomes dos livros da bíblia
        /// </summary>
        /// <param name="lstLivros"></param>
        public void PreencheLivros(ListView lstLivros)
        {
            string _SQL = "SELECT * FROM Livros ORDER BY Livro ASC";
            DataTable _DT = _access.getDados(_SQL);
            lstLivros.Items.Clear();
            for (int i = 0; i < _DT.Rows.Count; i++)
            {
                DataRow _DR = _DT.Rows[i];
                ListViewItem _LVI = new ListViewItem(_DR["Livro"].ToString());
                _LVI.SubItems.Add(_DR["Descricao"].ToString());
                lstLivros.Items.Add(_LVI);
            }
        }

        /// <summary>
        /// Método para preencher o listview (lstCapitulos) com os capítulos do livro que foi previamente selecionado
        /// Deve ser enviado para chamar esse método, o livro escolhido via parâmetro
        /// </summary>
        /// <param name="livro"></param>
        /// <param name="lstCapitulos"></param>
        public void PreencheCapitulos(string livro, ListView lstCapitulos)
        {
            string _SQL = "SELECT Capitulo FROM Versiculos WHERE Livro=" + livro + " GROUP BY Capitulo ORDER BY VAL(Capitulo), Capitulo";
            DataTable _DT = _access.getDados(_SQL);
            lstCapitulos.Items.Clear();
            for (int i = 0; i < _DT.Rows.Count; i++)
            {
                DataRow _DR = _DT.Rows[i];
                ListViewItem _LVI = new ListViewItem(_DR["Capitulo"].ToString());
                lstCapitulos.Items.Add(_LVI);
            }
        }

        /// <summary>
        /// Método para preencher o listview (lstVersiculos) com os versículos do capítulo do livro que foi selecionado previamente
        /// Necessário preencher o Livro e o Capítulo
        /// </summary>
        /// <param name="livro"></param>
        /// <param name="capitulo"></param>
        /// <param name="lstVersiculos"></param>
        public void PreencheVersiculos(string livro, string capitulo, ListView lstVersiculos)
        {
            string _SQL = "SELECT Versiculo FROM Versiculos WHERE Livro=" + livro + " AND Capitulo=" + capitulo + " ORDER BY Versiculo ASC";
            DataTable _DT = _access.getDados(_SQL);
            lstVersiculos.Items.Clear();
            for (int i = 0; i < _DT.Rows.Count; i++)
            {
                DataRow _DR = _DT.Rows[i];
                ListViewItem _LVI = new ListViewItem(_DR["Versiculo"].ToString());
                lstVersiculos.Items.Add(_LVI);
            }
        }
        /// <summary>
        /// Método para exibir o texto em questão
        /// </summary>
        /// <param name="iLivro">(int) ID do livro</param>
        /// <param name="iCapitulo">(int) ID do capítulo</param>
        /// <param name="iVersiculo">(int) ID do versículo</param>
        /// <param name="_NOME_LIVRO">(string) Nome do livro</param>
        /// <param name="_CAPITULO">(string) Nome do capítulo</param>
        /// <param name="show_somente_versiculo">(bool) Mostra somente o versículo ou todo o texto do capítulo (true|false)</param>
        /// <param name="resBiblia">(WebBrowser) Controle onde será exibido o texto</param>
        public void ExibeTextoBiblico(string iLivro, string iCapitulo, string iVersiculo, string _NOME_LIVRO, string _CAPITULO, bool show_somente_versiculo, WebBrowser resBiblia)
        {
            string _SQL = string.Empty;

            if (show_somente_versiculo == false)
            {
                _SQL = "SELECT Versiculo,Descricao FROM Versiculos WHERE Livro=" + iLivro + " AND Capitulo=" + iCapitulo + "";
            }
            else
            {
                _SQL = "SELECT Versiculo,Descricao FROM Versiculos WHERE Livro=" + iLivro + " AND Capitulo=" + iCapitulo + " AND Versiculo=" + iVersiculo + "";
            }

            DataTable _DT = _access.getDados(_SQL);
            resBiblia.DocumentText = "";
            resBiblia.Document.OpenNew(true);
            resBiblia.Document.Write(this.TemplateTexto(_NOME_LIVRO, _CAPITULO, _DT));
            resBiblia.Refresh();
        }
        /// <summary>
        /// Método para realizar uma pesquisa na bíblia através de um parâmetro de texto
        /// </summary>
        /// <param name="_PESQUISA">Conteúdo à ser pesquisado</param>
        /// <param name="dgvDados">Controle do form datagridview</param>
        /// <returns>Total de linhas encontradas</returns>
        public int PesquisaBiblica(String _PESQUISA, DataGridView dgvDados)
        {
            string _SQL = "SELECT * FROM Versiculos WHERE Descricao LIKE '%" + _PESQUISA + "%'";
            DataTable _DT = _access.getDados(_SQL);
            dgvDados.Rows.Clear();

            int _i = 1;
            foreach (DataRow _ROW in _DT.Rows)
            {
                dgvDados.Rows.Add(_i.ToString(), _ROW["Livro"], _ROW["Capitulo"], _ROW["Versiculo"], _ROW["Descricao"]);
                _i++;
            }

            return _i - 1;
        }
        /// <summary>
        /// Mostra a caixa de promessas
        /// </summary>
        /// <param name="_HEADER"></param>
        /// <param name="_BODY"></param>
        /// <returns></returns>
        public string CaixaPromessas(string _HEADER, string _BODY)
        {
            return this.TemplatePromessas(_HEADER, _BODY);
        }
        #endregion

        #region Métodos Privados da Classe
        /// <summary>
        /// Template do texto bíblico à ser exibido
        /// </summary>
        /// <param name="_NOME_LIVRO">Nome do livro em questão</param>
        /// <param name="_CAPITULO">O capítulo selecionado do livro em questão</param>
        /// <param name="_DT">DataTable contendo os dados à serem percorridos</param>
        /// <returns>O texto completo formatado + HTML</returns>
        private string TemplateTexto(string _NOME_LIVRO, string _CAPITULO, DataTable _DT)
        {
            #region Template do que é exibido
            // Header do HTML
            string header = @"
                <!DOCTYPE html>
                <head>
                    <meta charset=""utf-8"">
                    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
                    <title></title>
                    <meta name=""description"" content="""">
                    <meta name=""viewport"" content=""width=device-width"">
                    <link href=""https://stackpath.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u"" crossorigin=""anonymous"">
                    <link href=""https://fonts.googleapis.com/css?family=Roboto"" rel=""stylesheet"">
                    <style>
                    *{font-family: 'Roboto', sans-serif;}
                    body{padding:10px;}
                    </style>
                </head>      
                <body>";

            // BreadCrumb com o nome e o capítulo do livro
            string breadcrumb = "<ol class=\"breadcrumb\"><li><a href=\"javascript:void(0);\"><strong>Bíblia</strong></a></li><li><a href=\"javascript:void(0);\"><strong>" + _NOME_LIVRO + "</strong></a></li><li class=\"active\"><strong>" + _CAPITULO + "</strong></li></ol>";

            // Body do texto, isso completa toda a exibição do livro em si
            string body = string.Empty;
            foreach (DataRow _ROW in _DT.Rows)
            {
                body += "<p><span class=\"label label-warning\">" + _ROW["Versiculo"].ToString() + "</span> &minus; " + _ROW["Descricao"].ToString() + "</p>";
            }

            // Final da exibição
            string footer = @"
                <script src=""https://stackpath.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"" integrity=""sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa"" crossorigin=""anonymous""></script>
                </body>
                </html>";

            // Retorna todo o texto formatado
            //return header + breadcrumb + body.Replace("Deus", "<!--span class=\"label label-default\"--><a class=\"label label-default\" target=\"_new\" href=\"https://pt.wikipedia.org/wiki/Deus\">DEUS</a><!--/span-->").Replace("Jesus", "<!--span class=\"label label-default\"--><a class=\"label label-default\" target=\"_new\" href=\"https://pt.wikipedia.org/wiki/Jesus\">JESUS</a><!--/span-->").Replace("Cristo", "<!--span class=\"label label-default\"--><a class=\"label label-default\" target=\"_new\" href=\"https://pt.wikipedia.org/wiki/Cristo\">CRISTO</a><!--/span>--") + footer;
            return header + breadcrumb + body + footer;
            #endregion
        }
        /// <summary>
        /// Template da caixa de promessas
        /// </summary>
        /// <param name="_header">texto do header</param>
        /// <param name="_texto">texto do body</param>
        /// <returns>texto formatado</returns>
        private string TemplatePromessas(string _header, string _texto)
        {
            #region Template do que é exibido
            // Header do HTML
            string header = @"
                <!DOCTYPE html>
                <head>
                    <meta charset=""utf-8"">
                    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
                    <title></title>
                    <meta name=""description"" content="""">
                    <meta name=""viewport"" content=""width=device-width"">
                    <link href=""https://stackpath.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u"" crossorigin=""anonymous"">
                    <link href=""https://fonts.googleapis.com/css?family=Roboto"" rel=""stylesheet"">
                    <style>
                    *{font-family: 'Roboto', sans-serif;}
                    body{padding:10px;}
                    </style>
                </head>      
                <body>";

            // Body do texto, isso completa toda a exibição do livro em si
            string body = "<div class=\"jumbotron\">" +
                              "<div class=\"container\">" +
                                "<span class=\"label label-default\">Promessas</span>" + 
                                "<h1>" + _header + "</h1>" +
                                "<p>" + _texto + "</p>" + 
                              "</div>" +
                          "</div>";

            // Final da exibição
            string footer = @"
                <script src=""https://stackpath.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"" integrity=""sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa"" crossorigin=""anonymous""></script>
                </body>
                </html>";

            // Retorna todo o texto formatado
            return header + body + footer;
            #endregion
        }
        #endregion
    }
}