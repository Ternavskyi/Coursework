<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sorting_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sorting_Settings))
        Me.bClose = New System.Windows.Forms.Button()
        Me.cbSorting_Setting = New System.Windows.Forms.CheckedListBox()
        Me.bSent_Seting = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sleepTime = New System.Windows.Forms.TextBox()
        Me.isVisualization = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'bClose
        '
        Me.bClose.Location = New System.Drawing.Point(13, 13)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(60, 60)
        Me.bClose.TabIndex = 0
        Me.bClose.Text = "Close"
        Me.bClose.UseVisualStyleBackColor = True
        '
        'cbSorting_Setting
        '
        Me.cbSorting_Setting.BackColor = System.Drawing.Color.Aqua
        Me.cbSorting_Setting.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cbSorting_Setting.CheckOnClick = True
        Me.cbSorting_Setting.FormattingEnabled = True
        Me.cbSorting_Setting.Items.AddRange(New Object() {"Bubble", "Selection", "Insertion", "Gnome", "Shell"})
        Me.cbSorting_Setting.Location = New System.Drawing.Point(13, 158)
        Me.cbSorting_Setting.Name = "cbSorting_Setting"
        Me.cbSorting_Setting.Size = New System.Drawing.Size(73, 75)
        Me.cbSorting_Setting.TabIndex = 1
        '
        'bSent_Seting
        '
        Me.bSent_Seting.Location = New System.Drawing.Point(13, 240)
        Me.bSent_Seting.Name = "bSent_Seting"
        Me.bSent_Seting.Size = New System.Drawing.Size(75, 23)
        Me.bSent_Seting.TabIndex = 2
        Me.bSent_Seting.Text = "Sent Seting"
        Me.bSent_Seting.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Час затримки, міліс"
        '
        'sleepTime
        '
        Me.sleepTime.Location = New System.Drawing.Point(12, 306)
        Me.sleepTime.Name = "sleepTime"
        Me.sleepTime.Size = New System.Drawing.Size(100, 20)
        Me.sleepTime.TabIndex = 4
        Me.sleepTime.Text = "50"
        '
        'isVisualization
        '
        Me.isVisualization.AutoSize = True
        Me.isVisualization.Location = New System.Drawing.Point(13, 273)
        Me.isVisualization.Name = "isVisualization"
        Me.isVisualization.Size = New System.Drawing.Size(86, 17)
        Me.isVisualization.TabIndex = 5
        Me.isVisualization.Text = "Візуалізація"
        Me.isVisualization.UseVisualStyleBackColor = True
        '
        'Sorting_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1000, 772)
        Me.Controls.Add(Me.isVisualization)
        Me.Controls.Add(Me.sleepTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bSent_Seting)
        Me.Controls.Add(Me.cbSorting_Setting)
        Me.Controls.Add(Me.bClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sorting_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sorting_Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bClose As Button
    Friend WithEvents cbSorting_Setting As CheckedListBox
    Friend WithEvents bSent_Seting As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents sleepTime As TextBox
    Friend WithEvents isVisualization As CheckBox
End Class
