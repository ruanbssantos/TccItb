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
        Dim blindao As String
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
                    txtobservacoes.Text = mr!observacoes
                    blindao = mr!blindagem
                    If blindao = True Then
                        rbsim.Checked = True
                    ElseIf blindao = False Then
                        rbnao.Checked = True
                    End If
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
            '--------------------------------------------------------------
            Try
                cn.Open()
                Dim sql As String = "select cod_tipocorrida, preco_total, kmtotal, cod_moto from corrida where cod_corrida = " & codigos.codagend & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                Dim preco As Decimal
                mr = cmd.ExecuteReader
                While mr.Read
                    preco = mr!preco_total
                    txtkmtotal.Text = mr!kmtotal
                    codtipocorrida = mr!cod_tipocorrida
                    codmoto1 = mr!cod_moto
                End While
                txtvalortotal.Text = preco.ToString("##,##0.00")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub btnfechar_Click(sender As System.Object, e As System.EventArgs) Handles btnfechar.Click
        'If MessageBox.Show("Deseja realmente sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        If Cons_Corrida.Enabled = False Then
            Cons_Corrida.Enabled = True
            Me.Close()
        Else
            inicio.Enabled = True
            Me.Close()
        End If
        'end If
    End Sub
    Private Sub Informacoes_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Cons_Corrida.Enabled = False Then
            Cons_Corrida.Enabled = True
        ElseIf inicio.Enabled = False Then
            inicio.Enabled = True
        End If
        Exit Sub
    End Sub
End Class