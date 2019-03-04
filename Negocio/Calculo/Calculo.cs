using BancoDados;
using Objetos.Calculo;
using System;
using System.Data;
using System.Text;


namespace Negocio.Calculo
{
    public class Calculo
    {
        CRUD crud;
        StringBuilder sqlBuilder;
        string SQL;

        public bool Gravar(CalculoObjeto calculo)
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();
            sqlBuilder.Append("INSERT INTO Calculo (Tipo_Calculo, Data_Estabilidade, Dias, Valor_Indenizacao, Valor_Decimo_Terceiro, Valor_Ferias, Valor_Terco_Ferias, Valor_FGTS8, Valor_FGTS40, Valor_Total, Id_Empregado, Complemento) ");
            sqlBuilder.Append("VALUES(@Tipo_Calculo, @Data_Estabilidade, @Dias, @Valor_Indenizacao, @Valor_Decimo_Terceiro, @Valor_Ferias, @Valor_Terco_Ferias, @Valor_FGTS8, @Valor_FGTS40, @Valor_Total, @Id_Empregado, @Complemento)");

            SQL = sqlBuilder.ToString();

            try
            {

                crud.LimparParametro();
                crud.AdicionarParamentro("Tipo_Calculo", calculo.TipoCalculo);
                crud.AdicionarParamentro("Data_Estabilidade", calculo.DataEstabilidade);
                crud.AdicionarParamentro("Dias", calculo.Dias);
                crud.AdicionarParamentro("Valor_Indenizacao", calculo.ValorIndenizacao);
                crud.AdicionarParamentro("Valor_Decimo_Terceiro", calculo.ValorDecimoTerceiro);
                crud.AdicionarParamentro("Valor_Ferias", calculo.ValorFerias);
                crud.AdicionarParamentro("Valor_Terco_Ferias", calculo.ValorTercoFerias);
                crud.AdicionarParamentro("Valor_FGTS8", calculo.FGTS8);
                crud.AdicionarParamentro("Valor_FGTS40", calculo.FGTS40);
                crud.AdicionarParamentro("Valor_Total", calculo.ValorTotal);
                crud.AdicionarParamentro("Id_Empregado", calculo.Empregado.Id);
                crud.AdicionarParamentro("Complemento", calculo.Complemento);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public bool ExcluirPorId(CalculoObjeto calculo)
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();
            sqlBuilder.Append("DELETE FROM Calculo ");
            sqlBuilder.Append("WHERE Id = @Id");

            SQL = sqlBuilder.ToString();
            try
            {

                crud.LimparParametro();
                crud.AdicionarParamentro("Id", calculo.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public bool ExcluirPorEmpregado(CalculoObjeto calculo)
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();
            sqlBuilder.Append("DELETE FROM Calculo ");
            sqlBuilder.Append("WHERE Id_Empregado = @Id_Empregado");

            SQL = sqlBuilder.ToString();
            try
            {

                crud.LimparParametro();
                crud.AdicionarParamentro("Id_Empregado", calculo.Empregado.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public bool Existe(CalculoObjeto calculo)
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();

            sqlBuilder.Append("SELECT COUNT(*) ");
            sqlBuilder.Append("FROM Calculo ");
            sqlBuilder.Append("WHERE Id_Empregado = @Id_Empregado");

            SQL = sqlBuilder.ToString();

            try
            {

                crud.LimparParametro();
                crud.AdicionarParamentro("Id_Empregado", calculo.Empregado.Id);
                int count = int.Parse(crud.Executar(CommandType.Text, SQL).ToString());
                if (count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable Listar()
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();
            sqlBuilder.Append("SELECT Calculo.Id, Calculo.Tipo_Calculo, Calculo.Data_Estabilidade, Calculo.Dias, Calculo.Valor_Indenizacao, Calculo.Valor_Decimo_Terceiro, ");
            sqlBuilder.Append("Calculo.Valor_Ferias, Calculo.Valor_Terco_Ferias, Calculo.Valor_FGTS8, Calculo.Valor_FGTS40, Calculo.Valor_Total, Empregado.Matricula, ");
            sqlBuilder.Append("Empregado.Nome, Empregado.Admissao, Empregado.Demissao, Empregado.Media, Complemento.Descricao, Complemento.Valor, Complemento.Tipo  ");
            sqlBuilder.Append("FROM Calculo ");
            sqlBuilder.Append("LEFT JOIN Empregado ON Calculo.Id_Empregado = Empregado.Id ");
            sqlBuilder.Append("LEFT JOIN Complemento ON Complemento.Id_Empregado = Empregado.Id ");


            SQL = sqlBuilder.ToString();

            try
            {
                DataTable dataTable = crud.Consulta(CommandType.Text, SQL);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ListarDemonstrativo(int idEmpregado, int IdCalculo)
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();
            sqlBuilder.Append("SELECT Calculo.Id, Calculo.Tipo_Calculo, Calculo.Data_Estabilidade, Calculo.Dias, Calculo.Valor_Indenizacao, Calculo.Valor_Decimo_Terceiro, ");
            sqlBuilder.Append("Calculo.Valor_Ferias, Calculo.Valor_Terco_Ferias, Calculo.Valor_FGTS8, Calculo.Valor_FGTS40, Calculo.Valor_Total, Empregado.Matricula, ");
            sqlBuilder.Append("Empregado.Nome, Empregado.Admissao, Empregado.Demissao, Empregado.Media, Complemento.Descricao, Complemento.Valor, Complemento.Tipo  ");
            sqlBuilder.Append("FROM Calculo ");
            sqlBuilder.Append("LEFT JOIN Empregado ON Calculo.Id_Empregado = Empregado.Id ");
            sqlBuilder.Append("LEFT JOIN Complemento ON Complemento.Id_Empregado = Empregado.Id ");
            sqlBuilder.Append("WHERE Empregado.Id = @Id AND Calculo.Id = @IdCalculo");

            SQL = sqlBuilder.ToString();

            try
            {
                crud.LimparParametro();
                crud.AdicionarParamentro("Id", idEmpregado);
                crud.AdicionarParamentro("IdCalculo", IdCalculo);
                DataTable dataTable = crud.Consulta(CommandType.Text, SQL);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ListarDemonstrativo0(int idEmpregado)
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();
            sqlBuilder.Append("SELECT Calculo.Id, Calculo.Tipo_Calculo, Calculo.Data_Estabilidade, Calculo.Dias, Calculo.Valor_Indenizacao, Calculo.Valor_Decimo_Terceiro, ");
            sqlBuilder.Append("Calculo.Valor_Ferias, Calculo.Valor_Terco_Ferias, Calculo.Valor_FGTS8, Calculo.Valor_FGTS40, Calculo.Valor_Total, Empregado.Matricula, ");
            sqlBuilder.Append("Empregado.Nome, Empregado.Admissao, Empregado.Demissao, Empregado.Media, Complemento.Descricao, Complemento.Valor, Complemento.Tipo  ");
            sqlBuilder.Append("FROM Calculo ");
            sqlBuilder.Append("LEFT JOIN Empregado ON Calculo.Id_Empregado = Empregado.Id ");
            sqlBuilder.Append("LEFT JOIN Complemento ON Complemento.Id_Empregado = Empregado.Id ");
            sqlBuilder.Append("WHERE Empregado.Id = @Id ");
            sqlBuilder.Append("ORDER BY Calculo.Id DESC");

            SQL = sqlBuilder.ToString();

            try
            {
                crud.LimparParametro();
                crud.AdicionarParamentro("Id", idEmpregado);
                DataTable dataTable = crud.Consulta(CommandType.Text, SQL);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ValorTotal(int matricula)
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();
            sqlBuilder.Append("SELECT Calculo.Id, Calculo.Valor_Total ");
            sqlBuilder.Append("FROM Calculo ");
            sqlBuilder.Append("LEFT JOIN Empregado ON Calculo.Id_Empregado = Empregado.Id ");
            sqlBuilder.Append("WHERE Empregado.Matricula = @Matricula ");
            sqlBuilder.Append("ORDER BY Calculo.Valor_Total");

            SQL = sqlBuilder.ToString();

            try
            {
                crud.LimparParametro();
                crud.AdicionarParamentro("Matricula", matricula);

                DataTable dataTable = crud.Consulta(CommandType.Text, SQL);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
