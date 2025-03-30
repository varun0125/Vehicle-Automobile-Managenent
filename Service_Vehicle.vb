Public Class Service_Vehicle
    ' Database Connection Variables
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand

    ' Form Load Event
    Private Sub Service_Vehicle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\vehicle_automobile_management.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        ' Optional: Load Data from the Database if Needed
        Dim query As String = "SELECT * FROM Vehicle_Service"
        cmd = New OleDb.OleDbCommand(query, conn)

        ' Set Form Position
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(200, 80)
    End Sub

    ' Home Button Click
    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Dim dashboard As New Dashboard()
        dashboard.Show()
        Me.Hide()
    End Sub

    ' Clear Button Click
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        tbOwnerName.Clear()
        cbSelectVehicle.SelectedIndex = -1
        dtpServiceDate.Value = Date.Today
        cbServiceType.SelectedIndex = -1
        tbPartsUsed.Clear()
        tbDescription.Clear()
    End Sub

  
    Private Sub btnServiceVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServiceVehicle.Click

    End Sub
End Class
