namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.movieModels", "Name", c => c.String(maxLength: 60));
            AlterColumn("dbo.movieModels", "Genre", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.movieModels", "Rating", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.movieModels", "Rating", c => c.String());
            AlterColumn("dbo.movieModels", "Genre", c => c.String());
            AlterColumn("dbo.movieModels", "Name", c => c.String());
        }
    }
}
