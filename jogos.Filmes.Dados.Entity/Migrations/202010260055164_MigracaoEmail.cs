namespace jogos.Filmes.Dados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jogos", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jogos", "Email");
        }
    }
}
