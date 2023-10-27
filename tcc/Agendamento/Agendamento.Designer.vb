<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agendamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agendamento))
        Me.lblcodfunc = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.mtbcnpj = New System.Windows.Forms.MaskedTextBox()
        Me.rbclijud = New System.Windows.Forms.RadioButton()
        Me.rbclifisi = New System.Windows.Forms.RadioButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblcod = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnconfirma = New System.Windows.Forms.Button()
        Me.txtobservacoes = New System.Windows.Forms.TextBox()
        Me.txtlocdest = New System.Windows.Forms.TextBox()
        Me.txtendorigem = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.PainelBotoes = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblcadastro_cliente = New System.Windows.Forms.Label()
        Me.btnfechar = New System.Windows.Forms.PictureBox()
        Me.DtpData = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DtpHora = New System.Windows.Forms.DateTimePicker()
        Me.mtbcpf = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtCidade = New System.Windows.Forms.TextBox()
        Me.CbUf = New System.Windows.Forms.ComboBox()
        Me.TxtCompl = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCep = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.TxtBairro = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbnao = New System.Windows.Forms.RadioButton()
        Me.rbsim = New System.Windows.Forms.RadioButton()
        Me.PainelBotoes.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnfechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblcodfunc
        '
        Me.lblcodfunc.AutoSize = True
        Me.lblcodfunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodfunc.Location = New System.Drawing.Point(160, 22)
        Me.lblcodfunc.Name = "lblcodfunc"
        Me.lblcodfunc.Size = New System.Drawing.Size(52, 16)
        Me.lblcodfunc.TabIndex = 402
        Me.lblcodfunc.Text = "Código"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 496)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(708, 31)
        Me.Panel2.TabIndex = 401
        '
        'mtbcnpj
        '
        Me.mtbcnpj.BackColor = System.Drawing.Color.White
        Me.mtbcnpj.Culture = New System.Globalization.CultureInfo("en-US")
        Me.mtbcnpj.Location = New System.Drawing.Point(14, 44)
        Me.mtbcnpj.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mtbcnpj.Mask = "00.000.000/0000-00"
        Me.mtbcnpj.Name = "mtbcnpj"
        Me.mtbcnpj.Size = New System.Drawing.Size(141, 22)
        Me.mtbcnpj.TabIndex = 366
        Me.mtbcnpj.Visible = False
        '
        'rbclijud
        '
        Me.rbclijud.AutoSize = True
        Me.rbclijud.Location = New System.Drawing.Point(131, 36)
        Me.rbclijud.Name = "rbclijud"
        Me.rbclijud.Size = New System.Drawing.Size(117, 20)
        Me.rbclijud.TabIndex = 21
        Me.rbclijud.Text = "Cliente Jurídico"
        Me.rbclijud.UseVisualStyleBackColor = True
        '
        'rbclifisi
        '
        Me.rbclifisi.AutoSize = True
        Me.rbclifisi.Checked = True
        Me.rbclifisi.Location = New System.Drawing.Point(16, 35)
        Me.rbclifisi.Name = "rbclifisi"
        Me.rbclifisi.Size = New System.Drawing.Size(106, 20)
        Me.rbclifisi.TabIndex = 20
        Me.rbclifisi.TabStop = True
        Me.rbclifisi.Text = "Cliente Físico"
        Me.rbclifisi.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(11, 22)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(147, 16)
        Me.Label22.TabIndex = 397
        Me.Label22.Text = "Código do Funcionario:"
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcod.Location = New System.Drawing.Point(137, 44)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(52, 16)
        Me.lblcod.TabIndex = 396
        Me.lblcod.Text = "Código"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 44)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 16)
        Me.Label11.TabIndex = 389
        Me.Label11.Text = "Código da Corrida:"
        '
        'btnconfirma
        '
        Me.btnconfirma.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnconfirma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnconfirma.Enabled = False
        Me.btnconfirma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnconfirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirma.ForeColor = System.Drawing.Color.White
        Me.btnconfirma.Location = New System.Drawing.Point(597, 65)
        Me.btnconfirma.Margin = New System.Windows.Forms.Padding(4)
        Me.btnconfirma.Name = "btnconfirma"
        Me.btnconfirma.Size = New System.Drawing.Size(98, 27)
        Me.btnconfirma.TabIndex = 18
        Me.btnconfirma.Text = "Continuar"
        Me.btnconfirma.UseVisualStyleBackColor = False
        '
        'txtobservacoes
        '
        Me.txtobservacoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservacoes.Location = New System.Drawing.Point(12, 25)
        Me.txtobservacoes.Margin = New System.Windows.Forms.Padding(4)
        Me.txtobservacoes.MaxLength = 144
        Me.txtobservacoes.Multiline = True
        Me.txtobservacoes.Name = "txtobservacoes"
        Me.txtobservacoes.Size = New System.Drawing.Size(501, 53)
        Me.txtobservacoes.TabIndex = 17
        '
        'txtlocdest
        '
        Me.txtlocdest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlocdest.Location = New System.Drawing.Point(14, 152)
        Me.txtlocdest.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlocdest.MaxLength = 100
        Me.txtlocdest.Name = "txtlocdest"
        Me.txtlocdest.Size = New System.Drawing.Size(662, 22)
        Me.txtlocdest.TabIndex = 13
        '
        'txtendorigem
        '
        Me.txtendorigem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtendorigem.Location = New System.Drawing.Point(175, 48)
        Me.txtendorigem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtendorigem.MaxLength = 100
        Me.txtendorigem.Name = "txtendorigem"
        Me.txtendorigem.Size = New System.Drawing.Size(240, 22)
        Me.txtendorigem.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(327, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 386
        Me.Label6.Text = "Hora:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(172, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 385
        Me.Label5.Text = "Data:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 384
        Me.Label4.Text = "Local de Destino:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(172, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 383
        Me.Label3.Text = "Endereço de Origem:"
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.Location = New System.Drawing.Point(11, 25)
        Me.lblmsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(100, 16)
        Me.lblmsg.TabIndex = 382
        Me.lblmsg.Text = "CPF do Cliente:"
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
        Me.PainelBotoes.Size = New System.Drawing.Size(708, 31)
        Me.PainelBotoes.TabIndex = 403
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(645, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 108
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.tcc.My.Resources.Resources.AristocratCrown_Transparent_brightgold
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 107
        Me.PictureBox1.TabStop = False
        '
        'lblcadastro_cliente
        '
        Me.lblcadastro_cliente.AutoSize = True
        Me.lblcadastro_cliente.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcadastro_cliente.ForeColor = System.Drawing.Color.White
        Me.lblcadastro_cliente.Location = New System.Drawing.Point(229, -1)
        Me.lblcadastro_cliente.Name = "lblcadastro_cliente"
        Me.lblcadastro_cliente.Size = New System.Drawing.Size(247, 30)
        Me.lblcadastro_cliente.TabIndex = 24
        Me.lblcadastro_cliente.Text = "Agendamento da Corrida"
        '
        'btnfechar
        '
        Me.btnfechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnfechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnfechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfechar.Image = Global.tcc.My.Resources.Resources.BtnFechar
        Me.btnfechar.Location = New System.Drawing.Point(677, 3)
        Me.btnfechar.Name = "btnfechar"
        Me.btnfechar.Size = New System.Drawing.Size(26, 26)
        Me.btnfechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnfechar.TabIndex = 13
        Me.btnfechar.TabStop = False
        '
        'DtpData
        '
        Me.DtpData.CustomFormat = ""
        Me.DtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpData.Location = New System.Drawing.Point(175, 44)
        Me.DtpData.Name = "DtpData"
        Me.DtpData.Size = New System.Drawing.Size(135, 22)
        Me.DtpData.TabIndex = 3
        Me.DtpData.Value = New Date(2015, 8, 15, 0, 0, 0, 0)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rbclijud)
        Me.GroupBox2.Controls.Add(Me.rbclifisi)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox2.Location = New System.Drawing.Point(259, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 79)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblcod)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblcodfunc)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 79)
        Me.GroupBox1.TabIndex = 28138
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Código"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.DtpHora)
        Me.GroupBox3.Controls.Add(Me.lblmsg)
        Me.GroupBox3.Controls.Add(Me.DtpData)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.mtbcpf)
        Me.GroupBox3.Controls.Add(Me.mtbcnpj)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(415, 73)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informações"
        '
        'DtpHora
        '
        Me.DtpHora.CustomFormat = ""
        Me.DtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpHora.Location = New System.Drawing.Point(330, 44)
        Me.DtpHora.Name = "DtpHora"
        Me.DtpHora.ShowUpDown = True
        Me.DtpHora.Size = New System.Drawing.Size(66, 22)
        Me.DtpHora.TabIndex = 4
        Me.DtpHora.Value = New Date(2015, 8, 25, 15, 36, 0, 0)
        '
        'mtbcpf
        '
        Me.mtbcpf.BackColor = System.Drawing.Color.White
        Me.mtbcpf.Culture = New System.Globalization.CultureInfo("es-US")
        Me.mtbcpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbcpf.Location = New System.Drawing.Point(14, 44)
        Me.mtbcpf.Mask = "000.000.000-00"
        Me.mtbcpf.Name = "mtbcpf"
        Me.mtbcpf.Size = New System.Drawing.Size(141, 22)
        Me.mtbcpf.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.TxtCidade)
        Me.GroupBox4.Controls.Add(Me.CbUf)
        Me.GroupBox4.Controls.Add(Me.TxtCompl)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.TxtCep)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtlocdest)
        Me.GroupBox4.Controls.Add(Me.TxtNum)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.TxtBairro)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtendorigem)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 201)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(683, 187)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rota"
        '
        'TxtCidade
        '
        Me.TxtCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCidade.Location = New System.Drawing.Point(436, 48)
        Me.TxtCidade.MaxLength = 50
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Size = New System.Drawing.Size(176, 22)
        Me.TxtCidade.TabIndex = 8
        '
        'CbUf
        '
        Me.CbUf.BackColor = System.Drawing.Color.White
        Me.CbUf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbUf.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CbUf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbUf.FormattingEnabled = True
        Me.CbUf.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"})
        Me.CbUf.Location = New System.Drawing.Point(623, 48)
        Me.CbUf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CbUf.Name = "CbUf"
        Me.CbUf.Size = New System.Drawing.Size(53, 24)
        Me.CbUf.TabIndex = 9
        '
        'TxtCompl
        '
        Me.TxtCompl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCompl.Location = New System.Drawing.Point(436, 101)
        Me.TxtCompl.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCompl.MaxLength = 50
        Me.TxtCompl.Name = "TxtCompl"
        Me.TxtCompl.Size = New System.Drawing.Size(240, 22)
        Me.TxtCompl.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(620, 28)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 16)
        Me.Label16.TabIndex = 397
        Me.Label16.Text = "UF:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(433, 28)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 16)
        Me.Label15.TabIndex = 396
        Me.Label15.Text = "Cidade:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(433, 81)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 16)
        Me.Label13.TabIndex = 395
        Me.Label13.Text = "Complemento:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 81)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 391
        Me.Label12.Text = "Número:"
        '
        'TxtCep
        '
        Me.TxtCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCep.Location = New System.Drawing.Point(14, 48)
        Me.TxtCep.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCep.MaxLength = 8
        Me.TxtCep.Name = "TxtCep"
        Me.TxtCep.Size = New System.Drawing.Size(141, 22)
        Me.TxtCep.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 389
        Me.Label2.Text = "CEP:"
        '
        'TxtNum
        '
        Me.TxtNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNum.Location = New System.Drawing.Point(14, 101)
        Me.TxtNum.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNum.MaxLength = 4
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(141, 22)
        Me.TxtNum.TabIndex = 10
        '
        'TxtBairro
        '
        Me.TxtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBairro.Location = New System.Drawing.Point(175, 101)
        Me.TxtBairro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBairro.MaxLength = 70
        Me.TxtBairro.Name = "TxtBairro"
        Me.TxtBairro.Size = New System.Drawing.Size(240, 22)
        Me.TxtBairro.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(172, 81)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 16)
        Me.Label14.TabIndex = 388
        Me.Label14.Text = "Bairro:"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.txtobservacoes)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox5.Location = New System.Drawing.Point(175, 394)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(520, 96)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Observações"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbnao)
        Me.GroupBox6.Controls.Add(Me.rbsim)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 394)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(153, 96)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Blindagem"
        '
        'rbnao
        '
        Me.rbnao.AutoSize = True
        Me.rbnao.Checked = True
        Me.rbnao.Location = New System.Drawing.Point(82, 43)
        Me.rbnao.Name = "rbnao"
        Me.rbnao.Size = New System.Drawing.Size(48, 19)
        Me.rbnao.TabIndex = 15
        Me.rbnao.TabStop = True
        Me.rbnao.Text = "Não"
        Me.rbnao.UseVisualStyleBackColor = True
        '
        'rbsim
        '
        Me.rbsim.AutoSize = True
        Me.rbsim.Location = New System.Drawing.Point(14, 43)
        Me.rbsim.Name = "rbsim"
        Me.rbsim.Size = New System.Drawing.Size(47, 19)
        Me.rbsim.TabIndex = 15
        Me.rbsim.Text = "Sim"
        Me.rbsim.UseVisualStyleBackColor = True
        '
        'Agendamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(708, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PainelBotoes)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnconfirma)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Agendamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PainelBotoes.ResumeLayout(False)
        Me.PainelBotoes.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnfechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblcodfunc As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents mtbcnpj As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rbclijud As System.Windows.Forms.RadioButton
    Friend WithEvents rbclifisi As System.Windows.Forms.RadioButton
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblcod As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnconfirma As System.Windows.Forms.Button
    Friend WithEvents txtobservacoes As System.Windows.Forms.TextBox
    Friend WithEvents txtlocdest As System.Windows.Forms.TextBox
    Friend WithEvents txtendorigem As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblmsg As System.Windows.Forms.Label
    Friend WithEvents PainelBotoes As System.Windows.Forms.Panel
    Friend WithEvents lblcadastro_cliente As System.Windows.Forms.Label
    Friend WithEvents btnfechar As System.Windows.Forms.PictureBox
    Friend WithEvents DtpData As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCep As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNum As System.Windows.Forms.TextBox
    Friend WithEvents TxtBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtCidade As System.Windows.Forms.TextBox
    Friend WithEvents CbUf As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCompl As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DtpHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents mtbcpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbnao As System.Windows.Forms.RadioButton
    Friend WithEvents rbsim As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
