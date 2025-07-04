' Title: Information System '
' Author: Lucas Jurgec '
' Date Created: 02/05/2024 Last Modified: 04/08/2024 '
' Description: Sumbit the information inputted into the database '

Imports System.Data.OleDb
Public Class frmInfo
    Private Sub txtDate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            cbxVenue.Focus() ' Programmatically click the login button
        End If
    End Sub
    Private Sub cbxVenue_KeyDown(sender As Object, e As KeyEventArgs) Handles cbxVenue.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtCoach.Focus() ' Programmatically click the Open button
        End If
    End Sub
    Private Sub txtCoach_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCoach.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtAssistant.Focus() ' Set focus to the password textbox
        End If
    End Sub

    Private Sub txtAssistant_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAssistant.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtAid.Focus() ' Programmatically click the login button
        End If
    End Sub
    Private Sub txtAid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAid.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txt2BallsBefore.Focus() ' Programmatically click the login button
        End If
    End Sub
    Private Sub txt2BallsBefore_KeyDown(sender As Object, e As KeyEventArgs) Handles txt2BallsBefore.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txt3BallsBefore.Focus() ' Programmatically click the Open button
        End If
    End Sub
    Private Sub txt3BallsBefore_KeyDown(sender As Object, e As KeyEventArgs) Handles txt3BallsBefore.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtJKitsBefore.Focus() ' Set focus to the password textbox
        End If
    End Sub

    Private Sub txtJKitsBefore_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJKitsBefore.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtMKitsAfter.Focus() ' Programmatically click the login button
        End If
    End Sub
    Private Sub txtMKitsBefore_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMKitsBefore.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtJBooksBefore.Focus() ' Programmatically click the login button
        End If
    End Sub
    Private Sub txtJBooksBefore_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJBooksBefore.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtMBooksBefore.Focus() ' Programmatically click the Open button
        End If
    End Sub
    Private Sub txtMBooksBefore_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMBooksBefore.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtBagsBefore.Focus() ' Set focus to the password textbox
        End If
    End Sub

    Private Sub txtBagsBefore_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBagsBefore.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txt2BallsAfter.Focus() ' Programmatically click the login button
        End If
    End Sub
    Private Sub txt2BallsAfter_KeyDown(sender As Object, e As KeyEventArgs) Handles txt2BallsAfter.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txt3BallsAfter.Focus() ' Programmatically click the Open button
        End If
    End Sub

    Private Sub txt3BallsAfter_KeyDown(sender As Object, e As KeyEventArgs) Handles txt3BallsAfter.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtJKitsAfter.Focus() ' Set focus to the password textbox
        End If
    End Sub

    Private Sub txtJKitsAfter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJKitsAfter.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtMKitsAfter.Focus() ' Programmatically click the login button
        End If
    End Sub

    Private Sub txtMKitsAfter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMKitsAfter.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtJBooksAfter.Focus() ' Programmatically click the login button
        End If
    End Sub

    Private Sub txtJBooksAfter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJBooksAfter.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtMBooksAfter.Focus() ' Programmatically click the Open button
        End If
    End Sub

    Private Sub txtMBooksAfter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMBooksAfter.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the default Enter behavior (like adding a new line)
            txtBagsAfter.Focus() ' Set focus to the password textbox
        End If
    End Sub

    Private Sub FrmInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxAid.Items.Add("Yes") ' adds the value to the combo box '
        cbxAid.Items.Add("No")

        cbxVenue.Items.Add("Brunswick")
        cbxVenue.Items.Add("Footscray")

        cbxMajor.Items.Add("Yes")
        cbxMajor.Items.Add("No")

        cbxMinor.Items.Add("Yes")
        cbxMinor.Items.Add("No")

        cbxGood.Items.Add("Yes")
        cbxGood.Items.Add("No")

        cbxEquipment.Items.Add("Yes")
        cbxEquipment.Items.Add("No")

        cbxUniform.Items.Add("Yes")
        cbxUniform.Items.Add("No")

        cbxReplacement.Items.Add("Yes")
        cbxReplacement.Items.Add("No")

        AddHandler txtDate.MouseHover, AddressOf txtDate_MouseHover
        AddHandler txtDate.MouseLeave, AddressOf txtDate_MouseLeave
        AddHandler txtDate.Enter, AddressOf txtDate_Enter
        AddHandler txtDate.Leave, AddressOf txtDate_Leave
    End Sub
    Private Sub txtDate_MouseHover(sender As Object, e As EventArgs)
        lblDateExample.Visible = True
    End Sub
    Private Sub txtDate_MouseLeave(sender As Object, e As EventArgs)
        lblDateExample.Visible = False
    End Sub
    Private Sub txtDate_Enter(sender As Object, e As EventArgs) Handles txtDate.Enter
        lblDateExample.Visible = True
    End Sub
    Private Sub txtDate_Leave(sender As Object, e As EventArgs) Handles txtDate.Leave
        lblDateExample.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide() ' hides this form '
        frmEmployeeWelcome.Show() ' opens this form '

        txtDate.Clear() ' resets all the textboxes comboxboxes and checkboxes '
        txtCoach.Clear()
        txtAssistant.Clear()
        txtAid.Clear()
        txt2BallsBefore.Clear()
        txt3BallsBefore.Clear()
        txt2BallsAfter.Clear()
        txt3BallsAfter.Clear()
        txtBagsBefore.Clear()
        txtBagsAfter.Clear()
        txtJKitsBefore.Clear()
        txtMKitsBefore.Clear()
        txtJKitsAfter.Clear()
        txtMKitsAfter.Clear()
        txtJBooksBefore.Clear()
        txtJBooksAfter.Clear()
        txtMBooksBefore.Clear()
        txtMBooksAfter.Clear()

        cbxAid.SelectedIndex = -1
        cbxVenue.SelectedIndex = -1
        cbxMajor.SelectedIndex = -1
        cbxMinor.SelectedIndex = -1
        cbxEquipment.SelectedIndex = -1
        cbxUniform.SelectedIndex = -1
        cbxGood.SelectedIndex = -1
        cbxReplacement.SelectedIndex = -1

        chbFloor.Checked = False
        chbEquipment.Checked = False
        chbFire.Checked = False
        chbHazards.Checked = False
        chbGlazing.Checked = False
        chbElectrical.Checked = False
        chbRisk.Checked = False
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim InfoDate As String = txtDate.Text.Trim() ' Retrieve the text value from the TextBox control and remove any leading or trailing whitespace '
        Dim InfoCoach As String = txtCoach.Text.Trim()
        Dim InfoAssistant As String = txtAssistant.Text.Trim()
        Dim InfoFirstAid As String = txtAid.Text.Trim()
        Dim InfoAidKitAvailable As String = cbxAid.SelectedItem.ToString().Trim()
        Dim InfoVenue As String = cbxVenue.SelectedItem.ToString().Trim()

        Dim StockBalls2Before As String = txt2BallsBefore.Text.Trim() ' Retrieve the text value from the TextBox control and remove any leading or trailing whitespace '
        Dim StockBall3Before As String = txt3BallsBefore.Text.Trim()
        Dim StockBall2After As String = txt2BallsAfter.Text.Trim()
        Dim StockBall3After As String = txt3BallsAfter.Text.Trim()
        Dim StockBagsBefore As String = txtBagsBefore.Text.Trim()
        Dim StockBagsAfter As String = txtBagsAfter.Text.Trim()
        Dim StockKitJBefore As String = txtJKitsBefore.Text.Trim()
        Dim StockKitMBefore As String = txtMKitsBefore.Text.Trim()
        Dim StockKitJAfter As String = txtJKitsAfter.Text.Trim()
        Dim StockKitMAfter As String = txtMKitsAfter.Text.Trim()
        Dim StockBookJBefore As String = txtJBooksBefore.Text.Trim()
        Dim StockBookJAfter As String = txtJBooksAfter.Text.Trim()
        Dim StockBookMBefore As String = txtMBooksBefore.Text.Trim()
        Dim StockBookMAfter As String = txtMBooksAfter.Text.Trim()

        Dim AfterMajor As String = cbxMajor.SelectedItem.ToString().Trim()
        Dim AfterMinor As String = cbxMinor.SelectedItem.ToString().Trim()
        Dim AfterEquipment As String = cbxEquipment.SelectedItem.ToString().Trim()
        Dim AfterUniform As String = cbxUniform.SelectedItem.ToString().Trim()
        Dim AfterGood As String = cbxGood.SelectedItem.ToString().Trim()
        Dim AfterReplace As String = cbxReplacement.SelectedItem.ToString().Trim()

        Dim SafteyFloor As Boolean = chbFloor.Checked
        Dim SafteyEquipment As Boolean = chbEquipment.Checked
        Dim SafteyFire As Boolean = chbFire.Checked
        Dim SafteyHazard As Boolean = chbHazards.Checked
        Dim SafteryGlazing As Boolean = chbGlazing.Checked
        Dim SafteryElectrical As Boolean = chbElectrical.Checked
        Dim SafteryRisk As Boolean = chbRisk.Checked

        Dim attendanceTable As String
        Select Case InfoVenue
            Case "Footscray"
                attendanceTable = "tblFootscrayInfo"
            Case "Brunswick"
                attendanceTable = "tblBrunswickInfo"
            Case Else
                MessageBox.Show("Invalid venue selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
        End Select

        If String.IsNullOrEmpty(InfoDate) OrElse String.IsNullOrEmpty(InfoCoach) OrElse String.IsNullOrEmpty(InfoAssistant) OrElse String.IsNullOrEmpty(InfoFirstAid) OrElse String.IsNullOrEmpty(InfoAidKitAvailable) OrElse String.IsNullOrEmpty(InfoVenue) OrElse
   String.IsNullOrEmpty(StockBalls2Before) OrElse String.IsNullOrEmpty(StockBall3Before) OrElse String.IsNullOrEmpty(StockBall2After) OrElse String.IsNullOrEmpty(StockBall3After) OrElse String.IsNullOrEmpty(StockBagsBefore) OrElse String.IsNullOrEmpty(StockBagsAfter) OrElse
   String.IsNullOrEmpty(StockKitJBefore) OrElse String.IsNullOrEmpty(StockKitMBefore) OrElse String.IsNullOrEmpty(StockKitJAfter) OrElse String.IsNullOrEmpty(StockKitMAfter) OrElse String.IsNullOrEmpty(StockBookJBefore) OrElse String.IsNullOrEmpty(StockBookJAfter) OrElse
   String.IsNullOrEmpty(StockBookMBefore) OrElse String.IsNullOrEmpty(StockBookMAfter) OrElse String.IsNullOrEmpty(AfterMajor) OrElse String.IsNullOrEmpty(AfterMinor) OrElse String.IsNullOrEmpty(AfterEquipment) OrElse String.IsNullOrEmpty(AfterUniform) OrElse
   String.IsNullOrEmpty(AfterGood) OrElse String.IsNullOrEmpty(AfterReplace) Then
            MessageBox.Show("Please fill in all fields.", "Information")
            Return
        End If

        Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, "dbeKickers.accdb") ' Define the path to the database file by combining the application's startup path with the database file name '
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};" ' Create a connection string using the specified provider and the database path '
        Dim connection As New OleDbConnection(connectionString) ' Initialize a new instance of the OleDbConnection class with the constructed connection string '
        Try
            connection.Open()

            Dim query As String = $"INSERT INTO {attendanceTable} ([InfoDate], [Venue], [Coach], [ACoach], [FirstAidPerson], [AidKitAvailable], [Floor], [Equipment], [Fire], [Hazard], [Glazing], [Electrical], [Risk], [MajorIncident], [MinorIncident], [AidKitReplacementRequired], [EquipmentPackedAway],
