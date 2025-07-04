' Title: Information System '
' Author: Lucas Jurgec '
' Date Created: 02/05/2024 Last Modified: 04/08/2024 '
' Description: acts as a home screen for employees that links the forms together '

Public Class frmEmployeeWelcome
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End ' ends the program '
    End Sub

    Private Sub btnForm_Click(sender As Object, e As EventArgs) Handles btnForm.Click
        Me.Hide() ' removes this form from the screen '
        frmInfo.Show() ' displays this form to the user '
    End Sub
End Class