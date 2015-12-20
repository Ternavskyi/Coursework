Public Class Input_Data
    Public wh As Integer, hh As Integer
    Public MatrixI(,) As Integer
    Public Cize As Integer

    Private Sub Input_Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wh = General.wg
        hh = General.hg
        Me.Width = wh
        Me.Height = hh
        oStart.Location = New Point(wh - wh / 2 - 240, 12)
        oStart.Width = wh / 1.5
        oStart.Height = hh - 24
    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub iDimension_matrix_ValueChanged(sender As Object, e As EventArgs) Handles iDimension_matrix.ValueChanged
        Cize = iDimension_matrix.Value
    End Sub

    Private Sub iInput_Method_SelectedIndexChanged(sender As Object, e As EventArgs) Handles iInput_Method.SelectedIndexChanged
        If iInput_Method.Text = "Open matrix file" Then
            Call Open()
        Else
            Call Generate()
        End If
    End Sub

    Private Sub Open()
        iDimension_matrix.Visible = False
        iDimension_matrix.Value = 2
        iView_Generation.Visible = False
        'Як стерти значення iView_Generation.Visible????????????
        bOpen_matrix_file.Visible = True
        iOpen_matrix_file.Visible = True
        '==================================================================================================================
        Dim Rnd As New Random 'Задання нового рандому.
        Dim r As Integer, c As Integer 'Змінні які будуть перебирати рядки і стовпці.
        ReDim MatrixI(Cize, Cize) 'Задання розмірності початкової матриці.
        Debug.Print("**********************************************************************************")
        For r = 0 To Cize - 1 'Перебирання рядків.
            For c = 0 To Cize - 1 'Перебирання стовпців.
                MatrixI(r, c) = Rnd.Next(-100, 201) 'Запис рандомних чисел в межіх [-100,100] у матрицю.
                Debug.Write(MatrixI(r, c) & "|")
            Next 'Слідуючий стовпець.
            Debug.Print("")
        Next 'Слідуючий рядок.
    End Sub

    Private Sub Generate()
        iDimension_matrix.Visible = True
        iView_Generation.Visible = True
        bOpen_matrix_file.Visible = False
        iOpen_matrix_file.Visible = False
        iOpen_matrix_file.Text = ""
        '==================================================================================================================

    End Sub
End Class