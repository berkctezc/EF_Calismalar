namespace EfCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updated_state : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Detail", c => c.String());
            AddColumn("dbo.Customers", "Surname", c => c.String());
            AddColumn("dbo.Customers", "City", c => c.String());
            DropColumn("dbo.Customers", "Title");
            DropColumn("dbo.Customers", "MusteriSehir");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MusteriSehir", c => c.String());
            AddColumn("dbo.Customers", "Title", c => c.String());
            DropColumn("dbo.Customers", "City");
            DropColumn("dbo.Customers", "Surname");
            DropColumn("dbo.Categories", "Detail");
        }
    }
}
