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
        Me.bSent_Seting = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sleepTime = New System.Windows.Forms.TextBox()
        Me.cbVisualization = New System.Windows.Forms.CheckBox()
        Me.cbBubble = New System.Windows.Forms.CheckBox()
        Me.cbSelection = New System.Windows.Forms.CheckBox()
        Me.cbInsertion = New System.Windows.Forms.CheckBox()
        Me.cbGnome = New System.Windows.Forms.CheckBox()
        Me.cbShell = New System.Windows.Forms.CheckBox()
        Me.bClose = New System.Windows.Forms.Button()
        Me.iMax_Min = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bSent_Seting
        '
        Me.bSent_Seting.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.bSent_Seting.Location = New System.Drawing.Point(170, 568)
        Me.bSent_Seting.Name = "bSent_Seting"
        Me.bSent_Seting.Size = New System.Drawing.Size(134, 31)
        Me.bSent_Seting.TabIndex = 2
        Me.bSent_Seting.Text = "Sent Seting"
        Me.bSent_Seting.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 480)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Delay, millisec"
        '
        'sleepTime
        '
        Me.sleepTime.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.sleepTime.Location = New System.Drawing.Point(17, 504)
        Me.sleepTime.Name = "sleepTime"
        Me.sleepTime.Size = New System.Drawing.Size(132, 29)
        Me.sleepTime.TabIndex = 4
        Me.sleepTime.Text = "50"
        '
        'cbVisualization
        '
        Me.cbVisualization.AutoSize = True
        Me.cbVisualization.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbVisualization.Location = New System.Drawing.Point(17, 410)
        Me.cbVisualization.Name = "cbVisualization"
        Me.cbVisualization.Size = New System.Drawing.Size(122, 25)
        Me.cbVisualization.TabIndex = 5
        Me.cbVisualization.Text = "Vizualization"
        Me.cbVisualization.UseVisualStyleBackColor = True
        '
        'cbBubble
        '
        Me.cbBubble.AutoSize = True
        Me.cbBubble.Checked = True
        Me.cbBubble.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbBubble.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbBubble.Location = New System.Drawing.Point(17, 136)
        Me.cbBubble.Name = "cbBubble"
        Me.cbBubble.Size = New System.Drawing.Size(82, 25)
        Me.cbBubble.TabIndex = 6
        Me.cbBubble.Text = "Bubble"
        Me.cbBubble.UseVisualStyleBackColor = True
        '
        'cbSelection
        '
        Me.cbSelection.AutoSize = True
        Me.cbSelection.Checked = True
        Me.cbSelection.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSelection.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbSelection.Location = New System.Drawing.Point(17, 167)
        Me.cbSelection.Name = "cbSelection"
        Me.cbSelection.Size = New System.Drawing.Size(97, 25)
        Me.cbSelection.TabIndex = 7
        Me.cbSelection.Text = "Selection"
        Me.cbSelection.UseVisualStyleBackColor = True
        '
        'cbInsertion
        '
        Me.cbInsertion.AutoSize = True
        Me.cbInsertion.Checked = True
        Me.cbInsertion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbInsertion.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbInsertion.Location = New System.Drawing.Point(17, 198)
        Me.cbInsertion.Name = "cbInsertion"
        Me.cbInsertion.Size = New System.Drawing.Size(94, 25)
        Me.cbInsertion.TabIndex = 8
        Me.cbInsertion.Text = "Insertion"
        Me.cbInsertion.UseVisualStyleBackColor = True
        '
        'cbGnome
        '
        Me.cbGnome.AutoSize = True
        Me.cbGnome.Checked = True
        Me.cbGnome.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbGnome.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbGnome.Location = New System.Drawing.Point(17, 229)
        Me.cbGnome.Name = "cbGnome"
        Me.cbGnome.Size = New System.Drawing.Size(84, 25)
        Me.cbGnome.TabIndex = 9
        Me.cbGnome.Text = "Gnome"
        Me.cbGnome.UseVisualStyleBackColor = True
        '
        'cbShell
        '
        Me.cbShell.AutoSize = True
        Me.cbShell.Checked = True
        Me.cbShell.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbShell.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbShell.Location = New System.Drawing.Point(17, 260)
        Me.cbShell.Name = "cbShell"
        Me.cbShell.Size = New System.Drawing.Size(65, 25)
        Me.cbShell.TabIndex = 10
        Me.cbShell.Text = "Shell"
        Me.cbShell.UseVisualStyleBackColor = True
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
        'iMax_Min
        '
        Me.iMax_Min.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.iMax_Min.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.iMax_Min.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.iMax_Min.FormattingEnabled = True
        Me.iMax_Min.Items.AddRange(New Object() {"Min", "Max"})
        Me.iMax_Min.Location = New System.Drawing.Point(17, 333)
        Me.iMax_Min.Name = "iMax_Min"
        Me.iMax_Min.Size = New System.Drawing.Size(132, 29)
        Me.iMax_Min.TabIndex = 11
        Me.iMax_Min.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Select sort method:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Select items in a row"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "you want to sort:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 21)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "If you want to enable"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 21)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "visualization:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 438)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Select the delay between"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 459)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 21)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "permutations column:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 536)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(305, 21)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Following settings, press ""Send Seting"""
        '
        'bCancel
        '
        Me.bCancel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.bCancel.Location = New System.Drawing.Point(15, 568)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(134, 31)
        Me.bCancel.TabIndex = 20
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = True
        '
        'Sorting_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1000, 772)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.iMax_Min)
        Me.Controls.Add(Me.cbShell)
        Me.Controls.Add(Me.cbGnome)
        Me.Controls.Add(Me.cbInsertion)
        Me.Controls.Add(Me.cbSelection)
        Me.Controls.Add(Me.cbBubble)
        Me.Controls.Add(Me.cbVisualization)
        Me.Controls.Add(Me.sleepTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bSent_Seting)
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
    Friend WithEvents bSent_Seting As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents sleepTime As TextBox
    Friend WithEvents cbVisualization As CheckBox
    Friend WithEvents cbBubble As CheckBox
    Friend WithEvents cbSelection As CheckBox
    Friend WithEvents cbInsertion As CheckBox
    Friend WithEvents cbGnome As CheckBox
    Friend WithEvents cbShell As CheckBox
    Friend WithEvents iMax_Min As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents bCancel As Button
End Class
