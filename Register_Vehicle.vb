Public Class Register_Vehicle

    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim i, t As Integer
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable

    Private Sub Register_Vehicle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbOwnerContact.MaxLength = 10
        tbYear.MaxLength = 4
        tbRegistration.MaxLength = 8
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\vehicle_automobile_management.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "Select * from Registered_Vehicles"
        da = New OleDb.OleDbDataAdapter
        cmd = New OleDb.OleDbCommand
        dt = New DataTable
        btnRegisteredVehicle.Enabled = True
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(200, 80)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cbMake.SelectedIndex = -1
        tbYear.Clear()
        tbColor.Clear()
        tbRegistration.Clear()
        tbOwnerName.Clear()
        tbOwnerContact.Clear()
        dtpPurchaseDate.Value = Date.Today
        dtpInsurance.Value = Date.Today
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim dasboard As New Dashboard()
        dasboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegisteredVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegisteredVehicle.Click
        Dim sql As String = "INSERT INTO Registered_Vehicles (Owner_Name, Make, Year, Registration, Color, Owner_Contact, Purchase_Date, Insurance_Date) " & "VALUES ('" & tbOwnerName.Text & "','" & cbMake.Text & "','" & tbYear.Text & "','" & tbRegistration.Text & "','" & tbColor.Text & "','" & tbOwnerContact.Text & "','" & dtpPurchaseDate.Text & "','" & dtpInsurance.Text & "')"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd = New OleDb.OleDbCommand(sql, conn)
        t = cmd.ExecuteNonQuery()
        MsgBox("Record Saved")
    End Sub

    Private Sub tbYear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbYear.TextChanged
        If tbYear.Text <> "" AndAlso Not IsNumeric(tbYear.Text) Then
            MsgBox("Enter only digits")
            tbYear.Clear()
        End If
    End Sub

    Private Sub tbOwnerContact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbOwnerContact.TextChanged
        If tbOwnerContact.Text <> "" AndAlso Not IsNumeric(tbOwnerContact.Text) Then
            MsgBox("Enter only digits")
            tbOwnerContact.Clear()
        End If
    End Sub

    Private Sub cbMake_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMake.SelectedIndexChanged

    End Sub

    Private Sub tbRegistration_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbRegistration.TextChanged
        If tbRegistration.Text <> "" AndAlso Not IsNumeric(tbRegistration.Text) Then
            MsgBox("Enter only digits")
            tbRegistration.Clear()
        End If
    End Sub
End Class
