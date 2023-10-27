Imports System.Data.SqlClient
Public Class inicio
    Dim hora As String
    Private Sub inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Renderer = New ToolStripProfessionalRenderer(New CorMenu())
        CmsDgvAberto.RenderMode = ToolStripRenderMode.Professional
        CmsDgvAberto.Renderer = New ToolStripProfessionalRenderer(New CorMenu())
        CmsDgvEmAndamento.RenderMode = ToolStripRenderMode.Professional
        CmsDgvEmAndamento.Renderer = New ToolStripProfessionalRenderer(New CorMenu())
        LblUsuario.Text = "Usuário: " + Login.txtnome.Text
        LblData.Text = "Data: " + Today
        Timer1.Start()
        Timer2.Start()
        carregar_corridas_abertas()
        carregar_corridas_em_andamento()
    End Sub
    Private Sub SairDoProgramaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairDoProgramaToolStripMenuItem.Click
        If MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub TrocarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrocarUsuarioToolStripMenuItem.Click
        Login.Show()
        Login.txtnome.Clear()
        Login.txtsenha.Clear()
        Login.txtnome.Focus()
        Me.Close()
    End Sub
    Private Sub AgendarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgendarToolStripMenuItem.Click
        Agendamento.Show()
        Me.Enabled = False
        PlRodape.Enabled = True
    End Sub
    Private Sub DiarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiarioToolStripMenuItem.Click
        Rel_Corrida.Show()
        Me.Enabled = False
    End Sub
    Private Sub MensalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MensalToolStripMenuItem.Click
        Rel_Empresa.Show()
        Me.Enabled = False
    End Sub
    Private Sub BackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSBackup.Click
        backup.Show()
        Me.Enabled = False
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblHora.Text = "Hora: " + FormatDateTime(TimeOfDay, DateFormat.ShortTime)
    End Sub
    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        'Shell("calc.exe")
        calculadora.Show()
    End Sub
    Private Sub BlocoDeNotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlocoDeNotasToolStripMenuItem.Click
        'Shell("notepad.exe")
        Bloco_notas.Show()
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        Consultas.Show()
        Me.Enabled = False
    End Sub
    Private Sub FunciónarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSFunc.Click
        Funcionario.Show()
        Me.Enabled = False
    End Sub
    Private Sub MotoristaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSMoto.Click
        Motorista.Show()
        Me.Enabled = False
    End Sub
    Private Sub FísicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FísicoToolStripMenuItem.Click
        Cliente_Fis.Show()
        Me.Enabled = False
    End Sub
    Private Sub JurídicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JurídicoToolStripMenuItem.Click
        Cliente_Jud.Show()
        Me.Enabled = False
    End Sub
    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        usuario.Show()
        Me.Enabled = False
    End Sub
    Private Sub ConsultarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem1.Click
        Cons_Corrida.Show()
        Me.Enabled = False
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        codigos.contador = codigos.contador + 1
        If codigos.contador > 59 Then
            codigos.contador = 0
            carregar_corridas_abertas()
            carregar_corridas_em_andamento()
        End If
    End Sub
    Private Sub carregar_corridas_abertas()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select agendamento.Cod_agendamento as Corrida, agendamento.Horario as Horario, agendamento.Data_agend as Data, Cliente.Nome as [Cliente], agendamento.Observacoes as [Observações],agendamento.blindagem from agendamento inner join Cliente on agendamento.Cod_cli = Cliente.Cod_cli where agendamento.Data_agend = '" & Today & "' and Status_Agend = 'Pendente'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                DgvPendente.DataSource = dt
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub DgvPedente_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvPendente.CellDoubleClick
        Try
            codigos.codagend = DgvPendente.CurrentRow.Cells(0).Value
            codigos.blindagem1 = DgvPendente.CurrentRow.Cells(5).Value
            update_corrida.Show()
            Me.Enabled = False
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub AbrirAgendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirAgendaToolStripMenuItem.Click
        Cons_Corrida.Show()
        Me.Enabled = False
    End Sub
    Private Sub DesignarMotoristaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesignarMotoristaToolStripMenuItem.Click
        Try
            codigos.codagend = DgvPendente.CurrentRow.Cells(0).Value
            codigos.blindagem1 = DgvPendente.CurrentRow.Cells(5).Value
            update_corrida.Show()
            Me.Enabled = False
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Function cancelar_corrida()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "update agendamento set Status_Agend = 'Cancelada', Cod_moto = 0 where Cod_agendamento = " & codigos.codagend & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Finally
                cn.Close()
            End Try
            '----------------
            Try
                cn.Open()
                Dim sql As String = "update corrida set status_corrida = 'Cancelada', Cod_moto = 0 where Cod_agendamento = " & codigos.codagend & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Finally
                cn.Close()
            End Try
            Return True
        End Using
    End Function
    Public Sub motorista_disponivel()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "update motorista set Status_Moto = '" & True & "', status_corrida = 'False' where cod_moto = " & codigos.codmoto & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub carregar_corridas_em_andamento()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select agendamento.Cod_agendamento as [Corrida], agendamento.Cod_moto as Motorista, Cliente.Nome as Cliente, agendamento.Horario as Horario, agendamento.Data_agend as Data from agendamento inner join Cliente on agendamento.Cod_cli = Cliente.Cod_cli where agendamento.Data_agend = '" & Today & "' and Status_Agend = 'Em andamento'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                DgvEmAndamento.DataSource = dt
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        Cons_Corrida.Show()
        Me.Enabled = False
    End Sub
    Public Function finalizar_corrida()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "update agendamento set Status_Agend = 'Finalizada' where Cod_agendamento = " & codigos.codagend & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Finally
                cn.Close()
            End Try
            '--------------
            Try
                cn.Open()
                Dim sql As String = "update corrida set Status_corrida = 'Finalizada' where Cod_agendamento = " & codigos.codagend & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Finally
                cn.Close()
            End Try
            Return True
        End Using
    End Function
    Private Sub CancelarCorridaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarCorridaToolStripMenuItem.Click
        Try
            codigos.codagend = DgvEmAndamento.CurrentRow.Cells(0).Value
            codigos.codmoto = DgvEmAndamento.CurrentRow.Cells(1).Value
            If MessageBox.Show("Deseja realmente cancelar a corrida " & codigos.codagend & "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If cancelar_corrida() = True Then
                    MessageBox.Show("Cancelamento efetuado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    motorista_disponivel()
                    codigos.codagend = Nothing
                    codigos.codmoto = Nothing
                    carregar_corridas_em_andamento()
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub CancelarCorridaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarPendente.Click
        Try
            codigos.codagend = DgvPendente.CurrentRow.Cells(0).Value
            If MessageBox.Show("Deseja realmente cancelar a corrida " & codigos.codagend & "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If cancelar_corrida() = True Then
                    MessageBox.Show("Cancelamento efetuado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    codigos.codagend = Nothing
                    carregar_corridas_abertas()
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub FinalizarCorridaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinalizarCorridaToolStripMenuItem.Click
        Try
            codigos.codagend = DgvEmAndamento.CurrentRow.Cells(0).Value
            codigos.codmoto = DgvEmAndamento.CurrentRow.Cells(1).Value
            If MessageBox.Show("Deseja realmente finalizar a corrida " & codigos.codagend & "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If finalizar_corrida() = True Then
                    MessageBox.Show("Corrida finalizada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    motorista_disponivel()
                    codigos.codagend = Nothing
                    codigos.codmoto = Nothing
                    carregar_corridas_em_andamento()
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    'aviso para msg perto do horario
    'Private Sub pegar_hora()
    '    Using cn As SqlConnection = conexao()
    '        Try
    '            cn.Open()
    '            Dim sql As String = "select horario from agendamento where Data_agend = '" & System.DateTime.Now & "' and Status_Agend = 'Pendente'"
    '            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
    '            Dim mr As SqlDataReader
    '            mr = cmd.ExecuteReader
    '            While mr.Read
    '                hora = mr!horario
    '            End While
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Using
    'End Sub
    Private Sub InformaçõesDaCorridaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformaçõesDaCorridaToolStripMenuItem.Click
        Try
            codigos.codagend = DgvEmAndamento.CurrentRow.Cells(0).Value
            Me.Enabled = False
            Informacoes.Show()
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub MSConta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSConta.Click
        Contas.Show()
        Me.Enabled = False
    End Sub
    Private Sub InformaçõesDaCorridaToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles InformaçõesDaCorridaToolStripMenuItem1.Click
        Try
            codigos.codagend = DgvPendente.CurrentRow.Cells(0).Value
            Informacoes.Show()
            Me.Enabled = False
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub PbAbrir_Click(sender As System.Object, e As System.EventArgs) Handles PbAbrir.Click
        PbAbrir.Visible = False
        PlNormal.Visible = False
        DgvEmAndamento.Visible = True
        DgvPendente.Visible = True
        PlAnda.Visible = True
        PlPende.Visible = True
        PlConsulta.Visible = True
    End Sub
    Private Sub PlNormal_Click(sender As Object, e As System.EventArgs) Handles PlNormal.Click
        PbAbrir.Visible = False
        PlNormal.Visible = False
        DgvEmAndamento.Visible = True
        DgvPendente.Visible = True
        PlAnda.Visible = True
        PlPende.Visible = True
        PlConsulta.Visible = True
    End Sub
    Private Sub PlConsulta_Click(sender As Object, e As System.EventArgs) Handles PictureBox1.Click, Me.Click, PictureBox2.Click, MenuStrip1.Click, Panel2.Click, PlRodape.Click
        PlAnda.Visible = False
        PlPende.Visible = False
        DgvEmAndamento.Visible = False
        DgvPendente.Visible = False
        PlConsulta.Visible = False
        PbAbrir.Visible = True
        PlNormal.Visible = True
    End Sub
    Private Sub StatusMotoristaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StatusMotoristaToolStripMenuItem.Click
        Moto_Update.Show()
        Me.Enabled = False
    End Sub
    Private Sub DgvEmAndamento_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvEmAndamento.CellDoubleClick
        Try
            codigos.codagend = DgvEmAndamento.CurrentRow.Cells(0).Value
            codigos.codmoto = DgvEmAndamento.CurrentRow.Cells(1).Value
            If MessageBox.Show("Deseja realmente finalizar a corrida " & codigos.codagend & "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If finalizar_corrida() = True Then
                    MessageBox.Show("Corrida finalizada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    motorista_disponivel()
                    codigos.codagend = Nothing
                    codigos.codmoto = Nothing
                    carregar_corridas_em_andamento()
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Help_Inicial.Show()
        Me.Enabled = False
    End Sub
    Private Sub AtualizarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AtualizarToolStripMenuItem.Click, ToolStripMenuItem2.Click
        codigos.contador = 60
    End Sub


End Class