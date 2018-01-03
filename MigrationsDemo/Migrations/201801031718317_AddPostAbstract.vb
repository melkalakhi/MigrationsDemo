Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddPostAbstract
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Posts", "Abstract", Function(c) c.String())
            Sql("UPDATE dbo.Posts SET Abstract = LEFT(Content, 100) WHERE Abstract IS NULL")
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Posts", "Abstract")
        End Sub
    End Class
End Namespace
