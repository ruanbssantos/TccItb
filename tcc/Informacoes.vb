Imports System.Data.SqlClient
Public Class Informacoes

    Dim codcli As Integer
    Dim codforma As Integer
    Dim codtipocorrida As Integer
    Dim codmoto1 As Integer


    Private Sub Informacoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_dados()
        txtcodcorrida.Text = codigos.codagend
    End Sub

    Private Sub carregar_dados()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from agendamento where cod_agendamento = " & codigos.codagend & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader

                mr = cmd.ExecuteReader

                While mr.Read
                    txtdataagend.Text = mr!data_agend
                    txthorario.Text = mr!horario
                    codcli = mr!cod_cli
                    txtcodfunc.Text = mr!cod_func
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try


            Try
                cn.Open()
                Dim sql As String = "select nome from cliente where cod_cli= '" & codcli & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader

                mr = cmd.ExecuteReader


                While mr.Read
                    txtnomecli.Text = mr!nome
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try


            '----------------------------------------------------------

            Try
                cn.Open()
                Dim sql As String = "select * from rota where cod_agendamento = " & codigos.codagend & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader

                mr = cmd.ExecuteReader

                While mr.Read
                    txtenddest.Text = mr!Endereco_destino
                    txtendori.Text = mr!Endereco_origem
                    txtnum.Text = mr!Numero
                    txtcomp.Text = mr!Complemento
                    txtcep.Text = mr!CEP
                    txtbairro.Text = mr!Bairro
                    txtcidade.Text = mr!cidade
                    txtuf.Text = mr!uf
                    txttipolocal.Text = mr!Tipo_local
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try

            '--------------------------------------------------------------

            Try
                cn.Open()
                Dim sql As String = "select cod_forma from pgto_corrida where cod_corrida = " & codigos.codagend & ""
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

            Try
                cn.Open()
                Dim sql As String = "select desc_forma from forma_pgto where cod_forma = " & codforma & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader

                mr = cmd.ExecuteReader

                While mr.Read
                    txtformpgto.Text = mr!desc_forma
                End While

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try


            '--------------------------------------------------------------
            Try
                cn.Open()
                Dim sql As String = "select cod_tipocorrida, preco_total, kmtotal, cod_moto from corrida where cod_corrida = " & codigos.codagend & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader

                mr = cmd.ExecuteReader

                While mr.Read
                    txtvalortotal.Text = mr!preco_total
                    txtkmtotal.Text = mr!kmtotal
                    codtipocorrida = mr!cod_tipocorrida
                    codmoto1 = mr!cod_moto
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try


            Try
                cn.Open()
                Dim sql As String = "select nome from motorista where cod_moto= '" & codmoto1 & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader

                mr = cmd.ExecuteReader


                While mr.Read
                    txtnomemoto.Text = mr!nome
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try

            Try
                cn.Open()
                Dim sql As String = "select nome_corrida from Tipo_corrida where cod_TipoCorrida= '" & codtipocorrida & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader

                mr = cmd.ExecuteReader


                While mr.Read
                    txttipocorrida.Text = mr!nome_corrida
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txttipocorrida_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttipocorrida.TextChanged

    End Sub
End Class