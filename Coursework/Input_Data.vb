Public Class Input_Data

    Public MatrixI(,) As Integer
    Public wh As Integer, hh As Integer
    Public whc As Integer, hhc As Integer
    Public Cize As Integer
    Public Index_Creation As Integer = 2, Index_Creation_2 As Integer = 2
    Public Path As String

    Private Sub Input_Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        wh = General.wg
        hh = General.hg
        whc = General.wgc
        hhc = General.hgc
        Me.Width = wh
        Me.Height = hh
        oStart.Location = New Point(whc - whc / 2 - 240, 12)
        oStart.Width = wh / 1.5
        oStart.Height = hh - 24
        bCancel.Width = iInput_Method.Width / 2 - 5
        bCancel.Height = iInput_Method.Height
        '****************************************************************************************************
        bOk.Width = iInput_Method.Width / 2 - 5
        bOk.Height = iInput_Method.Height
        '****************************************************************************************************
        bSend_data.Width = iInput_Method.Width
        bSend_data.Height = iInput_Method.Height
        '****************************************************************************************************
        bCancel.Location = New Point(iInput_Method.Location.X, iInput_Method.Location.Y + iInput_Method.Height + 10)
        bOk.Location = New Point(iInput_Method.Location.X + iInput_Method.Width - bOk.Width, iInput_Method.Location.Y + iInput_Method.Height + 10)
        bSend_data.Location = New Point(bCancel.Location.X, bCancel.Location.Y + bCancel.Height + 10)

    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click

        Me.Close()

    End Sub

    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click

        Me.Close()

    End Sub

    Private Sub iDimension_matrix_ValueChanged(sender As Object, e As EventArgs) Handles iDimension_matrix.ValueChanged

        Cize = iDimension_matrix.Value

    End Sub

    Private Sub iInput_Method_SelectedIndexChanged(sender As Object, e As EventArgs) Handles iInput_Method.SelectedIndexChanged

        Select Case iInput_Method.Text
            Case "Open matrix file"
                Call Open_Visual()
                Index_Creation = 0
            Case "Create matrix"
                Call Generate_Visual()
                Index_Creation = 1
        End Select

    End Sub

    Private Sub iView_Generation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles iView_Generation.SelectedIndexChanged
        Select Case iView_Generation.Text
            Case "Generate randomly matrix"
                Index_Creation_2 = 0
                oStart.Rows.Clear()
                bSend_data.Enabled = False
            Case "Generate empty matrix"
                Index_Creation_2 = 1
                oStart.Rows.Clear()
                bSend_data.Enabled = False
        End Select
        If Index_Creation_2 <> 2 Then
            bOk.Enabled = True
        End If
    End Sub

    Private Sub bOk_Click(sender As Object, e As EventArgs) Handles bOk.Click

        oStart.Rows.Clear()
        Select Case Index_Creation
            Case 0
                MsgBox("ok")
            Case 1
                If Index_Creation_2 = 0 Then
                    Call GenerateR()
                Else
                    Call GenerateE()
                End If
            Case 2
                MsgBox("You choose a method for creating matrix", 16, "Error")
            Case 3
                Call inputFromFile
        End Select

    End Sub

    Private Sub bOpen_matrix_file_Click_1(sender As Object, e As EventArgs) Handles bOpen_matrix_file.Click


        Open_matrix_file.InitialDirectory = "C:\"
        Open_matrix_file.Title = "Coursework"
        Open_matrix_file.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*"
        Open_matrix_file.FilterIndex = 1
        If Open_matrix_file.ShowDialog = DialogResult.OK Then
            bOk.Enabled = True
            Path = Open_matrix_file.FileName
            Index_Creation = 3
        Else
            Path = ""
        End If
        Debug.Print(Path)
        iOpen_matrix_file.Text = Path

    End Sub

    Private Sub Open_Visual()

        iDimension_matrix.Visible = False
        iDimension_matrix.Value = 2
        iView_Generation.Visible = False
        iView_Generation.SelectedIndex = -1
        bOpen_matrix_file.Visible = True
        iOpen_matrix_file.Visible = True
        '****************************************************************************************************
        bOpen_matrix_file.Width = iInput_Method.Width / 4
        '****************************************************************************************************
        iOpen_matrix_file.Width = (iInput_Method.Width / 4) * 3
        '****************************************************************************************************
        bOpen_matrix_file.Location = New Point(iInput_Method.Location.X, iInput_Method.Location.Y + iInput_Method.Height + 10)
        iOpen_matrix_file.Location = New Point(iInput_Method.Location.X + bOpen_matrix_file.Width, iInput_Method.Location.Y + iInput_Method.Height + 11)
        bCancel.Location = New Point(bOpen_matrix_file.Location.X, bOpen_matrix_file.Location.Y + bOpen_matrix_file.Height + 10)
        bOk.Location = New Point(bOpen_matrix_file.Location.X + iInput_Method.Width - bOk.Width, bOpen_matrix_file.Location.Y + bOpen_matrix_file.Height + 10)
        bSend_data.Location = New Point(bCancel.Location.X, bCancel.Location.Y + bCancel.Height + 10)
        bOk.Enabled = False
        oStart.Rows.Clear()
        bSend_data.Enabled = False

    End Sub

    Private Sub Generate_Visual()

        iDimension_matrix.Visible = True
        iView_Generation.Visible = True
        bOpen_matrix_file.Visible = False
        iOpen_matrix_file.Visible = False
        iOpen_matrix_file.Text = ""
        '****************************************************************************************************
        iDimension_matrix.Width = iInput_Method.Width
        '****************************************************************************************************
        iView_Generation.Width = iInput_Method.Width
        '****************************************************************************************************
        iDimension_matrix.Location = New Point(iInput_Method.Location.X, iInput_Method.Location.Y + iInput_Method.Height + 10)
        iView_Generation.Location = New Point(iInput_Method.Location.X, iDimension_matrix.Location.Y + iDimension_matrix.Height + 10)
        bCancel.Location = New Point(iView_Generation.Location.X, iView_Generation.Location.Y + iView_Generation.Height + 10)
        bOk.Location = New Point(iView_Generation.Location.X + iInput_Method.Width - bOk.Width + 2, iView_Generation.Location.Y + iView_Generation.Height + 10)
        bSend_data.Location = New Point(bCancel.Location.X, bCancel.Location.Y + bCancel.Height + 10)
        bOk.Enabled = False
        oStart.Rows.Clear()
        bSend_data.Enabled = False

    End Sub

    Private Sub GenerateR()

        Dim Rnd As New Random 'Задання нового рандому.
        Dim r As Integer, c As Integer 'Змінні які будуть перебирати рядки і стовпці.

        oStart.RowCount = Cize
        oStart.ColumnCount = Cize
        Debug.Print("**********************************************************************************")

        For r = 0 To Cize - 1 'Перебирання рядків.
            For c = 0 To Cize - 1 'Перебирання стовпців.
                oStart(c, r).Value = Rnd.Next(-100, 201) 'Запис рандомних чисел в межіх [-100,100] у матрицю.
                bSend_data.Enabled = True
            Next 'Слідуючий стовпець.
        Next 'Слідуючий рядок.
        bSend_data.Enabled = True

    End Sub

    Private Sub GenerateE()

        Dim r As Integer, c As Integer 'Змінні які будуть перебирати рядки і стовпці.

        oStart.RowCount = Cize
        oStart.ColumnCount = Cize
        Debug.Print("**********************************************************************************")

        For r = 0 To Cize - 1 'Перебирання рядків.
            For c = 0 To Cize - 1 'Перебирання стовпців.
                oStart(c, r).Value = 0
                bSend_data.Enabled = True
            Next 'Слідуючий стовпець.
        Next 'Слідуючий рядок.
        bSend_data.Enabled = True

    End Sub

    Private Sub inputFromFile()
        Dim c As Integer = 0, r As Integer = 0
        Dim fileReader As String, tempString As String
        Dim charONE As Char
        Dim flag As Boolean = False
        fileReader = My.Computer.FileSystem.ReadAllText(Path)
        Dim custEnum As IEnumerator = fileReader.GetEnumerator()
        custEnum.Reset()
        Dim thisChar As Object
        Cize = 1
        r = 0
        c = 0
        For Each ck As Char In fileReader
            If ck = Chr(13) Then Cize += 1
        Next
        oStart.RowCount = Cize
        oStart.ColumnCount = Cize
        While custEnum.MoveNext()
            thisChar = custEnum.Current()
            charONE = Convert.ToChar(thisChar)
            If (Asc(charONE) = 32) Then
                oStart(r, c).Value = tempString
                r = r + 1
                tempString = ""
            ElseIf (Asc(charONE) = 13) Then
                flag = True
            ElseIf (flag And Asc(charONE) = 10) Then
                oStart(r, c).Value = tempString
                c = c + 1
                tempString = ""
                r = 0
            ElseIf (Asc(charONE) <> 32 Or Asc(charONE) <> 13 Or Asc(charONE) <> 10) Then 'Дописати межі на введення тільки цифр
                tempString = tempString + charONE
            Else
                oStart(r, c).Value = "INCORECT"
            End If
            ' MsgBox(charONE & " ----  " & Asc(charONE))
        End While
        oStart(r, c).Value = tempString
        bSend_data.Enabled = True
    End Sub

    Private Function countTheCharacters(fileReader As String, v As String) As Object
        Throw New NotImplementedException()
    End Function

    Private Sub iSend_data_Click(sender As Object, e As EventArgs) Handles bSend_data.Click

        Dim r As Integer, c As Integer 'Змінні які будуть перебирати рядки і стовпці.

        ReDim MatrixI(Cize, Cize) 'Задання розмірності початкової матриці.

        For r = 0 To Cize - 1 'Перебирання рядків.
            For c = 0 To Cize - 1 'Перебирання стовпців.
                MatrixI(r, c) = oStart(c, r).Value
            Next 'Слідуючий стовпець.
        Next 'Слідуючий рядок.
        Call Receiving()
        Me.Close()
    End Sub

End Class
'Незабути зробити аби стовпці були по ширині тексту в комірці
'Незабути очищати DataGrid
'Виправити два баги із запуском форми

'Пояснення:
'==================================================================================================================
'...R - Random
'...E - Empti (пуста)