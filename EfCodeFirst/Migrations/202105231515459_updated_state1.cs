namespace EfCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updated_state1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Tag", c => c.String());
            Sql("Update Categories Set Name=Tag");
            DropColumn("dbo.Categories", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Name", c => c.String());
            Sql("Update Categories Set Tag=Name");
            DropColumn("dbo.Categories", "Tag");
        }
    }
}
