Imports System.Windows.Media.Animation
Imports System.Data
Imports System.Speech.Synthesis
Imports System.Windows.Navigation
Imports System.Windows.Media
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System

Public Class SQLHandler
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sacco_Database.mdb;"
    Private connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(connectionString)
    Private command As OleDb.OleDbCommand

    Public accessAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("SELECT * FROM Drivers", connection)
    Public accessDS As DataSet

    ' Query Parameters for the commands

    Public params As New List(Of OleDb.OleDbParameter)

    'Query Stats counter 

    Public record_count As Integer
    Public exception As String

    Public Sub nonQuery(query As String)
        connection.Open()
        Dim command As New OleDb.OleDbCommand(query, connection)
        command.ExecuteNonQuery()

        connection.Close()
    End Sub

    Public Sub closeConnection()
        connection.Close()
    End Sub
    Public Sub ExecuteQuery(query As String)

        Try
            connection.Open()
            command = New OleDb.OleDbCommand(query, connection)

            'run through the parameters
            params.ForEach(Sub(x) command.Parameters.Add(x))

            'clear the parameter list
            params.Clear()

            'Execute and fill data set
            accessDS = New DataSet
            accessAdapter = New OleDb.OleDbDataAdapter(command)
            record_count = accessAdapter.Fill(accessDS)


            connection.Close()
        Catch ex As Exception
            exception = ex.Message

        End Try

        If connection.State = ConnectionState.Open Then
            connection.Close()

        End If
    End Sub




End Class
