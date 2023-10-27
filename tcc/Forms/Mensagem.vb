Public Class Mensagem
    Private Sub btnok_Click(sender As System.Object, e As System.EventArgs) Handles btnok.Click
        If Funcionario.Enabled = False Then
            Funcionario.Enabled = True
            Funcionario.Show()
        ElseIf Cliente_Jud.Enabled = False Then
            Cliente_Jud.Enabled = True
            Cliente_Jud.Show()
        ElseIf Cliente_Fis.Enabled = False Then
            Cliente_Fis.Enabled = True
            Cliente_Fis.Show()
        ElseIf Motorista.Enabled = False Then
            Motorista.Enabled = True
            Motorista.Show()
        ElseIf Contas.Enabled = False Then
            Contas.Enabled = True
            Contas.Show()
        End If
        Me.Close()
    End Sub
    Private Sub Mensagem_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Funcionario.Enabled = False Then
            Funcionario.Enabled = True
            Funcionario.Show()
        ElseIf Cliente_Jud.Enabled = False Then
            Cliente_Jud.Enabled = True
            Cliente_Jud.Show()
        ElseIf Cliente_Fis.Enabled = False Then
            Cliente_Fis.Enabled = True
            Cliente_Fis.Show()
        ElseIf Motorista.Enabled = False Then
            Motorista.Enabled = True
            Motorista.Show()
        ElseIf Contas.Enabled = False Then
            Contas.Enabled = True
            Contas.Show()
        End If
        Exit Sub
    End Sub
End Class