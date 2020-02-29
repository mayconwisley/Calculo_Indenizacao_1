namespace CalculoIndenizacao
{
    partial class FrmCalculoEstabilidade
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDadosEmpregado = new System.Windows.Forms.Label();
            this.cbxEmpregado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CbCalcFGTS40 = new System.Windows.Forms.CheckBox();
            this.CbCalcFGTS8 = new System.Windows.Forms.CheckBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblDiasEstabilidade = new System.Windows.Forms.Label();
            this.mktDataEstabilidade = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvListaLancamento = new System.Windows.Forms.DataGridView();
            this.IdComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoComplemento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id_EmpregadoComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotais = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLancamento)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDadosEmpregado);
            this.groupBox1.Controls.Add(this.cbxEmpregado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empregado";
            // 
            // lblDadosEmpregado
            // 
            this.lblDadosEmpregado.AutoSize = true;
            this.lblDadosEmpregado.Location = new System.Drawing.Point(6, 66);
            this.lblDadosEmpregado.Name = "lblDadosEmpregado";
            this.lblDadosEmpregado.Size = new System.Drawing.Size(38, 13);
            this.lblDadosEmpregado.TabIndex = 4;
            this.lblDadosEmpregado.Text = "Dados";
            // 
            // cbxEmpregado
            // 
            this.cbxEmpregado.DisplayMember = "Nome";
            this.cbxEmpregado.FormattingEnabled = true;
            this.cbxEmpregado.Location = new System.Drawing.Point(9, 32);
            this.cbxEmpregado.Name = "cbxEmpregado";
            this.cbxEmpregado.Size = new System.Drawing.Size(359, 21);
            this.cbxEmpregado.TabIndex = 1;
            this.cbxEmpregado.ValueMember = "Id";
            this.cbxEmpregado.SelectedIndexChanged += new System.EventHandler(this.cbxEmpregado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CbCalcFGTS40);
            this.groupBox2.Controls.Add(this.CbCalcFGTS8);
            this.groupBox2.Controls.Add(this.lblInfo);
            this.groupBox2.Controls.Add(this.lblDiasEstabilidade);
            this.groupBox2.Controls.Add(this.mktDataEstabilidade);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(275, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 352);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculos";
            // 
            // CbCalcFGTS40
            // 
            this.CbCalcFGTS40.AutoSize = true;
            this.CbCalcFGTS40.Checked = true;
            this.CbCalcFGTS40.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbCalcFGTS40.Location = new System.Drawing.Point(9, 81);
            this.CbCalcFGTS40.Name = "CbCalcFGTS40";
            this.CbCalcFGTS40.Size = new System.Drawing.Size(104, 17);
            this.CbCalcFGTS40.TabIndex = 5;
            this.CbCalcFGTS40.Text = "Calc. FGTS 40%";
            this.CbCalcFGTS40.UseVisualStyleBackColor = true;
            this.CbCalcFGTS40.CheckedChanged += new System.EventHandler(this.CbCalcFGTS40_CheckedChanged);
            // 
            // CbCalcFGTS8
            // 
            this.CbCalcFGTS8.AutoSize = true;
            this.CbCalcFGTS8.Checked = true;
            this.CbCalcFGTS8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbCalcFGTS8.Location = new System.Drawing.Point(9, 58);
            this.CbCalcFGTS8.Name = "CbCalcFGTS8";
            this.CbCalcFGTS8.Size = new System.Drawing.Size(98, 17);
            this.CbCalcFGTS8.TabIndex = 4;
            this.CbCalcFGTS8.Text = "Calc. FGTS 8%";
            this.CbCalcFGTS8.UseVisualStyleBackColor = true;
            this.CbCalcFGTS8.CheckedChanged += new System.EventHandler(this.CbCalcFGTS8_CheckedChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(6, 175);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(40, 17);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Info";
            // 
            // lblDiasEstabilidade
            // 
            this.lblDiasEstabilidade.AutoSize = true;
            this.lblDiasEstabilidade.Location = new System.Drawing.Point(111, 35);
            this.lblDiasEstabilidade.Name = "lblDiasEstabilidade";
            this.lblDiasEstabilidade.Size = new System.Drawing.Size(52, 13);
            this.lblDiasEstabilidade.TabIndex = 2;
            this.lblDiasEstabilidade.Text = "Dias: 000";
            // 
            // mktDataEstabilidade
            // 
            this.mktDataEstabilidade.Location = new System.Drawing.Point(9, 32);
            this.mktDataEstabilidade.Mask = "00/00/0000";
            this.mktDataEstabilidade.Name = "mktDataEstabilidade";
            this.mktDataEstabilidade.Size = new System.Drawing.Size(80, 20);
            this.mktDataEstabilidade.TabIndex = 3;
            this.mktDataEstabilidade.ValidatingType = typeof(System.DateTime);
            this.mktDataEstabilidade.Leave += new System.EventHandler(this.mktDataEstabilidade_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fim Estabilidade";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvListaLancamento);
            this.groupBox3.Controls.Add(this.lblTotais);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(20, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 352);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Complementos";
            // 
            // dgvListaLancamento
            // 
            this.dgvListaLancamento.AllowUserToAddRows = false;
            this.dgvListaLancamento.AllowUserToDeleteRows = false;
            this.dgvListaLancamento.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListaLancamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListaLancamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaLancamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdComplemento,
            this.DescricaoComplemento,
            this.ValorComplemento,
            this.TipoComplemento,
            this.Id_EmpregadoComplemento});
            this.dgvListaLancamento.Location = new System.Drawing.Point(6, 32);
            this.dgvListaLancamento.MultiSelect = false;
            this.dgvListaLancamento.Name = "dgvListaLancamento";
            this.dgvListaLancamento.ReadOnly = true;
            this.dgvListaLancamento.RowHeadersWidth = 5;
            this.dgvListaLancamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaLancamento.Size = new System.Drawing.Size(237, 301);
            this.dgvListaLancamento.TabIndex = 8;
            // 
            // IdComplemento
            // 
            this.IdComplemento.DataPropertyName = "Id";
            this.IdComplemento.HeaderText = "Id";
            this.IdComplemento.Name = "IdComplemento";
            this.IdComplemento.ReadOnly = true;
            this.IdComplemento.Visible = false;
            // 
            // DescricaoComplemento
            // 
            this.DescricaoComplemento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescricaoComplemento.DataPropertyName = "Descricao";
            this.DescricaoComplemento.HeaderText = "Descrição";
            this.DescricaoComplemento.Name = "DescricaoComplemento";
            this.DescricaoComplemento.ReadOnly = true;
            // 
            // ValorComplemento
            // 
            this.ValorComplemento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ValorComplemento.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.ValorComplemento.DefaultCellStyle = dataGridViewCellStyle2;
            this.ValorComplemento.HeaderText = "Valor";
            this.ValorComplemento.Name = "ValorComplemento";
            this.ValorComplemento.ReadOnly = true;
            this.ValorComplemento.Width = 56;
            // 
            // TipoComplemento
            // 
            this.TipoComplemento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TipoComplemento.DataPropertyName = "Tipo";
            this.TipoComplemento.HeaderText = "Negativo";
            this.TipoComplemento.Name = "TipoComplemento";
            this.TipoComplemento.ReadOnly = true;
            this.TipoComplemento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TipoComplemento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TipoComplemento.Visible = false;
            // 
            // Id_EmpregadoComplemento
            // 
            this.Id_EmpregadoComplemento.DataPropertyName = "Id_Empregado";
            this.Id_EmpregadoComplemento.HeaderText = "Id_Empregado";
            this.Id_EmpregadoComplemento.Name = "Id_EmpregadoComplemento";
            this.Id_EmpregadoComplemento.ReadOnly = true;
            this.Id_EmpregadoComplemento.Visible = false;
            // 
            // lblTotais
            // 
            this.lblTotais.AutoSize = true;
            this.lblTotais.Location = new System.Drawing.Point(6, 336);
            this.lblTotais.Name = "lblTotais";
            this.lblTotais.Size = new System.Drawing.Size(58, 13);
            this.lblTotais.TabIndex = 2;
            this.lblTotais.Text = "Total: 0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lista de Complementos";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(418, 70);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(172, 33);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(418, 109);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(172, 33);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(418, 148);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(172, 33);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FrmCalculoEstabilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 557);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculoEstabilidade";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Calculo Estabilidade";
            this.Load += new System.EventHandler(this.FrmCalculoEstabilidade_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLancamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxEmpregado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDadosEmpregado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mktDataEstabilidade;
        private System.Windows.Forms.Label lblDiasEstabilidade;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotais;
        private System.Windows.Forms.DataGridView dgvListaLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorComplemento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TipoComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_EmpregadoComplemento;
        private System.Windows.Forms.CheckBox CbCalcFGTS40;
        private System.Windows.Forms.CheckBox CbCalcFGTS8;
    }
}