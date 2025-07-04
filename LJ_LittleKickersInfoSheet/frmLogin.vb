' Title: Information System '
' Author: Lucas Jurgec '
' Date Created: 02/05/2024 Last Modified: 04/08/2024 '
' Description: Login to the program '

Imports System.Data.OleDb
Public Class frmLogin
    Private Sub txtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtPass.Focus() ' Set focus to the password textbox
        End If
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            btnLog.Focus() ' Programmatically click the login button
        End If
    End Sub

    Private Sub btnLog_KeyDown(sender As Object, e As KeyEventArgs) Handles btnLog.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior
            ' Call your login function here
        End If
    End Sub
    Private Sub btnCan_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        End ' ends the program '
    End Sub
    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeKickers.accdb") ' Define the path to the database file by combining the application's startup path with the database file name '
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create a connection string using the specified provider and the database path '
        Dim connection As New OleDbConnection(connectionString) ' Initialize a new instance of the OleDbConnection class with the constructed connection string '

        Try
            connection.Open() ' opens the connection to the database '
            Dim username As String = txtUser.Text ' defines what the user inputted as username '
            Dim password As String = txtPass.Text ' defines what the user inputted as password '

            Dim empQuery As String = "SELECT 'Employee' AS UserType FROM tblEmployees WHERE Username = @Username AND Password = @Password AND StillEmployeed = 'Yes'"
            Dim empCommand As New OleDbCommand(empQuery, connection) ' Create a new OleDbCommand object for the employee query.
            empCommand.Parameters.AddWithValue("@Username", username) ' Add the @Username parameter and assign it the value of the username variable.
            empCommand.Parameters.AddWithValue("@Password", password) ' Add the @Password parameter and assign it the value of the password variable.

            Dim mgrQuery As String = "SELECT 'Manager' AS UserType FROM tblManagers WHERE Username = @Username AND Password = @Password"
            Dim mgrCommand As New OleDbCommand(mgrQuery, connection) ' Create a new OleDbCommand object for the manager query.
            mgrCommand.Parameters.AddWithValue("@Username", username) ' Add the @Username parameter and assign it the value of the username variable.
            mgrCommand.Parameters.AddWithValue("@Password", password) ' Add the @Password parameter and assign it the value of the password variable.

            Dim userType As String = Nothing ' Initialize userType variable to store the result.

            Using empReader As OleDbDataReader = empCommand.ExecuteReader() ' Execute the employee query and obtain a data reader.
                If empReader.Read() Then ' Check if the data reader has any rows.
                    userType = empReader("UserType").ToString() ' If it does, set userType to the value of the UserType column.
                End If
            End Using

            If String.IsNullOrEmpty(userType) Then ' If userType is still null or empty, execute the manager query.
                Using mgrReader As OleDbDataReader = mgrCommand.ExecuteReader() ' Execute the manager query and obtain a data reader.
                    If mgrReader.Read() Then ' Check if the data reader has any rows.
                        userType = mgrReader("UserType").ToString() ' If it does, set userType to the value of the UserType column.
                    End If
                End Using
            End If

            If Not String.IsNullOrEmpty(userType) Then ' If userType is not null or empty, determine which form to display.
                If userType = "Employee" Then
                    Dim employeeWelcome As New frmEmployeeWelcome()
                    employeeWelcome.Show() ' Display the employee welcome form.
                    txtPass.Clear() ' Clear the password textbox.
                    txtUser.Clear() ' Clear the username textbox.
                ElseIf userType = "Manager" Then
                    Dim managerWelcome As New frmManwelcome()
                    managerWelcome.Show() ' Display the manager welcome form.
                    txtPass.Clear() ' Clear the password textbox.
                    txtUser.Clear() ' Clear the username textbox.
                End If
                Me.Hide() ' Hide the current form.
            Else
                MessageBox.Show("Invalid username or password, or you are no longer employed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' displays messagebox '
                txtPass.Clear() ' clears textbox '
                txtUser.Clear() ' clears textbox '
                txtUser.Focus() ' makes this textbox the focus '
            End If
        Catch ex As Exception
            MessageBox.Show("Error during login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' displays messagebox '
            txtPass.Clear() ' clears textbox '
            txtUser.Clear() ' clears textbox '
            txtUser.Focus() ' makes this textbox the focus '
        Finally
            connection.Close() ' closes the connection to the database '
        End Try
    End Sub
End Class