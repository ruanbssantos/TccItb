<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PainelBotoes = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblcadastro_cliente = New System.Windows.Forms.Label()
        Me.BtnFechar = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbCliJud = New System.Windows.Forms.RadioButton()
        Me.RbCliFis = New System.Windows.Forms.RadioButton()
        Me.RbMoto = New System.Windows.Forms.RadioButton()
        Me.RbFunc = New System.Windows.Forms.RadioButton()
        Me.gbstatus = New System.Windows.Forms.GroupBox()
        Me.RbInativo = New System.Windows.Forms.RadioButton()
        Me.RbAtivo = New System.Windows.Forms.RadioButton()
        Me.CbFiltro = New System.Windows.Forms.ComboBox()
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.DgvConsulta = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PbFoto = New System.Windows.Forms.PictureBox()
        Me.BtnExibir = New System.Windows.Forms.PictureBox()
        Me.PainelBotoes.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbstatus.SuspendLayout()
        CType(Me.DgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PainelBotoes.Location = New System.Drawing.Point(-1, 0)
        Me.PainelBotoes.Name = "PainelBotoes"
        Me.PainelBotoes.Size = New System.Drawing.Size(1148, 31)
        Me.PainelBotoes.TabIndex = 415
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1085, 3)
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
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 28157
        Me.PictureBox1.TabStop = False
        '
        'lblcadastro_cliente
        '
        Me.lblcadastro_cliente.AutoSize = True
        Me.lblcadastro_cliente.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcadastro_cliente.ForeColor = System.Drawing.Color.White
        Me.lblcadastro_cliente.Location = New System.Drawing.Point(498, 1)
        Me.lblcadastro_cliente.Name = "lblcadastro_cliente"
        Me.lblcadastro_cliente.Size = New System.Drawing.Size(94, 30)
        Me.lblcadastro_cliente.TabIndex = 24
        Me.lblcadastro_cliente.Text = "Consulta"
        '
        'BtnFechar
        '
        Me.BtnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFechar.Image = Global.tcc.My.Resources.Resources.BtnFechar
        Me.BtnFechar.Location = New System.Drawing.Point(1117, 3)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(26, 26)
        Me.BtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnFechar.TabIndex = 13
        Me.BtnFechar.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(200, 71)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 16)
        Me.Label14.TabIndex = 412
        Me.Label14.Text = "Filtro:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RbCliJud)
        Me.GroupBox1.Controls.Add(Me.RbCliFis)
        Me.GroupBox1.Controls.Add(Me.RbMoto)
        Me.GroupBox1.Controls.Add(Me.RbFunc)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 183)
        Me.GroupBox1.TabIndex = 422
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cadastro"
        '
        'RbCliJud
        '
        Me.RbCliJud.AutoSize = True
        Me.RbCliJud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbCliJud.Location = New System.Drawing.Point(32, 65)
        Me.RbCliJud.Name = "RbCliJud"
        Me.RbCliJud.Size = New System.Drawing.Size(98, 17)
        Me.RbCliJud.TabIndex = 4
        Me.RbCliJud.Text = "Cliente Jurídico"
        Me.RbCliJud.UseVisualStyleBackColor = True
        '
        'RbCliFis
        '
        Me.RbCliFis.AutoSize = True
        Me.RbCliFis.Checked = True
        Me.RbCliFis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbCliFis.Location = New System.Drawing.Point(32, 28)
        Me.RbCliFis.Name = "RbCliFis"
        Me.RbCliFis.Size = New System.Drawing.Size(89, 17)
        Me.RbCliFis.TabIndex = 3
        Me.RbCliFis.TabStop = True
        Me.RbCliFis.Text = "Cliente Físico"
        Me.RbCliFis.UseVisualStyleBackColor = True
        '
        'RbMoto
        '
        Me.RbMoto.AutoSize = True
        Me.RbMoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbMoto.Location = New System.Drawing.Point(32, 143)
        Me.RbMoto.Name = "RbMoto"
        Me.RbMoto.Size = New System.Drawing.Size(68, 17)
        Me.RbMoto.TabIndex = 6
        Me.RbMoto.Text = "Motorista"
        Me.RbMoto.UseVisualStyleBackColor = True
        '
        'RbFunc
        '
        Me.RbFunc.AutoSize = True
        Me.RbFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbFunc.Location = New System.Drawing.Point(32, 104)
        Me.RbFunc.Name = "RbFunc"
        Me.RbFunc.Size = New System.Drawing.Size(80, 17)
        Me.RbFunc.TabIndex = 5
        Me.RbFunc.Text = "Funcionário"
        Me.RbFunc.UseVisualStyleBackColor = True
        '
        'gbstatus
        '
        Me.gbstatus.BackColor = System.Drawing.Color.Transparent
        Me.gbstatus.Controls.Add(Me.RbInativo)
        Me.gbstatus.Controls.Add(Me.RbAtivo)
        Me.gbstatus.Location = New System.Drawing.Point(12, 287)
        Me.gbstatus.Name = "gbstatus"
        Me.gbstatus.Size = New System.Drawing.Size(175, 106)
        Me.gbstatus.TabIndex = 423
        Me.gbstatus.TabStop = False
        Me.gbstatus.Text = "Status"
        '
        'RbInativo
        '
        Me.RbInativo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RbInativo.AutoSize = True
        Me.RbInativo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbInativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbInativo.Location = New System.Drawing.Point(32, 61)
        Me.RbInativo.Name = "RbInativo"
        Me.RbInativo.Size = New System.Drawing.Size(60, 19)
        Me.RbInativo.TabIndex = 8
        Me.RbInativo.Text = "Inativo"
        Me.RbInativo.UseVisualStyleBackColor = True
        '
        'RbAtivo
        '
        Me.RbAtivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RbAtivo.AutoSize = True
        Me.RbAtivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbAtivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbAtivo.Location = New System.Drawing.Point(32, 29)
        Me.RbAtivo.Name = "RbAtivo"
        Me.RbAtivo.Size = New System.Drawing.Size(50, 19)
        Me.RbAtivo.TabIndex = 7
        Me.RbAtivo.Text = "Ativo"
        Me.RbAtivo.UseVisualStyleBackColor = True
        '
        'CbFiltro
        '
        Me.CbFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CbFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbFiltro.FormattingEnabled = True
        Me.CbFiltro.Location = New System.Drawing.Point(256, 68)
        Me.CbFiltro.Name = "CbFiltro"
        Me.CbFiltro.Size = New System.Drawing.Size(114, 24)
        Me.CbFiltro.TabIndex = 1
        '
        'TxtFiltro
        '
        Me.TxtFiltro.BackColor = System.Drawing.Color.White
        Me.TxtFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFiltro.Location = New System.Drawing.Point(392, 70)
        Me.TxtFiltro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(568, 22)
        Me.TxtFiltro.TabIndex = 2
        '
        'DgvConsulta
        '
        Me.DgvConsulta.AllowUserToAddRows = False
        Me.DgvConsulta.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgvConsulta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvConsulta.BackgroundColor = System.Drawing.Color.White
        Me.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsulta.Location = New System.Drawing.Point(205, 98)
        Me.DgvConsulta.Name = "DgvConsulta"
        Me.DgvConsulta.ReadOnly = True
        Me.DgvConsulta.RowHeadersVisible = False
        Me.DgvConsulta.RowHeadersWidth = 50
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DgvConsulta.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvConsulta.Size = New System.Drawing.Size(790, 295)
        Me.DgvConsulta.StandardTab = True
        Me.DgvConsulta.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-1, 425)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1148, 31)
        Me.Panel1.TabIndex = 28153
        '
        'PbFoto
        '
        Me.PbFoto.BackgroundImage = CType(resources.GetObject("PbFoto.BackgroundImage"), System.Drawing.Image)
        Me.PbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PbFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbFoto.Location = New System.Drawing.Point(1001, 98)
        Me.PbFoto.Name = "PbFoto"
        Me.PbFoto.Size = New System.Drawing.Size(133, 141)
        Me.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbFoto.TabIndex = 28152
        Me.PbFoto.TabStop = False
        '
        'BtnExibir
        '
        Me.BtnExibir.BackColor = System.Drawing.Color.Transparent
        Me.BtnExibir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExibir.Image = CType(resources.GetObject("BtnExibir.Image"), System.Drawing.Image)
        Me.BtnExibir.Location = New System.Drawing.Point(967, 68)
        Me.BtnExibir.Name = "BtnExibir"
        Me.BtnExibir.Size = New System.Drawing.Size(26, 26)
        Me.BtnExibir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnExibir.TabIndex = 28150
        Me.BtnExibir.TabStop = False
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1146, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PbFoto)
        Me.Controls.Add(Me.DgvConsulta)
        Me.Controls.Add(Me.BtnExibir)
        Me.Controls.Add(Me.CbFiltro)
        Me.Controls.Add(Me.TxtFiltro)
        Me.Controls.Add(Me.gbstatus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PainelBotoes)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Consultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PainelBotoes.ResumeLayout(False)
        Me.PainelBotoes.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbstatus.ResumeLayout(False)
        Me.gbstatus.PerformLayout()
        CType(Me.DgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnExibir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnFechar As System.Windows.Forms.PictureBox
    Friend WithEvents PainelBotoes As System.Windows.Forms.Panel
    Friend WithEvents lblcadastro_cliente As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbCliJud As System.Windows.Forms.RadioButton
    Friend WithEvents RbCliFis As System.Windows.Forms.RadioButton
    Friend WithEvents RbMoto As System.Windows.Forms.RadioButton
    Friend WithEvents RbFunc As System.Windows.Forms.RadioButton
    Friend WithEvents gbstatus As System.Windows.Forms.GroupBox
    Friend WithEvents RbInativo As System.Windows.Forms.RadioButton
    Friend WithEvents RbAtivo As System.Windows.Forms.RadioButton
    Friend WithEvents CbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents DgvConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents PbFoto As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnExibir As System.Windows.Forms.PictureBox
End Class
