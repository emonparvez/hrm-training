namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig011 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "DivisionName");
            DropColumn("dbo.Employees", "DepartmentName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "DepartmentName", c => c.String());
            AddColumn("dbo.Employees", "DivisionName", c => c.String());
        }
    }
}
