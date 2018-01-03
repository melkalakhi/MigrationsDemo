Imports System.Data.Entity
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Data.Entity.Infrastructure

Public Class BlogContext
    Inherits DbContext

    Public Property Blogs As DbSet(Of Blog)

End Class

Public Class Blog

    Public Property BlogId As Integer

    Public Property Name As String

    Public Property Url As String

    Public Property Rating As Integer

    Public Overridable Property Posts As List(Of Post)

End Class

Public Class Post

    Public Property PostId As Integer

    <MaxLength(200)>
    Public Property Title As String

    Public Property Content As String

    Public Property BlogId As Integer

    Public Property Blog As Blog

    Public Property Abstract As String

End Class