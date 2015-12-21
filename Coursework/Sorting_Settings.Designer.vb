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
        Me.SuspendLayout()
        '
        'bClose
        '
        Me.bClose.BackColor = System.Drawing.Color.Transparent
        Me.bClose.BackgroundImage = Global.Coursework.My.Resources.Resources.Back
        Me.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bClose.FlatAppearance.BorderSize = 0
        Me.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClose.Location = New System.Drawing.Point(13, 13)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(60, 60)
        Me.bClose.TabIndex = 0
        Me.bClose.UseVisualStyleBackColor = False
        '
        'cbSorting_Setting
        '
        Me.cbSorting_Setting.BackColor = System.Drawing.SystemColors.Control
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
        'Sorting_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1000, 772)
        Me.Controls.Add(Me.bSent_Seting)
        Me.Controls.Add(Me.cbSorting_Setting)
        Me.Controls.Add(Me.bClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sorting_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sorting_Settings"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bClose As Button
    Friend WithEvents cbSorting_Setting As CheckedListBox
    Friend WithEvents bSent_Seting As Button
End Class
