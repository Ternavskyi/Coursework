Public Class Input_Data

    Public MatrixI(,) As Integer
    Public wh As Integer, hh As Integer
    Public Cize As Integer
    Public Index_Creation As Integer = 2, Index_Creation_2 As Integer = 2
    Public Path As String

    Private Sub Input_Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        wh = General.wg
        hh = General.hg
        Me.Width = wh
        Me.Height = hh
        Me.Location = New Point(Home.Location.X, Home.Location.Y)
        oStart.Location = New Point(iInput_Method.Location.X + iInput_Method.Width + 40, 12)
        oStart.Width = wh - oStart.Location.X - 20
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
        Label5.Location = New Point(iInput_Method.Location.X, iInput_Method.Location.Y + iInput_Method.Height + 10)
        Label6.Location = New Point(iInput_Method.Location.X, Label5.Location.Y + Label5.Height)
        Label7.Location = New Point(iInput_Method.Location.X, Label6.Location.Y + Label6.Height)
        bCancel.Location = New Point(iInput_Method.Location.X, Label7.Location.Y + Label7.Height + 10)
        bOk.Location = New Point(iInput_Method.Location.X + iInput_Method.Width - bOk.Width, Label7.Location.Y + Label7.Height + 10)
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

        Select Case iInput_Method.SelectedItem
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
                MsgBox("File not found")
            Case 1
                If Index_Creation_2 = 0 Then
                    Call GenerateR()
                Else
                    Call GenerateE()
                End If
            Case 2
                MsgBox("You choose a method for creating matrix", 16, "Error")
            Case 3
                Call Read_matrix_file()
        End Select

    End Sub

    Private Sub Open_Visual()

        iDimension_matrix.Visible = False
        iDimension_matrix.Value = 2
        iView_Generation.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        NumericUpDown1.Visible = False
        NumericUpDown2.Visible = False
        iView_Generation.SelectedIndex = -1
        bOpen_matrix_file.Visible = True
        iOpen_matrix_file.Visible = True
        Label2.Visible = True
        '****************************************************************************************************
        bOpen_matrix_file.Width = iInput_Method.Width / 4
        '****************************************************************************************************
        iOpen_matrix_file.Width = (iInput_Method.Width / 4) * 3
        '****************************************************************************************************
        Label2.Location = New Point(iInput_Method.Location.X, iInput_Method.Location.Y + iInput_Method.Height + 10)
        bOpen_matrix_file.Location = New Point(iInput_Method.Location.X, Label2.Location.Y + Label2.Height + 10)
        iOpen_matrix_file.Location = New Point(iInput_Method.Location.X + bOpen_matrix_file.Width, Label2.Location.Y + Label2.Height + 11)
        Label5.Location = New Point(bOpen_matrix_file.Location.X, bOpen_matrix_file.Location.Y + bOpen_matrix_file.Height + 10)
        Label6.Location = New Point(bOpen_matrix_file.Location.X, Label5.Location.Y + Label5.Height + 10)
        Label7.Location = New Point(bOpen_matrix_file.Location.X, Label6.Location.Y + Label6.Height + 10)
        bCancel.Location = New Point(iInput_Method.Location.X, Label7.Location.Y + Label7.Height + 10)
        bOk.Location = New Point(iInput_Method.Location.X + iInput_Method.Width - bOk.Width, Label7.Location.Y + Label7.Height + 10)
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
        Label2.Visible = False
        Label3.Visible = True
        Label4.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        NumericUpDown1.Visible = True
        NumericUpDown2.Visible = True
        iOpen_matrix_file.Text = ""
        '****************************************************************************************************
        iDimension_matrix.Width = iInput_Method.Width
        '****************************************************************************************************
        iView_Generation.Width = iInput_Method.Width
        '****************************************************************************************************
        Label3.Location = New Point(iInput_Method.Location.X, iInput_Method.Location.Y + iInput_Method.Height + 10)
        iDimension_matrix.Location = New Point(iInput_Method.Location.X, Label3.Location.Y + Label3.Height + 10)
        Label4.Location = New Point(iInput_Method.Location.X, iDimension_matrix.Location.Y + iDimension_matrix.Height + 10)
        iView_Generation.Location = New Point(iInput_Method.Location.X, Label4.Location.Y + Label4.Height + 10)
        Label8.Location = New Point(iInput_Method.Location.X, iView_Generation.Location.Y + iView_Generation.Height + 10)
        Label9.Location = New Point(iInput_Method.Location.X, Label8.Location.Y + Label8.Height + 10)
        Label10.Location = New Point(iInput_Method.Location.X + iInput_Method.Width - Label10.Width, Label8.Location.Y + Label8.Height + 10)
        NumericUpDown1.Location = New Point(iInput_Method.Location.X, Label9.Location.Y + Label9.Height + 10)
        NumericUpDown2.Location = New Point(iInput_Method.Location.X + iInput_Method.Width - NumericUpDown2.Width, Label10.Location.Y + Label10.Height + 10)
        Label5.Location = New Point(iView_Generation.Location.X, NumericUpDown1.Location.Y + NumericUpDown1.Height + 10)
        Label6.Location = New Point(bOpen_matrix_file.Location.X, Label5.Location.Y + Label5.Height + 10)
        Label7.Location = New Point(bOpen_matrix_file.Location.X, Label6.Location.Y + Label6.Height + 10)
        bCancel.Location = New Point(iInput_Method.Location.X, Label7.Location.Y + Label7.Height + 10)
        bOk.Location = New Point(iInput_Method.Location.X + iInput_Method.Width - bOk.Width, Label7.Location.Y + Label7.Height + 10)
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

        For r = 0 To Cize - 1 'Перебирання рядків.
            For c = 0 To Cize - 1 'Перебирання стовпців.
                oStart(c, r).Value = Rnd.Next(NumericUpDown1.Value, NumericUpDown2.Value + 1) 'Запис рандомних чисел в межіх [-100,100] у матрицю.
                bSend_data.Enabled = True
            Next 'Слідуючий стовпець.
        Next 'Слідуючий рядок.
        bSend_data.Enabled = True

    End Sub

    Private Sub GenerateE()

        Dim r As Integer, c As Integer 'Змінні які будуть перебирати рядки і стовпці.

        oStart.RowCount = Cize
        oStart.ColumnCount = Cize

        For r = 0 To Cize - 1 'Перебирання рядків.
            For c = 0 To Cize - 1 'Перебирання стовпців.
                oStart(c, r).Value = 0
                bSend_data.Enabled = True
            Next 'Слідуючий стовпець.
        Next 'Слідуючий рядок.
        bSend_data.Enabled = True

    End Sub

    Private Sub iOpen_matrix_file_TextChanged(sender As Object, e As EventArgs)
        Path = iOpen_matrix_file.Text
        If Path <> "" Then
            bOk.Enabled = True
            Index_Creation = 3
        End If
    End Sub

    Private Sub Read_matrix_file()
        Dim c As Integer = 0, r As Integer = 0
        Dim fileReader As String, tempString As String
        Dim charONE As Char
        Dim flag As Boolean = False
        Try
            fileReader = My.Computer.FileSystem.ReadAllText(Path)
        Catch
            MsgBox("File not found")
            Exit Sub
        End Try
        Dim custEnum As IEnumerator = fileReader.GetEnumerator()
        Dim Cize1 As Integer, Cize2 As Integer
        custEnum.Reset()
        Dim thisChar As Object
        Cize = 1
        r = 0
        c = 0
        For Each ck As Char In fileReader
            If ck = Chr(13) Then Cize1 += 1
        Next
        For Each ck2 As Char In fileReader
            If ck2 = Chr(9) Then Cize2 += 1
            If ck2 = Chr(13) Then Exit For
        Next
        Cize1 += 1
        Cize2 += 1
        If Cize2 > Cize1 Then
            Cize = Cize1
            MsgBox("Because the matrix is not square, the number of columns is reduced to the number of lines is: " & Cize & "x" & Cize & " and not " & Cize1 & "x" & Cize2, 48, "Matrix is not square")
        ElseIf Cize2 < Cize1 Then
            Cize = Cize2
            MsgBox("Because the matrix is not square, the number of lines will be reduced to the number of columns is: " & Cize & "x" & Cize & " and not " & Cize1 & "x" & Cize2, 48, "Matrix is not square")
        ElseIf Cize2 = Cize1 Then
            Cize = Cize2
        End If
        oStart.RowCount = Cize
        oStart.ColumnCount = Cize
        While custEnum.MoveNext()
            thisChar = custEnum.Current()
            charONE = Convert.ToChar(thisChar)
            If (Asc(charONE) = 9) Then
                Try
                    oStart(r, c).Value = tempString
                    r = r + 1
                    tempString = ""
                Catch
                    GoTo Obh1
                End Try
