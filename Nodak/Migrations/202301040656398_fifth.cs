namespace Nodak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifth : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Teachers", new[] { "Course_Id" });
            RenameColumn(table: "dbo.Courses", name: "Course_Id", newName: "Teacher_Id");
            CreateIndex("dbo.Courses", "Teacher_Id");
            DropColumn("dbo.Teachers", "Course_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "Course_Id", c => c.Guid());
            DropIndex("dbo.Courses", new[] { "Teacher_Id" });
            RenameColumn(table: "dbo.Courses", name: "Teacher_Id", newName: "Course_Id");
            CreateIndex("dbo.Teachers", "Course_Id");
        }
    }
}
