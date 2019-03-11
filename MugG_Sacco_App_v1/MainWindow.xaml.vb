Imports System.Windows.Media.Animation
Imports System.Data
Imports System.Speech.Synthesis
Imports System.Windows.Navigation
Imports System.Windows.Media
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System
Imports Xceed.Wpf.Toolkit

Class MainWindow

    'maintains the connection to my database
    Dim connection As OleDb.OleDbConnection
    Private Sub InfoSACCO_Loaded(sender As Object, e As RoutedEventArgs) Handles InfoSACCO.Loaded
        ' Navigates the window view area into a new set up startup page
        Dim login As New Login_Page
        Me.mainFrame.NavigationService.Navigate(login)
    End Sub

    Private Sub mainFrame_Navigated(sender As Object, e As NavigationEventArgs) Handles mainFrame.Navigated

    End Sub
End Class
