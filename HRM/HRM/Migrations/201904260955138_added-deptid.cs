namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeddeptid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "MobileNumber", c => c.String(maxLength: 15));
            AddColumn("dbo.Employees", "Email", c => c.String(maxLength: 100));
            AddColumn("dbo.Employees", "DivisionName", c => c.String());
            AddColumn("dbo.Employees", "DepartmentName", c => c.String());
            AddColumn("dbo.Employees", "BloodGroup", c => c.String(maxLength: 150));
            AddColumn("dbo.Employees", "Address", c => c.String(maxLength: 150));
            AddColumn("dbo.Employees", "DeptId", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "Division_Id", c => c.Int());
            CreateIndex("dbo.Employees", "DeptId");
            CreateIndex("dbo.Employees", "Division_Id");
            AddForeignKey("dbo.Employees", "DeptId", "dbo.Depts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Employees", "Division_Id", "dbo.Divisions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Division_Id", "dbo.Divisions");
            DropForeignKey("dbo.Employees", "DeptId", "dbo.Depts");
            DropIndex("dbo.Employees", new[] { "Division_Id" });
            DropIndex("dbo.Employees", new[] { "DeptId" });
            DropColumn("dbo.Employees", "Division_Id");
            DropColumn("dbo.Employees", "DeptId");
            DropColumn("dbo.Employees", "Address");
            DropColumn("dbo.Employees", "BloodGroup");
            DropColumn("dbo.Employees", "DepartmentName");
            DropColumn("dbo.Employees", "DivisionName");
            DropColumn("dbo.Employees", "Email");
            DropColumn("dbo.Employees", "MobileNumber");
        }
    }
}
