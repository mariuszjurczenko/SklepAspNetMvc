namespace PraktyczneKursy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usunieciePolaTest : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Kurs", "Test");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kurs", "Test", c => c.String());
        }
    }
}
