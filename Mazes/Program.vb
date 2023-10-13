Imports System
Imports System.IO.IsolatedStorage

Module Program
    Dim mazeGrid(10, 10) As String
    Sub Main()
        Dim theEnd As Boolean = False
        Console.WriteLine("Mazes...")
        Call mazeBuilder()
        Call displayMaze()
        While theEnd = True
    End Sub
    Sub mazeBuilder() 'creates the maze as 10x10 2d array
        For i = 1 To 10
            For j = 1 To 10
                mazeGrid(i, j) = "X "
            Next
        Next

        mazeGrid(6, 1) = "T "

        For i = 2 To 6
            mazeGrid(i, 2) = "  "
        Next

        mazeGrid(9, 2) = "  "

        For i = 6 To 9
            mazeGrid(i, 3) = "  "
        Next

        mazeGrid(3, 4) = "  "

        For i = 5 To 6
            mazeGrid(i, 4) = "  "
        Next

        mazeGrid(8, 4) = "  "

        For i = 3 To 5
            mazeGrid(i, 5) = "  "
        Next

        mazeGrid(8, 5) = "  "

        For i = 5 To 8
            mazeGrid(i, 6) = "  "
        Next

        For i = 2 To 4
            mazeGrid(i, 7) = "  "
        Next

        mazeGrid(5, 7) = "  "

        For i = 4 To 8
            mazeGrid(i, 8) = "  "
        Next

        mazeGrid(5, 9) = "  "

        mazeGrid(8, 9) = "  "

        mazeGrid(5, 10) = "  "
    End Sub
    Sub displayMaze()
        For i As Integer = 1 To 10
            For j As Integer = 1 To 10
                Console.Write(mazeGrid(j, i))
            Next
            Console.Write(vbCrLf)
        Next
    End Sub
End Module
