
namespace Season.Discoteca.Dominio
{
    public class Musica
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public int? Ano { get; set; } // ? ou Nullable<int> - pode receber nulo
        public string Notes { get; set; }
    }

}
