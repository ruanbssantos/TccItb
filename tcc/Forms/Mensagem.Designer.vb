<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mensagem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mensagem))
        Me.lblmensagem = New System.Windows.Forms.Label()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.btnok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblmensagem
        '
        Me.lblmensagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmensagem.AutoSize = True
        Me.lblmensagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmensagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblmensagem.Location = New System.Drawing.Point(156, 386)
        Me.lblmensagem.Name = "lblmensagem"
        Me.lblmensagem.Size = New System.Drawing.Size(86, 16)
        Me.lblmensagem.TabIndex = 6
        Me.lblmensagem.Text = "MENSAGEM"
        '
        'lbltitulo
        '
        Me.lbltitulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltitulo.Location = New System.Drawing.Point(153, 347)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(112, 31)
        Me.lbltitulo.TabIndex = 5
        Me.lbltitulo.Text = "TÍTULO"
        '
        'btnok
        '
        Me.btnok.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnok.Location = New System.Drawing.Point(485, 410)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(163, 43)
        Me.btnok.TabIndex = 1
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'Mensagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(784, 750)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.lblmensagem)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Mensagem"
        Me.Opacity = 0.9R
        Me.Text = "Erro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmensagem As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents btnok As System.Windows.Forms.Button
End Class
