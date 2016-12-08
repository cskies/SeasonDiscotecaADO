using Season.Discoteca.Dominio;
using System.Data.Entity;

namespace Season.Discoteca.AcessoDados.Entity.Context
{
    public class DiscotecaDbContext : DbContext //data context. represents dataBase (tables)
    {
        //DbSet tab do enttity
        public DbSet<Musica> Musicas { get; set; }
    }
}
