namespace PrototipoUnip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.pessoas",
                c => new
                    {
                        nome = c.String(nullable: false, maxLength: 128),
                        cpf = c.String(),
                        logradouro = c.String(),
                        numero = c.Int(nullable: false),
                        cep = c.String(),
                        bairro = c.String(),
                        cidade = c.String(),
                        estado = c.String(),
                        telefone = c.String(),
                    })
                .PrimaryKey(t => t.nome);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.pessoas");
        }
    }
}
