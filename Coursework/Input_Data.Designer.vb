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
        Me.iInput_Method = New System.Windows.Forms.ComboBox()
        Me.Open_matrix_file = New System.Windows.Forms.OpenFileDialog()
        Me.iView_Generation = New System.Windows.Forms.ComboBox()
        Me.oStart = New System.Windows.Forms.DataGridView()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.bOk = New System.Windows.Forms.Button()
        Me.bSend_data = New System.Windows.Forms.Button()
        Me.bClose = New System.Windows.Forms.Button()
        Me.iDimension_matrix = New System.Windows.Forms.NumericUpDown()
        Me.iOpen_matrix_file = New System.Windows.Forms.TextBox()
        Me.bOpen_matrix_file = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.oStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iDimension_matrix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iInput_Method
        '
        Me.iInput_Method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.iInput_Method.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.iInput_Method.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.iInput_Method.FormattingEnabled = True
        Me.iInput_Method.Items.AddRange(New Object() {"Open matrix file", "Create matrix"})
        Me.iInput_Method.Location = New System.Drawing.Point(13, 131)
        Me.iInput_Method.Name = "iInput_Method"
        Me.iInput_Method.Size = New System.Drawing.Size(400, 29)
        Me.iInput_Method.TabIndex = 1
        Me.iInput_Method.Tag = ""
        '
        'iView_Generation
        '
        Me.iView_Generation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.iView_Generation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iView_Generation.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.iView_Generation.FormattingEnabled = True
        Me.iView_Generation.Items.AddRange(New Object() {"Generate randomly matrix", "Generate empty matrix"})
        Me.iView_Generation.Location = New System.Drawing.Point(15, 245)
        Me.iView_Generation.Name = "iView_Generation"
        Me.iView_Generation.Size = New System.Drawing.Size(400, 29)
        Me.iView_Generation.TabIndex = 5
        Me.iView_Generation.Visible = False
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
        Me.oStart.TabIndex = 7
        '
        'bCancel
        '
        Me.bCancel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.bCancel.Location = New System.Drawing.Point(22, 423)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(195, 31)
        Me.bCancel.TabIndex = 8
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = True
        '
        'bOk
        '
        Me.bOk.Enabled = False
        Me.bOk.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.bOk.Location = New System.Drawing.Point(223, 423)
        Me.bOk.Name = "bOk"
        Me.bOk.Size = New System.Drawing.Size(195, 31)
        Me.bOk.TabIndex = 9
        Me.bOk.Text = "Ok"
        Me.bOk.UseVisualStyleBackColor = True
        '
        'bSend_data
        '
        Me.bSend_data.Enabled = False
        Me.bSend_data.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.bSend_data.Location = New System.Drawing.Point(18, 460)
        Me.bSend_data.Name = "bSend_data"
        Me.bSend_data.Size = New System.Drawing.Size(400, 31)
        Me.bSend_data.TabIndex = 10
        Me.bSend_data.Text = "Send data"
        Me.bSend_data.UseVisualStyleBackColor = True
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
        Me.bClose.TabIndex = 0
        Me.bClose.UseVisualStyleBackColor = False
        '
        'iDimension_matrix
        '
        Me.iDimension_matrix.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.iDimension_matrix.Location = New System.Drawing.Point(13, 188)
        Me.iDimension_matrix.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.iDimension_matrix.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.iDimension_matrix.Name = "iDimension_matrix"
        Me.iDimension_matrix.Size = New System.Drawing.Size(400, 29)
        Me.iDimension_matrix.TabIndex = 11
        Me.iDimension_matrix.Value = New Decimal(New Integer() {2, 0, 0, 0})
        Me.iDimension_matrix.Visible = False
        '
        'iOpen_matrix_file
        '
        Me.iOpen_matrix_file.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.iOpen_matrix_file.Location = New System.Drawing.Point(86, 188)
        Me.iOpen_matrix_file.Name = "iOpen_matrix_file"
        Me.iOpen_matrix_file.Size = New System.Drawing.Size(327, 29)
        Me.iOpen_matrix_file.TabIndex = 13
        Me.iOpen_matrix_file.Visible = False
        '
        'bOpen_matrix_file
        '
        Me.bOpen_matrix_file.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.bOpen_matrix_file.Location = New System.Drawing.Point(13, 187)
        Me.bOpen_matrix_file.Name = "bOpen_matrix_file"
        Me.bOpen_matrix_file.Size = New System.Drawing.Size(74, 31)
        Me.bOpen_matrix_file.TabIndex = 12
        Me.bOpen_matrix_file.Text = "Open"
        Me.bOpen_matrix_file.UseVisualStyleBackColor = True
        Me.bOpen_matrix_file.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 21)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Choose a method for creating matrix:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Open the file *.txt or the file path:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Enter the dimension of the matrix:"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 21)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Select matrix to generate:"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(395, 21)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "After entering all the settings, click ""Ok"" to generate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 378)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(385, 21)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "the matrix and then ""Send data"" to dispatch matrix"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 399)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 21)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "processing."
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(214, 322)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(195, 29)
        Me.NumericUpDown2.TabIndex = 30
        Me.NumericUpDown2.Value = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDown2.Visible = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(13, 322)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(195, 29)
        Me.NumericUpDown1.TabIndex = 29
        Me.NumericUpDown1.Value = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown1.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(210, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 21)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Max:"
        Me.Label10.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 21)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Min:"
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 21)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Select the verge rand:"
        Me.Label8.Visible = False
        '
        'Input_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1000, 772)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.iOpen_matrix_file)
        Me.Controls.Add(Me.bOpen_matrix_file)
        Me.Controls.Add(Me.iDimension_matrix)
        Me.Controls.Add(Me.bSend_data)
        Me.Controls.Add(Me.bOk)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.oStart)
        Me.Controls.Add(Me.iView_Generation)
        Me.Controls.Add(Me.iInput_Method)
        Me.Controls.Add(Me.bClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Input_Data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Input_Data"
        CType(Me.oStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iDimension_matrix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bClose As Button
    Friend WithEvents iInput_Method As ComboBox
    Friend WithEvents Open_matrix_file As OpenFileDialog
    Friend WithEvents iView_Generation As ComboBox
    Friend WithEvents oStart As DataGridView
    Friend WithEvents bCancel As Button
    Friend WithEvents bOk As Button
    Friend WithEvents bSend_data As Button
    Friend WithEvents bOpen_matrix_file As Button
    Friend WithEvents iOpen_matrix_file As TextBox
    Friend WithEvents iDimension_matrix As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
End Class
