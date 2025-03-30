Public Class View_Employees

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim dashboard As New Dashboard
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Dim dashboard As New Dashboard
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub View_Employees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(200, 80)
    End Sub
End Class