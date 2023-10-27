Imports System.Data.SqlClient
Public Class Alt_Agend
    Dim codforma As Integer
    Dim codformaup As Integer
    Public Sub formato_hora()
        DtpHora.Format = DateTimePickerFormat.Custom
        DtpHora.CustomFormat = "HH:mm"
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
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub btnfechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfechar.Click
        If MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Cons_Corrida.Enabled = True
            Me.Close()
        End If
    End Sub
    Private Sub Alt_Agend_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Cons_Corrida.Enabled = True
        Exit Sub
    End Sub
    Private Sub AltAgend_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formato_hora()
        carregar_forma()
        lblcod.Text = codigos.codcorrida
        lblnome.Text = codigos.nomecli
        busca_dados()
    End Sub
    Private Sub busca_dados()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from agendamento where cod_agendamento = " & codigos.codcorrida & " and status_agend = 'Pendente'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    DtpData.Text = mr!data_agend
                    DtpHora.Text = mr!horario
                    txtobservacoes.Text = mr!observacoes
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
            '--------------------------------------------------------------
            Try
                cn.Open()
                Dim sql As String = "select cod_forma from pgto_corrida where cod_corrida = " & codigos.codcorrida & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    codforma = mr!cod_forma
                    If codforma = 1 Then
                        cbformapgto.Text = "Cartão de débito"
                    ElseIf codforma = 2 Then
                        cbformapgto.Text = "Cartão de crédito"
                    ElseIf codforma = 3 Then
                        cbformapgto.Text = "Dinheiro"
                    End If
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub BtnAlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlt.Click
        alterar_dados()
    End Sub
    Private Sub alterar_dados()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "update agendamento set data_agend = '" & DtpData.Text & "', horario = '" & DtpHora.Text & "', observacoes = '" & txtobservacoes.Text & "' where cod_agendamento = '" & codigos.codcorrida & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
            Try
                cn.Open()
                Dim sql As String = "update pgto_corrida set cod_forma = '" & codformaup & "' where cod_corrida = '" & codigos.codcorrida & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
            MessageBox.Show("Alteração efetuada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cons_Corrida.Enabled = True
            Me.Close()
        End Using
    End Sub
    Private Sub cbformapgto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbformapgto.SelectedIndexChanged
        If cbformapgto.Text = "Cartão de débito" Then
            codformaup = 1
        ElseIf cbformapgto.Text = "Cartão de crédito" Then
            codformaup = 2
        ElseIf cbformapgto.Text = "Dinheiro" Then
            codformaup = 3
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Enabled = False
        Help_Alt_Corr.Show()
    End Sub
    Private Sub txtobservacoes_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtobservacoes.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub
    Private Sub alt_Agend_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DtpData.KeyDown, DtpHora.KeyDown, cbformapgto.KeyDown, txtobservacoes.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAlt.PerformClick()
        End If
    End Sub
End Class
