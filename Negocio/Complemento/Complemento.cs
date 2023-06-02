using BancoDados;
using Objetos.Complemento;
using Objetos.Empregado;
using System;
using System.Data;
using System.Text;


namespace Negocio.Complemento
{
    public class Complemento
    {

        CRUD crud;
        StringBuilder sqlBuilder;
        string SQL;

        public bool Adicionar(ComplementoObjeto complemento)
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();
            sqlBuilder.Append("INSERT INTO Complemento (Descricao, Valor, Tipo, Id_Empregado) ");
            sqlBuilder.Append("VALUES (@Descricao, @Valor, @Tipo, @Id_Empregado)");
            SQL = sqlBuilder.ToString();

            try
            {
                crud.LimparParametro();
                crud.AdicionarParamentro("Descricao", complemento.Descricao);
                crud.AdicionarParamentro("Valor", complemento.Valor);
                crud.AdicionarParamentro("Tipo", complemento.Tipo);
                crud.AdicionarParamentro("Id_Empregado", complemento.Empregado.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Excluir(ComplementoObjeto complemento)
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();
            sqlBuilder.Append("DELETE FROM Complemento ");
            sqlBuilder.Append("WHERE Id = @Id");

            SQL = sqlBuilder.ToString();

            try
            {
                crud.LimparParametro();
                crud.AdicionarParamentro("Id", complemento.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Lista(EmpregadoObjeto empregado)
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();
            sqlBuilder.Append("SELECT Id, Descricao, Valor, Tipo, Id_Empregado ");
            sqlBuilder.Append("FROM Complemento ");
            sqlBuilder.Append("WHERE Id_Empregado = @Id_Empregado");

            SQL = sqlBuilder.ToString();

            try
            {
                crud.LimparParametro();
                crud.AdicionarParamentro("Id_Empregado", empregado.Id);
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
