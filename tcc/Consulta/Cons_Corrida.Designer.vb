<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cons_Corrida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cons_Corrida))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.cbfiltro = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PainelBotoes = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblcadastro_cliente = New System.Windows.Forms.Label()
        Me.btnfechar = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnExibir = New System.Windows.Forms.PictureBox()
        Me.DgvConsCorri = New System.Windows.Forms.DataGridView()
        Me.CmsDgvConsulta = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelarPendente = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.InformaçõesDaCorridaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PainelBotoes.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnfechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnExibir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvConsCorri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsDgvConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtfiltro
        '
        Me.txtfiltro.BackColor = System.Drawing.Color.White
        Me.txtfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfiltro.Location = New System.Drawing.Point(235, 58)
        Me.txtfiltro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(550, 22)
        Me.txtfiltro.TabIndex = 2
        '
        'cbfiltro
        '
        Me.cbfiltro.BackColor = System.Drawing.Color.White
        Me.cbfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbfiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbfiltro.FormattingEnabled = True
        Me.cbfiltro.Items.AddRange(New Object() {"Todos", "Código da Corrida", "Código do Motorista", "CPF do Cliente", "CNPJ do Cliente", "Data da Corrida", "Status"})
        Me.cbfiltro.Location = New System.Drawing.Point(72, 56)
        Me.cbfiltro.Name = "cbfiltro"
        Me.cbfiltro.Size = New System.Drawing.Size(156, 24)
        Me.cbfiltro.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(25, 58)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 16)
        Me.Label14.TabIndex = 179
        Me.Label14.Text = "Filtro:"
        '
        'PainelBotoes
        '
        Me.PainelBotoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PainelBotoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.PainelBotoes.Controls.Add(Me.PictureBox2)
        Me.PainelBotoes.Controls.Add(Me.PictureBox1)
        Me.PainelBotoes.Controls.Add(Me.lblcadastro_cliente)
        Me.PainelBotoes.Controls.Add(Me.btnfechar)
        Me.PainelBotoes.Location = New System.Drawing.Point(-1, 0)
        Me.PainelBotoes.Name = "PainelBotoes"
        Me.PainelBotoes.Size = New System.Drawing.Size(848, 31)
        Me.PainelBotoes.TabIndex = 405
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(785, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 107
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.tcc.My.Resources.Resources.AristocratCrown_Transparent_brightgold
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 105
        Me.PictureBox1.TabStop = False
        '
        'lblcadastro_cliente
        '
        Me.lblcadastro_cliente.AutoSize = True
        Me.lblcadastro_cliente.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcadastro_cliente.ForeColor = System.Drawing.Color.White
        Me.lblcadastro_cliente.Location = New System.Drawing.Point(328, -1)
        Me.lblcadastro_cliente.Name = "lblcadastro_cliente"
        Me.lblcadastro_cliente.Size = New System.Drawing.Size(196, 30)
        Me.lblcadastro_cliente.TabIndex = 24
        Me.lblcadastro_cliente.Text = "Consulta de Corrida"
        '
        'btnfechar
        '
        Me.btnfechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnfechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnfechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfechar.Image = Global.tcc.My.Resources.Resources.BtnFechar
        Me.btnfechar.Location = New System.Drawing.Point(817, 3)
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
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-1, 404)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(848, 31)
        Me.Panel1.TabIndex = 406
        '
        'BtnExibir
        '
        Me.BtnExibir.BackColor = System.Drawing.Color.Transparent
        Me.BtnExibir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExibir.Image = CType(resources.GetObject("BtnExibir.Image"), System.Drawing.Image)
        Me.BtnExibir.Location = New System.Drawing.Point(792, 58)
        Me.BtnExibir.Name = "BtnExibir"
        Me.BtnExibir.Size = New System.Drawing.Size(26, 26)
        Me.BtnExibir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnExibir.TabIndex = 28153
        Me.BtnExibir.TabStop = False
        '
        'DgvConsCorri
        '
        Me.DgvConsCorri.AllowUserToAddRows = False
        Me.DgvConsCorri.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgvConsCorri.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvConsCorri.BackgroundColor = System.Drawing.Color.White
        Me.DgvConsCorri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsCorri.ContextMenuStrip = Me.CmsDgvConsulta
        Me.DgvConsCorri.Location = New System.Drawing.Point(28, 93)
        Me.DgvConsCorri.Name = "DgvConsCorri"
        Me.DgvConsCorri.ReadOnly = True
        Me.DgvConsCorri.RowHeadersVisible = False
        Me.DgvConsCorri.RowHeadersWidth = 50
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DgvConsCorri.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvConsCorri.Size = New System.Drawing.Size(790, 295)
        Me.DgvConsCorri.StandardTab = True
        Me.DgvConsCorri.TabIndex = 3
        '
        'CmsDgvConsulta
        '
        Me.CmsDgvConsulta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.CancelarPendente, Me.ToolStripSeparator8, Me.InformaçõesDaCorridaToolStripMenuItem1})
        Me.CmsDgvConsulta.Name = "CmsDgv"
        Me.CmsDgvConsulta.Size = New System.Drawing.Size(197, 60)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(193, 6)
        '
        'CancelarPendente
        '
        Me.CancelarPendente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarPendente.Name = "CancelarPendente"
        Me.CancelarPendente.Size = New System.Drawing.Size(196, 22)
        Me.CancelarPendente.Text = "Cancelar corrida"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(193, 6)
        '
        'InformaçõesDaCorridaToolStripMenuItem1
        '
        Me.InformaçõesDaCorridaToolStripMenuItem1.Name = "InformaçõesDaCorridaToolStripMenuItem1"
        Me.InformaçõesDaCorridaToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.InformaçõesDaCorridaToolStripMenuItem1.Text = "Informações da corrida"
        '
        'Cons_Corrida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(847, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me.DgvConsCorri)
        Me.Controls.Add(Me.BtnExibir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PainelBotoes)
        Me.Controls.Add(Me.txtfiltro)
        Me.Controls.Add(Me.cbfiltro)
        Me.Controls.Add(Me.Label14)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Cons_Corrida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PainelBotoes.ResumeLayout(False)
        Me.PainelBotoes.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnfechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnExibir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvConsCorri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsDgvConsulta.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents cbfiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PainelBotoes As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblcadastro_cliente As System.Windows.Forms.Label
    Friend WithEvents btnfechar As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnExibir As System.Windows.Forms.PictureBox
    Friend WithEvents DgvConsCorri As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CmsDgvConsulta As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelarPendente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InformaçõesDaCorridaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
