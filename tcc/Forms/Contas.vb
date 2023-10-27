Imports System.Data.SqlClient
Public Class Contas
    Dim filtro As String
    Dim codigo As Integer
    Dim cod_conta As Integer
    Dim valor As String
    Private Sub Contas_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescconta.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub
    Private Sub Contas_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        inicio.Enabled = True
        Exit Sub
    End Sub
    Private Sub conscdmot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' codigos.codfunc = 1
        limpar_campos()
        carregar_codigo()
        cbfiltro.SelectedItem = "Todos"
        cons_contas()
    End Sub
    Private Sub limpar_campos()
        txtvalor.Text = "0,00"
        txtcod.Clear()
        DtpPgto.Text = Today
        DtpVenc.Text = Today
        txtdescconta.Clear()
        cod_conta = Nothing
    End Sub
    Private Function Validar_Campos()
        If txtvalor.Text = "" Then
            MessageBox.Show("O campo valor da conta não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtvalor.Focus()
            Return False
        ElseIf txtdescconta.Text = "" Then
            MessageBox.Show("O campo descrição da conta não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtdescconta.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub carregar_codigo()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select top 1 cod_conta from contas_pagar order by Cod_conta desc"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                If mr.Read Then
                    codigo = mr!Cod_conta + 1
                    RbAltExc.Visible = True
                Else
                    codigo = 1
                    RbAltExc.Visible = False
                End If
                txtcod.Text = codigo
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub carregar_dados()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from  contas_pagar where cod_conta = " & cod_conta & " "
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                If mr.Read Then
                    DtpPgto.Text = mr!Data_pgto
                    DtpVenc.Text = mr!Data_venc
                    txtvalor.Text = mr!Valor_pago
                    txtdescconta.Text = mr!Desc_conta
                    btnalterar.Enabled = True
                Else
                    MessageBox.Show("Conta não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    limpar_campos()
                    btnalterar.Enabled = False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Function cad_contas()
        Using cn As SqlConnection = conexao()
            Try
                ' Dim resultado As String
                valor = Replace(txtvalor.Text, ".", "")
                valor = Replace(valor, ",", ".")
                'resultado = valor
                cn.Open()
                Dim sql As String = "insert into contas_pagar (cod_conta, data_venc, data_pgto, valor_pago, cod_func, desc_conta) values  ('" & codigo & "', '" & DtpVenc.Text & "','" & DtpPgto.Text & "', '" & valor & "', '" & codigos.codfunc & "', '" & txtdescconta.Text & "')"
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
    Private Function alt_conta()
        Using cn As SqlConnection = conexao()
            Try
                valor = Replace(txtvalor.Text, ".", "")
                valor = Replace(valor, ",", ".")
                cn.Open()
                Dim sql As String = "update contas_pagar set data_venc ='" & DtpVenc.Text & "', data_pgto = '" & DtpPgto.Text & "', valor_pago = '" & valor & "',  desc_conta = '" & txtdescconta.Text & "' where cod_conta = '" & cod_conta & "' "
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
    Private Sub cons_descricao()
        Using cn As SqlConnection = conexao()
            If (filtro = "Descrição") Then
                Try
                    cn.Open()
                    Dim sql As String = "select cod_conta as Código , data_venc as Vencimento, data_pgto as Pagamento, valor_pago as [Valor da Conta], Cod_func as [Código do Funcionário], Desc_conta as [Descrição da Conta]  from contas_pagar where desc_conta like '%" & txtfiltro.Text & "%' "
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsconta.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            End If
        End Using
    End Sub
    Private Sub cons_contas()
        Using cn As SqlConnection = conexao()
            If (filtro = "Código") Then
                Try
                    cn.Open()
                    Dim sql As String = "select cod_conta as Código , data_venc as Vencimento, data_pgto as Pagamento, valor_pago as [Valor da Conta], Cod_func as [Código do Funcionário], Desc_conta as [Descrição da Conta]  from  contas_pagar where cod_conta = " & txtfiltro.Text & ""
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsconta.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "Data de Pagamento") Then
                Try
                    cn.Open()
                    Dim sql As String = "select cod_conta as Código , data_venc as Vencimento, data_pgto as Pagamento, valor_pago as [Valor da Conta], Cod_func as [Código do Funcionário], Desc_conta as [Descrição da Conta]  from contas_pagar where data_pgto like '%" & txtfiltro.Text & "%' "
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsconta.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "Data de Vencimento") Then
                Try
                    cn.Open()
                    Dim sql As String = "select cod_conta as Código , data_venc as Vencimento, data_pgto as Pagamento, valor_pago as [Valor da Conta], Cod_func as [Código do Funcionário], Desc_conta as [Descrição da Conta]  from contas_pagar where data_venc like '%" & txtfiltro.Text & "%' "
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsconta.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "Descrição") Then
                Try
                    cn.Open()
                    Dim sql As String = "select cod_conta as Código , data_venc as Vencimento, data_pgto as Pagamento, valor_pago as [Valor da Conta], Cod_func as [Código do Funcionário], Desc_conta as [Descrição da Conta]  from  contas_pagar where desc_conta like '%" & txtfiltro.Text & "%' "
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsconta.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cn.Close()
                End Try
            Else
                Try
                    cn.Open()
                    Dim sql As String = "select cod_conta as Código , data_venc as Vencimento, data_pgto as Pagamento, valor_pago as [Valor da Conta], Cod_func as [Código do Funcionário], Desc_conta as [Descrição da Conta]  from  contas_pagar"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsconta.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            End If
        End Using
    End Sub
    Private Sub btnconfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirma.Click
        Try
            If Validar_Campos() = False Then
                Exit Sub
            ElseIf Validar_Campos() = True Then
                If cad_contas() = True Then
                    MessageBox.Show("Cadastro efetuado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpar_campos()
                    carregar_codigo()
                    cons_contas()
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub cbfiltro_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbfiltro.SelectedIndexChanged
        filtro = cbfiltro.SelectedItem
        If (filtro = "Todos") Then
            txtfiltro.Enabled = False
            txtfiltro.Clear()
        Else
            txtfiltro.Enabled = True
        End If
    End Sub
    Private Sub RbCad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbCad.CheckedChanged
        limpar_campos()
        carregar_codigo()
        BtnExibir.Visible = False
        btnalterar.Visible = False
        btnconfirma.Visible = True
        txtcod.Enabled = False
    End Sub
    Private Sub RbAltExc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbAltExc.CheckedChanged
        limpar_campos()
        BtnExibir.Visible = True
        btnalterar.Visible = True
        btnconfirma.Visible = False
        txtcod.Enabled = True
    End Sub
    Private Sub BtnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFechar.Click
        If MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            inicio.Enabled = True
            Me.Close()
        End If
    End Sub
    Private Sub BtnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BtnConsultar.Click
        cons_contas()
    End Sub
    Private Sub btnalterar_Click(sender As System.Object, e As System.EventArgs) Handles btnalterar.Click
        Try
            If cod_conta = txtcod.Text Then
                If Validar_Campos() = False Then
                    Exit Sub
                ElseIf Validar_Campos() = True Then
                    If MessageBox.Show("Deseja realmente alterar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If alt_conta() = True Then
                            MessageBox.Show("Alteração efetuada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            limpar_campos()
                            cons_contas()
                        Else
                            Exit Sub
                        End If
                    End If
                End If
            Else
                Mensagem.lbltitulo.Text = "Erro"
                Mensagem.lblmensagem.Text = "Código da conta modificado. A operação atual foi cancelada."
                limpar_campos()
                Me.Enabled = False
                Mensagem.Show()
                btnalterar.Enabled = False
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Mensagem.lbltitulo.Text = "Erro"
            Mensagem.lblmensagem.Text = "Ocorreu um erro durante o processamento de sua solicitação. A operação atual foi cancelada."
            limpar_campos()
            Me.Enabled = False
            Mensagem.Show()
            btnalterar.Enabled = False
        End Try
    End Sub
    Private Sub BtnExibir_Click(sender As System.Object, e As System.EventArgs) Handles BtnExibir.Click
        Try
            If txtcod.Text.Trim = "" Then
                MessageBox.Show("Por favor digite o código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpar_campos()
                txtcod.Focus()
                btnalterar.Enabled = False
            Else
                cod_conta = txtcod.Text
                carregar_dados()
            End If
        Catch ex As Exception
            Mensagem.lbltitulo.Text = "Erro"
            Mensagem.lblmensagem.Text = "Ocorreu um erro durante o processamento de sua solicitação. A operação atual foi cancelada."
            Me.Enabled = False
            Mensagem.Show()
            limpar_campos()
            btnalterar.Enabled = False
        End Try
    End Sub
    Private Sub DgvConsconta_DoubleClick(sender As Object, e As System.EventArgs) Handles DgvConsconta.DoubleClick
        Try
            RbAltExc.Checked = True
            cod_conta = DgvConsconta.CurrentRow.Cells(0).Value
            txtcod.Text = cod_conta
            carregar_dados()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub txtvalor_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtvalor.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Enabled = False
        Help_Contas.Show()
    End Sub
    Private Sub txtvalor_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtvalor.TextChanged
        Try
            Utils.TextBoxMoeda(txtvalor)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Class