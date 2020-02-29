namespace CalculoIndenizacao
{
    partial class FrmCadastroEmpragado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MktAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MktDemissao = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMedia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDiasBase = new System.Windows.Forms.TextBox();
            this.dgvListaEmpregado = new System.Windows.Forms.DataGridView();
            this.IdEmpregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatriculaEmpregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEmpregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdmissaoEmpregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemissaoEmpregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MediaEmpregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseEmpregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGravar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpregado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMatricula.Location = new System.Drawing.Point(21, 94);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(76, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // TxtNome
            // 
            this.TxtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNome.Location = new System.Drawing.Point(103, 94);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(304, 20);
            this.TxtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Admissão";
            // 
            // MktAdmissao
            // 
            this.MktAdmissao.Location = new System.Drawing.Point(21, 147);
            this.MktAdmissao.Mask = "00/00/0000";
            this.MktAdmissao.Name = "MktAdmissao";
            this.MktAdmissao.Size = new System.Drawing.Size(76, 20);
            this.MktAdmissao.TabIndex = 3;
            this.MktAdmissao.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Demissão";
            // 
            // MktDemissao
            // 
            this.MktDemissao.Location = new System.Drawing.Point(103, 147);
            this.MktDemissao.Mask = "00/00/0000";
            this.MktDemissao.Name = "MktDemissao";
            this.MktDemissao.Size = new System.Drawing.Size(76, 20);
            this.MktDemissao.TabIndex = 4;
            this.MktDemissao.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Media";
            // 
            // TxtMedia
            // 
            this.TxtMedia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMedia.Location = new System.Drawing.Point(193, 147);
            this.TxtMedia.Name = "TxtMedia";
            this.TxtMedia.Size = new System.Drawing.Size(84, 20);
            this.TxtMedia.TabIndex = 5;
            this.TxtMedia.Text = "0,00";
            this.TxtMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtMedia.TextChanged += new System.EventHandler(this.TxtMedia_TextChanged);
            this.TxtMedia.Enter += new System.EventHandler(this.TxtMedia_Enter);
            this.TxtMedia.Leave += new System.EventHandler(this.TxtMedia_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dias Base";
            // 
            // TxtDiasBase
            // 
            this.TxtDiasBase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDiasBase.Location = new System.Drawing.Point(283, 147);
            this.TxtDiasBase.Name = "TxtDiasBase";
            this.TxtDiasBase.Size = new System.Drawing.Size(52, 20);
            this.TxtDiasBase.TabIndex = 6;
            this.TxtDiasBase.Text = "30";
            this.TxtDiasBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvListaEmpregado
            // 
            this.dgvListaEmpregado.AllowUserToAddRows = false;
            this.dgvListaEmpregado.AllowUserToDeleteRows = false;
            this.dgvListaEmpregado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListaEmpregado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListaEmpregado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEmpregado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpregado,
            this.MatriculaEmpregado,
            this.NomeEmpregado,
            this.AdmissaoEmpregado,
            this.DemissaoEmpregado,
            this.MediaEmpregado,
            this.BaseEmpregado});
            this.dgvListaEmpregado.Location = new System.Drawing.Point(18, 198);
            this.dgvListaEmpregado.MultiSelect = false;
            this.dgvListaEmpregado.Name = "dgvListaEmpregado";
            this.dgvListaEmpregado.ReadOnly = true;
            this.dgvListaEmpregado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaEmpregado.Size = new System.Drawing.Size(470, 174);
            this.dgvListaEmpregado.TabIndex = 10;
            this.dgvListaEmpregado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaEmpregado_CellDoubleClick);
            // 
            // IdEmpregado
            // 
            this.IdEmpregado.DataPropertyName = "Id";
            this.IdEmpregado.HeaderText = "Id";
            this.IdEmpregado.Name = "IdEmpregado";
            this.IdEmpregado.ReadOnly = true;
            this.IdEmpregado.Visible = false;
            // 
            // MatriculaEmpregado
            // 
            this.MatriculaEmpregado.DataPropertyName = "Matricula";
            this.MatriculaEmpregado.HeaderText = "Matricula";
            this.MatriculaEmpregado.Name = "MatriculaEmpregado";
            this.MatriculaEmpregado.ReadOnly = true;
            // 
            // NomeEmpregado
            // 
            this.NomeEmpregado.DataPropertyName = "Nome";
            this.NomeEmpregado.HeaderText = "Nome";
            this.NomeEmpregado.Name = "NomeEmpregado";
            this.NomeEmpregado.ReadOnly = true;
            // 
            // AdmissaoEmpregado
            // 
            this.AdmissaoEmpregado.DataPropertyName = "Admissao";
            this.AdmissaoEmpregado.HeaderText = "Admissão";
            this.AdmissaoEmpregado.Name = "AdmissaoEmpregado";
            this.AdmissaoEmpregado.ReadOnly = true;
            // 
            // DemissaoEmpregado
            // 
            this.DemissaoEmpregado.DataPropertyName = "Demissao";
            this.DemissaoEmpregado.HeaderText = "Demissão";
            this.DemissaoEmpregado.Name = "DemissaoEmpregado";
            this.DemissaoEmpregado.ReadOnly = true;
            // 
            // MediaEmpregado
            // 
            this.MediaEmpregado.DataPropertyName = "Media";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.MediaEmpregado.DefaultCellStyle = dataGridViewCellStyle7;
            this.MediaEmpregado.HeaderText = "Media";
            this.MediaEmpregado.Name = "MediaEmpregado";
            this.MediaEmpregado.ReadOnly = true;
            // 
            // BaseEmpregado
            // 
            this.BaseEmpregado.DataPropertyName = "Base";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.BaseEmpregado.DefaultCellStyle = dataGridViewCellStyle8;
            this.BaseEmpregado.HeaderText = "Dias_Base";
            this.BaseEmpregado.Name = "BaseEmpregado";
            this.BaseEmpregado.ReadOnly = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(413, 81);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(413, 110);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 8;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(413, 139);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 9;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lista de Empregado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dois cliques sobre o item para excluir ou alterar.";
            // 
            // FrmCadastroEmpragado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 395);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.dgvListaEmpregado);
            this.Controls.Add(this.TxtDiasBase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtMedia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MktDemissao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MktAdmissao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroEmpragado";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro Empragado";
            this.Load += new System.EventHandler(this.FrmCadastroEmpragado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpregado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MktAdmissao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MktDemissao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMedia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDiasBase;
        private System.Windows.Forms.DataGridView dgvListaEmpregado;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatriculaEmpregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEmpregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmissaoEmpregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemissaoEmpregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn MediaEmpregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseEmpregado;
    }
}