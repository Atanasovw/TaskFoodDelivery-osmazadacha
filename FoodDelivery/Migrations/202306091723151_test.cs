namespace FoodDelivery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Grammage = c.Double(nullable: false),
                        DishTypeId = c.Int(nullable: false),
                        DishTypes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DishTypes", t => t.DishTypes_Id)
                .Index(t => t.DishTypes_Id);
            
            CreateTable(
                "dbo.DishTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dishes", "DishTypes_Id", "dbo.DishTypes");
            DropIndex("dbo.Dishes", new[] { "DishTypes_Id" });
            DropTable("dbo.DishTypes");
            DropTable("dbo.Dishes");
        }
    }
}
