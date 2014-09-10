Option Strict On

Public Class Main
    Dim solver As Solver
    Public listTextBoxes As List(Of TextBox)

    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        RichTextBox1.Text += "Clicked Solve" & vbNewLine
        solver = New Solver
        solver.start()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text += "Form Loaded" & vbNewLine
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
            RichTextBox1.Text = ex.Message
        End Try

        'preFill()
    End Sub

    Public Sub preFill()
        RichTextBox1.Text += "Boxes filled" & vbNewLine
        listTextBoxes.Item(0).Text = "2"
        listTextBoxes.Item(1).Text = "0"
        listTextBoxes.Item(2).Text = "4"
        listTextBoxes.Item(3).Text = "1"
        listTextBoxes.Item(4).Text = "0"
        listTextBoxes.Item(5).Text = "0"
        listTextBoxes.Item(6).Text = "0"
        listTextBoxes.Item(7).Text = "0"
        listTextBoxes.Item(8).Text = "0"

        listTextBoxes.Item(9).Text = "6"
        listTextBoxes.Item(10).Text = "9"
        listTextBoxes.Item(11).Text = "0"
        listTextBoxes.Item(12).Text = "3"
        listTextBoxes.Item(13).Text = "0"
        listTextBoxes.Item(14).Text = "5"
        listTextBoxes.Item(15).Text = "0"
        listTextBoxes.Item(16).Text = "0"
        listTextBoxes.Item(17).Text = "0"

        listTextBoxes.Item(18).Text = "0"
        listTextBoxes.Item(19).Text = "1"
        listTextBoxes.Item(20).Text = "0"
        listTextBoxes.Item(21).Text = "0"
        listTextBoxes.Item(22).Text = "4"
        listTextBoxes.Item(23).Text = "7"
        listTextBoxes.Item(24).Text = "6"
        listTextBoxes.Item(25).Text = "0"
        listTextBoxes.Item(26).Text = "0"

        listTextBoxes.Item(27).Text = "1"
        listTextBoxes.Item(28).Text = "0"
        listTextBoxes.Item(29).Text = "0"
        listTextBoxes.Item(30).Text = "0"
        listTextBoxes.Item(31).Text = "9"
        listTextBoxes.Item(32).Text = "0"
        listTextBoxes.Item(33).Text = "0"
        listTextBoxes.Item(34).Text = "6"
        listTextBoxes.Item(35).Text = "0"

        listTextBoxes.Item(36).Text = "0"
        listTextBoxes.Item(37).Text = "6"
        listTextBoxes.Item(38).Text = "0"
        listTextBoxes.Item(39).Text = "4"
        listTextBoxes.Item(40).Text = "1"
        listTextBoxes.Item(41).Text = "8"
        listTextBoxes.Item(42).Text = "0"
        listTextBoxes.Item(43).Text = "5"
        listTextBoxes.Item(44).Text = "0"

        listTextBoxes.Item(45).Text = "0"
        listTextBoxes.Item(46).Text = "4"
        listTextBoxes.Item(47).Text = "0"
        listTextBoxes.Item(48).Text = "0"
        listTextBoxes.Item(49).Text = "2"
        listTextBoxes.Item(50).Text = "0"
        listTextBoxes.Item(51).Text = "0"
        listTextBoxes.Item(52).Text = "0"
        listTextBoxes.Item(53).Text = "1"

        listTextBoxes.Item(54).Text = "0"
        listTextBoxes.Item(55).Text = "0"
        listTextBoxes.Item(56).Text = "5"
        listTextBoxes.Item(57).Text = "9"
        listTextBoxes.Item(58).Text = "7"
        listTextBoxes.Item(59).Text = "0"
        listTextBoxes.Item(60).Text = "0"
        listTextBoxes.Item(61).Text = "1"
        listTextBoxes.Item(62).Text = "0"

        listTextBoxes.Item(63).Text = "0"
        listTextBoxes.Item(64).Text = "0"
        listTextBoxes.Item(65).Text = "0"
        listTextBoxes.Item(66).Text = "8"
        listTextBoxes.Item(67).Text = "0"
        listTextBoxes.Item(68).Text = "1"
        listTextBoxes.Item(69).Text = "0"
        listTextBoxes.Item(70).Text = "4"
        listTextBoxes.Item(71).Text = "9"

        listTextBoxes.Item(72).Text = "0"
        listTextBoxes.Item(73).Text = "0"
        listTextBoxes.Item(74).Text = "0"
        listTextBoxes.Item(75).Text = "0"
        listTextBoxes.Item(76).Text = "0"
        listTextBoxes.Item(77).Text = "4"
        listTextBoxes.Item(78).Text = "3"
        listTextBoxes.Item(79).Text = "0"
        listTextBoxes.Item(80).Text = "2"
    End Sub
End Class
