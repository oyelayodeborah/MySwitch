namespace MySwitch.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Channels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FlatAmount = c.String(),
                        PercentOfTransaction = c.String(),
                        Maximum = c.String(),
                        Minimum = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CardPAN = c.String(),
                        Description = c.String(),
                        SinkNodeId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SinkNodes", t => t.SinkNodeId_Id)
                .Index(t => t.SinkNodeId_Id);
            
            CreateTable(
                "dbo.SinkNodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        HostName = c.String(),
                        IPAddress = c.String(),
                        Port = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schemes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransactionTypeChannelFee = c.String(),
                        Description = c.String(),
                        RouteId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Routes", t => t.RouteId_Id)
                .Index(t => t.RouteId_Id);
            
            CreateTable(
                "dbo.SourceNodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        HostName = c.String(),
                        IPAddress = c.String(),
                        Port = c.String(),
                        Status = c.String(),
                        SchemeId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schemes", t => t.SchemeId_Id)
                .Index(t => t.SchemeId_Id);
            
            CreateTable(
                "dbo.Transaction",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CardPAN = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TransactionTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SourceNodes", "SchemeId_Id", "dbo.Schemes");
            DropForeignKey("dbo.Schemes", "RouteId_Id", "dbo.Routes");
            DropForeignKey("dbo.Routes", "SinkNodeId_Id", "dbo.SinkNodes");
            DropIndex("dbo.SourceNodes", new[] { "SchemeId_Id" });
            DropIndex("dbo.Schemes", new[] { "RouteId_Id" });
            DropIndex("dbo.Routes", new[] { "SinkNodeId_Id" });
            DropTable("dbo.TransactionTypes");
            DropTable("dbo.Transaction");
            DropTable("dbo.SourceNodes");
            DropTable("dbo.Schemes");
            DropTable("dbo.SinkNodes");
            DropTable("dbo.Routes");
            DropTable("dbo.Fees");
            DropTable("dbo.Channels");
        }
    }
}
