<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(backup))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbRestore = New System.Windows.Forms.RadioButton()
        Me.RbBackup = New System.Windows.Forms.RadioButton()
        Me.localorigem = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnrestaura = New System.Windows.Forms.Button()
        Me.btniniciar = New System.Windows.Forms.Button()
        Me.PainelBotoes = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblcadastro_cliente = New System.Windows.Forms.Label()
        Me.btnfechar = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.PainelBotoes.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnfechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Arquivos de Backup|*.bak"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "bak"
        Me.SaveFileDialog1.Filter = "Arquivo de backup|*.bak"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RbRestore)
        Me.GroupBox1.Controls.Add(Me.RbBackup)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 123)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operação"
        '
        'RbRestore
        '
        Me.RbRestore.AutoSize = True
        Me.RbRestore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.RbRestore.Location = New System.Drawing.Point(15, 73)
        Me.RbRestore.Name = "RbRestore"
        Me.RbRestore.Size = New System.Drawing.Size(74, 20)
        Me.RbRestore.TabIndex = 3
        Me.RbRestore.Text = "Restore"
        Me.RbRestore.UseVisualStyleBackColor = True
        '
        'RbBackup
        '
        Me.RbBackup.AutoSize = True
        Me.RbBackup.Checked = True
        Me.RbBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.RbBackup.Location = New System.Drawing.Point(15, 38)
        Me.RbBackup.Name = "RbBackup"
        Me.RbBackup.Size = New System.Drawing.Size(72, 20)
        Me.RbBackup.TabIndex = 2
        Me.RbBackup.TabStop = True
        Me.RbBackup.Text = "Backup"
        Me.RbBackup.UseVisualStyleBackColor = True
        '
        'localorigem
        '
        Me.localorigem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.localorigem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.localorigem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.localorigem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.localorigem.ForeColor = System.Drawing.Color.White
        Me.localorigem.Location = New System.Drawing.Point(568, 105)
        Me.localorigem.Margin = New System.Windows.Forms.Padding(4)
        Me.localorigem.Name = "localorigem"
        Me.localorigem.Size = New System.Drawing.Size(37, 27)
        Me.localorigem.TabIndex = 4
        Me.localorigem.Text = "..."
        Me.localorigem.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(130, 109)
        Me.TextBox2.MaxLength = 500
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(431, 20)
        Me.TextBox2.TabIndex = 5
        '
        'btnrestaura
        '
        Me.btnrestaura.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnrestaura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrestaura.Enabled = False
        Me.btnrestaura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrestaura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrestaura.ForeColor = System.Drawing.Color.White
        Me.btnrestaura.Location = New System.Drawing.Point(253, 150)
        Me.btnrestaura.Margin = New System.Windows.Forms.Padding(4)
        Me.btnrestaura.Name = "btnrestaura"
        Me.btnrestaura.Size = New System.Drawing.Size(137, 27)
        Me.btnrestaura.TabIndex = 6
        Me.btnrestaura.Text = "Restaurar Backup"
        Me.btnrestaura.UseVisualStyleBackColor = False
        '
        'btniniciar
        '
        Me.btniniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btniniciar.Enabled = False
        Me.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btniniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btniniciar.ForeColor = System.Drawing.Color.White
        Me.btniniciar.Location = New System.Drawing.Point(253, 150)
        Me.btniniciar.Margin = New System.Windows.Forms.Padding(4)
        Me.btniniciar.Name = "btniniciar"
        Me.btniniciar.Size = New System.Drawing.Size(137, 27)
        Me.btniniciar.TabIndex = 28139
        Me.btniniciar.Text = "Iniciar Backup"
        Me.btniniciar.UseVisualStyleBackColor = False
        '
        'PainelBotoes
        '
        Me.PainelBotoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PainelBotoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PainelBotoes.Controls.Add(Me.PictureBox2)
        Me.PainelBotoes.Controls.Add(Me.PictureBox1)
        Me.PainelBotoes.Controls.Add(Me.lblcadastro_cliente)
        Me.PainelBotoes.Controls.Add(Me.btnfechar)
        Me.PainelBotoes.Location = New System.Drawing.Point(0, 0)
        Me.PainelBotoes.Name = "PainelBotoes"
        Me.PainelBotoes.Size = New System.Drawing.Size(619, 31)
        Me.PainelBotoes.TabIndex = 28138
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(556, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28157
        Me.PictureBox2.TabStop = False
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
        Me.lblcadastro_cliente.Location = New System.Drawing.Point(243, 0)
        Me.lblcadastro_cliente.Name = "lblcadastro_cliente"
        Me.lblcadastro_cliente.Size = New System.Drawing.Size(158, 30)
        Me.lblcadastro_cliente.TabIndex = 24
        Me.lblcadastro_cliente.Text = "Backup/Restore"
        '
        'btnfechar
        '
        Me.btnfechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnfechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnfechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfechar.Image = Global.tcc.My.Resources.Resources.BtnFechar
        Me.btnfechar.Location = New System.Drawing.Point(588, 3)
        Me.btnfechar.Name = "btnfechar"
        Me.btnfechar.Size = New System.Drawing.Size(26, 26)
        Me.btnfechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnfechar.TabIndex = 13
        Me.btnfechar.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 198)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 31)
        Me.Panel1.TabIndex = 28144
        '
        'backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(618, 228)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.localorigem)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btniniciar)
        Me.Controls.Add(Me.PainelBotoes)
        Me.Controls.Add(Me.btnrestaura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "backup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PainelBotoes.ResumeLayout(False)
        Me.PainelBotoes.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnfechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbRestore As System.Windows.Forms.RadioButton
    Friend WithEvents RbBackup As System.Windows.Forms.RadioButton
    Friend WithEvents localorigem As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnrestaura As System.Windows.Forms.Button
    Friend WithEvents btniniciar As System.Windows.Forms.Button
    Friend WithEvents PainelBotoes As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblcadastro_cliente As System.Windows.Forms.Label
    Friend WithEvents btnfechar As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
