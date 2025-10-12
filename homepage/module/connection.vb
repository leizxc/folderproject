Imports MySql.Data.MySqlClient
Module connnection
    Public Sub connectme()
        If conn.State = System.Data.ConnectionState.Open Then conn.Close()
        connstring = "server=localhost;userid=root;password=;database=database_panel;port=3306"
        conn.ConnectionString = connstring
        conn.Open()
    End Sub
End Module

