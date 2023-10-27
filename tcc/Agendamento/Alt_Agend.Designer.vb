<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alt_Agend
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alt_Agend))
        Me.PainelBotoes = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblcadastro_cliente = New System.Windows.Forms.Label()
        Me.btnfechar = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblnome = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpHora = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbformapgto = New System.Windows.Forms.ComboBox()
        Me.DtpData = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblcod = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.txtobservacoes = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PainelBotoes.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnfechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
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
        Me.PainelBotoes.Location = New System.Drawing.Point(-1, 0)
        Me.PainelBotoes.Name = "PainelBotoes"
        Me.PainelBotoes.Size = New System.Drawing.Size(430, 31)
        Me.PainelBotoes.TabIndex = 357
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(367, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 359
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.tcc.My.Resources.Resources.AristocratCrown_Transparent_brightgold
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 358
        Me.PictureBox1.TabStop = False
        '
        'lblcadastro_cliente
        '
        Me.lblcadastro_cliente.AutoSize = True
        Me.lblcadastro_cliente.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcadastro_cliente.ForeColor = System.Drawing.Color.White
        Me.lblcadastro_cliente.Location = New System.Drawing.Point(111, 1)
        Me.lblcadastro_cliente.Name = "lblcadastro_cliente"
        Me.lblcadastro_cliente.Size = New System.Drawing.Size(203, 30)
        Me.lblcadastro_cliente.TabIndex = 24
        Me.lblcadastro_cliente.Text = "Alteração da Corrida"
        '
        'btnfechar
        '
        Me.btnfechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnfechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnfechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfechar.Image = Global.tcc.My.Resources.Resources.BtnFechar
        Me.btnfechar.Location = New System.Drawing.Point(399, 3)
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
        Me.Panel1.Location = New System.Drawing.Point(-1, 374)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 31)
        Me.Panel1.TabIndex = 358
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lblnome)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.DtpHora)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cbformapgto)
        Me.GroupBox3.Controls.Add(Me.DtpData)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(401, 153)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informações"
        '
        'lblnome
        '
        Me.lblnome.AutoSize = True
        Me.lblnome.Location = New System.Drawing.Point(11, 48)
        Me.lblnome.Name = "lblnome"
        Me.lblnome.Size = New System.Drawing.Size(45, 16)
        Me.lblnome.TabIndex = 28150
        Me.lblnome.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 28149
        Me.Label2.Text = "Nome do Cliente:"
        '
        'DtpHora
        '
        Me.DtpHora.CustomFormat = ""
        Me.DtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpHora.Location = New System.Drawing.Point(141, 101)
        Me.DtpHora.Name = "DtpHora"
        Me.DtpHora.ShowUpDown = True
        Me.DtpHora.Size = New System.Drawing.Size(85, 22)
        Me.DtpHora.TabIndex = 3
        Me.DtpHora.Value = New Date(2015, 8, 25, 15, 36, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(238, 82)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 16)
        Me.Label9.TabIndex = 28148
        Me.Label9.Text = "Forma de Pagamento :"
        '
        'cbformapgto
        '
        Me.cbformapgto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbformapgto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbformapgto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbformapgto.FormattingEnabled = True
        Me.cbformapgto.Location = New System.Drawing.Point(241, 99)
        Me.cbformapgto.Margin = New System.Windows.Forms.Padding(4)
        Me.cbformapgto.Name = "cbformapgto"
        Me.cbformapgto.Size = New System.Drawing.Size(141, 24)
        Me.cbformapgto.TabIndex = 4
        '
        'DtpData
        '
        Me.DtpData.CustomFormat = ""
        Me.DtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpData.Location = New System.Drawing.Point(14, 101)
        Me.DtpData.Name = "DtpData"
        Me.DtpData.Size = New System.Drawing.Size(116, 22)
        Me.DtpData.TabIndex = 2
        Me.DtpData.Value = New Date(2015, 8, 15, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 82)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 385
        Me.Label5.Text = "Data:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(138, 82)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 386
        Me.Label6.Text = "Hora:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblcod)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 79)
        Me.GroupBox1.TabIndex = 28145
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Código"
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcod.Location = New System.Drawing.Point(138, 35)
        Me.lblcod.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(52, 16)
        Me.lblcod.TabIndex = 390
        Me.lblcod.Text = "Código"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 35)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 16)
        Me.Label11.TabIndex = 389
        Me.Label11.Text = "Código da Corrida:"
        '
        'BtnAlt
        '
        Me.BtnAlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAlt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlt.ForeColor = System.Drawing.Color.White
        Me.BtnAlt.Location = New System.Drawing.Point(325, 61)
        Me.BtnAlt.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(88, 27)
        Me.BtnAlt.TabIndex = 7
        Me.BtnAlt.Text = "Alterar"
        Me.BtnAlt.UseVisualStyleBackColor = False
        '
        'txtobservacoes
        '
        Me.txtobservacoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservacoes.Location = New System.Drawing.Point(14, 27)
        Me.txtobservacoes.Margin = New System.Windows.Forms.Padding(4)
        Me.txtobservacoes.MaxLength = 144
        Me.txtobservacoes.Multiline = True
        Me.txtobservacoes.Name = "txtobservacoes"
        Me.txtobservacoes.Size = New System.Drawing.Size(368, 51)
        Me.txtobservacoes.TabIndex = 6
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.txtobservacoes)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 281)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(401, 87)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Observações"
        '
        'Alt_Agend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(428, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PainelBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Alt_Agend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PainelBotoes.ResumeLayout(False)
        Me.PainelBotoes.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnfechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PainelBotoes As System.Windows.Forms.Panel
    Friend WithEvents lblcadastro_cliente As System.Windows.Forms.Label
    Friend WithEvents btnfechar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DtpHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbformapgto As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAlt As System.Windows.Forms.Button
    Friend WithEvents txtobservacoes As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcod As System.Windows.Forms.Label
    Friend WithEvents lblnome As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
