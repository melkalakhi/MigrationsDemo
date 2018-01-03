Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Blogs",
                Function(c) New With
                    {
                        .BlogId = c.Int(nullable := False, identity := True),
                        .Name = c.String()
                    }) _
                .PrimaryKey(Function(t) t.BlogId)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Blogs")
        End Sub
    End Class
End Namespace
