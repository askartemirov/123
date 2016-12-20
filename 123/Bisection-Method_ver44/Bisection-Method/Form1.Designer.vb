<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ButtonClearOutPut = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonRun = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Time_Box = New System.Windows.Forms.TextBox()
        Me.function_Box = New System.Windows.Forms.ComboBox()
        Me.resultX_Box = New System.Windows.Forms.TextBox()
        Me.Abs_Box = New System.Windows.Forms.TextBox()
        Me.k_max_Box = New System.Windows.Forms.TextBox()
        Me.k_Box = New System.Windows.Forms.TextBox()
        Me.resultF_Box = New System.Windows.Forms.TextBox()
        Me.b_Box = New System.Windows.Forms.TextBox()
        Me.Tol_Box = New System.Windows.Forms.TextBox()
        Me.a_Box = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Time_max_Box = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(323, 352)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 42)
        Me.ButtonExit.TabIndex = 49
        Me.ButtonExit.Text = "Выход"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(34, 238)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(365, 19)
        Me.ProgressBar1.TabIndex = 48
        '
        'ButtonClearOutPut
        '
        Me.ButtonClearOutPut.Location = New System.Drawing.Point(323, 275)
        Me.ButtonClearOutPut.Name = "ButtonClearOutPut"
        Me.ButtonClearOutPut.Size = New System.Drawing.Size(76, 71)
        Me.ButtonClearOutPut.TabIndex = 47
        Me.ButtonClearOutPut.Text = "очистить результат"
        Me.ButtonClearOutPut.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(77, 381)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Time(msec): "
        '
        'ButtonRun
        '
        Me.ButtonRun.Location = New System.Drawing.Point(57, 198)
        Me.ButtonRun.Name = "ButtonRun"
        Me.ButtonRun.Size = New System.Drawing.Size(313, 25)
        Me.ButtonRun.TabIndex = 45
        Me.ButtonRun.Text = "Вычислить"
        Me.ButtonRun.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(128, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "а:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(128, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "b:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(103, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "k_max:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(92, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Result x*:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(116, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "f(x*):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "NumberOfIterations:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Abs(b-a):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Tolerance:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Function f(x):"
        '
        'Time_Box
        '
        Me.Time_Box.Location = New System.Drawing.Point(150, 378)
        Me.Time_Box.Name = "Time_Box"
        Me.Time_Box.ReadOnly = True
        Me.Time_Box.Size = New System.Drawing.Size(149, 20)
        Me.Time_Box.TabIndex = 35
        '
        'function_Box
        '
        Me.function_Box.FormattingEnabled = True
        Me.function_Box.Items.AddRange(New Object() {"x^2-exp(x)", "(x-2)^2-ln(x)", "(x-2)^2-log(x)", "1600*(1-exp(-x/5))-160*x", "4*x^3-2*x-6", "x^2-4*sin(x)"})
        Me.function_Box.Location = New System.Drawing.Point(150, 22)
        Me.function_Box.Name = "function_Box"
        Me.function_Box.Size = New System.Drawing.Size(155, 21)
        Me.function_Box.TabIndex = 34
        Me.function_Box.Text = "x^2-4*sin(x)"
        '
        'resultX_Box
        '
        Me.resultX_Box.Location = New System.Drawing.Point(150, 268)
        Me.resultX_Box.Name = "resultX_Box"
        Me.resultX_Box.ReadOnly = True
        Me.resultX_Box.Size = New System.Drawing.Size(149, 20)
        Me.resultX_Box.TabIndex = 33
        '
        'Abs_Box
        '
        Me.Abs_Box.Location = New System.Drawing.Point(150, 352)
        Me.Abs_Box.Name = "Abs_Box"
        Me.Abs_Box.ReadOnly = True
        Me.Abs_Box.Size = New System.Drawing.Size(149, 20)
        Me.Abs_Box.TabIndex = 32
        '
        'k_max_Box
        '
        Me.k_max_Box.Location = New System.Drawing.Point(150, 145)
        Me.k_max_Box.Name = "k_max_Box"
        Me.k_max_Box.Size = New System.Drawing.Size(100, 20)
        Me.k_max_Box.TabIndex = 31
        Me.k_max_Box.Text = "100"
        '
        'k_Box
        '
        Me.k_Box.Location = New System.Drawing.Point(150, 326)
        Me.k_Box.Name = "k_Box"
        Me.k_Box.ReadOnly = True
        Me.k_Box.Size = New System.Drawing.Size(149, 20)
        Me.k_Box.TabIndex = 30
        '
        'resultF_Box
        '
        Me.resultF_Box.Location = New System.Drawing.Point(150, 297)
        Me.resultF_Box.Name = "resultF_Box"
        Me.resultF_Box.ReadOnly = True
        Me.resultF_Box.Size = New System.Drawing.Size(149, 20)
        Me.resultF_Box.TabIndex = 29
        '
        'b_Box
        '
        Me.b_Box.Location = New System.Drawing.Point(150, 86)
        Me.b_Box.Name = "b_Box"
        Me.b_Box.Size = New System.Drawing.Size(100, 20)
        Me.b_Box.TabIndex = 28
        Me.b_Box.Text = "3"
        '
        'Tol_Box
        '
        Me.Tol_Box.Location = New System.Drawing.Point(150, 115)
        Me.Tol_Box.Name = "Tol_Box"
        Me.Tol_Box.Size = New System.Drawing.Size(100, 20)
        Me.Tol_Box.TabIndex = 27
        Me.Tol_Box.Text = "1e-28"
        '
        'a_Box
        '
        Me.a_Box.Location = New System.Drawing.Point(150, 54)
        Me.a_Box.Name = "a_Box"
        Me.a_Box.Size = New System.Drawing.Size(100, 20)
        Me.a_Box.TabIndex = 26
        Me.a_Box.Text = "1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(68, 410)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 13)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "                                                 "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(60, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Time limit(msec):"
        '
        'Time_max_Box
        '
        Me.Time_max_Box.Location = New System.Drawing.Point(150, 171)
        Me.Time_max_Box.Name = "Time_max_Box"
        Me.Time_max_Box.Size = New System.Drawing.Size(100, 20)
        Me.Time_max_Box.TabIndex = 52
        Me.Time_max_Box.Text = "30"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 446)
        Me.Controls.Add(Me.Time_max_Box)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ButtonClearOutPut)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ButtonRun)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Time_Box)
        Me.Controls.Add(Me.function_Box)
        Me.Controls.Add(Me.resultX_Box)
        Me.Controls.Add(Me.Abs_Box)
        Me.Controls.Add(Me.k_max_Box)
        Me.Controls.Add(Me.k_Box)
        Me.Controls.Add(Me.resultF_Box)
        Me.Controls.Add(Me.b_Box)
        Me.Controls.Add(Me.Tol_Box)
        Me.Controls.Add(Me.a_Box)
        Me.Name = "Form1"
        Me.Text = "Метод Бисекции"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ButtonClearOutPut As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ButtonRun As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Time_Box As System.Windows.Forms.TextBox
    Friend WithEvents function_Box As System.Windows.Forms.ComboBox
    Friend WithEvents resultX_Box As System.Windows.Forms.TextBox
    Friend WithEvents Abs_Box As System.Windows.Forms.TextBox
    Friend WithEvents k_max_Box As System.Windows.Forms.TextBox
    Friend WithEvents k_Box As System.Windows.Forms.TextBox
    Friend WithEvents resultF_Box As System.Windows.Forms.TextBox
    Friend WithEvents b_Box As System.Windows.Forms.TextBox
    Friend WithEvents Tol_Box As System.Windows.Forms.TextBox
    Friend WithEvents a_Box As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Time_max_Box As System.Windows.Forms.TextBox

End Class
