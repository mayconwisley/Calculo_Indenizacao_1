using Negocio.Calculo;
using Negocio.Complemento;
using Negocio.Empregado;
using Objetos.Calculo;
using Objetos.Empregado;
using System;
using System.Data;
using System.Windows.Forms;

namespace CalculoIndenizacao
{
    public partial class FrmCalculoEstabilidade : MetroFramework.Forms.MetroForm
    {
        public FrmCalculoEstabilidade()
        {
            InitializeComponent();
        }

        bool abrir = true;
        #region Outros
        FrmVisualizarRelatorio visualizarRelatorio;
        Relatorios.RelatorioDemonstrativo relatorioDemonstrativo;
        Empregado empregado;
        EmpregadoObjeto empregadoObjeto;
        Complemento complemento;
        Calculo calculo;
        CalculoObjeto calculoObjeto;
        int empregadoId, diasBase;
        TimeSpan diasEstabilidade;
        DataTable dadosEmpregado;
        string info = string.Empty, strComplemento = string.Empty;
        DateTime admissao, demissao, estabilidade;
        decimal valorMedia = 0;
        decimal valorTotalComplemento = 0;

        decimal valorIndenizacao = 0;
        decimal valorDecimoTerceiroSalario = 0;
        decimal valorFerias = 0;
        decimal valorTercoFerias = 0;
        decimal valorTotal = 0;
        decimal fgts8 = 0;
        decimal fgts40 = 0;
        #endregion
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
            valorTotalComplemento = 0;
            try
            {
                empregadoObjeto.Id = empregadoId;
                dgvListaLancamento.DataSource = complemento.Lista(empregadoObjeto);

                foreach (DataGridViewRow item in dgvListaLancamento.Rows)
                {
                    valorTotalComplemento += decimal.Parse(item.Cells["ValorComplemento"].Value.ToString());
                }

                lblTotais.Text = "Totais: " + valorTotalComplemento.ToString("#,##0.00");
                if (valorTotalComplemento > 0)
                {
                    strComplemento = "S";
                }
                else
                {
                    strComplemento = "N";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DadosEmpregado(int idEmpregado)
        {
            dadosEmpregado = new DataTable();
            empregado = new Empregado();
            empregadoObjeto = new EmpregadoObjeto();

            try
            {
                empregadoObjeto.Id = idEmpregado;
                dadosEmpregado = empregado.DadosEmpregado(empregadoObjeto);

                foreach (DataRow item in dadosEmpregado.Rows)
                {
                    admissao = DateTime.Parse(item["Admissao"].ToString());
                    demissao = DateTime.Parse(item["Demissao"].ToString());

                    valorMedia = decimal.Parse(item["Media"].ToString());
                    diasBase = int.Parse(item["Base"].ToString());

                    info = "Admissão: " + admissao.ToString("dd/MM/yyyy") +
                           " | Demissão: " + demissao.ToString("dd/MM/yyyy") +
                           "\nMédia: " + valorMedia.ToString("#,##0.00") +
                           " | Dias Base: " + diasBase.ToString("00");
                }
                lblDadosEmpregado.Text = info.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Calcular()
        {
            try
            {
                valorIndenizacao = CalculoBase.Indenizacao(valorMedia, diasBase, diasEstabilidade.Days);
                valorDecimoTerceiroSalario = CalculoBase.DecimoTerceiro(valorMedia, diasBase, diasEstabilidade.Days);
                valorFerias = CalculoBase.Ferias(valorMedia, diasBase, diasEstabilidade.Days);
                valorTercoFerias = CalculoBase.TercoFerias(valorFerias);

                if (CbCalcFGTS8.Checked)
                {
                    fgts8 = CalculoBase.FGTS8(valorIndenizacao, valorDecimoTerceiroSalario);
                }
                else
                {
                    fgts8 = 0;
                }
                if (CbCalcFGTS40.Checked)
                {
                    fgts40 = CalculoBase.FGTS40(fgts8);
                }
                else
                {
                    fgts40 = 0;
                }

                valorTotal = CalculoBase.Total(valorIndenizacao, valorDecimoTerceiroSalario, valorFerias, valorTercoFerias, fgts8, fgts40, valorTotalComplemento);

                lblInfo.Text = "Indenização....: " + valorIndenizacao.ToString("#,##0.00") +
                                                    "\n13º Salário....: " + valorDecimoTerceiroSalario.ToString("#,##0.00") +
                                                    "\nFérias.........: " + valorFerias.ToString("#,##0.00") +
                                                    "\n1/3 Férias.....: " + valorTercoFerias.ToString("#,##0.00") +
                                                    "\nFGTS 8%........: " + fgts8.ToString("#,##0.00") +
                                                    "\nFGTS 40%.......: " + fgts40.ToString("#,##0.00") +
                                                    "\n\nTotal..........: " + valorTotal.ToString("#,##0.00");
                btnGravar.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Existe(int idEmpregado)
        {
            calculo = new Calculo();
            calculoObjeto = new CalculoObjeto();
            empregadoObjeto = new EmpregadoObjeto();

            try
            {
                empregadoObjeto.Id = idEmpregado;
                calculoObjeto.Empregado = new EmpregadoObjeto();
                calculoObjeto.Empregado.Id = idEmpregado;


                if (!calculo.Existe(calculoObjeto))
                {
                    if (MessageBox.Show("Já exite um calculo para este colaborador, deseja excluir?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        calculo.ExcluirPorEmpregado(calculoObjeto);
                        MessageBox.Show("Calculo excluido.");
                        btnCalcular.Enabled = true;
                    }
                    else
                    {
                        btnCalcular.Enabled = false;
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void GravarCalculo(char opc)
        {
            calculo = new Calculo();
            calculoObjeto = new CalculoObjeto();
            try
            {
                calculoObjeto.TipoCalculo = "Calculo Estabilidade";
                calculoObjeto.DataEstabilidade = estabilidade;
                calculoObjeto.Dias = diasEstabilidade.Days;
                calculoObjeto.ValorIndenizacao = valorIndenizacao;
                calculoObjeto.ValorDecimoTerceiro = valorDecimoTerceiroSalario;
                calculoObjeto.ValorFerias = valorFerias;
                calculoObjeto.ValorTercoFerias = valorTercoFerias;

                calculoObjeto.FGTS8 = fgts8;
                calculoObjeto.FGTS40 = fgts40;

                calculoObjeto.ValorTotal = valorTotal;
                calculoObjeto.Complemento = strComplemento;
                calculoObjeto.Empregado = new EmpregadoObjeto();
                calculoObjeto.Empregado.Id = empregadoId;

                switch (opc)
                {
                    case 'G':
                        if (calculo.Gravar(calculoObjeto))
                        {
                            MessageBox.Show("Dados Gravados com Sucesso...");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao Gravar");
                        }
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset()
        {
            mktDataEstabilidade.Clear();
            lblInfo.Text = "Info";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            empregadoId = int.Parse(cbxEmpregado.SelectedValue.ToString());
            Existe(empregadoId);
            Calcular();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja gravar os dados calculados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                GravarCalculo('G');
                btnGravar.Enabled = false;
                btnImprimir.Enabled = true;
            }
        }

        private void CbCalcFGTS8_CheckedChanged(object sender, EventArgs e)
        {
            if (CbCalcFGTS8.Checked == false)
            {
                CbCalcFGTS40.Checked = false;
                CbCalcFGTS40.Enabled = false;
            }
            else
            {
                CbCalcFGTS40.Enabled = true;
            }
            Calcular();
        }

        private void CbCalcFGTS40_CheckedChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            relatorioDemonstrativo = new Relatorios.RelatorioDemonstrativo();
            try
            {
                relatorioDemonstrativo.GerarRelatorio0(empregadoId);
                visualizarRelatorio = new FrmVisualizarRelatorio(empregadoId);
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

        private void cbxEmpregado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                empregadoId = int.Parse(cbxEmpregado.SelectedValue.ToString());
                ListaComplemento();
                DadosEmpregado(empregadoId);
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mktDataEstabilidade_Leave(object sender, EventArgs e)
        {
            try
            {
                estabilidade = DateTime.Parse(mktDataEstabilidade.Text.Trim());

                diasEstabilidade = estabilidade.Date.Subtract(demissao);


                if (diasEstabilidade.Days < 0)
                {
                    diasEstabilidade = TimeSpan.Zero;
                    lblDiasEstabilidade.Text = "Data fim da estabilidade é anterior\n a data de demissão!";
                    btnCalcular.Enabled = false;
                    mktDataEstabilidade.Focus();
                }
                else if (diasEstabilidade.Days == 0)
                {
                    diasEstabilidade = TimeSpan.Zero;
                    lblDiasEstabilidade.Text = "Data fim da estabilidade é igual\n a data de demissão!";
                    btnCalcular.Enabled = false;
                    mktDataEstabilidade.Focus();
                }
                else
                {
                    lblDiasEstabilidade.Text = "Dias: " + diasEstabilidade.Days;
                    btnCalcular.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCalculoEstabilidade_Load(object sender, EventArgs e)
        {
            ListarEmpregado();
        }
    }
}
