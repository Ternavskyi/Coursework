<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About_IDE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About_IDE))
        Me.bClose = New System.Windows.Forms.Button()
        Me.txtAbout_IDE = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'bClose
        '
        Me.bClose.BackColor = System.Drawing.Color.Transparent
        Me.bClose.BackgroundImage = Global.Coursework.My.Resources.Resources.Back
        Me.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bClose.FlatAppearance.BorderSize = 0
        Me.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClose.Location = New System.Drawing.Point(12, 12)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(60, 60)
        Me.bClose.TabIndex = 3
        Me.bClose.UseVisualStyleBackColor = False
        '
        'txtAbout_IDE
        '
        Me.txtAbout_IDE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAbout_IDE.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtAbout_IDE.Location = New System.Drawing.Point(104, 80)
        Me.txtAbout_IDE.Name = "txtAbout_IDE"
        Me.txtAbout_IDE.ReadOnly = True
        Me.txtAbout_IDE.Size = New System.Drawing.Size(381, 238)
        Me.txtAbout_IDE.TabIndex = 4
        Me.txtAbout_IDE.Text = resources.GetString("txtAbout_IDE.Text")
        '
        'About_IDE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 1000)
        Me.Controls.Add(Me.txtAbout_IDE)
        Me.Controls.Add(Me.bClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "About_IDE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "About_IDE"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bClose As Button
    Friend WithEvents txtAbout_IDE As RichTextBox
End Class
