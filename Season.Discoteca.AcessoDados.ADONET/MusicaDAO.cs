using Season.Comum.DAO.Interfaces;
using Season.Comum.Fabricas.ADONET.SQLServer;
using Season.Discoteca.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Season.Discoteca.AcessoDados.ADONET
{
    public class MusicaDAO : IDAO<Musica, long>
    {
        public List<Musica> Selecionar()
        {
            List<Musica> resultado = new List<Musica>();

            DbConnection conexao = SqlServerFactory.CriarConexao();


            //DbCommand comando = conexao.CreateCommand();
            //comando.CommandText = "SELECT * FROM MUS_MUSICAS";
            //comando.CommandType = CommandType.Text;

            DbCommand comando = SqlServerFactory.CriarComando(conexao, "SELECT * FROM MUS_MUSICAS");
            DbDataReader reader = SqlServerFactory.CriarReader(comando);

            while (reader.Read())
            {
                Musica novaMusica = new Musica();
                novaMusica.Id = long.Parse(reader["MUS_ID"].ToString()); //impedancia = parse necessario
                novaMusica.Titulo = reader["MUS_Titulo"].ToString();

                //novaMusica.Ano = reader["MUS_ANO"] is DBNull ? null : novaMusica.Ano = int.Parse(reader["MUS_ANO"].ToString()); // operador ternario

                if (reader["MUS_ANO"] is DBNull)
                {
                    novaMusica.Ano = null;
                }
                else
                {
                    novaMusica.Ano = int.Parse(reader["MUS_ANO"].ToString());
                }

                resultado.Add(novaMusica);
            }

            SqlServerFactory.FecharConexao(conexao);

            return resultado;
        }

        public Musica SelecionarPorId(long id)
        {
            Musica musica = null;
            DbConnection conexao = SqlServerFactory.CriarConexao();
            DbCommand comando = SqlServerFactory.CriarComando(conexao, "SELECT * FROM MUS_MUSICAS WHERE MUS_ID = @id");
            SqlServerFactory.CriarParametro(comando, "@id", id);
            DbDataReader reader = SqlServerFactory.CriarReader(comando);

            if (reader.Read())
            {
                musica = new Musica
                {
                    Id = Convert.ToInt32(reader["MUS_ID"]),
                    Titulo = reader["MUS_TITULO"].ToString()
                };
                if (reader["MUS_ANO"] is DBNull)
                {
                    musica.Ano = null;
                }
                else
                {
                    musica.Ano = Convert.ToInt32(reader["MUS_ANO"]);
                }
            }

            SqlServerFactory.FecharConexao(conexao);
            return musica;

        }

        public void inserir(Musica modelo)
        {
            DbConnection conexao = SqlServerFactory.CriarConexao();
            DbCommand comando = SqlServerFactory.CriarComando(conexao, "INSERT INTO MUS_MUSICAS (MUS_TITULO, MUS_ANO) VALUES (@titulo, @ano)");
            SqlServerFactory.CriarParametro(comando, "@titulo", modelo.Titulo);
            SqlServerFactory.CriarParametro(comando, "@ano", modelo.Ano);  
            SqlServerFactory.ExecutarNonQuery(comando);
            SqlServerFactory.FecharConexao(conexao);
        }

        public void Atualizar(Musica modelo)
        {
            DbConnection conexao = SqlServerFactory.CriarConexao();
            DbCommand comando = SqlServerFactory.CriarComando(conexao, "UPDATE MUS_MUSICAS SET MUS_TITULO = @titulo, MUS_ANO = @ano WHERE MUS_ID = @id");

            SqlServerFactory.CriarParametro(comando, "@id", modelo.Id);
            SqlServerFactory.CriarParametro(comando, "@titulo", modelo.Titulo);
            SqlServerFactory.CriarParametro(comando, "@ano", modelo.Ano);

            SqlServerFactory.ExecutarNonQuery(comando);
            SqlServerFactory.FecharConexao(conexao);

        }

        public void Excluir(Musica modelo)
        {
            ExcluirId(modelo.Id);
        }

        public void ExcluirId(long id)
        {
            //1 or 1 = 1 injection test
            DbConnection conexao = SqlServerFactory.CriarConexao();
            DbCommand comando = SqlServerFactory.CriarComando(conexao, "DELETE FROM MUS_MUSICAS WHERE MUS_ID = @id");

            SqlServerFactory.CriarParametro(comando, "@id", id);
            SqlServerFactory.ExecutarNonQuery(comando);
            SqlServerFactory.FecharConexao(conexao);
            
        }

        public int Contar()
        {
            DbConnection conexao = SqlServerFactory.CriarConexao();
            DbCommand comando = SqlServerFactory.CriarComando(conexao, "SELECT COUNT (*) MUS_MUSICAS");
            int resultado = (int)SqlServerFactory.ExecutarScalar(comando);
            SqlServerFactory.FecharConexao(conexao);
            return resultado;
        }
    }
}

