using Negocio.Calculo;
using System.Data;

namespace CalculoIndenizacao.Relatorios
{
    public class RelatorioDemonstrativo
    {
        Calculo calculo;
        Relatorio relatorio;


        public void GerarRelatorio(int empregadoId, int calculoId)
        {
            calculo = new Calculo();
            relatorio = new Relatorio();

            DataTable dataTable = calculo.ListarDemonstrativo(empregadoId, calculoId);


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

    }
}
