' Title: Information System '
' Author: Lucas Jurgec '
' Date Created: 02/05/2024 Last Modified: 04/08/2024 '
' Description: Add, remove and change the players information in the database '

Imports System.Data.OleDb

Public Class frmKickerManager
    Private Sub txtNameSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNameSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            btnOpen.Focus() ' Programmatically click the Open button
        End If
    End Sub
    Private Sub txtFirst_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFirst.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtLast.Focus() ' Set focus to the password textbox
        End If
    End Sub

    Private Sub txtLast_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLast.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtGuardian.Focus() ' Programmatically click the login button
        End If
    End Sub
    Private Sub txtGuardian_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGuardian.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            cbxAddClass.Focus() ' Programmatically click the Open button
        End If
    End Sub
    Private Sub cbxAddClass_KeyDown(sender As Object, e As KeyEventArgs) Handles cbxAddClass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            cbxAddLocation.Focus() ' Set focus to the password textbox
        End If
    End Sub

    Private Sub cbxAddLocation_KeyDown(sender As Object, e As KeyEventArgs) Handles cbxAddLocation.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            cbxAddDay.Focus() ' Programmatically click the login button
        End If
    End Sub
    Private Sub cbxAddDay_KeyDown(sender As Object, e As KeyEventArgs) Handles cbxAddDay.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtMail.Focus() ' Programmatically click the Open button
        End If
    End Sub
    Private Sub txtMail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMail.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtPhone.Focus() ' Set focus to the password textbox
        End If
    End Sub

    Private Sub txtPhone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPhone.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtBirthday.Focus() ' Programmatically click the login button
        End If
    End Sub
    Private Sub txtBirthday_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBirthday.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            btnAdd.Focus() ' Programmatically click the Open button
        End If
    End Sub
    Private Sub btnAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles btnAdd.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            btnClear.Focus() ' Set focus to the password textbox
        End If
    End Sub

    Private Sub btnClear_KeyDown(sender As Object, e As KeyEventArgs) Handles btnClear.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            btnLoad.Focus() ' Programmatically click the login button
        End If
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        txtFirst.Clear() ' clears textboxes '
        txtLast.Clear() ' clears textboxes '
        txtGuardian.Clear() ' clears textboxes '
        txtBirthday.Clear() ' clears textboxes '
        txtPhone.Clear() ' clears textboxes '
        txtMail.Clear() ' clears textboxes '
        txtNameSearch.Clear() ' clears textboxes '

        cbxNewClass.SelectedIndex = -1 ' clears the comboboxes '
        cbxNewDay.SelectedIndex = -1 ' clears the comboboxes '
        cbxNewLocation.SelectedIndex = -1 ' clears the comboboxes '
        cbxAddClass.SelectedIndex = -1 ' clears the comboboxes '
        cbxAddLocation.SelectedIndex = -1 ' clears the comboboxes '
        cbxAddDay.SelectedIndex = -1 ' clears the comboboxes '


        Me.Hide()
        frmManwelcome.Show()
    End Sub
    Private Sub frmRoleManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxNewClass.Items.Add("J") ' adds this into the combobox '
        cbxNewClass.Items.Add("M") ' adds this into the combobox '

        cbxAddClass.Items.Add("J") ' adds this into the combobox '
        cbxAddClass.Items.Add("M") ' adds this into the combobox '

        cbxAddDay.Items.Add("Saturday") ' adds this into the combobox '
        cbxAddDay.Items.Add("Sunday") ' adds this into the combobox '

        cbxNewDay.Items.Add("Saturday") ' adds this into the combobox '
        cbxNewDay.Items.Add("Sunday") ' adds this into the combobox '

        cbxAddLocation.Items.Add("Brunswick") ' adds this into the combobox '
        cbxAddLocation.Items.Add("Footscray") ' adds this into the combobox '

        cbxNewLocation.Items.Add("Brunswick") ' adds this into the combobox '
        cbxNewLocation.Items.Add("Footscray") ' adds this into the combobox '

        Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeKickers.accdb") ' Define the path to the database file by combining the application's startup path with the database file name '
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create a connection string using the specified provider and the database path '
        Dim connection As New OleDbConnection(connectionString) ' Initialize a new instance of the OleDbConnection class with the constructed connection string '
        Try
            connection.Open() ' opens the connection to the database '
            Dim command As New OleDbCommand("SELECT * FROM tblKickers;", connection) ' sets the path to the table being used '
            Dim dataReader As OleDbDataReader = command.ExecuteReader()
            lbxKickers.Items.Clear()
            Do While dataReader.Read()
                lbxKickers.Items.Add(dataReader("ID").ToString() & " " & dataReader("FirstName").ToString() & " " & dataReader("LastName").ToString())
            Loop

            lbxKickers.Update()
            dataReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message) ' displays messagebox '
        Finally
            connection.Close() ' closes the connection to the database '
        End Try

        AddHandler txtBirthday.MouseHover, AddressOf txtBirthday_MouseHover
        AddHandler txtBirthday.MouseLeave, AddressOf txtBirthday_MouseLeave
        AddHandler txtBirthday.Enter, AddressOf txtBirthday_Enter
        AddHandler txtBirthday.Leave, AddressOf txtBirthday_Leave
    End Sub
    Private Sub txtBirthday_MouseHover(sender As Object, e As EventArgs)
        lblDateExample.Visible = True
    End Sub
    Private Sub txtBirthday_MouseLeave(sender As Object, e As EventArgs)
        lblDateExample.Visible = False
    End Sub
    Private Sub txtBirthday_Enter(sender As Object, e As EventArgs) Handles txtBirthday.Enter
        lblDateExample.Visible = True
    End Sub
    Private Sub txtBirthday_Leave(sender As Object, e As EventArgs) Handles txtBirthday.Leave
        lblDateExample.Visible = False
    End Sub

    Private Function FormatPhoneNumber(phoneNumber As String) As String
        Dim formattedNumber As New System.Text.StringBuilder()

        For i As Integer = 0 To phoneNumber.Length - 1
            If i > 0 AndAlso i Mod 3 = 0 Then
                formattedNumber.Append(" ")
            End If
            formattedNumber.Append(phoneNumber(i))
        Next
        Return formattedNumber.ToString()
    End Function

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If lbxKickers.SelectedItem Is Nothing Then ' checks to see if anything is selected inside the listbox '
            MessageBox.Show("Please select a kicker from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information) ' if nothing is selected this is displayed '
            Return
        End If

        Dim selectedKicker As String = lbxKickers.SelectedItem.ToString() ' sets the selected listbox item as a dim '
        Dim kickerID As Integer ' sets the listbox items id as a dim '

        If Integer.TryParse(selectedKicker.Split(" "c)(0), kickerID) Then ' checks if there is any data associated with the selected id '
            Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeLittleKickers.accdb") ' Define the path to the database file by combining the application's startup path with the database file name '
            Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create a connection string using the specified provider and the database path '
            Dim connection As New OleDbConnection(connectionString) ' Initialize a new instance of the OleDbConnection class with the constructed connection string '
            Try
                connection.Open() ' opens the connection with the database
                Dim command As New OleDbCommand("SELECT FirstName, LastName, GuardianName, Location, Class, DOB, Day, PhoneNumber, Email FROM tblKickers WHERE ID = @ID;", connection) ' gets the information selected based on the id '
                command.Parameters.Add("@ID", OleDbType.Integer).Value = kickerID
                Dim dataReader As OleDbDataReader = command.ExecuteReader()
                If dataReader.Read() Then
                    Try
                        Dim firstName As String = dataReader("FirstName").ToString() ' associates the data in the table with the dim '
                        Dim lastName As String = dataReader("LastName").ToString() ' associates the data in the table with the dim '
                        Dim parentName As String = dataReader("GuardianName").ToString() ' associates the data in the table with the dim '
                        Dim location As String = dataReader("Location").ToString() ' associates the data in the table with the dim '
                        Dim [class] As String = dataReader("Class").ToString() ' associates the data in the table with the dim '
                        Dim dob As String = dataReader("DOB").ToString() ' associates the data in the table with the dim '
                        Dim Day As String = dataReader("Day").ToString() ' associates the data in the table with the dim '
                        Dim phoneNumber As String = FormatPhoneNumber(dataReader("PhoneNumber").ToString()) ' associates the data in the table with the dim and formats the number '
                        Dim email As String = dataReader("Email").ToString() ' associates the data in the table with the dim '

                        Dim details As String = $"First Name: {firstName}{vbCrLf}" & ' defines details as what will be displayed by the messagebox
                                                $"Last Name: {lastName}{vbCrLf}" &
                                                $"Parent Name: {parentName}{vbCrLf}" &
                                                $"Location: {location}{vbCrLf}" &
                                                $"Class: {[class]}{vbCrLf}" &
                                                $"DOB: {dob}{vbCrLf}" &
                                                $"Day: {Day}{vbCrLf}" &
                                                $"Phone Number: 0{phoneNumber}{vbCrLf}" &
                                                $"Email: {email}"

                        MessageBox.Show(details, "Kicker Details", MessageBoxButtons.OK, MessageBoxIcon.Information) ' shows the messagebox '
                    Catch ex As Exception ' checks if there is an error trying to read the data '
                        MessageBox.Show("Error reading data: " & ex.Message) ' displays if there is an error retrieving the data and will explain the error '
                    End Try
                Else
                    MessageBox.Show("No details found for the selected kicker.", "No Details", MessageBoxButtons.OK, MessageBoxIcon.Information) ' displayed if no data is associated with the name ' 
                End If
                dataReader.Close()
            Catch ex As Exception
                MessageBox.Show("Error retrieving details: " & ex.Message) ' displays if there is an error retrieving the data and will explain the error '
            Finally
                connection.Close() ' ends the connection with the database '
            End Try
        Else
            MessageBox.Show("Invalid ID selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' displayed if no data is associated with the id '
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirst.Clear() ' clears textboxes '
        txtLast.Clear()
        txtGuardian.Clear()
        txtBirthday.Clear()
        txtPhone.Clear()
        txtMail.Clear()

        cbxAddClass.SelectedIndex = -1 ' clears the comboboxes '
        cbxAddLocation.SelectedIndex = -1
        cbxAddDay.SelectedIndex = -1
    End Sub

   Private Sub txtNameSearch_TextChanged(sender As Object, e As EventArgs) Handles txtNameSearch.TextChanged
    Dim MatchFound As Boolean = False ' Initialize a flag to track if a match is found.
    Dim Last As Integer = lbxKickers.Items.Count - 1 ' Get the index of the last item in the lbxKickers ListBox.
    Dim I As Integer = 0 ' Initialize a counter variable.
    Dim ThisItem As String = "" ' Initialize a variable to store the current item.

    If txtNameSearch.Text > "" Then ' Check if the search text is not empty.
        Do
            ThisItem = CStr(lbxKickers.Items.Item(I)) ' Get the current item from the ListBox and convert it to a string.
            If ThisItem.IndexOf(txtNameSearch.Text) > -1 Then ' Check if the current item contains the search text.
                MatchFound = True ' Set the flag to true if a match is found.
                lbxKickers.SelectedIndex = I ' Select the current item in the ListBox.
            End If
            I += 1 ' Increment the counter.
        Loop Until I > Last Or MatchFound ' Continue looping until the end of the list is reached or a match is found.

        If Not MatchFound Then ' If no match is found, clear the selection and enable the button.
            lbxKickers.SelectedIndex = -1
            btnOpen.Enabled = True
        Else
            btnOpen.Enabled = True ' Enable the button if a match is found.
        End If
    Else
        lbxKickers.SelectedIndex = -1 ' Clear the selection if the search text is empty.
        btnOpen.Enabled = True ' Enable the button.
    End If
End Sub

Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    Dim firstName As String = txtFirst.Text.Trim() ' Retrieve and trim the first name.
    Dim lastName As String = txtLast.Text.Trim() ' Retrieve and trim the last name.
    Dim email As String = txtMail.Text.Trim() ' Retrieve and trim the email.
    Dim DOB As String = txtBirthday.Text.Trim() ' Retrieve and trim the date of birth.
    Dim [Class] As String = cbxAddClass.SelectedItem.ToString().Trim() ' Retrieve and trim the selected class.
    Dim location As String = cbxAddLocation.SelectedItem.ToString().Trim() ' Retrieve and trim the selected location.
    Dim guardian As String = txtGuardian.Text.Trim() ' Retrieve and trim the guardian name.
    Dim day As String = cbxAddDay.SelectedItem.ToString().Trim() ' Retrieve and trim the selected day.
    Dim phoneNumber As String = txtPhone.Text.Trim() ' Retrieve and trim the phone number.

    If String.IsNullOrEmpty(firstName) OrElse String.IsNullOrEmpty(lastName) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(phoneNumber) OrElse String.IsNullOrEmpty(DOB) OrElse String.IsNullOrEmpty([Class]) OrElse String.IsNullOrEmpty(location) OrElse String.IsNullOrEmpty(guardian) OrElse String.IsNullOrEmpty(day) Then
        MessageBox.Show("Please fill in all fields.", "Information") ' Show a message if any field is empty.
        Return
    End If

        Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeKickers.accdb") ' Construct the database path.
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create the connection string.
    Dim connection As New OleDbConnection(connectionString) ' Initialize a new OleDbConnection with the connection string.

    Try
        connection.Open() ' Open the database connection.

        Dim query As String = "INSERT INTO tblKickers (FirstName, LastName, DOB, GuardianName, Email, PhoneNumber, [Class], Location, [Day]) VALUES (@FirstName, @LastName, @Birthday, @GuardianName, @Email, @PhoneNumber, @Class, @Location, @Day)" ' Define the SQL query to insert a new kicker.
        Dim command As New OleDbCommand(query, connection) ' Initialize a new OleDbCommand with the query and connection.
        command.Parameters.AddWithValue("@FirstName", firstName) ' Add the first name parameter.
        command.Parameters.AddWithValue("@LastName", lastName) ' Add the last name parameter.
        Dim formattedBirthday As DateTime
        If DateTime.TryParse(DOB, formattedBirthday) Then ' Try to parse the date of birth.
            command.Parameters.AddWithValue("@Birthday", formattedBirthday) ' Add the date of birth parameter.
        Else
            MessageBox.Show("Invalid date format for Birthday.", "Error") ' Show a message if the date format is invalid.
            Return
        End If
        command.Parameters.AddWithValue("@GuardianName", guardian) ' Add the guardian name parameter.
        command.Parameters.AddWithValue("@Email", email) ' Add the email parameter.
        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber) ' Add the phone number parameter.
        command.Parameters.AddWithValue("@Class", [Class]) ' Add the class parameter.
        command.Parameters.AddWithValue("@Location", location) ' Add the location parameter.
        command.Parameters.AddWithValue("@Day", day) ' Add the day parameter.

        command.ExecuteNonQuery() ' Execute the query.

        MessageBox.Show("Kicker added successfully!", "Information") ' Show a message if the kicker is added successfully.
    Catch ex As Exception
        MessageBox.Show("An error occurred: " & ex.Message) ' Show a message if an error occurs.
    Finally
        connection.Close() ' Close the database connection.
    End Try
End Sub

Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeKickers.accdb") ' Construct the database path.
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create the connection string.
    Dim connection As New OleDbConnection(connectionString) ' Initialize a new OleDbConnection with the connection string.

    Try
        connection.Open() ' Open the database connection.
        Dim command As New OleDbCommand("SELECT * FROM tblKickers;", connection) ' Define the SQL query to select all kickers.
        Dim dataReader As OleDbDataReader = command.ExecuteReader() ' Execute the query and obtain a data reader.
        lbxKickers.Items.Clear() ' Clear the items in the lbxKickers ListBox.
        Do While dataReader.Read() ' Loop through all the rows in the data reader.
            lbxKickers.Items.Add(dataReader("ID").ToString() & " " & dataReader("FirstName").ToString() & " " & dataReader("LastName").ToString()) ' Add each kicker to the ListBox.
        Loop
        lbxKickers.Update() ' Update the ListBox.
        dataReader.Close() ' Close the data reader.
    Catch ex As Exception
        MessageBox.Show("Error loading data: " & ex.Message) ' Show a message if an error occurs.
    Finally
        connection.Close() ' Close the database connection.
    End Try
End Sub

Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
    If lbxKickers.SelectedItem Is Nothing Then ' Check if no item is selected in the ListBox.
        MessageBox.Show("Please select a kicker from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Show a message if no item is selected.
        Return
    End If

    Dim selectedKicker As String = lbxKickers.SelectedItem.ToString() ' Get the selected kicker from the ListBox.
    Dim kickerID As Integer

    If Integer.TryParse(selectedKicker.Split(" "c)(0), kickerID) Then ' Try to parse the ID from the selected kicker.
        Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeLittleKickers.accdb") ' Construct the database path.
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create the connection string.
        Dim connection As New OleDbConnection(connectionString) ' Initialize a new OleDbConnection with the connection string.

        Dim updates As New List(Of String)()
        If cbxNewLocation.SelectedItem IsNot Nothing Then updates.Add("Location = @Location") ' Add the location update if selected.
        If cbxNewClass.SelectedItem IsNot Nothing Then updates.Add("[Class] = @Class") ' Add the class update if selected.
        If cbxNewDay.SelectedItem IsNot Nothing Then updates.Add("[Day] = @Day") ' Add the day update if selected.

        If updates.Count = 0 Then ' Check if no updates are selected.
            MessageBox.Show("Please select at least one value to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Show a message if no updates are selected.
            Return
        End If

        Dim query As String = "UPDATE tblKickers SET " & String.Join(", ", updates) & " WHERE ID = @ID" ' Construct the update query.

        Try
            connection.Open() ' Open the database connection.

            Dim command As New OleDbCommand(query, connection) ' Initialize a new OleDbCommand with the update query and connection.
                If cbxNewLocation.SelectedItem IsNot Nothing Then command.Parameters.AddWithValue("@Location", cbxNewLocation.SelectedItem.ToString().Trim()) ' Add the location parameter if selected
                If cbxNewClass.SelectedItem IsNot Nothing Then command.Parameters.AddWithValue("@Class", cbxNewClass.SelectedItem.ToString().Trim()) ' Add the class parameter if selected.
            If cbxNewDay.SelectedItem IsNot Nothing Then command.Parameters.AddWithValue("@Day", cbxNewDay.SelectedItem.ToString().Trim()) ' Add the day parameter if selected.
            command.Parameters.AddWithValue("@ID", kickerID) ' Add the ID parameter.
            command.ExecuteNonQuery() ' Execute the update query.

            MessageBox.Show("Kicker updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Show a message if the kicker is updated successfully.
            cbxNewLocation.SelectedIndex = -1 ' Reset the location ComboBox.
            cbxNewClass.SelectedIndex = -1 ' Reset the class ComboBox.
            cbxNewDay.SelectedIndex = -1 ' Reset the day ComboBox.
        Catch ex As Exception
            MessageBox.Show("Error updating kicker: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Show a message if an error occurs.
        Finally
            connection.Close() ' Close the database connection.
        End Try
    Else
        MessageBox.Show("Invalid ID selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Show a message if the ID is invalid.
    End If
End Sub

Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
    If lbxKickers.SelectedItem Is Nothing Then ' Check if no item is selected in the ListBox.
        MessageBox.Show("Please select a kicker from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Show a message if no item is selected.
        Return
    End If

    Dim selectedKicker As String = lbxKickers.SelectedItem.ToString() ' Get the selected kicker from the ListBox.
    Dim kickerID As Integer

    If Integer.TryParse(selectedKicker.Split(" "c)(0), kickerID) Then ' Try to parse the ID from the selected kicker.
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove the selected kicker?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ' Show a confirmation dialog.
        If result = DialogResult.Yes Then
            Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeLittleKickers.accdb") ' Construct the database path.
            Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create the connection string.
            Dim connection As New OleDbConnection(connectionString) ' Initialize a new OleDbConnection with the connection string.

            Try
                connection.Open() ' Open the database connection.

                Dim deleteQuery As String = "DELETE FROM tblKickers WHERE ID = @ID" ' Define the delete query.
                Dim deleteCommand As New OleDbCommand(deleteQuery, connection) ' Initialize a new OleDbCommand with the delete query and connection.
                deleteCommand.Parameters.AddWithValue("@ID", kickerID) ' Add the ID parameter.
                deleteCommand.ExecuteNonQuery() ' Execute the delete query.

                MessageBox.Show("Kicker removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Show a message if the kicker is removed successfully.
                btnLoad.PerformClick() ' Reload the ListBox.
            Catch ex As Exception
                MessageBox.Show("Error removing kicker: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Show a message if an error occurs.
            Finally
                connection.Close() ' Close the database connection.
            End Try
        End If
    Else
        MessageBox.Show("Invalid ID selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Show a message if the ID is invalid.
    End If
End Sub

End Class