Imports System.Data.SqlClient
Public Class Consultas
    Dim filtro As String
    Dim conscod As Integer
    Dim nomeimgfunc As String
    'Private Sub Carrega_imagem()
    '    Dim img As Image
    '    For colun As Integer = 0 To dgvconsuta.RowCount - 1
    '        If dgvconsuta.Rows(colun).Cells("img_local").Value.ToString = "" Then
    '            img = imagem.Image
    '            dgvconsuta.Rows(colun).Cells("imagem").Value = img
    '        Else
    '            img = Image.FromFile(dgvconsuta.Rows(colun).Cells("img_local").Value.ToString)
    '            dgvconsuta.Rows(colun).Cells("imagem").Value = img
    '        End If
    '    Next
    'End Sub
    '===========================================================
    '================================FUNCIONÁRIO================================
    '===========================================================
    Private Sub cons_nome_func_inativo()
        Using cn As SqlConnection = conexao()
            DgvConsulta.DataSource = ""
            If (filtro = "Nome") Then
                Try
                    cn.Open()
                    Dim sql As String = "select funcionario.img_local, funcionario.Cod_func as Código, funcionario.Nome, funcionario.CPF, funcionario.Sexo, funcionario.RG, funcionario.Data_nasc as [Data de Nascimento], funcionario.Endereco as Endereço, funcionario.Numero as Número, funcionario.Complemento, funcionario.CEP, funcionario.Bairro, funcionario.Cidade, funcionario.UF, funcionario.Telefone, funcionario.Celular, funcionario.Email,  tblogin.usuario as Usuário, tblogin.nivel as Nível from funcionario inner join tblogin on funcionario.cod_func = tblogin.cod_func where funcionario.nome like '%" & TxtFiltro.Text & "%'  and funcionario.condicao = '" & False & "' order by funcionario.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            End If
        End Using
    End Sub
    Private Sub cons_nome_func_ativo()
        Using cn As SqlConnection = conexao()
            DgvConsulta.DataSource = ""
            If (filtro = "Nome") Then
                Try
                    cn.Open()
                    Dim sql As String = "select funcionario.img_local, funcionario.Cod_func as Código, funcionario.Nome, funcionario.CPF, funcionario.Sexo, funcionario.RG, funcionario.Data_nasc as [Data de Nascimento], funcionario.Endereco as Endereço, funcionario.Numero as Número, funcionario.Complemento, funcionario.CEP, funcionario.Bairro, funcionario.Cidade, funcionario.UF, funcionario.Telefone, funcionario.Celular, funcionario.Email,  tblogin.usuario as Usuário, tblogin.nivel as Nível from funcionario inner join tblogin on funcionario.cod_func = tblogin.cod_func where funcionario.nome like '%" & TxtFiltro.Text & "%' and funcionario.condicao = '" & True & "' order by funcionario.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            End If
        End Using
    End Sub
    Private Sub cons_funcionario_inativo()
        Using cn As SqlConnection = conexao()
            DgvConsulta.DataSource = ""
            If (filtro = "Código") Then
                Try
                    cn.Open()
                    Dim sql As String = "select funcionario.img_local, funcionario.Cod_func as Código, funcionario.Nome, funcionario.CPF, funcionario.Sexo, funcionario.RG, funcionario.Data_nasc as [Data de Nascimento], funcionario.Endereco as Endereço, funcionario.Numero as Número, funcionario.Complemento, funcionario.CEP, funcionario.Bairro, funcionario.Cidade, funcionario.UF, funcionario.Telefone, funcionario.Celular, funcionario.Email,  tblogin.usuario as Usuário, tblogin.nivel as Nível from funcionario inner join tblogin on funcionario.cod_func = tblogin.cod_func where funcionario.cod_func = '" & TxtFiltro.Text & "'  and funcionario.condicao = '" & False & "'order by funcionario.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "Nome") Then
                Try
                    cn.Open()
                    Dim sql As String = "select funcionario.img_local, funcionario.Cod_func as Código, funcionario.Nome, funcionario.CPF, funcionario.Sexo, funcionario.RG, funcionario.Data_nasc as [Data de Nascimento], funcionario.Endereco as Endereço, funcionario.Numero as Número, funcionario.Complemento, funcionario.CEP, funcionario.Bairro, funcionario.Cidade, funcionario.UF, funcionario.Telefone, funcionario.Celular, funcionario.Email,  tblogin.usuario as Usuário, tblogin.nivel as Nível from funcionario inner join tblogin on funcionario.cod_func = tblogin.cod_func where funcionario.nome like '%" & TxtFiltro.Text & "%'  and funcionario.condicao = '" & False & "' order by funcionario.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "CPF") Then
                Try
                    cn.Open()
                    Dim sql As String = "select funcionario.img_local, funcionario.Cod_func as Código, funcionario.Nome, funcionario.CPF, funcionario.Sexo, funcionario.RG, funcionario.Data_nasc as [Data de Nascimento], funcionario.Endereco as Endereço, funcionario.Numero as Número, funcionario.Complemento, funcionario.CEP, funcionario.Bairro, funcionario.Cidade, funcionario.UF, funcionario.Telefone, funcionario.Celular, funcionario.Email,  tblogin.usuario as Usuário, tblogin.nivel as Nível from funcionario inner join tblogin on funcionario.cod_func = tblogin.cod_func where funcionario.cpf like '%" & TxtFiltro.Text & "%'  and funcionario.condicao = '" & False & "' order by funcionario.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "RG") Then
                Try
                    cn.Open()
                    Dim sql As String = "select funcionario.img_local, funcionario.Cod_func as Código, funcionario.Nome, funcionario.CPF, funcionario.Sexo, funcionario.RG, funcionario.Data_nasc as [Data de Nascimento], funcionario.Endereco as Endereço, funcionario.Numero as Número, funcionario.Complemento, funcionario.CEP, funcionario.Bairro, funcionario.Cidade, funcionario.UF, funcionario.Telefone, funcionario.Celular, funcionario.Email,  tblogin.usuario as Usuário, tblogin.nivel as Nível from funcionario inner join tblogin on funcionario.cod_func = tblogin.cod_func where funcionario.rg like '%" & TxtFiltro.Text & "%'  and funcionario.condicao = '" & False & "' order by funcionario.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            Else
                Try
                    cn.Open()
                    Dim sql As String = "select funcionario.img_local, funcionario.Cod_func as Código, funcionario.Nome, funcionario.CPF, funcionario.Sexo, funcionario.RG, funcionario.Data_nasc as [Data de Nascimento], funcionario.Endereco as Endereço, funcionario.Numero as Número, funcionario.Complemento, funcionario.CEP, funcionario.Bairro, funcionario.Cidade, funcionario.UF, funcionario.Telefone, funcionario.Celular, funcionario.Email,  tblogin.usuario as Usuário, tblogin.nivel as Nível from funcionario inner join tblogin on funcionario.cod_func = tblogin.cod_func where funcionario.condicao = '" & False & "' order by funcionario.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            End If
        End Using
    End Sub
    Private Sub cons_funcionario_ativo()
        Using cn As SqlConnection = conexao()
            DgvConsulta.DataSource = ""
            If (filtro = "Código") Then
                Try
                    cn.Open()
                    Dim sql As String = "select funcionario.img_local, funcionario.Cod_func as Código, funcionario.Nome, funcionario.CPF, funcionario.Sexo, funcionario.RG, funcionario.Data_nasc as [Data de Nascimento], funcionario.Endereco as Endereço, funcionario.Numero as Número, funcionario.Complemento, funcionario.CEP, funcionario.Bairro, funcionario.Cidade, funcionario.UF, funcionario.Telefone, funcionario.Celular, funcionario.Email,  tblogin.usuario as Usuário, tblogin.nivel as Nível from funcionario inner join tblogin on funcionario.cod_func = tblogin.cod_func where funcionario.cod_func = '" & TxtFiltro.Text & "'  and funcionario.condicao = '" & True & "' order by funcionario.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "Nome") Then
                Try
                    cn.Open()
                    Dim sql As String = "select funcionario.img_local, funcionario.Cod_func as Código, funcionario.Nome, funcionario.CPF, funcionario.Sexo, funcionario.RG, funcionario.Data_nasc as [Data de Nascimento], funcionario.Endereco as Endereço, funcionario.Numero as Número, funcionario.Complemento, funcionario.CEP, funcionario.Bairro, funcionario.Cidade, funcionario.UF, funcionario.Telefone, funcionario.Celular, funcionario.Email,  tblogin.usuario as Usuário, tblogin.nivel as Nível from funcionario inner join tblogin on funcionario.cod_func = tblogin.cod_func where funcionario.nome like '%" & TxtFiltro.Text & "%'  and funcionario.condicao = '" & True & "' order by funcionario.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "CPF") Then
                Try
                    cn.Open()
                    Dim sql As String = "select funcionario.img_local, funcionario.Cod_func as Código, funcionario.Nome, funcionario.CPF, funcionario.Sexo, funcionario.RG, funcionario.Data_nasc as [Data de Nascimento], funcionario.Endereco as Endereço, funcionario.Numero as Número, funcionario.Complemento, funcionario.CEP, funcionario.Bairro, funcionario.Cidade, funcionario.UF, funcionario.Telefone, funcionario.Celular, funcionario.Email,  tblogin.usuario as Usuário, tblogin.nivel as Nível from funcionario inner join tblogin on funcionario.cod_func = tblogin.cod_func where funcionario.cpf like '%" & TxtFiltro.Text & "%'  and funcionario.condicao = '" & True & "' order by funcionario.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "RG") Then
                Try
                    cn.Open()
                    Dim sql As String = "select funcionario.img_local, funcionario.Cod_func as Código, funcionario.Nome, funcionario.CPF, funcionario.Sexo, funcionario.RG, funcionario.Data_nasc as [Data de Nascimento], funcionario.Endereco as Endereço, funcionario.Numero as Número, funcionario.Complemento, funcionario.CEP, funcionario.Bairro, funcionario.Cidade, funcionario.UF, funcionario.Telefone, funcionario.Celular, funcionario.Email,  tblogin.usuario as Usuário, tblogin.nivel as Nível from funcionario inner join tblogin on funcionario.cod_func = tblogin.cod_func where funcionario.rg like '%" & TxtFiltro.Text & "%'  and funcionario.condicao = '" & True & "' order by funcionario.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            Else
                Try
                    cn.Open()
                    Dim sql As String = "select funcionario.img_local, funcionario.Cod_func as Código, funcionario.Nome, funcionario.CPF, funcionario.Sexo, funcionario.RG, funcionario.Data_nasc as [Data de Nascimento], funcionario.Endereco as Endereço, funcionario.Numero as Número, funcionario.Complemento, funcionario.CEP, funcionario.Bairro, funcionario.Cidade, funcionario.UF, funcionario.Telefone, funcionario.Celular, funcionario.Email,  tblogin.usuario as Usuário, tblogin.nivel as Nível from funcionario inner join tblogin on funcionario.cod_func = tblogin.cod_func where funcionario.condicao = '" & True & "' order by funcionario.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            End If
        End Using
    End Sub
    '===========================================================
    '================================MOTORISTA================================
    '===========================================================
    Private Sub cons_nome_moto_ativo()
        Using cn As SqlConnection = conexao()
            DgvConsulta.DataSource = ""
            If (filtro = "Nome") Then
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.img_local, motorista.cod_moto as [Código do Motorista], motorista.Nome, motorista.Sexo, motorista.CPF, motorista.RG, motorista.endereco as Endereço, motorista.numero as Número, motorista.Complemento , motorista.CEP, motorista.Bairro, motorista.Cidade, motorista.UF, motorista.data_nasc as [Data de nascimento], motorista.Telefone, motorista.Celular, motorista.Email as [E-mail], motorista.cart_moto as [Número da CNH], motorista.tipo_categoria as [Categoria da CNH], veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.Placa , veiculo.Cor, veiculo.desc_veic as [Observações], veiculo.Blindagem, motorista.Status_Moto [Status]  from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where motorista.nome like '%" & TxtFiltro.Text & "%' and motorista.Condicao = '" & True & "' order by motorista.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            End If
        End Using
    End Sub
    Private Sub cons_nome_moto_inativo()
        Using cn As SqlConnection = conexao()
            DgvConsulta.DataSource = ""
            If (filtro = "Nome") Then
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.img_local, motorista.cod_moto as [Código do Motorista], motorista.Nome, motorista.Sexo, motorista.CPF, motorista.RG, motorista.endereco as Endereço, motorista.numero as Número, motorista.Complemento , motorista.CEP, motorista.Bairro, motorista.Cidade, motorista.UF, motorista.data_nasc as [Data de nascimento], motorista.Telefone, motorista.Celular, motorista.Email as [E-mail], motorista.cart_moto as [Número da CNH], motorista.tipo_categoria as [Categoria da CNH], veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.Placa , veiculo.Cor, veiculo.desc_veic as [Observações], veiculo.Blindagem, motorista.Status_Moto [Status]  from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where motorista.nome like '%" & TxtFiltro.Text & "%' and motorista.Condicao = '" & False & "' order by motorista.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            End If
        End Using
    End Sub
    Private Sub cons_motorista_ativo()
        Using cn As SqlConnection = conexao()
            DgvConsulta.DataSource = ""
            If (filtro = "Código") Then
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.img_local, motorista.cod_moto as [Código do Motorista], motorista.Nome, motorista.Sexo, motorista.CPF, motorista.RG, motorista.endereco as Endereço, motorista.numero as Número, motorista.Complemento , motorista.CEP, motorista.Bairro, motorista.Cidade, motorista.UF, motorista.data_nasc as [Data de nascimento], motorista.Telefone, motorista.Celular, motorista.Email as [E-mail], motorista.cart_moto as [Número da CNH], motorista.tipo_categoria as [Categoria da CNH], veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.Placa , veiculo.Cor, veiculo.desc_veic as [Observações], veiculo.Blindagem, motorista.Status_Moto [Status]  from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where motorista.cod_moto = " & TxtFiltro.Text & " and motorista.Condicao = '" & True & "' order by motorista.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "Nome") Then
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.img_local, motorista.cod_moto as [Código do Motorista], motorista.Nome, motorista.Sexo, motorista.CPF, motorista.RG, motorista.endereco as Endereço, motorista.numero as Número, motorista.Complemento , motorista.CEP, motorista.Bairro, motorista.Cidade, motorista.UF, motorista.data_nasc as [Data de nascimento], motorista.Telefone, motorista.Celular, motorista.Email as [E-mail], motorista.cart_moto as [Número da CNH], motorista.tipo_categoria as [Categoria da CNH], veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.Placa , veiculo.Cor, veiculo.desc_veic as [Observações], veiculo.Blindagem, motorista.Status_Moto [Status]  from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where motorista.nome like '%" & TxtFiltro.Text & "%' and motorista.Condicao = '" & True & "' order by motorista.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "CNH") Then
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.img_local, motorista.cod_moto as [Código do Motorista], motorista.Nome, motorista.Sexo, motorista.CPF, motorista.RG, motorista.endereco as Endereço, motorista.numero as Número, motorista.Complemento , motorista.CEP, motorista.Bairro, motorista.Cidade, motorista.UF, motorista.data_nasc as [Data de nascimento], motorista.Telefone, motorista.Celular, motorista.Email as [E-mail], motorista.cart_moto as [Número da CNH], motorista.tipo_categoria as [Categoria da CNH], veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.Placa , veiculo.Cor, veiculo.desc_veic as [Observações], veiculo.Blindagem, motorista.Status_Moto [Status]  from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where motorista.cart_moto like '%" & TxtFiltro.Text & "%'  and motorista.Condicao = '" & True & "' order by motorista.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "CPF") Then
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.img_local, motorista.cod_moto as [Código do Motorista], motorista.Nome, motorista.Sexo, motorista.CPF, motorista.RG, motorista.endereco as Endereço, motorista.numero as Número, motorista.Complemento , motorista.CEP, motorista.Bairro, motorista.Cidade, motorista.UF, motorista.data_nasc as [Data de nascimento], motorista.Telefone, motorista.Celular, motorista.Email as [E-mail], motorista.cart_moto as [Número da CNH], motorista.tipo_categoria as [Categoria da CNH], veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.Placa , veiculo.Cor, veiculo.desc_veic as [Observações], veiculo.Blindagem, motorista.Status_Moto [Status]  from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where motorista.cpf like '%" & TxtFiltro.Text & "%' and motorista.Condicao = '" & True & "' order by motorista.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "RG") Then
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.img_local, motorista.cod_moto as [Código do Motorista], motorista.Nome, motorista.Sexo, motorista.CPF, motorista.RG, motorista.endereco as Endereço, motorista.numero as Número, motorista.Complemento , motorista.CEP, motorista.Bairro, motorista.Cidade, motorista.UF, motorista.data_nasc as [Data de nascimento], motorista.Telefone, motorista.Celular, motorista.Email as [E-mail], motorista.cart_moto as [Número da CNH], motorista.tipo_categoria as [Categoria da CNH], veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.Placa , veiculo.Cor, veiculo.desc_veic as [Observações], veiculo.Blindagem, motorista.Status_Moto [Status]  from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where motorista.rg like '%" & TxtFiltro.Text & "%'  and motorista.Condicao = '" & True & "' order by motorista.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "Blindado") Then
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.img_local, motorista.cod_moto as [Código do Motorista], motorista.Nome, motorista.Sexo, motorista.CPF, motorista.RG, motorista.endereco as Endereço, motorista.numero as Número, motorista.Complemento , motorista.CEP, motorista.Bairro, motorista.Cidade, motorista.UF, motorista.data_nasc as [Data de nascimento], motorista.Telefone, motorista.Celular, motorista.Email as [E-mail], motorista.cart_moto as [Número da CNH], motorista.tipo_categoria as [Categoria da CNH], veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.Placa , veiculo.Cor, veiculo.desc_veic as [Observações], veiculo.Blindagem, motorista.Status_Moto [Status]  from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where veiculo.blindagem = '" & True & "' and motorista.Condicao = '" & True & "' order by motorista.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "Não blindado") Then
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.img_local, motorista.cod_moto as [Código do Motorista], motorista.Nome, motorista.Sexo, motorista.CPF, motorista.RG, motorista.endereco as Endereço, motorista.numero as Número, motorista.Complemento , motorista.CEP, motorista.Bairro, motorista.Cidade, motorista.UF, motorista.data_nasc as [Data de nascimento], motorista.Telefone, motorista.Celular, motorista.Email as [E-mail], motorista.cart_moto as [Número da CNH], motorista.tipo_categoria as [Categoria da CNH], veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.Placa , veiculo.Cor, veiculo.desc_veic as [Observações], veiculo.Blindagem, motorista.Status_Moto [Status]  from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where veiculo.blindagem = '" & False & "' and motorista.Condicao = '" & True & "' order by motorista.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            Else
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.img_local, motorista.cod_moto as [Código do Motorista], motorista.Nome, motorista.Sexo, motorista.CPF, motorista.RG, motorista.endereco as Endereço, motorista.numero as Número, motorista.Complemento , motorista.CEP, motorista.Bairro, motorista.Cidade, motorista.UF, motorista.data_nasc as [Data de nascimento], motorista.Telefone, motorista.Celular, motorista.Email as [E-mail], motorista.cart_moto as [Número da CNH], motorista.tipo_categoria as [Categoria da CNH], veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.Placa , veiculo.Cor, veiculo.desc_veic as [Observações], veiculo.Blindagem, motorista.Status_Moto [Status]  from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where motorista.Condicao = '" & True & "' order by motorista.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            End If
        End Using
    End Sub
    Private Sub cons_motorista_inativo()
        Using cn As SqlConnection = conexao()
            DgvConsulta.DataSource = ""
            If (filtro = "Código") Then
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.img_local, motorista.cod_moto as [Código do Motorista], motorista.Nome, motorista.Sexo, motorista.CPF, motorista.RG, motorista.endereco as Endereço, motorista.numero as Número, motorista.Complemento , motorista.CEP, motorista.Bairro, motorista.Cidade, motorista.UF, motorista.data_nasc as [Data de nascimento], motorista.Telefone, motorista.Celular, motorista.Email as [E-mail], motorista.cart_moto as [Número da CNH], motorista.tipo_categoria as [Categoria da CNH], veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.Placa , veiculo.Cor, veiculo.desc_veic as [Observações], veiculo.Blindagem, motorista.Status_Moto [Status]  from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where motorista.cod_moto = " & TxtFiltro.Text & " and motorista.Condicao = '" & False & "' order by motorista.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "Nome") Then
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.img_local, motorista.cod_moto as [Código do Motorista], motorista.Nome, motorista.Sexo, motorista.CPF, motorista.RG, motorista.endereco as Endereço, motorista.numero as Número, motorista.Complemento , motorista.CEP, motorista.Bairro, motorista.Cidade, motorista.UF, motorista.data_nasc as [Data de nascimento], motorista.Telefone, motorista.Celular, motorista.Email as [E-mail], motorista.cart_moto as [Número da CNH], motorista.tipo_categoria as [Categoria da CNH], veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.Placa , veiculo.Cor, veiculo.desc_veic as [Observações], veiculo.Blindagem, motorista.Status_Moto [Status]  from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where motorista.nome like '%" & TxtFiltro.Text & "%' and motorista.Condicao = '" & False & "' order by motorista.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "CNH") Then
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.img_local, motorista.cod_moto as [Código do Motorista], motorista.Nome, motorista.Sexo, motorista.CPF, motorista.RG, motorista.endereco as Endereço, motorista.numero as Número, motorista.Complemento , motorista.CEP, motorista.Bairro, motorista.Cidade, motorista.UF, motorista.data_nasc as [Data de nascimento], motorista.Telefone, motorista.Celular, motorista.Email as [E-mail], motorista.cart_moto as [Número da CNH], motorista.tipo_categoria as [Categoria da CNH], veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.Placa , veiculo.Cor, veiculo.desc_veic as [Observações], veiculo.Blindagem, motorista.Status_Moto [Status]  from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where motorista.cart_moto like '%" & TxtFiltro.Text & "%'  and motorista.Condicao = '" & False & "' order by motorista.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            ElseIf (filtro = "CPF") Then
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.img_local, motorista.cod_moto as [Código do Motorista], motorista.Nome, motorista.Sexo, motorista.CPF, motorista.RG, motorista.endereco as Endereço, motorista.numero as Número, motorista.Complemento , motorista.CEP, motorista.Bairro, motorista.Cidade, motorista.UF, motorista.data_nasc as [Data de nascimento], motorista.Telefone, motorista.Celular, motorista.Email as [E-mail], motorista.cart_moto as [Número da CNH], motorista.tipo_categoria as [Categoria da CNH], veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.Placa , veiculo.Cor, veiculo.desc_veic as [Observações], veiculo.Blindagem, motorista.Status_Moto [Status]  from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where motorista.cpf like '%" & TxtFiltro.Text & "%' and motorista.Condicao = '" & False & "' order by motorista.nome asc"
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
            ElseIf (filtro = "RG") Then
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.img_local, motorista.cod_moto as [Código do Motorista], motorista.Nome, motorista.Sexo, motorista.CPF, motorista.RG, motorista.endereco as Endereço, motorista.numero as Número, motorista.Complemento , motorista.CEP, motorista.Bairro, motorista.Cidade, motorista.UF, motorista.data_nasc as [Data de nascimento], motorista.Telefone, motorista.Celular, motorista.Email as [E-mail], motorista.cart_moto as [Número da CNH], motorista.tipo_categoria as [Categoria da CNH], veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.Placa , veiculo.Cor, veiculo.desc_veic as [Observações], veiculo.Blindagem, motorista.Status_Moto [Status]  from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where motorista.rg like '%" & TxtFiltro.Text & "%'  and motorista.Condicao = '" & False & "' order by motorista.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            Else
                Try
                    cn.Open()
                    Dim sql As String = "select motorista.img_local, motorista.cod_moto as [Código do Motorista], motorista.Nome, motorista.Sexo, motorista.CPF, motorista.RG, motorista.endereco as Endereço, motorista.numero as Número, motorista.Complemento , motorista.CEP, motorista.Bairro, motorista.Cidade, motorista.UF, motorista.data_nasc as [Data de nascimento], motorista.Telefone, motorista.Celular, motorista.Email as [E-mail], motorista.cart_moto as [Número da CNH], motorista.tipo_categoria as [Categoria da CNH], veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.Placa , veiculo.Cor, veiculo.desc_veic as [Observações], veiculo.Blindagem, motorista.Status_Moto [Status]  from motorista inner join veiculo on motorista.cod_veic = veiculo.cod_veic where motorista.Condicao = '" & False & "' order by motorista.nome asc"
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    DgvConsulta.DataSource = dt
                    With DgvConsulta
                        .Columns("img_local").Visible = False
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    cn.Close()
                End Try
            End If
        End Using
    End Sub
    '===========================================================
    '================================CLIENTE_FÍSICO================================
    '===========================================================
    Private Sub cons_nome_clifis()
        Using cn As SqlConnection = conexao()
            If (filtro = "Nome") Then
                Try
                    cn.Open()
                    Dim sql As String = "select Cliente.Cod_cli as Código, Cliente.Nome, Cliente.Endereco as Endereço, Cliente.Numero as Número, Cliente.Complemento, Cliente.CEP, Cliente.Bairro, Cliente.Cidade, Cliente.UF, Cliente.Telefone, Cliente.Celular, Cliente.Email, cli_fisico.CPF, cli_fisico.Sexo, cli_fisico.data_nasc as [Data de nascimento] from Cliente inner join cli_fisico on Cliente.cod_cli = cli_fisico.cod_cli where Cliente.nome like '%" & TxtFiltro.Text & "%' and Cliente.tipo_cli = 'Fis' order by cliente.nome asc"
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
            End If
        End Using
    End Sub
    Private Sub cons_clifis()
        Using cn As SqlConnection = conexao()
            DgvConsulta.DataSource = ""
            If (filtro = "Código") Then
                Try
                    cn.Open()
                    Dim sql As String = "select Cliente.Cod_cli as Código, Cliente.Nome, Cliente.Endereco as Endereço, Cliente.Numero as Número, Cliente.Complemento, Cliente.CEP, Cliente.Bairro, Cliente.Cidade, Cliente.UF, Cliente.Telefone, Cliente.Celular, Cliente.Email, cli_fisico.CPF, cli_fisico.Sexo, cli_fisico.data_nasc as [Data de nascimento] from Cliente inner join cli_fisico on Cliente.cod_cli = cli_fisico.cod_cli where Cliente.cod_cli like '%" & TxtFiltro.Text & "%' and Cliente.tipo_cli = 'Fis' order by cliente.nome asc"
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
            ElseIf (filtro = "Nome") Then
                Try
                    cn.Open()
                    Dim sql As String = "select Cliente.Cod_cli as Código, Cliente.Nome, Cliente.Endereco as Endereço, Cliente.Numero as Número, Cliente.Complemento, Cliente.CEP, Cliente.Bairro, Cliente.Cidade, Cliente.UF, Cliente.Telefone, Cliente.Celular, Cliente.Email, cli_fisico.CPF, cli_fisico.Sexo, cli_fisico.data_nasc as [Data de nascimento] from Cliente inner join cli_fisico on Cliente.cod_cli = cli_fisico.cod_cli where Cliente.nome like '%" & TxtFiltro.Text & "%' and Cliente.tipo_cli = 'Fis' order by cliente.nome asc"
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
            ElseIf (filtro = "CPF") Then
                Try
                    cn.Open()
                    Dim sql As String = "select Cliente.Cod_cli as Código, Cliente.Nome, Cliente.Endereco as Endereço, Cliente.Numero as Número, Cliente.Complemento, Cliente.CEP, Cliente.Bairro, Cliente.Cidade, Cliente.UF, Cliente.Telefone, Cliente.Celular, Cliente.Email, cli_fisico.CPF, cli_fisico.Sexo, cli_fisico.data_nasc as [Data de nascimento] from Cliente inner join cli_fisico on Cliente.cod_cli = cli_fisico.cod_cli where cli_fisico.cpf like '%" & TxtFiltro.Text & "%' and Cliente.tipo_cli = 'Fis' order by cliente.nome asc"
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
            Else
                Try
                    cn.Open()
                    Dim sql As String = "select Cliente.Cod_cli as Código, Cliente.Nome, Cliente.Endereco as Endereço, Cliente.Numero as Número, Cliente.Complemento, Cliente.CEP, Cliente.Bairro, Cliente.Cidade, Cliente.UF, Cliente.Telefone, Cliente.Celular, Cliente.Email, cli_fisico.CPF, cli_fisico.Sexo, cli_fisico.data_nasc as [Data de nascimento] from Cliente inner join cli_fisico on Cliente.cod_cli = cli_fisico.cod_cli where Cliente.tipo_cli = 'Fis' order by cliente.nome asc"
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
            End If
        End Using
    End Sub
    '===========================================================
    '================================CLIENTE_JURÍDICO================================
    '===========================================================
    Private Sub cons_nome_jur()
        Using cn As SqlConnection = conexao()
            DgvConsulta.DataSource = ""
            If (filtro = "Nome") Then
                Try
                    cn.Open()
                    Dim sql As String = "select Cliente.Cod_cli as Código, Cliente.Nome, Cliente.Endereco as Endereço, Cliente.Numero as Número, Cliente.Complemento, Cliente.CEP, Cliente.Bairro, Cliente.Cidade, Cliente.UF, Cliente.Telefone, Cliente.Email, cli_juridico.CNPJ, cli_juridico.razao_social AS [Razão Social], cli_juridico.website as [Website] from Cliente inner join cli_juridico on Cliente.cod_cli = cli_juridico.cod_cli where Cliente.nome like '%" & TxtFiltro.Text & "%' and Cliente.tipo_cli = 'Jur'  order by cliente.nome asc"
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
            End If
        End Using
    End Sub
    Private Sub cons_cli_jur()
        Using cn As SqlConnection = conexao()
            DgvConsulta.DataSource = ""
            If (filtro = "Código") Then
                Try
                    cn.Open()
                    Dim sql As String = "select Cliente.Cod_cli as Código, Cliente.Nome, Cliente.Endereco as Endereço, Cliente.Numero as Número, Cliente.Complemento, Cliente.CEP, Cliente.Bairro, Cliente.Cidade, Cliente.UF, Cliente.Telefone, Cliente.Email, cli_juridico.CNPJ, cli_juridico.razao_social AS [Razão Social], cli_juridico.website as [Website] from Cliente inner join cli_juridico on Cliente.cod_cli = cli_juridico.cod_cli where Cliente.cod_cli = " & TxtFiltro.Text & " and Cliente.tipo_cli = 'Jur'  order by cliente.nome asc"
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
            ElseIf (filtro = "Nome") Then
                Try
                    cn.Open()
                    Dim sql As String = "select Cliente.Cod_cli as Código, Cliente.Nome, Cliente.Endereco as Endereço, Cliente.Numero as Número, Cliente.Complemento, Cliente.CEP, Cliente.Bairro, Cliente.Cidade, Cliente.UF, Cliente.Telefone, Cliente.Email, cli_juridico.CNPJ, cli_juridico.razao_social AS [Razão Social], cli_juridico.website as [Website] from Cliente inner join cli_juridico on Cliente.cod_cli = cli_juridico.cod_cli where Cliente.nome like '%" & TxtFiltro.Text & "%' and Cliente.tipo_cli = 'Jur'  order by cliente.nome asc"
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
            ElseIf (filtro = "CNPJ") Then
                Try
                    cn.Open()
                    Dim sql As String = "select Cliente.Cod_cli as Código, Cliente.Nome, Cliente.Endereco as Endereço, Cliente.Numero as Número, Cliente.Complemento, Cliente.CEP, Cliente.Bairro, Cliente.Cidade, Cliente.UF, Cliente.Telefone, Cliente.Email, cli_juridico.CNPJ, cli_juridico.razao_social AS [Razão Social], cli_juridico.website as [Website] from Cliente inner join cli_juridico on Cliente.cod_cli = cli_juridico.cod_cli where cli_juridico.cnpj like '%" & TxtFiltro.Text & "%' and Cliente.tipo_cli = 'Jur'  order by cliente.nome asc"
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
            Else
                Try
                    cn.Open()
                    Dim sql As String = "select Cliente.Cod_cli as Código, Cliente.Nome, Cliente.Endereco as Endereço, Cliente.Numero as Número, Cliente.Complemento, Cliente.CEP, Cliente.Bairro, Cliente.Cidade, Cliente.UF, Cliente.Telefone, Cliente.Email, cli_juridico.CNPJ, cli_juridico.razao_social AS [Razão Social], cli_juridico.website as [Website] from Cliente  inner join cli_juridico on Cliente.cod_cli = cli_juridico.cod_cli where Cliente.tipo_cli = 'Jur' order by cliente.nome asc"
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
            End If
        End Using
    End Sub
    Private Sub rec_moto()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = " update veiculo set condicao = '" & True & "' where cod_veic = " & conscod & ""
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
                Dim sql As String = "update motorista set condicao = '" & True & "' where cod_moto = " & conscod & ""
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
                Dim sql As String = "update tblogin set condicao = '" & True & "' where cod_func = " & conscod & ""
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
                Dim sql As String = "update funcionario set condicao = '" & True & "' where cod_func = " & conscod & ""
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
    Private Sub btnfechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFechar.Click
        inicio.Enabled = True
        Me.Close()
    End Sub

    Private Sub Consultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        RbCliFis.Checked = True
    End Sub
    Private Sub btnexibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExibir.Click
        If RbFunc.Checked = True Then
            If RbAtivo.Checked = True Then
                cons_funcionario_ativo()
            ElseIf RbInativo.Checked = True Then
                cons_funcionario_inativo()
            End If
        ElseIf RbMoto.Checked = True Then
            If RbAtivo.Checked = True Then
                cons_motorista_ativo()
            ElseIf RbInativo.Checked = True Then
                cons_motorista_inativo()
            End If
        ElseIf RbCliFis.Checked = True Then
            cons_clifis()
        ElseIf RbCliJud.Checked = True Then
            cons_cli_jur()
        End If
    End Sub
    Private Sub cbfiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbFiltro.SelectedIndexChanged
        TxtFiltro.Clear()
        filtro = CbFiltro.SelectedItem
        If (filtro = "Todos") Or (filtro = "Blindado") Or (filtro = "Não blindado") Then
            TxtFiltro.Enabled = False
            TxtFiltro.Clear()
        Else
            TxtFiltro.Enabled = True
        End If
    End Sub
    Private Sub txtfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFiltro.TextChanged
        If RbFunc.Checked = True Then
            If RbAtivo.Checked = True Then
                cons_nome_func_ativo()
            ElseIf RbMoto.Checked = True Then
                cons_nome_func_inativo()
            End If
        ElseIf RbMoto.Checked = True Then
            If RbAtivo.Checked = True Then
                cons_nome_moto_ativo()
            ElseIf RbInativo.Checked = True Then
                cons_nome_moto_inativo()
            End If
        ElseIf RbCliFis.Checked = True Then
            cons_nome_clifis()
        ElseIf RbCliJud.Checked = True Then
            cons_nome_jur()
        End If
    End Sub
    Private Sub rbativo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbAtivo.CheckedChanged
        If RbFunc.Checked = True Then
            cons_funcionario_ativo()
        ElseIf RbMoto.Checked = True Then
            cons_motorista_ativo()
        End If
    End Sub
    Private Sub rbinativo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbInativo.CheckedChanged
        If RbFunc.Checked = True Then
            cons_funcionario_inativo()
        ElseIf RbMoto.Checked = True Then
            cons_motorista_inativo()
        End If
    End Sub
    Private Sub rbmoto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbMoto.CheckedChanged
        CbFiltro.Items.Clear()
        gbstatus.Visible = True
        PbFoto.Visible = True
        CbFiltro.Items.Add("Todos")
        CbFiltro.Items.Add("Código")
        CbFiltro.Items.Add("Nome")
        CbFiltro.Items.Add("CNH")
        CbFiltro.Items.Add("CPF")
        CbFiltro.Items.Add("RG")
        CbFiltro.Items.Add("Blindado")
        CbFiltro.Items.Add("Não blindado")
        CbFiltro.SelectedItem = "Todos"
        RbAtivo.Checked = True
        If RbAtivo.Checked = True Then
            cons_motorista_ativo()
        ElseIf RbInativo.Checked = True Then
            cons_motorista_inativo()
        End If
    End Sub
    Private Sub rbfunc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbFunc.CheckedChanged
        CbFiltro.Items.Clear()
        gbstatus.Visible = True
        PbFoto.Visible = True
        CbFiltro.Items.Add("Todos")
        CbFiltro.Items.Add("Código")
        CbFiltro.Items.Add("Nome")
        CbFiltro.Items.Add("CPF")
        CbFiltro.Items.Add("RG")
        CbFiltro.SelectedItem = "Todos"
        RbAtivo.Checked = True
        If RbAtivo.Checked = True Then
            cons_funcionario_ativo()
        ElseIf RbInativo.Checked = True Then
            cons_funcionario_inativo()
        End If
    End Sub
    Private Sub rbclifis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbCliFis.CheckedChanged
        CbFiltro.Items.Clear()
        gbstatus.Visible = False
        PbFoto.Visible = False
        CbFiltro.Items.Add("Todos")
        CbFiltro.Items.Add("Código")
        CbFiltro.Items.Add("Nome")
        CbFiltro.Items.Add("CPF")
        CbFiltro.SelectedItem = "Todos"
        cons_clifis()
    End Sub
    Private Sub rbclijud_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbCliJud.CheckedChanged
        CbFiltro.Items.Clear()
        gbstatus.Visible = False
        PbFoto.Visible = False
        CbFiltro.Items.Add("Todos")
        CbFiltro.Items.Add("Código")
        CbFiltro.Items.Add("Nome")
        CbFiltro.Items.Add("CNPJ")
        CbFiltro.SelectedItem = "Todos"
        cons_cli_jur()
    End Sub
    Private Sub dgvconsuta_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvConsulta.CellDoubleClick
        Try
            Dim mostra_cod As Integer
            If RbFunc.Checked = True Then
                If RbInativo.Checked = True Then
                    conscod = DgvConsulta.CurrentRow.Cells(1).Value
                    If MessageBox.Show("Funcionário " & conscod & " atualmente está excluido. Deseja realmente restaurá-lo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        rec_func()
                        MessageBox.Show("Funcionário restaurado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        conscod = 0
                        cons_funcionario_inativo()
                    End If
                ElseIf RbAtivo.Checked = True Then
                    codigos.conscodfunc = DgvConsulta.CurrentRow.Cells(1).Value
                    mostra_cod = DgvConsulta.CurrentRow.Cells(1).Value
                    If MessageBox.Show("Deseja realmente fazer alteração do funcionário de código " & mostra_cod & " ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        Funcionario.RbAltExc.Checked = True
                        Funcionario.Show()
                        Me.Close()
                    End If
                End If
            ElseIf RbMoto.Checked = True Then
                If RbInativo.Checked = True Then
                    conscod = DgvConsulta.CurrentRow.Cells(1).Value
                    If MessageBox.Show("Motorista " & conscod & " atualmente está excluido. Deseja realmente restaurá-lo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        rec_moto()
                        MessageBox.Show("Motorista restaurado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        conscod = 0
                        cons_motorista_inativo()
                    End If
                ElseIf RbAtivo.Checked = True Then
                    codigos.conscodmoto = DgvConsulta.CurrentRow.Cells(1).Value
                    mostra_cod = DgvConsulta.CurrentRow.Cells(1).Value
                    If MessageBox.Show("Deseja realmente fazer alteração do motorista de código " & mostra_cod & " ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        Motorista.RbAltExc.Checked = True
                        Motorista.Show()
                        Me.Close()
                    End If
                End If
            ElseIf RbCliFis.Checked = True Then
                codigos.conscodclifis = DgvConsulta.CurrentRow.Cells(0).Value
                mostra_cod = DgvConsulta.CurrentRow.Cells(0).Value
                codigos.cpfclifis = DgvConsulta.CurrentRow.Cells(12).Value
                If MessageBox.Show("Deseja realmente fazer alteração do cliente físico de código " & mostra_cod & " ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    Cliente_Fis.RbAltExc.Checked = True
                    Cliente_Fis.Show()

                    Me.Close()
                End If
            ElseIf RbCliJud.Checked = True Then
                codigos.conscodclijud = DgvConsulta.CurrentRow.Cells(0).Value
                mostra_cod = DgvConsulta.CurrentRow.Cells(0).Value
                codigos.cnpjclijud = DgvConsulta.CurrentRow.Cells(11).Value
                If MessageBox.Show("Deseja realmente fazer alteração do cliente jurídico de código " & mostra_cod & " ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    Cliente_Jud.RbAltExc.Checked = True
                    Cliente_Jud.Show()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub dgvconsuta_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvConsulta.CurrentCellChanged
        If RbFunc.Checked = True Or RbMoto.Checked = True Then
            Try
                Dim img As String = (DgvConsulta.CurrentRow.Cells("img_local").Value.ToString)
                PbFoto.Image = New System.Drawing.Bitmap(img)
            Catch ex As Exception
                PbFoto.Image = Nothing
            End Try
        Else
            Exit Sub
        End If
    End Sub
    'Private Sub PbFoto_Click(sender As System.Object, e As System.EventArgs) Handles PbFoto.Click
    '    Try
    '        Process.Start(dgvconsuta.CurrentRow.Cells("img_local").Value.ToString)
    '        Me.Show()
    '    Catch ex As Exception
    '      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End Try
    'End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Enabled = False
        Help_Consulta.Show()
    End Sub
End Class