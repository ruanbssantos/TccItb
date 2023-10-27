Imports System.Data.SqlClient
Public Class ValorCorrida
    Dim CodAgend As Integer
    Dim codadicional As Integer
    Dim codtipo As Integer
    Dim codcorrida As Integer
    Dim codmoto As Integer
    Dim codforma As Integer
    Dim valortotal As Decimal

    Private Sub ValorCorrida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Cor do menu
        MenuStrip2.RenderMode = ToolStripRenderMode.Professional
        MenuStrip2.Renderer = New ToolStripProfessionalRenderer(New CorMenu())

        carregar_dados()

    End Sub
    Private Sub btngera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngera.Click

        If cbtipo.Text = "" And cbadic.Text = "" Then
            MessageBox.Show("Insira dados para gerar valor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            gerar_valor()

        End If
    End Sub
    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click

        If cbformapgto.Text = "" Then
            MessageBox.Show("Insira dados para confirmar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        End If
    End Sub

    Private Sub cbtipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbtipo.SelectedIndexChanged

        selecionar_tipo_corrida()


    End Sub

    Private Sub cbformapgto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbformapgto.SelectedIndexChanged

        forma_pagamento()

    End Sub

    Private Sub txtvalor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvalor.TextChanged
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

    Private Sub gerar_valor()

        Using cn As SqlConnection = conexao()
            Dim pedagio As String

            pedagio = Replace(txtpedagio.Text, ",", ".")


            '------------------------------------------------

            Try
                cn.Open()
                Dim sql As String = "update adicionais_corrida set valor_adicional = '" & pedagio & "' where cod_adicional = '1'"
                Dim cmd As SqlCommand = New SqlCommand(Sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim mr As Integer
                da.Fill(dt)

                mr = cmd.ExecuteNonQuery

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try

            '---------------------------------------------

            Try
                cn.Open()
                Dim sql As String = "insert into corrida (cod_corrida, cod_TipoCorrida, preco_total, KmTotal, cod_moto, cod_agendamento) values  ('" & CodAgend & "', '" & codtipo & "','0.00', '" & txtkm.Text & "', '" & codmoto & "', '" & CodAgend & "')"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)

            Catch ex As Exception
                MsgBox(ex.Message)
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
                MsgBox(ex.Message)
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
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try

            '----------------------------------------------------

            Try
                cn.Open()
                Dim sql As String = "update corrida set preco_total = (select (Tipo_corrida.preco * corrida.kmTotal) + adicionais_corrida.valor_adicional  from Tipo_corrida inner join corrida on Tipo_corrida.cod_TipoCorrida = corrida.cod_TipoCorrida inner join det_corrida on corrida.cod_corrida = det_corrida.cod_corrida inner join adicionais_corrida on adicionais_corrida.cod_adicional = det_corrida.cod_adicional where corrida.cod_corrida = '" & codcorrida & "') where cod_corrida = '" & codcorrida & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim mr As Integer
                da.Fill(dt)

                mr = cmd.ExecuteNonQuery

            Catch ex As Exception
                MsgBox(ex.Message)
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



                txtvalor.Text = valortotal

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try

        End Using

    End Sub

    Private Sub confirmar()
        Using cn As SqlConnection = conexao()

            Dim valor As String
            valor = Replace(txtvalor.Text, ",", ".")



            Try
                cn.Open()
                Dim sql As String = "insert into pgto_corrida (cod_pgto, valor_pago, cod_adicional, cod_corrida, cod_forma) values  ('" & CodAgend & "', '" & valor & "','" & codadicional & "', '" & codcorrida & "', '" & codforma & "' )"
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

    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("calc.exe")
    End Sub

    Private Sub BlocoDeNotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("notepad.exe")
    End Sub
End Class

