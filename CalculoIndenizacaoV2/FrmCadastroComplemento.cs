using Negocio;
using Negocio.Complemento;
using Negocio.Empregado;
using Objetos.Complemento;
using Objetos.Empregado;
using System;
using System.Windows.Forms;

namespace CalculoIndenizacao
{
    public partial class FrmCadastroComplemento : MetroFramework.Forms.MetroForm
    {
        public FrmCadastroComplemento()
        {
            InitializeComponent();
        }

        Empregado empregado;
        EmpregadoObjeto empregadoObjeto;
        Complemento complemento;
        ComplementoObjeto complementoObjeto;
        int empregadoId, complementoId;
        Validar validar;

        private void ListarEmpregado()
        {
            empregado = new Empregado();
            try
            {
                cbxEmpregado.DataSource = empregado.ListaCombobox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ListaComplemento()
        {
            complemento = new Complemento();
            empregadoObjeto = new EmpregadoObjeto();

            decimal valorTotalComplemento = 0;
            try
            {
                empregadoObjeto.Id = empregadoId;
                dgvListaLancamento.DataSource = complemento.Lista(empregadoObjeto);

                foreach (DataGridViewRow item in dgvListaLancamento.Rows)
                {
                    valorTotalComplemento += decimal.Parse(item.Cells["ValorComplemento"].Value.ToString());

                }

                lblTotais.Text = "Totais: " + valorTotalComplemento.ToString("#,##0.00");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Manipular(char opc)
        {
            complemento = new Complemento();
            complementoObjeto = new ComplementoObjeto();

            try
            {
                complementoObjeto.Id = complementoId;
                complementoObjeto.Descricao = txtDecricao.Text.Trim();
                decimal valor = decimal.Parse(txtValor.Text.Trim());

                if (cbTipo.Checked)
                {
                    complementoObjeto.Tipo = true;
                    valor = valor * (-1);
                }
                else
                {
                    complementoObjeto.Tipo = false;
                }
                complementoObjeto.Valor = valor;
                complementoObjeto.Empregado = new EmpregadoObjeto();
                complementoObjeto.Empregado.Id = empregadoId;

                switch (opc)
                {
                    case 'A':
                        complemento.Adicionar(complementoObjeto);
                        break;
                    case 'E':
                        complemento.Excluir(complementoObjeto);
                        break;
                    default:
                        break;
                }
                ListaComplemento();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset()
        {
            txtDecricao.Clear();
            txtValor.Text = "0,00";
            btnAdicionar.Enabled = true;
            btnExcluir.Enabled = false;

        }

        private void FrmCadastroComplemento_Load(object sender, EventArgs e)
        {
            ListarEmpregado();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Manipular('A');
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Manipular('E');
        }

        private void dgvListaLancamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                complementoId = int.Parse(dgvListaLancamento.Rows[e.RowIndex].Cells["IdComplemento"].Value.ToString());
                txtDecricao.Text = dgvListaLancamento.Rows[e.RowIndex].Cells["DescricaoComplemento"].Value.ToString();
                txtValor.Text = dgvListaLancamento.Rows[e.RowIndex].Cells["ValorComplemento"].Value.ToString();

                bool tipo = bool.Parse(dgvListaLancamento.Rows[e.RowIndex].Cells["TipoComplemento"].Value.ToString());
                if (tipo == true)
                {
                    cbTipo.Checked = true;
                }
                else
                {
                    cbTipo.Checked = false;
                }
                btnAdicionar.Enabled = false;
                btnExcluir.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            validar = new Validar();
            txtValor.Text = validar.ValidarValor(txtValor.Text);
            txtValor.Select(txtValor.Text.Length, 0);
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            validar = new Validar();
            txtValor.Text = validar.Zero(txtValor.Text);
            txtValor.Text = validar.Formatar(txtValor.Text);
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            if (txtValor.Text == "0,00")
            {
                txtValor.Text = "";
            }
        }

        private void cbxEmpregado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                empregadoId = int.Parse(cbxEmpregado.SelectedValue.ToString());
                ListaComplemento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
