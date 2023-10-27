Imports System.Data.SqlClient
Public Class Rel_Corrida
    Dim mes1 As Integer
    Dim ano1 As Integer
    Dim filtro As Integer
    Dim total_lucro As String
    Dim resultado1 As Double
    Private Sub btnexibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexibir.Click
        lblvalor.Text = ""
        If cbporcent.Text <> "-" And CbMes.Text <> "Todos" Then
            relatorio_corr4()
        ElseIf txtcodmoto.Text = "" Then
            relatorio_corr1()
        ElseIf CbMes.Text = "Todos" Then
            relatorio_corr3()
        Else
            relatorio_corr2()
        End If
    End Sub
    Private Sub relatorio_corr1()
        lblvalor.Text = ""
        cbporcent.SelectedItem = "-"
        If txtano.Text = "" Then
            ano1 = System.DateTime.Now.Year
        Else
            ano1 = txtano.Text
        End If
        If CbMes.Text = "Todos" Then
            MessageBox.Show("É necessário inserir o código do motorista para realizar a operação atual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CbMes.Text = "" Then
            mes1 = System.DateTime.Now.Month
        Else
            mes1 = filtro
        End If
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select corrida.Cod_moto as [Código do motorista], motorista.Condicao as [Condição], datepart(year,agendamento.Data_agend) as Ano, datepart(month,agendamento.Data_agend) as Mês , sum(corrida.Preco_total) as Lucro from agendamento inner join corrida on agendamento.Cod_agendamento = corrida.Cod_agendamento inner join motorista on motorista.Cod_moto = corrida.Cod_moto where datepart(month,agendamento.Data_agend) = '" & mes1 & "' and datepart(year,agendamento.Data_agend) = '" & ano1 & "' and agendamento.Status_Agend = 'Finalizada' group by datepart(month,agendamento.Data_agend), corrida.Cod_moto, motorista.Condicao, datepart(year,agendamento.Data_agend)"
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
    Private Sub CbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbMes.SelectedIndexChanged
        If CbMes.SelectedItem = "Janeiro" Then
            filtro = 1
        ElseIf CbMes.SelectedItem = "Fevereiro" Then
            filtro = 2
        ElseIf CbMes.SelectedItem = "Março" Then
            filtro = 3
        ElseIf CbMes.SelectedItem = "Abril" Then
            filtro = 4
        ElseIf CbMes.SelectedItem = "Maio" Then
            filtro = 5
        ElseIf CbMes.SelectedItem = "Junho" Then
            filtro = 6
        ElseIf CbMes.SelectedItem = "Julho" Then
            filtro = 7
        ElseIf CbMes.SelectedItem = "Agosto" Then
            filtro = 8
        ElseIf CbMes.SelectedItem = "Setembro" Then
            filtro = 9
        ElseIf CbMes.SelectedItem = "Outubro" Then
            filtro = 10
        ElseIf CbMes.SelectedItem = "Novembro" Then
            filtro = 11
        ElseIf CbMes.SelectedItem = "Dezembro" Then
            filtro = 12
        End If
    End Sub
    Public Sub relatorio_corr2()
        lblvalor.Text = ""
        cbporcent.SelectedItem = "-"
        If txtano.Text = "" Then
            ano1 = System.DateTime.Now.Year
        Else
            ano1 = txtano.Text
        End If
        If CbMes.Text = "" Then
            mes1 = System.DateTime.Now.Month
        Else
            mes1 = filtro
        End If
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select corrida.Cod_moto as [Código do motorista], motorista.Condicao as [Condição],datepart(year,agendamento.Data_agend) as Ano, datepart(month,agendamento.Data_agend) as Mês , sum(corrida.Preco_total) as Lucro from agendamento inner join corrida on agendamento.Cod_agendamento = corrida.Cod_agendamento inner join motorista on motorista.Cod_moto = corrida.Cod_moto where motorista.Cod_moto = '" & txtcodmoto.Text & "' and datepart(month,agendamento.Data_agend) = '" & mes1 & "' and datepart(year,agendamento.Data_agend) = '" & ano1 & "' and agendamento.Status_Agend = 'Finalizada' group by datepart(month,agendamento.Data_agend), corrida.Cod_moto, motorista.Condicao, datepart(year,agendamento.Data_agend)"
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
    Private Sub relatorio_corr3()
        lblvalor.Text = ""
        cbporcent.SelectedItem = "-"
        If txtano.Text = "" Then
            ano1 = System.DateTime.Now.Year
        Else
            ano1 = txtano.Text
        End If
        If CbMes.Text = "" Then
            mes1 = System.DateTime.Now.Month
        Else
            mes1 = filtro
        End If
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select agendamento.Cod_moto as [Código do motorista], motorista.Condicao as [Condição], datepart(YEAR,agendamento.Data_agend) as Ano,datepart(month,agendamento.Data_agend) as Mês, sum(corrida.Preco_total) as Lucro from agendamento inner join corrida on agendamento.Cod_agendamento = corrida.Cod_agendamento inner join motorista on motorista.Cod_moto = agendamento.Cod_moto  where agendamento.Cod_moto = '" & txtcodmoto.Text & "' and agendamento.Status_Agend = 'Finalizada' and datepart(year,agendamento.Data_agend) = '" & ano1 & "'  group by datepart(MONTH,agendamento.Data_agend), datepart(year,agendamento.Data_agend), agendamento.Cod_moto, motorista.condicao"
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
    Private Sub Rel_Corrida_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        inicio.Enabled = True
        Exit Sub
    End Sub
    Private Sub RelLucroCorrida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        busca_data()
        relatorio_corr1()
        cbporcent.Text = "-"
        txtano.Text = System.DateTime.Now.Year
    End Sub
    Private Sub busca_data()
        If System.DateTime.Now.Month = 1 Then
            CbMes.SelectedItem = "Janeiro"
        ElseIf System.DateTime.Now.Month = 2 Then
            CbMes.SelectedItem = "Fevereiro"
        ElseIf System.DateTime.Now.Month = 3 Then
            CbMes.SelectedItem = "Março"
        ElseIf System.DateTime.Now.Month = 4 Then
            CbMes.SelectedItem = "Abril"
        ElseIf System.DateTime.Now.Month = 5 Then
            CbMes.SelectedItem = "Maio"
        ElseIf System.DateTime.Now.Month = 6 Then
            CbMes.SelectedItem = "Junho"
        ElseIf System.DateTime.Now.Month = 7 Then
            CbMes.SelectedItem = "Julho"
        ElseIf System.DateTime.Now.Month = 8 Then
            CbMes.SelectedItem = "Agosto"
        ElseIf System.DateTime.Now.Month = 9 Then
            CbMes.SelectedItem = "Setembro"
        ElseIf System.DateTime.Now.Month = 10 Then
            CbMes.SelectedItem = "Outubro"
        ElseIf System.DateTime.Now.Month = 11 Then
            CbMes.SelectedItem = "Novembro"
        ElseIf System.DateTime.Now.Month = 12 Then
            CbMes.SelectedItem = "Dezembro"
        End If
    End Sub
    Private Sub relatorio_corr4()
        If txtcodmoto.Text = "" Then
            MessageBox.Show("É necessário inserir o código do motorista para realizar tal operação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If txtano.Text = "" Then
                ano1 = System.DateTime.Now.Year
            Else
                ano1 = txtano.Text
            End If
            If CbMes.Text = "" Then
                mes1 = System.DateTime.Now.Month
            Else
                mes1 = filtro
            End If

            Using cn As SqlConnection = conexao()
                Try
                    cn.Open()
                    'Dim sql As String = "select agendamento.Cod_moto as [Código do motorista], motorista.Condicao as [Condição], datepart(YEAR,agendamento.Data_agend) as Ano,datepart(month,agendamento.Data_agend) as Mês, sum(corrida.Preco_total) as Lucro from agendamento inner join corrida on agendamento.Cod_agendamento = corrida.Cod_agendamento inner join motorista on motorista.Cod_moto = agendamento.Cod_moto  where agendamento.Cod_moto = '" & txtcodmoto.Text & "' and agendamento.Status_Agend = 'Finalizada' and datepart(year,agendamento.Data_agend) = '" & ano1 & "' group by datepart(MONTH,agendamento.Data_agend), datepart(year,agendamento.Data_agend), agendamento.Cod_moto, motorista.condicao"
                    Dim sql As String = "select corrida.Cod_moto as [Código do motorista], motorista.Condicao as [Condição],datepart(year,agendamento.Data_agend) as Ano, datepart(month,agendamento.Data_agend) as Mês , sum(corrida.Preco_total) as Lucro from agendamento inner join corrida on agendamento.Cod_agendamento = corrida.Cod_agendamento inner join motorista on motorista.Cod_moto = corrida.Cod_moto where motorista.Cod_moto = '" & txtcodmoto.Text & "' and datepart(month,agendamento.Data_agend) = '" & mes1 & "' and datepart(year,agendamento.Data_agend) = '" & ano1 & "' and agendamento.Status_Agend = 'Finalizada' group by datepart(month,agendamento.Data_agend), corrida.Cod_moto, motorista.Condicao, datepart(year,agendamento.Data_agend)"
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

                Try
                    cn.Open()
                    Dim sql As String = "select sum(corrida.Preco_total) as Lucro from agendamento inner join corrida on agendamento.Cod_agendamento = corrida.Cod_agendamento inner join motorista on motorista.Cod_moto = corrida.Cod_moto where agendamento.Cod_moto = '" & txtcodmoto.Text & "' and datepart(month,agendamento.Data_agend) = '" & mes1 & "' and datepart(year,agendamento.Data_agend) = '" & ano1 & "' and agendamento.Status_Agend = 'Finalizada' group by datepart(month,agendamento.Data_agend), corrida.Cod_moto, motorista.Condicao, datepart(year,agendamento.Data_agend)"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim mr As SqlDataReader
                    mr = cmd.ExecuteReader
                    While mr.Read
                        total_lucro = mr!lucro
                    End While
                    resultado1 = (total_lucro / 100) * cbporcent.SelectedItem
                    lblvalor.Text = resultado1.ToString("##,##0.00")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
                '------------------------------------------------------------------------
            End Using
        End If
    End Sub
    Private Sub txtano_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtano.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtcodmoto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodmoto.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Enabled = False
        Help_Relatorio_corrida.Show()
    End Sub
    Private Sub rel_corrida_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtcodmoto.KeyDown, txtano.KeyDown, cbporcent.KeyDown, CbMes.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnexibir.PerformClick()
        End If
    End Sub
End Class