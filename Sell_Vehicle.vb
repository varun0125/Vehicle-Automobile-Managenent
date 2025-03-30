Public Class Sell_Vehicle

    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim i, t As Integer
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable

    Private Sub dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpSaleDate.Value = Date.Today
        tbBuyerContact.MaxLength = 10
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = CS:\vehicle_automobile_management.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "Select * from Sold_Vehicles"
        da = New OleDb.OleDbDataAdapter
        cmd = New OleDb.OleDbCommand
        dt = New DataTable
        btnSellVehicle.Enabled = True

        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(200, 80)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim dashboard As New Dashboard()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cbSelectVehicle.SelectedIndex = -1
        tbBuyerName.Clear()
        tbBuyerContact.Clear()
        tbSalePrice.Clear()
    End Sub

    Private Sub btnSellVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSellVehicle.Click

        'Insert Data into Sold_Vehicles Table
        Dim sql As String = "insert into Sold_Vehicles values('" & cbSelectVehicle.Text & "','" & tbBuyerName.Text & "','" & tbBuyerContact.Text & "','" & dtpSaleDate.Text & "','" & tbSalePrice.Text & "')"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd = New OleDb.OleDbCommand(sql, conn)
        t = cmd.ExecuteNonQuery()
        MsgBox("Record Saved")

        

        cbSelectVehicle.SelectedIndex = -1
        tbBuyerName.Clear()
        tbBuyerContact.Clear()
        tbSalePrice.Clear()
        dtpSaleDate.Value = Date.Today
    End Sub

    Private Sub tbBuyerContact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBuyerContact.TextChanged
        If tbBuyerContact.Text <> "" AndAlso Not IsNumeric(tbBuyerContact.Text) Then
            MsgBox("Enter only digits")
            tbBuyerContact.Clear()
        End If
    End Sub

    Private Sub tbSalePrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSalePrice.TextChanged
        If tbSalePrice.Text <> "" AndAlso Not IsNumeric(tbSalePrice.Text) Then
            MsgBox("Enter only digits")
            tbSalePrice.Clear()
        End If
    End Sub
End Class