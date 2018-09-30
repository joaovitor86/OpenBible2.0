namespace OpenBible2._0
{
    partial class frmPesquisar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisar));
            this.btnFechar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExibir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPesquisa = new MaterialSkin.Controls.MaterialLabel();
            this.txtPesquisa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTotalResultados = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resBiblia = new System.Windows.Forms.WebBrowser();
            this.labelBiblia = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Depth = 0;
            this.btnFechar.Location = new System.Drawing.Point(582, 272);
            this.btnFechar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Primary = true;
            this.btnFechar.Size = new System.Drawing.Size(100, 43);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Depth = 0;
            this.btnExibir.Location = new System.Drawing.Point(688, 272);
            this.btnExibir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Primary = true;
            this.btnExibir.Size = new System.Drawing.Size(100, 43);
            this.btnExibir.TabIndex = 3;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column2});
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.Location = new System.Drawing.Point(12, 106);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(776, 160);
            this.dgvDados.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Livro";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Capitulo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Versiculo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Descrição";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.lblPesquisa.Depth = 0;
            this.lblPesquisa.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPesquisa.Location = new System.Drawing.Point(12, 75);
            this.lblPesquisa.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(71, 19);
            this.lblPesquisa.TabIndex = 5;
            this.lblPesquisa.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.txtPesquisa.Depth = 0;
            this.txtPesquisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPesquisa.Hint = "";
            this.txtPesquisa.Location = new System.Drawing.Point(89, 75);
            this.txtPesquisa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.Size = new System.Drawing.Size(699, 23);
            this.txtPesquisa.TabIndex = 6;
            this.txtPesquisa.UseSystemPasswordChar = false;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // lblTotalResultados
            // 
            this.lblTotalResultados.AutoSize = true;
            this.lblTotalResultados.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalResultados.Depth = 0;
            this.lblTotalResultados.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalResultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalResultados.Location = new System.Drawing.Point(12, 272);
            this.lblTotalResultados.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalResultados.Name = "lblTotalResultados";
            this.lblTotalResultados.Size = new System.Drawing.Size(140, 19);
            this.lblTotalResultados.TabIndex = 7;
            this.lblTotalResultados.Text = "Total encontrado: 0";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.resBiblia);
            this.panel1.Controls.Add(this.labelBiblia);
            this.panel1.Location = new System.Drawing.Point(12, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 204);
            this.panel1.TabIndex = 8;
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
            this.resBiblia.Size = new System.Drawing.Size(766, 159);
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
            this.labelBiblia.Size = new System.Drawing.Size(770, 35);
            this.labelBiblia.TabIndex = 1;
            this.labelBiblia.Text = "Bíblia";
            // 
            // frmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotalResultados);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnFechar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pesquisar na bíblia";
            this.Load += new System.EventHandler(this.frmPesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnFechar;
        private MaterialSkin.Controls.MaterialRaisedButton btnExibir;
        private System.Windows.Forms.DataGridView dgvDados;
        private MaterialSkin.Controls.MaterialLabel lblPesquisa;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesquisa;
        private MaterialSkin.Controls.MaterialLabel lblTotalResultados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser resBiblia;
        private MaterialSkin.Controls.MaterialLabel labelBiblia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}