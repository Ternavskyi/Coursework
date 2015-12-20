<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Input_Data
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Input_Data))
        Me.bClose = New System.Windows.Forms.Button()
        Me.iInput_Method = New System.Windows.Forms.ComboBox()
        Me.Open_matrix_file = New System.Windows.Forms.OpenFileDialog()
        Me.bOpen_matrix_file = New System.Windows.Forms.Button()
        Me.iOpen_matrix_file = New System.Windows.Forms.TextBox()
        Me.iView_Generation = New System.Windows.Forms.ComboBox()
        Me.iDimension_matrix = New System.Windows.Forms.NumericUpDown()
        Me.oStart = New System.Windows.Forms.DataGridView()
        CType(Me.iDimension_matrix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bClose
        '
        Me.bClose.Location = New System.Drawing.Point(12, 12)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(75, 23)
        Me.bClose.TabIndex = 0
        Me.bClose.Text = "Close"
        Me.bClose.UseVisualStyleBackColor = True
        '
        'iInput_Method
        '
        Me.iInput_Method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.iInput_Method.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iInput_Method.FormattingEnabled = True
        Me.iInput_Method.Items.AddRange(New Object() {"Open matrix file", "Create matrix"})
        Me.iInput_Method.Location = New System.Drawing.Point(13, 176)
        Me.iInput_Method.Name = "iInput_Method"
        Me.iInput_Method.Size = New System.Drawing.Size(274, 21)
        Me.iInput_Method.TabIndex = 1
        '
        'Open_matrix_file
        '
        Me.Open_matrix_file.FileName = "Open matrix file"
        '
        'bOpen_matrix_file
        '
        Me.bOpen_matrix_file.Location = New System.Drawing.Point(12, 205)
        Me.bOpen_matrix_file.Name = "bOpen_matrix_file"
        Me.bOpen_matrix_file.Size = New System.Drawing.Size(75, 22)
        Me.bOpen_matrix_file.TabIndex = 2
        Me.bOpen_matrix_file.Text = "Open"
        Me.bOpen_matrix_file.UseVisualStyleBackColor = True
        Me.bOpen_matrix_file.Visible = False
        '
        'iOpen_matrix_file
        '
        Me.iOpen_matrix_file.Location = New System.Drawing.Point(86, 206)
        Me.iOpen_matrix_file.Name = "iOpen_matrix_file"
        Me.iOpen_matrix_file.Size = New System.Drawing.Size(201, 20)
        Me.iOpen_matrix_file.TabIndex = 3
        Me.iOpen_matrix_file.Visible = False
        '
        'iView_Generation
        '
        Me.iView_Generation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.iView_Generation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iView_Generation.FormattingEnabled = True
        Me.iView_Generation.Items.AddRange(New Object() {"Generate randomly matrix", "Generate empty matrix"})
        Me.iView_Generation.Location = New System.Drawing.Point(12, 234)
        Me.iView_Generation.Name = "iView_Generation"
        Me.iView_Generation.Size = New System.Drawing.Size(275, 21)
        Me.iView_Generation.TabIndex = 5
        Me.iView_Generation.Visible = False
        '
        'iDimension_matrix
        '
        Me.iDimension_matrix.Location = New System.Drawing.Point(13, 206)
        Me.iDimension_matrix.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.iDimension_matrix.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.iDimension_matrix.Name = "iDimension_matrix"
        Me.iDimension_matrix.Size = New System.Drawing.Size(274, 20)
        Me.iDimension_matrix.TabIndex = 6
        Me.iDimension_matrix.Value = New Decimal(New Integer() {2, 0, 0, 0})
        Me.iDimension_matrix.Visible = False
        '
        'oStart
        '
        Me.oStart.AllowUserToAddRows = False
        Me.oStart.AllowUserToDeleteRows = False
        Me.oStart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.oStart.Location = New System.Drawing.Point(-17, 98)
        Me.oStart.Name = "oStart"
        Me.oStart.Size = New System.Drawing.Size(400, 400)
        Me.oStart.TabIndex = 7
        '
        'Input_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 772)
        Me.Controls.Add(Me.oStart)
        Me.Controls.Add(Me.iDimension_matrix)
        Me.Controls.Add(Me.iView_Generation)
        Me.Controls.Add(Me.iOpen_matrix_file)
        Me.Controls.Add(Me.bOpen_matrix_file)
        Me.Controls.Add(Me.iInput_Method)
        Me.Controls.Add(Me.bClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Input_Data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Input_Data"
        CType(Me.iDimension_matrix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bClose As Button
    Friend WithEvents iInput_Method As ComboBox
    Friend WithEvents Open_matrix_file As OpenFileDialog
    Friend WithEvents bOpen_matrix_file As Button
    Friend WithEvents iOpen_matrix_file As TextBox
    Friend WithEvents iView_Generation As ComboBox
    Friend WithEvents iDimension_matrix As NumericUpDown
    Friend WithEvents oStart As DataGridView
End Class
