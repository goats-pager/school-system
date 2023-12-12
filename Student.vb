' Student.vb

Public Class Student
    Private _studentId As Integer
    Private _name As String

    Public Sub New(studentId As Integer, name As String)
        _studentId = studentId
        _name = name
    End Sub

    Public Sub DisplayInfo()
        Console.WriteLine($"Student ID: {_studentId}")
        Console.WriteLine($"Name: {_name}")
    End Sub
End Class
