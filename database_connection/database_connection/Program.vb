Imports System.Data
Imports MySql.Data.MySqlClient

Module Program

    ' Static variables for database connection details
    Private _connection As MySqlConnection
    Private URL As String = "Server=localhost;Database=OOP_db;User ID=root;Password=;"

    'getConnection Method
    Public Function GetConnection() As MySqlConnection
        Try
            If _connection Is Nothing OrElse _connection.State = ConnectionState.Closed Then
                _connection = New MySqlConnection(URL)
                _connection.Open()
                Console.WriteLine("Connection established successfully.")
            Else
                Console.WriteLine("Using existing connection.")
            End If
        Catch ex As MySqlException
            Console.WriteLine("Error connecting to database: " & ex.Message)
        End Try
        'Return the _conenction to use in other methods
        Return _connection
    End Function

    ' Method to display records
    Public Sub DisplayRecords()
        Dim stmt As MySqlCommand = Nothing
        Dim rs As MySqlDataReader = Nothing

        Try
            ' Ensure connection is established
            Dim conn As MySqlConnection = GetConnection()

            ' Create a command and execute the query
            Dim query As String = "SELECT * FROM students_info" ' Replace with your actual table name
            stmt = New MySqlCommand(query, conn)
            rs = stmt.ExecuteReader()

            ' Print each record from the result set
            While rs.Read()
                Dim id As Integer = rs.GetInt32("id")
                Console.WriteLine("ID: " & id)
                Dim firstname As String = rs.GetString("firstname")
                Console.WriteLine("Firstname: " & firstname)
                Dim middlename As String = rs.GetString("middlename")
                Console.WriteLine("Middlename: " & middlename)
                Console.WriteLine("----------------------")
            End While
            'Handles exception for database operations
        Catch ex As Exception
            Console.WriteLine("An error occurred: " & ex.Message)
        Finally
            ' Clean up resources
            If rs IsNot Nothing Then rs.Close()
            If stmt IsNot Nothing Then stmt.Dispose()
            If _connection IsNot Nothing Then _connection.Close()
        End Try
    End Sub

    Sub Main()
        DisplayRecords()
    End Sub

End Module
