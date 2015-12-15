Module Calculation

    'Глобальні змінні на модуль.
    Public MatrixI(,) As Integer, MatrixO(,) As Integer
    Public MatrixR(,) As Integer, BMatrixR(,) As Integer
    Public Cize As Integer

    Public Sub Sort() 'Почерговий виклик сабів Call ...().
        Call Generate()
        Call Rebuild()
        Call Backup()
        Call Bubble()
    End Sub

    'Саби які відповідають за генерування, перебудову і дублювання матриці.
    '==================================================================================================================

    'Private Sub Receiving() 'Отримання MatrixI(n,n) із форми Input_Data.
    '...
    'End Sub

    Private Sub Generate() 'Генерування матриці MatrixI(n,n).
        Dim Rnd As New Random 'Задання нового рандому.
        Dim r As Integer, c As Integer 'Змінні які будуть перебирати рядки і стовпці.
        Cize = 5 'Тимчасовий костиль аби не робити взаємодію із формою.
        ReDim MatrixI(Cize, Cize) 'Задання розмірності початкової матриці.
        Debug.Print("**********************************************************************************")
        For r = 0 To Cize - 1 'Перебирання рядків.
            For c = 0 To Cize - 1 'Перебирання стовпців.
                MatrixI(r, c) = Rnd.Next(-100, 101) 'Запис рандомних чисел в межіх [-100,100] у матрицю.
                Debug.Write(MatrixI(r, c) & "|")
            Next 'Слідуючий стовпець.
            Debug.Print("")
        Next 'Слідуючий рядок.
    End Sub

    Private Sub Rebuild() 'Перебудова матриці із вигляду MatrixI(n,n) у вигляд MatrixR(n,2), де перший стовпець це індекс рядка MatrixI, а другий це найменші елемент рядка MatrixI.
        Dim Min As Integer 'Змінні які запамятовують мінімальниий і максимальний елемент у рядку матриці.
        Dim r As Integer, c As Integer 'Змінні які будуть перебирати рядки і стовпці.
        ReDim MatrixR(Cize, 2) 'Задання розмірності перебудованої матриці.
        Min = MatrixI(0, 0) 'Припущення що в першому рядку мінімальний елемент знаходиться у позиції (0,0).
        Debug.Print("**********************************************************************************")
        For r = 0 To Cize - 1 'Перебирання рядків.
            For c = 0 To Cize - 1 'Перебирання стовпців.
                If Min > MatrixI(r, c) Then 'Перевірка чи менший елемент MatrixI(r, c) за мінімальний.
                    Min = MatrixI(r, c) 'Присвоєння мінімальному елементу значення MatrixI(r, c).
                End If 'Закінчення перевірки.
            Next 'Слідуючий стовпець.
            MatrixR(r, 0) = r 'Запис у MatrixR (перебудовану матрицю) у перший стовпець індекс рядка MatrixI (початкової матриці).
            MatrixR(r, 1) = Min 'Запис у MatrixR (перебудовану матрицю) у другий стовпець мінімальний елеммент рядка MatrixI (початкової матриці).
            Min = MatrixI(r + 1, 0) 'Зміщення припущення мінімального елемента рядка на слідуючий рядок.
            Debug.Print(MatrixR(r, 0) & "|" & MatrixR(r, 1))
        Next 'Слідуючий рядок.
        Debug.Print("**********************************************************************************")
    End Sub

    Private Sub Backup() 'Дублювання MatrixR(n,2) у BMatrixR(n,2).
        Dim r As Integer, c As Integer 'Змінні які будуть перебирати рядки і стовпці.
        ReDim BMatrixR(Cize, 2) 'Задання розмірності дубльованої перебудованої матриці.
        For r = 0 To Cize - 1 'Перебирання рядків.
            For c = 0 To 1 'Перебирання стовпців.
                BMatrixR(r, c) = MatrixR(r, c) 'Дубоювання значення із MatrixR(r, c) в BMatrixR(r, c).
            Next 'Слідуючий стовпець.
        Next 'Слідуючий рядок.
    End Sub

    'Саби які відповідають за вивід даних початкової і кінцевої матриці.
    '==================================================================================================================

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

    'Функція порівняння двох елементів, та функція перестановки порівнюваних елементів.
    '==================================================================================================================

    Private Function Comparison(PIndexRow, NIndexRow) As Boolean
        Dim P = BMatrixR(PIndexRow, 1)
        Dim N = BMatrixR(NIndexRow, 1)
        Dim Answer = False
        If P > N Then
            Answer = True
        End If
        ' провірка чи потрібна візуалізація з форми
        ' Якщо потрібна то реалізовувати візуалізації  (виконувати її в іншому сабі). У відповідності від answer = True чи фолс зробити інший колір рядка. Виділити мінімальний елемент в кожному рядку іншим кольором.
        Return Answer
    End Function

    Private Function Transposition(PIndexRow, NIndexRow) As Boolean
        Dim PAgent As Integer
        Dim NAgent As Integer
        PAgent = BMatrixR(NIndexRow, 1)
        NAgent = BMatrixR(NIndexRow, 0)
        BMatrixR(NIndexRow, 1) = BMatrixR(PIndexRow, 1)
        BMatrixR(NIndexRow, 0) = BMatrixR(PIndexRow, 0)
        BMatrixR(PIndexRow, 1) = PAgent
        BMatrixR(PIndexRow, 0) = NAgent
    End Function
    'Саби методів сортування.
    '==================================================================================================================

    Private Sub Bubble()
        Dim r As Integer
        Dim check As Integer
        Debug.Print("**********************************************************************************")
        Do
            check = 0
            For r = 0 To Cize - 2
                If Comparison(r, r + 1) Then
                    Transposition(r, r + 1)
                    check = 1
                    ' кількість перестановок
                End If
            Next
        Loop Until check = 0
        For r = 0 To Cize - 1
            Debug.Print(BMatrixR(r, 0) & "|" & BMatrixR(r, 1))
        Next
    End Sub
End Module

'Пояснення:
'==================================================================================================================
'P... - Previous (Попередній)
'N... - Next (Слідуючий)
'...Agent... - Посередник
'...Index... - Індекс
'B... - Backup (Резервний)
'...R - Rebuild (Передудова)
'...I - Input (Вхідні дані)
'...O - Output (Вихідні дані)
'G... - Global (Глобальні константи)
'r - Row (Рядок)
'с - Column (Стовпець)
'Generate - Генерування
'Comparison - Перевірка
'Transposition - Перестановка