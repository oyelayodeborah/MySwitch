namespace MySwitch.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SinkNodes", "Status", c => c.Int(nullable: false));
            AlterColumn("dbo.SourceNodes", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SourceNodes", "Status", c => c.String());
            AlterColumn("dbo.SinkNodes", "Status", c => c.String());
        }
    }
}
