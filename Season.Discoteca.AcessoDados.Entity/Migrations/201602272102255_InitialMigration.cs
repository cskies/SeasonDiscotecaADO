namespace Season.Discoteca.AcessoDados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musicas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Titulo = c.String(),
                        Ano = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Musicas");
        }
    }
}
