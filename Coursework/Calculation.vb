﻿Module Calculation

    'Глобальні змінні на модуль.
    Public MatrixI(,) As Integer, MatrixO(,) As Integer
    Public MatrixR(,) As Integer, BMatrixR(,) As Integer
    Public Cize As Integer

    Public Sub Sort() 'Почерговий виклик сабів Call ...().
        Call Generate()
        Call Rebuild()
        Call Backup()
        Call Selection()
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
        Dim Min As Integer 'Змінні які запамятовують мінімальниий елемент у рядку матриці.
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

    Private Function Comparison(PIndexRow, NIndexRow) As Boolean 'Comparison (перевірка) порівняння двох елементів BMatrixR(r, 1) і BMatrixR(r+1, 1).
        Dim P = BMatrixR(PIndexRow, 1) 'Previous (Попередній) елемент матриці BMatrixR(r, 1).
        Dim N = BMatrixR(NIndexRow, 1) 'Next (Слідуючий) елемент матриці BMatrixR(r+1, 1).
        Dim Answer = False 'Присвоюємо Answer (відповідь) вочаткове значення False.
        If P > N Then 'Порівняння двох елементів BMatrixR(r, 1) і BMatrixR(r+1, 1).
            Answer = True 'При виконання умови Answer (відповідь) змінює своє значення на True.
        End If 'Закінчення перевірки.
        ' провірка чи потрібна візуалізація з форми.
        ' Якщо потрібна то реалізовувати візуалізації  (виконувати її в іншому сабі). У відповідності від answer = True чи фолс зробити інший колір рядка. Виділити мінімальний елемент в кожному рядку іншим кольором.
        Return Answer 'Повертає значенння Answer (відповідь) у саб метода сортування.
    End Function

    Private Function Transposition(PIndexRow, NIndexRow) As Boolean 'Transposition (перестановка) двох елементів місцями BMatrixR(r, 1) і BMatrixR(r+1, 1).
        Dim IndexAgent As Integer 'IndexAgent, Index (індекс) Agent (просередник) зміння яка запамятовує значення BMatrixR(r+1, 0).
        Dim ValueAgent As Integer 'IndexAgent, Value (значення) Agent (просередник) зміння яка запамятовує значення BMatrixR(r+1, 1).
        IndexAgent = BMatrixR(NIndexRow, 0) 'Надаємо IndexAgent значення BMatrixR(r+1, 0).
        ValueAgent = BMatrixR(NIndexRow, 1) 'Надаємо ValueAgent значення BMatrixR(r+1, 1).
        BMatrixR(NIndexRow, 0) = BMatrixR(PIndexRow, 0) 'Присвоєння комірці BMatrixR(r+1, 0) значення комірки BMatrixR(r, 0).
        BMatrixR(NIndexRow, 1) = BMatrixR(PIndexRow, 1) 'Присвоєння комірці BMatrixR(r+1, 1) значення комірки BMatrixR(r, 1).
        BMatrixR(PIndexRow, 0) = IndexAgent 'Присвоєння комірці BMatrixR(r, 0) значення комірки BMatrixR(r+1, 0).
        BMatrixR(PIndexRow, 1) = ValueAgent 'Присвоєння комірці BMatrixR(r, 1) значення комірки BMatrixR(r+1, 1).
    End Function

    'Саби методів сортування.
    '==================================================================================================================

    Private Sub Bubble() 'Метод сортування бульбашкою.
        Dim r As Integer 'Змінна яка буде перебирати рядки.
        Dim check As Integer 'check (перевірка) зміна для перевірки чи проводився захід у функцію Transposition за весь цикл проходу по всіх рядках матриці BMatrixR.
        Debug.Print("**********************************************************************************")
        Do 'Заходимо в цикл.
            check = 0 'Присвоюємо значення яке повідомляє циклу що в фунцію Transposition цикл не заходив.
            For r = 0 To Cize - 2 'Перебирання стовпців.
                If Comparison(r, r + 1) Then 'Звернення до функції Comparison для порівняння значень.
                    Transposition(r, r + 1) 'Звертаємося до функції Transposition аби фона поміняла місцями значенння.
                    check = 1 'Присвоюємо значення яке повідомляє циклу що в фунцію Transposition цикл заходив.
                    ' кількість перестановок.
                End If 'Закінчення перевірки.
            Next 'Слідуючий рядок.
        Loop Until check = 0 'Робимо перевірку уммови оскільки в нас цикл пряцює доки check не дорівнює нулю.
        For r = 0 To Cize - 1
            Debug.Print(BMatrixR(r, 0) & "|" & BMatrixR(r, 1))
        Next
    End Sub

    Private Sub Selection() 'Метод сортування вибором.
        Dim r1 As Integer, r2 As Integer 'Змінна яка буде перебирати рядки.
        Dim rMin As Integer 'Змінні які запамятовують мінімальниий елемент у стовпці матриці.
        Debug.Print("**********************************************************************************")
        For r1 = 0 To Cize - 2 'Перебирання стовпців починаючи з нульового.
            rMin = r1 'Припускаємо що мінімальний елемент знаходиться на r1 рядку
            For r2 = r1 + 1 To Cize - 1 'Перебирання стовпців починаючи з першого.
                If Comparison(rMin, r2) Then 'Звернення до функції Comparison для порівняння значень.
                    rMin = r2 'Прив виконання умови припускаємо що мінімальний елемент знаходиться у r2 рядку.
                End If 'Закінчення перевірки.
            Next 'Слідуючий рядок r2.
            Transposition(r1, rMin) 'Звертаємося до функції Transposition аби фона поміняла місцями значенння.
        Next 'Слідуючий рядок r1.
        For r = 0 To Cize - 1
            Debug.Print(BMatrixR(r, 0) & "|" & BMatrixR(r, 1))
        Next
    End Sub

End Module

'Пояснення:
'==================================================================================================================
'P... - Previous (Попередній)
'N... - Next (Слідуючий)
'Answer - Відповідь
'Value - Значення
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
'check - Перевірка