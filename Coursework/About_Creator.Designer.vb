<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About_Creator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About_Creator))
        Me.txtAbout_Creator = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bClose = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAbout_Creator
        '
        Me.txtAbout_Creator.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAbout_Creator.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtAbout_Creator.Location = New System.Drawing.Point(138, 89)
        Me.txtAbout_Creator.Name = "txtAbout_Creator"
        Me.txtAbout_Creator.ReadOnly = True
        Me.txtAbout_Creator.Size = New System.Drawing.Size(381, 238)
        Me.txtAbout_Creator.TabIndex = 3
        Me.txtAbout_Creator.Text = resources.GetString("txtAbout_Creator.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.Coursework.My.Resources.Resources.Ternavskyi_Roman
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(612, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(376, 500)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'bClose
        '
        Me.bClose.BackColor = System.Drawing.Color.Transparent
        Me.bClose.BackgroundImage = Global.Coursework.My.Resources.Resources.Back
        Me.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bClose.FlatAppearance.BorderSize = 0
        Me.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClose.Location = New System.Drawing.Point(10, 12)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(60, 60)
        Me.bClose.TabIndex = 2
        Me.bClose.UseVisualStyleBackColor = False
        '
        'About_Creator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 1000)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtAbout_Creator)
        Me.Controls.Add(Me.bClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "About_Creator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "About_Creator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bClose As Button
    Friend WithEvents txtAbout_Creator As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
