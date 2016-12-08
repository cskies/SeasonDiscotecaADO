using Season.Comum.DAO.Interfaces;
using Season.Discoteca.AcessoDados.ADONET;
using Season.Discoteca.Dominio;
using Season.Repositoris.Comum;
using System.Collections.Generic;

namespace Season.Discoteca.Repositorios
{
    public class MusicaRepositorio : IRepositorioGenerico<Musica, long>
    {

        private IDAO<Musica, long> _musicaDAO = new MusicaDAO();

        public List<Musica> Selecionar()
        {
            return _musicaDAO.Selecionar();
        }

        public Musica SelecionarPorChave(long id)
        {
            return _musicaDAO.SelecionarPorId(id);
        }

        public void Inserir(Musica modelo)
        {
            _musicaDAO.inserir(modelo);
        }

        public void Atualizar(Musica modelo)
        {
            _musicaDAO.Atualizar(modelo);
        }

        public void Excluir(Musica modelo)
        {
            _musicaDAO.Excluir(modelo);
        }

        public int Contar()
        {
            return _musicaDAO.Contar();
        }
    }
}
