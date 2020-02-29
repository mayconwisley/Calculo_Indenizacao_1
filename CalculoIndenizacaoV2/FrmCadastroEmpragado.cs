using Negocio;
using Negocio.Empregado;
using Objetos.Empregado;
using System;
using System.Windows.Forms;

namespace CalculoIndenizacao
{
    public partial class FrmCadastroEmpragado : MetroFramework.Forms.MetroForm
    {
        public FrmCadastroEmpragado()
        {
            InitializeComponent();
        }

        Empregado empregado;
        EmpregadoObjeto empregadoObjeto;
        Validar validar;
        int empregadoId;

        private void ListarEmpregados()
        {
            empregado = new Empregado();
            try
            {
                dgvListaEmpregado.DataSource = empregado.Lista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Manipular(char opc)
        {
            empregado = new Empregado();
            empregadoObjeto = new EmpregadoObjeto();

            try
            {
                empregadoObjeto.Id = empregadoId;
                empregadoObjeto.Matricula = txtMatricula.Text.Trim();
                empregadoObjeto.Nome = TxtNome.Text.Trim();
                empregadoObjeto.Admissao = DateTime.Parse(MktAdmissao.Text.Trim());
                empregadoObjeto.Demissao = DateTime.Parse(MktDemissao.Text.Trim());
                empregadoObjeto.Media = decimal.Parse(TxtMedia.Text.Trim());
                empregadoObjeto.Base = int.Parse(TxtDiasBase.Text.Trim());

                switch (opc)
                {
                    case 'G':
                        empregado.Gravar(empregadoObjeto);
                        break;
                    case 'A':
                        empregado.Alterar(empregadoObjeto);
                        break;
                    case 'E':
                        empregado.Excluir(empregadoObjeto);
                        break;
                    default:
                        break;
                }
                ListarEmpregados();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset()
        {
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            btnGravar.Enabled = true;
            txtMatricula.Clear();
            TxtNome.Clear();
            TxtMedia.Text = "0,00";
            TxtDiasBase.Text = "30";
            MktAdmissao.Clear();
            MktDemissao.Clear();
        }

        private void FrmCadastroEmpragado_Load(object sender, EventArgs e)
        {
            ListarEmpregados();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Manipular('G');
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Manipular('A');
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Manipular('E');
        }

        private void dgvListaEmpregado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                empregadoId = int.Parse(dgvListaEmpregado.Rows[e.RowIndex].Cells["IdEmpregado"].Value.ToString());
                txtMatricula.Text = dgvListaEmpregado.Rows[e.RowIndex].Cells["MatriculaEmpregado"].Value.ToString();
                TxtNome.Text = dgvListaEmpregado.Rows[e.RowIndex].Cells["NomeEmpregado"].Value.ToString();
                MktAdmissao.Text = dgvListaEmpregado.Rows[e.RowIndex].Cells["AdmissaoEmpregado"].Value.ToString();
                MktDemissao.Text = dgvListaEmpregado.Rows[e.RowIndex].Cells["DemissaoEmpregado"].Value.ToString();
                TxtMedia.Text = dgvListaEmpregado.Rows[e.RowIndex].Cells["MediaEmpregado"].Value.ToString();
                TxtDiasBase.Text = dgvListaEmpregado.Rows[e.RowIndex].Cells["BaseEmpregado"].Value.ToString();
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
                btnGravar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtMedia_TextChanged(object sender, EventArgs e)
        {
            validar = new Validar();
            TxtMedia.Text = validar.ValidarValor(TxtMedia.Text);
            TxtMedia.Select(TxtMedia.Text.Length, 0);
        }

        private void TxtMedia_Leave(object sender, EventArgs e)
        {
            validar = new Validar();
            TxtMedia.Text = validar.Zero(TxtMedia.Text);
            TxtMedia.Text = validar.Formatar(TxtMedia.Text);
        }

        private void TxtMedia_Enter(object sender, EventArgs e)
        {
            if (TxtMedia.Text == "0,00")
            {
                TxtMedia.Text = "";
            }
        }
    }
}
