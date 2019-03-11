Class adderPage
    Dim access As New SQLHandler

    'variables for adding drivers
    Private driverFirstname As String
    Private driverSirName As String
    Private driverIDNumber As String
    Private driverNumberPlate As String
    Private driverSalary As Double

    'variables for adding conductors
    Private condFirstName As String
    Private condSirName As String
    Private condNumberPlate As String
    Private condIDNumber As String
    Private condSalary As Double

    'variables for adding Vehicles
    Private carDriverID As String
    Private carPlateNumber As String
    Private carMake As String
    Private carModel As String
    Private carCapacity As String
    Private carValue As Double


    Private Sub addDriverFirstNameTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addDriverFirstNameTextBox.TextChanged
        driverFirstname = addDriverFirstNameTextBox.Text.ToUpper


    End Sub

    Private Sub addDriverSirNameTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addDriverSirNameTextBox.TextChanged
        driverSirName = addDriverSirNameTextBox.Text.ToUpper
    End Sub

    Private Sub addDriverIDTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addDriverIDTextBox.TextChanged
        driverIDNumber = addDriverIDTextBox.Text
    End Sub

    Private Sub addDriverNumberPlateTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addDriverNumberPlateTextBox.TextChanged
        driverNumberPlate = addDriverNumberPlateTextBox.Text.ToUpper
    End Sub

    Private Sub addDriverSalaryTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addDriverSalaryTextBox.TextChanged

        driverSalary = Val(addDriverSalaryTextBox.Text)
    End Sub

    Private Sub addDriversSubmitButton_Click(sender As Object, e As RoutedEventArgs) Handles addDriversSubmitButton.Click
        Try
            access.nonQuery("INSERT INTO Drivers(ID,FirstName,sirName,numberPlate,Salary) " & "
                            VALUES('" & driverIDNumber & "','" & driverFirstname & "','" & driverSirName & "','" & driverNumberPlate & "','" & driverSalary & "')")
            access.closeConnection()
            MsgBox("Added driver successfully")
            addDriverFirstNameTextBox.Clear()
            addDriverIDTextBox.Clear()
            addDriverNumberPlateTextBox.Clear()
            addDriverSalaryTextBox.Clear()
            addDriverSirNameTextBox.Clear()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    'adding conductors to the database
    Private Sub addCondFirstNameTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addCondFirstNameTextBox.TextChanged
        condFirstName = addCondFirstNameTextBox.Text.ToUpper

    End Sub

    Private Sub addCondSirNameTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addCondSirNameTextBox.TextChanged
        condSirName = addCondSirNameTextBox.Text.ToUpper
    End Sub

    Private Sub addCondIDNumberTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addCondIDNumberTextBox.TextChanged
        condIDNumber = addCondIDNumberTextBox.Text

    End Sub

    Private Sub addCondNumberPlateTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addCondNumberPlateTextBox.TextChanged
        condNumberPlate = addCondNumberPlateTextBox.Text.ToUpper
    End Sub

    Private Sub addCondSalaryTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addCondSalaryTextBox.TextChanged
        condSalary = Val(addCondSalaryTextBox.Text)

    End Sub
    Private Sub addConductorsSubmitButton_Click(sender As Object, e As RoutedEventArgs) Handles addConductorsSubmitButton.Click
        Try
            access.nonQuery("INSERT INTO Conductors(ID,firstName,sirName,numberPlate,Salary) " &
                        "VALUES('" & condIDNumber & "','" & condFirstName & "','" & condSirName & "','" & condNumberPlate & "','" & condSalary & "')")
            access.closeConnection()
            MsgBox("Added Conductor Successfully!")
            addCondFirstNameTextBox.Clear()
            addCondIDNumberTextBox.Clear()
            addCondNumberPlateTextBox.Clear()
            addCondSalaryTextBox.Clear()
            addCondSirNameTextBox.Clear()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    ' adding vehicles to the database
    Private Sub addVehicleDriverIDTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addVehicleDriverIDTextBox.TextChanged
        carDriverID = addVehicleDriverIDTextBox.Text
    End Sub

    Private Sub addVehicleCapacityTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addVehicleCapacityTextBox.TextChanged
        carCapacity = Val(addVehicleCapacityTextBox.Text)
    End Sub

    Private Sub addVehicleMakeTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addVehicleMakeTextBox.TextChanged
        carMake = addVehicleMakeTextBox.Text.ToUpper
    End Sub

    Private Sub addVehicleModelTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addVehicleModelTextBox.TextChanged
        carModel = addVehicleModelTextBox.Text.ToUpper
    End Sub

    Private Sub addVehicleValueTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addVehicleValueTextBox.TextChanged
        carValue = Val(addVehicleValueTextBox.Text)
    End Sub

    Private Sub addVehicleNumberPlateTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addVehicleNumberPlateTextBox.TextChanged
        carPlateNumber = addVehicleNumberPlateTextBox.Text.ToUpper
    End Sub

    Private Sub addVehiclesSubmitButton_Click(sender As Object, e As RoutedEventArgs) Handles addVehiclesSubmitButton.Click
        Try
            access.nonQuery("INSERT INTO Vehicles(numberPlate,DriverID,Make,Model,Capacity,Valuation)" &
                            "VALUES('" & carPlateNumber & "','" & carDriverID & "','" & carMake & "','" & carModel & "','" & carCapacity & "','" & carValue & "')")
            access.closeConnection()
            MsgBox("Added vehicle successfully")
            addVehicleCapacityTextBox.Clear()
            addVehicleDriverIDTextBox.Clear()
            addVehicleMakeTextBox.Clear()
            addVehicleModelTextBox.Clear()
            addVehicleNumberPlateTextBox.Clear()
            addVehicleValueTextBox.Clear()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
