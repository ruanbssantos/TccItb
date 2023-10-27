Imports System.Data.SqlClient
Public Class MotoUpdate
    Dim cod_moto As Integer
    Private Sub carregar_forma()
        Using cn As SqlConnection = conexao()

            Try
                cn.Open()
                Dim sql As String = "select cod_moto, Nome from motorista where condicao = 1 and cod_moto <> 0"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    CbMotorista.Items.Add(CStr(mr.Item("cod_moto")) + " - " + (mr.Item("nome")))
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub pegar_status_moto()
        Using cn As SqlConnection = conexao()
            Dim status As String

            Try
                cn.Open()
                Dim sql As String = "select status_moto from motorista where cod_moto = '" & cod_moto & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                While mr.Read
                    status = mr!status_moto
                    If status = "False" Then
                        CbOperação.Text = "Indisponível"
                    ElseIf status = "True" Then
                        CbOperação.Text = "Disponível"
                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub alt_status_moto()
        Using cn As SqlConnection = conexao()
            Dim status As String
            If CbOperação.Text = "Indisponível" Then
                status = "False"
            Else
                status = "True"
            End If
            Try
                cn.Open()
                Dim sql As String = "update motorista set status_moto = '" & status & "' where cod_moto = " & cod_moto & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub MotoUpdate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carregar_forma()
    End Sub

    Private Sub CbMotorista_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles CbMotorista.SelectedIndexChanged
        If CbMotorista.Text = "" Then
            Exit Sub
        Else
            cod_moto = CbMotorista.Text.Substring(0, CbMotorista.Text.IndexOf(" "))
            pegar_status_moto()
        End If
    End Sub

    Private Sub btnalterar_Click(sender As System.Object, e As System.EventArgs) Handles btnalterar.Click
        If CbMotorista.Text = "" Then
            MessageBox.Show("O campo motorista não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbMotorista.Focus()
            Exit Sub
        ElseIf CbOperação.Text = "" Then
            MessageBox.Show("O campo operação não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbMotorista.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Deseja realmente alterar status do motorista?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                alt_status_moto()
                MessageBox.Show("Motorista alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CbMotorista.SelectedIndex = -1
                CbOperação.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub btnfechar_Click(sender As System.Object, e As System.EventArgs) Handles btnfechar.Click
        If MessageBox.Show("Deseja realmente sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            inicio.Enabled = True
            Me.Close()
        End If
    End Sub
End Class