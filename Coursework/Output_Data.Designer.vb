<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.oStart = New System.Windows.Forms.DataGridView()
        Me.oEnd = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.oTBubble = New System.Windows.Forms.Label()
        Me.oNBubble = New System.Windows.Forms.Label()
        Me.oTSelection = New System.Windows.Forms.Label()
        Me.oNSelection = New System.Windows.Forms.Label()
        Me.oTInsertion = New System.Windows.Forms.Label()
        Me.oNInsertion = New System.Windows.Forms.Label()
        Me.oTGnome = New System.Windows.Forms.Label()
        Me.oNGnome = New System.Windows.Forms.Label()
        Me.oTShell = New System.Windows.Forms.Label()
        Me.oNShell = New System.Windows.Forms.Label()
        CType(Me.oStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oEnd, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'oStart
        '
        Me.oStart.AllowUserToAddRows = False
        Me.oStart.AllowUserToDeleteRows = False
        Me.oStart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.oStart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.oStart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.oStart.ColumnHeadersVisible = False
        Me.oStart.Location = New System.Drawing.Point(888, 12)
        Me.oStart.Name = "oStart"
        Me.oStart.RowHeadersVisible = False
        Me.oStart.Size = New System.Drawing.Size(100, 100)
        Me.oStart.TabIndex = 8
        '
        'oEnd
        '
        Me.oEnd.AllowUserToAddRows = False
        Me.oEnd.AllowUserToDeleteRows = False
        Me.oEnd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.oEnd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.oEnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.oEnd.ColumnHeadersVisible = False
        Me.oEnd.Location = New System.Drawing.Point(888, 660)
        Me.oEnd.Name = "oEnd"
        Me.oEnd.RowHeadersVisible = False
        Me.oEnd.Size = New System.Drawing.Size(100, 100)
        Me.oEnd.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(10, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Bubble"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(10, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Selection"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(10, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Insertion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(10, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Gnome"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(10, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Shell"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(110, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "N"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(201, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Time"
        '
        'oTBubble
        '
        Me.oTBubble.AutoSize = True
        Me.oTBubble.Location = New System.Drawing.Point(201, 149)
        Me.oTBubble.Name = "oTBubble"
        Me.oTBubble.Size = New System.Drawing.Size(0, 13)
        Me.oTBubble.TabIndex = 18
        '
        'oNBubble
        '
        Me.oNBubble.AutoSize = True
        Me.oNBubble.Location = New System.Drawing.Point(110, 149)
        Me.oNBubble.Name = "oNBubble"
        Me.oNBubble.Size = New System.Drawing.Size(0, 13)
        Me.oNBubble.TabIndex = 17
        '
        'oTSelection
        '
        Me.oTSelection.AutoSize = True
        Me.oTSelection.Location = New System.Drawing.Point(201, 173)
        Me.oTSelection.Name = "oTSelection"
        Me.oTSelection.Size = New System.Drawing.Size(0, 13)
        Me.oTSelection.TabIndex = 20
        '
        'oNSelection
        '
        Me.oNSelection.AutoSize = True
        Me.oNSelection.Location = New System.Drawing.Point(110, 173)
        Me.oNSelection.Name = "oNSelection"
        Me.oNSelection.Size = New System.Drawing.Size(0, 13)
        Me.oNSelection.TabIndex = 19
        '
        'oTInsertion
        '
        Me.oTInsertion.AutoSize = True
        Me.oTInsertion.Location = New System.Drawing.Point(201, 197)
        Me.oTInsertion.Name = "oTInsertion"
        Me.oTInsertion.Size = New System.Drawing.Size(0, 13)
        Me.oTInsertion.TabIndex = 22
        '
        'oNInsertion
        '
        Me.oNInsertion.AutoSize = True
        Me.oNInsertion.Location = New System.Drawing.Point(110, 197)
        Me.oNInsertion.Name = "oNInsertion"
        Me.oNInsertion.Size = New System.Drawing.Size(0, 13)
        Me.oNInsertion.TabIndex = 21
        '
        'oTGnome
        '
        Me.oTGnome.AutoSize = True
        Me.oTGnome.Location = New System.Drawing.Point(201, 220)
        Me.oTGnome.Name = "oTGnome"
        Me.oTGnome.Size = New System.Drawing.Size(0, 13)
        Me.oTGnome.TabIndex = 24
        '
        'oNGnome
        '
        Me.oNGnome.AutoSize = True
        Me.oNGnome.Location = New System.Drawing.Point(110, 220)
        Me.oNGnome.Name = "oNGnome"
        Me.oNGnome.Size = New System.Drawing.Size(0, 13)
        Me.oNGnome.TabIndex = 23
        '
        'oTShell
        '
        Me.oTShell.AutoSize = True
        Me.oTShell.Location = New System.Drawing.Point(201, 243)
        Me.oTShell.Name = "oTShell"
        Me.oTShell.Size = New System.Drawing.Size(0, 13)
        Me.oTShell.TabIndex = 26
        '
        'oNShell
        '
        Me.oNShell.AutoSize = True
        Me.oNShell.Location = New System.Drawing.Point(110, 243)
        Me.oNShell.Name = "oNShell"
        Me.oNShell.Size = New System.Drawing.Size(0, 13)
        Me.oNShell.TabIndex = 25
        '
        'Output_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1000, 772)
        Me.Controls.Add(Me.oTShell)
        Me.Controls.Add(Me.oNShell)
        Me.Controls.Add(Me.oTGnome)
        Me.Controls.Add(Me.oNGnome)
        Me.Controls.Add(Me.oTInsertion)
        Me.Controls.Add(Me.oNInsertion)
        Me.Controls.Add(Me.oTSelection)
        Me.Controls.Add(Me.oNSelection)
        Me.Controls.Add(Me.oTBubble)
        Me.Controls.Add(Me.oNBubble)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.oEnd)
        Me.Controls.Add(Me.oStart)
        Me.Controls.Add(Me.bClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Output_Data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Output_Data"
        CType(Me.oStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oEnd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bClose As Button
    Friend WithEvents oStart As DataGridView
    Friend WithEvents oEnd As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents oTBubble As Label
    Friend WithEvents oNBubble As Label
    Friend WithEvents oTSelection As Label
    Friend WithEvents oNSelection As Label
    Friend WithEvents oTInsertion As Label
    Friend WithEvents oNInsertion As Label
    Friend WithEvents oTGnome As Label
    Friend WithEvents oNGnome As Label
    Friend WithEvents oTShell As Label
    Friend WithEvents oNShell As Label
End Class
