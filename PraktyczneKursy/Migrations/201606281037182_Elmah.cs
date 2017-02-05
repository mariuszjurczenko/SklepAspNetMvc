namespace PraktyczneKursy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Elmah : DbMigration
    {
        public override void Up()
        {
            SqlFile("../Migrations/ELMAH-1.2-db-SQLServer.sql");
        }
        
        public override void Down()
        {
        }
    }
}
