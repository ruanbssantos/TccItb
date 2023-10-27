Imports System.Data.SqlClient
Public Class Agendamento
    Dim CodClifis As Integer
    Dim CodAgend As Integer ' usado para cod
    Dim codadicional As Integer
    Dim codtipo As Integer
    Dim codcorrida As Integer
    Dim codmoto As Integer
    Dim codclijud As Integer
    Dim codfunc As Integer
    Dim blindado As String
    Public Sub limpar_campos()
        mtbcpf.Clear()
        mtbcnpj.Clear()
        DtpData.Text = Today
        DtpHora.Text = FormatDateTime(TimeOfDay, DateFormat.ShortTime)
        txtendorigem.Clear()
        TxtCep.Clear()
        TxtCidade.Clear()
        CbUf.SelectedIndex = -1
        TxtNum.Clear()
        TxtBairro.Clear()
        TxtCompl.Clear()
        txtlocdest.Clear()
        txtobservacoes.Clear()
        CodClifis = Nothing
        codclijud = Nothing
    End Sub
    Private Function validar_cpf()
        Dim cpf As String
        cpf = Replace(mtbcpf.Text, " ", "")
        If cpf = "..-" Then
            MessageBox.Show("O campo CPF não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mtbcpf.Focus()
            Return False
        ElseIf cpf.Length < 14 Then
            MessageBox.Show("Por favor, digite corretamente o CPF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mtbcpf.Focus()
            Return False
        End If
        Return True
    End Function
    Private Function validar_cnpj()
        Dim cnpj As String
        cnpj = Replace(mtbcnpj.Text, " ", "")
        If cnpj = "../-" Then
            MessageBox.Show("O campo CNPJ não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mtbcnpj.Focus()
            Return False
        ElseIf cnpj.Length < 18 Then
            MessageBox.Show("Por favor, digite corretamente o CNPJ.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mtbcnpj.Focus()
            Return False
        End If
        Return True
    End Function
    Private Function Validar_Campos()
        If DtpData.Text < Today Then
            MessageBox.Show("A data da corrida não pode ser menor do que o dia de hoje.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DtpData.Focus()
            Return False
        ElseIf txtendorigem.Text.Trim = "" Then
            MessageBox.Show("O campo endereço de origem não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtendorigem.Focus()
            Return False
        ElseIf TxtBairro.Text.Trim = "" Then
            MessageBox.Show("O campo bairro não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBairro.Focus()
            Return False
        ElseIf TxtNum.Text.Trim = "" Then
            MessageBox.Show("O campo número não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNum.Focus()
            Return False
        ElseIf TxtCidade.Text.Trim = "" Then
            MessageBox.Show("O campo cidade não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtCidade.Focus()
            Return False
        ElseIf CbUf.Text = "" Then
            MessageBox.Show("O campo UF não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbUf.Focus()
            Return False
        ElseIf txtlocdest.Text.Trim = "" Then
            MessageBox.Show("O campo local de destino não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtlocdest.Focus()
            Return False
        End If
        Return True
    End Function
    Private Function validar_dia_hora()
        If DtpData.Text = Today Then
            If DtpHora.Text < FormatDateTime(TimeOfDay, DateFormat.ShortTime) Then
                MessageBox.Show("A hora da corrida não pode ser menor do que a hora atual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                DtpHora.Focus()
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub Agendamento_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCep.KeyPress, txtendorigem.KeyPress, TxtCidade.KeyPress, TxtNum.KeyPress, TxtBairro.KeyPress, TxtCompl.KeyPress, txtlocdest.KeyPress, txtobservacoes.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub
    Private Sub Agendamento_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        inicio.Enabled = True
        Exit Sub
    End Sub
    Private Sub corrida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_codigo()
        codfunc = codigos.codfunc
        'codfunc = 1
        lblcodfunc.Text = codfunc
        DtpData.Text = Today
        DtpHora.Text = FormatDateTime(TimeOfDay, DateFormat.ShortTime)
        formato_hora()
    End Sub
    Public Sub formato_hora()
        DtpHora.Format = DateTimePickerFormat.Custom
        DtpHora.CustomFormat = "HH:mm"
    End Sub
    Private Sub carregar_codigo()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select top 1 cod_agendamento from agendamento order by cod_agendamento desc"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                If mr.Read Then
                    CodAgend = mr!cod_agendamento + 1
                Else
                    CodAgend = 1
                End If
                lblcod.Text = CodAgend
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Function pegar_cod_clifisico()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select cod_cli from cli_fisico where cpf = '" & mtbcpf.Text & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                If mr.Read Then
                    CodClifis = mr!cod_cli
                Else
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                btnconfirma.Enabled = False
                Return False
            Finally
                cn.Close()
            End Try
            Return True
        End Using
    End Function
    Private Function agendar_clifisico()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "insert into agendamento (cod_agendamento, data_agend, horario, cod_moto, cod_cli, cod_func, status_agend, Observacoes, blindagem) values  ('" & CodAgend & "', '" & DtpData.Text & "','" & DtpHora.Text & "', '0', '" & CodClifis & "', '" & codfunc & "', 'Pendente', '" & txtobservacoes.Text & "', '" & blindado & "')"
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
                Dim uf As String = ""
                uf = CbUf.SelectedItem
                cn.Open()
                Dim sql As String = "insert into rota (endereco_destino, endereco_origem, numero, complemento, cep, bairro, cidade, uf, cod_agendamento) values  ('" & txtlocdest.Text & "','" & txtendorigem.Text & "', '" & TxtNum.Text & "', '" & TxtCompl.Text & "', '" & TxtCep.Text & "', '" & TxtBairro.Text & "', '" & TxtCidade.Text & "', '" & uf & "', '" & CodAgend & "')"
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
        End Using
        Return True
    End Function
    Private Function pegar_cod_clijuridico()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select cod_cli from cli_juridico where cnpj = '" & mtbcnpj.Text & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                If mr.Read Then
                    codclijud = mr!cod_cli
                Else
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                btnconfirma.Enabled = False
                Return False
            Finally
                cn.Close()
            End Try
            Return True
        End Using
    End Function
    Private Function agendar_clijuridico()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "insert into agendamento (cod_agendamento, data_agend, horario, cod_moto, cod_cli, cod_func, status_agend, observacoes, blindagem) values  ('" & CodAgend & "', '" & DtpData.Text & "','" & DtpHora.Text & "', '0', '" & codclijud & "', '" & codfunc & "', 'Pendente', '" & txtobservacoes.Text & "', '" & blindado & "')"
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
                Dim uf As String = ""
                uf = CbUf.SelectedItem
                cn.Open()
                Dim sql As String = "insert into rota (endereco_destino, endereco_origem, numero, complemento, cep, bairro, cidade, uf, cod_agendamento) values  ('" & txtlocdest.Text & "','" & txtendorigem.Text & "', '" & TxtNum.Text & "', '" & TxtCompl.Text & "', '" & TxtCep.Text & "', '" & TxtBairro.Text & "', '" & TxtCidade.Text & "', '" & uf & "', '" & CodAgend & "')"
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
    Private Sub rbclijud_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbclijud.CheckedChanged
        limpar_campos()
        btnconfirma.Enabled = False
        mtbcnpj.Visible = True
        mtbcpf.Visible = False
        lblmsg.Text = "CNPJ do cliente:"
    End Sub
    Private Sub rbclifisi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbclifisi.CheckedChanged
        limpar_campos()
        btnconfirma.Enabled = False
        mtbcpf.Visible = True
        mtbcnpj.Visible = False
        lblmsg.Text = "CPF do cliente:"
    End Sub
    Private Sub carregar_cep()
        Using cn As SqlConnection = conexaocep()
            Try
                cn.Open()
                Dim sql As String = "select * from tblLogradouros$ where CEP = " & TxtCep.Text & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    CbUf.Text = mr!uf
                    txtendorigem.Text = mr!descricao
                    TxtCidade.Text = mr!cidade
                    TxtBairro.Text = mr!bairro
                End While
            Catch ex As Exception
                ' MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub btnfechar_Click(sender As System.Object, e As System.EventArgs) Handles btnfechar.Click
        If MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            inicio.Enabled = True
            Me.Close()
        End If
    End Sub
    Private Sub TxtCep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCep.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub TxtCep_LostFocus(sender As Object, e As System.EventArgs) Handles TxtCep.LostFocus
        carregar_cep()
    End Sub
    Private Sub mtbcpf_LostFocus(sender As Object, e As System.EventArgs) Handles mtbcpf.LostFocus
        Dim cpf As String
        cpf = Replace(mtbcpf.Text, " ", "")
        If cpf = "..-" Then
            Exit Sub
        Else
            If pegar_cod_clifisico() = False Then
                MessageBox.Show("Cliente não encontrado. A operação atual não poderá prosseguir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                btnconfirma.Enabled = False
                Exit Sub
            ElseIf pegar_cod_clifisico() = True Then
                btnconfirma.Enabled = True
            End If
        End If
    End Sub
    Private Sub mtbcnpj_LostFocus(sender As Object, e As System.EventArgs) Handles mtbcnpj.LostFocus
        Dim cnpj As String
        cnpj = Replace(mtbcnpj.Text, " ", "")
        If cnpj = "../-" Then
            Exit Sub
        Else
            If pegar_cod_clijuridico() = False Then
                MessageBox.Show("Cliente não encontrado. A operação atual não poderá prosseguir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                btnconfirma.Enabled = False
                Exit Sub
            ElseIf pegar_cod_clijuridico() = True Then
                btnconfirma.Enabled = True
            End If
        End If
    End Sub
    Private Sub btnconfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirma.Click
        If rbsim.Checked = True Then
            Valor_Corrida.txtvalor.Text = "100"
            codigos.valorblindagem = 100
            If rbclifisi.Checked = True Then
                If validar_cpf() = False Then
                    Exit Sub
                ElseIf validar_cpf() = True Then
                    If Validar_Campos() = False Then
                        Exit Sub
                    ElseIf Validar_Campos() = True Then
                        If validar_dia_hora() = False Then
                            Exit Sub
                        ElseIf validar_dia_hora() = True Then
                            If agendar_clifisico() = True Then
                                Valor_Corrida.Show()
                                Me.Visible = False
                            Else
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            ElseIf rbclijud.Checked = True Then
                If validar_cnpj() = False Then
                    Exit Sub
                ElseIf validar_cnpj() = True Then
                    If Validar_Campos() = False Then
                        Exit Sub
                    ElseIf Validar_Campos() = True Then
                        If validar_dia_hora() = False Then
                            Exit Sub
                        ElseIf validar_dia_hora() = True Then
                            If agendar_clijuridico() = True Then
                                Valor_Corrida.Show()
                                Me.Visible = False
                            Else
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
        Else
            Valor_Corrida.txtvalor.Text = "00.00"
            codigos.valorblindagem = 0
            If rbclifisi.Checked = True Then
                If validar_cpf() = False Then
                    Exit Sub
                ElseIf validar_cpf() = True Then
                    If Validar_Campos() = False Then
                        Exit Sub
                    ElseIf Validar_Campos() = True Then
                        If validar_dia_hora() = False Then
                            Exit Sub
                        ElseIf validar_dia_hora() = True Then
                            If agendar_clifisico() = True Then
                                Valor_Corrida.Show()
                                Me.Visible = False
                            Else
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            ElseIf rbclijud.Checked = True Then
                If validar_cnpj() = False Then
                    Exit Sub
                ElseIf validar_cnpj() = True Then
                    If Validar_Campos() = False Then
                        Exit Sub
                    ElseIf Validar_Campos() = True Then
                        If validar_dia_hora() = False Then
                            Exit Sub
                        ElseIf validar_dia_hora() = True Then
                            If agendar_clijuridico() = True Then
                                Valor_Corrida.Show()
                                Me.Visible = False
                            Else
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub rbsim_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbsim.CheckedChanged
        blindado = "True"
    End Sub
    Private Sub rbnao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnao.CheckedChanged
        blindado = "False"
    End Sub
    Private Sub TxtNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNum.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Enabled = False
        Help_Agend.Show()
    End Sub
    Private Sub Agendamento_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles mtbcpf.KeyDown, mtbcnpj.KeyDown, DtpData.KeyDown, DtpHora.KeyDown, TxtCep.KeyDown, txtendorigem.KeyDown, TxtCidade.KeyDown, CbUf.KeyDown, TxtNum.KeyDown, TxtBairro.KeyDown, TxtCompl.KeyDown, txtlocdest.KeyDown, txtobservacoes.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnconfirma.PerformClick()
        End If
    End Sub
End Class