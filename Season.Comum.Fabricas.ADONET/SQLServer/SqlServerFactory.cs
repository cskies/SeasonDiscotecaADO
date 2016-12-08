using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Season.Comum.Fabricas.ADONET.SQLServer
{
    public static class SqlServerFactory
    {
        //estrutura static só acessa estrut static //const var = MAIUSCULO = sempre static a constante
        private const string STRING_CONEXAO = @"Server=.\SQLEXPRESS;Database=TesteADONET;User Id=sa; Password=masterkey"; //encapsula string conexao

        //factorIES_Method Pattern

        public static DbConnection CriarConexao()
        {
            //const != readOnly (semânticas diferentes)
            DbConnection conexao = new SqlConnection(STRING_CONEXAO);
            conexao.Open();
            return conexao;
        }

        public static DbCommand CriarComando(DbConnection conexao, string sql)
        {
            DbCommand comando = conexao.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;
            return comando;
        }

        //reference type
        public static void CriarParametro(DbCommand comando, string nomeParametro, object valorParametro)
        {
            DbParameter parametro = comando.CreateParameter();
            parametro.ParameterName = nomeParametro;
            if (valorParametro == null)
            {
                parametro.Value = DBNull.Value;
            }
            else
            {
                parametro.Value = valorParametro;
            }
            comando.Parameters.Add(parametro);
        }

        public static DbDataReader CriarReader(DbCommand comando)
        {
            return comando.ExecuteReader();
        }

        public static void ExecutarNonQuery(DbCommand comando)
        {
            comando.ExecuteNonQuery();
        }

        public static object ExecutarScalar(DbCommand comando)
        {
            return comando.ExecuteScalar();

        }

        public static void FecharConexao(DbConnection conexao)
        {
            conexao.Close();
        }

        internal static void ExecutarNonQuery()
        {
            throw new NotImplementedException();
        }


    }
}
