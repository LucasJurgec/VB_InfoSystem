' Title: Information System '
' Author: Lucas Jurgec '
' Date Created: 02/05/2024 Last Modified: 04/08/2024 '
' Description: Calculates the wage of employees '

Imports System.Data.OleDb

Public Class frmWage
    Private Sub cbxEmployee_KeyDown(sender As Object, e As KeyEventArgs) Handles cbxEmployee.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtHours.Focus() ' Set focus to the password textbox
        End If
    End Sub
    Private Sub txtHours_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHours.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            btnCalc.Focus() ' Set focus to the password textbox
        End If
    End Sub
    Private Sub btnCalc_KeyDown(sender As Object, e As KeyEventArgs) Handles btnCalc.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide() ' removes this form from the screen '
        frmManwelcome.Show() ' opens this form for the user '

        cbxEmployee.SelectedIndex = -1 ' resets the combobox to display nothing '
        txtHours.Clear() ' clears the textbox '
    End Sub

    Private Sub frmWage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeKickers.accdb") ' Define the path to the database file by combining the application's startup path with the database file name '
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create a connection string using the specified provider and the database path '
        Dim connection As New OleDbConnection(connectionString) ' Initialize a new instance of the OleDbConnection class with the constructed connection string '
        Try
            connection.Open() ' opens the connection to the database '
            Dim command As New OleDbCommand("SELECT ID, FirstName, LastName FROM tblEmployees WHERE StillEmployeed = 'Yes';", connection) ' retrieves the infomation needed from the correct table '
            Dim dataReader As OleDbDataReader = command.ExecuteReader() ' Execute the command and obtain an OleDbDataReader to read the data returned by the query.
            cbxEmployee.Items.Clear() ' Clear all existing items from the cbxEmployee ComboBox control.
            Do While dataReader.Read() ' Loop through all the rows in the dataReader.
                cbxEmployee.Items.Add(dataReader("ID").ToString() & " " & dataReader("FirstName").ToString() & " " & dataReader("LastName").ToString()) ' Add a new item to the cbxEmployee ComboBox, combining the ID, FirstName, and LastName columns from the current row, converting them to strings.
            Loop

            cbxEmployee.Update() ' Update the cbxEmployee ComboBox to reflect the changes.
            dataReader.Close() ' Close the dataReader to free up database resources.
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message) ' displays messagebox '
        Finally
            connection.Close() ' closes the connection to the database '
        End Try
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        If cbxEmployee.SelectedItem Is Nothing Then ' checks if the combobox is empty '
            MessageBox.Show("Please select a employee from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information) ' displays error messagebox '
            Return ' returnes the program to check the if statement again '
        End If

        Dim selectedEmployee As String = cbxEmployee.SelectedItem.ToString() ' defines selectedEmployee as the name selected by the combobox
        Dim kickerID As Integer

        If Integer.TryParse(selectedEmployee.Split(" "c)(0), kickerID) Then
            Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeKickers.accdb") ' Define the path to the database file by combining the application's startup path with the database file name '
            Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create a connection string using the specified provider and the database path '
            Dim connection As New OleDbConnection(connectionString) ' Initialize a new instance of the OleDbConnection class with the constructed connection string '
            Try
                connection.Open() ' opens the connection to the database '
                Dim command As New OleDbCommand("SELECT Rate, FirstName, LastName FROM tblEmployees WHERE ID = @ID;", connection) ' Create a new OleDbCommand object with a parameterized SQL query to select Rate, FirstName, and LastName from tblEmployees where ID matches the parameter @ID.
                command.Parameters.Add("@ID", OleDbType.Integer).Value = kickerID ' Add the @ID parameter to the command, set its type to Integer, and assign its value to kickerID.
                Dim dataReader As OleDbDataReader = command.ExecuteReader() ' Execute the command and obtain an OleDbDataReader to read the data returned by the query.
                If dataReader.Read() Then ' Check if the dataReader has any rows.
                    Try
                        Dim FirstName As String = dataReader("FirstName").ToString() ' Retrieve the FirstName column value from the dataReader, convert it to a string, and assign it to the FirstName variable.
                        Dim LastName As String = dataReader("LastName").ToString() ' Retrieve the LastName column value from the dataReader, convert it to a string, and assign it to the LastName variable.
                        Dim HourlyRate As String = dataReader("Rate").ToString() ' Retrieve the Rate column value from the dataReader, convert it to a string, and assign it to the HourlyRate variable.
                        Dim HoursWorked = txtHours.Text ' Retrieve the text value from the txtHours TextBox control and assign it to the HoursWorked variable.

                        MessageBox.Show(FirstName & " " & LastName & "'s" & " wage = $" & HourlyRate * HoursWorked, "Kicker Details", MessageBoxButtons.OK, MessageBoxIcon.Information) ' display messagebox '
                        txtHours.Clear() ' clears the textbox '
                        cbxEmployee.SelectedIndex = -1 ' clears the combobox '
                        cbxEmployee.Focus() ' makes the combobox the focus '
                    Catch ex As Exception
                        MessageBox.Show("Error reading data: " & ex.Message) ' display messagebox '
                    End Try
                Else
                    MessageBox.Show("No details found for the selected employee.", "No Details", MessageBoxButtons.OK, MessageBoxIcon.Information) ' display messagebox '
                End If
                dataReader.Close()
            Catch ex As Exception
                MessageBox.Show("Error retrieving details: " & ex.Message) ' display messagebox '
            Finally
                connection.Close() ' closes the connection to the database '
            End Try
        Else
            MessageBox.Show("Invalid ID selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' display messagebox '
        End If
    End Sub
End Class