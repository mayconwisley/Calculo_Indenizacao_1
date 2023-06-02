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
            this.label1.Location = new System.Drawing.Point(8, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empregado";
            // 
            // cbxEmpregado
            // 
            this.cbxEmpregado.DisplayMember = "Nome";
            this.cbxEmpregado.FormattingEnabled = true;
            this.cbxEmpregado.Location = new System.Drawing.Point(11, 76);
            this.cbxEmpregado.Name = "cbxEmpregado";
            this.cbxEmpregado.Size = new System.Drawing.Size(294, 21);
            this.cbxEmpregado.TabIndex = 1;
            this.cbxEmpregado.ValueMember = "Id";
            this.cbxEmpregado.SelectedIndexChanged += new System.EventHandler(this.CbxEmpregado_SelectedIndexChanged);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(311, 76);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // cbxValorTotal
            // 
            this.cbxValorTotal.DisplayMember = "Valor_Total";
            this.cbxValorTotal.FormatString = "N2";
            this.cbxValorTotal.FormattingEnabled = true;
            this.cbxValorTotal.Location = new System.Drawing.Point(11, 115);
            this.cbxValorTotal.Margin = new System.Windows.Forms.Padding(2);
            this.cbxValorTotal.Name = "cbxValorTotal";
            this.cbxValorTotal.Size = new System.Drawing.Size(129, 21);
            this.cbxValorTotal.TabIndex = 5;
            this.cbxValorTotal.ValueMember = "Id";
            this.cbxValorTotal.SelectedIndexChanged += new System.EventHandler(this.CbxValorTotal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor Total";
            // 
            // FrmListaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 158);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxValorTotal);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.cbxEmpregado);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListaRelatorio";
            this.Resizable = false;
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