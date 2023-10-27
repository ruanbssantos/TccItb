Imports System.Data.SqlClient
Public Class SQLSERVER
    Dim conexaoSQLServer As String = "Server=.;UID=sa;PWD=123456;"
    Function BackupDatabase(ByVal connString As String, ByVal nomeDB As String, ByVal backupFile As String)
        'Dim conexaoSQLServer As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Master"
        Dim cn As New SqlConnection("Server=(local);uid=sa;pwd=123456;database=master")
        Try
            ' comando para fazer o backup do Banco de dados
            Dim cmdBackup As New SqlCommand("BACKUP DATABASE DBTaxi TO DISK = '" & backupFile & "'", cn)
            cn.Open()
            cmdBackup.ExecuteNonQuery()
        Finally
            cn.Close()
        End Try
        Return True
    End Function
    Function RestauraDatabase(ByVal connString As String, ByVal nomeDB As String, ByVal backupFile As String)
        Using cn As SqlConnection = conexao()
            SqlConnection.ClearAllPools()
        End Using
        Dim cn2 As New SqlConnection("Server=(local);uid=sa;pwd=123456;database=master")
        Try
            Dim cmdBackup As New SqlCommand("RESTORE DATABASE DBTaxi FROM DISK = '" & backupFile & "' WITH NOUNLOAD, REPLACE", cn2)
            cn2.Open()
            cmdBackup.ExecuteNonQuery()
        Finally
            cn2.Close()
        End Try
        Return True
    End Function
End Class



