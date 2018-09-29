namespace OpenBible2._0
{
    partial class frmNovaJanela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovaJanela));
            this.painelBiblia = new System.Windows.Forms.Panel();
            this.resBiblia = new System.Windows.Forms.WebBrowser();
            this.labelBiblia = new MaterialSkin.Controls.MaterialLabel();
            this.painelBiblia.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelBiblia
            // 
            this.painelBiblia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelBiblia.BackColor = System.Drawing.Color.White;
            this.painelBiblia.Controls.Add(this.resBiblia);
            this.painelBiblia.Controls.Add(this.labelBiblia);
            this.painelBiblia.Location = new System.Drawing.Point(4, 66);
            this.painelBiblia.Name = "painelBiblia";
            this.painelBiblia.Size = new System.Drawing.Size(793, 530);
            this.painelBiblia.TabIndex = 2;
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
            this.resBiblia.Size = new System.Drawing.Size(783, 485);
            this.resBiblia.TabIndex = 2;
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
            this.labelBiblia.Size = new System.Drawing.Size(787, 35);
            this.labelBiblia.TabIndex = 1;
            this.labelBiblia.Text = "Bíblia";
            // 
            // frmNovaJanela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.painelBiblia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNovaJanela";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenBible 2.0";
            this.Load += new System.EventHandler(this.frmNovaJanela_Load);
            this.painelBiblia.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelBiblia;
        private System.Windows.Forms.WebBrowser resBiblia;
        private MaterialSkin.Controls.MaterialLabel labelBiblia;
    }
}