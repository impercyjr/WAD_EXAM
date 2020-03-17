namespace WAD_Exam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Employee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.nhanviens",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        EmployeeID = c.String(),
                        Department = c.String(),
                        Salary = c.Double(nullable: false),
                        CateroryID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Name)
                .ForeignKey("dbo.Categories", t => t.CateroryID)
                .Index(t => t.CateroryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.nhanviens", "CateroryID", "dbo.Categories");
            DropIndex("dbo.nhanviens", new[] { "CateroryID" });
            DropTable("dbo.nhanviens");
            DropTable("dbo.Categories");
        }
    }
}
