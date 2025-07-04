' Title: Information System '
' Author: Lucas Jurgec '
' Date Created: 02/05/2024 Last Modified: 04/08/2024 '
' Description: Add and remove employees from the busniss '

Imports System.Data.OleDb

Public Class frmEmployeeManager
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide() ' removes the current form '
        frmManwelcome.Show() ' opens the manager welcome form '
    End Sub

    Private Sub frmEmployeeManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRate.Clear() ' clears the textboxes '
        txtPass.Clear()
        txtUser.Clear()
        txtFirst.Clear()
        txtLast.Clear()
        txtBirthday.Clear()
        txtPhone.Clear()
        txtMail.Clear()
        txtSearch.Clear()
        txtPay.Clear()

        Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeKickers.accdb") ' Define the path to the database file by combining the application's startup path with the database file name '
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create a connection string using the specified provider and the database path '
        Dim connection As New OleDbConnection(connectionString) ' Initialize a new instance of the OleDbConnection class with the constructed connection string '
        Try
            connection.Open() ' opens the connection to the database '
            Dim command As New OleDbCommand("SELECT * FROM tblEmployees;", connection) ' This query selects all records from the tblEmployees table '
            Dim dataReader As OleDbDataReader = command.ExecuteReader() ' Execute the query and obtain an OleDbDataReader object to read the data '
            lbxEmployee.Items.Clear() ' Clear all items from the lbxEmployee ListBox.
            Do While dataReader.Read() ' Loop through all rows in the dataReader.
                lbxEmployee.Items.Add(dataReader("ID").ToString() & " " & dataReader("FirstName").ToString() & " " & dataReader("LastName").ToString()) ' Add each employee's ID, FirstName, and LastName to the lbxEmployee ListBox.
            Loop

            lbxEmployee.Update() ' Update the lbxEmployee ListBox.
            dataReader.Close() ' Close the dataReader.
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message) ' Display an error message if an exception occurs.
        Finally
            connection.Close() ' Close the database connection.
        End Try

        AddHandler txtBirthday.MouseHover, AddressOf txtBirthday_MouseHover ' Add event handler for MouseHover event of txtBirthday.
        AddHandler txtBirthday.MouseLeave, AddressOf txtBirthday_MouseLeave ' Add event handler for MouseLeave event of txtBirthday.
        AddHandler txtBirthday.Enter, AddressOf txtBirthday_Enter ' Add event handler for Enter event of txtBirthday.
        AddHandler txtBirthday.Leave, AddressOf txtBirthday_Leave ' Add event handler for Leave event of txtBirthday.
    End Sub

    Private Sub txtBirthday_MouseHover(sender As Object, e As EventArgs)
        lblDateExample.Visible = True ' Show the lblDateExample label when the mouse hovers over txtBirthday.
    End Sub

    Private Sub txtBirthday_MouseLeave(sender As Object, e As EventArgs)
        lblDateExample.Visible = False ' Hide the lblDateExample label when the mouse leaves txtBirthday.
    End Sub

    Private Sub txtBirthday_Enter(sender As Object, e As EventArgs) Handles txtBirthday.Enter
        lblDateExample.Visible = True ' Show the lblDateExample label when txtBirthday receives focus.
    End Sub

    Private Sub txtBirthday_Leave(sender As Object, e As EventArgs) Handles txtBirthday.Leave
        lblDateExample.Visible = False ' Hide the lblDateExample label when txtBirthday loses focus.
    End Sub

    Private Function FormatPhoneNumber(phoneNumber As String) As String
        Dim formattedNumber As New System.Text.StringBuilder() ' Initialize a StringBuilder for the formatted phone number.

        For i As Integer = 0 To phoneNumber.Length - 1
            If i > 0 AndAlso i Mod 3 = 0 Then
                formattedNumber.Append(" ") ' Add a space every three characters.
            End If
            formattedNumber.Append(phoneNumber(i)) ' Append each character of the phone number.
        Next
        Return formattedNumber.ToString() ' Return the formatted phone number.
    End Function

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        If lbxEmployee.SelectedItem Is Nothing Then ' Check if no item is selected in the lbxEmployee ListBox.
            MessageBox.Show("Please select a kicker from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Display a message if no item is selected.
            Return ' Exit the subroutine.
        End If

        Dim selectedKicker As String = lbxEmployee.SelectedItem.ToString() ' Get the selected item from the lbxEmployee ListBox.
        Dim kickerID As Integer

        If Integer.TryParse(selectedKicker.Split(" "c)(0), kickerID) Then ' Try to parse the ID from the selected item.
            Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeKickers.accdb") ' Define the path to the database file.
            Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create the connection string.
            Dim connection As New OleDbConnection(connectionString) ' Initialize a new OleDbConnection with the connection string.
            Try
                connection.Open() ' Open the database connection.
                Dim command As New OleDbCommand("SELECT FirstName, LastName, Rate, Username, DOB, Password, PhoneNumber, Email, StillEmployeed FROM tblEmployees WHERE ID = @ID;", connection) ' Define the SQL query to select employee details.
                command.Parameters.Add("@ID", OleDbType.Integer).Value = kickerID ' Add the ID parameter to the query.
                Dim dataReader As OleDbDataReader = command.ExecuteReader() ' Execute the query and obtain a data reader.
                If dataReader.Read() Then ' Check if the data reader has any rows.
                    Try
                        Dim firstName As String = dataReader("FirstName").ToString()
                        Dim lastName As String = dataReader("LastName").ToString()
                        Dim Username As String = dataReader("Username").ToString()
                        Dim Password As String = dataReader("Password").ToString()
                        Dim Rate As String = dataReader("Rate").ToString()
                        Dim dob As String = dataReader("DOB").ToString()
                        Dim Employeed As String = dataReader("StillEmployeed").ToString()
                        Dim phoneNumber As String = FormatPhoneNumber(dataReader("PhoneNumber").ToString())
                        Dim email As String = dataReader("Email").ToString()

                        Dim details As String = $"First Name: {firstName}{vbCrLf}" &
                                                $"Last Name: {lastName}{vbCrLf}" &
                                                $"Username: {Username}{vbCrLf}" &
                                                $"Password: {Password}{vbCrLf}" &
                                                $"Hourly Rate: ${[Rate]}{vbCrLf}" &
                                                $"DOB: {dob}{vbCrLf}" &
                                                $"Email: {email}{vbCrLf}" &
                                                $"Phone Number: 0{phoneNumber}{vbCrLf}" &
                                                $"Current Employee?: {Employeed}"

                        MessageBox.Show(details, "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Display the employee details.
                    Catch ex As Exception
                        MessageBox.Show("Error reading data: " & ex.Message) ' Display an error message if an exception occurs.
                    End Try
                Else
                    MessageBox.Show("No details found for the selected employee.", "No Details", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Display a message if no details are found.
                End If
                dataReader.Close() ' Close the data reader.
            Catch ex As Exception
                MessageBox.Show("Error retrieving details: " & ex.Message) ' Display an error message if an exception occurs.
            Finally
                connection.Close() ' Close the database connection.
            End Try
        Else
            MessageBox.Show("Invalid ID selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Display an error message if the ID is invalid.
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim MatchFound As Boolean = False ' Initialize a flag to track if a match is found.
        Dim Last As Integer = lbxEmployee.Items.Count - 1 ' Get the index of the last item in the lbxEmployee ListBox.
        Dim I As Integer = 0 ' Initialize a counter variable.
        Dim ThisItem As String = "" ' Initialize a variable to store the current item.

        If txtSearch.Text > "" Then ' Check if the search text is not empty.
            Do
                ThisItem = CStr(lbxEmployee.Items.Item(I)) ' Get the current item from the ListBox and convert it to a string.
                If ThisItem.IndexOf(txtSearch.Text) > -1 Then ' Check if the current item contains the search text.
                    MatchFound = True ' Set the flag to true if a match is found.
                    lbxEmployee.SelectedIndex = I ' Select the current item in the ListBox.
                End If
                I += 1 ' Increment the counter.
            Loop Until I > Last Or MatchFound ' Continue looping until the end of the list is reached or a match is found.

            If Not MatchFound Then ' If no match is found, clear the selection and enable the button.
                lbxEmployee.SelectedIndex = -1
                btnInfo.Enabled = True
            Else
                btnInfo.Enabled = True ' Enable the button if a match is found.
            End If
        Else
            lbxEmployee.SelectedIndex = -1 ' Clear the selection if the search text is empty.
            btnInfo.Enabled = True ' Enable the button.
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim firstName As String = txtFirst.Text.Trim() ' Retrieve and trim the first name.
        Dim lastName As String = txtLast.Text.Trim() ' Retrieve and trim the last name.
        Dim email As String = txtMail.Text.Trim() ' Retrieve and trim the email.
        Dim username As String = txtUser.Text.Trim() ' Retrieve and trim the username.
        Dim password As String = txtPass.Text.Trim() ' Retrieve and trim the password.
        Dim DOB As String = txtBirthday.Text.Trim() ' Retrieve and trim the date of birth.
        Dim rate As String = txtRate.Text.Trim() ' Retrieve and trim the rate.
        Dim phoneNumber As String = txtPhone.Text.Trim() ' Retrieve and trim the phone number.

        If String.IsNullOrEmpty(firstName) OrElse String.IsNullOrEmpty(lastName) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(phoneNumber) OrElse String.IsNullOrEmpty(DOB) OrElse String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(rate) Then
            MessageBox.Show("Please fill in all fields.", "Information") ' Show a message if any field is empty.
            Return
        End If

        Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeKickers.accdb") ' Define the path to the database file.
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create the connection string.
        Dim connection As New OleDbConnection(connectionString) ' Initialize a new OleDbConnection with the connection string.
        Try
            connection.Open() ' Open the database connection.

            ' Prepare SQL query
            Dim query As String = "INSERT INTO tblEmployees ([FirstName], [LastName], [DOB], [Username], [Password], [Email], [PhoneNumber], [Rate], [StillEmployeed]) VALUES (@FirstName, @LastName, @DOB, @Username, @Password, @Email, @PhoneNumber, @Rate, @StillEmployeed)"
            Dim command As New OleDbCommand(query, connection) ' Initialize a new OleDbCommand with the query and connection.

            ' Add parameters
            command.Parameters.AddWithValue("@FirstName", firstName) ' Add the first name parameter.
            command.Parameters.AddWithValue("@LastName", lastName) ' Add the last name parameter.
            Dim formattedBirthday As DateTime
            If DateTime.TryParse(DOB, formattedBirthday) Then ' Try to parse the date of birth.
                command.Parameters.AddWithValue("@DOB", formattedBirthday) ' Add the date of birth parameter.
            Else
                MessageBox.Show("Invalid date format for Birthday.", "Error") ' Show a message if the date format is invalid.
                Return
            End If
            command.Parameters.AddWithValue("@Username", username) ' Add the username parameter.
            command.Parameters.AddWithValue("@Password", password) ' Add the password parameter.
            command.Parameters.AddWithValue("@Email", email) ' Add the email parameter.
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber) ' Add the phone number parameter.
            command.Parameters.AddWithValue("@Rate", rate) ' Add the rate parameter.
            command.Parameters.AddWithValue("@StillEmployeed", "Yes") ' Add the StillEmployeed parameter.

            ' Execute query
            command.ExecuteNonQuery() ' Execute the query.
            MessageBox.Show("Employee added successfully!", "Information") ' Show a message if the employee is added successfully.
        Catch ex As OleDbException
            MessageBox.Show("OleDb Error: " & ex.Message) ' Show an OleDb error message if an exception occurs.
        Catch ex As Exception
            MessageBox.Show("General Error: " & ex.Message) ' Show a general error message if an exception occurs.
        Finally
            connection.Close() ' Close the database connection.
        End Try
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeKickers.accdb") ' Define the path to the database file.
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create the connection string.
        Dim connection As New OleDbConnection(connectionString) ' Initialize a new OleDbConnection with the connection string.

        Try
            connection.Open() ' Open the database connection.
            Dim command As New OleDbCommand("SELECT * FROM tblEmployees;", connection) ' Define the SQL query to select all employees.
            Dim dataReader As OleDbDataReader = command.ExecuteReader() ' Execute the query and obtain a data reader.
            lbxEmployee.Items.Clear() ' Clear the items in the lbxEmployee ListBox.
            Do While dataReader.Read() ' Loop through all the rows in the data reader.
                lbxEmployee.Items.Add(dataReader("ID").ToString() & " " & dataReader("FirstName").ToString() & " " & dataReader("LastName").ToString()) ' Add each employee's details to the ListBox.
            Loop
            lbxEmployee.Update() ' Update the ListBox.
            dataReader.Close() ' Close the data reader.
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message) ' Show a message if an error occurs.
        Finally
            connection.Close() ' Close the database connection.
        End Try
    End Sub

    Private Sub btnClearEmployee_Click(sender As Object, e As EventArgs) Handles btnClearEmployee.Click
        txtRate.Clear() ' Clear the rate TextBox.
        txtPass.Clear() ' Clear the password TextBox.
        txtUser.Clear() ' Clear the username TextBox.
        txtFirst.Clear() ' Clear the first name TextBox.
        txtLast.Clear() ' Clear the last name TextBox.
        txtBirthday.Clear() ' Clear the birthday TextBox.
        txtPhone.Clear() ' Clear the phone number TextBox.
        txtMail.Clear() ' Clear the email TextBox.
    End Sub

    Private Sub btnIncrease_Click(sender As Object, e As EventArgs) Handles btnIncrease.Click
        If lbxEmployee.SelectedItem Is Nothing Then ' Check if no item is selected in the lbxEmployee ListBox.
            MessageBox.Show("Please select an employee from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Display a message if no item is selected.
            Return
        End If

        Dim selectedKicker As String = lbxEmployee.SelectedItem.ToString() ' Get the selected item from the lbxEmployee ListBox.
        Dim kickerID As Integer

        If Integer.TryParse(selectedKicker.Split(" "c)(0), kickerID) Then ' Try to parse the ID from the selected item.
            Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeKickers.accdb") ' Define the path to the database file.
            Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create the connection string.
            Dim connection As New OleDbConnection(connectionString) ' Initialize a new OleDbConnection with the connection string.

            Dim updates As New List(Of String)()
            If txtPay.SelectedText IsNot Nothing Then updates.Add("Rate = @Rate") ' Add the rate update if a value is selected.

            If updates.Count = 0 Then ' Check if no updates are selected.
                MessageBox.Show("Please select at least one value to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Show a message if no updates are selected.
                Return
            End If

            Dim query As String = "UPDATE tblEmployees SET " & String.Join(", ", updates) & " WHERE ID = @ID" ' Construct the update query.
            Dim NewPay As String = txtPay.Text.Trim() ' Get the new pay rate.

            Try
                connection.Open() ' Open the database connection.
                Dim command As New OleDbCommand(query, connection) ' Initialize a new OleDbCommand with the update query and connection.
                If txtPay.SelectedText IsNot Nothing Then command.Parameters.AddWithValue("@Rate", NewPay) ' Add the rate parameter if a value is selected.
                command.Parameters.AddWithValue("@ID", kickerID) ' Add the ID parameter.

                command.ExecuteNonQuery() ' Execute the update query.
                MessageBox.Show("Pay updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Show a message if the pay is updated successfully.
            Catch ex As Exception
                MessageBox.Show("Error updating pay: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Show a message if an error occurs.
            Finally
                connection.Close() ' Close the database connection.
            End Try
        Else
            MessageBox.Show("Invalid ID selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Show a message if the ID is invalid.
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lbxEmployee.SelectedItem Is Nothing Then ' Check if no item is selected in the lbxEmployee ListBox.
            MessageBox.Show("Please select an employee from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Display a message if no item is selected.
            Return
        End If

        Dim selectedKicker As String = lbxEmployee.SelectedItem.ToString() ' Get the selected item from the lbxEmployee ListBox.
        Dim kickerID As Integer

        If Integer.TryParse(selectedKicker.Split(" "c)(0), kickerID) Then ' Try to parse the ID from the selected item.
            Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeKickers.accdb") ' Define the path to the database file.
            Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create the connection string.
            Dim connection As New OleDbConnection(connectionString) ' Initialize a new OleDbConnection with the connection string.

            Dim updates As New List(Of String)()

            Dim query As String = "UPDATE tblEmployees SET StillEmployeed = @StillEmployeed WHERE ID = @ID" ' Define the update query.

            Try
                connection.Open() ' Open the database connection.
                Dim command As New OleDbCommand(query, connection) ' Initialize a new OleDbCommand with the update query and connection.
                command.Parameters.AddWithValue("@StillEmployeed", "No") ' Add the StillEmployeed parameter.
                command.Parameters.AddWithValue("@ID", kickerID) ' Add the ID parameter.

                command.ExecuteNonQuery() ' Execute the update query.
                MessageBox.Show("Employee removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Show a message if the employee is removed successfully.
            Catch ex As Exception
                MessageBox.Show("Error removing employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Show a message if an error occurs.
            Finally
                connection.Close() ' Close the database connection.
            End Try
        Else
            MessageBox.Show("Invalid ID selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Show a message if the ID is invalid.
        End If
    End Sub

End Class