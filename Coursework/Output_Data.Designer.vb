<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Output_Data
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Output_Data))
        Me.oStart = New System.Windows.Forms.DataGridView()
        Me.oEnd = New System.Windows.Forms.DataGridView()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pTable = New System.Windows.Forms.PictureBox()
        Me.bClose = New System.Windows.Forms.Button()
        Me.oTShell = New System.Windows.Forms.Label()
        Me.oNShell = New System.Windows.Forms.Label()
        Me.oTGnome = New System.Windows.Forms.Label()
        Me.oNGnome = New System.Windows.Forms.Label()
        Me.oTInsertion = New System.Windows.Forms.Label()
        Me.oNInsertion = New System.Windows.Forms.Label()
        Me.oTSelection = New System.Windows.Forms.Label()
        Me.oNSelection = New System.Windows.Forms.Label()
        Me.oTBubble = New System.Windows.Forms.Label()
        Me.oNBubble = New System.Windows.Forms.Label()
        CType(Me.oStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.oStart.ReadOnly = True
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
        Me.oEnd.ReadOnly = True
        Me.oEnd.RowHeadersVisible = False
        Me.oEnd.Size = New System.Drawing.Size(100, 100)
        Me.oEnd.TabIndex = 9
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(12, 244)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(379, 211)
        Me.Chart1.TabIndex = 27
        Me.Chart1.Text = "Chart1"
        Title1.Name = "Перестановки"
        Title1.Text = "Кількість перестановок"
        Me.Chart1.Titles.Add(Title1)
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(12, 461)
        Me.Chart2.Name = "Chart2"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(379, 211)
        Me.Chart2.TabIndex = 28
        Me.Chart2.Text = "Chart2"
        Title2.Name = "Title1"
        Title2.Text = "Час роботи"
        Me.Chart2.Titles.Add(Title2)
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(397, 641)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 31)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Export data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pTable
        '
        Me.pTable.BackgroundImage = Global.Coursework.My.Resources.Resources.Table
        Me.pTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pTable.Location = New System.Drawing.Point(102, 12)
        Me.pTable.Name = "pTable"
        Me.pTable.Size = New System.Drawing.Size(300, 226)
        Me.pTable.TabIndex = 30
        Me.pTable.TabStop = False
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
        'oTShell
        '
        Me.oTShell.AutoSize = True
        Me.oTShell.Location = New System.Drawing.Point(219, 212)
        Me.oTShell.Name = "oTShell"
        Me.oTShell.Size = New System.Drawing.Size(25, 13)
        Me.oTShell.TabIndex = 40
        Me.oTShell.Text = "000"
        '
        'oNShell
        '
        Me.oNShell.AutoSize = True
        Me.oNShell.Location = New System.Drawing.Point(330, 212)
        Me.oNShell.Name = "oNShell"
        Me.oNShell.Size = New System.Drawing.Size(25, 13)
        Me.oNShell.TabIndex = 39
        Me.oNShell.Text = "000"
        '
        'oTGnome
        '
        Me.oTGnome.AutoSize = True
        Me.oTGnome.Location = New System.Drawing.Point(219, 175)
        Me.oTGnome.Name = "oTGnome"
        Me.oTGnome.Size = New System.Drawing.Size(25, 13)
        Me.oTGnome.TabIndex = 38
        Me.oTGnome.Text = "000"
        '
        'oNGnome
        '
        Me.oNGnome.AutoSize = True
        Me.oNGnome.Location = New System.Drawing.Point(330, 175)
        Me.oNGnome.Name = "oNGnome"
        Me.oNGnome.Size = New System.Drawing.Size(25, 13)
        Me.oNGnome.TabIndex = 37
        Me.oNGnome.Text = "000"
        '
        'oTInsertion
        '
        Me.oTInsertion.AutoSize = True
        Me.oTInsertion.Location = New System.Drawing.Point(219, 137)
        Me.oTInsertion.Name = "oTInsertion"
        Me.oTInsertion.Size = New System.Drawing.Size(25, 13)
        Me.oTInsertion.TabIndex = 36
        Me.oTInsertion.Text = "000"
        '
        'oNInsertion
        '
        Me.oNInsertion.AutoSize = True
        Me.oNInsertion.Location = New System.Drawing.Point(330, 137)
        Me.oNInsertion.Name = "oNInsertion"
        Me.oNInsertion.Size = New System.Drawing.Size(25, 13)
        Me.oNInsertion.TabIndex = 35
        Me.oNInsertion.Text = "000"
        '
        'oTSelection
        '
        Me.oTSelection.AutoSize = True
        Me.oTSelection.Location = New System.Drawing.Point(219, 100)
        Me.oTSelection.Name = "oTSelection"
        Me.oTSelection.Size = New System.Drawing.Size(25, 13)
        Me.oTSelection.TabIndex = 34
        Me.oTSelection.Text = "000"
        '
        'oNSelection
        '
        Me.oNSelection.AutoSize = True
        Me.oNSelection.Location = New System.Drawing.Point(330, 100)
        Me.oNSelection.Name = "oNSelection"
        Me.oNSelection.Size = New System.Drawing.Size(25, 13)
        Me.oNSelection.TabIndex = 33
        Me.oNSelection.Text = "000"
        '
        'oTBubble
        '
        Me.oTBubble.AutoSize = True
        Me.oTBubble.Location = New System.Drawing.Point(219, 63)
        Me.oTBubble.Name = "oTBubble"
        Me.oTBubble.Size = New System.Drawing.Size(25, 13)
        Me.oTBubble.TabIndex = 32
        Me.oTBubble.Text = "000"
        '
        'oNBubble
        '
        Me.oNBubble.AutoSize = True
        Me.oNBubble.Location = New System.Drawing.Point(330, 63)
        Me.oNBubble.Name = "oNBubble"
        Me.oNBubble.Size = New System.Drawing.Size(25, 13)
        Me.oNBubble.TabIndex = 31
        Me.oNBubble.Text = "000"
        '
        'Output_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1000, 780)
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
        Me.Controls.Add(Me.pTable)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
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
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bClose As Button
    Friend WithEvents oStart As DataGridView
    Friend WithEvents oEnd As DataGridView
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Button1 As Button
    Friend WithEvents pTable As PictureBox
    Friend WithEvents oTShell As Label
    Friend WithEvents oNShell As Label
    Friend WithEvents oTGnome As Label
    Friend WithEvents oNGnome As Label
    Friend WithEvents oTInsertion As Label
    Friend WithEvents oNInsertion As Label
    Friend WithEvents oTSelection As Label
    Friend WithEvents oNSelection As Label
    Friend WithEvents oTBubble As Label
    Friend WithEvents oNBubble As Label
End Class
