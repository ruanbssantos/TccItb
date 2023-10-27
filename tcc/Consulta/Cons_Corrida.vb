Imports System.Data.SqlClient
Public Class Cons_Corrida
    Dim codcli As Integer
    Dim filtro As String
    Private Sub Cons_Corrida_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        inicio.Enabled = True
        Exit Sub
    End Sub
    Private Sub conscorrida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbfiltro.SelectedItem = "Todos"
        cons_corrida()
    End Sub
    Private Sub cons_corrida()
        Using cn As SqlConnection = conexao()
            DgvConsCorri.DataSource = ""
            If (filtro = "Código da Corrida") Then
                Try
                    cn.Open()
                    Dim sql As String = "select	corrida.cod_corrida AS [Código da corrida], agendamento.data_agend as [Data do Agendamento], agendamento.horario as [Horário], agendamento.Observacoes as [Observações], Tipo_corrida.nome_Corrida as [Tipo da corrida], corrida.kmTotal as [KM total], corrida.preco_total as [Valor total], motorista.Cod_moto as [Código do Motorista], motorista.Nome as [Nome do Motorisa], motorista.Condicao as [Condição do Motorista], Cliente.Nome as [Nome do Cliente], agendamento.cod_func as [Código do Funcionário], rota.Endereco_origem as [Endereço de Origem], rota.CEP, rota.Cidade, rota.Bairro, rota.UF, rota.Numero as Número, rota.Complemento, rota.Endereco_destino as [Endereço de Destino], corrida.Status_corrida As [Status da corrida] from Tipo_corrida inner join corrida on Tipo_corrida.cod_TipoCorrida = corrida.cod_TipoCorrida inner join motorista  on motorista.cod_moto = corrida.cod_moto  inner join agendamento  on agendamento.cod_agendamento = corrida.cod_agendamento inner join rota on rota.cod_agendamento = agendamento.cod_agendamento inner join Cliente on agendamento.Cod_cli = Cliente.Cod_cli where corrida.cod_corrida = '" & txtfiltro.Text & "'"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsCorri.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "Código do Motorista") Then
                Try
                    cn.Open()
                    Dim sql As String = "select	corrida.cod_corrida AS [Código da corrida], agendamento.data_agend as [Data do Agendamento], agendamento.horario as [Horário], agendamento.Observacoes as [Observações], Tipo_corrida.nome_Corrida as [Tipo da corrida], corrida.kmTotal as [KM total], corrida.preco_total as [Valor total], motorista.Cod_moto as [Código do Motorista], motorista.Nome as [Nome do Motorisa], motorista.Condicao as [Condição do Motorista], Cliente.Nome as [Nome do Cliente], agendamento.cod_func as [Código do Funcionário], rota.Endereco_origem as [Endereço de Origem], rota.CEP, rota.Cidade, rota.Bairro, rota.UF, rota.Numero as Número, rota.Complemento, rota.Endereco_destino as [Endereço de Destino], corrida.Status_corrida As [Status da corrida] from Tipo_corrida inner join corrida on Tipo_corrida.cod_TipoCorrida = corrida.cod_TipoCorrida inner join motorista  on motorista.cod_moto = corrida.cod_moto  inner join agendamento  on agendamento.cod_agendamento = corrida.cod_agendamento inner join rota on rota.cod_agendamento = agendamento.cod_agendamento inner join Cliente on agendamento.Cod_cli = Cliente.Cod_cli where motorista.cod_moto = '" & txtfiltro.Text & "' "
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsCorri.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "CPF do Cliente") Then
                Try
                    cn.Open()
                    Dim sql As String = "select cod_cli from cli_fisico where cpf = '" & txtfiltro.Text & "'"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim mr As SqlDataReader
                    mr = cmd.ExecuteReader
                    While mr.Read
                        codcli = mr!cod_cli
                    End While
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
                '---------------------------------
                Try
                    cn.Open()
                    Dim sql As String = "select	corrida.cod_corrida AS [Código da corrida], agendamento.data_agend as [Data do Agendamento], agendamento.horario as [Horário], agendamento.Observacoes as [Observações], Tipo_corrida.nome_Corrida as [Tipo da corrida], corrida.kmTotal as [KM total], corrida.preco_total as [Valor total], motorista.Cod_moto as [Código do Motorista], motorista.Nome as [Nome do Motorisa], motorista.Condicao as [Condição do Motorista], Cliente.Nome as [Nome do Cliente], agendamento.cod_func as [Código do Funcionário], rota.Endereco_origem as [Endereço de Origem], rota.CEP, rota.Cidade, rota.Bairro, rota.UF, rota.Numero as Número, rota.Complemento, rota.Endereco_destino as [Endereço de Destino], corrida.Status_corrida As [Status da corrida] from Tipo_corrida inner join corrida on Tipo_corrida.cod_TipoCorrida = corrida.cod_TipoCorrida inner join motorista  on motorista.cod_moto = corrida.cod_moto  inner join agendamento  on agendamento.cod_agendamento = corrida.cod_agendamento inner join rota on rota.cod_agendamento = agendamento.cod_agendamento inner join Cliente on agendamento.Cod_cli = Cliente.Cod_cli where agendamento.cod_cli = '" & codcli & "'"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsCorri.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "CNPJ do Cliente") Then
                Try
                    cn.Open()
                    Dim sql As String = "select cod_cli from cli_juridico where cnpj = '" & txtfiltro.Text & "'"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim mr As SqlDataReader
                    mr = cmd.ExecuteReader
                    While mr.Read
                        codcli = mr!cod_cli
                    End While
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
                '---------------------------------
                Try
                    cn.Open()
                    Dim sql As String = "select	corrida.cod_corrida AS [Código da corrida], agendamento.data_agend as [Data do Agendamento], agendamento.horario as [Horário], agendamento.Observacoes as [Observações], Tipo_corrida.nome_Corrida as [Tipo da corrida], corrida.kmTotal as [KM total], corrida.preco_total as [Valor total], motorista.Cod_moto as [Código do Motorista], motorista.Nome as [Nome do Motorisa], motorista.Condicao as [Condição do Motorista], Cliente.Nome as [Nome do Cliente], agendamento.cod_func as [Código do Funcionário], rota.Endereco_origem as [Endereço de Origem], rota.CEP, rota.Cidade, rota.Bairro, rota.UF, rota.Numero as Número, rota.Complemento, rota.Endereco_destino as [Endereço de Destino], corrida.Status_corrida As [Status da corrida] from Tipo_corrida inner join corrida on Tipo_corrida.cod_TipoCorrida = corrida.cod_TipoCorrida inner join motorista  on motorista.cod_moto = corrida.cod_moto  inner join agendamento  on agendamento.cod_agendamento = corrida.cod_agendamento inner join rota on rota.cod_agendamento = agendamento.cod_agendamento inner join Cliente on agendamento.Cod_cli = Cliente.Cod_cli where agendamento.cod_cli = '" & codcli & "'"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsCorri.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "Data da Corrida") Then
                Try
                    cn.Open()
                    Dim sql As String = "select	corrida.cod_corrida AS [Código da corrida], agendamento.data_agend as [Data do Agendamento], agendamento.horario as [Horário], agendamento.Observacoes as [Observações], Tipo_corrida.nome_Corrida as [Tipo da corrida], corrida.kmTotal as [KM total], corrida.preco_total as [Valor total], motorista.Cod_moto as [Código do Motorista], motorista.Nome as [Nome do Motorisa], motorista.Condicao as [Condição do Motorista], Cliente.Nome as [Nome do Cliente], agendamento.cod_func as [Código do Funcionário], rota.Endereco_origem as [Endereço de Origem], rota.CEP, rota.Cidade, rota.Bairro, rota.UF, rota.Numero as Número, rota.Complemento, rota.Endereco_destino as [Endereço de Destino], corrida.Status_corrida As [Status da corrida] from Tipo_corrida inner join corrida on Tipo_corrida.cod_TipoCorrida = corrida.cod_TipoCorrida inner join motorista  on motorista.cod_moto = corrida.cod_moto  inner join agendamento  on agendamento.cod_agendamento = corrida.cod_agendamento inner join rota on rota.cod_agendamento = agendamento.cod_agendamento inner join Cliente on agendamento.Cod_cli = Cliente.Cod_cli where agendamento.data_agend like '%" & txtfiltro.Text & "%'"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsCorri.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "Status") Then
                Try
                    cn.Open()
                    Dim sql As String = "select	corrida.cod_corrida AS [Código da corrida], agendamento.data_agend as [Data do Agendamento], agendamento.horario as [Horário], agendamento.Observacoes as [Observações], Tipo_corrida.nome_Corrida as [Tipo da corrida], corrida.kmTotal as [KM total], corrida.preco_total as [Valor total], motorista.Cod_moto as [Código do Motorista], motorista.Nome as [Nome do Motorisa], motorista.Condicao as [Condição do Motorista], Cliente.Nome as [Nome do Cliente], agendamento.cod_func as [Código do Funcionário], rota.Endereco_origem as [Endereço de Origem], rota.CEP, rota.Cidade, rota.Bairro, rota.UF, rota.Numero as Número, rota.Complemento, rota.Endereco_destino as [Endereço de Destino], corrida.Status_corrida As [Status da corrida] from Tipo_corrida inner join corrida on Tipo_corrida.cod_TipoCorrida = corrida.cod_TipoCorrida inner join motorista  on motorista.cod_moto = corrida.cod_moto  inner join agendamento  on agendamento.cod_agendamento = corrida.cod_agendamento inner join rota on rota.cod_agendamento = agendamento.cod_agendamento inner join Cliente on agendamento.Cod_cli = Cliente.Cod_cli where agendamento.status_agend = '" & txtfiltro.Text & "'"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsCorri.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            Else
                Try
                    cn.Open()
                    Dim sql As String = "select	corrida.cod_corrida AS [Código da corrida], agendamento.data_agend as [Data do Agendamento], agendamento.horario as [Horário], agendamento.Observacoes as [Observações], Tipo_corrida.nome_Corrida as [Tipo da corrida], corrida.kmTotal as [KM total], corrida.preco_total as [Valor total], motorista.Cod_moto as [Código do Motorista], motorista.Nome as [Nome do Motorisa], motorista.Condicao as [Condição do Motorista], Cliente.Nome as [Nome do Cliente], agendamento.cod_func as [Código do Funcionário], rota.Endereco_origem as [Endereço de Origem], rota.CEP, rota.Cidade, rota.Bairro, rota.UF, rota.Numero as Número, rota.Complemento, rota.Endereco_destino as [Endereço de Destino], corrida.Status_corrida As [Status da corrida] from Tipo_corrida inner join corrida on Tipo_corrida.cod_TipoCorrida = corrida.cod_TipoCorrida inner join motorista  on motorista.cod_moto = corrida.cod_moto  inner join agendamento  on agendamento.cod_agendamento = corrida.cod_agendamento inner join rota on rota.cod_agendamento = agendamento.cod_agendamento inner join Cliente on agendamento.Cod_cli = Cliente.Cod_cli"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsCorri.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            End If
        End Using
    End Sub
    Private Sub cbfiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbfiltro.SelectedIndexChanged
        txtfiltro.Clear()
        filtro = cbfiltro.SelectedItem
        If (filtro = "Todos") Then
            txtfiltro.Enabled = False
            txtfiltro.Clear()
        Else
            txtfiltro.Enabled = True
        End If
    End Sub
    Private Sub btnexibir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExibir.Click
        codcli = Nothing
        cons_corrida()
    End Sub
    Private Sub btnfechar_Click(sender As System.Object, e As System.EventArgs) Handles btnfechar.Click
        inicio.Enabled = True
        Me.Close()
    End Sub
    Private Sub DgvConsCorri_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvConsCorri.CellDoubleClick
        Try
            Dim status As String
            status = DgvConsCorri.CurrentRow.Cells(20).Value
            If status = "Pendente" Or status = "Em andamento" Then
                codigos.codcorrida = DgvConsCorri.CurrentRow.Cells(0).Value
                codigos.nomecli = DgvConsCorri.CurrentRow.Cells(10).Value
                Alt_Agend.Show()
                Me.Enabled = False
            Else
                MessageBox.Show("Corridas " & status & " não podem sofrer alterações.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Enabled = False
        Help_Cons_Corrida.Show()
    End Sub
    Private Sub InformaçõesDaCorridaToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles InformaçõesDaCorridaToolStripMenuItem1.Click
        Try
            codigos.codagend = DgvConsCorri.CurrentRow.Cells(0).Value
            Informacoes.Show()
            Me.Enabled = False
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub CancelarPendente_Click(sender As System.Object, e As System.EventArgs) Handles CancelarPendente.Click
        Try
            Dim status_corrida As String
            status_corrida = DgvConsCorri.CurrentRow.Cells(20).Value
            If Not status_corrida = "Pendente" Then
                MessageBox.Show("Apenas corridas pendentes podem ser canceladas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                codigos.codagend = DgvConsCorri.CurrentRow.Cells(0).Value
                If MessageBox.Show("Deseja realmente cancelar a corrida " & codigos.codagend & "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If cancelar_corrida() = True Then
                        MessageBox.Show("Cancelamento efetuado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        codigos.codagend = Nothing
                        cons_corrida()
                    Else
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Function cancelar_corrida()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "update agendamento set Status_Agend = 'Cancelada', Cod_moto = 0 where Cod_agendamento = " & codigos.codagend & " and Status_Agend = 'Pendente'"
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
            '----------------
            Try
                cn.Open()
                Dim sql As String = "update corrida set status_corrida = 'Cancelada', Cod_moto = 0 where Cod_agendamento = " & codigos.codagend & " and status_corrida = 'Pendente'"
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
            Return True
        End Using
    End Function
End Class