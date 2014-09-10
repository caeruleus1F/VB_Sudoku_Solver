Imports Microsoft.VisualBasic
Imports System.IO

Public Class Solver
    Dim sheet(8, 8) As SudokuSquare

    Public Sub New()
        For i = 0 To 8
            For j = 0 To 8
                sheet(i, j) = New SudokuSquare()
            Next
        Next
    End Sub

    Public Sub start()
        ' start the solving process
        ' continue until no changes have been made
        ' after a pass
        Dim changesMade As Boolean = True

        sheetInput()
        displaySheet()

        While changesMade
            changesMade = makePass()

            If changesMade Then
                displaySheet()
            End If
        End While
        displayPossibilities()
    End Sub

    Public Sub sheetInput()
        ' gather input numbers from the form

        For i = 0 To 8
            For j = 0 To 8
                If Main.listTextBoxes.Item(i * 9 + j).Text = "" Then
                    Main.listTextBoxes.Item(i * 9 + j).Text = "0"
                End If

                updatePossibles(CShort(i), CShort(j), CShort(Main.listTextBoxes.Item(i * 9 + j).Text))
            Next
        Next
    End Sub

    Public Sub displayPossibilities()
        ' output the list of possible numbers in a given cell
        ' by row and column
        Dim writer As New StreamWriter("output.txt")
        Dim strTemp As String = Nothing

        For i = 0 To 8
            For j = 0 To 8
                strTemp = "Row " & i & ", "
                strTemp += "Column " & j & ": "
                For k = 0 To 8
                    If CBool(sheet(i, j).possibleNumbers And CLng(Math.Pow(2, k))) Then
                        strTemp += (k + 1) & ", "
                    End If
                Next
                writer.WriteLine(strTemp)
            Next
        Next
        writer.Close()
    End Sub

    Public Sub displaySheet()
        ' output the actual numbers to the list of textboxes
        Dim counter As Short = 0

        For i = 0 To 8
            For j = 0 To 8
                Main.listTextBoxes.Item(counter).Text = CStr(sheet(i, j).actualNumber)
                counter += 1S
            Next
        Next
    End Sub

    Public Sub updatePossibles(row As Short, column As Short, iActualNumber As Short)
        ' go through each row, column, and subdivision to determine which cells
        ' cannot contain the argument number

        If iActualNumber <> 0 Then
            Dim bitwiseNumber As Short = CShort(Math.Pow(2, iActualNumber - 1))
            Dim subRow As Short = CShort(row \ 3)
            Dim subColumn As Short = CShort(column \ 3)

            sheet(row, column).actualNumber = iActualNumber
            sheet(row, column).possibleNumbers = bitwiseNumber

            For i = 0 To 8
                If CBool(CShort(i <> column) And (sheet(row, i).possibleNumbers And bitwiseNumber)) Then
                    sheet(row, i).possibleNumbers -= bitwiseNumber
                End If
            Next

            For j = 0 To 8
                If CBool(CShort(j <> row) And (sheet(j, column).possibleNumbers And bitwiseNumber)) Then
                    sheet(j, column).possibleNumbers -= bitwiseNumber
                End If
            Next

            For k = 0 To 2
                For l = 0 To 2
                    If CBool(CShort(row <> subRow * 3 + k And column <> subColumn * 3 + l) And sheet(subRow * 3 + k, subColumn * 3 + l).possibleNumbers And bitwiseNumber) Then
                        sheet(subRow * 3 + k, subColumn * 3 + l).possibleNumbers -= bitwiseNumber
                    End If
                Next
            Next
        End If
    End Sub

    Public Function makePass() As Boolean
        ' scans over each cell in the sheet looking for
        ' cells that only have one possible number that
        ' could be the acutal number
        Dim changesMade As Boolean = False
        Dim bitwiseNumber As Short = 0

        For i = 0 To 8
            For j = 0 To 8
                If sheet(i, j).actualNumber = 0 Then
                    Dim possibles As Short = 0
                    Dim actualNumber As Short = 0

                    For k = 0 To 8
                        bitwiseNumber = CShort(Math.Pow(2, k))
                        If CBool(sheet(i, j).possibleNumbers And bitwiseNumber) Then
                            possibles += 1S
                            actualNumber = CShort(k + 1)
                        End If
                    Next

                    If possibles = 1 Then
                        changesMade = True
                        updatePossibles(CShort(i), CShort(j), actualNumber)
                    End If
                End If
            Next
        Next

        Return changesMade
    End Function
End Class
