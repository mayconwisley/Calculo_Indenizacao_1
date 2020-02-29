namespace CalculoIndenizacao
{
    partial class UCRelatorio
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
            this.MtTlListarDemons = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // MtTlListarDemons
            // 
            this.MtTlListarDemons.ActiveControl = null;
            this.MtTlListarDemons.Location = new System.Drawing.Point(3, 3);
            this.MtTlListarDemons.Name = "MtTlListarDemons";
            this.MtTlListarDemons.Size = new System.Drawing.Size(163, 98);
            this.MtTlListarDemons.TabIndex = 0;
            this.MtTlListarDemons.Text = "Listar Demonstrativos";
            this.MtTlListarDemons.UseSelectable = true;
            this.MtTlListarDemons.Click += new System.EventHandler(this.MtTlListarDemons_Click);
            // 
            // UCRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MtTlListarDemons);
            this.Name = "UCRelatorio";
            this.Size = new System.Drawing.Size(172, 111);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile MtTlListarDemons;
    }
}
