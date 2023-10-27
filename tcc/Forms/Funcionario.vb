Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Funcionario
    Dim codigo As Integer
    Dim nomeimg As String
    Dim cod_func As Integer
    Dim cod_func_rec As Integer
    Dim cpf_comp As String
    Private Sub limpar_campos()
        TxtNome.Clear()
        DtpDataNasc.Text = Today
        MtbCpf.Clear()
        MtbRG.Clear()
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
        CbNivel.SelectedIndex = -1
        TxtCod.Clear()
        TxtUser.Text = ""
        PbFoto.Image = Nothing
        cpf_comp = Nothing
        nomeimg = ""
    End Sub
    Private Function Validar_Campos()
        Dim cpf As String
        cpf = Replace(MtbCpf.Text.Trim, " ", "")
        If TxtNome.Text.Trim = "" Then
            MessageBox.Show("O campo nome não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNome.Focus()
            Return False
        ElseIf TxtUser.Text = "" Then
            MessageBox.Show("Por favor, digite nome e sobrenome.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        ElseIf MtbRG.Text.Trim = "" Then
            MessageBox.Show("O campo RG não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MtbRG.Focus()
            Return False
        ElseIf MtbRG.Text.Trim.Length < 9 Then
            MessageBox.Show("Por favor, digite corretamente o RG .", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MtbRG.Focus()
            Return False
        ElseIf TxtEnd.Text.Trim = "" Then
            MessageBox.Show("O campo endereço não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtEnd.Focus()
            Return False
        ElseIf TxtCidade.Text.Trim = "" Then
            MessageBox.Show("O campo cidade não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtCidade.Focus()
            Return False
        ElseIf CbUf.Text = "" Then
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
        ElseIf CbNivel.Text.Trim = "" Then
            MessageBox.Show("O campo nível não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbNivel.Focus()
            Return False
        End If
        Return True
    End Function
    Private Function Validar_telefone_celular()
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
    Private Function Validar_email()
        Dim strRegex As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + "\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim re As New Regex(strRegex)
        If TxtEmail.Text.Trim <> "" Then
            If Not (re.IsMatch(TxtEmail.Text)) Then
                MessageBox.Show("Por favor, digite corretamente o e-mail.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtEmail.Focus()
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub carregar_codigo()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select top 1 cod_func from funcionario order by cod_func desc"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                If mr.Read Then
                    codigo = mr!cod_func + 1
                    RbAltExc.Visible = True
                Else
                    codigo = 1
                    RbAltExc.Visible = False
                End If
                TxtCod.Text = codigo
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Function Cad_Funcionario()
        Using cn As SqlConnection = conexao()
            Try
                Dim sexo As String = ""
                Dim uf As String = ""
                uf = CbUf.SelectedItem
                If RbMasc.Checked = True Then
                    sexo = "M"
                ElseIf RbFem.Checked = True Then
                    sexo = "F"
                End If
                cn.Open()
                Dim sql As String = "insert into funcionario (cod_func, img_local,nome,cpf, sexo, rg, data_nasc, endereco, numero, complemento, cep, bairro, cidade, uf, email, telefone, celular,condicao) values  ('" & codigo & "', '" & nomeimg & "', '" & TxtNome.Text & "' , '" & MtbCpf.Text & "', '" & sexo & "', '" & MtbRG.Text & "', '" & DtpDataNasc.Text & "', '" & TxtEnd.Text & "', '" & TxtNum.Text & "', '" & TxtCompl.Text & "', '" & TxtCep.Text & "', '" & TxtBairro.Text & "', '" & TxtCidade.Text & "', '" & uf & "', '" & TxtEmail.Text & "', '" & MtbTel.Text & "', '" & MtbCel.Text & "', '" & True & "')"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
            '------------------------------------------
            Try
                Dim nivel As String = ""
                nivel = CbNivel.SelectedItem
                cn.Open()
                Dim sql As String = "insert into TbLogin ( Usuario, Senha, Nivel, condicao, cod_func) values  ('" & TxtUser.Text & "' , '123456', '" & nivel & "', '" & True & "', '" & codigo & "')"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
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
                Exit Sub
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub carregar_dados_ativos()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sexo As String = ""
                Dim sql As String = "select * from  funcionario where cod_func = " & cod_func & " and condicao = '" & True & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                If mr.Read Then
                    nomeimg = mr!img_local
                    TxtNome.Text = mr!nome
                    cpf_comp = mr!cpf
                    MtbCpf.Text = mr!cpf
                    MtbRG.Text = mr!rg
                    DtpDataNasc.Text = mr!data_nasc
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
                    sexo = mr!sexo
                    If sexo = "F" Then
                        RbFem.Checked = True
                    ElseIf sexo = "M" Then
                        RbMasc.Checked = True
                    End If
                    If codigos.codfunc = cod_func Then
                        BtnAlt.Enabled = True
                        BtnRestSenha.Enabled = True
                        BtnRestSenha.Visible = True
                        BtnExc.Enabled = False
                    Else
                        BtnAlt.Enabled = True
                        BtnRestSenha.Enabled = True
                        BtnRestSenha.Visible = True
                        BtnExc.Enabled = True
                    End If
                Else
                    MessageBox.Show("Funcionário não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    limpar_campos()
                    BtnAlt.Enabled = False
                    BtnExc.Enabled = False
                    BtnRestSenha.Enabled = False
                    BtnRestSenha.Visible = False
                End If
                '---------------------------------------
                Try
                    PbFoto.Image = New System.Drawing.Bitmap(nomeimg)
                Catch ex1 As Exception
                End Try
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
            '--------------------------------
            Try
                cn.Open()
                Dim sql As String = "select * from  tblogin where cod_func = " & cod_func & " and condicao = '" & True & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    TxtUser.Text = mr!usuario
                    CbNivel.Text = mr!nivel
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub carregar_dados_inativos()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select cod_func from  funcionario where cod_func = " & TxtCod.Text & " and condicao = '" & False & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    cod_func_rec = mr!cod_func
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Function alt_func()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim uf As String = ""
                uf = CbUf.SelectedItem
                Dim sexo As String = ""
                If RbMasc.Checked = True Then
                    sexo = "M"
                ElseIf RbFem.Checked = True Then
                    sexo = "F"
                End If
                Dim sql As String = "update funcionario set img_local ='" & nomeimg & "', nome = '" & TxtNome.Text & "', sexo = '" & sexo & "' , rg = '" & MtbRG.Text & "', data_nasc = '" & DtpDataNasc.Text & "' , endereco = '" & TxtEnd.Text & "'  , numero = '" & TxtNum.Text & "', complemento = '" & TxtCompl.Text & "', cep = '" & TxtCep.Text & "', bairro = '" & TxtBairro.Text & "', cidade = '" & TxtCidade.Text & "', uf = '" & uf & "', telefone = '" & MtbTel.Text & "', celular = '" & MtbCel.Text & "', email = '" & TxtEmail.Text & "' where cod_func = " & cod_func & ""
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
            '---------------------------------
            Try
                cn.Open()
                Dim nivel As Integer
                nivel = CbNivel.SelectedItem
                Dim sql As String = "update tblogin set usuario = '" & TxtUser.Text & "', nivel = '" & nivel & "' where cod_func = " & cod_func & ""
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
    Private Sub exc_func()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "update tblogin set condicao = '" & False & "' where cod_func = " & cod_func & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
            '--------------------------
            Try
                cn.Open()
                Dim sql As String = "update funcionario set condicao = '" & False & "' where cod_func = " & cod_func & ""
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
    Private Sub rec_func()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "update tblogin set condicao = '" & True & "' where cod_func = " & cod_func_rec & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
            '--------------------------
            Try
                cn.Open()
                Dim sql As String = "update funcionario set condicao = '" & True & "' where cod_func = " & cod_func_rec & ""
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
    Private Sub reset_senha()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim nivel As Integer
                nivel = CbNivel.SelectedItem
                Dim sql As String = "update tblogin set senha = '123456' where cod_func = " & cod_func & ""
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
    Private Function comparar_cpf()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select cpf from funcionario"
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
                        MessageBox.Show("CPF inválido. Operação atual não proseguida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
    Private Sub rbcadastro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbCad.CheckedChanged
        limpar_campos()
        carregar_codigo()
        MtbCpf.Enabled = True
        TxtCod.Enabled = False
        BtnConfirma.Visible = True
        BtnExibir.Visible = False
        BtnAlt.Visible = False
        BtnExc.Visible = False
        BtnRestSenha.Visible = False
        BtnAlt.Enabled = False
        BtnExc.Enabled = False
    End Sub
    Private Sub rbaltexcl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbAltExc.CheckedChanged
        MtbCpf.Enabled = False
        TxtCod.Enabled = True
        BtnExibir.Visible = True
        BtnAlt.Visible = True
        BtnExc.Visible = True
        BtnRestSenha.Visible = False
        BtnRestSenha.Enabled = False
        BtnConfirma.Visible = False
        limpar_campos()
    End Sub
    Private Sub pb_foto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbFoto.Click
        Dim OFD As New OpenFileDialog
        Try
            OFD.Filter = "Imagens (*.jpg;*.png)|*jpg;*png"
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                nomeimg = OFD.FileName
                PbFoto.Image = New System.Drawing.Bitmap(nomeimg)
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Mensagem.lbltitulo.Text = "Erro"
            Mensagem.lblmensagem.Text = "Ocorreu um erro durante o processamento de sua solicitação. A operação atual foi cancelada."
            Me.Enabled = False
            Mensagem.Show()
        End Try
    End Sub
    Private Sub btnConfiCadFunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfirma.Click
        Try
            If Validar_Campos() = False Then
                Exit Sub
            ElseIf Validar_Campos() = True Then
                If Validar_email() = False Then
                    Exit Sub
                ElseIf Validar_telefone_celular() = False Then
                    Exit Sub
                Else
                    If Cad_Funcionario() = True Then
                        MessageBox.Show("Cadastro efetuado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        limpar_campos()
                        carregar_codigo()
                    Else
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub btnalterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlt.Click
        Try
            If cod_func = TxtCod.Text Then
                If Validar_Campos() = False Then
                    Exit Sub
                ElseIf Validar_Campos() = True Then
                    If Validar_email() = False Then
                        Exit Sub
                    ElseIf Validar_telefone_celular() = False Then
                        Exit Sub
                    Else
                        If MessageBox.Show("Deseja realmente alterar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            If alt_func() = True Then
                                MessageBox.Show("Alteração efetuada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpar_campos()
                                BtnAlt.Enabled = False
                                BtnExc.Enabled = False
                                BtnRestSenha.Visible = False
                            Else
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            Else
                Mensagem.lbltitulo.Text = "Erro"
                Mensagem.lblmensagem.Text = "Código do funcionário modificado. A operação atual foi cancelada."
                limpar_campos()
                Me.Enabled = False
                Mensagem.Show()
                BtnAlt.Enabled = False
                BtnExc.Enabled = False
                BtnRestSenha.Visible = False
            End If
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Mensagem.lbltitulo.Text = "Erro"
            Mensagem.lblmensagem.Text = "Ocorreu um erro durante o processamento de sua solicitação. A operação atual foi cancelada."
            limpar_campos()
            Me.Enabled = False
            Mensagem.Show()
            BtnAlt.Enabled = False
            BtnExc.Enabled = False
            BtnRestSenha.Visible = False
        End Try
    End Sub
    Private Sub btnfechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfechar.Click
        If MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            inicio.Enabled = True
            Me.Close()
        End If
    End Sub
    Private Sub btnexibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExibir.Click
        Try
            PbFoto.Image = Nothing
            If TxtCod.Text.Trim = "" Then
                MessageBox.Show("Por favor digite o código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpar_campos()
                BtnAlt.Enabled = False
                BtnExc.Enabled = False
                BtnRestSenha.Visible = False
            Else
                cod_func = TxtCod.Text
                carregar_dados_inativos()
                If cod_func_rec <> 0 Then
                    If MessageBox.Show("Funcionário " & cod_func_rec & " atualmente está excluido. Deseja realmente restaurá-lo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        rec_func()
                        limpar_campos()
                        MessageBox.Show("Funcionário restaurado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cod_func_rec = 0
                    Else
                        limpar_campos()
                        cod_func_rec = 0
                    End If
                Else
                    carregar_dados_ativos()
                End If
            End If
        Catch ex As Exception
            Mensagem.lbltitulo.Text = "Erro"
            Mensagem.lblmensagem.Text = "Ocorreu um erro durante o processamento de sua solicitação. A operação atual foi cancelada."
            Me.Enabled = False
            Mensagem.Show()
            limpar_campos()
        End Try
    End Sub
    Private Sub mtbcep_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCep.LostFocus
        Carregar_cep()
    End Sub
    Private Sub BtnExc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExc.Click
        Try
            If cod_func = TxtCod.Text Then
                If MessageBox.Show("Deseja realmente excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    exc_func()
                    MessageBox.Show("Exclusão efetuada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpar_campos()
                    BtnAlt.Enabled = False
                    BtnExc.Enabled = False
                    BtnRestSenha.Visible = False
                End If
            Else
                Mensagem.lbltitulo.Text = "Erro"
                Mensagem.lblmensagem.Text = "Código do funcionário modificado. A operação atual foi cancelada."
                Me.Enabled = False
                Mensagem.Show()
                limpar_campos()
                BtnAlt.Enabled = False
                BtnExc.Enabled = False
                BtnRestSenha.Visible = False
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Mensagem.lbltitulo.Text = "Erro"
            Mensagem.lblmensagem.Text = "Ocorreu um erro durante o processamento de sua solicitação. A operação atual foi cancelada."
            limpar_campos()
            Me.Enabled = False
            Mensagem.Show()
            BtnAlt.Enabled = False
            BtnExc.Enabled = False
            BtnRestSenha.Visible = False
        End Try
    End Sub
    Private Sub txtnome_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNome.LostFocus
        Try
            TxtNome.Text = TxtNome.Text.Trim()
            If RbCad.Checked = True Then
                TxtUser.Text = TxtNome.Text.Substring(0, TxtNome.Text.IndexOf(" ")).ToLower + "_" + CStr(codigo)
            ElseIf RbAltExc.Checked = True Then
                TxtUser.Text = TxtNome.Text.Substring(0, TxtNome.Text.IndexOf(" ")).ToLower + "_" + CStr(cod_func)
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub Funcionario_KeyPress1(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNome.KeyPress, TxtEmail.KeyPress, TxtCep.KeyPress, TxtEnd.KeyPress, TxtCidade.KeyPress, TxtNum.KeyPress, TxtBairro.KeyPress, TxtCompl.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub
    Private Sub Funcionario_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        inicio.Enabled = True
        Exit Sub
    End Sub
    Private Sub Funcionario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If codigos.conscodfunc <> 0 Then
            cod_func = codigos.conscodfunc
            carregar_dados_ativos()
            TxtCod.Text = cod_func
            BtnAlt.Enabled = True
            BtnRestSenha.Enabled = True
            BtnExc.Enabled = True
            codigos.conscodfunc = 0
        ElseIf codigos.conscodfunc = 0 Then
            RbCad.Checked = True
            Exit Sub
        End If
    End Sub
    Private Sub BtnRestSenha_Click(sender As System.Object, e As System.EventArgs) Handles BtnRestSenha.Click
        If MessageBox.Show("Deseja realmente resetar senha?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            reset_senha()
            MessageBox.Show("Senha resetada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub TxtNome_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles TxtNome.TextChanged
        TxtNome.Text.Trim()
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
    Private Sub TxtNome_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNome.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Enabled = False
        Help_Funcionario.Show()
    End Sub
    Private Sub Funcionario_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNome.KeyPress, TxtEmail.KeyPress, TxtCep.KeyPress, TxtNum.KeyPress, TxtEnd.KeyPress, TxtCidade.KeyPress, TxtBairro.KeyPress, TxtCompl.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub
End Class