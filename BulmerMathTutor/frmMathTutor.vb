'Title:         Elementary Math Tutor
'Author:        Mark Bulmer
'Date:          May 1, 2022
'Purpose:       The application displays addition or multiplication sets for a chosen integer
'               in order to help educate elementary students.
Public Class frmMathTutor

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' The mnuClear click event clears the Listbox object resets all checks
        lstResults.Items.Clear()
        radEarlyElementary.Checked = False
        radUpperElementary.Checked = False
        mnuAddition.Checked = False
        mnuMultiplication.Checked = False
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' The mnuExit click event closes the window and exits the application
        Close()
    End Sub

    Private Sub mnuAddition_Click(sender As Object, e As EventArgs) Handles mnuAddition.Click
        ' The mnuAddition click event selects the addition function
        mnuAddition.Checked = True
        mnuMultiplication.Checked = False
    End Sub

    Private Sub mnuMultiplication_Click(sender As Object, e As EventArgs) Handles mnuMultiplication.Click
        ' The mnuMultiplication click event selects the multiplication function
        mnuAddition.Checked = False
        mnuMultiplication.Checked = True
    End Sub

    Private Sub btnGenerateList_Click(sender As Object, e As EventArgs) Handles btnGenerateList.Click
        ' The btnGenerateList click processes the user input and displays the appropriate results
        Dim result As Integer

        ' I realize that I am doing this the hard way but I can't figure out how to properly utilize my "result" input to help 
        ' automate the process quicker.
        If radEarlyElementary.Checked Then
            If mnuAddition.Checked Then
                result = Interaction.InputBox("Enter a number between 0 and 6")
                If result > 6 Or result < 0 Then Interaction.MsgBox("Invalid number")
                If result = 1 Then
                    lstResults.Items.Add("1 + 0 = 1")
                    lstResults.Items.Add("1 + 1 = 2")
                    lstResults.Items.Add("1 + 2 = 3")
                    lstResults.Items.Add("1 + 3 = 4")
                    lstResults.Items.Add("1 + 4 = 5")
                    lstResults.Items.Add("1 + 5 = 6")
                    lstResults.Items.Add("1 + 6 = 7")
                End If
                If result = 2 Then
                    lstResults.Items.Add("2 + 0 = 2")
                    lstResults.Items.Add("2 + 1 = 3")
                    lstResults.Items.Add("2 + 2 = 4")
                    lstResults.Items.Add("2 + 3 = 5")
                    lstResults.Items.Add("2 + 4 = 6")
                    lstResults.Items.Add("2 + 5 = 7")
                    lstResults.Items.Add("2 + 6 = 8")
                End If
                If result = 3 Then
                    lstResults.Items.Add("3 + 0 = 3")
                    lstResults.Items.Add("3 + 1 = 4")
                    lstResults.Items.Add("3 + 2 = 5")
                    lstResults.Items.Add("3 + 3 = 6")
                    lstResults.Items.Add("3 + 4 = 7")
                    lstResults.Items.Add("3 + 5 = 8")
                    lstResults.Items.Add("3 + 6 = 9")
                End If
                If result = 4 Then
                    lstResults.Items.Add("4 + 0 = 4")
                    lstResults.Items.Add("4 + 1 = 5")
                    lstResults.Items.Add("4 + 2 = 6")
                    lstResults.Items.Add("4 + 3 = 7")
                    lstResults.Items.Add("4 + 4 = 8")
                    lstResults.Items.Add("4 + 5 = 9")
                    lstResults.Items.Add("4 + 6 = 10")
                End If
                If result = 5 Then
                    lstResults.Items.Add("5 + 0 = 5")
                    lstResults.Items.Add("5 + 1 = 6")
                    lstResults.Items.Add("5 + 2 = 7")
                    lstResults.Items.Add("5 + 3 = 8")
                    lstResults.Items.Add("5 + 4 = 9")
                    lstResults.Items.Add("5 + 5 = 10")
                    lstResults.Items.Add("5 + 6 = 11")
                End If
                If result = 6 Then
                    lstResults.Items.Add("6 + 0 = 6")
                    lstResults.Items.Add("6 + 1 = 7")
                    lstResults.Items.Add("6 + 2 = 8")
                    lstResults.Items.Add("6 + 3 = 9")
                    lstResults.Items.Add("6 + 4 = 10")
                    lstResults.Items.Add("6 + 5 = 11")
                    lstResults.Items.Add("6 + 6 = 12")
                End If
            End If
            If mnuMultiplication.Checked Then
                result = Interaction.InputBox("Enter a number between 0 and 6")
                If result > 6 Or result < 0 Then Interaction.MsgBox("Invalid number")
                If result = 1 Then
                    lstResults.Items.Add("1 * 0 = 0")
                    lstResults.Items.Add("1 * 1 = 1")
                    lstResults.Items.Add("1 * 2 = 2")
                    lstResults.Items.Add("1 * 3 = 3")
                    lstResults.Items.Add("1 * 4 = 4")
                    lstResults.Items.Add("1 * 5 = 5")
                    lstResults.Items.Add("1 * 6 = 6")
                End If
                If result = 2 Then
                    lstResults.Items.Add("2 * 0 = 0")
                    lstResults.Items.Add("2 * 1 = 2")
                    lstResults.Items.Add("2 * 2 = 4")
                    lstResults.Items.Add("2 * 3 = 6")
                    lstResults.Items.Add("2 * 4 = 8")
                    lstResults.Items.Add("2 * 5 = 10")
                    lstResults.Items.Add("2 * 6 = 12")
                End If
                If result = 3 Then
                    lstResults.Items.Add("3 * 0 = 0")
                    lstResults.Items.Add("3 * 1 = 3")
                    lstResults.Items.Add("3 * 2 = 6")
                    lstResults.Items.Add("3 * 3 = 9")
                    lstResults.Items.Add("3 * 4 = 12")
                    lstResults.Items.Add("3 * 5 = 15")
                    lstResults.Items.Add("3 * 6 = 18")
                End If
                If result = 4 Then
                    lstResults.Items.Add("4 * 0 = 0")
                    lstResults.Items.Add("4 * 1 = 4")
                    lstResults.Items.Add("4 * 2 = 8")
                    lstResults.Items.Add("4 * 3 = 12")
                    lstResults.Items.Add("4 * 4 = 16")
                    lstResults.Items.Add("4 * 5 = 20")
                    lstResults.Items.Add("4 * 6 = 24")
                End If
                If result = 5 Then
                    lstResults.Items.Add("5 * 0 = 0")
                    lstResults.Items.Add("5 * 1 = 5")
                    lstResults.Items.Add("5 * 2 = 10")
                    lstResults.Items.Add("5 * 3 = 15")
                    lstResults.Items.Add("5 * 4 = 20")
                    lstResults.Items.Add("5 * 5 = 25")
                    lstResults.Items.Add("5 * 6 = 30")
                End If
                If result = 6 Then
                    lstResults.Items.Add("6 * 0 = 0")
                    lstResults.Items.Add("6 * 1 = 6")
                    lstResults.Items.Add("6 * 2 = 12")
                    lstResults.Items.Add("6 * 3 = 18")
                    lstResults.Items.Add("6 * 4 = 24")
                    lstResults.Items.Add("6 * 5 = 30")
                    lstResults.Items.Add("6 * 6 = 36")
                End If
            End If
        End If
        If radUpperElementary.Checked Then
            If mnuAddition.Checked Then
                result = Interaction.InputBox("Enter a number between 0 and 12")
                If result > 12 Or result < 0 Then Interaction.MsgBox("Invalid number")
                If result = 1 Then
                    lstResults.Items.Add("1 + 0 = 1")
                    lstResults.Items.Add("1 + 1 = 2")
                    lstResults.Items.Add("1 + 2 = 3")
                    lstResults.Items.Add("1 + 3 = 4")
                    lstResults.Items.Add("1 + 4 = 5")
                    lstResults.Items.Add("1 + 5 = 6")
                    lstResults.Items.Add("1 + 6 = 7")
                    lstResults.Items.Add("1 + 7 = 8")
                    lstResults.Items.Add("1 + 8 = 9")
                    lstResults.Items.Add("1 + 9 = 10")
                    lstResults.Items.Add("1 + 10 = 11")
                    lstResults.Items.Add("1 + 11 = 12")
                    lstResults.Items.Add("1 + 12 = 13")
                End If
                If result = 2 Then
                    lstResults.Items.Add("2 + 0 = 2")
                    lstResults.Items.Add("2 + 1 = 3")
                    lstResults.Items.Add("2 + 2 = 4")
                    lstResults.Items.Add("2 + 3 = 5")
                    lstResults.Items.Add("2 + 4 = 6")
                    lstResults.Items.Add("2 + 5 = 7")
                    lstResults.Items.Add("2 + 6 = 8")
                    lstResults.Items.Add("2 + 7 = 9")
                    lstResults.Items.Add("2 + 8 = 10")
                    lstResults.Items.Add("2 + 9 = 11")
                    lstResults.Items.Add("2 + 10 = 12")
                    lstResults.Items.Add("2 + 11 = 13")
                    lstResults.Items.Add("2 + 12 = 14")
                End If
                If result = 3 Then
                    lstResults.Items.Add("3 + 0 = 3")
                    lstResults.Items.Add("3 + 1 = 4")
                    lstResults.Items.Add("3 + 2 = 5")
                    lstResults.Items.Add("3 + 3 = 6")
                    lstResults.Items.Add("3 + 4 = 7")
                    lstResults.Items.Add("3 + 5 = 8")
                    lstResults.Items.Add("3 + 6 = 9")
                    lstResults.Items.Add("3 + 7 = 10")
                    lstResults.Items.Add("3 + 8 = 11")
                    lstResults.Items.Add("3 + 9 = 12")
                    lstResults.Items.Add("3 + 10 = 13")
                    lstResults.Items.Add("3 + 11 = 14")
                    lstResults.Items.Add("3 + 12 = 15")
                End If
                If result = 4 Then
                    lstResults.Items.Add("4 + 0 = 4")
                    lstResults.Items.Add("4 + 1 = 5")
                    lstResults.Items.Add("4 + 2 = 6")
                    lstResults.Items.Add("4 + 3 = 7")
                    lstResults.Items.Add("4 + 4 = 8")
                    lstResults.Items.Add("4 + 5 = 9")
                    lstResults.Items.Add("4 + 6 = 10")
                    lstResults.Items.Add("4 + 7 = 11")
                    lstResults.Items.Add("4 + 8 = 12")
                    lstResults.Items.Add("4 + 9 = 13")
                    lstResults.Items.Add("4 + 10 = 14")
                    lstResults.Items.Add("4 + 11 = 15")
                    lstResults.Items.Add("4 + 12 = 16")
                End If
                If result = 5 Then
                    lstResults.Items.Add("5 + 0 = 5")
                    lstResults.Items.Add("5 + 1 = 6")
                    lstResults.Items.Add("5 + 2 = 7")
                    lstResults.Items.Add("5 + 3 = 8")
                    lstResults.Items.Add("5 + 4 = 9")
                    lstResults.Items.Add("5 + 5 = 10")
                    lstResults.Items.Add("5 + 6 = 11")
                    lstResults.Items.Add("5 + 7 = 12")
                    lstResults.Items.Add("5 + 8 = 13")
                    lstResults.Items.Add("5 + 9 = 14")
                    lstResults.Items.Add("5 + 10 = 15")
                    lstResults.Items.Add("5 + 11 = 16")
                    lstResults.Items.Add("5 + 12 = 17")
                End If
                If result = 6 Then
                    lstResults.Items.Add("6 + 0 = 6")
                    lstResults.Items.Add("6 + 1 = 7")
                    lstResults.Items.Add("6 + 2 = 8")
                    lstResults.Items.Add("6 + 3 = 9")
                    lstResults.Items.Add("6 + 4 = 10")
                    lstResults.Items.Add("6 + 5 = 11")
                    lstResults.Items.Add("6 + 6 = 12")
                    lstResults.Items.Add("6 + 7 = 13")
                    lstResults.Items.Add("6 + 8 = 14")
                    lstResults.Items.Add("6 + 9 = 15")
                    lstResults.Items.Add("6 + 10 = 16")
                    lstResults.Items.Add("6 + 11 = 17")
                    lstResults.Items.Add("6 + 12 = 18")
                End If
                If result = 7 Then
                    lstResults.Items.Add("7 + 0 = 7")
                    lstResults.Items.Add("7 + 1 = 8")
                    lstResults.Items.Add("7 + 2 = 9")
                    lstResults.Items.Add("7 + 3 = 10")
                    lstResults.Items.Add("7 + 4 = 11")
                    lstResults.Items.Add("7 + 5 = 12")
                    lstResults.Items.Add("7 + 6 = 13")
                    lstResults.Items.Add("7 + 7 = 14")
                    lstResults.Items.Add("7 + 8 = 15")
                    lstResults.Items.Add("7 + 9 = 16")
                    lstResults.Items.Add("7 + 10 = 17")
                    lstResults.Items.Add("7 + 11 = 18")
                    lstResults.Items.Add("7 + 12 = 19")
                End If
                If result = 8 Then
                    lstResults.Items.Add("8 + 0 = 8")
                    lstResults.Items.Add("8 + 1 = 9")
                    lstResults.Items.Add("8 + 2 = 10")
                    lstResults.Items.Add("8 + 3 = 11")
                    lstResults.Items.Add("8 + 4 = 12")
                    lstResults.Items.Add("8 + 5 = 13")
                    lstResults.Items.Add("8 + 6 = 14")
                    lstResults.Items.Add("8 + 7 = 15")
                    lstResults.Items.Add("8 + 8 = 16")
                    lstResults.Items.Add("8 + 9 = 17")
                    lstResults.Items.Add("8 + 10 = 18")
                    lstResults.Items.Add("8 + 11 = 19")
                    lstResults.Items.Add("8 + 12 = 20")
                End If
                If result = 9 Then
                    lstResults.Items.Add("9 + 0 = 9")
                    lstResults.Items.Add("9 + 1 = 10")
                    lstResults.Items.Add("9 + 2 = 11")
                    lstResults.Items.Add("9 + 3 = 12")
                    lstResults.Items.Add("9 + 4 = 13")
                    lstResults.Items.Add("9 + 5 = 14")
                    lstResults.Items.Add("9 + 6 = 15")
                    lstResults.Items.Add("9 + 7 = 16")
                    lstResults.Items.Add("9 + 8 = 17")
                    lstResults.Items.Add("9 + 9 = 18")
                    lstResults.Items.Add("9 + 10 = 19")
                    lstResults.Items.Add("9 + 11 = 20")
                    lstResults.Items.Add("9 + 12 = 21")
                End If
                If result = 10 Then
                    lstResults.Items.Add("10 + 0 = 10")
                    lstResults.Items.Add("10 + 1 = 11")
                    lstResults.Items.Add("10 + 2 = 12")
                    lstResults.Items.Add("10 + 3 = 13")
                    lstResults.Items.Add("10 + 4 = 14")
                    lstResults.Items.Add("10 + 5 = 15")
                    lstResults.Items.Add("10 + 6 = 16")
                    lstResults.Items.Add("10 + 7 = 17")
                    lstResults.Items.Add("10 + 8 = 18")
                    lstResults.Items.Add("10 + 9 = 19")
                    lstResults.Items.Add("10 + 10 = 20")
                    lstResults.Items.Add("10 + 11 = 21")
                    lstResults.Items.Add("10 + 12 = 22")
                End If
                If result = 11 Then
                    lstResults.Items.Add("11 + 0 = 11")
                    lstResults.Items.Add("11 + 1 = 12")
                    lstResults.Items.Add("11 + 2 = 13")
                    lstResults.Items.Add("11 + 3 = 14")
                    lstResults.Items.Add("11 + 4 = 15")
                    lstResults.Items.Add("11 + 5 = 16")
                    lstResults.Items.Add("11 + 6 = 17")
                    lstResults.Items.Add("11 + 7 = 18")
                    lstResults.Items.Add("11 + 8 = 19")
                    lstResults.Items.Add("11 + 9 = 20")
                    lstResults.Items.Add("11 + 10 = 21")
                    lstResults.Items.Add("11 + 11 = 22")
                    lstResults.Items.Add("11 + 12 = 23")
                End If
                If result = 12 Then
                    lstResults.Items.Add("12 + 0 = 12")
                    lstResults.Items.Add("12 + 1 = 13")
                    lstResults.Items.Add("12 + 2 = 14")
                    lstResults.Items.Add("12 + 3 = 15")
                    lstResults.Items.Add("12 + 4 = 16")
                    lstResults.Items.Add("12 + 5 = 17")
                    lstResults.Items.Add("12 + 6 = 18")
                    lstResults.Items.Add("12 + 7 = 19")
                    lstResults.Items.Add("12 + 8 = 20")
                    lstResults.Items.Add("12 + 9 = 21")
                    lstResults.Items.Add("12 + 10 = 22")
                    lstResults.Items.Add("12 + 11 = 23")
                    lstResults.Items.Add("12 + 12 = 24")
                End If
            End If
            If mnuMultiplication.Checked Then
                result = Interaction.InputBox("Enter a number between 0 and 6")
                If result > 6 Or result < 0 Then Interaction.MsgBox("Invalid number")
                If result = 1 Then
                    lstResults.Items.Add("1 * 0 = 0")
                    lstResults.Items.Add("1 * 1 = 1")
                    lstResults.Items.Add("1 * 2 = 2")
                    lstResults.Items.Add("1 * 3 = 3")
                    lstResults.Items.Add("1 * 4 = 4")
                    lstResults.Items.Add("1 * 5 = 5")
                    lstResults.Items.Add("1 * 6 = 6")
                    lstResults.Items.Add("1 * 7 = 7")
                    lstResults.Items.Add("1 * 8 = 8")
                    lstResults.Items.Add("1 * 9 = 9")
                    lstResults.Items.Add("1 * 10 = 10")
                    lstResults.Items.Add("1 * 11 = 11")
                    lstResults.Items.Add("1 * 12 = 12")
                End If
                If result = 2 Then
                    lstResults.Items.Add("2 * 0 = 0")
                    lstResults.Items.Add("2 * 1 = 2")
                    lstResults.Items.Add("2 * 2 = 4")
                    lstResults.Items.Add("2 * 3 = 6")
                    lstResults.Items.Add("2 * 4 = 8")
                    lstResults.Items.Add("2 * 5 = 10")
                    lstResults.Items.Add("2 * 6 = 12")
                    lstResults.Items.Add("2 * 7 = 14")
                    lstResults.Items.Add("2 * 8 = 16")
                    lstResults.Items.Add("2 * 9 = 18")
                    lstResults.Items.Add("2 * 10 = 20")
                    lstResults.Items.Add("2 * 11 = 22")
                    lstResults.Items.Add("2 * 12 = 24")
                End If
                If result = 3 Then
                    lstResults.Items.Add("3 * 0 = 0")
                    lstResults.Items.Add("3 * 1 = 3")
                    lstResults.Items.Add("3 * 2 = 6")
                    lstResults.Items.Add("3 * 3 = 9")
                    lstResults.Items.Add("3 * 4 = 12")
                    lstResults.Items.Add("3 * 5 = 15")
                    lstResults.Items.Add("3 * 6 = 18")
                    lstResults.Items.Add("3 * 7 = 21")
                    lstResults.Items.Add("3 * 8 = 24")
                    lstResults.Items.Add("3 * 9 = 27")
                    lstResults.Items.Add("3 * 10 = 30")
                    lstResults.Items.Add("3 * 11 = 33")
                    lstResults.Items.Add("3 * 12 = 36")
                End If
                If result = 4 Then
                    lstResults.Items.Add("4 * 0 = 0")
                    lstResults.Items.Add("4 * 1 = 4")
                    lstResults.Items.Add("4 * 2 = 8")
                    lstResults.Items.Add("4 * 3 = 12")
                    lstResults.Items.Add("4 * 4 = 16")
                    lstResults.Items.Add("4 * 5 = 20")
                    lstResults.Items.Add("4 * 6 = 24")
                    lstResults.Items.Add("4 * 7 = 28")
                    lstResults.Items.Add("4 * 8 = 32")
                    lstResults.Items.Add("4 * 9 = 36")
                    lstResults.Items.Add("4 * 10 = 40")
                    lstResults.Items.Add("4 * 11 = 44")
                    lstResults.Items.Add("4 * 12 = 48")
                End If
                If result = 5 Then
                    lstResults.Items.Add("5 * 0 = 0")
                    lstResults.Items.Add("5 * 1 = 5")
                    lstResults.Items.Add("5 * 2 = 10")
                    lstResults.Items.Add("5 * 3 = 15")
                    lstResults.Items.Add("5 * 4 = 20")
                    lstResults.Items.Add("5 * 5 = 25")
                    lstResults.Items.Add("5 * 6 = 30")
                    lstResults.Items.Add("5 * 7 = 35")
                    lstResults.Items.Add("5 * 8 = 40")
                    lstResults.Items.Add("5 * 9 = 45")
                    lstResults.Items.Add("5 * 10 = 50")
                    lstResults.Items.Add("5 * 11 = 55")
                    lstResults.Items.Add("5 * 12 = 60")
                End If
                If result = 6 Then
                    lstResults.Items.Add("6 * 0 = 0")
                    lstResults.Items.Add("6 * 1 = 6")
                    lstResults.Items.Add("6 * 2 = 12")
                    lstResults.Items.Add("6 * 3 = 18")
                    lstResults.Items.Add("6 * 4 = 24")
                    lstResults.Items.Add("6 * 5 = 30")
                    lstResults.Items.Add("6 * 6 = 36")
                    lstResults.Items.Add("6 * 7 = 42")
                    lstResults.Items.Add("6 * 8 = 48")
                    lstResults.Items.Add("6 * 9 = 54")
                    lstResults.Items.Add("6 * 10 = 60")
                    lstResults.Items.Add("6 * 11 = 66")
                    lstResults.Items.Add("6 * 12 = 72")
                End If
                If result = 7 Then
                    lstResults.Items.Add("7 * 0 = 0")
                    lstResults.Items.Add("7 * 1 = 7")
                    lstResults.Items.Add("7 * 2 = 14")
                    lstResults.Items.Add("7 * 3 = 21")
                    lstResults.Items.Add("7 * 4 = 28")
                    lstResults.Items.Add("7 * 5 = 35")
                    lstResults.Items.Add("7 * 6 = 42")
                    lstResults.Items.Add("7 * 7 = 49")
                    lstResults.Items.Add("7 * 8 = 56")
                    lstResults.Items.Add("7 * 9 = 63")
                    lstResults.Items.Add("7 * 10 = 70")
                    lstResults.Items.Add("7 * 11 = 77")
                    lstResults.Items.Add("7 * 12 = 84")
                End If
                If result = 8 Then
                    lstResults.Items.Add("8 * 0 = 0")
                    lstResults.Items.Add("8 * 1 = 8")
                    lstResults.Items.Add("8 * 2 = 16")
                    lstResults.Items.Add("8 * 3 = 24")
                    lstResults.Items.Add("8 * 4 = 32")
                    lstResults.Items.Add("8 * 5 = 40")
                    lstResults.Items.Add("8 * 6 = 48")
                    lstResults.Items.Add("8 * 7 = 56")
                    lstResults.Items.Add("8 * 8 = 64")
                    lstResults.Items.Add("8 * 9 = 72")
                    lstResults.Items.Add("8 * 10 = 80")
                    lstResults.Items.Add("8 * 11 = 88")
                    lstResults.Items.Add("8 * 12 = 96")
                End If
                If result = 9 Then
                    lstResults.Items.Add("9 * 0 = 0")
                    lstResults.Items.Add("9 * 1 = 9")
                    lstResults.Items.Add("9 * 2 = 18")
                    lstResults.Items.Add("9 * 3 = 27")
                    lstResults.Items.Add("9 * 4 = 36")
                    lstResults.Items.Add("9 * 5 = 45")
                    lstResults.Items.Add("9 * 6 = 54")
                    lstResults.Items.Add("9 * 7 = 63")
                    lstResults.Items.Add("9 * 8 = 72")
                    lstResults.Items.Add("9 * 9 = 81")
                    lstResults.Items.Add("9 * 10 = 90")
                    lstResults.Items.Add("9 * 11 = 99")
                    lstResults.Items.Add("9 * 12 = 108")
                End If
                If result = 10 Then
                    lstResults.Items.Add("10 * 0 = 0")
                    lstResults.Items.Add("10 * 1 = 10")
                    lstResults.Items.Add("10 * 2 = 20")
                    lstResults.Items.Add("10 * 3 = 30")
                    lstResults.Items.Add("10 * 4 = 40")
                    lstResults.Items.Add("10 * 5 = 50")
                    lstResults.Items.Add("10 * 6 = 60")
                    lstResults.Items.Add("10 * 7 = 70")
                    lstResults.Items.Add("10 * 8 = 80")
                    lstResults.Items.Add("10 * 9 = 90")
                    lstResults.Items.Add("10 * 10 = 100")
                    lstResults.Items.Add("10 * 11 = 110")
                    lstResults.Items.Add("10 * 12 = 120")
                End If
                If result = 11 Then
                    lstResults.Items.Add("11 * 0 = 0")
                    lstResults.Items.Add("11 * 1 = 11")
                    lstResults.Items.Add("11 * 2 = 22")
                    lstResults.Items.Add("11 * 3 = 33")
                    lstResults.Items.Add("11 * 4 = 44")
                    lstResults.Items.Add("11 * 5 = 55")
                    lstResults.Items.Add("11 * 6 = 66")
                    lstResults.Items.Add("11 * 7 = 77")
                    lstResults.Items.Add("11 * 8 = 88")
                    lstResults.Items.Add("11 * 9 = 99")
                    lstResults.Items.Add("11 * 10 = 110")
                    lstResults.Items.Add("11 * 11 = 121")
                    lstResults.Items.Add("11 * 12 = 132")
                End If
                If result = 12 Then
                    lstResults.Items.Add("12 * 0 = 0")
                    lstResults.Items.Add("12 * 1 = 12")
                    lstResults.Items.Add("12 * 2 = 24")
                    lstResults.Items.Add("12 * 3 = 36")
                    lstResults.Items.Add("12 * 4 = 48")
                    lstResults.Items.Add("12 * 5 = 60")
                    lstResults.Items.Add("12 * 6 = 72")
                    lstResults.Items.Add("12 * 7 = 84")
                    lstResults.Items.Add("12 * 8 = 96")
                    lstResults.Items.Add("12 * 9 = 108")
                    lstResults.Items.Add("12 * 10 = 120")
                    lstResults.Items.Add("12 * 11 = 132")
                    lstResults.Items.Add("12 * 12 = 144")
                End If
            End If
        End If
    End Sub
End Class
