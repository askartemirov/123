Imports info.lundin.math
Imports System.Math
Public Class form4

    Dim f As String
    Function func(znach As Double)
        Dim Parser As New ExpressionParser()
        Parser.Values.Add("x", znach)
        Return Parser.Parse(f)
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "") Then MsgBox("Неправильный ввод!") : GoTo 10
        Dim a, b, tol, k_max, time, k As Double
        Dim x1, x2, y1, y2 As Double
        f = TextBox1.Text
        a = Double.Parse(TextBox2.Text)
        b = Double.Parse(TextBox3.Text)
        tol = Double.Parse(TextBox4.Text)
        k_max = Double.Parse(TextBox5.Text)

        time = 0
        k = 0
        While (Abs(b - a) > tol And k < k_max)
            k = k + 1
            x1 = b - (b - a) / ((1 + Sqrt(5)) / 2)
            x2 = a + (b - a) / ((1 + Sqrt(5)) / 2)
            y1 = func(x1)
            y2 = func(x2)
            If (y1 > y2) Then
                a = x1
            Else
                b = x2
            End If
            time = time + 0.0001
            TextBox9.Text = Convert.ToString(time)
            If (ProgressBar1.Value <> 100) Then
                ProgressBar1.Value += 1
            End If
        End While

        If (ProgressBar1.Value <> 100) Then
            ProgressBar1.Value = 100
        End If
        ProgressBar1.Value = 100
        TextBox6.Text = x1
        TextBox7.Text = func(x1)
        TextBox8.Text = k
        TextBox10.Text = Abs(b - a)
10:
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class
