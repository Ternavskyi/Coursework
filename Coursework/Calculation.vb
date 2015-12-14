Module Calculation

    'Глобальні змінні на модуль.
    Public MatrixI(,) As Integer, MatrixO(,) As Integer
    Public MatrixR(,) As Integer, BMatrixR(,) As Integer
    Public Cize As Integer
    Public GMax As Integer, GMin As Integer

    Public Sub Sort() 'Почерговий виклик сабів Call ...().
        Call Generate()
        Call Rebuild()
    End Sub

    'Private Sub Receiving() 'Отримання MatrixI(n,n) із форми Input_Data.
    '...
    'End Sub

    Private Sub Generate() 'Генерування матриці MatrixI(n,n).
        Dim Rnd As New Random 'Задання нового рандому
        Dim r As Integer, c As Integer 'Змінні які будуть перебирати рядки і стовпці
        Cize = 5 'Тимчасовий костиль аби не робити взаємодію із формою
        ReDim MatrixI(Cize, Cize) 'Задання розмірності початкової матриці
        Debug.Print("**********************************************************************************")
        For r = 0 To Cize - 1 'Перебирання рядків
            For c = 0 To Cize - 1 'Перебирання стовпців
                MatrixI(r, c) = Rnd.Next(-100, 101) 'Запис рандомних чисел в межіх [-100,100] у матрицю
                Debug.Write(MatrixI(r, c) & "|")
            Next 'Слідуючий рядок
            Debug.Print("")
        Next 'Слідуючий стовпець
    End Sub

    Private Sub Rebuild() 'Перебудова матриці із вигляду MatrixI(n,n) у вигляд MatrixR(n,2), де перший стовпець це індекс рядка MatrixI, а другий це найменші елемент рядка MatrixI.
        Dim Max As Integer, Min As Integer 'Змінні які запамятовують мінімальниий і максимальний елемент у рядку матриці
        Dim r As Integer, c As Integer 'Змінні які будуть перебирати рядки і стовпці
        ReDim MatrixR(Cize, 2) 'Задання розмірності перебудованої матриці
        Max = MatrixI(0, 0) 'Припущення що в першому рядку максимальний елемент знаходиться у позиції (0,0)
        Min = MatrixI(0, 0) 'Припущення що в першому рядку мінімальний елемент знаходиться у позиції (0,0)
        Debug.Print("**********************************************************************************")
        For r = 0 To Cize - 1 'Перебирання рядків
            For c = 0 To Cize - 1 'Перебирання стовпців
                If Max < MatrixI(r, c) Then 'Перевірка чи більший елемент MatrixI(r, c) за максимальний
                    Max = MatrixI(r, c) 'Присвоєння максимальному елементу значення MatrixI(r, c)
                End If 'Закінчення перевірки
                If Min > MatrixI(r, c) Then 'Перевірка чи менший елемент MatrixI(r, c) за мінімальний
                    Min = MatrixI(r, c) 'Присвоєння мінімальному елементу значення MatrixI(r, c)
                End If 'Закінчення перевірки
            Next 'Слідуючий рядок
            If GMax < Max Then 'Перевірка чи більший елемент Max (максимальний елемент рядка) за GMax (глобальне максимальне всієї матриці)
                GMax = Max 'Присвоєння глобальному максимальному елементу значення максимального рядка
            End If 'Закінчення перевірки
            If GMin > Min Then 'Перевірка чи менший елемент Min (мінімальний елемент рядка) за GMin (глобальне мінімальне всієї матриці)
                GMin = Min 'Присвоєння глобальному мінімальному елементу значення мінімального рядка
            End If 'Закінчення перевірки
            MatrixR(r, 0) = r 'Запис у MatrixR (перебудовану матрицю) у перший стовпець індекс рядка MatrixI (початкової матриці)
            MatrixR(r, 1) = Min 'Запис у MatrixR (перебудовану матрицю) у другий стовпець мінімальний елеммент рядка MatrixI (початкової матриці)
            Max = MatrixI(r + 1, 0) 'Зміщення припущення максимального елемента рядка на слідуючий рядок
            Min = MatrixI(r + 1, 0) 'Зміщення припущення мінімального елемента рядка на слідуючий рядок
            Debug.Print(MatrixR(r, 0) & "|" & MatrixR(r, 1))
        Next 'Слідуючий стовпець
        Debug.Print("**********************************************************************************")
        Debug.Print("GMax=>" & GMax)
        Debug.Print("GMin=>" & GMin)
    End Sub

    Private Sub Backup() 'Дублювання MatrixR(n,2) у BMatrixR(n,2).

    End Sub

    Private Sub Output_Start() 'Вивід матриці MatrixI(n,n) на DataGrid.
        'PMatrixI.RowCount = Cize
        'PMatrixI.ColumnCount = Cize
        'For r = 0 To Cize - 1
        'For c = 0 To Cize - 1
        'PMatrixI(c, r).Value = MatrixI(r, c)
        'Next
        'Next
    End Sub

    Private Sub Output_End() 'Вивід матриці MatrixO...(n,n) на DataGrid.
        'PMatrixO.RowCount = Cize
        'PMatrixO.ColumnCount = Cize
        'For r = 0 To Cize - 1
        'For c = 0 To Cize - 1
        'PMatrixO(c, r).Value = MatrixO(r, c)
        'Next
        'Next
    End Sub

    '=============================================================================================
    'Саби методів сортування
End Module
