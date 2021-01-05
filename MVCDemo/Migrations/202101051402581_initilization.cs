namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initilization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCitys",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        State_StateId = c.Int(),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.tblStates", t => t.State_StateId)
                .Index(t => t.State_StateId);
            
            CreateTable(
                "dbo.tblStates",
                c => new
                    {
                        StateId = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                        Country_CountryId = c.Int(),
                    })
                .PrimaryKey(t => t.StateId)
                .ForeignKey("dbo.tblCountries", t => t.Country_CountryId)
                .Index(t => t.Country_CountryId);
            
            CreateTable(
                "dbo.tblCountries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblStates", "Country_CountryId", "dbo.tblCountries");
            DropForeignKey("dbo.tblCitys", "State_StateId", "dbo.tblStates");
            DropIndex("dbo.tblStates", new[] { "Country_CountryId" });
            DropIndex("dbo.tblCitys", new[] { "State_StateId" });
            DropTable("dbo.tblCountries");
            DropTable("dbo.tblStates");
            DropTable("dbo.tblCitys");
        }
    }
}
