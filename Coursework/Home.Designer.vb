﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.bInput_Data = New System.Windows.Forms.Button()
        Me.bSorting_Setting = New System.Windows.Forms.Button()
        Me.bOutput_Data = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bInput_Data
        '
        Me.bInput_Data.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bInput_Data.FlatAppearance.BorderSize = 0
        Me.bInput_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bInput_Data.Location = New System.Drawing.Point(0, 0)
        Me.bInput_Data.Name = "bInput_Data"
        Me.bInput_Data.Size = New System.Drawing.Size(100, 100)
        Me.bInput_Data.TabIndex = 0
        Me.bInput_Data.Text = "Input_Data"
        Me.bInput_Data.UseVisualStyleBackColor = False
        '
        'bSorting_Setting
        '
        Me.bSorting_Setting.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bSorting_Setting.FlatAppearance.BorderSize = 0
        Me.bSorting_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSorting_Setting.Location = New System.Drawing.Point(130, 0)
        Me.bSorting_Setting.Name = "bSorting_Setting"
        Me.bSorting_Setting.Size = New System.Drawing.Size(100, 100)
        Me.bSorting_Setting.TabIndex = 1
        Me.bSorting_Setting.Text = "Sorting_Setting"
        Me.bSorting_Setting.UseVisualStyleBackColor = False
        '
        'bOutput_Data
        '
        Me.bOutput_Data.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bOutput_Data.FlatAppearance.BorderSize = 0
        Me.bOutput_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bOutput_Data.Location = New System.Drawing.Point(260, 0)
        Me.bOutput_Data.Name = "bOutput_Data"
        Me.bOutput_Data.Size = New System.Drawing.Size(100, 100)
        Me.bOutput_Data.TabIndex = 2
        Me.bOutput_Data.Text = "Output_Data"
        Me.bOutput_Data.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 772)
        Me.Controls.Add(Me.bOutput_Data)
        Me.Controls.Add(Me.bSorting_Setting)
        Me.Controls.Add(Me.bInput_Data)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bInput_Data As Button
    Friend WithEvents bSorting_Setting As Button
    Friend WithEvents bOutput_Data As Button
End Class
