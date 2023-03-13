<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CBAjaliimit = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAjaliimit = New System.Windows.Forms.TextBox()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CbRight = New System.Windows.Forms.ComboBox()
        Me.CbLeft = New System.Windows.Forms.ComboBox()
        Me.CbCentre = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblError = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBAjaliimit
        '
        Me.CBAjaliimit.AutoSize = True
        Me.CBAjaliimit.Location = New System.Drawing.Point(37, 17)
        Me.CBAjaliimit.Name = "CBAjaliimit"
        Me.CBAjaliimit.Size = New System.Drawing.Size(15, 14)
        Me.CBAjaliimit.TabIndex = 0
        Me.CBAjaliimit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sisesta ajaliimit:"
        '
        'TxtAjaliimit
        '
        Me.TxtAjaliimit.Enabled = False
        Me.TxtAjaliimit.Location = New System.Drawing.Point(146, 48)
        Me.TxtAjaliimit.Name = "TxtAjaliimit"
        Me.TxtAjaliimit.Size = New System.Drawing.Size(100, 20)
        Me.TxtAjaliimit.TabIndex = 2
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(256, 299)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart.TabIndex = 3
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Minion Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Palub, sisesta arv vahemikus 1 kuni 60"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtAjaliimit)
        Me.GroupBox1.Controls.Add(Me.CBAjaliimit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(107, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajaliimit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CbRight)
        Me.GroupBox2.Controls.Add(Me.CbLeft)
        Me.GroupBox2.Controls.Add(Me.CbCentre)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(163, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(245, 100)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Värv valimine"
        '
        'CbRight
        '
        Me.CbRight.FormattingEnabled = True
        Me.CbRight.Items.AddRange(New Object() {"Punane", "Oranž", "Kollane", "Roheline", "Sinine", "Violetne", "Roosa", "Pruun"})
        Me.CbRight.Location = New System.Drawing.Point(93, 66)
        Me.CbRight.Name = "CbRight"
        Me.CbRight.Size = New System.Drawing.Size(121, 21)
        Me.CbRight.TabIndex = 5
        '
        'CbLeft
        '
        Me.CbLeft.FormattingEnabled = True
        Me.CbLeft.Items.AddRange(New Object() {"", "Punane", "Oranž", "Kollane", "Roheline", "Sinine", "Violetne", "Roosa", "Pruun"})
        Me.CbLeft.Location = New System.Drawing.Point(93, 42)
        Me.CbLeft.Name = "CbLeft"
        Me.CbLeft.Size = New System.Drawing.Size(121, 21)
        Me.CbLeft.TabIndex = 4
        '
        'CbCentre
        '
        Me.CbCentre.FormattingEnabled = True
        Me.CbCentre.Items.AddRange(New Object() {"Punane", "Oranž", "Kollane", "Roheline", "Sinine", "Violetne", "Roosa", "Pruun"})
        Me.CbCentre.Location = New System.Drawing.Point(93, 20)
        Me.CbCentre.Name = "CbCentre"
        Me.CbCentre.Size = New System.Drawing.Size(121, 21)
        Me.CbCentre.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Paremale"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Vasakule"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Õiges asendis"
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.ForeColor = System.Drawing.Color.Red
        Me.LblError.Location = New System.Drawing.Point(250, 325)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(0, 15)
        Me.LblError.TabIndex = 8
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 393)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnStart)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBAjaliimit As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAjaliimit As TextBox
    Friend WithEvents BtnStart As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CbRight As ComboBox
    Friend WithEvents CbLeft As ComboBox
    Friend WithEvents CbCentre As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblError As Label
End Class
