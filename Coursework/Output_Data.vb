Public Class Output_Data
    Public wh As Integer, hh As Integer
    Public Cize As Integer
    Public HMatrix(,) As Single

    Private Sub Output_Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wh = General.wg
        hh = General.hg
        Me.Width = wh
        Me.Height = hh
        Me.Location = New Point(Home.Location.X, Home.Location.Y)
        oStart.Width = (wh / 3) * 2
        oStart.Height = hh / 2 - 24 + 6
        oStart.Location = New Point(wh - wh / 2 - 12, 12)
        oEnd.Width = (wh / 3) * 2
        oEnd.Height = hh / 2 - 24 + 6
        oEnd.Location = New Point(wh - wh / 2 - 12, hh - oEnd.Height - 12)
        Cize = Calculation.Cize
        Call Output_Start()
        Call Output_End()
        Call Data_Sort()
        If Calculation.Matrix_Sort_Method_Calculation(0, 1) = 1 Then
            Chart1.Series("Series1").Points.AddXY("Buble= " & Calculation.MatrixD(0, 1), Calculation.MatrixD(0, 1))
            Chart2.Series("Series1").Points.AddXY("Buble= " & Calculation.MatrixD(0, 2), Calculation.MatrixD(0, 2))
        End If
        If Calculation.Matrix_Sort_Method_Calculation(1, 1) = 1 Then
            Chart1.Series("Series1").Points.AddXY("Selection= " & Calculation.MatrixD(1, 1), Calculation.MatrixD(1, 1))
            Chart2.Series("Series1").Points.AddXY("Selection= " & Calculation.MatrixD(1, 2), Calculation.MatrixD(1, 2))
        End If
        If Calculation.Matrix_Sort_Method_Calculation(2, 1) = 1 Then
            Chart1.Series("Series1").Points.AddXY("Insertion= " & Calculation.MatrixD(2, 1), Calculation.MatrixD(2, 1))
            Chart2.Series("Series1").Points.AddXY("Insertion= " & Calculation.MatrixD(2, 2), Calculation.MatrixD(2, 2))
        End If
        If Calculation.Matrix_Sort_Method_Calculation(3, 1) = 1 Then
            Chart1.Series("Series1").Points.AddXY("Gnome= " & Calculation.MatrixD(3, 1), Calculation.MatrixD(3, 1))
            Chart2.Series("Series1").Points.AddXY("Gnome= " & Calculation.MatrixD(3, 2), Calculation.MatrixD(3, 2))
        End If
        If Calculation.Matrix_Sort_Method_Calculation(4, 1) = 1 Then
            Chart1.Series("Series1").Points.AddXY("Shell= " & Calculation.MatrixD(4, 1), Calculation.MatrixD(4, 1))
            Chart2.Series("Series1").Points.AddXY("Shell= " & Calculation.MatrixD(4, 2), Calculation.MatrixD(4, 2))
        End If
    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub Output_Start() 'Вивід матриці MatrixI(n,n) на DataGrid.

        Dim r As Integer, c As Integer 'Змінні які будуть перебирати рядки і стовпці.

        oStart.RowCount = Cize
        oStart.ColumnCount = Cize
        For r = 0 To Cize - 1
            For c = 0 To Cize - 1
                oStart(c, r).Value = Calculation.MatrixI(r, c)
            Next
        Next

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path As String
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Excel Files (*.xls)|*.xls|Text Files (*.txt)|*.txt"
        saveFileDialog1.Title = "Save an File"
        saveFileDialog1.ShowDialog()
        path = saveFileDialog1.FileName
        Dim StrExport As String = ""

        StrExport &= Environment.NewLine
        For Each R As DataGridViewRow In oEnd.Rows
            For Each C As DataGridViewCell In R.Cells
                If Not C.Value Is Nothing Then
                    StrExport &= Chr(09) & C.Value.ToString
                Else
                    StrExport &= Chr(09)
                End If
            Next
            StrExport = StrExport.Substring(0, StrExport.Length - 1)
            StrExport &= Environment.NewLine
        Next
        If saveFileDialog1.FileName <> "" Then
            Select Case saveFileDialog1.FilterIndex
                Case 1
                    Dim tw As IO.TextWriter = New IO.StreamWriter(path)
                    tw.Write(StrExport)
                    tw.Close()
                Case 2
                    Dim tw As IO.TextWriter = New IO.StreamWriter(path)
                    tw.Write(StrExport)
                    tw.Close()
                Case 3
                    Dim tw As IO.TextWriter = New IO.StreamWriter(path)
                    tw.Write(StrExport)
                    tw.Close()
            End Select
        End If
    End Sub

    Private Sub Output_End() 'Вивід матриці MatrixO...(n,n) на DataGrid.

        Dim r As Integer, c As Integer 'Змінні які будуть перебирати рядки і стовпці.
        Dim min As Integer
        Dim minr As Integer, minc As Integer

        oEnd.RowCount = Cize
        oEnd.ColumnCount = Cize
        For r = 0 To Cize - 1
            For c = 0 To Cize - 1
                oEnd(c, r).Value = Calculation.MatrixO(r, c)
            Next
        Next
        If Calculation.Index_Max_Min = 0 Then
            min = oEnd(0, 0).Value
            For r = 0 To Cize - 1
                For c = 0 To Cize - 1
                    If min > oEnd(c, r).Value Then
                        min = oEnd(c, r).Value
                        minr = r
                        minc = c
                    End If
                Next
                oEnd(minc, minr).Style.BackColor = Color.Yellow
                If r <> Cize - 1 Then
                    min = oEnd(0, r + 1).Value
                End If
            Next
        ElseIf Calculation.Index_Max_Min = 1 Then
            min = oEnd(0, 0).Value
            For r = 0 To Cize - 1
                For c = 0 To Cize - 1
                    If min <= oEnd(c, r).Value Then
                        min = oEnd(c, r).Value
                        minr = r
                        minc = c
                    End If
                Next
                oEnd(minc, minr).Style.BackColor = Color.Yellow
                If r <> Cize - 1 Then
                    min = oEnd(0, r + 1).Value
                End If
            Next
        End If

    End Sub

    Private Sub Data_Sort()

        Dim Work_Sort_Method As Integer

        For Work_Sort_Method = 0 To 4

            Select Case Work_Sort_Method
                Case 0

                    If Calculation.Matrix_Sort_Method_Calculation(Work_Sort_Method, 1) = 1 Then
                        oNBubble.Text = Calculation.MatrixD(0, 1)
                        oTBubble.Text = Calculation.MatrixD(0, 2)
                    End If

                Case 1

                    If Calculation.Matrix_Sort_Method_Calculation(Work_Sort_Method, 1) = 1 Then
                        oNSelection.Text = Calculation.MatrixD(1, 1)
                        oTSelection.Text = Calculation.MatrixD(1, 2)
                    End If

                Case 2

                    If Calculation.Matrix_Sort_Method_Calculation(Work_Sort_Method, 1) = 1 Then
                        oNInsertion.Text = Calculation.MatrixD(2, 1)
                        oTInsertion.Text = Calculation.MatrixD(2, 2)
                    End If

                Case 3

                    If Calculation.Matrix_Sort_Method_Calculation(Work_Sort_Method, 1) = 1 Then
                        oNGnome.Text = Calculation.MatrixD(3, 1)
                        oTGnome.Text = Calculation.MatrixD(3, 2)
                    End If

                Case 4

                    If Calculation.Matrix_Sort_Method_Calculation(Work_Sort_Method, 1) = 1 Then
                        oNShell.Text = Calculation.MatrixD(4, 1)
                        oTShell.Text = Calculation.MatrixD(4, 2)
                    End If

            End Select
        Next

    End Sub
End Class