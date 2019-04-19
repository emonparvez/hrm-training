namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Employee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Designations", "Designation_Id", c => c.Int());
            CreateIndex("dbo.Designations", "Designation_Id");
            AddForeignKey("dbo.Designations", "Designation_Id", "dbo.Designations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Designations", "Designation_Id", "dbo.Designations");
            DropIndex("dbo.Designations", new[] { "Designation_Id" });
            DropColumn("dbo.Designations", "Designation_Id");
        }
    }
}
