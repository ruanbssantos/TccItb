Public Class Bloco_notas
    Dim caminhoabrir As String
    Dim resp As Object
    Dim arquivo_existente As String
    Private Sub SalvarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarToolStripMenuItem.Click
        Try
            If caminhoabrir <> Nothing Then
                Dim write As New System.IO.StreamWriter(caminhoabrir)
                write.Write(TxtTexto.Text)
                write.Close()
                arquivo_existente = TxtTexto.Text
            Else
                Dim caminho As String
                If Salvar.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                    Exit Sub
                Else
                    caminho = Salvar.FileName
                    caminhoabrir = caminho
                    arquivo_existente = TxtTexto.Text
                    Dim text As String
                    text = caminho.Substring(3)
                    Me.Text = text.Substring(0, text.IndexOf(".txt")) + " -  Bloco de notas"
                    Dim write As New System.IO.StreamWriter(caminho)
                    write.Write(TxtTexto.Text)
                    write.Close()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FonteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FonteToolStripMenuItem.Click
        Fonte.ShowDialog()
        TxtTexto.Font = Fonte.Font
    End Sub
    Private Sub CorDaFonteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorDaFonteToolStripMenuItem.Click
        Cor.ShowDialog()
        TxtTexto.ForeColor = Cor.Color
    End Sub
    Private Sub CorDeFundoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorDeFundoToolStripMenuItem.Click
        Cor.ShowDialog()
        TxtTexto.BackColor = Cor.Color
    End Sub
    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        Try
            If TxtTexto.Text <> "" And Me.Text = "Sem título - Bloco de notas" Then
                resp = MessageBox.Show("Deseja salvar as alterações em Sem título?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                Select Case resp
                    Case vbYes
                        Dim caminho As String
                        Salvar.ShowDialog()
                        caminho = Salvar.FileName
                        Dim write As New System.IO.StreamWriter(caminho)
                        write.Write(TxtTexto.Text)
                        write.Close()
                        Abrir.ShowDialog()
                        caminhoabrir = Abrir.FileName
                        Dim arquivo As String = caminhoabrir
                        If IO.File.Exists(arquivo) Then
                            TxtTexto.Text = IO.File.ReadAllText(arquivo)
                            arquivo_existente = IO.File.ReadAllText(arquivo)
                            Dim text As String
                            text = arquivo.Substring(3)
                            Me.Text = text.Substring(0, text.IndexOf(".txt")) + " -  Bloco de notas"
                        End If
                    Case vbNo
                        caminhoabrir = Nothing
                        arquivo_existente = Nothing
                        Abrir.ShowDialog()
                        caminhoabrir = Abrir.FileName
                        Dim arquivo As String = caminhoabrir
                        If IO.File.Exists(arquivo) Then
                            TxtTexto.Text = IO.File.ReadAllText(arquivo)
                            arquivo_existente = IO.File.ReadAllText(arquivo)
                            Dim text As String
                            text = arquivo.Substring(3)
                            Me.Text = text.Substring(0, text.IndexOf(".txt")) + " -  Bloco de notas"
                        End If
                End Select
            ElseIf caminhoabrir <> Nothing And arquivo_existente <> TxtTexto.Text Then
                resp = MessageBox.Show("Deseja salvar as alterações em " & caminhoabrir & " ?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Select Case resp
                    Case vbYes
                        Dim write As New System.IO.StreamWriter(caminhoabrir)
                        write.Write(TxtTexto.Text)
                        write.Close()
                        TxtTexto.Clear()
                        caminhoabrir = Nothing
                        arquivo_existente = Nothing
                        Me.Text = "Sem título - Bloco de notas"
                        Abrir.ShowDialog()
                        caminhoabrir = Abrir.FileName
                        Dim arquivo As String = caminhoabrir
                        If IO.File.Exists(arquivo) Then
                            TxtTexto.Text = IO.File.ReadAllText(arquivo)
                            arquivo_existente = IO.File.ReadAllText(arquivo)
                            Dim text As String
                            text = arquivo.Substring(3)
                            Me.Text = text.Substring(0, text.IndexOf(".txt")) + " -  Bloco de notas"
                        End If
                    Case vbNo
                        caminhoabrir = Nothing
                        arquivo_existente = Nothing
                        Abrir.ShowDialog()
                        caminhoabrir = Abrir.FileName
                        Dim arquivo As String = caminhoabrir
                        Dim text As String
                        text = arquivo.Substring(3)
                        Me.Text = text.Substring(0, text.IndexOf(".txt")) + " -  Bloco de notas"
                        If IO.File.Exists(arquivo) Then
                            TxtTexto.Text = IO.File.ReadAllText(arquivo)
                            arquivo_existente = IO.File.ReadAllText(arquivo)
                        End If
                End Select
            Else
                Abrir.ShowDialog()
                caminhoabrir = Abrir.FileName
                Dim arquivo As String = caminhoabrir
                If IO.File.Exists(arquivo) Then
                    TxtTexto.Text = IO.File.ReadAllText(arquivo)
                    arquivo_existente = IO.File.ReadAllText(arquivo)
                    Dim text As String
                    text = arquivo.Substring(3)
                    Me.Text = text.Substring(0, text.IndexOf(".txt")) + " -  Bloco de notas"
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub LimparTudoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimparTudoToolStripMenuItem.Click
        If MessageBox.Show("Deseja realmente limpar tudo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            TxtTexto.Clear()
        End If
    End Sub
    Private Sub NovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoToolStripMenuItem.Click
        Try
            If TxtTexto.Text <> "" And Me.Text = "Sem título - Bloco de notas" Then
                resp = MessageBox.Show("Deseja salvar as alterações em Sem título?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                Select Case resp
                    Case vbYes
                        Dim caminho As String
                        Salvar.ShowDialog()
                        caminho = Salvar.FileName
                        Dim write As New System.IO.StreamWriter(caminho)
                        write.Write(TxtTexto.Text)
                        write.Close()
                        TxtTexto.Clear()
                        caminhoabrir = Nothing
                        Me.Text = "Sem título - Bloco de notas"
                    Case vbNo
                        TxtTexto.Clear()
                        caminhoabrir = Nothing
                        Me.Text = "Sem título - Bloco de notas"
                        'Case vbCancel
                End Select
            ElseIf caminhoabrir <> Nothing And arquivo_existente <> TxtTexto.Text Then
                resp = MessageBox.Show("Deseja salvar as alterações em " & caminhoabrir & " ?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Select Case resp
                    Case vbYes
                        Dim write As New System.IO.StreamWriter(caminhoabrir)
                        write.Write(TxtTexto.Text)
                        write.Close()
                        TxtTexto.Clear()
                        caminhoabrir = Nothing
                        arquivo_existente = Nothing
                        Me.Text = "Sem título - Bloco de notas"
                    Case vbNo
                        TxtTexto.Clear()
                        arquivo_existente = Nothing
                        caminhoabrir = Nothing
                        Me.Text = "Sem título - Bloco de notas"
                End Select
            Else
                TxtTexto.Clear()
                caminhoabrir = Nothing
                Me.Text = "Sem título - Bloco de notas"
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SalvarComoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarComoToolStripMenuItem.Click
        Try
            Dim caminho As String
            Salvar.ShowDialog()
            caminho = Salvar.FileName
            If caminho = "" Then
                Exit Sub
            Else
                caminhoabrir = caminho
                arquivo_existente = TxtTexto.Text
                Dim text As String
                text = caminho.Substring(3)
                Me.Text = text.Substring(0, text.IndexOf(".txt")) + " -  Bloco de notas"
                Dim write As New System.IO.StreamWriter(caminho)
                write.Write(TxtTexto.Text)
                write.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    'Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
    '    Try
    '        If TxtTexto.Text <> "" And Me.Text = "Sem título - Bloco de notas" Then
    '            resp = MessageBox.Show("Deseja salvar as alterações em Sem título?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
    '            Select Case resp
    '                Case vbYes
    '                    Dim caminho As String
    '                    Salvar.ShowDialog()
    '                    caminho = Salvar.FileName
    '                    Dim write As New System.IO.StreamWriter(caminho)
    '                    write.Write(TxtTexto.Text)
    '                    write.Close()
    '                    Me.Close()
    '                Case vbNo
    '                    Me.Close()
    '            End Select
    '        ElseIf caminhoabrir <> Nothing And arquivo_existente <> TxtTexto.Text Then
    '            resp = MessageBox.Show("Deseja salvar as alterações em " & caminhoabrir & " ?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
    '            Select Case resp
    '                Case vbYes
    '                    Dim write As New System.IO.StreamWriter(caminhoabrir)
    '                    write.Write(TxtTexto.Text)
    '                    write.Close()
    '                    Me.Close()
    '                Case vbNo
    '                    Me.Close()
    '            End Select
    '        Else
    '            Me.Close()
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub
    Private Sub Bloco_notas_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If TxtTexto.Text <> "" And Me.Text = "Sem título - Bloco de notas" Then
                resp = MessageBox.Show("Deseja salvar as alterações em Sem título?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                Select Case resp
                    Case vbYes
                        Dim caminho As String
                        Salvar.ShowDialog()
                        caminho = Salvar.FileName
                        Dim write As New System.IO.StreamWriter(caminho)
                        write.Write(TxtTexto.Text)
                        write.Close()
                        Exit Sub
                    Case vbNo
                        Exit Sub
                End Select
            ElseIf caminhoabrir <> Nothing And arquivo_existente <> TxtTexto.Text Then
                resp = MessageBox.Show("Deseja salvar as alterações em " & caminhoabrir & " ?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Select Case resp
                    Case vbYes
                        Dim write As New System.IO.StreamWriter(caminhoabrir)
                        write.Write(TxtTexto.Text)
                        write.Close()
                        Exit Sub
                    Case vbNo
                        Exit Sub
                End Select
            Else
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
