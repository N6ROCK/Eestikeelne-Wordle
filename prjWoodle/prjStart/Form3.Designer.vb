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
        Me.SuspendLayout()
        '
        'CBAjaliimit
        '
        Me.CBAjaliimit.AutoSize = True
        Me.CBAjaliimit.Location = New System.Drawing.Point(119, 83)
        Me.CBAjaliimit.Name = "CBAjaliimit"
        Me.CBAjaliimit.Size = New System.Drawing.Size(60, 17)
        Me.CBAjaliimit.TabIndex = 0
        Me.CBAjaliimit.Text = "Ajaliimit"
        Me.CBAjaliimit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sisesta ajaliimit:"
        '
        'TxtAjaliimit
        '
        Me.TxtAjaliimit.Enabled = False
        Me.TxtAjaliimit.Location = New System.Drawing.Point(228, 128)
        Me.TxtAjaliimit.Name = "TxtAjaliimit"
        Me.TxtAjaliimit.Size = New System.Drawing.Size(100, 20)
        Me.TxtAjaliimit.TabIndex = 2
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(228, 210)
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
        Me.Label2.Location = New System.Drawing.Point(228, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Palub, sisesta arv vahemikus 0 kuni 60"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 393)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.TxtAjaliimit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBAjaliimit)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBAjaliimit As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAjaliimit As TextBox
    Friend WithEvents BtnStart As Button
    Friend WithEvents Label2 As Label
End Class
