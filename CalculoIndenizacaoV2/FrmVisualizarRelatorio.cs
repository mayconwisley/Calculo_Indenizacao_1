using CalculoIndenizacao.Relatorios;
using Microsoft.Reporting.WinForms;
using Negocio.Calculo;
using System;
using System.Data;
using System.Windows.Forms;

namespace CalculoIndenizacao
{
    public partial class FrmVisualizarRelatorio : Form
    {
        ReportDataSource reportDataSource;
        Calculo calculo;
        Relatorio relatorio;
        int idEmpregado;
        int idCalculo = 0;
        public FrmVisualizarRelatorio()
        {
            InitializeComponent();
        }

        public FrmVisualizarRelatorio(int empregadoId, int calculoId)
        {
            InitializeComponent();
            idEmpregado = empregadoId;
            idCalculo = calculoId;
        }

        public FrmVisualizarRelatorio(int empregadoId)
        {
            InitializeComponent();
            idEmpregado = empregadoId;
        }


        public void GerarRelatorio(int empregadoId)
        {
            calculo = new Calculo();
            relatorio = new Relatorio();

            DataTable dataTable = calculo.ListarDemonstrativo(empregadoId, idCalculo);


            foreach (DataRow row in dataTable.Rows)
            {
                DataRow dataRow = relatorio.Demonstrativo.NewRow();
                dataRow["Id"] = row["Id"];
                dataRow["Tipo_Calculo"] = row["Tipo_Calculo"];
                dataRow["Data_Estabilidade"] = row["Data_Estabilidade"];
                dataRow["Dias"] = row["Dias"];
                dataRow["Valor_Indenizacao"] = row["Valor_Indenizacao"];
                dataRow["Valor_Decimo_Terceiro"] = row["Valor_Decimo_Terceiro"];
                dataRow["Valor_Ferias"] = row["Valor_Ferias"];
                dataRow["Valor_Terco_Ferias"] = row["Valor_Terco_Ferias"];
                dataRow["Valor_FGTS8"] = row["Valor_FGTS8"];
                dataRow["Valor_FGTS40"] = row["Valor_FGTS40"];
                dataRow["Valor_Total"] = row["Valor_Total"];
                dataRow["Matricula"] = row["Matricula"];
                dataRow["Nome"] = row["Nome"];
                dataRow["Admissao"] = row["Admissao"];
                dataRow["Demissao"] = row["Demissao"];
                dataRow["Media"] = row["Media"];
                dataRow["Descricao"] = row["Descricao"];
                dataRow["Valor"] = row["Valor"];
                dataRow["Tipo"] = row["Tipo"];

                relatorio.Demonstrativo.Rows.Add(dataRow);
            }
        }

        public void GerarRelatorio0(int empregadoId)
        {
            calculo = new Calculo();
            relatorio = new Relatorio();

            DataTable dataTable = calculo.ListarDemonstrativo0(empregadoId);


            foreach (DataRow row in dataTable.Rows)
            {
                DataRow dataRow = relatorio.Demonstrativo.NewRow();
                dataRow["Id"] = row["Id"];
                dataRow["Tipo_Calculo"] = row["Tipo_Calculo"];
                dataRow["Data_Estabilidade"] = row["Data_Estabilidade"];
                dataRow["Dias"] = row["Dias"];
                dataRow["Valor_Indenizacao"] = row["Valor_Indenizacao"];
                dataRow["Valor_Decimo_Terceiro"] = row["Valor_Decimo_Terceiro"];
                dataRow["Valor_Ferias"] = row["Valor_Ferias"];
                dataRow["Valor_Terco_Ferias"] = row["Valor_Terco_Ferias"];
                dataRow["Valor_FGTS8"] = row["Valor_FGTS8"];
                dataRow["Valor_FGTS40"] = row["Valor_FGTS40"];
                dataRow["Valor_Total"] = row["Valor_Total"];
                dataRow["Matricula"] = row["Matricula"];
                dataRow["Nome"] = row["Nome"];
                dataRow["Admissao"] = row["Admissao"];
                dataRow["Demissao"] = row["Demissao"];
                dataRow["Media"] = row["Media"];
                dataRow["Descricao"] = row["Descricao"];
                dataRow["Valor"] = row["Valor"];
                dataRow["Tipo"] = row["Tipo"];

                relatorio.Demonstrativo.Rows.Add(dataRow);
            }
        }


        private void FrmVisualizarRelatorio_Load(object sender, EventArgs e)
        {
            reportDataSource = new ReportDataSource();

            try
            {
                if (idCalculo != 0)
                {
                    GerarRelatorio(idEmpregado); 
                }
                else
                {
                    GerarRelatorio0(idEmpregado);
                }
                reportDataSource.Name = "CalcDemonstrativo";
                reportDataSource.Value = relatorio.Demonstrativo;
                RvVisualizarRelatorio.LocalReport.DataSources.Clear();
                RvVisualizarRelatorio.LocalReport.DataSources.Add(reportDataSource);
                RvVisualizarRelatorio.LocalReport.ReportPath = @"Relatorios\Demonstrativo.rdlc";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.RvVisualizarRelatorio.RefreshReport();
            this.RvVisualizarRelatorio.SetDisplayMode(DisplayMode.PrintLayout);
            this.RvVisualizarRelatorio.ZoomMode = ZoomMode.Percent;
            this.RvVisualizarRelatorio.ZoomPercent = 100;
            this.RvVisualizarRelatorio.RefreshReport();
        }
    }
}
