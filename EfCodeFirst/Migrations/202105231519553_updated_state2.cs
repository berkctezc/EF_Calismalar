namespace EfCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updated_state2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "Detail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Detail", c => c.String());
        }
    }
}
