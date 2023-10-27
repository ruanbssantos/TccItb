<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bloco_notas
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LimparTudoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FonteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorDaFonteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorDeFundoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cor = New System.Windows.Forms.ColorDialog()
        Me.Fonte = New System.Windows.Forms.FontDialog()
        Me.Abrir = New System.Windows.Forms.OpenFileDialog()
        Me.Salvar = New System.Windows.Forms.SaveFileDialog()
        Me.TxtTexto = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.FormatoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(454, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.SalvarToolStripMenuItem, Me.SalvarComoToolStripMenuItem, Me.ToolStripSeparator1, Me.LimparTudoToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NovoToolStripMenuItem.Text = "Novo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir..."
        '
        'SalvarToolStripMenuItem
        '
        Me.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        Me.SalvarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalvarToolStripMenuItem.Text = "Salvar"
        '
        'SalvarComoToolStripMenuItem
        '
        Me.SalvarComoToolStripMenuItem.Name = "SalvarComoToolStripMenuItem"
        Me.SalvarComoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalvarComoToolStripMenuItem.Text = "Salvar como..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'LimparTudoToolStripMenuItem
        '
        Me.LimparTudoToolStripMenuItem.Name = "LimparTudoToolStripMenuItem"
        Me.LimparTudoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LimparTudoToolStripMenuItem.Text = "Limpar tudo"
        '
        'FormatoToolStripMenuItem
        '
        Me.FormatoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FonteToolStripMenuItem, Me.CorToolStripMenuItem})
        Me.FormatoToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        Me.FormatoToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.FormatoToolStripMenuItem.Text = "Formatar"
        '
        'FonteToolStripMenuItem
        '
        Me.FonteToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FonteToolStripMenuItem.Name = "FonteToolStripMenuItem"
        Me.FonteToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.FonteToolStripMenuItem.Text = "Fonte"
        '
        'CorToolStripMenuItem
        '
        Me.CorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CorDaFonteToolStripMenuItem, Me.CorDeFundoToolStripMenuItem})
        Me.CorToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorToolStripMenuItem.Name = "CorToolStripMenuItem"
        Me.CorToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.CorToolStripMenuItem.Text = "Cor"
        '
        'CorDaFonteToolStripMenuItem
        '
        Me.CorDaFonteToolStripMenuItem.Name = "CorDaFonteToolStripMenuItem"
        Me.CorDaFonteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CorDaFonteToolStripMenuItem.Text = "Cor da fonte"
        '
        'CorDeFundoToolStripMenuItem
        '
        Me.CorDeFundoToolStripMenuItem.Name = "CorDeFundoToolStripMenuItem"
        Me.CorDeFundoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CorDeFundoToolStripMenuItem.Text = "Cor de fundo"
        '
        'Abrir
        '
        Me.Abrir.Filter = "Arquivo De Texto (*.txt)|*.txt"
        Me.Abrir.Title = "Arquivo de texto"
        '
        'Salvar
        '
        Me.Salvar.Filter = "Arquivo De Texto (*.txt)|*.txt"
        Me.Salvar.Title = "Salvar arquivo de texto"
        '
        'TxtTexto
        '
        Me.TxtTexto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtTexto.Location = New System.Drawing.Point(0, 24)
        Me.TxtTexto.Multiline = True
        Me.TxtTexto.Name = "TxtTexto"
        Me.TxtTexto.Size = New System.Drawing.Size(454, 336)
        Me.TxtTexto.TabIndex = 1
        '
        'Bloco_notas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 360)
        Me.Controls.Add(Me.TxtTexto)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.Name = "Bloco_notas"
        Me.Text = "Sem título - Bloco de notas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalvarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LimparTudoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FonteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Cor As System.Windows.Forms.ColorDialog
    Friend WithEvents Fonte As System.Windows.Forms.FontDialog
    Friend WithEvents Abrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Salvar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CorDaFonteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CorDeFundoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TxtTexto As System.Windows.Forms.TextBox
    Friend WithEvents NovoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalvarComoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