[UniformRepair], [VenueCondition], [Before2Balls], [Befor3Balls], [BeforeJKits], [BeforeMKits], [BeforeJBook], [BeforeMBook], [BeforeBags], [After2Balls], [After3Balls], [AfterJKits], [AfterMKits], [AfterJBook], [AfterMBook], [AfterBags]) VALUES (@InfoDate, @Venue, @Coach, @ACoach, @FirstAidPerson, 
@AidKitAvailable, @Floor, @Equipment, @Fire, @Hazard, @Glazing, @Electrical, @Risk, @MajorIncident, @MinorIncident, @AidKitReplacementRequired, @EquipmentPackedAway, @UniformRepair, @VenueCondition, @Before2Balls, @Befor3Balls, @BeforeJKits, @BeforeMKits, @BeforeJBook, @BeforeMBook, @BeforeBags,
@After2Balls, @After3Balls, @AfterJKits, @AfterMKits, @AfterJBook, @AfterMBook, @AfterBags)"
            Dim command As New OleDbCommand(query, connection)
            Dim formattedBirthday As DateTime
            If DateTime.TryParse(InfoDate, formattedBirthday) Then
                command.Parameters.AddWithValue("@InfoDate", formattedBirthday)
            Else
                MessageBox.Show("Invalid date format", "Error")
                Return
            End If
            command.Parameters.AddWithValue("@Venue", InfoVenue)
            command.Parameters.AddWithValue("@Coach", InfoCoach)
            command.Parameters.AddWithValue("@ACoach", InfoAssistant)
            command.Parameters.AddWithValue("@FirstAidPerson", InfoFirstAid)
            command.Parameters.AddWithValue("@AidKitAvailable", InfoAidKitAvailable)

            command.Parameters.AddWithValue("@Floor", SafteyFloor)
            command.Parameters.AddWithValue("@Equipment", SafteyEquipment)
            command.Parameters.AddWithValue("@Fire", SafteyFire)
            command.Parameters.AddWithValue("@Hazard", SafteyHazard)
            command.Parameters.AddWithValue("@Glazing", SafteryGlazing)
            command.Parameters.AddWithValue("@Electrical", SafteryElectrical)
            command.Parameters.AddWithValue("@Risk", SafteryRisk)

            command.Parameters.AddWithValue("@MajorIncident", AfterMajor)
            command.Parameters.AddWithValue("@MinorIncident", AfterMinor)
            command.Parameters.AddWithValue("@AidKitReplacementRequired", AfterReplace)
            command.Parameters.AddWithValue("@EquipmentPackedAway", AfterEquipment)
            command.Parameters.AddWithValue("@UniformRepair", AfterUniform)
            command.Parameters.AddWithValue("@VenueCondition", AfterGood)

            command.Parameters.AddWithValue("@Before2Balls", StockBalls2Before)
            command.Parameters.AddWithValue("@Befor3Balls", StockBall3Before)
            command.Parameters.AddWithValue("@BeforeJKits", StockKitJBefore)
            command.Parameters.AddWithValue("@BeforeMKits", StockKitMBefore)
            command.Parameters.AddWithValue("@BeforeJBook", StockBookJBefore)
            command.Parameters.AddWithValue("@BeforeMBook", StockBookMBefore)
            command.Parameters.AddWithValue("@BeforeBags", StockBagsBefore)

            command.Parameters.AddWithValue("@After2Balls", StockBall2After)
            command.Parameters.AddWithValue("@After3Balls", StockBall3After)
            command.Parameters.AddWithValue("@AfterJKits", StockKitJAfter)
            command.Parameters.AddWithValue("@AfterMKits", StockKitMAfter)
            command.Parameters.AddWithValue("@AfterJBook", StockBookJAfter)
            command.Parameters.AddWithValue("@AfterMBook", StockBookMAfter)
            command.Parameters.AddWithValue("@AfterBags", StockBagsAfter)

            command.ExecuteNonQuery()

            MessageBox.Show("Info sheet submitted successfully!", "Information")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class
