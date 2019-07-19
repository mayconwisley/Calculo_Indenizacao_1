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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroEmpregado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroComplemento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalculo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalculoCalcular = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalculoListaCalculos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorioListarDemonstrativo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusPrincipal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal.SuspendLayout();
            this.statusPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro,
            this.menuCalculo,
            this.menuRelatorio,
            this.menuSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(580, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroEmpregado,
            this.menuCadastroComplemento});
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(66, 20);
            this.menuCadastro.Text = "Cadastro";
            // 
            // menuCadastroEmpregado
            // 
            this.menuCadastroEmpregado.Name = "menuCadastroEmpregado";
            this.menuCadastroEmpregado.Size = new System.Drawing.Size(151, 22);
            this.menuCadastroEmpregado.Text = "Empregado";
            this.menuCadastroEmpregado.Click += new System.EventHandler(this.menuCadastroEmpregado_Click);
            // 
            // menuCadastroComplemento
            // 
            this.menuCadastroComplemento.Name = "menuCadastroComplemento";
            this.menuCadastroComplemento.Size = new System.Drawing.Size(151, 22);
            this.menuCadastroComplemento.Text = "Complemento";
            this.menuCadastroComplemento.Click += new System.EventHandler(this.menuCadastroComplemento_Click);
            // 
            // menuCalculo
            // 
            this.menuCalculo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCalculoCalcular,
            this.menuCalculoListaCalculos});
            this.menuCalculo.Name = "menuCalculo";
            this.menuCalculo.Size = new System.Drawing.Size(59, 20);
            this.menuCalculo.Text = "Calculo";
            // 
            // menuCalculoCalcular
            // 
            this.menuCalculoCalcular.Name = "menuCalculoCalcular";
            this.menuCalculoCalcular.Size = new System.Drawing.Size(162, 22);
            this.menuCalculoCalcular.Text = "Calcular";
            this.menuCalculoCalcular.Click += new System.EventHandler(this.calcularToolStripMenuItem_Click);
            // 
            // menuCalculoListaCalculos
            // 
            this.menuCalculoListaCalculos.Name = "menuCalculoListaCalculos";
            this.menuCalculoListaCalculos.Size = new System.Drawing.Size(162, 22);
            this.menuCalculoListaCalculos.Text = "Lista de Calculos";
            this.menuCalculoListaCalculos.Click += new System.EventHandler(this.listaDeCalculosToolStripMenuItem_Click);
            // 
            // menuRelatorio
            // 
            this.menuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRelatorioListarDemonstrativo});
            this.menuRelatorio.Name = "menuRelatorio";
            this.menuRelatorio.Size = new System.Drawing.Size(66, 20);
            this.menuRelatorio.Text = "Relatório";
            // 
            // menuRelatorioListarDemonstrativo
            // 
            this.menuRelatorioListarDemonstrativo.Name = "menuRelatorioListarDemonstrativo";
            this.menuRelatorioListarDemonstrativo.Size = new System.Drawing.Size(183, 22);
            this.menuRelatorioListarDemonstrativo.Text = "Listar Demonstrativo";
            this.menuRelatorioListarDemonstrativo.Click += new System.EventHandler(this.menuRelatorioListarDemonstrativo_Click);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // statusPrincipal
            // 
            this.statusPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusPrincipal.Location = new System.Drawing.Point(0, 102);
            this.statusPrincipal.Name = "statusPrincipal";
            this.statusPrincipal.Size = new System.Drawing.Size(580, 22);
            this.statusPrincipal.TabIndex = 1;
            this.statusPrincipal.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(209, 17);
            this.toolStripStatusLabel1.Text = "Desenvolvido por: Maycon Wisley v2.0";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(580, 124);
            this.Controls.Add(this.statusPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Calculo Indenização";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.statusPrincipal.ResumeLayout(false);
            this.statusPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuCalculo;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.StatusStrip statusPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroEmpregado;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroComplemento;
        private System.Windows.Forms.ToolStripMenuItem menuCalculoCalcular;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorioListarDemonstrativo;
        private System.Windows.Forms.ToolStripMenuItem menuCalculoListaCalculos;
    }
}

