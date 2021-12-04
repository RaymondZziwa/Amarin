namespace amarin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Class : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        ClassName = c.String(),
                        Student_StudentId = c.Int(),
                    })
                .PrimaryKey(t => t.ClassId)
                .ForeignKey("dbo.Students", t => t.Student_StudentId)
                .Index(t => t.Student_StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classes", "Student_StudentId", "dbo.Students");
            DropIndex("dbo.Classes", new[] { "Student_StudentId" });
            DropTable("dbo.Classes");
        }
    }
}
