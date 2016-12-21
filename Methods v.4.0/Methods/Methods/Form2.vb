Imports info.lundin.math
Imports System.Math
Public Class form2
    Dim f As String
    Function func(znach As Double)
        Dim Parser As New ExpressionParser()
        Parser.Values.Add("x", znach)
        Return Parser.Parse(f)
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim x0, tol, k_max, k, x1, y0, y1, h As Double
        Dim time2 As DateTime
        Dim time1 As DateTime = Now

        f = TextBox1.Text
        x0 = Double.Parse(TextBox2.Text)
        tol = Double.Parse(TextBox4.Text)
        k_max = Double.Parse(TextBox3.Text)

        h = tol * 2
        x1 = x0 + h
        y0 = func(x0)
        y1 = func(x1)
        k = 0
        time1 = Now
        While (Abs(x1 - x0) > tol And k < k_max)

            k = k + 1
            If (y1 > y0) Then
                x1 = x0
                y1 = y0

            Else

                x0 = x1
                y0 = y1
                x1 = x1 + h
                y1 = func(x1)
            End If

            If (ProgressBar1.Value <> 100) Then
                ProgressBar1.Value += 1
            End If
        End While

        time2 = Now

        TextBox8.Text = time2.Subtract(time1).Milliseconds
        TextBox7.Text = y1
        TextBox9.Text = k
        TextBox6.Text = x1


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

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

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs)

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

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub
End Class
