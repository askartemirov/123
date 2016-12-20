Imports info.lundin.Math
Imports System.Math
Imports System.Windows.Markup
Imports System.Threading

Public Class Form1
    Dim SW As New Stopwatch
    Dim f As String
    Function Func(a As Decimal)
        Dim parser As New ExpressionParser()
        parser.Values.Add("x", a)
        Return parser.Parse(f)
    End Function

    Private Sub calc()
        SW.Reset()
        SW.Start()

        Dim a, b, m, tol1, f1, f2, f3, tol As Decimal
        Dim k_max, k_max2, time_max, time As Integer
        Dim msg, title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult

        time = Double.Parse(Time_max_Box.Text)
        f = function_Box.Text
        a = Decimal.Parse(a_Box.Text)
        b = Decimal.Parse(b_Box.Text)
        tol1 = Decimal.Parse(Tol_Box.Text, Globalization.NumberStyles.Float)
        k_max = Integer.Parse(k_max_Box.Text)
        k_max2 = k_max
        time_max = time

        ProgressBar1.Visible = True

        tol = tol1

        f1 = Func(a)
        f2 = Func(b)

        If (Math.Sign(f1) = Math.Sign(f2)) Then
            MessageBox.Show("F(a) and F(b) must be opposite! Check [a,b]")

        Else
            Dim k As Integer
            k = 0
            While (k < k_max And b - a > tol)



                m = a + ((b - a) / 2)
                f1 = Func(a)
                f3 = Func(m)

                If (Sign(f1) = Sign(f3)) Then
                    a += 1
                    a = m
                Else
                    b += 1
                    b = m

                End If
                k = k + 1

                If (k = k_max And tol > 1.0E-29) Then
                    msg = "Не хватает итерации для точного решения, добавить итерацию?"
                    style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                    title = "MsgBox Demonstaration"
                    response = MsgBox(msg, style, title)
                    If response = MsgBoxResult.Yes Then
                        k_max += k_max2
                    End If
                End If

                If (ProgressBar1.Value <> 100) Then
                    ProgressBar1.Value += 1

                End If

                If (time_max <= SW.ElapsedMilliseconds) Then
                    SW.Stop()
                    msg = "Не хватает  времени, добавить время?"
                    style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                    title = "MsgBox Demonstaration"
                    response = MsgBox(msg, style, title)
                    If response = MsgBoxResult.Yes Then
                        SW.Start()
                        time_max = time_max + 10000
                    Else
                        Exit While
                    End If
                End If
            End While
            If (ProgressBar1.Value <> 100) Then
                ProgressBar1.Value = 100
                SW.Stop()
            End If

            If (Abs(b - a) > tol) Then

                Label11.Text = ("Программа не может вычислить с погрешностью " & Tol_Box.Text & vbCr & "при заданном k_max")
            End If
            SW.Stop()

            ProgressBar1.Value = 100
            resultX_Box.Text = m
            Abs_Box.Text = Convert.ToDouble(Abs(b - a))
            k_Box.Text = k
            resultF_Box.Text = Func(m)
            Time_Box.Text = SW.ElapsedMilliseconds

        End If
    End Sub

    Private Sub ButtonRun_Click(sender As Object, e As EventArgs) Handles ButtonRun.Click
        Label11.Text = ""
        Try
            If (function_Box.Text = "" Or a_Box.Text = "" Or b_Box.Text = "" Or Tol_Box.Text = "" Or k_max_Box.Text = "" Or Time_max_Box.Text = "") Then MsgBox("Заполните все поля!") : Exit Sub
            calc()

            ProgressBar1.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message + "  Проверьте правильность ввода Function f(x):")
        End Try

    End Sub

    Private Sub ButtonClearOutPut_Click(sender As Object, e As EventArgs) Handles ButtonClearOutPut.Click
        resultX_Box.Text = ""
        resultF_Box.Text = ""
        k_Box.Text = ""
        Abs_Box.Text = ""
        Time_Box.Text = ""
        Label11.Text = ""
        ProgressBar1.Value = 0
        SW.Reset()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub a_Box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles a_Box.KeyPress
        If a_Box.SelectionStart = 0 Then
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And e.KeyChar <> "-" And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 46 Then
                e.Handled = True
            End If
        Else
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 46 Then
                e.Handled = True
            End If
        End If
        If InStr(a_Box.Text, ".") Then
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And e.KeyChar <> "-" Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub b_Box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles b_Box.KeyPress
        If b_Box.SelectionStart = 0 Then
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And e.KeyChar <> "-" And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 46 Then
                e.Handled = True
            End If
        Else
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 46 Then
                e.Handled = True
            End If
        End If
        If InStr(b_Box.Text, ".") Then
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And e.KeyChar <> "-" Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub k_max_Box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles k_max_Box.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 48 And Asc(e.KeyChar) <> 48 Then
            e.Handled = True
        End If
    End Sub
End Class
