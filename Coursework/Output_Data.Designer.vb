﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Output_Data
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Output_Data))
        Me.bClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bClose
        '
        Me.bClose.Location = New System.Drawing.Point(13, 13)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(75, 23)
        Me.bClose.TabIndex = 0
        Me.bClose.Text = "Close"
        Me.bClose.UseVisualStyleBackColor = True
        '
        'Output_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 772)
        Me.Controls.Add(Me.bClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Output_Data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Output_Data"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bClose As Button
End Class
