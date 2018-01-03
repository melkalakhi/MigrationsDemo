Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddBlogUrl
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Blogs", "Url", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Blogs", "Url")
        End Sub
    End Class
End Namespace
