namespace jogos.Filmes.Dados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicaoPlataforma : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plataforma",
                c => new
                    {
                        IdPlataforma = c.Long(nullable: false, identity: true),
                        NomePlataforma = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.IdPlataforma);
            
            AlterColumn("dbo.Jogos", "Plataforma", c => c.Long(nullable: false));
            CreateIndex("dbo.Jogos", "Plataforma");
            AddForeignKey("dbo.Jogos", "Plataforma", "dbo.Plataforma", "IdPlataforma", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jogos", "Plataforma", "dbo.Plataforma");
            DropIndex("dbo.Jogos", new[] { "Plataforma" });
            AlterColumn("dbo.Jogos", "Plataforma", c => c.String(nullable: false, maxLength: 100));
            DropTable("dbo.Plataforma");
        }
    }
}
