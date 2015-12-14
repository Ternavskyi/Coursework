Module Calculation

    'Глобальні змінні на модуль.
    Public MatrixI(,) As String, MatrixO(,) As String
    Public MatrixR(,) As String, BMatrixR(,) As String
    Public Cize As Integer
    Public GMax As String, GMin As String
    Private Sub Sort() 'Почерговий виклик сабів Call ...().

    End Sub

    'Private Sub Receiving() 'Отримання MatrixI(n,n) із форми Input_Data.
    '...
    'End Sub

    Private Sub Generate() 'Генерування матриці MatrixI(n,n).
        Dim Rnd As New Random
        Dim r As Integer, c As Integer
        Cize = 20
        ReDim MatrixI(Cize, Cize)
        For r = 0 To Cize - 1
            For c = 0 To Cize - 1
                MatrixI(r, c) = Rnd.Next(-500, 501)
            Next
        Next
    End Sub

    Private Sub Rebuild() 'Перебудова матриці із вигляду MatrixI(n,n) у вигляд MatrixR(n,2), де перший стовпець це індекс рядка MatrixI, а другий це найменші елемент рядка MatrixI.

    End Sub

    Private Sub Backup() 'Дублювання MatrixR(n,2) у BMatrixR(n,2).

    End Sub

    Private Sub Output_Start() 'Вивід матриці MatrixI(n,n) на DataGrid.

    End Sub

    Private Sub Output_End() 'Вивід матриці MatrixO...(n,n) на DataGrid.

    End Sub

    '=============================================================================================
    'Саби методів сортування
End Module
