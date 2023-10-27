Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Cliente_Fis
    Dim cod_cli As Integer
    Dim codigo_cli As Integer 'Usado para mostrar codigo
    Dim pegar_cpf As String
    Dim cpf_comp As String
    Dim email_comp As String
    Dim senha As String
    Private Sub limpar_campos()
        cod_cli = Nothing
        pegar_cpf = Nothing
        cpf_comp = Nothing
        email_comp = Nothing
        MtbCpfAlt.Clear()
        TxtNome.Clear()
        DtpDataNasc.Text = Today
        MtbCpf.Clear()
        RbMasc.Checked = True
        TxtCep.Clear()
        CbUf.SelectedIndex = -1
        TxtEnd.Clear()
        TxtCompl.Clear()
        TxtNum.Clear()
        TxtBairro.Clear()
        TxtCidade.Clear()
        MtbTel.Clear()
        MtbCel.Clear()
        TxtEmail.Clear()
        TxtCod.Clear()
    End Sub
    Private Function Validar_Campos()
        Dim cpf As String
        cpf = Replace(MtbCpf.Text.Trim, " ", "")
        Dim strRegex As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + "\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim re As New Regex(strRegex)
        If TxtNome.Text.Trim = "" Then
            MessageBox.Show("O campo nome não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNome.Focus()
            Return False
        ElseIf DtpDataNasc.Text >= Today Then
            MessageBox.Show("Data de nascimento não pode ser maior ou igual ao dia de hoje.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DtpDataNasc.Focus()
            Return False
        ElseIf cpf = "..-" Then
            MessageBox.Show("O campo CPF não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MtbCpf.Focus()
            Return False
        ElseIf cpf.Length < 14 Then
            MessageBox.Show("Por favor, digite corretamente o CPF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MtbCpf.Focus()
            Return False
        ElseIf TxtEmail.Text.Trim = "" Then
            MessageBox.Show("O campo e-mail não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtEmail.Focus()
            Return False
        ElseIf Not (re.IsMatch(TxtEmail.Text.Trim)) Then
            MessageBox.Show("Por favor, digite corretamente o e-mail.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtEmail.Focus()
            Return False
        ElseIf TxtEnd.Text.Trim = "" Then
            MessageBox.Show("O campo endereço não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtEnd.Focus()
            Return False
        ElseIf TxtCidade.Text.Trim = "" Then
            MessageBox.Show("O campo cidade não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtCidade.Focus()
            Return False
        ElseIf CbUf.Text.Trim = "" Then
            MessageBox.Show("O campo UF não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbUf.Focus()
            Return False
        ElseIf TxtNum.Text.Trim = "" Then
            MessageBox.Show("O campo número não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNum.Focus()
            Return False
        ElseIf TxtBairro.Text.Trim = "" Then
            MessageBox.Show("O campo bairro não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBairro.Focus()
            Return False
        End If
        Return True
    End Function
    Private Function Validar_campos_nao_obrigatorio()
        Dim celular As String
        celular = Replace(MtbCel.Text.Trim, " ", "")
        Dim telefone As String
        telefone = Replace(MtbTel.Text.Trim, " ", "")
        If telefone = "()-" And celular = "()-" Then
            MessageBox.Show("O campo telefone ou celular não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MtbTel.Focus()
            Return False
        End If
        If telefone <> "()-" Then
            If telefone.Length < 13 Then
                MessageBox.Show("Por favor, digite corretamente o telefone.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                MtbTel.Focus()
                Return False
            End If
        End If
        If celular <> "()-" Then
            If celular.Length < 14 Then
                MessageBox.Show("Por favor, digite corretamente o celular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                MtbCel.Focus()
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub carregar_codigo()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select top 1 cod_cli from cliente order by cod_cli desc"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                If mr.Read Then
                    codigo_cli = mr!cod_cli
                    If codigo_cli Mod 2 = 0 Then
                        codigo_cli = codigo_cli + 1
                    Else
                        codigo_cli = codigo_cli + 2
                    End If
                    RbAltExc.Visible = True
                Else
                    codigo_cli = 1
                    RbAltExc.Visible = False
                End If
                TxtCod.Text = codigo_cli
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Function cad_cli()
        Using cn As SqlConnection = conexao()
            Try
                Dim uf As String = ""
                uf = CbUf.SelectedItem
                cn.Open()
                Dim sql As String = "insert into cliente (cod_cli, nome, endereco, numero, complemento, cep, bairro, cidade, uf, telefone, celular, email, senha, tipo_cli) values  ('" & codigo_cli & "','" & TxtNome.Text & "','" & TxtEnd.Text & "', '" & TxtNum.Text & "', '" & TxtCompl.Text & "', '" & TxtCep.Text & "', '" & TxtBairro.Text & "',  '" & TxtCidade.Text & "',  '" & uf & "', '" & MtbTel.Text & "', '" & MtbCel.Text & "','" & TxtEmail.Text & "','" & senha & "', 'Fis')"
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
            '-------------------------------------------------------
            Try
                Dim sexo As String = ""
                If RbMasc.Checked = True Then
                    sexo = "M"
                ElseIf RbFem.Checked = True Then
                    sexo = "F"
                End If
                cn.Open()
                Dim sql As String = "insert into cli_fisico (cpf, sexo, data_nasc, cod_cli) values  ('" & MtbCpf.Text & "','" & sexo & "', '" & DtpDataNasc.Text & "', '" & codigo_cli & "')"
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
    Private Sub Carregar_cep()
        Using cn As SqlConnection = conexaocep()
            Try
                cn.Open()
                Dim sql As String = "select * from tblLogradouros$ where CEP = " & TxtCep.Text & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    TxtCep.Text = mr!cep
                    CbUf.Text = mr!uf
                    TxtEnd.Text = mr!descricao
                    TxtCidade.Text = mr!cidade
                    TxtBairro.Text = mr!bairro
                End While
            Catch ex As Exception
                'MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub carregar_dados_cli()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from cliente where cod_cli = " & cod_cli & " and tipo_cli = 'Fis'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    TxtNome.Text = mr!nome
                    TxtEnd.Text = mr!endereco
                    TxtNum.Text = mr!numero
                    TxtCompl.Text = mr!complemento
                    TxtCep.Text = mr!cep
                    TxtBairro.Text = mr!bairro
                    TxtCidade.Text = mr!cidade
                    CbUf.Text = mr!uf
                    MtbTel.Text = mr!telefone
                    MtbCel.Text = mr!celular
                    TxtEmail.Text = mr!email
                    email_comp = mr!email
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
            '----------------------------------------------------------
            Try
                cn.Open()
                Dim sql As String = "select * from cli_fisico where cod_cli = " & cod_cli & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                Dim sexo As String = ""
                mr = cmd.ExecuteReader
                While mr.Read
                    cpf_comp = mr!cpf
                    MtbCpf.Text = mr!cpf
                    sexo = mr!sexo
                    If sexo = "F" Then
                        RbFem.Checked = True
                    ElseIf sexo = "M" Then
                        RbMasc.Checked = True
                    End If
                    DtpDataNasc.Text = mr!data_nasc
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Function alt_cli_email_novo()
        Using cn As SqlConnection = conexao()
            Try
                Dim uf As String = ""
                uf = CbUf.SelectedItem
                cn.Open()
                Dim sql As String = "update cliente set nome = '" & TxtNome.Text & "', endereco = '" & TxtEnd.Text & "', numero = '" & TxtNum.Text & "' , complemento = '" & TxtCompl.Text & "',cep ='" & TxtCep.Text & "', bairro = '" & TxtBairro.Text & "' , cidade = '" & TxtCidade.Text & "'  , uf = '" & uf & "', telefone = '" & MtbTel.Text & "', celular = '" & MtbCel.Text & "', email = '" & TxtEmail.Text & "', senha= '" & senha & "' where cod_cli = " & cod_cli & ""
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
            '--------------------------------------------------------------
            Try
                Dim sexo As String = ""
                If RbMasc.Checked = True Then
                    sexo = "M"
                ElseIf RbFem.Checked = True Then
                    sexo = "F"
                End If
                cn.Open()
                Dim sql As String = "update cli_fisico set sexo = '" & sexo & "', data_nasc = '" & DtpDataNasc.Text & "' where cod_cli = " & cod_cli & ""
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
    Private Function alt_cli_normal()
        Using cn As SqlConnection = conexao()
            Try
                Dim uf As String = ""
                uf = CbUf.SelectedItem
                cn.Open()
                Dim sql As String = "update cliente set nome = '" & TxtNome.Text & "', endereco = '" & TxtEnd.Text & "', numero = '" & TxtNum.Text & "' , complemento = '" & TxtCompl.Text & "',cep ='" & TxtCep.Text & "', bairro = '" & TxtBairro.Text & "' , cidade = '" & TxtCidade.Text & "'  , uf = '" & uf & "', telefone = '" & MtbTel.Text & "', celular = '" & MtbCel.Text & "' where cod_cli = " & cod_cli & ""
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
            '--------------------------------------------------------------
            Try
                Dim sexo As String = ""
                If RbMasc.Checked = True Then
                    sexo = "M"
                ElseIf RbFem.Checked = True Then
                    sexo = "F"
                End If
                cn.Open()
                Dim sql As String = "update cli_fisico set sexo = '" & sexo & "', data_nasc = '" & DtpDataNasc.Text & "' where cod_cli = " & cod_cli & ""
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
    Private Sub pegar_cod()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select cod_cli from cli_fisico where cpf = '" & MtbCpfAlt.Text & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                If mr.Read Then
                    cod_cli = mr!cod_cli
                    BtnAlt.Enabled = True
                Else
                    MessageBox.Show("Cliente não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    limpar_campos()
                    cod_cli = Nothing
                    BtnAlt.Enabled = False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Function comparar_email()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select email from cliente"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    Do While TxtEmail.Text = mr!Email
                        Return False
                    Loop
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
            Return True
        End Using
    End Function
    Private Sub TxtEmail_LostFocus(sender As Object, e As System.EventArgs) Handles TxtEmail.LostFocus
        If email_comp = TxtEmail.Text Then
            Exit Sub
        Else
            If comparar_email() = False Then
                MessageBox.Show("E-mail já cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtEmail.Clear()
                TxtEmail.Focus()
            End If
        End If
    End Sub
    Private Function comparar_cpf()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select cpf from cli_fisico"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    Do While MtbCpf.Text = mr!cpf
                        Return False
                    Loop
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
        Return True
    End Function
    Private Sub mtbcpf_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MtbCpf.LostFocus
        Dim cpf1 As New Valida_CPF_CNPJ
        cpf1.cpf = CStr(MtbCpf.Text)
        Dim cpf_ As String
        cpf_ = Replace(MtbCpf.Text, " ", "")
        If cpf_ = "..-" Then
            Exit Sub
        Else
            If cpf_comp = MtbCpf.Text Then
                Exit Sub
            Else
                If comparar_cpf() = True Then
                    If cpf1.isCpfValido = False Then
                        MessageBox.Show("CPF inválido. Operação atual não prosseguida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        MtbCpf.Clear()
                        MtbCpf.Focus()
                    End If
                Else
                    MessageBox.Show("CPF já cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MtbCpf.Clear()
                    MtbCpf.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub btnalterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlt.Click
        If pegar_cpf = MtbCpfAlt.Text Then
            If Validar_Campos() = False Then
                Exit Sub
            ElseIf Validar_Campos() = True Then
                If Validar_campos_nao_obrigatorio() = False Then
                    Exit Sub
                ElseIf Validar_campos_nao_obrigatorio() = True Then
                    If email_comp <> TxtEmail.Text.Trim Then
                        gerasenha()
                        If MessageBox.Show("Deseja realmente alterar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            If alt_cli_email_novo() = True Then
                                MessageBox.Show("Nova senha gerada para este cliente: " & senha & "", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                MessageBox.Show("Alteração efetuada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpar_campos()
                                BtnAlt.Enabled = False
                            Else
                                Exit Sub
                            End If
                        End If
                    Else
                        If MessageBox.Show("Deseja realmente alterar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            If alt_cli_normal() = True Then
                                MessageBox.Show("Alteração efetuada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpar_campos()
                                BtnAlt.Enabled = False
                            Else
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
        Else
            Mensagem.lbltitulo.Text = "Erro"
            Mensagem.lblmensagem.Text = "CPF do cliente modificado. A operação atual foi cancelada."
            Mensagem.Show()
            Me.Enabled = False
            limpar_campos()
            BtnAlt.Enabled = False
        End If
    End Sub
    Private Sub btnconfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfirma.Click
        If Validar_Campos() = False Then
            Exit Sub
        ElseIf Validar_Campos() = True Then
            If Validar_campos_nao_obrigatorio() = False Then
                Exit Sub
            ElseIf Validar_campos_nao_obrigatorio() = True Then
                gerasenha()
                If cad_cli() = True Then
                    MessageBox.Show("Senha gerada para este cliente: " & senha & "", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'enviar_email()
                    MessageBox.Show("Cadastro efetuado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpar_campos()
                    carregar_codigo()
                Else
                    Exit Sub
                End If
            End If
        End If
    End Sub
    Private Sub btnexibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExibir.Click
        Try
            Dim cpf As String
            cpf = Replace(MtbCpfAlt.Text, " ", "")
            If cpf = "..-" Then
                MessageBox.Show("Por favor digite o CPF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpar_campos()
                MtbCpf.Focus()
                BtnAlt.Enabled = False
            ElseIf cpf.Length < 14 Then
                MessageBox.Show("Por favor, digite corretamente o CPF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                MtbCpf.Focus()
                BtnAlt.Enabled = False
                TxtNome.Clear()
                DtpDataNasc.Text = Today
                MtbCpf.Clear()
                RbMasc.Checked = True
                TxtCep.Clear()
                CbUf.SelectedIndex = -1
                TxtEnd.Clear()
                TxtCompl.Clear()
                TxtNum.Clear()
                TxtBairro.Clear()
                TxtCidade.Clear()
                MtbTel.Clear()
                MtbCel.Clear()
                TxtEmail.Clear()
                TxtCod.Clear()
                cpf_comp = Nothing
                email_comp = Nothing
            Else
                pegar_cod()
                pegar_cpf = MtbCpfAlt.Text
                carregar_dados_cli()
            End If
        Catch ex As Exception
            Mensagem.lbltitulo.Text = "Erro"
            Mensagem.lblmensagem.Text = "Ocorreu um erro durante o processamento de sua solicitação. A operação atual foi cancelada."
            Me.Enabled = False
            Mensagem.Show()
            limpar_campos()
        End Try
    End Sub
    Private Sub TxtCepCliFis_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCep.LostFocus
        Carregar_cep()
    End Sub
    Private Sub btnfechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfechar.Click
        If MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            inicio.Enabled = True
            Me.Close()
        End If
    End Sub
    Private Sub rbcadastro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbCad.CheckedChanged
        limpar_campos()
        carregar_codigo()
        MtbCpf.Enabled = True
        TxtCod.Enabled = False
        BtnConfirma.Visible = True
        BtnExibir.Visible = False
        BtnAlt.Visible = False
        BtnAlt.Enabled = False
        LblMsg.Text = "Código do Cadastro:"
        TxtCod.Visible = True
        MtbCpfAlt.Visible = False
    End Sub
    Private Sub rbaltexcl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbAltExc.CheckedChanged
        limpar_campos()
        MtbCpf.Enabled = False
        TxtCod.Enabled = True
        BtnExibir.Visible = True
        BtnAlt.Visible = True
        BtnConfirma.Visible = False
        TxtCod.Visible = False
        LblMsg.Text = "CPF de Cadastro:"
        MtbCpfAlt.Visible = True
    End Sub
    Private Sub Cliente_Fis_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNome.KeyPress, TxtCep.KeyPress, TxtEnd.KeyPress, TxtCidade.KeyPress, TxtNum.KeyPress, TxtBairro.KeyPress, TxtCompl.KeyPress, TxtEmail.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub
    Private Sub Cliente_Fis_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        inicio.Enabled = True
        Exit Sub
    End Sub
    Private Sub ClienteFis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If codigos.conscodclifis <> 0 Then
                cod_cli = codigos.conscodclifis
                pegar_cpf = codigos.cpfclifis
                carregar_dados_cli()
                MtbCpfAlt.Text = pegar_cpf
                BtnAlt.Enabled = True
                codigos.conscodclifis = 0
            ElseIf codigos.conscodclifis = 0 Then
                RbCad.Checked = True
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub TxtNome_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNome.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub TxtNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNum.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub TxtCep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCep.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Enabled = False
        Help_Cli_Fis.Show()
    End Sub
    Private Function gerasenha() As String
        Dim prn As New Random
        Const minch As Integer = 8
        Const maxch As Integer = 8
        Const rancd As String = "ABCDEFGHIJKLMOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim senha_gerada As New System.Text.StringBuilder
        For i As Integer = 1 To prn.Next(minch, maxch + 1)
            senha = Convert.ToString(senha_gerada.Append(rancd.Substring(prn.Next(0, rancd.Length), 1)))
        Next
        Return Convert.ToString(senha_gerada)
    End Function
    'Private Sub enviar_email()
    '    Try
    '        Dim remetenteEmail As String = "kingtaxiscomp@gmail.com"
    '        Dim objEmail As New System.Net.Mail.MailMessage()
    '        objEmail.From = New System.Net.Mail.MailAddress(remetenteEmail, "King Taxi's", System.Text.Encoding.UTF8)
    '        objEmail.To.Add(TxtEmail.Text)
    '        objEmail.Priority = System.Net.Mail.MailPriority.Normal
    '        objEmail.IsBodyHtml = True
    '        objEmail.Subject = "Confirmação de cadastro"
    '        objEmail.Body = "Seu cadastro foi realizado com sucesso. Para efetuar um Login em nosso site utilize essa mesma conta de email e a senha: " & senha & " </n> Esta senha pode ser alterada em nosso site (apenas no site)."
    '        objEmail.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1")
    '        objEmail.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1")
    '        Dim objSmtp As New System.Net.Mail.SmtpClient
    '        objSmtp.Host = "smtp.gmail.com"
    '        objSmtp.Credentials = New System.Net.NetworkCredential("kingtaxiscomp@gmail.com", "kingtaxi123321")
    '        objSmtp.Port = 587
    '        objSmtp.EnableSsl = True
    '        objSmtp.Send(objEmail)
    '        MessageBox.Show("E-mail enviado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        objEmail.Dispose()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End Try
    'End Sub
End Class