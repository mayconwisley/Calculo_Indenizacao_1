using Negocio.Calculo;
using Negocio.Empregado;
using System;
using System.Windows.Forms;

namespace CalculoIndenizacao
{
    public partial class FrmListaRelatorio : MetroFramework.Forms.MetroForm
    {
        public FrmListaRelatorio()
        {
            InitializeComponent();
        }

        Empregado empregado;
        Calculo calculo;
        Relatorios.RelatorioDemonstrativo relatorioDemonstrativo;
        int empregadoId, iMatricula;
        int calculoId = 0;
        bool abrir = true;

        FrmVisualizarRelatorio visualizarRelatorio;

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
        private void ListarValorTotal(int matricula)
        {
            calculo = new Calculo();
            try
            {
                cbxValorTotal.DataSource = calculo.ValorTotal(matricula);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void FrmListaRelatorio_Load(object sender, EventArgs e)
        {
            ListarEmpregado();

        }

        private void CbxEmpregado_SelectedIndexChanged(object sender, EventArgs e)
        {
            empregado = new Empregado();
            try
            {
                empregadoId = int.Parse(cbxEmpregado.SelectedValue.ToString());
                iMatricula = empregado.Matricula(empregadoId);
                ListarValorTotal(iMatricula);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            relatorioDemonstrativo = new Relatorios.RelatorioDemonstrativo();
            try
            {
                relatorioDemonstrativo.GerarRelatorio(empregadoId, calculoId);
                visualizarRelatorio = new FrmVisualizarRelatorio(empregadoId, calculoId);
                foreach (Form item in Application.OpenForms)
                {
                    if (item is FrmVisualizarRelatorio)
                    {
                        item.Focus();
                        abrir = false;
                    }
                }
                if (abrir)
                {
                    visualizarRelatorio.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbxValorTotal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                calculoId = int.Parse(cbxValorTotal.SelectedValue.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
