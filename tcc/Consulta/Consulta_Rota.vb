Imports System.Text
Public Class Consulta_Rota
    Dim consultaEndereco As New StringBuilder()
    Private Sub btnfechar_Click(sender As System.Object, e As System.EventArgs) Handles btnfechar.Click
        Valor_Corrida.Enabled = True
        Me.Close()
    End Sub
    Private Sub Consulta_Rota_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Valor_Corrida.Enabled = True
        Exit Sub
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TxtCidade.Text = Agendamento.TxtCidade.Text
        txtendorigem.Text = Agendamento.txtendorigem.Text
        TxtCep.Text = Agendamento.TxtCep.Text
        TxtUf.Text = Agendamento.CbUf.Text
        TxtBairro.Text = Agendamento.TxtBairro.Text
        txtlocdest.Text = Agendamento.txtlocdest.Text
        Dim cidade As String = String.Empty
        Dim estado As String = String.Empty
        Dim rua As String = String.Empty
        Dim cep As String = String.Empty
        consultaEndereco.Append("http://maps.google.com/maps?q=")
        Try
            ' constroi a consulta pelo nome da cidade
            If TxtCidade.Text <> String.Empty Then
                cidade = TxtCidade.Text.Replace(" ", "+")
                consultaEndereco.Append(cidade + "," & "+")
            End If
            ' constroi a consulta pelo nome do estado
            If TxtUf.Text <> String.Empty Then
                estado = TxtUf.Text.Replace(" ", "+")
                consultaEndereco.Append(estado + "," & "+")
            End If
            ' constroi a consulta pelo nome da rua
            If txtendorigem.Text <> String.Empty Then
                rua = txtendorigem.Text.Replace(" ", "+")
                consultaEndereco.Append(rua + "," & "+")
            End If
            ' constroi a consulta pelo cep informado
            If TxtCep.Text <> String.Empty Then
                cep = TxtCep.Text.ToString()
                consultaEndereco.Append(cep)
            End If
            ' passa a URL com a string de consulta para o WebBrowser
            WebBrowser1.Navigate(consultaEndereco.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Localização indisponível para exibição no mapa.")
        End Try
    End Sub
End Class
