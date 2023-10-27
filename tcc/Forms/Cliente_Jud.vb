Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Cliente_Jud
    Dim cli_cnpj As String
    Dim codigo As Integer 'Usado para mostrar codigo
    Dim cod_cli As Integer
    Dim cnpj_comp As String
    Dim email_comp As String
    Dim senha As String
    Private Function Validar_Campos()
        Dim cnpj As String
        cnpj = Replace(MtbCnpj.Text.Trim, " ", "")
        Dim telefone As String
        telefone = Replace(MtbTel.Text.Trim, " ", "")
        Dim strRegex As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + "\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim re As New Regex(strRegex)
        If cnpj = "../-" Then
            MessageBox.Show("O campo CNPJ não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MtbCnpj.Focus()
            Return False
        ElseIf cnpj.Length < 18 Then
            MessageBox.Show("Por favor, digite corretamente o CNPJ.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MtbCnpj.Focus()
            Return False
        ElseIf TxtRazao.Text = "" Then
            MessageBox.Show("O campo razão social não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtRazao.Focus()
            Return False
        ElseIf TxtNomeFant.Text = "" Then
            MessageBox.Show("O campo nome fantasia não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNomeFant.Focus()
            Return False
        ElseIf telefone = "()-" Then
            MessageBox.Show("O campo telefone não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MtbTel.Focus()
            Return False
        ElseIf telefone.Length < 13 Then
            MessageBox.Show("Por favor, digite corretamente o telefone.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MtbTel.Focus()
            Return False
        ElseIf TxtEmail.Text.Trim = "" Then
            MessageBox.Show("O campo e-mail não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtEmail.Focus()
            Return False
        ElseIf Not (re.IsMatch(TxtEmail.Text.Trim)) Then
            MessageBox.Show("Por favor, digite corretamente o e-mail.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtEmail.Focus()
            Return False
        ElseIf TxtEnd.Text = "" Then
            MessageBox.Show("O campo endereço não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtEnd.Focus()
            Return False
        ElseIf TxtCidade.Text = "" Then
            MessageBox.Show("O campo cidade não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtCidade.Focus()
            Return False
        ElseIf CbUf.Text = "" Then
            MessageBox.Show("O campo UF não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbUf.Focus()
            Return False
        ElseIf TxtNum.Text = "" Then
            MessageBox.Show("O campo número não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNum.Focus()
            Return False
        ElseIf TxtBairro.Text = "" Then
            MessageBox.Show("O campo bairro não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBairro.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub limpar_campos()
        cli_cnpj = Nothing
        cod_cli = Nothing
        MtbCnpjAlt.Clear()
        TxtCod.Clear()
        MtbCnpj.Clear()
        TxtRazao.Clear()
        TxtNomeFant.Clear()
        MtbTel.Clear()
        TxtEmail.Clear()
        TxtSite.Clear()
        TxtCep.Clear()
        TxtEnd.Clear()
        TxtBairro.Clear()
        TxtCidade.Clear()
        TxtCompl.Clear()
        CbUf.SelectedIndex = -1
        TxtNum.Clear()
        cnpj_comp = Nothing
        email_comp = Nothing
    End Sub
    Private Sub carregar_codigo()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select top 1 cod_cli from cliente order by cod_cli desc"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                If mr.Read Then
                    codigo = mr!cod_cli
                    If codigo Mod 2 = 0 Then
                        codigo = codigo + 1
                    Else
                        codigo = codigo + 2
                    End If
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
    Private Function cad_clijud()
        Using cn As SqlConnection = conexao()
            Try
                Dim uf As String = ""
                uf = CbUf.SelectedItem
                cn.Open()
                Dim sql As String = "insert into cliente (cod_cli, nome, endereco, numero, complemento, cep, bairro, cidade, uf, telefone, email, senha, tipo_cli) values  ('" & codigo & "', '" & TxtNomeFant.Text & "','" & TxtEnd.Text & "', '" & TxtNum.Text & "', '" & TxtCompl.Text & "', '" & TxtCep.Text & "', '" & TxtBairro.Text & "',  '" & TxtCidade.Text & "',  '" & uf & "', '" & MtbTel.Text & "','" & TxtEmail.Text & "','" & senha & "', 'Jur')"
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
                cn.Open()
                Dim sql As String = "insert into cli_juridico (cnpj, razao_social, website, cod_cli) values  ('" & MtbCnpj.Text & "','" & TxtRazao.Text & "', '" & TxtSite.Text & "', '" & codigo & "')"
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
    Private Sub carregar_cep()
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
    Private Sub carregar_dados()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from cliente where cod_cli = " & cod_cli & " and tipo_cli = 'Jur'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    TxtNomeFant.Text = mr!nome
                    TxtEnd.Text = mr!endereco
                    TxtNum.Text = mr!numero
                    TxtCompl.Text = mr!complemento
                    TxtCep.Text = mr!cep
                    TxtBairro.Text = mr!bairro
                    TxtCidade.Text = mr!cidade
                    CbUf.Text = mr!uf
                    MtbTel.Text = mr!telefone
                    TxtEmail.Text = mr!email
                    email_comp = mr!email
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
            '-----------------------------------------------
            Try
                cn.Open()
                Dim sql As String = "select * from cli_juridico where cod_cli = " & cod_cli & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    MtbCnpj.Text = mr!cnpj
                    cnpj_comp = mr!cnpj
                    TxtRazao.Text = mr!razao_social
                    TxtSite.Text = mr!website
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Function alt_clijud_novo_email()
        Using cn As SqlConnection = conexao()
            Try
                Dim uf As String = ""
                uf = CbUf.SelectedItem
                cn.Open()
                Dim sql As String = "update cliente set nome = '" & TxtNomeFant.Text & "', endereco = '" & TxtEnd.Text & "', numero = '" & TxtNum.Text & "' , complemento = '" & TxtCompl.Text & "', cep = '" & TxtCep.Text & "', bairro = '" & TxtBairro.Text & "' , cidade = '" & TxtCidade.Text & "'  , uf = '" & uf & "', telefone = '" & MtbTel.Text & "' , email = '" & TxtEmail.Text & "', senha = '" & senha & "' where cod_cli = " & cod_cli & ""
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
                cn.Open()
                Dim sql As String = "update cli_juridico set razao_social = '" & TxtRazao.Text & "', website = '" & TxtSite.Text & "' where cod_cli = " & cod_cli & ""
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
    Private Function alt_clijud_normal()
        Using cn As SqlConnection = conexao()
            Try
                Dim uf As String = ""
                uf = CbUf.SelectedItem
                cn.Open()
                Dim sql As String = "update cliente set nome = '" & TxtNomeFant.Text & "', endereco = '" & TxtEnd.Text & "', numero = '" & TxtNum.Text & "' , complemento = '" & TxtCompl.Text & "', cep = '" & TxtCep.Text & "', bairro = '" & TxtBairro.Text & "' , cidade = '" & TxtCidade.Text & "'  , uf = '" & uf & "', telefone = '" & MtbTel.Text & "' , email = '" & TxtEmail.Text & "' where cod_cli = " & cod_cli & ""
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
                cn.Open()
                Dim sql As String = "update cli_juridico set razao_social = '" & TxtRazao.Text & "', website = '" & TxtSite.Text & "' where cod_cli = " & cod_cli & ""
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
    Private Sub pegar_cod_clijud()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select cod_cli from cli_juridico where cnpj = '" & MtbCnpjAlt.Text & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                If mr.Read Then
                    cod_cli = mr!cod_cli
                    BtnAlt.Enabled = True
                Else
                    MessageBox.Show("Cliente não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cod_cli = Nothing
                    limpar_campos()
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
    Private Function comparar_cnpj()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select cnpj from cli_juridico"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    Do While MtbCnpj.Text = mr!cnpj
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
    Private Sub mtbcpf_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MtbCnpj.LostFocus
        Dim cnpj1 As New Valida_CPF_CNPJ
        cnpj1.cnpj = CStr(MtbCnpj.Text)
        Dim cnpj_ As String
        cnpj_ = Replace(MtbCnpj.Text, " ", "")
        If cnpj_ = "../-" Then
            Exit Sub
        Else
            If cnpj_comp = MtbCnpj.Text Then
                Exit Sub
            Else
                If comparar_cnpj() = True Then
                    If cnpj1.isCnpjValido = False Then
                        MessageBox.Show("CNPJ inválido. Operação atual não prosseguida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        MtbCnpj.Clear()
                        MtbCnpj.Focus()
                    End If
                Else
                    MessageBox.Show("CNPJ já cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MtbCnpj.Clear()
                    MtbCnpj.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub mtbcep_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCep.LostFocus
        carregar_cep()
    End Sub
    Private Sub btnconfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfirma.Click
        If Validar_Campos() = False Then
            Exit Sub
        ElseIf Validar_Campos() = True Then
            gerasenha()
            If cad_clijud() = True Then
                MessageBox.Show("Senha gerada para este cliente: " & senha & "", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("Cadastro efetuado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpar_campos()
                carregar_codigo()
            Else
                Exit Sub
            End If
        End If
    End Sub
    Private Sub btnfechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFechar.Click
        If MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            inicio.Enabled = True
            Me.Close()
        End If
    End Sub
    Private Sub btnexibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExibir.Click
        Try
            Dim cnpj As String
            cnpj = Replace(MtbCnpjAlt.Text, " ", "")
            If cnpj = "../-" Then
                MessageBox.Show("Por favor digite o CNPJ.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpar_campos()
                MtbCnpj.Focus()
                BtnAlt.Enabled = False
            ElseIf cnpj.Length < 18 Then
                MessageBox.Show("Por favor, digite corretamente o CNPJ.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                MtbCnpj.Focus()
                BtnAlt.Enabled = False
                TxtCod.Clear()
                MtbCnpj.Clear()
                TxtRazao.Clear()
                TxtNomeFant.Clear()
                MtbTel.Clear()
                TxtEmail.Clear()
                TxtSite.Clear()
                TxtCep.Clear()
                TxtEnd.Clear()
                TxtBairro.Clear()
                TxtCidade.Clear()
                TxtCompl.Clear()
                CbUf.SelectedIndex = -1
                TxtNum.Clear()
                cnpj_comp = Nothing
                email_comp = Nothing
            Else
                pegar_cod_clijud()
                cli_cnpj = MtbCnpjAlt.Text
                carregar_dados()
            End If
        Catch ex As Exception
            Mensagem.lbltitulo.Text = "Erro"
            Mensagem.lblmensagem.Text = "Ocorreu um erro durante o processamento de sua solicitação. A operação atual foi cancelada."
            Mensagem.Show()
            Me.Enabled = False
            limpar_campos()
        End Try
    End Sub
    Private Sub btnalterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlt.Click
        If cli_cnpj = MtbCnpjAlt.Text Then
            If Validar_Campos() = False Then
                Exit Sub
            ElseIf Validar_Campos() = True Then
                If email_comp <> TxtEmail.Text.Trim Then
                    gerasenha()
                    If MessageBox.Show("Deseja realmente alterar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If alt_clijud_novo_email() = True Then
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
                        If alt_clijud_normal() = True Then
                            MessageBox.Show("Alteração efetuada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            limpar_campos()
                            BtnAlt.Enabled = False
                        Else
                            Exit Sub
                        End If
                    End If
                End If
            End If
        Else
            Mensagem.lbltitulo.Text = "Erro"
            Mensagem.lblmensagem.Text = "CNPJ do cliente modificado. A operação atual foi cancelada."
            Mensagem.Show()
            Me.Enabled = False
            limpar_campos()
            BtnAlt.Enabled = False
        End If
    End Sub
    Private Sub rbcadastro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbCad.CheckedChanged
        limpar_campos()
        carregar_codigo()
        MtbCnpj.Enabled = True
        TxtCod.Enabled = False
        BtnConfirma.Visible = True
        BtnExibir.Visible = False
        BtnAlt.Visible = False
        BtnAlt.Enabled = False
        LblMsg.Text = "Código do Cadastro:"
        MtbCnpjAlt.Visible = False
        TxtCod.Visible = True
    End Sub
    Private Sub rbaltexcl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbAltExc.CheckedChanged
        limpar_campos()
        MtbCnpj.Enabled = False
        TxtCod.Enabled = True
        BtnExibir.Visible = True
        BtnAlt.Visible = True
        BtnConfirma.Visible = False
        LblMsg.Text = "CNPJ do Cadastro:"
        MtbCnpjAlt.Visible = True
        TxtCod.Visible = False
    End Sub
    Private Sub Cliente_Jud_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRazao.KeyPress, TxtNomeFant.KeyPress, TxtEmail.KeyPress, TxtSite.KeyPress, TxtCep.KeyPress, TxtBairro.KeyPress, TxtCidade.KeyPress, TxtNum.KeyPress, TxtEnd.KeyPress, TxtCompl.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub
    Private Sub Cliente_Jud_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        inicio.Enabled = True
        Exit Sub
    End Sub
    Private Sub ClienteJud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If codigos.conscodclijud <> 0 Then
            cod_cli = codigos.conscodclijud
            cli_cnpj = codigos.cnpjclijud
            carregar_dados()
            TxtCod.Text = cod_cli
            MtbCnpjAlt.Text = cli_cnpj
            BtnAlt.Enabled = True
            codigos.conscodclijud = 0
        ElseIf codigos.conscodclijud = 0 Then
            RbCad.Checked = True
            Exit Sub
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
        Help_Cli_Jud.Show()
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
    '        MessageBox.Show("E-mail enviado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        objEmail.Dispose()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End Try
    'End Sub

    Private Sub GroupBox3_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class