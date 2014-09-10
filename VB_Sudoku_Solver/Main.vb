Option Strict On

Public Class Main
    Dim solver As Solver
    Public listTextBoxes As List(Of TextBox)

    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        solver = New Solver
        solver.start()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            listTextBoxes = New List(Of TextBox)
            Dim tabindex As Short = 0
            For i = 0 To 8
                For j = 0 To 8
                    Dim TextBoxTemp As New TextBox()
                    With TextBoxTemp
                        .Name = "TextBox" & CStr(tabindex)
                        .Text = ""
                        .MaxLength = 1
                        .Location = New System.Drawing.Point(28 * j + 12, 28 * i + 12)
                        .TabIndex = tabindex
                        .Size = New System.Drawing.Size(22, 22)
                        tabindex += 1S
                    End With
                    Controls.Add(TextBoxTemp)
                    listTextBoxes.Add(CType(TextBoxTemp, TextBox))
                Next
            Next
        Catch ex As Exception
        End Try
    End Sub
End Class
