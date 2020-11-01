namespace jogos.Filmes.Dados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jogos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                        Desenvolvedora = c.String(nullable: false, maxLength: 200),
                        Publicadora = c.String(nullable: false, maxLength: 200),
                        AnodeLançamento = c.Int(name: "Ano de Lançamento", nullable: false),
                        Plataforma = c.String(nullable: false, maxLength: 100),
                        Genero = c.String(nullable: false, maxLength: 100),
                        Enredo = c.String(maxLength: 1200),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jogos");
        }
    }
}
