<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loading
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loading))
        Me.pbcarregar = New System.Windows.Forms.ProgressBar()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblProgresso = New System.Windows.Forms.Label()
        Me.lblpor = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbcarregar
        '
        Me.pbcarregar.BackColor = System.Drawing.Color.White
        Me.pbcarregar.ForeColor = System.Drawing.Color.Gold
        Me.pbcarregar.Location = New System.Drawing.Point(27, 185)
        Me.pbcarregar.Name = "pbcarregar"
        Me.pbcarregar.Size = New System.Drawing.Size(491, 13)
        Me.pbcarregar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbcarregar.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(49, 215)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(444, 20)
        Me.Label14.TabIndex = 159
        Me.Label14.Text = "King Taxi's Company © • Todos os direitos reservados."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.tcc.My.Resources.Resources.AristocratCrown_Transparent_brightgold1
        Me.PictureBox1.Location = New System.Drawing.Point(111, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(315, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 160
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LblProgresso
        '
        Me.LblProgresso.AutoSize = True
        Me.LblProgresso.BackColor = System.Drawing.Color.Transparent
        Me.LblProgresso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProgresso.ForeColor = System.Drawing.Color.White
        Me.LblProgresso.Location = New System.Drawing.Point(24, 167)
        Me.LblProgresso.Name = "LblProgresso"
        Me.LblProgresso.Size = New System.Drawing.Size(82, 15)
        Me.LblProgresso.TabIndex = 161
        Me.LblProgresso.Text = "Carregando"
        Me.LblProgresso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblpor
        '
        Me.lblpor.AutoSize = True
        Me.lblpor.BackColor = System.Drawing.Color.Transparent
        Me.lblpor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpor.ForeColor = System.Drawing.Color.White
        Me.lblpor.Location = New System.Drawing.Point(479, 164)
        Me.lblpor.Name = "lblpor"
        Me.lblpor.Size = New System.Drawing.Size(39, 15)
        Me.lblpor.TabIndex = 163
        Me.lblpor.Text = "00 %"
        Me.lblpor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.tcc.My.Resources.Resources.Fundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(551, 253)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblpor)
        Me.Controls.Add(Me.pbcarregar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LblProgresso)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbcarregar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblProgresso As System.Windows.Forms.Label
    Friend WithEvents lblpor As System.Windows.Forms.Label
End Class
