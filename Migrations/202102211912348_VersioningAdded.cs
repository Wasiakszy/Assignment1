namespace Assignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VersioningAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NotePreviousVersions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NoteModelId = c.Int(nullable: false),
                        ModificationDate = c.DateTime(nullable: false),
                        Version = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NoteModels", t => t.NoteModelId, cascadeDelete: true)
                .Index(t => t.NoteModelId);
            
            AddColumn("dbo.NoteModels", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotePreviousVersions", "NoteModelId", "dbo.NoteModels");
            DropIndex("dbo.NotePreviousVersions", new[] { "NoteModelId" });
            DropColumn("dbo.NoteModels", "IsDeleted");
            DropTable("dbo.NotePreviousVersions");
        }
    }
}
