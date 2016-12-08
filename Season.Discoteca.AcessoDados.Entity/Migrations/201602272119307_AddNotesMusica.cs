namespace Season.Discoteca.AcessoDados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNotesMusica : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musicas", "Notes", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musicas", "Notes");
        }
    }
}
