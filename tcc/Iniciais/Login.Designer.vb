<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsenha = New System.Windows.Forms.TextBox()
        Me.btnentrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(15, 131)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 16)
        Me.Label14.TabIndex = 158
        Me.Label14.Text = "Nome de Usuário:"
        '
        'txtnome
        '
        Me.txtnome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.Location = New System.Drawing.Point(136, 129)
        Me.txtnome.MaxLength = 15
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(220, 22)
        Me.txtnome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(81, 166)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Senha:"
        '
        'txtsenha
        '
        Me.txtsenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsenha.Location = New System.Drawing.Point(136, 164)
        Me.txtsenha.MaxLength = 30
        Me.txtsenha.Name = "txtsenha"
        Me.txtsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsenha.Size = New System.Drawing.Size(220, 22)
        Me.txtsenha.TabIndex = 2
        '
        'btnentrar
        '
        Me.btnentrar.BackColor = System.Drawing.Color.White
        Me.btnentrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnentrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnentrar.ForeColor = System.Drawing.Color.Black
        Me.btnentrar.Location = New System.Drawing.Point(141, 211)
        Me.btnentrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnentrar.Name = "btnentrar"
        Me.btnentrar.Size = New System.Drawing.Size(98, 27)
        Me.btnentrar.TabIndex = 3
        Me.btnentrar.Text = "Entrar"
        Me.btnentrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.tcc.My.Resources.Resources.padlock_closed_inv
        Me.PictureBox1.Location = New System.Drawing.Point(52, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 165
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(136, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 29)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "Acesso"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuStrip2.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(15, 3, 0, 3)
        Me.MenuStrip2.Size = New System.Drawing.Size(391, 41)
        Me.MenuStrip2.TabIndex = 167
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SairToolStripMenuItem1.AutoSize = False
        Me.SairToolStripMenuItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SairToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.SairToolStripMenuItem1.Image = Global.tcc.My.Resources.Resources.logout_xxl
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(110, 30)
        Me.SairToolStripMenuItem1.Text = "Sair"
        Me.SairToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(391, 260)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnentrar)
        Me.Controls.Add(Me.txtsenha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsenha As System.Windows.Forms.TextBox
    Friend WithEvents btnentrar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents SairToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
