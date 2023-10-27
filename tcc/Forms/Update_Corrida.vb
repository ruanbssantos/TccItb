Imports System.Data.SqlClient
Public Class update_corrida
    Dim codmoto As Integer
    Private Sub carregar_nome_moto()
        Using cn As SqlConnection = conexao()
            If codigos.blindagem1 = True Then
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.Cod_moto, motorista.nome , veiculo.blindagem from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where motorista.Status_Moto = 1 and motorista.Cod_moto <> 0 and motorista.Condicao = 1 and veiculo.blindagem = '" & True & "'"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim mr As SqlDataReader
                    mr = cmd.ExecuteReader
                    While mr.Read
                        CbMoto.Items.Add(CStr(mr.Item("cod_moto")) + " - " + (mr.Item("nome")))
                    End While
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf codigos.blindagem1 = False Then
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.Cod_moto, motorista.nome , veiculo.blindagem from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where motorista.Status_Moto = 1 and motorista.Cod_moto <> 0 and motorista.Condicao = 1 and veiculo.blindagem = '" & False & "'"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim mr As SqlDataReader
                    mr = cmd.ExecuteReader
                    While mr.Read
                        CbMoto.Items.Add(CStr(mr.Item("cod_moto")) + " - " + (mr.Item("nome")))
                    End While
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            End If
        End Using
    End Sub
    Private Sub update_corrida_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        codigos.codagend = Nothing
        inicio.Enabled = True
        Exit Sub
    End Sub
    Private Sub update_corrida_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        carregar_nome_moto()
    End Sub
    Private Sub CbMoto_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CbMoto.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnConfirma.PerformClick()
        End If
    End Sub
    Private Sub CbMoto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbMoto.SelectedIndexChanged
        codmoto = CbMoto.Text.Substring(0, CbMoto.Text.IndexOf(" "))
    End Sub
    Private Sub btnfechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfechar.Click
        'If MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        codigos.codagend = Nothing
        inicio.Enabled = True
        Me.Close()
        'End If
    End Sub
    Private Sub BtnConfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfirma.Click
        If confirmar_moto() = True Then
            MessageBox.Show("Corrida em andamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            codigos.codagend = Nothing
            codigos.contador = 60
        Else
            Exit Sub
        End If
    End Sub
    Private Function confirmar_moto()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "update agendamento set Status_Agend = 'Em andamento', Cod_moto = '" & codmoto & "' where Cod_agendamento = '" & codigos.codagend & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Finally
                cn.Close()
            End Try
            '==============================
            Try
                cn.Open()
                Dim sql As String = "update corrida set Status_corrida = 'Em andamento', Cod_moto = '" & codmoto & "' where Cod_agendamento = '" & codigos.codagend & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Finally
                cn.Close()
            End Try
            '==============================
            Try
                cn.Open()
                Dim sql As String = "update motorista set Status_Moto = '0', status_corrida = '1' where Cod_moto = '" & codmoto & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Finally
                cn.Close()
                inicio.Enabled = True
                Me.Close()
            End Try
            Return True
        End Using
    End Function
End Class