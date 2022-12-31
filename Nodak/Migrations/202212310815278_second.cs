namespace Nodak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        IsPass = c.Boolean(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "Course_Id", c => c.Guid());
            CreateIndex("dbo.Students", "Course_Id");
            AddForeignKey("dbo.Students", "Course_Id", "dbo.Courses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "Course_Id" });
            DropColumn("dbo.Students", "Course_Id");
            DropTable("dbo.Courses");
        }
    }
}
