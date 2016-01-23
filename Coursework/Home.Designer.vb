<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.bExit = New System.Windows.Forms.Button()
        Me.pVS = New System.Windows.Forms.PictureBox()
        Me.pCoursework = New System.Windows.Forms.PictureBox()
        Me.pIco = New System.Windows.Forms.PictureBox()
        Me.bOutput_Data = New System.Windows.Forms.Button()
        Me.bSorting_Setting = New System.Windows.Forms.Button()
        Me.bInput_Data = New System.Windows.Forms.Button()
        Me.pArrow = New System.Windows.Forms.PictureBox()
        CType(Me.pVS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCoursework, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pIco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bExit
        '
        Me.bExit.BackColor = System.Drawing.Color.Transparent
        Me.bExit.BackgroundImage = Global.Coursework.My.Resources.Resources._Exit
        Me.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bExit.FlatAppearance.BorderSize = 0
        Me.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bExit.Location = New System.Drawing.Point(25, 369)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(200, 70)
        Me.bExit.TabIndex = 7
        Me.bExit.UseVisualStyleBackColor = False
        '
        'pVS
        '
        Me.pVS.BackColor = System.Drawing.Color.Transparent
        Me.pVS.BackgroundImage = Global.Coursework.My.Resources.Resources.VS
        Me.pVS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pVS.Location = New System.Drawing.Point(731, 445)
        Me.pVS.Name = "pVS"
        Me.pVS.Size = New System.Drawing.Size(100, 100)
        Me.pVS.TabIndex = 6
        Me.pVS.TabStop = False
        '
        'pCoursework
        '
        Me.pCoursework.BackColor = System.Drawing.Color.Transparent
        Me.pCoursework.BackgroundImage = Global.Coursework.My.Resources.Resources.Coursework
        Me.pCoursework.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pCoursework.Location = New System.Drawing.Point(519, 445)
        Me.pCoursework.Name = "pCoursework"
        Me.pCoursework.Size = New System.Drawing.Size(100, 100)
        Me.pCoursework.TabIndex = 5
        Me.pCoursework.TabStop = False
        '
        'pIco
        '
        Me.pIco.BackColor = System.Drawing.Color.Transparent
        Me.pIco.BackgroundImage = Global.Coursework.My.Resources.Resources.Ico
        Me.pIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pIco.Location = New System.Drawing.Point(625, 445)
        Me.pIco.Name = "pIco"
        Me.pIco.Size = New System.Drawing.Size(100, 100)
        Me.pIco.TabIndex = 4
        Me.pIco.TabStop = False
        '
        'bOutput_Data
        '
        Me.bOutput_Data.BackColor = System.Drawing.Color.Salmon
        Me.bOutput_Data.BackgroundImage = Global.Coursework.My.Resources.Resources.Sort
        Me.bOutput_Data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bOutput_Data.Enabled = False
        Me.bOutput_Data.FlatAppearance.BorderSize = 0
        Me.bOutput_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bOutput_Data.Location = New System.Drawing.Point(702, 0)
        Me.bOutput_Data.Name = "bOutput_Data"
        Me.bOutput_Data.Size = New System.Drawing.Size(300, 300)
        Me.bOutput_Data.TabIndex = 2
        Me.bOutput_Data.UseVisualStyleBackColor = False
        '
        'bSorting_Setting
        '
        Me.bSorting_Setting.BackColor = System.Drawing.Color.Salmon
        Me.bSorting_Setting.BackgroundImage = Global.Coursework.My.Resources.Resources.Sorting_Setting
        Me.bSorting_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bSorting_Setting.Enabled = False
        Me.bSorting_Setting.FlatAppearance.BorderSize = 0
        Me.bSorting_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSorting_Setting.Location = New System.Drawing.Point(360, 0)
        Me.bSorting_Setting.Name = "bSorting_Setting"
        Me.bSorting_Setting.Size = New System.Drawing.Size(300, 300)
        Me.bSorting_Setting.TabIndex = 1
        Me.bSorting_Setting.UseVisualStyleBackColor = False
        '
        'bInput_Data
        '
        Me.bInput_Data.BackColor = System.Drawing.Color.Aqua
        Me.bInput_Data.BackgroundImage = Global.Coursework.My.Resources.Resources.Generate
        Me.bInput_Data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bInput_Data.FlatAppearance.BorderSize = 0
        Me.bInput_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bInput_Data.Location = New System.Drawing.Point(0, 0)
        Me.bInput_Data.Name = "bInput_Data"
        Me.bInput_Data.Size = New System.Drawing.Size(300, 300)
        Me.bInput_Data.TabIndex = 0
        Me.bInput_Data.UseVisualStyleBackColor = False
        '
        'pArrow
        '
        Me.pArrow.BackgroundImage = Global.Coursework.My.Resources.Resources.Arrow
        Me.pArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pArrow.Location = New System.Drawing.Point(227, 512)
        Me.pArrow.Name = "pArrow"
        Me.pArrow.Size = New System.Drawing.Size(105, 150)
        Me.pArrow.TabIndex = 8
        Me.pArrow.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1000, 780)
        Me.Controls.Add(Me.pArrow)
        Me.Controls.Add(Me.bExit)
        Me.Controls.Add(Me.pVS)
        Me.Controls.Add(Me.pCoursework)
        Me.Controls.Add(Me.pIco)
        Me.Controls.Add(Me.bOutput_Data)
        Me.Controls.Add(Me.bSorting_Setting)
        Me.Controls.Add(Me.bInput_Data)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Home"
        CType(Me.pVS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCoursework, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pIco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pArrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bInput_Data As Button
    Friend WithEvents bSorting_Setting As Button
    Friend WithEvents bOutput_Data As Button
    Friend WithEvents pIco As PictureBox
    Friend WithEvents pCoursework As PictureBox
    Friend WithEvents pVS As PictureBox
    Friend WithEvents bExit As Button
    Friend WithEvents pArrow As PictureBox
End Class
