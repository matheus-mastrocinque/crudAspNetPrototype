namespace PrototipoUnip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCodeAluno : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.pessoas");
            AddColumn("dbo.pessoas", "codigo", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.pessoas", "nome", c => c.String());
            AddPrimaryKey("dbo.pessoas", "codigo");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.pessoas");
            AlterColumn("dbo.pessoas", "nome", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.pessoas", "codigo");
            AddPrimaryKey("dbo.pessoas", "nome");
        }
    }
}
