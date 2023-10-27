Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Motorista
    Dim codigomoto As Integer 'usando para veiculo tbm
    Dim cod_moto As Integer
    Dim nomeimg As String
    Dim cod_moto_rec As Integer
    Dim cpf_comp As String
    Private Sub limpar_campos()
        cpf_comp = Nothing
        cod_moto = Nothing
        TxtNome.Clear()
        MtbCpf.Clear()
        txtrg.Clear()
        RbMasc.Checked = True
        MtbCnh.Clear()
        TxtCategoria.Clear()
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
        TxtModelo.Clear()
        TxtMarca.Clear()
        TxtObs.Clear()
        TxtCor.Clear()
        MtbPlaca.Clear()
        TxtCod.Clear()
        DtpData.Text = Today
        mtbano.Clear()
        nomeimg = ""
        PbFoto.Image = Nothing
        rbnao.Checked = True
    End Sub
    Private Function Validar_Campos()
        Dim cpf As String
        cpf = Replace(MtbCpf.Text.Trim, " ", "")
        Dim birthdate As Date = DtpData.Value
        Dim years As Integer = DateTime.Now.Year - birthdate.Year
        If DateTime.Now.Month < birthdate.Month Or (DateTime.Now.Month = birthdate.Month And DateTime.Now.Day < birthdate.Day) Then
            years = years - 1
        End If
        If TxtNome.Text.Trim = "" Then
            MessageBox.Show("O campo nome não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNome.Focus()
            Return False
            'ElseIf Now.Year - DtpData.Value.Year < 18 Then
        ElseIf years < 18 Then
            MessageBox.Show("O motorista não pode ter menos que 18 anos de idade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DtpData.Focus()
            Return False
        ElseIf cpf = "..-" Then
            MessageBox.Show("O campo CPF não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MtbCpf.Focus()
            Return False
        ElseIf cpf.Length < 14 Then
            MessageBox.Show("Por favor, digite corretamente o CPF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MtbCpf.Focus()
            Return False
        ElseIf txtrg.Text.Trim = "" Then
            MessageBox.Show("O campo RG não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtrg.Focus()
            Return False
        ElseIf txtrg.Text.Trim.Length < 9 Then
            MessageBox.Show("Por favor, digite corretamente o RG .", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtrg.Focus()
            Return False
        ElseIf MtbCnh.Text.Trim = "" Then
            MessageBox.Show("O campo CNH não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MtbCnh.Focus()
            Return False
        ElseIf MtbCnh.Text.Trim.Length < 11 Then
            MessageBox.Show("Por favor, digite corretamente o CNH.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MtbCnh.Focus()
            Return False
        ElseIf TxtCategoria.Text.Trim = "" Then
            MessageBox.Show("O campo categoria não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtCategoria.Focus()
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
        ElseIf TxtModelo.Text.Trim = "" Then
            MessageBox.Show("O campo modelo não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtModelo.Focus()
            Return False
        ElseIf mtbano.Text.Trim.Length < 4 Then
            MessageBox.Show("Por favor, digite corretamente o ano do veiculo .", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mtbano.Focus()
            Return False
        ElseIf TxtMarca.Text.Trim = "" Then
            MessageBox.Show("O campo marca não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtMarca.Focus()
            Return False
        ElseIf TxtCor.Text.Trim = "" Then
            MessageBox.Show("O campo cor não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtCor.Focus()
            Return False
        ElseIf MtbPlaca.Text.Trim = "" Then
            MessageBox.Show("O campo placa não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBairro.Focus()
            Return False
        ElseIf MtbPlaca.Text.Trim.Length < 7 Then
            MessageBox.Show("Por favor, digite corretamente a placa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MtbPlaca.Focus()
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
                Dim sql As String = "select top 1 cod_moto from motorista order by cod_moto desc"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                If mr.Read Then
                    codigomoto = mr!cod_moto + 1
                    RbAltExc.Visible = True
                    If codigomoto = 1 Then
                        codigomoto = 1
                        RbAltExc.Visible = False
                    End If
                End If
                TxtCod.Text = codigomoto
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
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
                    CbUf.Text = mr!UF
                    TxtEnd.Text = mr!Descricao
                    TxtCidade.Text = mr!Cidade
                    TxtBairro.Text = mr!Bairro
                End While
            Catch ex As Exception
                ' MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Function cad_motorista_veiculo()
        Using cn As SqlConnection = conexao()
            Try
                Dim blindao As String = ""
                If rbsim.Checked = True Then
                    blindao = True
                ElseIf rbnao.Checked = True Then
                    blindao = False
                End If
                cn.Open()
                Dim sql As String = "insert into veiculo (cor, ano, marca, modelo, cod_veic, placa, desc_veic, condicao, blindagem) values  ('" & TxtCor.Text & "',  '" & mtbano.Text & "', '" & TxtMarca.Text & "', '" & TxtModelo.Text & "', '" & codigomoto & "', '" & MtbPlaca.Text & "' , '" & TxtObs.Text & "', '" & True & "', '" & blindao & "' )"
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
                Dim sexo As String = ""
                Dim uf As String = ""
                uf = CbUf.SelectedItem
                If RbMasc.Checked = True Then
                    sexo = "M"
                ElseIf RbFem.Checked = True Then
                    sexo = "F"
                End If
                cn.Open()
                Dim sql As String = "insert into motorista (cod_moto, img_local, nome ,sexo, cpf, rg, endereco, numero, complemento, cep, bairro, cidade, uf, data_nasc, cart_moto, tipo_categoria,telefone,celular, email,cod_veic, condicao, Status_Moto, status_corrida) values  ('" & codigomoto & "' ,'" & nomeimg & "', '" & TxtNome.Text & "' , '" & sexo & "', '" & MtbCpf.Text & "', '" & txtrg.Text & "', '" & TxtEnd.Text & "', '" & TxtNum.Text & "', '" & TxtCompl.Text & "', '" & TxtCep.Text & "', '" & TxtBairro.Text & "', '" & TxtCidade.Text & "', '" & uf & "', '" & DtpData.Text & "', '" & MtbCnh.Text & "', '" & TxtCategoria.Text.ToUpper & "','" & MtbTel.Text & "' ,'" & MtbCel.Text & "' ,'" & TxtEmail.Text & "' ,'" & codigomoto & "','" & True & "', '" & True & "', '" & False & "')"
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
    Private Sub carregar_dados()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sexo As String = ""
                Dim sql As String = "select * from  motorista where cod_moto = " & cod_moto & " and condicao = '" & True & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                If mr.Read Then
                    nomeimg = mr!img_local
                    TxtNome.Text = mr!nome
                    sexo = mr!sexo
                    If sexo = "F" Then
                        RbFem.Checked = True
                    ElseIf sexo = "M" Then
                        RbMasc.Checked = True
                    End If
                    MtbCpf.Text = mr!cpf
                    txtrg.Text = mr!rg
                    TxtEnd.Text = mr!endereco
                    TxtNum.Text = mr!numero
                    TxtCompl.Text = mr!complemento
                    TxtCep.Text = mr!cep
                    TxtBairro.Text = mr!bairro
                    TxtCidade.Text = mr!cidade
                    CbUf.Text = mr!uf
                    DtpData.Text = mr!data_nasc
                    MtbCnh.Text = mr!cart_moto
                    TxtCategoria.Text = mr!tipo_categoria
                    MtbTel.Text = mr!telefone
                    MtbCel.Text = mr!celular
                    TxtEmail.Text = mr!email
                    BtnAlterar.Enabled = True
                    BtnExcluir.Enabled = True
                    cpf_comp = mr!cpf
                Else
                    MessageBox.Show("Motorista não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    limpar_campos()
                End If
                '---------------------------------------
                Try
                    PbFoto.Image = New System.Drawing.Bitmap(nomeimg)
                Catch ex1 As Exception
                End Try
                '---------------------------------------
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
            '---------------------------------------
            Try
                Dim blindagem As String = ""
                cn.Open()
                Dim sql As String = "select * from veiculo where cod_veic = " & cod_moto & " and condicao = '" & True & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    MtbPlaca.Text = mr!placa
                    TxtObs.Text = mr!desc_veic
                    TxtCor.Text = mr!cor
                    TxtModelo.Text = mr!modelo
                    TxtMarca.Text = mr!marca
                    mtbano.Text = mr!ano
                    blindagem = mr!blindagem
                    If blindagem = "True" Then
                        rbsim.Checked = True
                    ElseIf blindagem = "False" Then
                        rbnao.Checked = True
                    End If
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Function alt_moto_veic()

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
                Dim sql As String = "update motorista set img_local = '" & nomeimg & "', nome = '" & TxtNome.Text & "', sexo = '" & sexo & "', rg = '" & txtrg.Text & "', endereco = '" & TxtEnd.Text & "', numero = '" & TxtNum.Text & "',  complemento = '" & TxtCompl.Text & "', cep = '" & TxtCep.Text & "', bairro = '" & TxtBairro.Text & "', cidade = '" & TxtCidade.Text & "', uf = '" & uf & "', data_nasc = '" & DtpData.Text & "', cart_moto = '" & MtbCnh.Text & "', tipo_categoria = '" & TxtCategoria.Text.ToUpper & "', telefone = '" & MtbTel.Text & "', celular = '" & MtbCel.Text & "' , email ='" & TxtEmail.Text & "' where cod_moto = '" & cod_moto & "' "
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
            '--------------------------------------------------------
            Try
                Dim blindagem As String = ""
                If rbsim.Checked = True Then
                    blindagem = True
                ElseIf rbnao.Checked = True Then
                    blindagem = False
                End If
                cn.Open()
                Dim sql As String = "update veiculo set ano = '" & mtbano.Text & "' , modelo = '" & TxtModelo.Text & "', cor = '" & TxtCor.Text & "', marca = '" & TxtMarca.Text & "', placa = '" & MtbPlaca.Text & "', desc_veic = '" & TxtObs.Text & "', blindagem = '" & blindagem & "' where cod_veic = " & cod_moto & " "
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
    Private Sub exc_moto()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "update veiculo set condicao = '" & False & "' where cod_veic = " & cod_moto & ""
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
                Dim sql As String = "update motorista set condicao = '" & False & "' where cod_moto = " & cod_moto & ""
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
                Dim sql As String = "select cpf from motorista"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    Do While MtbCpf.Text = mr!cpf
                        Return False
                    Loop
                End While
            Catch ex As Exception
                'MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
    Private Sub carregar_dados_inativos()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select cod_moto from  motorista where cod_moto = " & TxtCod.Text & " and condicao = '" & False & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    cod_moto_rec = mr!cod_moto
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub rec_moto()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = " update veiculo set condicao = '" & True & "' where cod_veic = " & cod_moto_rec & ""
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
                Dim sql As String = "update motorista set condicao = '" & True & "' where cod_moto = " & cod_moto_rec & ""
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
    Private Sub mtbcep_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCep.LostFocus
        carregar_cep()
    End Sub
    Private Sub btnfechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfechar.Click
        If MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            inicio.Enabled = True
            Me.Close()
        End If
    End Sub
    Private Sub btnexibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExibir.Click
        Try
            If TxtCod.Text.Trim = "" Then
                MessageBox.Show("Por favor digite o código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpar_campos()
                BtnAlterar.Enabled = False
                BtnExcluir.Enabled = False
            Else
                cod_moto = TxtCod.Text
                carregar_dados_inativos()
                If cod_moto_rec <> 0 Then
                    If MessageBox.Show("Motorista " & cod_moto & " atualmente está excluido. Deseja realmente restaurá-lo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        rec_moto()
                        limpar_campos()
                        MessageBox.Show("Motorista restaurado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cod_moto_rec = 0
                    Else
                        limpar_campos()
                        cod_moto_rec = 0
                    End If
                Else
                    carregar_dados()
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show("Motorista não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Mensagem.lbltitulo.Text = "Erro"
            Mensagem.lblmensagem.Text = "Ocorreu um erro durante o processamento de sua solicitação. A operação atual foi cancelada."
            Me.Enabled = False
            Mensagem.Show()
            limpar_campos()
        End Try
    End Sub
    Private Sub btnalterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlterar.Click
        Try
            If cod_moto = TxtCod.Text Then
                If Validar_Campos() = False Then
                    Exit Sub
                ElseIf Validar_Campos() = True Then
                    If Validar_email() = False Then
                        Exit Sub
                    ElseIf Validar_telefone_celular() = False Then
                        Exit Sub
                    Else
                        If MessageBox.Show("Deseja realmente alterar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            If alt_moto_veic() = True Then
                                MessageBox.Show("Alteração efetuada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpar_campos()
                                BtnAlterar.Enabled = False
                                BtnExcluir.Enabled = False
                            Else
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            Else
                'MessageBox.Show("Código do motorista modificado. Operação cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Mensagem.lbltitulo.Text = "Erro"
                Mensagem.lblmensagem.Text = "Código do motorista modificado. A operação atual foi cancelada."
                Me.Enabled = False
                Mensagem.Show()
                limpar_campos()
                BtnAlterar.Enabled = False
                BtnExcluir.Enabled = False
            End If
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Mensagem.lbltitulo.Text = "Erro"
            Mensagem.lblmensagem.Text = "Ocorreu um erro durante o processamento de sua solicitação. A operação atual foi cancelada."
            limpar_campos()
            Me.Enabled = False
            Mensagem.Show()
            BtnAlt.Enabled = False
            BtnExcluir.Enabled = False
        End Try
    End Sub
    Private Sub rbcadastro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbCad.CheckedChanged
        limpar_campos()
        carregar_codigo()
        MtbCpf.Enabled = True
        TxtCod.Enabled = False
        BtnConfirma.Visible = True
        BtnExibir.Visible = False
        BtnAlterar.Visible = False
        BtnExcluir.Visible = False
        BtnAlterar.Enabled = False
        BtnExcluir.Enabled = False
    End Sub
    Private Sub rbaltexcl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbAltExc.CheckedChanged
        MtbCpf.Enabled = False
        TxtCod.Enabled = True
        BtnExibir.Visible = True
        BtnAlterar.Visible = True
        BtnExcluir.Visible = True
        BtnConfirma.Visible = False
        limpar_campos()
    End Sub
    Private Sub btnconfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfirma.Click
        Try
            If Validar_Campos() = False Then
                Exit Sub
            ElseIf Validar_Campos() = True Then
                If Validar_email() = False Then
                    Exit Sub
                ElseIf Validar_telefone_celular() = False Then
                    Exit Sub
                Else
                    If cad_motorista_veiculo() = True Then
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
    Private Sub pb_foto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbFoto.Click
        Dim OFD As New OpenFileDialog
        Try
            OFD.Filter = "Imagens (*.jpg;*.png)|*jpg;*png"
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                nomeimg = OFD.FileName
                PbFoto.Image = New System.Drawing.Bitmap(nomeimg)
            End If
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Mensagem.lbltitulo.Text = "Erro"
            Mensagem.lblmensagem.Text = "Ocorreu um erro durante o processamento de sua solicitação. A operação atual foi cancelada."
            Me.Enabled = False
            Mensagem.Show()
        End Try
    End Sub
    Private Sub btnexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcluir.Click
        Try
            If cod_moto = TxtCod.Text Then
                If MessageBox.Show("Deseja realmente excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    exc_moto()
                    MessageBox.Show("Exclusão efetuada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpar_campos()
                    BtnAlterar.Enabled = False
                    BtnExcluir.Enabled = False
                End If
            Else
                'MessageBox.Show("Código do motorista modificado. Operação cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Mensagem.lbltitulo.Text = "Erro"
                Mensagem.lblmensagem.Text = "Código do motorista modificado. A operação atual foi cancelada."
                Me.Enabled = False
                Mensagem.Show()
                limpar_campos()
                BtnAlterar.Enabled = False
                BtnExcluir.Enabled = False
            End If
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Mensagem.lbltitulo.Text = "Erro"
            Mensagem.lblmensagem.Text = "Ocorreu um erro durante o processamento de sua solicitação. A operação atual foi cancelada."
            limpar_campos()
            Me.Enabled = False
            Mensagem.Show()
            BtnAlt.Enabled = False
            BtnExcluir.Enabled = False
        End Try
    End Sub
    Private Sub Motorista_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNome.KeyPress, TxtEmail.KeyPress, TxtEnd.KeyPress, TxtCep.KeyPress, TxtCidade.KeyPress, TxtNum.KeyPress, TxtBairro.KeyPress, TxtCompl.KeyPress, TxtModelo.KeyPress, TxtMarca.KeyPress, TxtCor.KeyPress, TxtObs.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub
    Private Sub Motorista_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        inicio.Enabled = True
        Exit Sub
    End Sub
    Private Sub Motorista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If codigos.conscodmoto <> 0 Then
            cod_moto = codigos.conscodmoto
            carregar_dados()
            TxtCod.Text = cod_moto
            BtnAlterar.Enabled = True
            BtnExcluir.Enabled = True
            codigos.conscodmoto = 0
        ElseIf codigos.conscodmoto = 0 Then
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
    Private Sub TxtNome_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNome.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Enabled = False
        Help_Motorista.Show()
    End Sub
    Private Sub TxtCategoria_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCategoria.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub
End Class