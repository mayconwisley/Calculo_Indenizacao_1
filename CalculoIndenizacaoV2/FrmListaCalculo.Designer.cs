namespace CalculoIndenizacao
{
    partial class FrmListaCalculo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListarCalculos = new System.Windows.Forms.DataGridView();
            this.EmpregadoMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpregadoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpregadoAdmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpregadoDemissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpregadoMedia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculoDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCalculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculoTipo_Calculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculoData_Estabilidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculoValor_Indenizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculoValor_Decimo_Terceiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculoValor_Ferias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculoValor_Terco_Ferias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculoValor_FGTS8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculoValor_FGTS40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculoValor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComplementoDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComplementoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComplementoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCalculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarCalculos
            // 
            this.dgvListarCalculos.AllowUserToAddRows = false;
            this.dgvListarCalculos.AllowUserToDeleteRows = false;
            this.dgvListarCalculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListarCalculos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListarCalculos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListarCalculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarCalculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpregadoMatricula,
            this.EmpregadoNome,
            this.EmpregadoAdmissao,
            this.EmpregadoDemissao,
            this.EmpregadoMedia,
            this.CalculoDias,
            this.IdCalculo,
            this.CalculoTipo_Calculo,
            this.CalculoData_Estabilidade,
            this.CalculoValor_Indenizacao,
            this.CalculoValor_Decimo_Terceiro,
            this.CalculoValor_Ferias,
            this.CalculoValor_Terco_Ferias,
            this.CalculoValor_FGTS8,
            this.CalculoValor_FGTS40,
            this.CalculoValor_Total,
            this.ComplementoDescricao,
            this.ComplementoValor,
            this.ComplementoTipo});
            this.dgvListarCalculos.Location = new System.Drawing.Point(13, 76);
            this.dgvListarCalculos.MultiSelect = false;
            this.dgvListarCalculos.Name = "dgvListarCalculos";
            this.dgvListarCalculos.ReadOnly = true;
            this.dgvListarCalculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarCalculos.Size = new System.Drawing.Size(776, 377);
            this.dgvListarCalculos.TabIndex = 0;
            this.dgvListarCalculos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarCalculos_CellDoubleClick);
            // 
            // EmpregadoMatricula
            // 
            this.EmpregadoMatricula.DataPropertyName = "Matricula";
            this.EmpregadoMatricula.HeaderText = "Matricula";
            this.EmpregadoMatricula.Name = "EmpregadoMatricula";
            this.EmpregadoMatricula.ReadOnly = true;
            this.EmpregadoMatricula.Width = 75;
            // 
            // EmpregadoNome
            // 
            this.EmpregadoNome.DataPropertyName = "Nome";
            this.EmpregadoNome.HeaderText = "Nome";
            this.EmpregadoNome.Name = "EmpregadoNome";
            this.EmpregadoNome.ReadOnly = true;
            this.EmpregadoNome.Width = 60;
            // 
            // EmpregadoAdmissao
            // 
            this.EmpregadoAdmissao.DataPropertyName = "Admissao";
            dataGridViewCellStyle23.Format = "d";
            dataGridViewCellStyle23.NullValue = null;
            this.EmpregadoAdmissao.DefaultCellStyle = dataGridViewCellStyle23;
            this.EmpregadoAdmissao.HeaderText = "Admissao";
            this.EmpregadoAdmissao.Name = "EmpregadoAdmissao";
            this.EmpregadoAdmissao.ReadOnly = true;
            this.EmpregadoAdmissao.Width = 77;
            // 
            // EmpregadoDemissao
            // 
            this.EmpregadoDemissao.DataPropertyName = "Demissao";
            dataGridViewCellStyle24.Format = "d";
            this.EmpregadoDemissao.DefaultCellStyle = dataGridViewCellStyle24;
            this.EmpregadoDemissao.HeaderText = "Demissao";
            this.EmpregadoDemissao.Name = "EmpregadoDemissao";
            this.EmpregadoDemissao.ReadOnly = true;
            this.EmpregadoDemissao.Width = 78;
            // 
            // EmpregadoMedia
            // 
            this.EmpregadoMedia.DataPropertyName = "Media";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.Format = "N2";
            this.EmpregadoMedia.DefaultCellStyle = dataGridViewCellStyle25;
            this.EmpregadoMedia.HeaderText = "Media";
            this.EmpregadoMedia.Name = "EmpregadoMedia";
            this.EmpregadoMedia.ReadOnly = true;
            this.EmpregadoMedia.Width = 61;
            // 
            // CalculoDias
            // 
            this.CalculoDias.DataPropertyName = "Dias";
            this.CalculoDias.HeaderText = "Dias";
            this.CalculoDias.Name = "CalculoDias";
            this.CalculoDias.ReadOnly = true;
            this.CalculoDias.Width = 53;
            // 
            // IdCalculo
            // 
            this.IdCalculo.DataPropertyName = "Id";
            this.IdCalculo.HeaderText = "Id";
            this.IdCalculo.Name = "IdCalculo";
            this.IdCalculo.ReadOnly = true;
            this.IdCalculo.Visible = false;
            this.IdCalculo.Width = 41;
            // 
            // CalculoTipo_Calculo
            // 
            this.CalculoTipo_Calculo.DataPropertyName = "Tipo_Calculo";
            this.CalculoTipo_Calculo.HeaderText = "Tipo_Calculo";
            this.CalculoTipo_Calculo.Name = "CalculoTipo_Calculo";
            this.CalculoTipo_Calculo.ReadOnly = true;
            this.CalculoTipo_Calculo.Width = 94;
            // 
            // CalculoData_Estabilidade
            // 
            this.CalculoData_Estabilidade.DataPropertyName = "Data_Estabilidade";
            this.CalculoData_Estabilidade.HeaderText = "Estabilidade";
            this.CalculoData_Estabilidade.Name = "CalculoData_Estabilidade";
            this.CalculoData_Estabilidade.ReadOnly = true;
            this.CalculoData_Estabilidade.Width = 89;
            // 
            // CalculoValor_Indenizacao
            // 
            this.CalculoValor_Indenizacao.DataPropertyName = "Valor_Indenizacao";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N2";
            this.CalculoValor_Indenizacao.DefaultCellStyle = dataGridViewCellStyle26;
            this.CalculoValor_Indenizacao.HeaderText = "Valor_Indenizacao";
            this.CalculoValor_Indenizacao.Name = "CalculoValor_Indenizacao";
            this.CalculoValor_Indenizacao.ReadOnly = true;
            this.CalculoValor_Indenizacao.Width = 120;
            // 
            // CalculoValor_Decimo_Terceiro
            // 
            this.CalculoValor_Decimo_Terceiro.DataPropertyName = "Valor_Decimo_Terceiro";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.Format = "N2";
            this.CalculoValor_Decimo_Terceiro.DefaultCellStyle = dataGridViewCellStyle27;
            this.CalculoValor_Decimo_Terceiro.HeaderText = "Valor_Decimo_Terceiro";
            this.CalculoValor_Decimo_Terceiro.Name = "CalculoValor_Decimo_Terceiro";
            this.CalculoValor_Decimo_Terceiro.ReadOnly = true;
            this.CalculoValor_Decimo_Terceiro.Width = 143;
            // 
            // CalculoValor_Ferias
            // 
            this.CalculoValor_Ferias.DataPropertyName = "Valor_Ferias";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.Format = "N2";
            this.CalculoValor_Ferias.DefaultCellStyle = dataGridViewCellStyle28;
            this.CalculoValor_Ferias.HeaderText = "Valor_Ferias";
            this.CalculoValor_Ferias.Name = "CalculoValor_Ferias";
            this.CalculoValor_Ferias.ReadOnly = true;
            this.CalculoValor_Ferias.Width = 90;
            // 
            // CalculoValor_Terco_Ferias
            // 
            this.CalculoValor_Terco_Ferias.DataPropertyName = "Valor_Terco_Ferias";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle29.Format = "N2";
            this.CalculoValor_Terco_Ferias.DefaultCellStyle = dataGridViewCellStyle29;
            this.CalculoValor_Terco_Ferias.HeaderText = "Valor_Terco_Ferias";
            this.CalculoValor_Terco_Ferias.Name = "CalculoValor_Terco_Ferias";
            this.CalculoValor_Terco_Ferias.ReadOnly = true;
            this.CalculoValor_Terco_Ferias.Width = 124;
            // 
            // CalculoValor_FGTS8
            // 
            this.CalculoValor_FGTS8.DataPropertyName = "Valor_FGTS8";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle30.Format = "N2";
            this.CalculoValor_FGTS8.DefaultCellStyle = dataGridViewCellStyle30;
            this.CalculoValor_FGTS8.HeaderText = "Valor_FGTS_8%";
            this.CalculoValor_FGTS8.Name = "CalculoValor_FGTS8";
            this.CalculoValor_FGTS8.ReadOnly = true;
            this.CalculoValor_FGTS8.Width = 110;
            // 
            // CalculoValor_FGTS40
            // 
            this.CalculoValor_FGTS40.DataPropertyName = "Valor_FGTS40";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle31.Format = "N2";
            this.CalculoValor_FGTS40.DefaultCellStyle = dataGridViewCellStyle31;
            this.CalculoValor_FGTS40.HeaderText = "Valor_FGTS_40%";
            this.CalculoValor_FGTS40.Name = "CalculoValor_FGTS40";
            this.CalculoValor_FGTS40.ReadOnly = true;
            this.CalculoValor_FGTS40.Width = 116;
            // 
            // CalculoValor_Total
            // 
            this.CalculoValor_Total.DataPropertyName = "Valor_Total";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle32.Format = "N2";
            this.CalculoValor_Total.DefaultCellStyle = dataGridViewCellStyle32;
            this.CalculoValor_Total.HeaderText = "Valor_Total";
            this.CalculoValor_Total.Name = "CalculoValor_Total";
            this.CalculoValor_Total.ReadOnly = true;
            this.CalculoValor_Total.Width = 86;
            // 
            // ComplementoDescricao
            // 
            this.ComplementoDescricao.DataPropertyName = "Descricao";
            this.ComplementoDescricao.HeaderText = "Descricao";
            this.ComplementoDescricao.Name = "ComplementoDescricao";
            this.ComplementoDescricao.ReadOnly = true;
            this.ComplementoDescricao.Width = 80;
            // 
            // ComplementoValor
            // 
            this.ComplementoValor.DataPropertyName = "Valor";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle33.Format = "N2";
            this.ComplementoValor.DefaultCellStyle = dataGridViewCellStyle33;
            this.ComplementoValor.HeaderText = "Valor";
            this.ComplementoValor.Name = "ComplementoValor";
            this.ComplementoValor.ReadOnly = true;
            this.ComplementoValor.Width = 56;
            // 
            // ComplementoTipo
            // 
            this.ComplementoTipo.DataPropertyName = "Tipo";
            this.ComplementoTipo.HeaderText = "Tipo";
            this.ComplementoTipo.Name = "ComplementoTipo";
            this.ComplementoTipo.ReadOnly = true;
            this.ComplementoTipo.Visible = false;
            this.ComplementoTipo.Width = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista Calculados";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(714, 459);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dois cliques sobre o item para excluir.";
            // 
            // FrmListaCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(802, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListarCalculos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListaCalculo";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Lista Calculo";
            this.Load += new System.EventHandler(this.FrmListaCalculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCalculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarCalculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpregadoMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpregadoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpregadoAdmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpregadoDemissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpregadoMedia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculoDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCalculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculoTipo_Calculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculoData_Estabilidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculoValor_Indenizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculoValor_Decimo_Terceiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculoValor_Ferias;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculoValor_Terco_Ferias;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculoValor_FGTS8;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculoValor_FGTS40;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculoValor_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplementoDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplementoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplementoTipo;
        private System.Windows.Forms.Label label2;
    }
}