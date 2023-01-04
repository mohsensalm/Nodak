namespace Nodak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seventh : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teachers", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Teachers", new[] { "Course_Id" });
            AddColumn("dbo.Courses", "Teacher_Id", c => c.Guid());
            AlterColumn("dbo.Students", "Name", c => c.String());
            CreateIndex("dbo.Courses", "Teacher_Id");
            AddForeignKey("dbo.Courses", "Teacher_Id", "dbo.Teachers", "Id");
            DropColumn("dbo.Teachers", "Course_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "Course_Id", c => c.Guid());
            DropForeignKey("dbo.Courses", "Teacher_Id", "dbo.Teachers");
            DropIndex("dbo.Courses", new[] { "Teacher_Id" });
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false, maxLength: 90));
            DropColumn("dbo.Courses", "Teacher_Id");
            CreateIndex("dbo.Teachers", "Course_Id");
            AddForeignKey("dbo.Teachers", "Course_Id", "dbo.Courses", "Id");
        }
    }
}
