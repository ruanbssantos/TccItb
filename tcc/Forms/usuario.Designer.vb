<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usuario))
        Me.PainelBotoes = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblcadastro_cliente = New System.Windows.Forms.Label()
        Me.btnfechar = New System.Windows.Forms.PictureBox()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.btnalterar = New System.Windows.Forms.Button()
        Me.TxtConfSenha = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PainelBotoes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnfechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PainelBotoes
        '
        Me.PainelBotoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PainelBotoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PainelBotoes.Controls.Add(Me.PictureBox1)
        Me.PainelBotoes.Controls.Add(Me.lblcadastro_cliente)
        Me.PainelBotoes.Controls.Add(Me.btnfechar)
        Me.PainelBotoes.Location = New System.Drawing.Point(-1, 0)
        Me.PainelBotoes.Name = "PainelBotoes"
        Me.PainelBotoes.Size = New System.Drawing.Size(478, 31)
        Me.PainelBotoes.TabIndex = 28130
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.tcc.My.Resources.Resources.AristocratCrown_Transparent_brightgold
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28156
        Me.PictureBox1.TabStop = False
        '
        'lblcadastro_cliente
        '
        Me.lblcadastro_cliente.AutoSize = True
        Me.lblcadastro_cliente.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcadastro_cliente.ForeColor = System.Drawing.Color.White
        Me.lblcadastro_cliente.Location = New System.Drawing.Point(203, -1)
        Me.lblcadastro_cliente.Name = "lblcadastro_cliente"
        Me.lblcadastro_cliente.Size = New System.Drawing.Size(83, 30)
        Me.lblcadastro_cliente.TabIndex = 24
        Me.lblcadastro_cliente.Text = "Usuário"
        '
        'btnfechar
        '
        Me.btnfechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnfechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnfechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfechar.Image = Global.tcc.My.Resources.Resources.BtnFechar
        Me.btnfechar.Location = New System.Drawing.Point(447, 3)
        Me.btnfechar.Name = "btnfechar"
        Me.btnfechar.Size = New System.Drawing.Size(26, 26)
        Me.btnfechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnfechar.TabIndex = 13
        Me.btnfechar.TabStop = False
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.BackColor = System.Drawing.Color.Transparent
        Me.LblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.Location = New System.Drawing.Point(78, 27)
        Me.LblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(0, 16)
        Me.LblUser.TabIndex = 28162
        '
        'btnalterar
        '
        Me.btnalterar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnalterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnalterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnalterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalterar.ForeColor = System.Drawing.Color.White
        Me.btnalterar.Location = New System.Drawing.Point(376, 53)
        Me.btnalterar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnalterar.Name = "btnalterar"
        Me.btnalterar.Size = New System.Drawing.Size(88, 27)
        Me.btnalterar.TabIndex = 4
        Me.btnalterar.Text = "Alterar"
        Me.btnalterar.UseVisualStyleBackColor = False
        '
        'TxtConfSenha
        '
        Me.TxtConfSenha.Location = New System.Drawing.Point(232, 49)
        Me.TxtConfSenha.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtConfSenha.MaxLength = 30
        Me.TxtConfSenha.Name = "TxtConfSenha"
        Me.TxtConfSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtConfSenha.Size = New System.Drawing.Size(206, 22)
        Me.TxtConfSenha.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(229, 29)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(110, 16)
        Me.Label22.TabIndex = 28160
        Me.Label22.Text = "Confirmar Senha:"
        '
        'TxtSenha
        '
        Me.TxtSenha.Location = New System.Drawing.Point(15, 49)
        Me.TxtSenha.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSenha.MaxLength = 30
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSenha.Size = New System.Drawing.Size(195, 22)
        Me.TxtSenha.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 29)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 16)
        Me.Label18.TabIndex = 28158
        Me.Label18.Text = "Nova Senha: "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(12, 27)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 16)
        Me.Label21.TabIndex = 28157
        Me.Label21.Text = "Usuário:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.LblUser)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 60)
        Me.GroupBox2.TabIndex = 28163
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Identificação"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtConfSenha)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.TxtSenha)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 84)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alteração de senha"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-1, 193)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 31)
        Me.Panel1.TabIndex = 28165
        '
        'usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(477, 224)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnalterar)
        Me.Controls.Add(Me.PainelBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PainelBotoes.ResumeLayout(False)
        Me.PainelBotoes.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnfechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PainelBotoes As System.Windows.Forms.Panel
    Friend WithEvents lblcadastro_cliente As System.Windows.Forms.Label
    Friend WithEvents btnfechar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LblUser As System.Windows.Forms.Label
    Friend WithEvents btnalterar As System.Windows.Forms.Button
    Friend WithEvents TxtConfSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TxtSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
