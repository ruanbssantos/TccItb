Imports System.Data.SqlClient

Public Class AltExcAgend
    Dim codcli As Integer
    Dim cpf As String
    Dim codmoto As Integer
    Dim codforma As Integer
    Dim tipocli As String
    Dim cnpj As String

    Private Sub AltExcAgend_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        carregar_nome_moto()
        carregar_forma()
    End Sub

    Private Sub SairToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Deseja realmente sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            inicio.Enabled = True
        End If

    End Sub


    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        If MessageBox.Show("Deseja realmente sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            inicio.Enabled = True
        End If
    End Sub
    Private Sub busca_cpf_cli_nome_motorista()

        Using cn As SqlConnection = conexao()


            Try
                cn.Open()
                Dim sql As String = "select tipo_cli from cliente where Cod_cli = " & codcli & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader

                mr = cmd.ExecuteReader

                While mr.Read
                    tipocli = mr!tipo_cli

                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try

            If tipocli = "Fis" Then


                '---------------------------------------------

                Try
                    cn.Open()
                    Dim sql As String = "select cpf from cli_fisico where Cod_cli = " & codcli & ""
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim mr As SqlDataReader

                    mr = cmd.ExecuteReader

                    While mr.Read
                        cpf = mr!cpf
                    End While

                    mtbcpf.Text = cpf

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cn.Close()
                End Try


                Try
                    cn.Open()
                    Dim sql As String = "select nome from motorista where Cod_moto = " & codmoto & ""
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim mr As SqlDataReader

                    mr = cmd.ExecuteReader

                    While mr.Read
                        cbmoto.Text = mr!nome
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cn.Close()
                End Try


            ElseIf tipocli = "Jur" Then

                '---------------------------------------------

                Try
                    cn.Open()
                    Dim sql As String = "select cnpj from cli_juridico where Cod_cli = " & codcli & ""
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim mr As SqlDataReader

                    mr = cmd.ExecuteReader

                    While mr.Read
                        cnpj = mr!cnpj

                    End While

                    mtbcnpj.Text = cnpj

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cn.Close()
                End Try


                Try
                    cn.Open()
                    Dim sql As String = "select nome from motorista where Cod_moto = " & codmoto & ""
                    Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                    Dim mr As SqlDataReader

                    mr = cmd.ExecuteReader

                    While mr.Read
                        cbmoto.Text = mr!nome
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cn.Close()
                End Try
            End If
        End Using
    End Sub

    Private Sub busca_dados()
        Using cn As SqlConnection = conexao()


            Try
                cn.Open()
                Dim sql As String = "select * from agendamento where cod_agendamento = " & txtcodcorri.Text & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader

                mr = cmd.ExecuteReader

                While mr.Read
                    mtbdata.Text = mr!data_agend
                    mtbhora.Text = mr!horario
                    codcli = mr!cod_cli
                    codmoto = mr!cod_moto
                    txtcodfunc.Text = mr!cod_func
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
            '----------------------------------------------------------

            Try
                cn.Open()
                Dim sql As String = "select * from rota where cod_agendamento = " & txtcodcorri.Text & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader

                mr = cmd.ExecuteReader

                While mr.Read
                    txtendorigem.Text = mr!Endereco_destino
                    txtlocdest.Text = mr!Endereco_origem
                    txtnumresid.Text = mr!Numero
                    txtcompl.Text = mr!Complemento
                    mtbcep.Text = mr!CEP
                    txtbairro.Text = mr!Bairro
                    txtcidade.Text = mr!cidade
                    cbuf.Text = mr!uf
                    txtdetcorri.Text = mr!observacao
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try

            '--------------------------------------------------------------

            Try
                cn.Open()
                Dim sql As String = "select cod_forma from pgto_corrida where cod_corrida = " & txtcodcorri.Text & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader

                mr = cmd.ExecuteReader

                While mr.Read
                    codforma = mr!cod_forma
                End While
                If codforma = 1 Then
                    cbformapgto.Text = "Cartão de débito"
                ElseIf codforma = 2 Then
                    cbformapgto.Text = "Cartão de crédito"
                ElseIf codforma = 3 Then
                    cbformapgto.Text = "Dinheiro"
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
            '--------------------------------------------------------------
            Try
                cn.Open()
                Dim sql As String = "select condicao from corrida where cod_corrida = " & txtcodcorri.Text & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader

                mr = cmd.ExecuteReader

                While mr.Read
                    cbcondicao.Text = mr!condicao
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try

        End Using
    End Sub

    Private Sub btnexibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexibir.Click
        busca_dados()
        busca_cpf_cli_nome_motorista()
    End Sub
    Private Sub carregar_nome_moto()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select nome from motorista"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader


                mr = cmd.ExecuteReader

                While mr.Read
                    cbmoto.Items.Add(mr.Item("nome"))
                End While

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub carregar_forma()
        Using cn As SqlConnection = conexao()

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
        End Using
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("calc.exe")
    End Sub

    Private Sub BlocoDeNotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("notepad.exe")
    End Sub


    Private Sub btnfechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfechar.Click
        If MessageBox.Show("Deseja realmente sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            inicio.Enabled = True
        End If
    End Sub
End Class