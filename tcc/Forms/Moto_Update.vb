Imports System.Data.SqlClient
Public Class Moto_Update
    Dim cod_moto As Integer
    Dim status As String
    Private Sub carregar_dgv()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select cod_moto as [Código], Nome, status_moto as [Status] from motorista where condicao = 1 and cod_moto <> 0"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                DgvUpdateMotorista.DataSource = dt
                With DgvUpdateMotorista
                    .Columns(0).ReadOnly = True
                    .Columns(1).ReadOnly = True
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub alt_status_moto()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "update motorista set status_moto = '" & status & "' where cod_moto = " & cod_moto & " and status_corrida = '0'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub Moto_Update_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        inicio.Enabled = True
        Exit Sub
    End Sub
    Private Sub MotoUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_dgv()
    End Sub
    Private Sub btnalterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalterar.Click
        If MessageBox.Show("Deseja realmente alterar os status dos motoristas?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            For colun As Integer = 0 To DgvUpdateMotorista.RowCount - 1
                status = DgvUpdateMotorista.Rows(colun).Cells(2).Value.ToString
                cod_moto = DgvUpdateMotorista.Rows(colun).Cells(0).Value
                alt_status_moto()
                cod_moto = Nothing
                status = Nothing
            Next
            MessageBox.Show("Alteações efetuadas com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        carregar_dgv()
    End Sub
    Private Sub btnfechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfechar.Click
        'If MessageBox.Show("Deseja realmente sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        inicio.Enabled = True
        Me.Close()
        'End If
    End Sub
End Class