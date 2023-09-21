namespace CalculoIndenizacao
{
    partial class FrmVisualizarRelatorio
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
            // TODO Microsoft.Reporting.WinForms.ReportViewer no longer supported.
            this.RvVisualizarRelatorio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RvVisualizarRelatorio
            // 
            this.RvVisualizarRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RvVisualizarRelatorio.Location = new System.Drawing.Point(0, 0);
            this.RvVisualizarRelatorio.Name = "RvVisualizarRelatorio";
            this.RvVisualizarRelatorio.ServerReport.BearerToken = null;
            this.RvVisualizarRelatorio.ShowFindControls = false;
            this.RvVisualizarRelatorio.ShowRefreshButton = false;
            this.RvVisualizarRelatorio.ShowStopButton = false;
            this.RvVisualizarRelatorio.Size = new System.Drawing.Size(906, 535);
            this.RvVisualizarRelatorio.TabIndex = 0;
            // 
            // FrmVisualizarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 535);
            this.Controls.Add(this.RvVisualizarRelatorio);
            this.Name = "FrmVisualizarRelatorio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Relatório";
            this.Load += new System.EventHandler(this.FrmVisualizarRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        // TODO Microsoft.Reporting.WinForms.ReportViewer no longer supported.
                private Microsoft.Reporting.WinForms.ReportViewer RvVisualizarRelatorio;
    }
}