<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Valor_Corrida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Valor_Corrida))
        Me.btngera = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cbadic = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtkm = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbtipo = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbformapgto = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnconfirmar = New System.Windows.Forms.Button()
        Me.txtpedagio = New System.Windows.Forms.TextBox()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnExibir = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BtnExibir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btngera
        '
        Me.btngera.AllowDrop = True
        Me.btngera.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btngera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btngera.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btngera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngera.ForeColor = System.Drawing.Color.White
        Me.btngera.Location = New System.Drawing.Point(117, 164)
        Me.btngera.Margin = New System.Windows.Forms.Padding(4)
        Me.btngera.Name = "btngera"
        Me.btngera.Size = New System.Drawing.Size(116, 27)
        Me.btngera.TabIndex = 6
        Me.btngera.Text = "Gerar Valor"
        Me.btngera.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(43, 69)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 16)
        Me.Label25.TabIndex = 331
        Me.Label25.Text = "Adicional:"
        '
        'cbadic
        '
        Me.cbadic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbadic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbadic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbadic.FormattingEnabled = True
        Me.cbadic.Location = New System.Drawing.Point(117, 68)
        Me.cbadic.Name = "cbadic"
        Me.cbadic.Size = New System.Drawing.Size(155, 24)
        Me.cbadic.TabIndex = 3
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(80, 107)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 16)
        Me.Label24.TabIndex = 329
        Me.Label24.Text = "KM:"
        '
        'txtkm
        '
        Me.txtkm.BackColor = System.Drawing.Color.White
        Me.txtkm.Enabled = False
        Me.txtkm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkm.Location = New System.Drawing.Point(118, 103)
        Me.txtkm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtkm.MaxLength = 7
        Me.txtkm.Name = "txtkm"
        Me.txtkm.Size = New System.Drawing.Size(67, 22)
        Me.txtkm.TabIndex = 5
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(5, 28)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(105, 16)
        Me.Label23.TabIndex = 327
        Me.Label23.Text = "Tipo de Corrida:"
        '
        'cbtipo
        '
        Me.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbtipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbtipo.FormattingEnabled = True
        Me.cbtipo.Location = New System.Drawing.Point(117, 28)
        Me.cbtipo.Name = "cbtipo"
        Me.cbtipo.Size = New System.Drawing.Size(155, 24)
        Me.cbtipo.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 105)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 16)
        Me.Label21.TabIndex = 336
        Me.Label21.Text = "Total:"
        '
        'cbformapgto
        '
        Me.cbformapgto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbformapgto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbformapgto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbformapgto.FormattingEnabled = True
        Me.cbformapgto.Location = New System.Drawing.Point(11, 48)
        Me.cbformapgto.Margin = New System.Windows.Forms.Padding(4)
        Me.cbformapgto.Name = "cbformapgto"
        Me.cbformapgto.Size = New System.Drawing.Size(140, 24)
        Me.cbformapgto.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 28)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 16)
        Me.Label9.TabIndex = 334
        Me.Label9.Text = "Forma de Pagamento :"
        '
        'btnconfirmar
        '
        Me.btnconfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnconfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnconfirmar.Enabled = False
        Me.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnconfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirmar.ForeColor = System.Drawing.Color.White
        Me.btnconfirmar.Location = New System.Drawing.Point(42, 163)
        Me.btnconfirmar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(98, 27)
        Me.btnconfirmar.TabIndex = 10
        Me.btnconfirmar.Text = "Confirmar"
        Me.btnconfirmar.UseVisualStyleBackColor = False
        '
        'txtpedagio
        '
        Me.txtpedagio.BackColor = System.Drawing.Color.White
        Me.txtpedagio.Enabled = False
        Me.txtpedagio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpedagio.Location = New System.Drawing.Point(289, 69)
        Me.txtpedagio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpedagio.MaxLength = 6
        Me.txtpedagio.Name = "txtpedagio"
        Me.txtpedagio.Size = New System.Drawing.Size(47, 22)
        Me.txtpedagio.TabIndex = 4
        Me.txtpedagio.Text = "00.00"
        '
        'txtvalor
        '
        Me.txtvalor.Enabled = False
        Me.txtvalor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalor.Location = New System.Drawing.Point(11, 124)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.ReadOnly = True
        Me.txtvalor.Size = New System.Drawing.Size(100, 22)
        Me.txtvalor.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 275)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 31)
        Me.Panel1.TabIndex = 339
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnExibir)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.cbtipo)
        Me.GroupBox2.Controls.Add(Me.txtkm)
        Me.GroupBox2.Controls.Add(Me.txtpedagio)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.cbadic)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.btngera)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 208)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gerar Valor"
        '
        'BtnExibir
        '
        Me.BtnExibir.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnExibir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExibir.Image = CType(resources.GetObject("BtnExibir.Image"), System.Drawing.Image)
        Me.BtnExibir.Location = New System.Drawing.Point(192, 101)
        Me.BtnExibir.Name = "BtnExibir"
        Me.BtnExibir.Size = New System.Drawing.Size(26, 26)
        Me.BtnExibir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnExibir.TabIndex = 28151
        Me.BtnExibir.TabStop = False
        Me.BtnExibir.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbformapgto)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.btnconfirmar)
        Me.GroupBox1.Controls.Add(Me.txtvalor)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(392, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 207)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Confirmação"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(580, 31)
        Me.Panel2.TabIndex = 28147
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.tcc.My.Resources.Resources.AristocratCrown_Transparent_brightgold
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 108
        Me.PictureBox1.TabStop = False
        '
        'Valor_Corrida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(580, 306)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Valor_Corrida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BtnExibir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btngera As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbadic As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtkm As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbtipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbformapgto As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents txtpedagio As System.Windows.Forms.TextBox
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnExibir As System.Windows.Forms.PictureBox
End Class
