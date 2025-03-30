Public Class Login_Form

    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim i, t As Integer
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"



        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\vehicle_automobile_management.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "Select * from Service_Reports"
        da = New OleDb.OleDbDataAdapter
        cmd = New OleDb.OleDbCommand
        dt = New DataTable

        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(200, 80)
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim correctAdmin As String = "admin"
        Dim correctPassword As String = "password"

        Dim enteredAdmin As String = txtAdmin.Text
        Dim enteredPassword As String = txtPassword.Text

        If enteredAdmin = correctAdmin AndAlso enteredPassword = correctPassword Then
            Dim dashboard As New Dashboard()
            dashboard.Show()
            Me.Hide()
        Else
            'Show the Error Messages(Labels)(agar user ne kuch bhi dal diya hai or usne pehle khali boxes bharke login karne ki try ki hogi 
            'to lblempty error show huya or show ho rha hai now user ne username and passowrd enter kiya or vo galat hai to lblempty error 
            'hide ho jayega or login error show hoga)
            If lblempty.Visible = True Or lblempty.Visible = False Then
                lblempty.Visible = False
                error_login_failed.Visible = True
                txtAdmin.Clear()
                txtPassword.Clear()
                txtAdmin.Focus()
            End If

            'Agar user ne pehle hi wrong password or username dala to login error wala label appear hoga agar vo phir khali boxes ke sath login 
            'karne ki koshish karega to login error label hide ho jayega or lblempty show hoga
            If String.IsNullOrWhiteSpace(enteredAdmin) OrElse String.IsNullOrWhiteSpace(enteredPassword) AndAlso error_login_failed.Visible = True Then
                error_login_failed.Visible = False
                lblempty.Visible = True
                txtAdmin.Clear()
                txtPassword.Clear()
                txtAdmin.Focus()
            End If
            Return
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub

End Class