Obh1:
            ElseIf (Asc(charONE) = 13) Then

                Try
                    flag = True
                Catch
                    GoTo Obh2
                End Try
Obh2:
            ElseIf (flag And Asc(charONE) = 10) Then
                Try
                    oStart(r, c).Value = tempString
                    c = c + 1
                    tempString = ""
                    r = 0
                Catch
                    GoTo Obh3
                End Try
Obh3:
            ElseIf (Asc(charONE) <> 32 Or Asc(charONE) <> 13 Or Asc(charONE) <> 10) Then 'Дописати межі на введення тільки цифр

                Try
                    tempString = tempString + charONE
                Catch
                    GoTo Obh4
                End Try
Obh4:
            Else

                Try
                    oStart(r, c).Value = "INCORECT"
                Catch
                    GoTo Obh5
                End Try
            End If
Obh5:
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
        Home.bSorting_Setting.Enabled = True
        Home.bSorting_Setting.BackColor = Color.Aqua
        Home.pArrow.Location = New Point(Home.bSorting_Setting.Location.X + Home.bSorting_Setting.Width / 2 - Home.pArrow.Width / 2, Home.bSorting_Setting.Location.Y - Home.pArrow.Height - 20)
        General.SortingSetingToolStripMenuItem.Enabled = True
        General.SortingSetingToolStripMenuItem.BackColor = Color.Aqua
        Me.Close()
    End Sub

    Private Sub bOpen_matrix_file_Click(sender As Object, e As EventArgs) Handles bOpen_matrix_file.Click
        Open_matrix_file.InitialDirectory = "C:\"
        Open_matrix_file.Title = "Coursework"
        Open_matrix_file.Filter = "Text Files (*.txt)|*.txt"
        Open_matrix_file.FilterIndex = 1
        If Open_matrix_file.ShowDialog = DialogResult.OK Then
            bOk.Enabled = True
            Path = Open_matrix_file.FileName
            Index_Creation = 3
        Else
            Path = ""
        End If
        iOpen_matrix_file.Text = Path
    End Sub
End Class
'Незабути зробити аби стовпці були по ширині тексту в комірці
'Незабути очищати DataGrid
'Виправити два баги із запуском форми

'Пояснення:
'==================================================================================================================
'...R - Random
'...E - Empti (пуста)