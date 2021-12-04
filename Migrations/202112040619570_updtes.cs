namespace amarin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updtes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Class_ClassId", "dbo.Classes");
            DropIndex("dbo.Students", new[] { "Class_ClassId" });
            RenameColumn(table: "dbo.Students", name: "Class_ClassId", newName: "Classes_ClassName");
            DropPrimaryKey("dbo.Classes");
            AlterColumn("dbo.Classes", "ClassName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Students", "Classes_ClassName", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Classes", "ClassName");
            CreateIndex("dbo.Students", "Classes_ClassName");
            AddForeignKey("dbo.Students", "Classes_ClassName", "dbo.Classes", "ClassName");
            DropColumn("dbo.Classes", "ClassId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Classes", "ClassId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Students", "Classes_ClassName", "dbo.Classes");
            DropIndex("dbo.Students", new[] { "Classes_ClassName" });
            DropPrimaryKey("dbo.Classes");
            AlterColumn("dbo.Students", "Classes_ClassName", c => c.Int());
            AlterColumn("dbo.Classes", "ClassName", c => c.String());
            AddPrimaryKey("dbo.Classes", "ClassId");
            RenameColumn(table: "dbo.Students", name: "Classes_ClassName", newName: "Class_ClassId");
            CreateIndex("dbo.Students", "Class_ClassId");
            AddForeignKey("dbo.Students", "Class_ClassId", "dbo.Classes", "ClassId");
        }
    }
}
