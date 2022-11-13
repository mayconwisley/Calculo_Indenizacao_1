namespace CalculoIndenizacao
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.MtTlCadastro = new MetroFramework.Controls.MetroTile();
            this.MtTlCalculo = new MetroFramework.Controls.MetroTile();
            this.MtTlRelatorio = new MetroFramework.Controls.MetroTile();
            this.MtTlSair = new MetroFramework.Controls.MetroTile();
            this.MtPnlPrincipal = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // MtTlCadastro
            // 
            this.MtTlCadastro.ActiveControl = null;
            this.MtTlCadastro.Location = new System.Drawing.Point(23, 63);
            this.MtTlCadastro.Name = "MtTlCadastro";
            this.MtTlCadastro.Size = new System.Drawing.Size(126, 98);
            this.MtTlCadastro.TabIndex = 2;
            this.MtTlCadastro.Text = "Cadastro";
            this.MtTlCadastro.UseSelectable = true;
            this.MtTlCadastro.Click += new System.EventHandler(this.MtTlCadastro_Click);
            // 
            // MtTlCalculo
            // 
            this.MtTlCalculo.ActiveControl = null;
            this.MtTlCalculo.Location = new System.Drawing.Point(155, 63);
            this.MtTlCalculo.Name = "MtTlCalculo";
            this.MtTlCalculo.Size = new System.Drawing.Size(126, 98);
            this.MtTlCalculo.TabIndex = 2;
            this.MtTlCalculo.Text = "Calculo";
            this.MtTlCalculo.UseSelectable = true;
            this.MtTlCalculo.Click += new System.EventHandler(this.MtTlCalculo_Click);
            // 
            // MtTlRelatorio
            // 
            this.MtTlRelatorio.ActiveControl = null;
            this.MtTlRelatorio.Location = new System.Drawing.Point(287, 63);
            this.MtTlRelatorio.Name = "MtTlRelatorio";
            this.MtTlRelatorio.Size = new System.Drawing.Size(126, 98);
            this.MtTlRelatorio.TabIndex = 2;
            this.MtTlRelatorio.Text = "Relatório";
            this.MtTlRelatorio.UseSelectable = true;
            this.MtTlRelatorio.Click += new System.EventHandler(this.MtTlRelatorio_Click);
            // 
            // MtTlSair
            // 
            this.MtTlSair.ActiveControl = null;
            this.MtTlSair.Location = new System.Drawing.Point(419, 63);
            this.MtTlSair.Name = "MtTlSair";
            this.MtTlSair.Size = new System.Drawing.Size(126, 98);
            this.MtTlSair.Style = MetroFramework.MetroColorStyle.Red;
            this.MtTlSair.TabIndex = 2;
            this.MtTlSair.Text = "Sair";
            this.MtTlSair.UseSelectable = true;
            this.MtTlSair.Click += new System.EventHandler(this.MtTlSair_Click);
            // 
            // MtPnlPrincipal
            // 
            this.MtPnlPrincipal.HorizontalScrollbarBarColor = true;
            this.MtPnlPrincipal.HorizontalScrollbarHighlightOnWheel = false;
            this.MtPnlPrincipal.HorizontalScrollbarSize = 10;
            this.MtPnlPrincipal.Location = new System.Drawing.Point(23, 167);
            this.MtPnlPrincipal.Name = "MtPnlPrincipal";
            this.MtPnlPrincipal.Size = new System.Drawing.Size(522, 100);
            this.MtPnlPrincipal.TabIndex = 3;
            this.MtPnlPrincipal.VerticalScrollbarBarColor = true;
            this.MtPnlPrincipal.VerticalScrollbarHighlightOnWheel = false;
            this.MtPnlPrincipal.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 279);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(233, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Desenvolvido por: Maycon Wisley v2.0";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(581, 310);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.MtPnlPrincipal);
            this.Controls.Add(this.MtTlSair);
            this.Controls.Add(this.MtTlRelatorio);
            this.Controls.Add(this.MtTlCalculo);
            this.Controls.Add(this.MtTlCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Resizable = false;
            this.Text = "Calculo Indenização";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile MtTlCadastro;
        private MetroFramework.Controls.MetroTile MtTlCalculo;
        private MetroFramework.Controls.MetroTile MtTlRelatorio;
        private MetroFramework.Controls.MetroTile MtTlSair;
        private MetroFramework.Controls.MetroPanel MtPnlPrincipal;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

