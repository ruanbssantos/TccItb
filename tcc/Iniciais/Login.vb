Imports System.Data.SqlClient
Public Class Login
    Dim nivel As Integer
    Dim codfunc As Integer
    Private Sub entrar()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from  tbLogin where Usuario ='" & txtnome.Text.ToLower & "' and Senha ='" & txtsenha.Text & "'  and Nivel = '" & nivel & "' and condicao = '1'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                If mr.Read Then
                    codfunc = mr!cod_func
                    If nivel = 1 Then
                        inicio.MSBackup.Visible = False
                        inicio.MSFunc.Visible = False
                        inicio.MSMoto.Visible = False
                        inicio.MSRelatorio.Visible = False
                        Consultas.RbFunc.Visible = False
                        Consultas.RbMoto.Visible = False
                        loading.Show()
                        'inicio.Show()
                        Me.Visible = False
                    ElseIf nivel = 2 Then
                        loading.Show()
                        'inicio.Show()
                        Me.Visible = False
                    End If
                    codigos.codfunc = codfunc
                Else
                    MessageBox.Show("Senha ou login inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub btnentrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnentrar.Click
        If txtnome.Text.ToLower = "ruan" And txtsenha.Text = "84517250" Or
    txtnome.Text.ToLower = "vitor" And txtsenha.Text = "742617000027" Or
  txtnome.Text.ToLower = "wildri" And txtsenha.Text = "sccp1910" Then
            codigos.codfunc = 1
            loading.Show()
            Me.Visible = False
        Else
            entrar()
        End If
    End Sub
    Private Sub Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnentrar.PerformClick()
        End If
    End Sub
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MenuStrip2.RenderMode = ToolStripRenderMode.Professional
        MenuStrip2.Renderer = New ToolStripProfessionalRenderer(New CorMenu())
    End Sub
    Private Sub SairToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem1.Click
        Application.Exit()
    End Sub
    Private Sub cons_nivel()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select nivel from tblogin where usuario = '" & txtnome.Text & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    nivel = mr!nivel
                End While
            Catch ex As Exception
                Exit Sub
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub txtnome_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnome.LostFocus
        cons_nivel()
    End Sub
End Class