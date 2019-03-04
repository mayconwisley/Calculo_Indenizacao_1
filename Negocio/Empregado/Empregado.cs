using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados;
using Objetos.Empregado;

namespace Negocio.Empregado
{
    public class Empregado
    {
        CRUD crud;
        StringBuilder sqlBuilder;
        string SQL;

        public bool Gravar(EmpregadoObjeto empregado)
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();
            sqlBuilder.Append("INSERT INTO Empregado (Matricula, Nome, Admissao, Demissao, Media, Base) ");
            sqlBuilder.Append("VALUES(@Matricula, @Nome, @Admissao, @Demissao, @Media, @Base)");

            SQL = sqlBuilder.ToString();

            try
            {
                crud.LimparParametro();
                crud.AdicionarParamentro("Matricula", empregado.Matricula);
                crud.AdicionarParamentro("Nome", empregado.Nome);
                crud.AdicionarParamentro("Admissao", empregado.Admissao);
                crud.AdicionarParamentro("Demissao", empregado.Demissao);
                crud.AdicionarParamentro("Media", empregado.Media);
                crud.AdicionarParamentro("Base", empregado.Base);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public bool Alterar(EmpregadoObjeto empregado)
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();

            sqlBuilder.Append("UPDATE Empregado SET Matricula = @Matricula, Nome = @Nome, Admissao = @Admissao, Demissao = @Demissao, Media = @Media, Base = @Base ");
            sqlBuilder.Append("WHERE Id = @Id");
            SQL = sqlBuilder.ToString();

            try
            {
                crud.LimparParametro();
                crud.AdicionarParamentro("Matricula", empregado.Matricula);
                crud.AdicionarParamentro("Nome", empregado.Nome);
                crud.AdicionarParamentro("Admissao", empregado.Admissao);
                crud.AdicionarParamentro("Demissao", empregado.Demissao);
                crud.AdicionarParamentro("Media", empregado.Media);
                crud.AdicionarParamentro("Base", empregado.Base);
                crud.AdicionarParamentro("Id", empregado.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public bool Excluir(EmpregadoObjeto empregado)
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();
            sqlBuilder.Append("DELETE FROM Empregado ");
            sqlBuilder.Append("WHERE Id = @Id");

            SQL = sqlBuilder.ToString();

            try
            {
                crud.LimparParametro();
                crud.AdicionarParamentro("Id", empregado.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Lista()
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();
            sqlBuilder.Append("SELECT Id, Matricula, Nome, Admissao, Demissao, Media, Base ");
            sqlBuilder.Append("FROM Empregado ");
            sqlBuilder.Append("ORDER BY Nome");

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

        public DataTable ListaCombobox()
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();
            sqlBuilder.Append("SELECT Id, Matricula || ' - ' || Nome AS Nome ");
            sqlBuilder.Append("FROM Empregado ");
            sqlBuilder.Append("ORDER BY Nome");

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

        public DataTable DadosEmpregado(EmpregadoObjeto empregado)
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();

            sqlBuilder.Append("SELECT Id, Matricula, Nome, Admissao, Demissao, Media, Base ");
            sqlBuilder.Append("FROM Empregado ");
            sqlBuilder.Append("WHERE Id = @Id");

            SQL = sqlBuilder.ToString();

            try
            {
                crud.LimparParametro();
                crud.AdicionarParamentro("Id", empregado.Id);
                DataTable dataTable = crud.Consulta(CommandType.Text, SQL);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Id(string matricula)
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();
            sqlBuilder.Append("SELECT Id ");
            sqlBuilder.Append("FROM Empregado ");
            sqlBuilder.Append("WHERE Matricula = @Matricula");

            SQL = sqlBuilder.ToString();

            try
            {
                crud.LimparParametro();
                crud.AdicionarParamentro("Matricula", matricula);
                return int.Parse(crud.Executar(CommandType.Text, SQL).ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Matricula(int Id)
        {
            crud = new CRUD();
            sqlBuilder = new StringBuilder();
            sqlBuilder.Append("SELECT Matricula ");
            sqlBuilder.Append("FROM Empregado ");
            sqlBuilder.Append("WHERE Id = @Id");

            SQL = sqlBuilder.ToString();

            try
            {
                crud.LimparParametro();
                crud.AdicionarParamentro("Id", Id);
                return int.Parse(crud.Executar(CommandType.Text, SQL).ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
