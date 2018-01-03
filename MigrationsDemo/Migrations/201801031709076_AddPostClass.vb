Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddPostClass
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Posts",
                Function(c) New With
                    {
                        .PostId = c.Int(nullable:=False, identity:=True),
                        .Title = c.String(maxLength:=200),
                        .Content = c.String(),
                        .BlogId = c.Int(nullable:=False)
                    }) _
                .PrimaryKey(Function(t) t.PostId) _
                .ForeignKey("dbo.Blogs", Function(t) t.BlogId, cascadeDelete:=True) _
                .Index(Function(t) t.BlogId) _
                .Index(Function(p) p.Title, unique:=True)
            
            AddColumn("dbo.Blogs", "Rating", Function(c) c.Int(nullable:=False, defaultValue:=3))
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Posts", "BlogId", "dbo.Blogs")
            DropIndex("dbo.Posts", New String() {"Title"})
            DropIndex("dbo.Posts", New String() { "BlogId" })
            DropColumn("dbo.Blogs", "Rating")
            DropTable("dbo.Posts")
        End Sub
    End Class
End Namespace
