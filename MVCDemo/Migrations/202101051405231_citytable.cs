namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class citytable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.tblCitys", newName: "tblCities");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.tblCities", newName: "tblCitys");
        }
    }
}
