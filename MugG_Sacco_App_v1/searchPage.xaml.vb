Imports System.Windows.Media.Animation
Imports System.Data
Imports System.Speech.Synthesis
Imports System.Windows.Navigation
Imports System.Windows.Media
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System
Class searchPage
    Dim access As New SQLHandler()

    Private Sub driverByDriverID1_Click(sender As Object, e As RoutedEventArgs) Handles driverByDriverIDButton.Click
        Try
            Dim gridAnimate As New DoubleAnimation
            gridAnimate.From = 0
            gridAnimate.To = driverByIDGrid.Height + 372

            gridAnimate.Duration = TimeSpan.FromSeconds(2)
            Me.driverByIDGrid.BeginAnimation(Grid.HeightProperty, gridAnimate)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub driverByCarPlateNumber1_Click(sender As Object, e As RoutedEventArgs) Handles driverByCarPlateNumberButton.Click
        Try
            Dim gridAnimate As New DoubleAnimation
            gridAnimate.From = driverByIDGrid.ActualHeight
            gridAnimate.To = driverByIDGrid.Height - driverByIDGrid.Height
            gridAnimate.Duration = TimeSpan.FromSeconds(2)
            Me.driverByIDGrid.BeginAnimation(Grid.HeightProperty, gridAnimate)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub



    Private Sub conductorByNationalIDButton_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles conductorByNationalIDButton.MouseLeftButtonDown
        Try
            Dim gridAnimate As New DoubleAnimation
            gridAnimate.From = 0
            gridAnimate.To = conductorByIDGrid.Height + 372

            gridAnimate.Duration = TimeSpan.FromSeconds(2)
            Me.conductorByIDGrid.BeginAnimation(Grid.HeightProperty, gridAnimate)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Try
            Dim gridAnimate As New DoubleAnimation
            gridAnimate.From = conductorByIDGrid.ActualHeight
            gridAnimate.To = conductorByIDGrid.Height - conductorByIDGrid.Height
            gridAnimate.Duration = TimeSpan.FromSeconds(2)
            Me.conductorByIDGrid.BeginAnimation(Grid.HeightProperty, gridAnimate)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Try
            Dim gridAnimate As New DoubleAnimation
            gridAnimate.From = 0
            gridAnimate.To = carByDriverIDGrid.Height + 372

            gridAnimate.Duration = TimeSpan.FromSeconds(2)
            Me.carByDriverIDGrid.BeginAnimation(Grid.HeightProperty, gridAnimate)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Try
            Dim gridAnimate As New DoubleAnimation
            gridAnimate.From = carByDriverIDGrid.ActualHeight
            gridAnimate.To = carByDriverIDGrid.Height - carByDriverIDGrid.Height
            gridAnimate.Duration = TimeSpan.FromSeconds(2)
            Me.carByDriverIDGrid.BeginAnimation(Grid.HeightProperty, gridAnimate)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Sub loadresultsGrid()

        searchResultDataGrid.DataContext = access.accessDS
        access.accessAdapter.UpdateCommand = New System.Data.OleDb.OleDbCommandBuilder(access.accessAdapter).GetUpdateCommand

    End Sub


    Public Sub findDriverByID_Click(sender As Object, e As RoutedEventArgs) Handles findDriverByID.Click
        Try
            Dim dockanimate As New DoubleAnimation
            dockanimate.From = searchPageDock.ActualWidth
            dockanimate.To = searchPageDock.Width - searchPageDock.Width
            dockanimate.Duration = TimeSpan.FromSeconds(1)
            Me.searchPageDock.BeginAnimation(DockPanel.WidthProperty, dockanimate)

            access.ExecuteQuery("SELECT * FROM Drivers WHERE ID='" & driverByIDSearchTextBox.Text & "'")
            loadresultsGrid()
            driverByIDSearchTextBox.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub backButton_Click(sender As Object, e As RoutedEventArgs) Handles backButton.Click

        Dim dockanimate As New DoubleAnimation
        dockanimate.From = searchPageDock.ActualWidth
        dockanimate.To = searchPageDock.Width + 740
        dockanimate.Duration = TimeSpan.FromSeconds(1)
        Me.searchPageDock.BeginAnimation(DockPanel.WidthProperty, dockanimate)

    End Sub

    Private Sub findDriverByPlateNumber_Click(sender As Object, e As RoutedEventArgs) Handles findDriverByPlateNumber.Click
        Try
            Dim dockanimate As New DoubleAnimation
            dockanimate.From = searchPageDock.ActualWidth
            dockanimate.To = searchPageDock.Width - searchPageDock.Width
            dockanimate.Duration = TimeSpan.FromSeconds(1)
            Me.searchPageDock.BeginAnimation(DockPanel.WidthProperty, dockanimate)

            access.ExecuteQuery("SELECT * FROM Drivers WHERE numberPlate='" & driverByPlateNumberSearchTextBox.Text & "'")
            loadresultsGrid()
            driverByPlateNumberSearchTextBox.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub findConductorByID_Click(sender As Object, e As RoutedEventArgs) Handles findConductorByID.Click
        Try
            Dim dockanimate As New DoubleAnimation
            dockanimate.From = searchPageDock.ActualWidth
            dockanimate.To = searchPageDock.Width - searchPageDock.Width
            dockanimate.Duration = TimeSpan.FromSeconds(1)
            Me.searchPageDock.BeginAnimation(DockPanel.WidthProperty, dockanimate)

            access.ExecuteQuery("SELECT * FROM Conductors WHERE ID='" & conductorIDsearchTextBox.Text & "'")
            loadresultsGrid()
            conductorIDsearchTextBox.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub findConductorByPlate_Click(sender As Object, e As RoutedEventArgs) Handles findConductorByPlate.Click
        Try
            Dim dockanimate As New DoubleAnimation
            dockanimate.From = searchPageDock.ActualWidth
            dockanimate.To = searchPageDock.Width - searchPageDock.Width
            dockanimate.Duration = TimeSpan.FromSeconds(1)
            Me.searchPageDock.BeginAnimation(DockPanel.WidthProperty, dockanimate)

            access.ExecuteQuery("SELECT * FROM Conductors WHERE numberPlate='" & conductorPlateSearchTextBox.Text & "'")
            loadresultsGrid()
            conductorPlateSearchTextBox.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub findCarByDriverID_Click(sender As Object, e As RoutedEventArgs) Handles findCarByDriverID.Click
        Try
            Dim dockanimate As New DoubleAnimation
            dockanimate.From = searchPageDock.ActualWidth
            dockanimate.To = searchPageDock.Width - searchPageDock.Width
            dockanimate.Duration = TimeSpan.FromSeconds(1)
            Me.searchPageDock.BeginAnimation(DockPanel.WidthProperty, dockanimate)

            access.ExecuteQuery("SELECT * FROM Vehicles WHERE DriverID='" & searchVehicleByDriverIDTextBox.Text & "'")
            loadresultsGrid()
            searchVehicleByDriverIDTextBox.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub findCarByPlateNumber_Click(sender As Object, e As RoutedEventArgs) Handles findCarByPlateNumber.Click
        Try
            Dim dockanimate As New DoubleAnimation
            dockanimate.From = searchPageDock.ActualWidth
            dockanimate.To = searchPageDock.Width - searchPageDock.Width
            dockanimate.Duration = TimeSpan.FromSeconds(1)
            Me.searchPageDock.BeginAnimation(DockPanel.WidthProperty, dockanimate)

            access.ExecuteQuery("SELECT * FROM Vehicles WHERE numberPlate='" & searchVehicleBYNumberPlateTextBox.Text & "'")
            loadresultsGrid()
            searchVehicleBYNumberPlateTextBox.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
