Imports System.Data.SqlClient
Public Class usuario
    Dim senha As String
    Dim senhacomp As String
    Private Sub carregar_dados()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from  tblogin where cod_func = " & codigos.codfunc & " and condicao = '" & True & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    LblUser.Text = mr!usuario
                    senhacomp = mr!senha
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub alt_login()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "update tblogin set senha = '" & senha & "' where cod_func = " & codigos.codfunc & ""
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
    Private Function Validar_Campos() As Boolean
        If TxtSenha.Text = "" Then
            MessageBox.Show("O campo senha não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf TxtConfSenha.Text = "" Then
            MessageBox.Show("O campo confirmar senha não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function
    Private Sub txtconfsenha_LostFocus(sender As Object, e As System.EventArgs) Handles TxtConfSenha.LostFocus
        If TxtSenha.Text = TxtConfSenha.Text Then
            senha = TxtSenha.Text
        Else
            MessageBox.Show("Senha não corresponde.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtConfSenha.Clear()
            TxtSenha.Clear()
            TxtSenha.Focus()
        End If
    End Sub
    Private Sub btnfechar_Click(sender As System.Object, e As System.EventArgs) Handles btnfechar.Click
        'If MessageBox.Show("Deseja realmente sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        inicio.Enabled = True
        Me.Close()
        'End If
    End Sub
    Private Sub btnalterar_Click(sender As System.Object, e As System.EventArgs) Handles btnalterar.Click
        If senhacomp = TxtSenha.Text Then
            MessageBox.Show("Por favor, digite uma senha diferente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtSenha.Clear()
            TxtConfSenha.Clear()
            TxtSenha.Focus()
        Else
            If Validar_Campos() = False Then
                Exit Sub
            ElseIf Validar_Campos() = True Then
                If MessageBox.Show("Deseja realmente alterar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    alt_login()
                    MessageBox.Show("Alteração efetuada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    inicio.Enabled = True
                    Me.Close()
                End If
            End If
        End If
    End Sub
    Private Sub usuario_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtConfSenha.KeyPress, TxtSenha.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub
    Private Sub usuario_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        inicio.Enabled = True
        Exit Sub
    End Sub
    Private Sub usuario_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        carregar_dados()
        LblUser.Text = Login.txtnome.Text
    End Sub
    Private Sub usuario_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtConfSenha.KeyDown, TxtSenha.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnalterar.PerformClick()
        End If
    End Sub
End Class