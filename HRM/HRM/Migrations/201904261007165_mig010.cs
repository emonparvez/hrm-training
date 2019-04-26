namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig010 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Division_Id", "dbo.Divisions");
            DropIndex("dbo.Employees", new[] { "Division_Id" });
            DropColumn("dbo.Employees", "Division_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Division_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Division_Id");
            AddForeignKey("dbo.Employees", "Division_Id", "dbo.Divisions", "Id");
        }
    }
}
