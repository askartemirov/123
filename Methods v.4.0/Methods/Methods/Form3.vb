Imports info.lundin.math
Imports System.Math
Public Class form3

    Dim f As String
    Function func(znach As Double)
        Dim Parser As New ExpressionParser()
        Parser.Values.Add("x", znach)
        Return Parser.Parse(f)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "") Then MsgBox("Неправильный ввод!") : GoTo 10
        Dim x0, h0, tol, R, k_max As Double
        Dim x1, h1, y0, y1, k As Double
        Dim time2 As DateTime
        Dim time1 As DateTime = Now
        f = TextBox1.Text
        x0 = Double.Parse(TextBox2.Text)
        h0 = Double.Parse(TextBox3.Text)
        tol = Double.Parse(TextBox4.Text)
        R = Double.Parse(TextBox5.Text)
        k_max = Double.Parse(TextBox6.Text)

        y0 = func(x0)
        h1 = h0
        x1 = x0 + h1
        y1 = func(x1)
        k = 0
        time1 = Now
        While (Abs(h1) > tol And k < k_max)
            k = k + 1

            If (y1 >= y0) Then
                If (Abs(h0) < tol / R) Then
                    h1 = h0
                    x1 = x0
                    y1 = y0
                Else
                    h1 = -h0 / R
                    h0 = h1
                    x0 = x1
                    y0 = y1
                    x1 = x0 + h1
                    y1 = func(x1)
                End If
            Else
                h1 = h0
                x0 = x1
                y0 = y1
                x1 = x0 + h1
                y1 = func(x1)
            End If

           
        End While
        time2 = Now
        TextBox9.Text = time2.Subtract(time1).Milliseconds
        If (ProgressBar1.Value <> 100) Then
            ProgressBar1.Value = 100
        End If
        ProgressBar1.Value = 100
        TextBox7.Text = x1
        TextBox8.Text = func(x1)
        TextBox10.Text = k
        TextBox11.Text = h1


10:
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

        ProgressBar1.Value = 0
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If TextBox2.SelectionStart = 0 Then
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And e.KeyChar <> "-" And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 46 Then
                e.Handled = True
            End If
        Else
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 46 Then
                e.Handled = True
            End If
        End If
        If InStr(TextBox2.Text, ",") Then
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And e.KeyChar <> "-" Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If TextBox3.SelectionStart = 0 Then
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And e.KeyChar <> "-" And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 46 Then
                e.Handled = True
            End If
        Else
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 46 Then
                e.Handled = True
            End If
        End If
        If InStr(TextBox3.Text, ",") Then
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And e.KeyChar <> "-" Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If TextBox4.SelectionStart = 0 Then
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And e.KeyChar <> "-" And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 46 Then
                e.Handled = True
            End If
        Else
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 46 Then
                e.Handled = True
            End If
        End If
        If InStr(TextBox4.Text, ",") Then
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And e.KeyChar <> "-" Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If TextBox6.SelectionStart = 0 Then
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And e.KeyChar <> "-" And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 46 Then
                e.Handled = True
            End If
        Else
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 46 Then
                e.Handled = True
            End If
        End If
        If InStr(TextBox6.Text, ",") Then
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And e.KeyChar <> "-" Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If TextBox5.SelectionStart = 0 Then
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And e.KeyChar <> "-" And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 46 Then
                e.Handled = True
            End If
        Else
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 46 Then
                e.Handled = True
            End If
        End If
        If InStr(TextBox5.Text, ",") Then
            If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And e.KeyChar <> "-" Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub
End Class
