Public Class calculadora
    Dim limpaExibicao As Boolean
    Dim copia As String
    Dim operando1, operando2 As Double
    Dim operador As Char
    Dim m As Double = 0
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click
        Try
            If limpaExibicao Then
                txtdisplay.Clear()
                limpaExibicao = False
            End If
            txtdisplay.Text = txtdisplay.Text + sender.Text
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnpoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpoint.Click
        Try
            If txtdisplay.Text.IndexOf(".") > 0 Then
            ElseIf Len(txtdisplay.Text) = 0 Then
                txtdisplay.Text = "0."
            Else
                txtdisplay.Text = txtdisplay.Text & "."
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtdisplay.Clear()
        operando1 = 0
        operando2 = 0
    End Sub
    Private Sub btnplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplus.Click
        Try
            operando1 = Val(txtdisplay.Text)
            operador = "/"
            limpaExibicao = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnminus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnminus.Click
        Try
            operando1 = Val(txtdisplay.Text)
            operador = "*"
            limpaExibicao = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnmulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmulti.Click
        Try
            operando1 = Val(txtdisplay.Text)
            operador = "-"
            limpaExibicao = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btndiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndiv.Click
        Try
            operando1 = Val(txtdisplay.Text)
            operador = "+"
            limpaExibicao = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnequal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnequal.Click
        Try
            Dim resultado As Double
            operando2 = Val(txtdisplay.Text)
            Select Case operador
                Case "+"
                    resultado = operando1 + operando2
                Case "-"
                    resultado = operando1 - operando2
                Case "*"
                    resultado = operando1 * operando2
                Case "/"
                    If operando2 <> "0" Then
                        resultado = operando1 / operando2
                    Else
                        txtdisplay.Text = "Não posso dividir por zero."
                        limpaExibicao = True
                        Exit Sub
                    End If
            End Select
            txtdisplay.Text = resultado
            limpaExibicao = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MenuItem3.Enabled = False
        ''atribuindo um valor para a dica associada ao botão MR
        'ToolTip1.SetToolTip(btnmr, "Chama o valor da memória.")
        ''atribuindo um valor para a dica associada ao botão MC
        'ToolTip1.SetToolTip(btnmc, "Limpando o valor da memória.")
    End Sub
    Private Sub btnnegative_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnegative.Click
        Try
            txtdisplay.Text = -Val(txtdisplay.Text)
            limpaExibicao = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btninverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninverse.Click
        Try
            Dim temp As Double
            temp = txtdisplay.Text
            If temp <> 0 Then
                txtdisplay.Text = 1 / temp
            Else
                txtdisplay.Text = "Divisão por Zero"
            End If
        Catch exc As Exception
            txtdisplay.Text = "Entrada incorreta para função"
        End Try
    End Sub
    Private Sub btnlog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlog.Click
        Try
            If txtdisplay.Text < 0 Then
                txtdisplay.Text = "Entrada incorreta para função"
            Else
                txtdisplay.Text = Math.Log(txtdisplay.Text)
            End If
        Catch exc As Exception
            txtdisplay.Text = "Entrada incorreta para função"
        End Try
    End Sub
    Private Sub btnsqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsqrt.Click
        Try
            If txtdisplay.Text < 0 Then
                txtdisplay.Text = "Resultado Indefinido."
            Else
                txtdisplay.Text = Math.Sqrt(Val(txtdisplay.Text))
            End If
        Catch exc As Exception
            txtdisplay.Text = "Entrada incorreta para função"
        End Try
    End Sub
    Private Sub btnplu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplu.Click
        Try
            m = m + txtdisplay.Text
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmin.Click
        Try
            m = m - txtdisplay.Text
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnmr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmr.Click
        Try
            txtdisplay.Text = m
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnmc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmc.Click
        Try
            m = 0
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnbacks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbacks.Click
        Try
            Dim a As String
            If Not Len(txtdisplay.Text) <= 0 Then
                a = txtdisplay.Text.Substring(0, txtdisplay.Text.Length - 1)
                txtdisplay.Text = a
            Else
                txtdisplay.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnce.Click
        Try
            txtdisplay.Clear()
            operando2 = 0
        Catch ex As Exception
        End Try
    End Sub
End Class