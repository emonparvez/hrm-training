namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig02 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Depts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeptCode = c.String(),
                        DeptName = c.String(),
                        DivisionsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Divisions", t => t.DivisionsId, cascadeDelete: true)
                .Index(t => t.DivisionsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Depts", "DivisionsId", "dbo.Divisions");
            DropIndex("dbo.Depts", new[] { "DivisionsId" });
            DropTable("dbo.Depts");
        }
    }
}
