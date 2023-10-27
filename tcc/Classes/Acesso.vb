Imports System.Data.SqlClient
Module Acesso
    Public Function conexao() As SqlConnection
        Dim sql As String = "server=.;uid=sa;pwd=123456;database=DBTaxi"
        Return New SqlConnection(sql)
    End Function
    Public Function conexaocep() As SqlConnection
        Dim sql As String = "server=.;uid=sa;pwd=123456;database=Logradouro"
        Return New SqlConnection(sql)
    End Function
End Module
