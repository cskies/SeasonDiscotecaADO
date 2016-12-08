using System.Collections.Generic;

namespace Season.Repositoris.Comum
{
    public interface IRepositorioGenerico<Tmodelo, Tchave>
        where Tmodelo : class
    {
        List<Tmodelo> Selecionar();
        Tmodelo SelecionarPorChave(Tchave id);
        void Inserir(Tmodelo modelo);
        void Atualizar(Tmodelo modelo);
        void Excluir(Tmodelo modelo);
        int Contar();
    }
}
