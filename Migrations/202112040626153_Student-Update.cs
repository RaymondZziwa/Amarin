namespace amarin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentUpdate : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Students", name: "Classes_ClassName", newName: "Class_ClassName");
            RenameIndex(table: "dbo.Students", name: "IX_Classes_ClassName", newName: "IX_Class_ClassName");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Students", name: "IX_Class_ClassName", newName: "IX_Classes_ClassName");
            RenameColumn(table: "dbo.Students", name: "Class_ClassName", newName: "Classes_ClassName");
        }
    }
}
