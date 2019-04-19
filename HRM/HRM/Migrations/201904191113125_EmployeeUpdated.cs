namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeUpdated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Designations", "Designation_Id", "dbo.Designations");
            DropIndex("dbo.Designations", new[] { "Designation_Id" });
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeCode = c.String(maxLength: 10),
                        EmployeeName = c.String(maxLength: 150),
                        NickName = c.String(maxLength: 150),
                        FatherName = c.String(maxLength: 150),
                        MotherName = c.String(maxLength: 150),
                        Desig = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Designations", t => t.Desig, cascadeDelete: true)
                .Index(t => t.Desig);
            
            DropColumn("dbo.Designations", "Designation_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Designations", "Designation_Id", c => c.Int());
            DropForeignKey("dbo.Employees", "Desig", "dbo.Designations");
            DropIndex("dbo.Employees", new[] { "Desig" });
            DropTable("dbo.Employees");
            CreateIndex("dbo.Designations", "Designation_Id");
            AddForeignKey("dbo.Designations", "Designation_Id", "dbo.Designations", "Id");
        }
    }
}
