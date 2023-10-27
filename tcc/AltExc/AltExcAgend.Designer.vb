<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltExcAgend
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltExcAgend))
        Me.txtcodcorri = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnexibir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnAlterarCorAltEx = New System.Windows.Forms.Button()
        Me.cbuf = New System.Windows.Forms.ComboBox()
        Me.cbmoto = New System.Windows.Forms.ComboBox()
        Me.mtbcpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtcodfunc = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtcidade = New System.Windows.Forms.TextBox()
        Me.mtbcep = New System.Windows.Forms.MaskedTextBox()
        Me.txttipoloc = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtbairro = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtcompl = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtnumresid = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mtbhora = New System.Windows.Forms.MaskedTextBox()
        Me.mtbdata = New System.Windows.Forms.MaskedTextBox()
        Me.txtdetcorri = New System.Windows.Forms.TextBox()
        Me.txtlocdest = New System.Windows.Forms.TextBox()
        Me.txtendorigem = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbformapgto = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbcondicao = New System.Windows.Forms.ComboBox()
        Me.mtbcnpj = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PainelBotoes = New System.Windows.Forms.Panel()
        Me.lblcadastro_cliente = New System.Windows.Forms.Label()
        Me.btnfechar = New System.Windows.Forms.PictureBox()
        Me.PainelBotoes.SuspendLayout()
        CType(Me.btnfechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcodcorri
        '
        Me.txtcodcorri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodcorri.Location = New System.Drawing.Point(243, 118)
        Me.txtcodcorri.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcodcorri.Name = "txtcodcorri"
        Me.txtcodcorri.Size = New System.Drawing.Size(116, 22)
        Me.txtcodcorri.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 121)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(186, 16)
        Me.Label11.TabIndex = 164
        Me.Label11.Text = "Código de registro da corrida:"
        '
        'btnexibir
        '
        Me.btnexibir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnexibir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnexibir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexibir.ForeColor = System.Drawing.Color.White
        Me.btnexibir.Location = New System.Drawing.Point(385, 111)
        Me.btnexibir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnexibir.Name = "btnexibir"
        Me.btnexibir.Size = New System.Drawing.Size(98, 27)
        Me.btnexibir.TabIndex = 2
        Me.btnexibir.Text = "Exibir"
        Me.btnexibir.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.White
        Me.btncancelar.Location = New System.Drawing.Point(394, 783)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(88, 27)
        Me.btncancelar.TabIndex = 20
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnAlterarCorAltEx
        '
        Me.btnAlterarCorAltEx.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAlterarCorAltEx.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlterarCorAltEx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterarCorAltEx.ForeColor = System.Drawing.Color.White
        Me.btnAlterarCorAltEx.Location = New System.Drawing.Point(241, 783)
        Me.btnAlterarCorAltEx.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlterarCorAltEx.Name = "btnAlterarCorAltEx"
        Me.btnAlterarCorAltEx.Size = New System.Drawing.Size(98, 27)
        Me.btnAlterarCorAltEx.TabIndex = 19
        Me.btnAlterarCorAltEx.Text = "Alterar"
        Me.btnAlterarCorAltEx.UseVisualStyleBackColor = False
        '
        'cbuf
        '
        Me.cbuf.BackColor = System.Drawing.Color.White
        Me.cbuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbuf.Enabled = False
        Me.cbuf.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbuf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbuf.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbuf.FormattingEnabled = True
        Me.cbuf.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"})
        Me.cbuf.Location = New System.Drawing.Point(74, 573)
        Me.cbuf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbuf.Name = "cbuf"
        Me.cbuf.Size = New System.Drawing.Size(41, 24)
        Me.cbuf.TabIndex = 32
        '
        'cbmoto
        '
        Me.cbmoto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbmoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbmoto.FormattingEnabled = True
        Me.cbmoto.Location = New System.Drawing.Point(135, 288)
        Me.cbmoto.Name = "cbmoto"
        Me.cbmoto.Size = New System.Drawing.Size(140, 24)
        Me.cbmoto.TabIndex = 21
        '
        'mtbcpf
        '
        Me.mtbcpf.BackColor = System.Drawing.Color.White
        Me.mtbcpf.Culture = New System.Globalization.CultureInfo("es-US")
        Me.mtbcpf.Enabled = False
        Me.mtbcpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbcpf.Location = New System.Drawing.Point(135, 212)
        Me.mtbcpf.Mask = "000.000.000-00"
        Me.mtbcpf.Name = "mtbcpf"
        Me.mtbcpf.Size = New System.Drawing.Size(114, 22)
        Me.mtbcpf.TabIndex = 18
        '
        'txtcodfunc
        '
        Me.txtcodfunc.BackColor = System.Drawing.Color.White
        Me.txtcodfunc.Enabled = False
        Me.txtcodfunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodfunc.Location = New System.Drawing.Point(186, 259)
        Me.txtcodfunc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcodfunc.Name = "txtcodfunc"
        Me.txtcodfunc.Size = New System.Drawing.Size(114, 22)
        Me.txtcodfunc.TabIndex = 20
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(30, 265)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(142, 16)
        Me.Label22.TabIndex = 347
        Me.Label22.Text = "Código do funcionario:"
        '
        'txtcidade
        '
        Me.txtcidade.BackColor = System.Drawing.Color.White
        Me.txtcidade.Enabled = False
        Me.txtcidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcidade.Location = New System.Drawing.Point(452, 526)
        Me.txtcidade.Name = "txtcidade"
        Me.txtcidade.Size = New System.Drawing.Size(187, 22)
        Me.txtcidade.TabIndex = 31
        '
        'mtbcep
        '
        Me.mtbcep.BackColor = System.Drawing.Color.White
        Me.mtbcep.Enabled = False
        Me.mtbcep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbcep.Location = New System.Drawing.Point(74, 529)
        Me.mtbcep.Mask = "00000000"
        Me.mtbcep.Name = "mtbcep"
        Me.mtbcep.Size = New System.Drawing.Size(54, 22)
        Me.mtbcep.TabIndex = 29
        '
        'txttipoloc
        '
        Me.txttipoloc.BackColor = System.Drawing.Color.White
        Me.txttipoloc.Enabled = False
        Me.txttipoloc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipoloc.Location = New System.Drawing.Point(297, 575)
        Me.txttipoloc.Margin = New System.Windows.Forms.Padding(4)
        Me.txttipoloc.Name = "txttipoloc"
        Me.txttipoloc.Size = New System.Drawing.Size(339, 22)
        Me.txttipoloc.TabIndex = 33
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(204, 581)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 16)
        Me.Label18.TabIndex = 345
        Me.Label18.Text = "Tipo de local:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(29, 578)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 16)
        Me.Label17.TabIndex = 344
        Me.Label17.Text = "UF:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(380, 531)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 16)
        Me.Label16.TabIndex = 343
        Me.Label16.Text = "Cidade:"
        '
        'txtbairro
        '
        Me.txtbairro.BackColor = System.Drawing.Color.White
        Me.txtbairro.Enabled = False
        Me.txtbairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbairro.Location = New System.Drawing.Point(210, 527)
        Me.txtbairro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbairro.Name = "txtbairro"
        Me.txtbairro.Size = New System.Drawing.Size(132, 22)
        Me.txtbairro.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(154, 531)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 16)
        Me.Label15.TabIndex = 342
        Me.Label15.Text = "Bairro:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(29, 531)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 16)
        Me.Label14.TabIndex = 341
        Me.Label14.Text = "CEP:"
        '
        'txtcompl
        '
        Me.txtcompl.BackColor = System.Drawing.Color.White
        Me.txtcompl.Enabled = False
        Me.txtcompl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompl.Location = New System.Drawing.Point(364, 473)
        Me.txtcompl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcompl.Name = "txtcompl"
        Me.txtcompl.Size = New System.Drawing.Size(276, 22)
        Me.txtcompl.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(261, 479)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 16)
        Me.Label13.TabIndex = 340
        Me.Label13.Text = "Complemento:"
        '
        'txtnumresid
        '
        Me.txtnumresid.BackColor = System.Drawing.Color.White
        Me.txtnumresid.Enabled = False
        Me.txtnumresid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumresid.Location = New System.Drawing.Point(171, 473)
        Me.txtnumresid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnumresid.Name = "txtnumresid"
        Me.txtnumresid.Size = New System.Drawing.Size(77, 22)
        Me.txtnumresid.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(29, 479)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 339
        Me.Label12.Text = "Número:"
        '
        'mtbhora
        '
        Me.mtbhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbhora.Location = New System.Drawing.Point(497, 285)
        Me.mtbhora.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mtbhora.Mask = "00:00"
        Me.mtbhora.Name = "mtbhora"
        Me.mtbhora.Size = New System.Drawing.Size(66, 22)
        Me.mtbhora.TabIndex = 23
        Me.mtbhora.ValidatingType = GetType(Date)
        '
        'mtbdata
        '
        Me.mtbdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbdata.Location = New System.Drawing.Point(346, 286)
        Me.mtbdata.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mtbdata.Mask = "00/00/0000"
        Me.mtbdata.Name = "mtbdata"
        Me.mtbdata.Size = New System.Drawing.Size(90, 22)
        Me.mtbdata.TabIndex = 22
        Me.mtbdata.ValidatingType = GetType(Date)
        '
        'txtdetcorri
        '
        Me.txtdetcorri.BackColor = System.Drawing.Color.White
        Me.txtdetcorri.Enabled = False
        Me.txtdetcorri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetcorri.Location = New System.Drawing.Point(175, 665)
        Me.txtdetcorri.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdetcorri.Multiline = True
        Me.txtdetcorri.Name = "txtdetcorri"
        Me.txtdetcorri.Size = New System.Drawing.Size(461, 80)
        Me.txtdetcorri.TabIndex = 35
        '
        'txtlocdest
        '
        Me.txtlocdest.BackColor = System.Drawing.Color.White
        Me.txtlocdest.Enabled = False
        Me.txtlocdest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlocdest.Location = New System.Drawing.Point(175, 620)
        Me.txtlocdest.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlocdest.Name = "txtlocdest"
        Me.txtlocdest.Size = New System.Drawing.Size(461, 22)
        Me.txtlocdest.TabIndex = 34
        '
        'txtendorigem
        '
        Me.txtendorigem.BackColor = System.Drawing.Color.White
        Me.txtendorigem.Enabled = False
        Me.txtendorigem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtendorigem.Location = New System.Drawing.Point(171, 428)
        Me.txtendorigem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtendorigem.Name = "txtendorigem"
        Me.txtendorigem.Size = New System.Drawing.Size(469, 22)
        Me.txtendorigem.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 665)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 16)
        Me.Label10.TabIndex = 338
        Me.Label10.Text = "Observações:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 295)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 337
        Me.Label7.Text = "Motorista:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(453, 291)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 336
        Me.Label6.Text = "Hora:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(299, 291)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 335
        Me.Label5.Text = "Data:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 625)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 334
        Me.Label4.Text = "Local de destino:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 433)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 16)
        Me.Label3.TabIndex = 333
        Me.Label3.Text = "Endereço de origem:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 218)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 332
        Me.Label2.Text = "CPF do cliente:"
        '
        'cbformapgto
        '
        Me.cbformapgto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbformapgto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbformapgto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbformapgto.FormattingEnabled = True
        Me.cbformapgto.Location = New System.Drawing.Point(186, 331)
        Me.cbformapgto.Margin = New System.Windows.Forms.Padding(4)
        Me.cbformapgto.Name = "cbformapgto"
        Me.cbformapgto.Size = New System.Drawing.Size(140, 24)
        Me.cbformapgto.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 332)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 16)
        Me.Label9.TabIndex = 352
        Me.Label9.Text = "Forma de pagamento :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(371, 335)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 354
        Me.Label8.Text = "Condição:"
        '
        'cbcondicao
        '
        Me.cbcondicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcondicao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbcondicao.FormattingEnabled = True
        Me.cbcondicao.Items.AddRange(New Object() {"Em aberto", "Cancelado", "Concluido"})
        Me.cbcondicao.Location = New System.Drawing.Point(453, 334)
        Me.cbcondicao.Name = "cbcondicao"
        Me.cbcondicao.Size = New System.Drawing.Size(114, 21)
        Me.cbcondicao.TabIndex = 25
        '
        'mtbcnpj
        '
        Me.mtbcnpj.BackColor = System.Drawing.Color.White
        Me.mtbcnpj.Culture = New System.Globalization.CultureInfo("en-US")
        Me.mtbcnpj.Enabled = False
        Me.mtbcnpj.Location = New System.Drawing.Point(422, 211)
        Me.mtbcnpj.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mtbcnpj.Mask = "00.000.000/0000-00"
        Me.mtbcnpj.Name = "mtbcnpj"
        Me.mtbcnpj.Size = New System.Drawing.Size(141, 20)
        Me.mtbcnpj.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(308, 215)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 16)
        Me.Label19.TabIndex = 356
        Me.Label19.Text = "CNPJ do cliente:"
        '
        'PainelBotoes
        '
        Me.PainelBotoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PainelBotoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PainelBotoes.Controls.Add(Me.lblcadastro_cliente)
        Me.PainelBotoes.Controls.Add(Me.btnfechar)
        Me.PainelBotoes.Location = New System.Drawing.Point(1, 1)
        Me.PainelBotoes.Name = "PainelBotoes"
        Me.PainelBotoes.Size = New System.Drawing.Size(682, 31)
        Me.PainelBotoes.TabIndex = 357
        '
        'lblcadastro_cliente
        '
        Me.lblcadastro_cliente.AutoSize = True
        Me.lblcadastro_cliente.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcadastro_cliente.ForeColor = System.Drawing.Color.White
        Me.lblcadastro_cliente.Location = New System.Drawing.Point(204, 1)
        Me.lblcadastro_cliente.Name = "lblcadastro_cliente"
        Me.lblcadastro_cliente.Size = New System.Drawing.Size(244, 30)
        Me.lblcadastro_cliente.TabIndex = 24
        Me.lblcadastro_cliente.Text = "Agendamento da corrida"
        '
        'btnfechar
        '
        Me.btnfechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnfechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnfechar.Image = Global.tcc.My.Resources.Resources.BtnFechar
        Me.btnfechar.Location = New System.Drawing.Point(651, 3)
        Me.btnfechar.Name = "btnfechar"
        Me.btnfechar.Size = New System.Drawing.Size(26, 26)
        Me.btnfechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnfechar.TabIndex = 13
        Me.btnfechar.TabStop = False
        '
        'AltExcAgend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 842)
        Me.ControlBox = False
        Me.Controls.Add(Me.PainelBotoes)
        Me.Controls.Add(Me.mtbcnpj)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbcondicao)
        Me.Controls.Add(Me.cbformapgto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbuf)
        Me.Controls.Add(Me.cbmoto)
        Me.Controls.Add(Me.mtbcpf)
        Me.Controls.Add(Me.txtcodfunc)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtcidade)
        Me.Controls.Add(Me.mtbcep)
        Me.Controls.Add(Me.txttipoloc)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtbairro)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtcompl)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtnumresid)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.mtbhora)
        Me.Controls.Add(Me.mtbdata)
        Me.Controls.Add(Me.txtdetcorri)
        Me.Controls.Add(Me.txtlocdest)
        Me.Controls.Add(Me.txtendorigem)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnAlterarCorAltEx)
        Me.Controls.Add(Me.btnexibir)
        Me.Controls.Add(Me.txtcodcorri)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AltExcAgend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PainelBotoes.ResumeLayout(False)
        Me.PainelBotoes.PerformLayout()
        CType(Me.btnfechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcodcorri As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnexibir As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnAlterarCorAltEx As System.Windows.Forms.Button
    Friend WithEvents cbuf As System.Windows.Forms.ComboBox
    Friend WithEvents cbmoto As System.Windows.Forms.ComboBox
    Friend WithEvents mtbcpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtcodfunc As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtcidade As System.Windows.Forms.TextBox
    Friend WithEvents mtbcep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txttipoloc As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtbairro As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtcompl As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtnumresid As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents mtbhora As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbdata As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtdetcorri As System.Windows.Forms.TextBox
    Friend WithEvents txtlocdest As System.Windows.Forms.TextBox
    Friend WithEvents txtendorigem As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbformapgto As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbcondicao As System.Windows.Forms.ComboBox
    Friend WithEvents mtbcnpj As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PainelBotoes As System.Windows.Forms.Panel
    Friend WithEvents lblcadastro_cliente As System.Windows.Forms.Label
    Friend WithEvents btnfechar As System.Windows.Forms.PictureBox
End Class
