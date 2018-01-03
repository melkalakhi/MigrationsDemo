Imports System.Data.Entity
Imports MigrationsDemo.Migrations

Module Module1

    Sub Main()

        Database.SetInitializer(New MigrateDatabaseToLatestVersion(Of BlogContext, Configuration)())

        Using db = New BlogContext()
            db.Blogs.Add(New Blog With {.Name = "Another Blog"})
            db.SaveChanges()
            For Each blog In db.Blogs
                Console.WriteLine(blog.Name)
            Next
        End Using

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()

    End Sub

End Module
