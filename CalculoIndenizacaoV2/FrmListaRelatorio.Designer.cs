namespace CalculoIndenizacao
{
    partial class FrmListaRelatorio
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEmpregado = new System.Windows.Forms.ComboBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.cbxValorTotal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empregado";
            // 
            // cbxEmpregado
            // 
            this.cbxEmpregado.DisplayMember = "Nome";
            this.cbxEmpregado.FormattingEnabled = true;
            this.cbxEmpregado.Location = new System.Drawing.Point(20, 31);
            this.cbxEmpregado.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEmpregado.Name = "cbxEmpregado";
            this.cbxEmpregado.Size = new System.Drawing.Size(391, 24);
            this.cbxEmpregado.TabIndex = 1;
            this.cbxEmpregado.ValueMember = "Id";
            this.cbxEmpregado.SelectedIndexChanged += new System.EventHandler(this.cbxEmpregado_SelectedIndexChanged);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(420, 31);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(100, 28);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // cbxValorTotal
            // 
            this.cbxValorTotal.DisplayMember = "Valor_Total";
            this.cbxValorTotal.FormatString = "N2";
            this.cbxValorTotal.FormattingEnabled = true;
            this.cbxValorTotal.Location = new System.Drawing.Point(20, 79);
            this.cbxValorTotal.Name = "cbxValorTotal";
            this.cbxValorTotal.Size = new System.Drawing.Size(171, 24);
            this.cbxValorTotal.TabIndex = 5;
            this.cbxValorTotal.ValueMember = "Id";
            this.cbxValorTotal.SelectedIndexChanged += new System.EventHandler(this.cbxValorTotal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor Total";
            // 
            // FrmListaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 116);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxValorTotal);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.cbxEmpregado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmListaRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Relatório Demonstrativo";
            this.Load += new System.EventHandler(this.FrmListaRelatorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEmpregado;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.ComboBox cbxValorTotal;
        private System.Windows.Forms.Label label2;
    }
}