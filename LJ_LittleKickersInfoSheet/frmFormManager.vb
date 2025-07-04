' Title: Information System '
' Author: Lucas Jurgec '
' Date Created: 02/05/2024 Last Modified: 04/08/2024 '
' Description: Manage the information inputted into by the employees '

Imports System.Data.OleDb
Public Class frmFormManager
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        frmManwelcome.Show()

        cbxLocation.SelectedIndex = -1
    End Sub
    Private Sub LoadData()
        Dim selectedLocation As String = If(cbxLocation.SelectedItem?.ToString(), String.Empty)
        Dim selectedDate As DateTime = dtpDate.Value.Date
        Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeKickers.accdb") ' Define the path to the database file by combining the application's startup path with the database file name '
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create a connection string using the specified provider and the database path '
        Dim connection As New OleDbConnection(connectionString) ' Initialize a new instance of the OleDbConnection class with the constructed connection string '

        Try
            connection.Open() ' Open the database connection.
            lbxInfo.Items.Clear() ' Clear all items from the lbxInfo ListBox.

            If selectedLocation.Equals("Brunswick", StringComparison.OrdinalIgnoreCase) OrElse String.IsNullOrEmpty(selectedLocation) Then
                Dim commandBrunswick As New OleDbCommand("SELECT * FROM tblBrunswickInfo WHERE InfoDate = @SelectedDate;", connection) ' Create a command to select Brunswick info.
                commandBrunswick.Parameters.Add("@SelectedDate", OleDbType.Date).Value = selectedDate ' Add the selected date parameter.
                Dim dataReaderBrunswick As OleDbDataReader = commandBrunswick.ExecuteReader() ' Execute the command and obtain a data reader.
                Do While dataReaderBrunswick.Read() ' Loop through all rows in the data reader.
                    lbxInfo.Items.Add("Brunswick: " & dataReaderBrunswick("ID").ToString() & " " & dataReaderBrunswick("InfoDate").ToString() & " " & dataReaderBrunswick("Venue").ToString()) ' Add Brunswick info to the ListBox.
                Loop
                dataReaderBrunswick.Close() ' Close the data reader.
            End If

            If selectedLocation.Equals("Footscray", StringComparison.OrdinalIgnoreCase) OrElse String.IsNullOrEmpty(selectedLocation) Then
                Dim commandFootscray As New OleDbCommand("SELECT * FROM tblFootscrayInfo WHERE InfoDate = @SelectedDate;", connection) ' Create a command to select Footscray info.
                commandFootscray.Parameters.Add("@SelectedDate", OleDbType.Date).Value = selectedDate ' Add the selected date parameter.
                Dim dataReaderFootscray As OleDbDataReader = commandFootscray.ExecuteReader() ' Execute the command and obtain a data reader.
                Do While dataReaderFootscray.Read() ' Loop through all rows in the data reader.
                    lbxInfo.Items.Add("Footscray: " & dataReaderFootscray("ID").ToString() & " " & dataReaderFootscray("InfoDate").ToString() & " " & dataReaderFootscray("Venue").ToString()) ' Add Footscray info to the ListBox.
                Loop
                dataReaderFootscray.Close() ' Close the data reader.
            End If

            lbxInfo.Update() ' Update the ListBox.
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message) ' Display an error message if an exception occurs.
        Finally
            connection.Close() ' Close the database connection.
        End Try
    End Sub

    Private Sub frmFormManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxLocation.Items.Add("Brunswick") ' Add Brunswick to the ComboBox.
        cbxLocation.Items.Add("Footscray") ' Add Footscray to the ComboBox.

        LoadData() ' Load initial data.
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If lbxInfo.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an entry from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Display a message if no item is selected.
            Return
        End If

        Dim selectedItem As String = lbxInfo.SelectedItem.ToString() ' Get the selected item from the ListBox.
        Dim parts() As String = selectedItem.Split(" "c) ' Split the selected item into parts.
        Dim tableName As String = parts(0).Replace(":", "").Trim() ' Get the table name from the selected item.
        Dim itemID As Integer

        If Integer.TryParse(parts(1), itemID) Then
            Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeKickers.accdb") ' Define the path to the database file.
            Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create the connection string.
            Dim connection As New OleDbConnection(connectionString) ' Initialize a new OleDbConnection with the connection string.
            Try
                connection.Open() ' Open the database connection.
                Dim command As New OleDbCommand($"SELECT * FROM tbl{tableName}Info WHERE ID = @ID;", connection) ' Define the SQL query to select details.
                command.Parameters.Add("@ID", OleDbType.Integer).Value = itemID ' Add the ID parameter to the query.
                Dim dataReader As OleDbDataReader = command.ExecuteReader() ' Execute the query and obtain a data reader.
                If dataReader.Read() Then ' Check if the data reader has any rows.
                    Try
                        Dim details As String = $"Info Date: {dataReader("InfoDate").ToString()}{vbCrLf}" &
                                                $"Venue: {dataReader("Venue").ToString()}{vbCrLf}" &
                                                $"Coach: {dataReader("Coach").ToString()}{vbCrLf}" &
                                                $"Assistant Coach: {dataReader("ACoach").ToString()}{vbCrLf}" &
                                                $"First Aid Person: {dataReader("FirstAidPerson").ToString()}{vbCrLf}" &
                                                $"Aid Kit Available: {dataReader("AidKitAvailable").ToString()}{vbCrLf}" &
                                                $"Floor: {dataReader("Floor").ToString()}{vbCrLf}" &
                                                $"Equipment: {dataReader("Equipment").ToString()}{vbCrLf}" &
                                                $"Fire: {dataReader("Fire").ToString()}{vbCrLf}" &
                                                $"Hazard: {dataReader("Hazard").ToString()}{vbCrLf}" &
                                                $"Glazing: {dataReader("Glazing").ToString()}{vbCrLf}" &
                                                $"Electrical: {dataReader("Electrical").ToString()}{vbCrLf}" &
                                                $"Risk: {dataReader("Risk").ToString()}{vbCrLf}" &
                                                $"Major Incident: {dataReader("MajorIncident").ToString()}{vbCrLf}" &
                                                $"Minor Incident: {dataReader("MinorIncident").ToString()}{vbCrLf}" &
                                                $"Aid Kit Replacement Required: {dataReader("AidKitReplacementRequired").ToString()}{vbCrLf}" &
                                                $"Equipment Packed Away: {dataReader("EquipmentPackedAway").ToString()}{vbCrLf}" &
                                                $"Uniform Repair: {dataReader("UniformRepair").ToString()}{vbCrLf}" &
                                                $"Venue Condition: {dataReader("VenueCondition").ToString()}{vbCrLf}" &
                                                $"Before 2 Balls: {dataReader("Before2Balls").ToString()}{vbCrLf}" &
                                                $"Before 3 Balls: {dataReader("Befor3Balls").ToString()}{vbCrLf}" &
                                                $"Before J Kits: {dataReader("BeforeJKits").ToString()}{vbCrLf}" &
                                                $"Before M Kits: {dataReader("BeforeMKits").ToString()}{vbCrLf}" &
                                                $"Before J Book: {dataReader("BeforeJBook").ToString()}{vbCrLf}" &
                                                $"Before M Book: {dataReader("BeforeMBook").ToString()}{vbCrLf}" &
                                                $"Before Bags: {dataReader("BeforeBags").ToString()}{vbCrLf}" &
                                                $"After 2 Balls: {dataReader("After2Balls").ToString()}{vbCrLf}" &
                                                $"After 3 Balls: {dataReader("After3Balls").ToString()}{vbCrLf}" &
                                                $"After J Kits: {dataReader("AfterJKits").ToString()}{vbCrLf}" &
                                                $"After M Kits: {dataReader("AfterMKits").ToString()}{vbCrLf}" &
                                                $"After J Book: {dataReader("AfterJBook").ToString()}{vbCrLf}" &
                                                $"After M Book: {dataReader("AfterMBook").ToString()}{vbCrLf}" &
                                                $"After Bags: {dataReader("AfterBags").ToString()}"

                        MessageBox.Show(details, "Attendance Details", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Display the attendance details.
                    Catch ex As Exception
                        MessageBox.Show("Error reading data: " & ex.Message) ' Display an error message if an exception occurs.
                    End Try
                Else
                    MessageBox.Show("No details found for the selected entry.", "No Details", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Display a message if no details are found.
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

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lbxInfo.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an entry from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Display a message if no item is selected.
            Return
        End If

        Dim selectedItem As String = lbxInfo.SelectedItem.ToString() ' Get the selected item from the ListBox.
        Dim parts() As String = selectedItem.Split(" "c) ' Split the selected item into parts.
        Dim tableName As String = parts(0).Replace(":", "").Trim() ' Get the table name from the selected item.

        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete all records from the selected table?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ' Show a confirmation dialog.
        If confirmResult = DialogResult.Yes Then
            Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeKickers.accdb") ' Define the path to the database file.
            Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create the connection string.
            Dim connection As New OleDbConnection(connectionString) ' Initialize a new OleDbConnection with the connection string.
            Try
                connection.Open() ' Open the database connection.
                Dim command As New OleDbCommand($"DELETE FROM tbl{tableName}Info;", connection) ' Define the delete query.
                Dim rowsAffected As Integer = command.ExecuteNonQuery() ' Execute the delete query and get the number of affected rows.
                MessageBox.Show($"{rowsAffected} record(s) deleted from the table.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Display a message if the records are deleted successfully.
            Catch ex As Exception
                MessageBox.Show("Error deleting records: " & ex.Message) ' Display an error message if an exception occurs.
            Finally
                connection.Close() ' Close the database connection.
            End Try
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadData() ' Load data into the form.
    End Sub

End Class