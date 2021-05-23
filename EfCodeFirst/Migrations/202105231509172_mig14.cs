namespace EfCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig14 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Title", c => c.String());
            DropColumn("dbo.Customers", "Surname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Surname", c => c.String());
            DropColumn("dbo.Customers", "Title");
        }
    }
}
