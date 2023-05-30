namespace Sp.AvSec.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class CreateInitTables_AvSec : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CardPrintQueueLogs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ReportFileName = c.String(nullable: false, maxLength: 64),
                        ReportUrl = c.String(nullable: false, maxLength: 512),
                        ReportPrintName = c.String(nullable: false, maxLength: 64),
                        ReportDataJson = c.String(nullable: false),
                        ReportStatus = c.String(nullable: false, maxLength: 36),
                        ReportError = c.String(maxLength: 512),
                        ReportCount = c.Int(nullable: false),
                        CreatedBy = c.String(maxLength: 36),
                        CreatedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 36),
                        ModifiedDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CardPrintQueueLog_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.ReportFileName)
                .Index(t => t.ReportPrintName)
                .Index(t => t.ReportStatus)
                .Index(t => t.IsDeleted);
            
            CreateTable(
                "dbo.CardPrintQueues",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ReportFileName = c.String(nullable: false, maxLength: 64),
                        ReportUrl = c.String(nullable: false, maxLength: 512),
                        ReportPrintName = c.String(nullable: false, maxLength: 64),
                        ReportDataJson = c.String(nullable: false),
                        CreatedBy = c.String(maxLength: 36),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CardPrintQueue_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.ReportFileName)
                .Index(t => t.ReportPrintName)
                .Index(t => t.IsDeleted);
            
            CreateTable(
                "dbo.CardTemplateLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CardTemplateId = c.Int(),
                        Name = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 512),
                        FileName = c.String(maxLength: 256),
                        FilePath = c.String(),
                        ActionType = c.String(maxLength: 32),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CardTemplateLog_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CardTemplates", t => t.CardTemplateId)
                .Index(t => t.CardTemplateId)
                .Index(t => t.Name)
                .Index(t => t.FileName)
                .Index(t => t.ActionType)
                .Index(t => t.IsDeleted);
            
            CreateTable(
                "dbo.CardTemplates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 512),
                        FileName = c.String(maxLength: 256),
                        FilePath = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CardTemplate_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name)
                .Index(t => t.FileName)
                .Index(t => t.IsDeleted);
            
            CreateTable(
                "dbo.PrintBatchDatas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PrintBatchId = c.Long(),
                        PrintData = c.String(),
                        PrintNum = c.Short(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_PrintBatchData_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PrintBatches", t => t.PrintBatchId)
                .Index(t => t.PrintBatchId)
                .Index(t => t.PrintNum)
                .Index(t => t.IsDeleted);
            
            CreateTable(
                "dbo.PrintBatches",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 512),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_PrintBatch_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name)
                .Index(t => t.IsDeleted);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrintBatchDatas", "PrintBatchId", "dbo.PrintBatches");
            DropForeignKey("dbo.CardTemplateLogs", "CardTemplateId", "dbo.CardTemplates");
            DropIndex("dbo.PrintBatches", new[] { "IsDeleted" });
            DropIndex("dbo.PrintBatches", new[] { "Name" });
            DropIndex("dbo.PrintBatchDatas", new[] { "IsDeleted" });
            DropIndex("dbo.PrintBatchDatas", new[] { "PrintNum" });
            DropIndex("dbo.PrintBatchDatas", new[] { "PrintBatchId" });
            DropIndex("dbo.CardTemplates", new[] { "IsDeleted" });
            DropIndex("dbo.CardTemplates", new[] { "FileName" });
            DropIndex("dbo.CardTemplates", new[] { "Name" });
            DropIndex("dbo.CardTemplateLogs", new[] { "IsDeleted" });
            DropIndex("dbo.CardTemplateLogs", new[] { "ActionType" });
            DropIndex("dbo.CardTemplateLogs", new[] { "FileName" });
            DropIndex("dbo.CardTemplateLogs", new[] { "Name" });
            DropIndex("dbo.CardTemplateLogs", new[] { "CardTemplateId" });
            DropIndex("dbo.CardPrintQueues", new[] { "IsDeleted" });
            DropIndex("dbo.CardPrintQueues", new[] { "ReportPrintName" });
            DropIndex("dbo.CardPrintQueues", new[] { "ReportFileName" });
            DropIndex("dbo.CardPrintQueueLogs", new[] { "IsDeleted" });
            DropIndex("dbo.CardPrintQueueLogs", new[] { "ReportStatus" });
            DropIndex("dbo.CardPrintQueueLogs", new[] { "ReportPrintName" });
            DropIndex("dbo.CardPrintQueueLogs", new[] { "ReportFileName" });
            DropTable("dbo.PrintBatches",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_PrintBatch_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.PrintBatchDatas",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_PrintBatchData_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.CardTemplates",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CardTemplate_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.CardTemplateLogs",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CardTemplateLog_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.CardPrintQueues",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CardPrintQueue_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.CardPrintQueueLogs",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CardPrintQueueLog_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
