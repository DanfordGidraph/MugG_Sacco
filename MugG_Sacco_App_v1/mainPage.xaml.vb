Imports System.Speech.Synthesis

Class mainPage
    Private Sub searchImage_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles searchImage.MouseLeftButtonDown

        Dim searcher As New searchPage
        Me.NavigationService.Navigate(searcher)

    End Sub

    Private Sub searchButton_Click(sender As Object, e As RoutedEventArgs) Handles searchButton.Click
        Dim searcher As New searchPage
        Me.NavigationService.Navigate(searcher)
    End Sub

    Private Sub viewButton_Click(sender As Object, e As RoutedEventArgs) Handles viewButton.Click
        Try
            Dim viewer As New viewPage
            Me.NavigationService.Navigate(viewer)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub viewImage_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles viewImage.MouseLeftButtonDown
        Try
            Dim viewer As New viewPage
            Me.NavigationService.Navigate(viewer)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub addButton1_Click(sender As Object, e As RoutedEventArgs) Handles addButton1.Click
        Dim adder As New adderPage
        Me.NavigationService.Navigate(adder)
    End Sub

    Private Sub image5_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles image5.MouseLeftButtonDown
        Dim adder As New adderPage
        Me.NavigationService.Navigate(adder)
    End Sub

    Private Sub addStackMain1_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles addStackMain1.MouseLeftButtonDown
        Dim adder As New adderPage
        Me.NavigationService.Navigate(adder)
    End Sub

    Private Sub kukenaTextBlock1_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles kukenaTextBlock1.MouseLeftButtonDown
        Dim speak As New SpeechSynthesizer
        speak.Speak("This Is Mug G SACCO 2019")
    End Sub

End Class
