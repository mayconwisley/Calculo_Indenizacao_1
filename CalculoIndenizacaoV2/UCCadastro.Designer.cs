namespace CalculoIndenizacao
{
    partial class UCCadastro
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MtTlCadEmpregado = new MetroFramework.Controls.MetroTile();
            this.MtTlCadComplemento = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // MtTlCadEmpregado
            // 
            this.MtTlCadEmpregado.ActiveControl = null;
            this.MtTlCadEmpregado.Location = new System.Drawing.Point(3, 3);
            this.MtTlCadEmpregado.Name = "MtTlCadEmpregado";
            this.MtTlCadEmpregado.Size = new System.Drawing.Size(136, 98);
            this.MtTlCadEmpregado.TabIndex = 0;
            this.MtTlCadEmpregado.Text = "Empregado";
            this.MtTlCadEmpregado.UseSelectable = true;
            this.MtTlCadEmpregado.Click += new System.EventHandler(this.MtTlCadEmpregado_Click);
            // 
            // MtTlCadComplemento
            // 
            this.MtTlCadComplemento.ActiveControl = null;
            this.MtTlCadComplemento.Location = new System.Drawing.Point(145, 3);
            this.MtTlCadComplemento.Name = "MtTlCadComplemento";
            this.MtTlCadComplemento.Size = new System.Drawing.Size(136, 98);
            this.MtTlCadComplemento.TabIndex = 0;
            this.MtTlCadComplemento.Text = "Complemento";
            this.MtTlCadComplemento.UseSelectable = true;
            this.MtTlCadComplemento.Click += new System.EventHandler(this.MtTlCadComplemento_Click);
            // 
            // UCCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MtTlCadComplemento);
            this.Controls.Add(this.MtTlCadEmpregado);
            this.Name = "UCCadastro";
            this.Size = new System.Drawing.Size(288, 109);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile MtTlCadEmpregado;
        private MetroFramework.Controls.MetroTile MtTlCadComplemento;
    }
}
