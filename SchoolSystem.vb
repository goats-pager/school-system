' SchoolSystem.vb

Module SchoolSystem
    Sub Main()
        ' Create students
        Dim student1 As New Student(1, "Alice")
        Dim student2 As New Student(2, "Bob")

        ' Create courses
        Dim course1 As New Course(101, "Mathematics")
        Dim course2 As New Course(102, "English")

        ' Record grades
        Dim grade1 As New Grade(student1, course1, 90.5)
        Dim grade2 As New Grade(student2, course2, 85.0)

        ' Display grade information
        Console.WriteLine("Grade Information:")
        grade1.DisplayInfo()
        Console.WriteLine()
        grade2.DisplayInfo()
    End Sub
End Module
