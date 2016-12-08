using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Season.Comum.DAO.Interfaces
{
    public interface IDAO<TModelo, TChave> //T = convencao Type 
        where TModelo : class              // restr no Tmodelo para fixar em classe, não data type (forca somente class)
    {
        List<TModelo> Selecionar(); //tipo precisa ser flexivel pra atender todos os DAO = GENERIC
        TModelo SelecionarPorId(TChave id);
        void inserir(TModelo modelo);
        void Atualizar(TModelo modelo);
        void Excluir(TModelo modelo);
        void ExcluirId(TChave id);
        int Contar();
    }
}
