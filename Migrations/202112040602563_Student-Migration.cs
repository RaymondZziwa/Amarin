namespace amarin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Classes", "Student_StudentId", "dbo.Students");
            DropIndex("dbo.Classes", new[] { "Student_StudentId" });
            AddColumn("dbo.Students", "fees_FeesBalance", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "Class_ClassId", c => c.Int());
            CreateIndex("dbo.Students", "Class_ClassId");
            AddForeignKey("dbo.Students", "Class_ClassId", "dbo.Classes", "ClassId");
            DropColumn("dbo.Classes", "Student_StudentId");
            DropColumn("dbo.Students", "fees_FeesBal");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "fees_FeesBal", c => c.Int(nullable: false));
            AddColumn("dbo.Classes", "Student_StudentId", c => c.Int());
            DropForeignKey("dbo.Students", "Class_ClassId", "dbo.Classes");
            DropIndex("dbo.Students", new[] { "Class_ClassId" });
            DropColumn("dbo.Students", "Class_ClassId");
            DropColumn("dbo.Students", "fees_FeesBalance");
            CreateIndex("dbo.Classes", "Student_StudentId");
            AddForeignKey("dbo.Classes", "Student_StudentId", "dbo.Students", "StudentId");
        }
    }
}
