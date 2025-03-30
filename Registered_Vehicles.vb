Public Class Registered_Vehicles
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim da As OleDb.OleDbDataAdapter
    Dim dtTable As New DataTable

    Private Sub Registered_Vehicles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\vehicle_automobile_management.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim query As String = "SELECT * from Registered_Vehicles"
        cmd = New OleDb.OleDbCommand(query, conn)
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dtTable)
        dgvRegisteredVehicles.DataSource = dtTable

        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(200, 80)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Dim dashboard As New Dashboard()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim dashboard As New Dashboard()
        dashboard.Show()
        Me.Hide()
    End Sub


End Class