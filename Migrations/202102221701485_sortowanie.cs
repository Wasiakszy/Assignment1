namespace Assignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sortowanie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HomeDtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        DateCre = c.DateTime(nullable: false),
                        DateMod = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HomeDtoes");
        }
    }
}
