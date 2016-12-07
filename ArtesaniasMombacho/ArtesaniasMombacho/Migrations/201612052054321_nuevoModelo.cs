namespace ArtesaniasMombacho.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nuevoModelo : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoryId", c => c.Int());
        }
    }
}
