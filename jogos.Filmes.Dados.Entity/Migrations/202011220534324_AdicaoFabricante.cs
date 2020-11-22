namespace jogos.Filmes.Dados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicaoFabricante : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Plataforma", "NomeFabricante", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Plataforma", "NomeFabricante");
        }
    }
}
