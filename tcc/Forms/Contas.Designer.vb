<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PainelBotoes = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblcadastro_cliente = New System.Windows.Forms.Label()
        Me.BtnFechar = New System.Windows.Forms.PictureBox()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnconfirma = New System.Windows.Forms.Button()
        Me.txtdescconta = New System.Windows.Forms.TextBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.btnalterar = New System.Windows.Forms.Button()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.cbfiltro = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DtpPgto = New System.Windows.Forms.DateTimePicker()
        Me.DtpVenc = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnConsultar = New System.Windows.Forms.PictureBox()
        Me.DgvConsconta = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbCad = New System.Windows.Forms.RadioButton()
        Me.RbAltExc = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnExibir = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PainelBotoes.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BtnConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvConsconta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.BtnExibir, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PainelBotoes.Controls.Add(Me.BtnFechar)
        Me.PainelBotoes.Location = New System.Drawing.Point(0, 0)
        Me.PainelBotoes.Name = "PainelBotoes"
        Me.PainelBotoes.Size = New System.Drawing.Size(655, 31)
        Me.PainelBotoes.TabIndex = 416
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(592, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28158
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.tcc.My.Resources.Resources.AristocratCrown_Transparent_brightgold
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28157
        Me.PictureBox1.TabStop = False
        '
        'lblcadastro_cliente
        '
        Me.lblcadastro_cliente.AutoSize = True
        Me.lblcadastro_cliente.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcadastro_cliente.ForeColor = System.Drawing.Color.White
        Me.lblcadastro_cliente.Location = New System.Drawing.Point(273, -1)
        Me.lblcadastro_cliente.Name = "lblcadastro_cliente"
        Me.lblcadastro_cliente.Size = New System.Drawing.Size(77, 30)
        Me.lblcadastro_cliente.TabIndex = 24
        Me.lblcadastro_cliente.Text = "Contas"
        '
        'BtnFechar
        '
        Me.BtnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFechar.Image = Global.tcc.My.Resources.Resources.BtnFechar
        Me.BtnFechar.Location = New System.Drawing.Point(624, 3)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(27, 26)
        Me.BtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnFechar.TabIndex = 13
        Me.BtnFechar.TabStop = False
        '
        'txtvalor
        '
        Me.txtvalor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtvalor.Location = New System.Drawing.Point(485, 48)
        Me.txtvalor.MaxLength = 7
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(128, 21)
        Me.txtvalor.TabIndex = 4
        Me.txtvalor.Text = "0,00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(241, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 16)
        Me.Label3.TabIndex = 426
        Me.Label3.Text = "Data de Pagamento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(482, 29)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 425
        Me.Label6.Text = "Valor da Conta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 29)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 16)
        Me.Label4.TabIndex = 424
        Me.Label4.Text = "Data de Vencimento:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 87)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 16)
        Me.Label14.TabIndex = 423
        Me.Label14.Text = "Descrição da Conta:"
        '
        'btnconfirma
        '
        Me.btnconfirma.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnconfirma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnconfirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirma.ForeColor = System.Drawing.Color.White
        Me.btnconfirma.Location = New System.Drawing.Point(542, 60)
        Me.btnconfirma.Margin = New System.Windows.Forms.Padding(4)
        Me.btnconfirma.Name = "btnconfirma"
        Me.btnconfirma.Size = New System.Drawing.Size(98, 27)
        Me.btnconfirma.TabIndex = 6
        Me.btnconfirma.Text = "Cadastrar"
        Me.btnconfirma.UseVisualStyleBackColor = False
        '
        'txtdescconta
        '
        Me.txtdescconta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtdescconta.Location = New System.Drawing.Point(13, 106)
        Me.txtdescconta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtdescconta.MaxLength = 50
        Me.txtdescconta.Multiline = True
        Me.txtdescconta.Name = "txtdescconta"
        Me.txtdescconta.Size = New System.Drawing.Size(600, 56)
        Me.txtdescconta.TabIndex = 5
        '
        'txtcod
        '
        Me.txtcod.BackColor = System.Drawing.Color.White
        Me.txtcod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtcod.Location = New System.Drawing.Point(125, 30)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(46, 21)
        Me.txtcod.TabIndex = 431
        '
        'btnalterar
        '
        Me.btnalterar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnalterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnalterar.Enabled = False
        Me.btnalterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnalterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalterar.ForeColor = System.Drawing.Color.White
        Me.btnalterar.Location = New System.Drawing.Point(542, 60)
        Me.btnalterar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnalterar.Name = "btnalterar"
        Me.btnalterar.Size = New System.Drawing.Size(98, 27)
        Me.btnalterar.TabIndex = 7
        Me.btnalterar.Text = "Alterar"
        Me.btnalterar.UseVisualStyleBackColor = False
        '
        'txtfiltro
        '
        Me.txtfiltro.BackColor = System.Drawing.Color.White
        Me.txtfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfiltro.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtfiltro.Location = New System.Drawing.Point(209, 29)
        Me.txtfiltro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(371, 22)
        Me.txtfiltro.TabIndex = 10
        '
        'cbfiltro
        '
        Me.cbfiltro.BackColor = System.Drawing.Color.White
        Me.cbfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbfiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbfiltro.FormattingEnabled = True
        Me.cbfiltro.Items.AddRange(New Object() {"Todos", "Código", "Data de Pagamento", "Data de Vencimento", "Descrição"})
        Me.cbfiltro.Location = New System.Drawing.Point(57, 28)
        Me.cbfiltro.Name = "cbfiltro"
        Me.cbfiltro.Size = New System.Drawing.Size(145, 24)
        Me.cbfiltro.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 437
        Me.Label1.Text = "Filtro:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.DtpPgto)
        Me.GroupBox3.Controls.Add(Me.DtpVenc)
        Me.GroupBox3.Controls.Add(Me.txtdescconta)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtvalor)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(629, 173)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dados"
        '
        'DtpPgto
        '
        Me.DtpPgto.CustomFormat = ""
        Me.DtpPgto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpPgto.Location = New System.Drawing.Point(244, 48)
        Me.DtpPgto.Name = "DtpPgto"
        Me.DtpPgto.Size = New System.Drawing.Size(191, 22)
        Me.DtpPgto.TabIndex = 3
        Me.DtpPgto.Value = New Date(2015, 8, 15, 0, 0, 0, 0)
        '
        'DtpVenc
        '
        Me.DtpVenc.CustomFormat = ""
        Me.DtpVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpVenc.Location = New System.Drawing.Point(13, 48)
        Me.DtpVenc.Name = "DtpVenc"
        Me.DtpVenc.Size = New System.Drawing.Size(190, 22)
        Me.DtpVenc.TabIndex = 2
        Me.DtpVenc.Value = New Date(2015, 8, 15, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnConsultar)
        Me.GroupBox1.Controls.Add(Me.DgvConsconta)
        Me.GroupBox1.Controls.Add(Me.cbfiltro)
        Me.GroupBox1.Controls.Add(Me.txtfiltro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(629, 313)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta"
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.Color.Transparent
        Me.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConsultar.Image = CType(resources.GetObject("BtnConsultar.Image"), System.Drawing.Image)
        Me.BtnConsultar.Location = New System.Drawing.Point(587, 26)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(26, 26)
        Me.BtnConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnConsultar.TabIndex = 28153
        Me.BtnConsultar.TabStop = False
        '
        'DgvConsconta
        '
        Me.DgvConsconta.AllowUserToAddRows = False
        Me.DgvConsconta.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgvConsconta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvConsconta.BackgroundColor = System.Drawing.Color.White
        Me.DgvConsconta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsconta.Location = New System.Drawing.Point(13, 58)
        Me.DgvConsconta.Name = "DgvConsconta"
        Me.DgvConsconta.ReadOnly = True
        Me.DgvConsconta.RowHeadersVisible = False
        Me.DgvConsconta.RowHeadersWidth = 50
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DgvConsconta.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvConsconta.Size = New System.Drawing.Size(603, 239)
        Me.DgvConsconta.StandardTab = True
        Me.DgvConsconta.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RbCad)
        Me.GroupBox2.Controls.Add(Me.RbAltExc)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(203, 73)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operação"
        '
        'RbCad
        '
        Me.RbCad.AutoSize = True
        Me.RbCad.Checked = True
        Me.RbCad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbCad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.RbCad.Location = New System.Drawing.Point(13, 30)
        Me.RbCad.Name = "RbCad"
        Me.RbCad.Size = New System.Drawing.Size(81, 20)
        Me.RbCad.TabIndex = 13
        Me.RbCad.TabStop = True
        Me.RbCad.Text = "Cadastro"
        Me.RbCad.UseVisualStyleBackColor = True
        '
        'RbAltExc
        '
        Me.RbAltExc.AutoSize = True
        Me.RbAltExc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbAltExc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.RbAltExc.Location = New System.Drawing.Point(100, 31)
        Me.RbAltExc.Name = "RbAltExc"
        Me.RbAltExc.Size = New System.Drawing.Size(84, 20)
        Me.RbAltExc.TabIndex = 14
        Me.RbAltExc.Text = "Alteração"
        Me.RbAltExc.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.BtnExibir)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtcod)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox4.Location = New System.Drawing.Point(221, 37)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(226, 73)
        Me.GroupBox4.TabIndex = 28143
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Código"
        '
        'BtnExibir
        '
        Me.BtnExibir.BackColor = System.Drawing.Color.Transparent
        Me.BtnExibir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExibir.Image = CType(resources.GetObject("BtnExibir.Image"), System.Drawing.Image)
        Me.BtnExibir.Location = New System.Drawing.Point(177, 27)
        Me.BtnExibir.Name = "BtnExibir"
        Me.BtnExibir.Size = New System.Drawing.Size(26, 26)
        Me.BtnExibir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnExibir.TabIndex = 28147
        Me.BtnExibir.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 28132
        Me.Label2.Text = "Código da Conta:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 614)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(655, 31)
        Me.Panel2.TabIndex = 28145
        '
        'Contas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(653, 645)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PainelBotoes)
        Me.Controls.Add(Me.btnalterar)
        Me.Controls.Add(Me.btnconfirma)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Contas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PainelBotoes.ResumeLayout(False)
        Me.PainelBotoes.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BtnConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvConsconta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.BtnExibir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PainelBotoes As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblcadastro_cliente As System.Windows.Forms.Label
    Friend WithEvents BtnFechar As System.Windows.Forms.PictureBox
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnconfirma As System.Windows.Forms.Button
    Friend WithEvents txtdescconta As System.Windows.Forms.TextBox
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents btnalterar As System.Windows.Forms.Button
    Friend WithEvents txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents cbfiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbCad As System.Windows.Forms.RadioButton
    Friend WithEvents RbAltExc As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnExibir As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DgvConsconta As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DtpPgto As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpVenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnConsultar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
