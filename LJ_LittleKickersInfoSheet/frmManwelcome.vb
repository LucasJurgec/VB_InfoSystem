' Title: Information System '
' Author: Lucas Jurgec '
' Date Created: 02/05/2024 Last Modified: 04/08/2024 '
' Description: acts as a home screen that links the different forms together '
Public Class frmManwelcome
    Private Sub tsmExit_Click(sender As Object, e As EventArgs) Handles tsmExit.Click
        End ' ends the program '
    End Sub
    Private Sub InfoSheetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoSheetsToolStripMenuItem.Click
        Me.Hide() ' removes this form from the screen '
        frmInfoManager.Show() ' opens this form '
    End Sub

    Private Sub NewEmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewEmployeesToolStripMenuItem.Click
        Me.Hide() ' removes this form from the screen '
        frmEmployeeManager.Show() ' opens this form '
    End Sub
    Private Sub EmployeeWageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeWageToolStripMenuItem.Click
        Me.Hide() ' removes this form from the screen '
        frmWage.Show() ' opens this form '
    End Sub

    Private Sub InfoSheetManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoSheetManagerToolStripMenuItem.Click
        Me.Hide() ' removes this form from the screen '
        frmFormManager.Show() ' opens this form '
    End Sub

    Private Sub KickerManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KickerManagerToolStripMenuItem.Click
        Me.Hide() ' removes this form from the screen '
        frmKickerManager.Show() ' opens this form '
    End Sub
End Class