' Course.vb

Public Class Course
    Private _courseId As Integer
    Private _name As String

    Public Sub New(courseId As Integer, name As String)
        _courseId = courseId
        _name = name
    End Sub

    Public Sub DisplayInfo()
        Console.WriteLine($"Course ID: {_courseId}")
        Console.WriteLine($"Name: {_name}")
    End Sub
End Class
