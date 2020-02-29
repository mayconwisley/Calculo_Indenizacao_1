namespace CalculoIndenizacao
{
    partial class FrmCadastroComplemento
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
            this.cbxEmpregado = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotais = new System.Windows.Forms.Label();
            this.dgvListaLancamento = new System.Windows.Forms.DataGridView();
            this.IdComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoComplemento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id_EmpregadoComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.CheckBox();
            this.txtDecricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLancamento)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxEmpregado
            // 
            this.cbxEmpregado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEmpregado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEmpregado.DisplayMember = "Nome";
            this.cbxEmpregado.FormattingEnabled = true;
            this.cbxEmpregado.Location = new System.Drawing.Point(6, 31);
            this.cbxEmpregado.Name = "cbxEmpregado";
            this.cbxEmpregado.Size = new System.Drawing.Size(462, 21);
            this.cbxEmpregado.TabIndex = 2;
            this.cbxEmpregado.ValueMember = "Id";
            this.cbxEmpregado.SelectedIndexChanged += new System.EventHandler(this.cbxEmpregado_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxEmpregado);
            this.groupBox1.Location = new System.Drawing.Point(17, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empregado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblTotais);
            this.groupBox2.Controls.Add(this.dgvListaLancamento);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnAdicionar);
            this.groupBox2.Controls.Add(this.cbTipo);
            this.groupBox2.Controls.Add(this.txtDecricao);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(17, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 267);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Complemento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(233, 32);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(79, 20);
            this.txtValor.TabIndex = 5;
            this.txtValor.Text = "0,00";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lista de Lançamentos";
            // 
            // lblTotais
            // 
            this.lblTotais.AutoSize = true;
            this.lblTotais.Location = new System.Drawing.Point(6, 239);
            this.lblTotais.Name = "lblTotais";
            this.lblTotais.Size = new System.Drawing.Size(63, 13);
            this.lblTotais.TabIndex = 5;
            this.lblTotais.Text = "Totais: 0,00";
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
            this.dgvListaLancamento.Location = new System.Drawing.Point(8, 84);
            this.dgvListaLancamento.MultiSelect = false;
            this.dgvListaLancamento.Name = "dgvListaLancamento";
            this.dgvListaLancamento.ReadOnly = true;
            this.dgvListaLancamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaLancamento.Size = new System.Drawing.Size(460, 132);
            this.dgvListaLancamento.TabIndex = 9;
            this.dgvListaLancamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaLancamento_CellDoubleClick);
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
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(393, 45);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(393, 16);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.AutoSize = true;
            this.cbTipo.Location = new System.Drawing.Point(318, 34);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(69, 17);
            this.cbTipo.TabIndex = 6;
            this.cbTipo.Text = "Negativo";
            this.cbTipo.UseVisualStyleBackColor = true;
            // 
            // txtDecricao
            // 
            this.txtDecricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDecricao.Location = new System.Drawing.Point(8, 32);
            this.txtDecricao.Name = "txtDecricao";
            this.txtDecricao.Size = new System.Drawing.Size(219, 20);
            this.txtDecricao.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dois cliques sobre o item para excluir";
            // 
            // FrmCadastroComplemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroComplemento";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro Complemento";
            this.Load += new System.EventHandler(this.FrmCadastroComplemento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLancamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxEmpregado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDecricao;
        private System.Windows.Forms.CheckBox cbTipo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvListaLancamento;
        private System.Windows.Forms.Label lblTotais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorComplemento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TipoComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_EmpregadoComplemento;
        private System.Windows.Forms.Label label1;
    }
}