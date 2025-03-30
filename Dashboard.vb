Public Class Dashboard

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Dim login_form As New Login_Form()
        login_form.Show()
        Me.Hide()
    End Sub

    Private Sub pbRegisterVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegisterVehicle.Click
        Dim register_vehicle As New Register_Vehicle()
        register_vehicle.Show()
        Me.Hide()
    End Sub

    Private Sub lblRegisterVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRegisterVehicle.Click
        Dim register_vehicle As New Register_Vehicle()
        register_vehicle.Show()
        Me.Hide()
    End Sub

    Private Sub pbSellVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbSellVehicle.Click
        Dim sell_vehicle As New Sell_Vehicle()
        sell_vehicle.Show()
        Me.Hide()
    End Sub

    Private Sub lblSellVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSellVehicle.Click
        Dim sell_vehicle As New Sell_Vehicle()
        sell_vehicle.Show()
        Me.Hide()
    End Sub

    Private Sub pbHireEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbHireEmployee.Click
        Dim hire_employee As New Hire_Employee()
        hire_employee.Show()
        Me.Hide()
    End Sub

    Private Sub lblHireEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHireEmployee.Click
        Dim hire_employee As New Hire_Employee()
        hire_employee.Show()
        Me.Hide()
    End Sub

    Private Sub pbVehicleService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbVehicleService.Click
        Dim vehicle_service As New Service_Vehicle()
        vehicle_service.Show()
        Me.Hide()
    End Sub

    Private Sub lblVehicleService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVehicleService.Click
        Dim vehicle_service As New Service_Vehicle()
        vehicle_service.Show()
        Me.Hide()
    End Sub

    Private Sub pbRegisteredVehicles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegisteredVehicles.Click
        Dim registered_vehicles As New Registered_Vehicles()
        registered_vehicles.Show()
        Me.Hide()
    End Sub

    Private Sub lblRegisteredVehicles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRegisteredVehicles.Click
        Dim registered_vehicles As New Registered_Vehicles()
        registered_vehicles.Show()
        Me.Hide()
    End Sub

    Private Sub pbSoldVehicles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbSoldVehicles.Click
        Dim sold_vehicles As New Sold_Vehicles()
        sold_vehicles.Show()
        Me.Hide()
    End Sub

    Private Sub lblSoldVehicles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSoldVehicles.Click
        Dim sold_vehicles As New Sold_Vehicles()
        sold_vehicles.Show()
        Me.Hide()
    End Sub

    Private Sub pbViewEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbViewEmployees.Click
        Dim view_employees As New View_Employees()
        view_employees.Show()
        Me.Hide()
    End Sub

    Private Sub lblViewEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblViewEmployees.Click
        Dim view_employees As New View_Employees()
        view_employees.Show()
        Me.Hide()
    End Sub

    Private Sub pbServiceReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbServiceReports.Click
        Dim service_reports As New Service_Reports()
        service_reports.Show()
        Me.Hide()
    End Sub

    Private Sub lblServiceReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblServiceReports.Click
        Dim service_reports As New Service_Reports()
        service_reports.Show()
        Me.Hide()
    End Sub

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub
End Class