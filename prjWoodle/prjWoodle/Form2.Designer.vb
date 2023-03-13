<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FGameover
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
        Me.Lbltulemus = New System.Windows.Forms.Label()
        Me.Lblvastus = New System.Windows.Forms.Label()
        Me.BtnRestart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbltulemus
        '
        Me.Lbltulemus.AutoSize = True
        Me.Lbltulemus.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbltulemus.Location = New System.Drawing.Point(237, 92)
        Me.Lbltulemus.Name = "Lbltulemus"
        Me.Lbltulemus.Size = New System.Drawing.Size(175, 55)
        Me.Lbltulemus.TabIndex = 0
        Me.Lbltulemus.Text = "Label1"
        '
        'Lblvastus
        '
        Me.Lblvastus.AutoSize = True
        Me.Lblvastus.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lblvastus.Location = New System.Drawing.Point(254, 158)
        Me.Lblvastus.Name = "Lblvastus"
        Me.Lblvastus.Size = New System.Drawing.Size(137, 42)
        Me.Lblvastus.TabIndex = 1
        Me.Lblvastus.Text = "Label2"
        '
        'BtnRestart
        '
        Me.BtnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BtnRestart.Location = New System.Drawing.Point(270, 226)
        Me.BtnRestart.Name = "BtnRestart"
        Me.BtnRestart.Size = New System.Drawing.Size(107, 52)
        Me.BtnRestart.TabIndex = 2
        Me.BtnRestart.Text = "Restart"
        Me.BtnRestart.UseVisualStyleBackColor = True
        '
        'FGameover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 393)
        Me.Controls.Add(Me.BtnRestart)
        Me.Controls.Add(Me.Lblvastus)
        Me.Controls.Add(Me.Lbltulemus)
        Me.Name = "FGameover"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbltulemus As Label
    Friend WithEvents Lblvastus As Label
    Friend WithEvents BtnRestart As Button
    'Friend WithEvents UCtrlTable2 As PrjStatistika.UCtrlTable
End Class
