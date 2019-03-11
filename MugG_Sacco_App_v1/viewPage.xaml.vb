Imports System.Windows.Navigation

Class viewPage

    Private access As New SQLHandler


    Public Sub driverLoadGrid()
        driverDataGridView.DataContext = access.accessDS
        'access.accessAdapter.UpdateCommand = New System.Data.OleDb.OleDbCommandBuilder(access.accessAdapter).GetUpdateCommand
        driversSaveChangesButton.IsEnabled = False
    End Sub
    Public Sub conductorLoadGrid()
        conductorDataGridView.DataContext = access.accessDS
        'access.accessAdapter.UpdateCommand = New System.Data.OleDb.OleDbCommandBuilder(access.accessAdapter).GetUpdateCommand
        conductorsSaveChangesButton.IsEnabled = False
    End Sub
    Public Sub vehiclesLoadGrid()
        vehicleDataGridView.DataContext = access.accessDS
        'access.accessAdapter.UpdateCommand = New System.Data.OleDb.OleDbCommandBuilder(access.accessAdapter).GetUpdateCommand
        vehiclesSaveChangesButton.IsEnabled = False
    End Sub
    Private Sub driverDataGridView_IsVisibleChanged(sender As Object, e As DependencyPropertyChangedEventArgs) Handles driverDataGridView.IsVisibleChanged
        access.ExecuteQuery("SELECT * FROM Drivers")
        driverLoadGrid()

    End Sub

    Private Sub conductorDataGridView_IsVisibleChanged(sender As Object, e As DependencyPropertyChangedEventArgs) Handles conductorDataGridView.IsVisibleChanged
        access.ExecuteQuery("SELECT * FROM Conductors")
        conductorLoadGrid()

    End Sub

    Private Sub vehicleDataGridView_IsVisibleChanged(sender As Object, e As DependencyPropertyChangedEventArgs) Handles vehicleDataGridView.IsVisibleChanged
        access.ExecuteQuery("SELECT * FROM Vehicles")
        vehiclesLoadGrid()

    End Sub

    Private Sub driverDataGridView_CurrentCellChanged(sender As Object, e As EventArgs) Handles driverDataGridView.CurrentCellChanged
        driversSaveChangesButton.IsEnabled = True
    End Sub

    Private Sub conductorDataGridView_CurrentCellChanged(sender As Object, e As EventArgs) Handles conductorDataGridView.CurrentCellChanged
        conductorsSaveChangesButton.IsEnabled = True
    End Sub

    Private Sub vehicleDataGridView_CurrentCellChanged(sender As Object, e As EventArgs) Handles vehicleDataGridView.CurrentCellChanged
        vehiclesSaveChangesButton.IsEnabled = True
    End Sub

    Private Sub vehiclesSaveChangesButton_Click(sender As Object, e As RoutedEventArgs) Handles vehiclesSaveChangesButton.Click
        Try
            access.accessAdapter.Update(access.accessDS)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub conductorsSaveChangesButton_Click(sender As Object, e As RoutedEventArgs) Handles conductorsSaveChangesButton.Click
        Try
            access.accessAdapter.Update(access.accessDS)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub driversSaveChangesButton_Click(sender As Object, e As RoutedEventArgs) Handles driversSaveChangesButton.Click
        Try
            access.accessAdapter.Update(access.accessDS)
        Catch ex As Exception

        End Try


    End Sub
End Class
