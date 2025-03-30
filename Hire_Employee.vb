Public Class Hire_Employee
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim i, t As Integer
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable

    Private Sub Hire_Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbPhoneNo.MaxLength = 10
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\vehicle_automobile_management.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "Select * from Hire_Employee"
        da = New OleDb.OleDbDataAdapter
        cmd = New OleDb.OleDbCommand
        dt = New DataTable
        btnRegisterEmployee.Enabled = True

        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(200, 80)
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        tbName.Clear()
        tbFatherName.Clear()
        tbMotherName.Clear()
        dtpDOB.Value = Date.Today
        tbAddress.Clear()
        tbEmail.Clear()
        tbPhoneNo.Clear()
        cbJobTitle.SelectedIndex = -1
        dtpHireDate.Value = Date.Today
        tbSalary.Clear()
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Dim dasboard As New Dashboard()
        dasboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegisterEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegisterEmployee.Click
        Dim sql As String = "insert into Hire_Employee values('" & tbName.Text & "','" & tbFatherName.Text & "','" & tbMotherName.Text & "','" & dtpDOB.Text & "','" & tbAddress.Text & "','" & tbEmail.Text & "','" & tbPhoneNo.Text & "','" & cbJobTitle.Text & "','" & dtpHireDate.Text & "','" & tbSalary.Text & "')"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd = New OleDb.OleDbCommand(sql, conn)
        t = cmd.ExecuteNonQuery()
        MsgBox("Record Saved")
    End Sub

    Private Sub tbPhoneNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPhoneNo.TextChanged
        If tbPhoneNo.Text <> "" AndAlso Not IsNumeric(tbPhoneNo.Text) Then
            MsgBox("Enter only digits")
            tbPhoneNo.Clear()
        End If
    End Sub

    Private Sub gbEmployeeDetails_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbEmployeeDetails.Enter

    End Sub
End Class