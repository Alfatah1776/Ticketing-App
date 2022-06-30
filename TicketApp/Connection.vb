Imports MySql.Data.MySqlClient
Module Connection
    Public conn As New MySqlConnection
    Public query As String
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public cmd As MySqlCommand

    Public data As String


    Sub Connect()
        Try
            conn.Close()
            conn.ConnectionString = "server=localhost; user id=root; password=; database=lufthansa_db;"
            conn.Open()
            'MsgBox("Connection Success")
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
    End Sub

    Sub connectionReport()
        data = "server=localhost; user id=root; password=; database=lufthansa_db;"
        conn = New MySqlConnection(Data)
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = Data
            conn.Open()
        Else
            MsgBox("Connection Failed")
        End If
    End Sub
End Module
