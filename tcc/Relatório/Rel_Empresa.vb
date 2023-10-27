Imports System.Data.SqlClient
Public Class Rel_Empresa
    Dim ano1 As Integer
    Private Sub btnexibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexibir.Click
        relatorio_emp()
    End Sub
    Private Sub relatorio_emp()
        If TxtAno.Text = "" Then
            ano1 = System.DateTime.Now.Year
        Else
            ano1 = TxtAno.Text
        End If
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select datepart(YEAR,agendamento.Data_agend) as Ano,datepart(month,agendamento.Data_agend) as Mês, sum(corrida.Preco_total) as Lucro from agendamento inner join corrida on agendamento.Cod_agendamento = corrida.Cod_agendamento where agendamento.Status_Agend = 'Finalizada' and datepart(year,agendamento.Data_agend) = '" & ano1 & "'  group by datepart(MONTH,agendamento.Data_agend), datepart(year,agendamento.Data_agend)"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                DgvConsulta.DataSource = dt
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub btnfechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfechar.Click
        inicio.Enabled = True
        Me.Close()
    End Sub
    Private Sub Rel_Empresa_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        inicio.Enabled = True
        Exit Sub
    End Sub
    Private Sub RelLucroEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        relatorio_emp()
        TxtAno.Text = System.DateTime.Now.Year
    End Sub
    Private Sub TxtAno_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtAno.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnexibir.PerformClick()
        End If
    End Sub
    Private Sub TxtAno_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAno.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub
End Class