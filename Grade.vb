' Grade.vb

Public Class Grade
    Private _student As Student
    Private _course As Course
    Private _score As Double

    Public Sub New(student As Student, course As Course, score As Double)
        _student = student
        _course = course
        _score = score
    End Sub

    Public Sub DisplayInfo()
        Console.WriteLine("Grade Information:")
        _student.DisplayInfo()
        _course.DisplayInfo()
        Console.WriteLine($"Score: {_score}")
    End Sub
End Class
