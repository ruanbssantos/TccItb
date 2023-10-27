Imports System.Data.SqlClient
Public Class backup
    Private Sub btnfechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfechar.Click
        'If MessageBox.Show("Deseja realmente sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        inicio.Enabled = True
        Me.Close()
        'End If
    End Sub
    Private Sub btniniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btniniciar.Click
        Dim sqlUtils As New SQLSERVER
        Dim caminho As String = SaveFileDialog1.FileName
        Dim conexaoSQLServer As String = "Server=.;UID=sa;PWD=123456;"
        'Dim conexaoSQLServer As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Master"
        Try
            sqlUtils.BackupDatabase(conexaoSQLServer, "DBTaxi", caminho)
            MessageBox.Show("Backup do banco de dados realizado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            inicio.Enabled = True
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub btnrestaura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestaura.Click
        'Dim conexaoSQLServer As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Master"
        Dim conexaoSQLServer As String = "Server=.;UID=sa;PWD=123456;"
        Dim sqlUtils As New SQLSERVER
        Dim caminho As String = OpenFileDialog1.FileName
        Try
            sqlUtils.RestauraDatabase(conexaoSQLServer, "DBTaxi", caminho)
            MessageBox.Show("O programa será reinicializado para completar a restauração.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
            Process.Start(Application.ExecutablePath)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub localorigem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles localorigem.Click
        If RbBackup.Checked = True Then
            SaveFileDialog1.ShowDialog()
        ElseIf RbRestore.Checked = True Then
            OpenFileDialog1.ShowDialog()
        End If
    End Sub
    Private Sub OpenFileDialog1_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        TextBox2.Text = OpenFileDialog1.FileName
        btnrestaura.Enabled = True
    End Sub
    Private Sub RbBackup_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbBackup.CheckedChanged
        If RbBackup.Checked = True Then
            btniniciar.Visible = True
            btnrestaura.Visible = False
        ElseIf RbRestore.Checked = True Then
            btnrestaura.Visible = True
            btniniciar.Visible = False
        End If
    End Sub
    Private Sub SaveFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        TextBox2.Text = SaveFileDialog1.FileName
        btniniciar.Enabled = True
    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Enabled = False
        Help_Backup.Show()
    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If RbBackup.Checked = True Then
                btniniciar.PerformClick()
            ElseIf RbRestore.Checked = True Then
                btnrestaura.PerformClick()
            End If
        End If
    End Sub
    Private Sub backup_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        inicio.Enabled = True
        Exit Sub
    End Sub
End Class


