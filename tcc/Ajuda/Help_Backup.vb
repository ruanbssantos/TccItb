Public Class Help_Backup
    Private Sub Help_Backup_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        backup.Enabled = True
    End Sub
End Class