<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class About_Program
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About_Program))
        Me.txtAbout_Program = New System.Windows.Forms.RichTextBox()
        Me.txtVS = New System.Windows.Forms.Label()
        Me.txtIDE = New System.Windows.Forms.Label()
        Me.txtGit = New System.Windows.Forms.Label()
        Me.txtGitHub = New System.Windows.Forms.Label()
        Me.txtProk = New System.Windows.Forms.Label()
        Me.txtVisualization = New System.Windows.Forms.Label()
        Me.pVisualization = New System.Windows.Forms.PictureBox()
        Me.pProk = New System.Windows.Forms.PictureBox()
        Me.pGitHub = New System.Windows.Forms.PictureBox()
        Me.pGit = New System.Windows.Forms.PictureBox()
        Me.pIDE = New System.Windows.Forms.PictureBox()
        Me.pVS = New System.Windows.Forms.PictureBox()
        Me.bClose = New System.Windows.Forms.Button()
        CType(Me.pVisualization, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pProk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pGitHub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pGit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pIDE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pVS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAbout_Program
        '
        Me.txtAbout_Program.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAbout_Program.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtAbout_Program.Location = New System.Drawing.Point(92, 36)
        Me.txtAbout_Program.Name = "txtAbout_Program"
        Me.txtAbout_Program.ReadOnly = True
        Me.txtAbout_Program.Size = New System.Drawing.Size(448, 106)
        Me.txtAbout_Program.TabIndex = 2
        Me.txtAbout_Program.Text = resources.GetString("txtAbout_Program.Text")
        '
        'txtVS
        '
        Me.txtVS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVS.AutoSize = True
        Me.txtVS.Location = New System.Drawing.Point(769, 115)
        Me.txtVS.Name = "txtVS"
        Me.txtVS.Size = New System.Drawing.Size(214, 13)
        Me.txtVS.TabIndex = 4
        Me.txtVS.Text = "Рисунок 2.1 - логотип ""Visual Studio 14.0"""
        '
        'txtIDE
        '
        Me.txtIDE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIDE.AutoSize = True
        Me.txtIDE.Location = New System.Drawing.Point(769, 234)
        Me.txtIDE.Name = "txtIDE"
        Me.txtIDE.Size = New System.Drawing.Size(138, 13)
        Me.txtIDE.TabIndex = 6
        Me.txtIDE.Text = "Рисунок 2.2 - ""Aboud IDE"""
        '
        'txtGit
        '
        Me.txtGit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGit.AutoSize = True
        Me.txtGit.Location = New System.Drawing.Point(769, 353)
        Me.txtGit.Name = "txtGit"
        Me.txtGit.Size = New System.Drawing.Size(142, 13)
        Me.txtGit.TabIndex = 8
        Me.txtGit.Text = "Рисунок 2.3 - логотип ""Git"""
        '
        'txtGitHub
        '
        Me.txtGitHub.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGitHub.AutoSize = True
        Me.txtGitHub.Location = New System.Drawing.Point(769, 472)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.Size = New System.Drawing.Size(162, 13)
        Me.txtGitHub.TabIndex = 10
        Me.txtGitHub.Text = "Рисунок 2.4 - логотип ""GitHub"""
        '
        'txtProk
        '
        Me.txtProk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProk.AutoSize = True
        Me.txtProk.Location = New System.Drawing.Point(769, 591)
        Me.txtProk.Name = "txtProk"
        Me.txtProk.Size = New System.Drawing.Size(167, 13)
        Me.txtProk.TabIndex = 12
        Me.txtProk.Text = "Рисунок 2.5 - полоса прокрутки"
        '
        'txtVisualization
        '
        Me.txtVisualization.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVisualization.AutoSize = True
        Me.txtVisualization.Location = New System.Drawing.Point(769, 710)
        Me.txtVisualization.Name = "txtVisualization"
        Me.txtVisualization.Size = New System.Drawing.Size(135, 13)
        Me.txtVisualization.TabIndex = 14
        Me.txtVisualization.Text = "Рисунок 2.6 - візуалізація"
        '
        'pVisualization
        '
        Me.pVisualization.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pVisualization.BackColor = System.Drawing.Color.Transparent
        Me.pVisualization.BackgroundImage = Global.Coursework.My.Resources.Resources.Visual
        Me.pVisualization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pVisualization.Location = New System.Drawing.Point(772, 607)
        Me.pVisualization.Name = "pVisualization"
        Me.pVisualization.Size = New System.Drawing.Size(100, 100)
        Me.pVisualization.TabIndex = 13
        Me.pVisualization.TabStop = False
        '
        'pProk
        '
        Me.pProk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pProk.BackColor = System.Drawing.Color.Transparent
        Me.pProk.BackgroundImage = Global.Coursework.My.Resources.Resources.Prok
        Me.pProk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pProk.Location = New System.Drawing.Point(772, 488)
        Me.pProk.Name = "pProk"
        Me.pProk.Size = New System.Drawing.Size(100, 100)
        Me.pProk.TabIndex = 11
        Me.pProk.TabStop = False
        '
        'pGitHub
        '
        Me.pGitHub.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pGitHub.BackColor = System.Drawing.Color.Transparent
        Me.pGitHub.BackgroundImage = Global.Coursework.My.Resources.Resources.GitHub
        Me.pGitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pGitHub.Location = New System.Drawing.Point(772, 369)
        Me.pGitHub.Name = "pGitHub"
        Me.pGitHub.Size = New System.Drawing.Size(100, 100)
        Me.pGitHub.TabIndex = 9
        Me.pGitHub.TabStop = False
        '
        'pGit
        '
        Me.pGit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pGit.BackColor = System.Drawing.Color.Transparent
        Me.pGit.BackgroundImage = Global.Coursework.My.Resources.Resources.Git
        Me.pGit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pGit.Location = New System.Drawing.Point(772, 250)
        Me.pGit.Name = "pGit"
        Me.pGit.Size = New System.Drawing.Size(100, 100)
        Me.pGit.TabIndex = 7
        Me.pGit.TabStop = False
        '
        'pIDE
        '
        Me.pIDE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pIDE.BackColor = System.Drawing.Color.Transparent
        Me.pIDE.BackgroundImage = Global.Coursework.My.Resources.Resources.IDE
        Me.pIDE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pIDE.Location = New System.Drawing.Point(772, 131)
        Me.pIDE.Name = "pIDE"
        Me.pIDE.Size = New System.Drawing.Size(100, 100)
        Me.pIDE.TabIndex = 5
        Me.pIDE.TabStop = False
        '
        'pVS
        '
        Me.pVS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pVS.BackColor = System.Drawing.Color.Transparent
        Me.pVS.BackgroundImage = Global.Coursework.My.Resources.Resources.VS
        Me.pVS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pVS.Location = New System.Drawing.Point(772, 12)
        Me.pVS.Name = "pVS"
        Me.pVS.Size = New System.Drawing.Size(100, 100)
        Me.pVS.TabIndex = 3
        Me.pVS.TabStop = False
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
        Me.bClose.TabIndex = 1
        Me.bClose.UseVisualStyleBackColor = False
        '
        'About_Program
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1000, 1000)
        Me.Controls.Add(Me.txtVisualization)
        Me.Controls.Add(Me.pVisualization)
        Me.Controls.Add(Me.txtProk)
        Me.Controls.Add(Me.pProk)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.pGitHub)
        Me.Controls.Add(Me.txtGit)
        Me.Controls.Add(Me.pGit)
        Me.Controls.Add(Me.txtIDE)
        Me.Controls.Add(Me.pIDE)
        Me.Controls.Add(Me.txtVS)
        Me.Controls.Add(Me.pVS)
        Me.Controls.Add(Me.txtAbout_Program)
        Me.Controls.Add(Me.bClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "About_Program"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "About_Program"
        CType(Me.pVisualization, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pProk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pGitHub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pGit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pIDE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pVS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bClose As Button
    Friend WithEvents txtAbout_Program As RichTextBox
    Friend WithEvents pVS As PictureBox
    Friend WithEvents txtVS As Label
    Friend WithEvents txtIDE As Label
    Friend WithEvents pIDE As PictureBox
    Friend WithEvents txtGit As Label
    Friend WithEvents pGit As PictureBox
    Friend WithEvents txtGitHub As Label
    Friend WithEvents pGitHub As PictureBox
    Friend WithEvents txtProk As Label
    Friend WithEvents pProk As PictureBox
    Friend WithEvents txtVisualization As Label
    Friend WithEvents pVisualization As PictureBox
End Class
