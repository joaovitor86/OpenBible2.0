namespace OpenBible2._0
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.painelDeLivros = new System.Windows.Forms.Panel();
            this.lstVersiculos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelVersiculos = new MaterialSkin.Controls.MaterialLabel();
            this.lstCapitulos = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelCapitulos = new MaterialSkin.Controls.MaterialLabel();
            this.lstLivros = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Livro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelLivros = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resBiblia = new System.Windows.Forms.WebBrowser();
            this.labelBiblia = new MaterialSkin.Controls.MaterialLabel();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnAbrirEmNovaJanela = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAbrePesquisa = new System.Windows.Forms.Button();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.painelDeLivros.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelDeLivros
            // 
            this.painelDeLivros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.painelDeLivros.BackColor = System.Drawing.Color.White;
            this.painelDeLivros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelDeLivros.Controls.Add(this.lstVersiculos);
            this.painelDeLivros.Controls.Add(this.labelVersiculos);
            this.painelDeLivros.Controls.Add(this.lstCapitulos);
            this.painelDeLivros.Controls.Add(this.labelCapitulos);
            this.painelDeLivros.Controls.Add(this.lstLivros);
            this.painelDeLivros.Controls.Add(this.labelLivros);
            this.painelDeLivros.Location = new System.Drawing.Point(2, 66);
            this.painelDeLivros.Name = "painelDeLivros";
            this.painelDeLivros.Size = new System.Drawing.Size(229, 532);
            this.painelDeLivros.TabIndex = 0;
            // 
            // lstVersiculos
            // 
            this.lstVersiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVersiculos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstVersiculos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstVersiculos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVersiculos.FullRowSelect = true;
            this.lstVersiculos.GridLines = true;
            this.lstVersiculos.HideSelection = false;
            this.lstVersiculos.Location = new System.Drawing.Point(5, 407);
            this.lstVersiculos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstVersiculos.MultiSelect = false;
            this.lstVersiculos.Name = "lstVersiculos";
            this.lstVersiculos.Size = new System.Drawing.Size(217, 119);
            this.lstVersiculos.TabIndex = 5;
            this.lstVersiculos.UseCompatibleStateImageBehavior = false;
            this.lstVersiculos.Click += new System.EventHandler(this.lstVersiculos_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Versículo";
            this.columnHeader1.Width = 150;
            // 
            // labelVersiculos
            // 
            this.labelVersiculos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersiculos.BackColor = System.Drawing.SystemColors.Control;
            this.labelVersiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVersiculos.Depth = 0;
            this.labelVersiculos.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelVersiculos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelVersiculos.Location = new System.Drawing.Point(5, 371);
            this.labelVersiculos.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelVersiculos.Name = "labelVersiculos";
            this.labelVersiculos.Padding = new System.Windows.Forms.Padding(4, 7, 7, 4);
            this.labelVersiculos.Size = new System.Drawing.Size(217, 35);
            this.labelVersiculos.TabIndex = 4;
            this.labelVersiculos.Text = "Versículos";
            // 
            // lstCapitulos
            // 
            this.lstCapitulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCapitulos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstCapitulos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.lstCapitulos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCapitulos.FullRowSelect = true;
            this.lstCapitulos.GridLines = true;
            this.lstCapitulos.HideSelection = false;
            this.lstCapitulos.Location = new System.Drawing.Point(5, 223);
            this.lstCapitulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCapitulos.MultiSelect = false;
            this.lstCapitulos.Name = "lstCapitulos";
            this.lstCapitulos.Size = new System.Drawing.Size(217, 144);
            this.lstCapitulos.TabIndex = 3;
            this.lstCapitulos.UseCompatibleStateImageBehavior = false;
            this.lstCapitulos.Click += new System.EventHandler(this.lstCapitulos_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Capítulo";
            this.columnHeader5.Width = 150;
            // 
            // labelCapitulos
            // 
            this.labelCapitulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCapitulos.BackColor = System.Drawing.SystemColors.Control;
            this.labelCapitulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCapitulos.Depth = 0;
            this.labelCapitulos.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCapitulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCapitulos.Location = new System.Drawing.Point(5, 187);
            this.labelCapitulos.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCapitulos.Name = "labelCapitulos";
            this.labelCapitulos.Padding = new System.Windows.Forms.Padding(4, 7, 7, 4);
            this.labelCapitulos.Size = new System.Drawing.Size(217, 35);
            this.labelCapitulos.TabIndex = 2;
            this.labelCapitulos.Text = "Capítulos";
            // 
            // lstLivros
            // 
            this.lstLivros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLivros.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstLivros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.Livro});
            this.lstLivros.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLivros.FullRowSelect = true;
            this.lstLivros.GridLines = true;
            this.lstLivros.HideSelection = false;
            this.lstLivros.Location = new System.Drawing.Point(5, 39);
            this.lstLivros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstLivros.MultiSelect = false;
            this.lstLivros.Name = "lstLivros";
            this.lstLivros.Size = new System.Drawing.Size(217, 144);
            this.lstLivros.TabIndex = 1;
            this.lstLivros.UseCompatibleStateImageBehavior = false;
            this.lstLivros.View = System.Windows.Forms.View.Details;
            this.lstLivros.Click += new System.EventHandler(this.lstLivros_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "#";
            this.columnHeader2.Width = 30;
            // 
            // Livro
            // 
            this.Livro.Text = "Livro";
            this.Livro.Width = 150;
            // 
            // labelLivros
            // 
            this.labelLivros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLivros.BackColor = System.Drawing.SystemColors.Control;
            this.labelLivros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLivros.Depth = 0;
            this.labelLivros.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelLivros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelLivros.Location = new System.Drawing.Point(5, 3);
            this.labelLivros.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelLivros.Name = "labelLivros";
            this.labelLivros.Padding = new System.Windows.Forms.Padding(4, 7, 7, 4);
            this.labelLivros.Size = new System.Drawing.Size(217, 35);
            this.labelLivros.TabIndex = 0;
            this.labelLivros.Text = "Livros";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.resBiblia);
            this.panel1.Controls.Add(this.labelBiblia);
            this.panel1.Location = new System.Drawing.Point(237, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 532);
            this.panel1.TabIndex = 1;
            // 
            // resBiblia
            // 
            this.resBiblia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resBiblia.Location = new System.Drawing.Point(5, 41);
            this.resBiblia.MinimumSize = new System.Drawing.Size(20, 20);
            this.resBiblia.Name = "resBiblia";
            this.resBiblia.ScriptErrorsSuppressed = true;
            this.resBiblia.Size = new System.Drawing.Size(647, 485);
            this.resBiblia.TabIndex = 2;
            this.resBiblia.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // labelBiblia
            // 
            this.labelBiblia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBiblia.BackColor = System.Drawing.SystemColors.Control;
            this.labelBiblia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBiblia.Depth = 0;
            this.labelBiblia.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelBiblia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBiblia.Location = new System.Drawing.Point(3, 3);
            this.labelBiblia.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBiblia.Name = "labelBiblia";
            this.labelBiblia.Padding = new System.Windows.Forms.Padding(4, 7, 7, 4);
            this.labelBiblia.Size = new System.Drawing.Size(651, 35);
            this.labelBiblia.TabIndex = 1;
            this.labelBiblia.Text = "Bíblia";
            // 
            // btnSobre
            // 
            this.btnSobre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.Image = global::OpenBible2._0.Properties.Resources.help;
            this.btnSobre.Location = new System.Drawing.Point(869, 29);
            this.btnSobre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(28, 30);
            this.btnSobre.TabIndex = 16;
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnAbrirEmNovaJanela
            // 
            this.btnAbrirEmNovaJanela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirEmNovaJanela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirEmNovaJanela.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirEmNovaJanela.Image = global::OpenBible2._0.Properties.Resources.application_go;
            this.btnAbrirEmNovaJanela.Location = new System.Drawing.Point(842, 29);
            this.btnAbrirEmNovaJanela.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAbrirEmNovaJanela.Name = "btnAbrirEmNovaJanela";
            this.btnAbrirEmNovaJanela.Size = new System.Drawing.Size(28, 30);
            this.btnAbrirEmNovaJanela.TabIndex = 15;
            this.btnAbrirEmNovaJanela.UseVisualStyleBackColor = true;
            this.btnAbrirEmNovaJanela.Click += new System.EventHandler(this.btnAbrirEmNovaJanela_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = global::OpenBible2._0.Properties.Resources.printer2;
            this.btnImprimir.Location = new System.Drawing.Point(815, 29);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(28, 30);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAbrePesquisa
            // 
            this.btnAbrePesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrePesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrePesquisa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrePesquisa.Image = global::OpenBible2._0.Properties.Resources.find;
            this.btnAbrePesquisa.Location = new System.Drawing.Point(788, 29);
            this.btnAbrePesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAbrePesquisa.Name = "btnAbrePesquisa";
            this.btnAbrePesquisa.Size = new System.Drawing.Size(28, 30);
            this.btnAbrePesquisa.TabIndex = 13;
            this.btnAbrePesquisa.UseVisualStyleBackColor = true;
            this.btnAbrePesquisa.Click += new System.EventHandler(this.btnAbrePesquisa_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAleatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAleatorio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAleatorio.Image = global::OpenBible2._0.Properties.Resources.page_refresh;
            this.btnAleatorio.Location = new System.Drawing.Point(761, 29);
            this.btnAleatorio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(28, 30);
            this.btnAleatorio.TabIndex = 14;
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnAbrirEmNovaJanela);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAbrePesquisa);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.painelDeLivros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(237, 600);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenBible 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.painelDeLivros.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelDeLivros;
        private MaterialSkin.Controls.MaterialLabel labelLivros;
        private System.Windows.Forms.ListView lstLivros;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader Livro;
        private System.Windows.Forms.ListView lstCapitulos;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialLabel labelCapitulos;
        private System.Windows.Forms.ListView lstVersiculos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialLabel labelVersiculos;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel labelBiblia;
        private System.Windows.Forms.WebBrowser resBiblia;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAbrePesquisa;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.Button btnAbrirEmNovaJanela;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

