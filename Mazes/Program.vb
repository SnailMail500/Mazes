Imports System
Imports System.IO.IsolatedStorage

Module Program
    Dim mazeGrid(10, 10) As String
    Dim xCoord As Integer = 6 'subject to change when generating mazes
    Dim yCoord As Integer = 1 'also subject to change when generating mazes
    Dim xCoordCheck As Integer = xCoord
    Dim yCoordCheck As Integer = yCoord
    Dim userInput As Char
    Dim pureInput As Char
    Dim theEnd As Boolean = False
    'I do not like the amount of global variables I need here.
    Sub Main() 'does literally everything else
        Dim currentLocation(1, 1)
        Console.WriteLine("Mazes...")
        Call mazeBuilder()
        Call displayMaze()
        'While True
        '    Beep() (I thought this was funny for a total of about 5 seconds)
        'End While
        While theEnd = False
            displayMaze()
            userInput = Console.ReadKey(True).KeyChar 'what in the name of all that is unholy- do i need the 'userInput =' ?
            If mazeGrid(5, 10) = "T " Then
                Console.WriteLine("Well done!")
                theEnd = True
            Else
                Select Case userInput
                    Case "w"
                        Call wPressed()
                    Case "s"
                        Call sPressed()
                    Case "a"
                        Call aPressed()
                    Case "d"
                        Call dPressed()
                End Select
            End If
        End While
    End Sub
    Sub mazeBuilder() 'creates the maze as 10x10 2d array
        For i = 1 To 10
            For j = 1 To 10
                mazeGrid(i, j) = "+ "
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
    Sub wPressed()
        yCoordCheck += 1
        If mazeGrid(xCoord, yCoordCheck) = "+ " Then
            Console.Clear()
            Console.WriteLine("Oops, you hit a wall!")
            Call displayMaze()
        End If
        Select Case yCoordCheck
            Case < 1
                Console.Clear()
                Console.WriteLine("Out of bounds- try again")
                Call displayMaze()
            Case > 1
                Console.Clear()
                Console.WriteLine("Outstanding Move.")
                mazeGrid(xCoord, yCoord) = "  "
                yCoord += 1
                mazeGrid(xCoord, yCoord) = "T "
                Call displayMaze()
        End Select
    End Sub
    Sub sPressed()
        yCoordCheck -= 1
        If mazeGrid(xCoord, yCoordCheck) = "+ " Then
            Console.Clear()
            Console.WriteLine("Oops, you hit a wall!")
            Call displayMaze()
        End If
        Select Case yCoordCheck
            Case < 10
                Console.Clear()
                Console.WriteLine("Out of bounds- try again")
                Call displayMaze()
            Case > 1
                Console.Clear()
                Console.WriteLine("Outstanding Move.")
                mazeGrid(xCoord, yCoord) = "  "
                yCoord -= 1
                mazeGrid(xCoord, yCoord) = "T "
                Call displayMaze()
            Case = 10
                Console.Clear()
                Console.WriteLine("Congratulations. You completed the maze.")
                TheEnd = True
        End Select
    End Sub
    Sub aPressed()
        xCoordCheck -= 1
        If mazeGrid(xCoordCheck, yCoord) = "+ " Then
            Console.Clear()
            Console.WriteLine("Oops, you hit a wall!")
            Call displayMaze()
        End If
        Select Case xCoordCheck
            Case > 10
                Console.Clear()
                Console.WriteLine("Out of bounds- try again")
                Call displayMaze()
            Case > 1
                Console.Clear()
                Console.WriteLine("Outstanding Move.")
                mazeGrid(xCoord, yCoord) = "  "
                xCoord -= 1
                mazeGrid(xCoord, yCoord) = "T "
                Call displayMaze()
        End Select
    End Sub
    Sub dPressed()
        xCoordCheck += 1
        If mazeGrid(xCoordCheck, yCoord) = "+ " Then
            Console.Clear()
            Console.WriteLine("Oops, you hit a wall!")
            Call displayMaze()
        End If
        Select Case xCoordCheck
            Case < 10
                Console.Clear()
                Console.WriteLine("Out of bounds- try again")
                Call displayMaze()
            Case > 1
                Console.Clear()
                Console.WriteLine("Outstanding Move.")
                mazeGrid(xCoord, yCoord) = "  "
                xCoord -= 1
                mazeGrid(xCoord, yCoord) = "T "
                Call displayMaze()
        End Select
    End Sub
End Module
'I even commented this. Well done me.