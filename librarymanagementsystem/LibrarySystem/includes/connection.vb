Imports MySql.Data.MySqlClient
Module connection
    Public Function mysqldb() As MySqlConnection
        'Return New MySqlConnection("server=192.168.8.103;user id=Assistant2;Password=assist2;database=dblibrary")
        Return New MySqlConnection("server=localhost;user id=root;Password=;database=dblibrary")
    End Function
    Public con As MySqlConnection = mysqldb()
End Module
