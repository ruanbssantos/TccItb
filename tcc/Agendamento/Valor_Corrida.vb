Imports System.Data.SqlClient
Public Class Valor_Corrida
    Dim CodAgend As Integer
    Dim codadicional As Integer
    Dim codtipo As Integer
    Dim codcorrida As Integer
    Dim codmoto As Integer
    Dim codforma As Integer
    Dim valortotal As Decimal
    Private Sub ValorCorrida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_dados()
    End Sub
    Private Function validar_campos_valor()
        If cbtipo.Text = "" Then
            MessageBox.Show("O campo tipo de corrida não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbtipo.Focus()
            Return False
        ElseIf cbadic.Text = "" Then
            MessageBox.Show("O campo adicional não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbadic.Focus()
            Return False
        End If
        Return True
    End Function
    Private Function validar_campos_pedagio()
        If txtpedagio.Enabled = True Then
            If txtpedagio.Text = "00.00" Then
                MessageBox.Show("Por favor, digite o valor do pedágio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtkm.Focus()
                Return False
            End If
        End If
        Return True
    End Function
    Private Function validar_campos_km()
        If txtkm.Enabled = True Then
            If txtkm.Text = "" Then
                MessageBox.Show("O campo km não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtkm.Focus()
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub btngera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngera.Click
        If validar_campos_valor() = False Then
            Exit Sub
        ElseIf validar_campos_valor() = True Then
            If validar_campos_pedagio() = False Then
                Exit Sub
            ElseIf validar_campos_pedagio() = True Then
                If validar_campos_km() = False Then
                    Exit Sub
                ElseIf validar_campos_km() = True Then
                    If MessageBox.Show("Deseja realmente gerar valor? Após a confirmação essa ação não poderá ser desfeita ou modificada.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If gerar_valor() = True Then
                            btnconfirmar.Enabled = True
                            btngera.Enabled = False
                            cbadic.Enabled = False
                            cbtipo.Enabled = False
                            txtpedagio.Enabled = False
                            txtkm.Enabled = False
                        Else
                            Exit Sub
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click
        If cbformapgto.Text = "" Then
            MessageBox.Show("Insira forma de pagamento para confirmar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            confirmar()
            codigos.contador = 60
        End If
    End Sub
    Private Sub cbadic_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbadic.SelectedIndexChanged
        selecionar_adicional()
        If cbadic.SelectedItem = "Pedágio" Then
            txtpedagio.Enabled = True
        Else
            txtpedagio.Enabled = False
            txtpedagio.Text = "00.00"
        End If
    End Sub
    Private Sub cbtipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbtipo.SelectedIndexChanged
        selecionar_tipo_corrida()
        If cbtipo.SelectedItem = "A disposição" Or cbtipo.SelectedItem = "Alphaville - Congonhas" Or cbtipo.SelectedItem = "Alphaville - Cumbica" Then
            cbadic.SelectedItem = "Não se aplica"
            cbadic.Enabled = False
        Else
            cbadic.Enabled = True
            cbadic.SelectedIndex = -1
        End If
        If cbtipo.Text = "Com paradas" Or cbtipo.Text = "Simples" Then
            BtnExibir.Visible = True
        Else
            BtnExibir.Visible = False
        End If
    End Sub
    Private Sub cbformapgto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbformapgto.SelectedIndexChanged
        forma_pagamento()
    End Sub
    Private Sub carregar_dados()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select top 1 cod_agendamento from agendamento order by cod_agendamento desc"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    CodAgend = mr!cod_agendamento
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
            '--------------------------------------------------------
            Try
                cn.Open()
                Dim sql As String = "select cod_moto from agendamento where cod_agendamento = '" & CodAgend & "' "
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    codmoto = mr!cod_moto
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
            '----------------------------------------------------
            Try
                cn.Open()
                Dim sql As String = "select nome_Corrida from Tipo_corrida"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    cbtipo.Items.Add(mr.Item("nome_Corrida"))
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
            '-----------------------------------------------------
            Try
                cn.Open()
                Dim sql As String = "select desc_forma from forma_pgto"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    cbformapgto.Items.Add(mr.Item("desc_forma"))
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
            '----------------------------------------------------
            Try
                cn.Open()
                Dim sql As String = "select desc_adicional from adicionais_corrida"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    cbadic.Items.Add(mr.Item("desc_adicional"))
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Function gerar_valor()
        Using cn As SqlConnection = conexao()
            Dim pedagio As String
            pedagio = Replace(txtpedagio.Text, ",", ".")
            txtkm.Text = Replace(txtkm.Text, ",", ".")
            '------------------------------------------------
            Try
                cn.Open()
                Dim sql As String = "update adicionais_corrida set valor_adicional = '" & pedagio & "' where cod_adicional = '1'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim mr As Integer
                da.Fill(dt)
                mr = cmd.ExecuteNonQuery
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Finally
                cn.Close()
            End Try
            '---------------------------------------------
            Try
                cn.Open()
                Dim sql As String = "insert into corrida (cod_corrida, cod_TipoCorrida, preco_total, KmTotal, cod_moto, cod_agendamento, status_corrida) values  ('" & CodAgend & "', '" & codtipo & "','0.00', '" & txtkm.Text & "', '" & codmoto & "', '" & CodAgend & "', 'Pendente')"
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
            '------------------------------------------------
            Try
                cn.Open()
                Dim sql As String = "select cod_corrida from corrida where cod_agendamento = '" & CodAgend & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim mr1 As SqlDataReader
                da.Fill(dt)
                mr1 = cmd.ExecuteReader
                While mr1.Read
                    codcorrida = mr1!cod_corrida
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Finally
                cn.Close()
            End Try
            '------------------------------------------------
            Try
                cn.Open()
                Dim sql As String = "insert into det_corrida (cod_corrida, cod_adicional) values  ('" & codcorrida & "','" & codadicional & "')"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
            '----------------------------------------------------
            Try
                cn.Open()
                Dim sql As String = "update corrida set preco_total = (select (Tipo_corrida.preco * corrida.kmTotal) + " & codigos.valorblindagem & " + adicionais_corrida.valor_adicional  from Tipo_corrida inner join corrida on Tipo_corrida.cod_TipoCorrida = corrida.cod_TipoCorrida inner join det_corrida on corrida.cod_corrida = det_corrida.cod_corrida inner join adicionais_corrida on adicionais_corrida.cod_adicional = det_corrida.cod_adicional where corrida.cod_corrida = '" & codcorrida & "') where cod_corrida = '" & codcorrida & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim mr As Integer
                da.Fill(dt)
                mr = cmd.ExecuteNonQuery
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Finally
                cn.Close()
            End Try
            '------------------------------------------------------
            Try
                cn.Open()
                Dim sql As String = "select preco_total from corrida where cod_corrida = '" & codcorrida & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim mr1 As SqlDataReader
                da.Fill(dt)
                mr1 = cmd.ExecuteReader
                While mr1.Read
                    valortotal = mr1!preco_total
                End While
                Dim valor_txt As String
                valor_txt = valortotal.ToString("##,##0.00")
                txtvalor.Text = valor_txt
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Finally
                cn.Close()
            End Try
            Return True
        End Using
    End Function
    Private Sub confirmar()
        Using cn As SqlConnection = conexao()
            Dim valor_pgto As String
            Dim resultado As String
            Dim result_final As String
            valor_pgto = valortotal.ToString("##,##0.00")
            resultado = Replace(valor_pgto, ".", "")
            result_final = Replace(resultado, ",", ".")
            Try
                cn.Open()
                Dim sql As String = "insert into pgto_corrida (cod_pgto, valor_pago, cod_adicional, cod_corrida, cod_forma) values  ('" & CodAgend & "', '" & result_final & "','" & codadicional & "', '" & codcorrida & "', '" & codforma & "' )"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                MessageBox.Show("Agendamento efetuado com sucesso. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
                Agendamento.Close()
                inicio.Enabled = True
                Me.Close()
            End Try
        End Using
    End Sub
    Private Sub selecionar_tipo_corrida()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select cod_TipoCorrida from Tipo_corrida where nome_Corrida= '" & cbtipo.Text & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    codtipo = mr!cod_TipoCorrida
                End While
                cn.Close()
                If cbtipo.SelectedItem = "Simples" Or cbtipo.SelectedItem = "Com paradas" Then
                    txtkm.Enabled = True
                    txtkm.Clear()
                Else
                    txtkm.Enabled = False
                    txtkm.Text = 1
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub selecionar_adicional()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select cod_adicional from adicionais_corrida where desc_adicional= '" & cbadic.Text & "' "
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    codadicional = mr!cod_adicional
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub forma_pagamento()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select cod_forma from forma_pgto where desc_forma= '" & cbformapgto.Text & "' "
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    codforma = mr!cod_forma
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub txtkm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkm.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtpedagio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpedagio.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then
            e.Handled = True
        End If
        'If e.KeyChar = "." And e.KeyChar = "," Then
        '    e.Handled = False
        '    txtpedagio.MaxLength = 5
        'End If
    End Sub
    'Private Sub txtpedagio_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpedagio.TextChanged
    '    Try
    '        If txtpedagio.Text.Substring(0, txtpedagio.Text.IndexOf(".")) Then
    '            txtpedagio.MaxLength = 6
    '        End If
    '    Catch ex As Exception
    '        txtpedagio.MaxLength = 3
    '    End Try
    'End Sub
    Private Sub txtpedagio_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpedagio.TextChanged
        Utils.TextBoxMoeda(txtpedagio)
    End Sub
    Private Sub btnfechar_Click(sender As System.Object, e As System.EventArgs) Handles BtnExibir.Click
        Me.Enabled = False
        Consulta_Rota.Show()
    End Sub
    Private Sub valor_corrida_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cbadic.KeyDown, cbtipo.KeyDown, txtkm.KeyDown, txtpedagio.KeyDown
        If e.KeyCode = Keys.Enter Then
            btngera.PerformClick()
        End If
    End Sub
    Private Sub valor_corrida_1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cbformapgto.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnconfirmar.PerformClick()
        End If
    End Sub
End Class

