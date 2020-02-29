using Negocio.Calculo;
using Objetos.Calculo;
using System;
using System.Windows.Forms;
namespace CalculoIndenizacao
{
    public partial class FrmListaCalculo : MetroFramework.Forms.MetroForm
    {
        public FrmListaCalculo()
        {
            InitializeComponent();
        }

        Calculo calculo;
        CalculoObjeto calculoObjeto;
        int calculoId;
        private void Listar()
        {
            calculo = new Calculo();
            try
            {
                dgvListarCalculos.DataSource = calculo.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Manipular(char opc)
        {
            calculo = new Calculo();
            calculoObjeto = new CalculoObjeto();
            try
            {
                calculoObjeto.Id = calculoId;
                switch (opc)
                {
                    case 'E':
                        if (calculo.ExcluirPorId(calculoObjeto))
                        {
                            MessageBox.Show("Dados excluido com sucesso...", "Aviso");
                        }
                        break;
                    default:
                        break;
                }
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrmListaCalculo_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void dgvListarCalculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                calculoId = int.Parse(dgvListarCalculos.Rows[e.RowIndex].Cells["IdCalculo"].Value.ToString());
                BtnExcluir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Manipular('E');
            BtnExcluir.Enabled = false;
        }
    }
}
