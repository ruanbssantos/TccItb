<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Moto_Update
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Moto_Update))
        Me.btnalterar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PainelBotoes = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblcadastro_cliente = New System.Windows.Forms.Label()
        Me.btnfechar = New System.Windows.Forms.PictureBox()
        Me.DgvUpdateMotorista = New System.Windows.Forms.DataGridView()
        Me.PainelBotoes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnfechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvUpdateMotorista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnalterar
        '
        Me.btnalterar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnalterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnalterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnalterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalterar.ForeColor = System.Drawing.Color.White
        Me.btnalterar.Location = New System.Drawing.Point(121, 328)
        Me.btnalterar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnalterar.Name = "btnalterar"
        Me.btnalterar.Size = New System.Drawing.Size(88, 27)
        Me.btnalterar.TabIndex = 2
        Me.btnalterar.Text = "Alterar"
        Me.btnalterar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(1, 376)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 31)
        Me.Panel1.TabIndex = 28147
        '
        'PainelBotoes
        '
        Me.PainelBotoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PainelBotoes.Controls.Add(Me.PictureBox1)
        Me.PainelBotoes.Controls.Add(Me.lblcadastro_cliente)
        Me.PainelBotoes.Controls.Add(Me.btnfechar)
        Me.PainelBotoes.Location = New System.Drawing.Point(0, 0)
        Me.PainelBotoes.Name = "PainelBotoes"
        Me.PainelBotoes.Size = New System.Drawing.Size(329, 31)
        Me.PainelBotoes.TabIndex = 28146
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
        Me.lblcadastro_cliente.Location = New System.Drawing.Point(114, 1)
        Me.lblcadastro_cliente.Name = "lblcadastro_cliente"
        Me.lblcadastro_cliente.Size = New System.Drawing.Size(102, 30)
        Me.lblcadastro_cliente.TabIndex = 24
        Me.lblcadastro_cliente.Text = "Motorista"
        '
        'btnfechar
        '
        Me.btnfechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnfechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnfechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfechar.Image = Global.tcc.My.Resources.Resources.BtnFechar
        Me.btnfechar.Location = New System.Drawing.Point(298, 3)
        Me.btnfechar.Name = "btnfechar"
        Me.btnfechar.Size = New System.Drawing.Size(26, 26)
        Me.btnfechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnfechar.TabIndex = 13
        Me.btnfechar.TabStop = False
        '
        'DgvUpdateMotorista
        '
        Me.DgvUpdateMotorista.AllowUserToAddRows = False
        Me.DgvUpdateMotorista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgvUpdateMotorista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvUpdateMotorista.BackgroundColor = System.Drawing.Color.White
        Me.DgvUpdateMotorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUpdateMotorista.Location = New System.Drawing.Point(12, 60)
        Me.DgvUpdateMotorista.Name = "DgvUpdateMotorista"
        Me.DgvUpdateMotorista.RowHeadersVisible = False
        Me.DgvUpdateMotorista.RowHeadersWidth = 50
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DgvUpdateMotorista.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvUpdateMotorista.Size = New System.Drawing.Size(303, 244)
        Me.DgvUpdateMotorista.StandardTab = True
        Me.DgvUpdateMotorista.TabIndex = 1
        '
        'Moto_Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.DgvUpdateMotorista)
        Me.Controls.Add(Me.PainelBotoes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnalterar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Moto_Update"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PainelBotoes.ResumeLayout(False)
        Me.PainelBotoes.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnfechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvUpdateMotorista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnalterar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PainelBotoes As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblcadastro_cliente As System.Windows.Forms.Label
    Friend WithEvents btnfechar As System.Windows.Forms.PictureBox
    Friend WithEvents DgvUpdateMotorista As System.Windows.Forms.DataGridView
End Class
