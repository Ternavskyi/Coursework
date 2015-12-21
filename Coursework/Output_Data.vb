Public Class Output_Data
    Public wh As Integer, hh As Integer
    Public whc As Integer, hhc As Integer
    Public Cize As Integer

    Private Sub Output_Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wh = General.wg
        hh = General.hg
        whc = General.wgc
        hhc = General.hgc
        Me.Width = wh
        Me.Height = hh
        oStart.Width = wh / 2
        oStart.Height = hh / 2 - 24 + 6
        oStart.Location = New Point(wh - wh / 2 - 12, 12)
        oEnd.Width = wh / 2
        oEnd.Height = hh / 2 - 24 + 6
        oEnd.Location = New Point(wh - wh / 2 - 12, hh - oEnd.Height - 12)
        Cize = Calculation.Cize
        Call Output_Start()
        Call Output_End()
        Call Data_Sort()
        If Calculation.MatrixD(0, 0) = 1 Then
            Chart1.Series("Series1").Points.AddXY("BUBLE", Calculation.MatrixD(0, 1))
            Chart2.Series("Series1").Points.AddXY("BUBLE", Calculation.MatrixD(0, 2))
        End If
        If Calculation.MatrixD(1, 0) = 1 Then
            Chart1.Series("Series1").Points.AddXY("Selection", Calculation.MatrixD(1, 1))
            Chart2.Series("Series1").Points.AddXY("Selection", Calculation.MatrixD(1, 2))
        End If
        If Calculation.MatrixD(2, 0) = 1 Then
            Chart1.Series("Series1").Points.AddXY("Insertion", Calculation.MatrixD(2, 1))
            Chart2.Series("Series1").Points.AddXY("Insertion", Calculation.MatrixD(2, 2))
        End If
        If Calculation.MatrixD(3, 0) = 1 Then
            Chart1.Series("Series1").Points.AddXY("Gnome", Calculation.MatrixD(3, 1))
            Chart2.Series("Series1").Points.AddXY("Gnome", Calculation.MatrixD(3, 2))
        End If
        If Calculation.MatrixD(4, 0) = 1 Then
            Chart1.Series("Series1").Points.AddXY("Shell", Calculation.MatrixD(4, 1))
            Chart2.Series("Series1").Points.AddXY("Shell", Calculation.MatrixD(4, 2))
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

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path As String
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "excel|*.xls|NotPad|*.txt|CSV|*.csv"
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

        oEnd.RowCount = Cize
        oEnd.ColumnCount = Cize
        For r = 0 To Cize - 1
            For c = 0 To Cize - 1
                oEnd(c, r).Value = Calculation.MatrixO(r, c)
            Next
        Next

    End Sub

    Private Sub Data_Sort()

        Dim c As Integer

        For c = 0 To 4

            Select Case c
                Case 0

                    If Calculation.method(c) = 1 Then
                        oNBubble.Text = Calculation.MatrixD(0, 1)
                        oTBubble.Text = Calculation.MatrixD(0, 2)
                    End If

                Case 1

                    If Calculation.method(c) = 1 Then
                        oNSelection.Text = Calculation.MatrixD(1, 1)
                        oTSelection.Text = Calculation.MatrixD(1, 2)
                    End If

                Case 2

                    If Calculation.method(c) = 1 Then
                        oNInsertion.Text = Calculation.MatrixD(2, 1)
                        oTInsertion.Text = Calculation.MatrixD(2, 2)
                    End If

                Case 3

                    If Calculation.method(c) = 1 Then
                        oNGnome.Text = Calculation.MatrixD(3, 1)
                        oTGnome.Text = Calculation.MatrixD(3, 2)
                    End If

                Case 4

                    If Calculation.method(c) = 1 Then
                        oNShell.Text = Calculation.MatrixD(4, 1)
                        oTShell.Text = Calculation.MatrixD(4, 2)
                    End If

            End Select
        Next

    End Sub

End Class