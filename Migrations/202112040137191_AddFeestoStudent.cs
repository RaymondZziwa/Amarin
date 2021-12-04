namespace amarin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFeestoStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "fees_FeesBal", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "fees_FeesBal");
        }
    }
}
