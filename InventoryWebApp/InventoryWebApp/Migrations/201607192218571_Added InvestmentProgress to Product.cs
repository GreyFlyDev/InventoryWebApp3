namespace InventoryWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInvestmentProgresstoProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "InvestmentProgress", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "InvestmentProgress");
        }
    }
}
