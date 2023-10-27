Public Class loading

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If (pbcarregar.Value < 100) Then
            pbcarregar.Value = pbcarregar.Value + 1
            lblpor.Text = pbcarregar.Value & " " & "%"
            If pbcarregar.Value = 16 Then
                LblProgresso.Text = "Carregando sistema"
            ElseIf pbcarregar.Value = 28 Then
                LblProgresso.Text = "Carregando o banco de dados"
            ElseIf pbcarregar.Value = 40 Then
                LblProgresso.Text = "Carregando padrões do windows"
            ElseIf pbcarregar.Value = 52 Then
                LblProgresso.Text = "Carregando configurações de proprietário"
            ElseIf pbcarregar.Value = 64 Then
                LblProgresso.Text = "Carregando informações do usuário"
            ElseIf pbcarregar.Value = 76 Then
                LblProgresso.Text = "Carregando layout do sistema"
            ElseIf pbcarregar.Value = 88 Then
                LblProgresso.Text = "Carregamento do sistema completo"
            ElseIf pbcarregar.Value = 100 Then
           
            'lblpor.Text = pbcarregar.Value & " " & "%"
            'If pbcarregar.Value = 5 Then
            '    LblProgresso.Text = "Carregando."
            'ElseIf pbcarregar.Value = 10 Then
            '    LblProgresso.Text = "Carregando.."
            'ElseIf pbcarregar.Value = 15 Then
            '    LblProgresso.Text = "Carregando..."
            'ElseIf pbcarregar.Value = 20 Then
            '    LblProgresso.Text = "Carregando."
            'ElseIf pbcarregar.Value = 25 Then
            '    LblProgresso.Text = "Carregando.."
            'ElseIf pbcarregar.Value = 30 Then
            '    LblProgresso.Text = "Carregando..."
            'ElseIf pbcarregar.Value = 35 Then
            '    LblProgresso.Text = "Carregando."
            'ElseIf pbcarregar.Value = 40 Then
            '    LblProgresso.Text = "Carregando.."
            'ElseIf pbcarregar.Value = 45 Then
            '    LblProgresso.Text = "Carregando..."
            'ElseIf pbcarregar.Value = 50 Then
            '    LblProgresso.Text = "Carregando."
            'ElseIf pbcarregar.Value = 55 Then
            '    LblProgresso.Text = "Carregando.."
            'ElseIf pbcarregar.Value = 60 Then
            '    LblProgresso.Text = "Carregando..."
            'ElseIf pbcarregar.Value = 65 Then
            '    LblProgresso.Text = "Carregando."
            'ElseIf pbcarregar.Value = 70 Then
            '    LblProgresso.Text = "Carregando.."
            'ElseIf pbcarregar.Value = 75 Then
            '    LblProgresso.Text = "Carregando..."
            'ElseIf pbcarregar.Value = 80 Then
            '    LblProgresso.Text = "Carregando."
            'ElseIf pbcarregar.Value = 85 Then
            '    LblProgresso.Text = "Carregando.."
            'ElseIf pbcarregar.Value = 90 Then
            '    LblProgresso.Text = "Carregando..."
            'ElseIf pbcarregar.Value = 95 Then
            '    LblProgresso.Text = "Carregamento completo"
            'ElseIf pbcarregar.Value = 100 Then
            Timer1.Enabled = False
            inicio.Show()
            Me.Close()
        End If
        End If
    End Sub
End Class