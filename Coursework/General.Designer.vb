<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class General
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(General))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortingSetingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem1, Me.GenerateToolStripMenuItem, Me.SortingSetingToolStripMenuItem, Me.SortingToolStripMenuItem})
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.HomeToolStripMenuItem.Text = "General"
        '
        'HomeToolStripMenuItem1
        '
        Me.HomeToolStripMenuItem1.BackColor = System.Drawing.Color.Aqua
        Me.HomeToolStripMenuItem1.Name = "HomeToolStripMenuItem1"
        Me.HomeToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.HomeToolStripMenuItem1.Text = "Home"
        '
        'GenerateToolStripMenuItem
        '
        Me.GenerateToolStripMenuItem.BackColor = System.Drawing.Color.Aqua
        Me.GenerateToolStripMenuItem.Name = "GenerateToolStripMenuItem"
        Me.GenerateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GenerateToolStripMenuItem.Text = "Generate"
        '
        'SortingSetingToolStripMenuItem
        '
        Me.SortingSetingToolStripMenuItem.BackColor = System.Drawing.Color.Salmon
        Me.SortingSetingToolStripMenuItem.Enabled = False
        Me.SortingSetingToolStripMenuItem.Name = "SortingSetingToolStripMenuItem"
        Me.SortingSetingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SortingSetingToolStripMenuItem.Text = "Sorting Setting"
        '
        'SortingToolStripMenuItem
        '
        Me.SortingToolStripMenuItem.BackColor = System.Drawing.Color.Salmon
        Me.SortingToolStripMenuItem.Enabled = False
        Me.SortingToolStripMenuItem.Name = "SortingToolStripMenuItem"
        Me.SortingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SortingToolStripMenuItem.Text = "Sorting"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.CreatorToolStripMenuItem, Me.IDEToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'CreatorToolStripMenuItem
        '
        Me.CreatorToolStripMenuItem.Name = "CreatorToolStripMenuItem"
        Me.CreatorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CreatorToolStripMenuItem.Text = "Creator"
        '
        'IDEToolStripMenuItem
        '
        Me.IDEToolStripMenuItem.Name = "IDEToolStripMenuItem"
        Me.IDEToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IDEToolStripMenuItem.Text = "IDE"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'General
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 361)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(700, 400)
        Me.Name = "General"
        Me.Text = "General"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IDEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GenerateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortingSetingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortingToolStripMenuItem As ToolStripMenuItem
End Class
