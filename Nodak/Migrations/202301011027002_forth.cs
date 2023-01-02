
namespace Nodak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Student_Id", c => c.Guid());
            CreateIndex("dbo.Courses", "Student_Id");
            AddForeignKey("dbo.Courses", "Student_Id", "dbo.Students", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Student_Id", "dbo.Students");
            DropIndex("dbo.Courses", new[] { "Student_Id" });
            DropColumn("dbo.Courses", "Student_Id");
        }
    }
}
