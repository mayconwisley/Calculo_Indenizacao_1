namespace CalculoIndenizacao
{
    partial class UcCalculo
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
            this.MtTlCalCalcular = new MetroFramework.Controls.MetroTile();
            this.MtTlCalListCalculo = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // MtTlCalCalcular
            // 
            this.MtTlCalCalcular.ActiveControl = null;
            this.MtTlCalCalcular.Location = new System.Drawing.Point(3, 3);
            this.MtTlCalCalcular.Name = "MtTlCalCalcular";
            this.MtTlCalCalcular.Size = new System.Drawing.Size(143, 98);
            this.MtTlCalCalcular.TabIndex = 0;
            this.MtTlCalCalcular.Text = "Calcular";
            this.MtTlCalCalcular.UseSelectable = true;
            this.MtTlCalCalcular.Click += new System.EventHandler(this.MtTlCalCalcular_Click);
            // 
            // MtTlCalListCalculo
            // 
            this.MtTlCalListCalculo.ActiveControl = null;
            this.MtTlCalListCalculo.Location = new System.Drawing.Point(152, 3);
            this.MtTlCalListCalculo.Name = "MtTlCalListCalculo";
            this.MtTlCalListCalculo.Size = new System.Drawing.Size(143, 98);
            this.MtTlCalListCalculo.TabIndex = 0;
            this.MtTlCalListCalculo.Text = "Lista de Calculos";
            this.MtTlCalListCalculo.UseSelectable = true;
            this.MtTlCalListCalculo.Click += new System.EventHandler(this.MtTlCalListCalculo_Click);
            // 
            // UcCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MtTlCalListCalculo);
            this.Controls.Add(this.MtTlCalCalcular);
            this.Name = "UcCalculo";
            this.Size = new System.Drawing.Size(301, 110);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile MtTlCalCalcular;
        private MetroFramework.Controls.MetroTile MtTlCalListCalculo;
    }
}
