Public Class frmManager
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        frmLogin.Show()
    End Sub
End Class