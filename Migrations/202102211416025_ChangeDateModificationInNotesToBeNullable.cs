namespace Assignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateModificationInNotesToBeNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NoteModels", "DateMod", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NoteModels", "DateMod", c => c.DateTime(nullable: false));
        }
    }
}
