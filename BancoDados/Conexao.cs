using System;
using System.Data;
using System.Data.SQLite;

namespace BancoDados
{
    public class Conexao
    {
        protected SQLiteConnection liteConnection;
        private string strConexao = @"Data Source=|DataDirectory|BancoDados\Indenizacao.db; Password=2802feer";

        protected bool Conectar()
        {
            liteConnection = new SQLiteConnection(strConexao);
            try
            {
                liteConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }
        protected bool Desconectar()
        {
            try
            {
                if (liteConnection.State != ConnectionState.Closed)
                {
                    liteConnection.Close();
                    liteConnection.Dispose();
                    return true;
                }
                else
                {
                    liteConnection.Dispose();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
