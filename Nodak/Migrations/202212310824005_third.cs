namespace Nodak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "Course_Id" });
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Family = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Address = c.String(),
                        IsMarried = c.Boolean(nullable: false),
                        InCome = c.Int(nullable: false),
                        Course_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.Course_Id);
            
            DropColumn("dbo.Students", "Course_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Course_Id", c => c.Guid());
            DropForeignKey("dbo.Teachers", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Teachers", new[] { "Course_Id" });
            DropTable("dbo.Teachers");
            CreateIndex("dbo.Students", "Course_Id");
            AddForeignKey("dbo.Students", "Course_Id", "dbo.Courses", "Id");
        }
    }
}
