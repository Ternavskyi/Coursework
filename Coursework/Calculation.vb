Module Calculation

    'Глобальні змінні на модуль.
    Public MatrixI(,) As Integer, MatrixO(,) As Integer
    Public MatrixR(,) As Integer, BMatrixR(,) As Integer
    Public MatrixD(5, 3) As Single
    Public Cize As Integer
    Public isVisual As Boolean
    Public sleepTime As Integer
    Public number As Integer
    Public time As New Stopwatch() 'Оголошення таймера.
    Public Matrix_Sort_Method_Calculation(5, 2) As Integer
    Public Work_Sort_Method As Integer
    Public Index_Max_Min As Integer

    Public Bubble_Matrix(100, 2) As Single
    Public Selection_Matrix(100, 2) As Single
    Public Insertion_Matrix(100, 2) As Single
    Public Gnome_Matrix(100, 2) As Single
    Public Shell_Matrix(100, 2) As Single

    Public Sub Sort() 'Почерговий виклик сабів Call ...().
        If Index_Max_Min = 0 Then
            Call Rebuild()
        ElseIf Index_Max_Min = 1 Then
            Call Rebuild2()
        End If


        For Work_Sort_Method = 0 To 4

            Select Case Work_Sort_Method
                Case 0

                    If Matrix_Sort_Method_Calculation(Work_Sort_Method, 1) = 1 Then
                        Call Backup()
                        Call Bubble()
                    End If

                Case 1

                    If Matrix_Sort_Method_Calculation(Work_Sort_Method, 1) = 1 Then
                        Call Backup()
                        Call Selection()
                    End If

                Case 2

                    If Matrix_Sort_Method_Calculation(Work_Sort_Method, 1) = 1 Then
                        Call Backup()
                        Call Insertion()
                    End If

                Case 3

                    If Matrix_Sort_Method_Calculation(Work_Sort_Method, 1) = 1 Then
                        Call Backup()
                        Call Gnome()
                    End If

                Case 4

                    If Matrix_Sort_Method_Calculation(Work_Sort_Method, 1) = 1 Then
                        Call Backup()
                        Call Shell()
                    End If

            End Select
        Next
        Call Assembling()

    End Sub

    Public Sub Sort_Method_Calculation()
        Dim r As Integer
        For r = 0 To 4
            Matrix_Sort_Method_Calculation(r, 0) = Sorting_Settings.Matrix_Sort_Method(r, 0)
            Matrix_Sort_Method_Calculation(r, 1) = Sorting_Settings.Matrix_Sort_Method(r, 1)
        Next
    End Sub

    'Саби які відповідають за генерування, перебудову і дублювання матриці.
    '==================================================================================================================

    Public Sub Receiving() 'Отримання MatrixI(n,n) із форми Input_Data.

        Dim r As Integer, c As Integer 'Змінні які будуть перебирати рядки і стовпці.

        Cize = Input_Data.Cize
        ReDim MatrixI(Cize, Cize) 'Задання розмірності початкової матриці.

        For r = 0 To Cize - 1 'Перебирання рядків.
            For c = 0 To Cize - 1 'Перебирання стовпців.
                MatrixI(r, c) = Input_Data.MatrixI(r, c)
            Next 'Слідуючий стовпець.
        Next 'Слідуючий рядок.

    End Sub

    Private Sub Rebuild() 'Перебудова матриці із вигляду MatrixI(n,n) у вигляд MatrixR(n,2), де перший стовпець це індекс рядка MatrixI, а другий це найменші елемент рядка MatrixI.

        Dim Min As Integer 'Змінні які запамятовують мінімальниий елемент у рядку матриці.
        Dim r As Integer, c As Integer 'Змінні які будуть перебирати рядки і стовпці.

        ReDim MatrixR(Cize, 2) 'Задання розмірності перебудованої матриці.
        Min = MatrixI(0, 0) 'Припущення що в першому рядку мінімальний елемент знаходиться у позиції (0,0).

        For r = 0 To Cize - 1 'Перебирання рядків.
            For c = 0 To Cize - 1 'Перебирання стовпців.
                If Min > MatrixI(r, c) Then 'Перевірка чи менший елемент MatrixI(r, c) за мінімальний.
                    Min = MatrixI(r, c) 'Присвоєння мінімальному елементу значення MatrixI(r, c).
                End If 'Закінчення перевірки.
            Next 'Слідуючий стовпець.
            MatrixR(r, 0) = r 'Запис у MatrixR (перебудовану матрицю) у перший стовпець індекс рядка MatrixI (початкової матриці).
            MatrixR(r, 1) = Min 'Запис у MatrixR (перебудовану матрицю) у другий стовпець мінімальний елеммент рядка MatrixI (початкової матриці).
            Min = MatrixI(r + 1, 0) 'Зміщення припущення мінімального елемента рядка на слідуючий рядок.
        Next 'Слідуючий рядок.

    End Sub

    Private Sub Rebuild2() 'Перебудова матриці із вигляду MatrixI(n,n) у вигляд MatrixR(n,2), де перший стовпець це індекс рядка MatrixI, а другий це найменші елемент рядка MatrixI.

        Dim Min As Integer 'Змінні які запамятовують мінімальниий елемент у рядку матриці.
        Dim r As Integer, c As Integer 'Змінні які будуть перебирати рядки і стовпці.

        ReDim MatrixR(Cize, 2) 'Задання розмірності перебудованої матриці.
        Min = MatrixI(0, 0) 'Припущення що в першому рядку мінімальний елемент знаходиться у позиції (0,0).

        For r = 0 To Cize - 1 'Перебирання рядків.
            For c = 0 To Cize - 1 'Перебирання стовпців.
                If Min < MatrixI(r, c) Then 'Перевірка чи менший елемент MatrixI(r, c) за мінімальний.
                    Min = MatrixI(r, c) 'Присвоєння мінімальному елементу значення MatrixI(r, c).
                End If 'Закінчення перевірки.
            Next 'Слідуючий стовпець.
            MatrixR(r, 0) = r 'Запис у MatrixR (перебудовану матрицю) у перший стовпець індекс рядка MatrixI (початкової матриці).
            MatrixR(r, 1) = Min 'Запис у MatrixR (перебудовану матрицю) у другий стовпець мінімальний елеммент рядка MatrixI (початкової матриці).
            Min = MatrixI(r + 1, 0) 'Зміщення припущення мінімального елемента рядка на слідуючий рядок.
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

    Private Sub Assembling()
        Dim r As Integer, c As Integer 'Змінні які будуть перебирати рядки і стовпці.

        ReDim MatrixO(Cize, Cize)
        For r = 0 To Cize - 1
            For c = 0 To Cize - 1
                MatrixO(r, c) = MatrixI(BMatrixR(r, 0), c)
            Next
        Next
    End Sub

    'Функція порівняння двох елементів, та функція перестановки порівнюваних елементів.
    '==================================================================================================================

    Private Function Comparison(PIndexRow, NIndexRow, SpecificAgent) As Boolean 'Comparison (перевірка) порівняння двох елементів BMatrixR(r, 1) і BMatrixR(r+1, 1).

        Dim Answer = False 'Присвоюємо Answer (відповідь) вочаткове значення False.

        If TypeOf SpecificAgent Is String Then

            Dim P = BMatrixR(PIndexRow, 1) 'Previous (Попередній) елемент матриці BMatrixR(r, 1).
            Dim N = BMatrixR(NIndexRow, 1) 'Next (Слідуючий) елемент матриці BMatrixR(r+1, 1).

            If P > N Then 'Порівняння двох елементів BMatrixR(r, 1) і BMatrixR(r+1, 1).
                Answer = True 'При виконання умови Answer (відповідь) змінює своє значення на True.
                If Calculation.isVisual Then Visualization.Creat()
            End If 'Закінчення перевірки.
            ' провірка чи потрібна візуалізація з форми.
            ' Якщо потрібна то реалізовувати візуалізації  (виконувати її в іншому сабі). У відповідності від answer = True чи фолс зробити інший колір рядка. Виділити мінімальний елемент в кожному рядку іншим кольором.

        Else

            Dim P = BMatrixR(PIndexRow, 1) 'Previous (Попередній) елемент матриці BMatrixR(r, 1).

            If SpecificAgent > P Then 'Порівняння двох елементів BMatrixR(r, 1) і BMatrixR(r+1, 1).
                Answer = True 'При виконання умови Answer (відповідь) змінює своє значення на True.
                If Calculation.isVisual Then Visualization.Creat()
            End If 'Закінчення перевірки.
            ' провірка чи потрібна візуалізація з форми.
            ' Якщо потрібна то реалізовувати візуалізації  (виконувати її в іншому сабі). У відповідності від answer = True чи фолс зробити інший колір рядка. Виділити мінімальний елемент в кожному рядку іншим кольором.

        End If
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

    Private Sub Bubble() 'Метод сортування бульбашкою "0".

        Dim r As Integer 'Змінна яка буде перебирати рядки.
        Dim i As Integer
        Dim check As Integer 'check (перевірка) зміна для перевірки чи проводився захід у функцію Transposition за весь цикл проходу по всіх рядках матриці BMatrixR.
        Dim SpecificAgent = "usual sorting method" 'Констання для методів сортування у яких подяються лише номери рядків у функцію порівняння.
        Debug.Print("*********************************************************************")
        Debug.Print("Bubble")
        MatrixD(0, 0) = 0 'Індекс методу сортування "0"
        time.Reset()
        time.Start() 'Старт таймера.
        number = 0 'Кількість перестановок.
        Do 'Заходимо в цикл.
            check = 0 'Присвоюємо значення яке повідомляє циклу що в фунцію Transposition цикл не заходив.
            For r = 0 To Cize - 2 'Перебирання рядків.
                If Comparison(r, r + 1, SpecificAgent) Then 'Звернення до функції Comparison для порівняння значень.
                    Transposition(r, r + 1) 'Звертаємося до функції Transposition аби фона поміняла місцями значенння.
                    number = number + 1 'Кількість 
                    check = 1 'Присвоюємо значення яке повідомляє циклу що в фунцію Transposition цикл заходив.
                    Debug.Print(number & "#" & time.Elapsed.TotalMilliseconds)
                End If 'Закінчення перевірки.
            Next 'Слідуючий рядок.
        Loop Until check = 0 'Робимо перевірку уммови оскільки в нас цикл пряцює доки check не дорівнює нулю.
        If Calculation.isVisual Then Visualization.Creat()
        If Calculation.isVisual Then Threading.Thread.Sleep(4000)

        time.Stop() 'Зупинка таймера.
        MatrixD(0, 1) = number 'Запис в матрицю MatrixD(0, 2) кількості перестановок.
        MatrixD(0, 2) = time.Elapsed.TotalMilliseconds 'Запис в матрицю MatrixD(0, 2) часу сортування.

    End Sub

    Private Sub Selection() 'Метод сортування вибором "1".

        Dim r1 As Integer, r2 As Integer 'Змінна яка буде перебирати рядки.
        Dim rMin As Integer 'Змінна яка запамятовує мінімальниий елемент у стовпці матриці.
        Dim SpecificAgent = "usual sorting method" 'Констання для методів сортування у яких подяються лише номери рядків у функцію порівняння

        Debug.Print("*********************************************************************")
        Debug.Print("Selection")
        MatrixD(1, 0) = 1 'Індекс методу сортування "1"
        time.Reset()
        time.Start() 'Старт таймера.
        number = 0 'Кількість перестановок.
        For r1 = 0 To Cize - 2 'Перебирання рядків починаючи з нульового.
            rMin = r1 'Припускаємо що мінімальний елемент знаходиться на r1 рядку
            For r2 = r1 + 1 To Cize - 1 'Перебирання рядків починаючи з першого.
                If Comparison(rMin, r2, SpecificAgent) Then 'Звернення до функції Comparison для порівняння значень.
                    rMin = r2 'Прив виконання умови припускаємо що мінімальний елемент знаходиться у r2 рядку.
                End If 'Закінчення перевірки.
            Next 'Слідуючий рядок r2.
            Transposition(r1, rMin) 'Звертаємося до функції Transposition аби фона поміняла місцями значенння.
            number = number + 1 'Кількість перестановок
            Debug.Print(number & "#" & time.Elapsed.TotalMilliseconds)
        Next 'Слідуючий рядок r1.
        If Calculation.isVisual Then Visualization.Creat()
        If Calculation.isVisual Then Threading.Thread.Sleep(4000)

        time.Stop() 'Зупинка таймера.
        MatrixD(1, 1) = number 'Запис в матрицю MatrixD(1, 2) кількості перестановок.
        MatrixD(1, 2) = time.Elapsed.TotalMilliseconds 'Запис в матрицю MatrixD(1, 2) часу сортування.
    End Sub

    Private Sub Insertion() 'Метод сортування вставкою "2".

        Dim r1 As Integer, r2 As Integer 'Змінна яка буде перебирати рядки.
        Dim NumberAgent As Integer 'Змінна яка тимчасово запамятовує індекс рядка.
        Dim SpecificAgent As Integer 'Змінна яка тимчасово запамятовує значення комірки.

        Debug.Print("*********************************************************************")
        Debug.Print("Insertion")
        MatrixD(2, 0) = 2 'Індекс методу сортування "2"
        time.Reset()
        time.Start() 'Старт таймера..
        number = 0 'Кількість перестановок.
        For r1 = 1 To Cize - 1 'Перебирання рядків починаючи з першого.
            NumberAgent = BMatrixR(r1, 0) 'Запамятовуємо значення комірки BMatrixR(r1, 0) оскільки індекс за один прохід може стати не актуальним.
            SpecificAgent = BMatrixR(r1, 1) 'Запамятовуємо значення комірки BMatrixR(r1, 1) оскільки індекс за один прохід може стати не актуальним.
            r2 = r1 - 1 'Перебирання рядків починаючи r1 і йдемо назад до нульового рядка.
            Do While r2 >= 0 'Перевірка чи не дойшов цикл до нульового рядка.
                If Comparison(r2, r1, SpecificAgent) Then 'Звернення до функції Comparison для порівняння значень, при чому передаючи SpecificAgent який є числовим значенням і буде використовуватися у порівнянні значень на відміно від r1.
                    Exit Do 'При поверненні True змінюємо рядок.
                End If 'Закінчення перевірки.
                BMatrixR(r2 + 1, 0) = BMatrixR(r2, 0) 'Присвоєння комірці BMatrixR(r2 + 1, 0) значення комірки BMatrixR(r2, 0).
                BMatrixR(r2 + 1, 1) = BMatrixR(r2, 1) 'Присвоєння комірці BMatrixR(r2 + 1, 1) значення комірки BMatrixR(r2, 1).
                number = number + 1 'Кількість перестановок
                Debug.Print(number & "#" & time.Elapsed.TotalMilliseconds)
                r2 = r2 - 1 'Перебирання рядків починаючи r1 і йдемо назад до нульового рядка.
            Loop 'Закінчення циклу.
            BMatrixR(r2 + 1, 0) = NumberAgent 'Присвоєння комірці BMatrixR(r2 + 1, 1) значення із буфера NumberAgent.
            BMatrixR(r2 + 1, 1) = SpecificAgent 'Присвоєння комірці BMatrixR(r2 + 1, 1) значення із буфера SpecificAgent.
        Next 'Наступний рядок.
        If Calculation.isVisual Then Visualization.Creat()
        If Calculation.isVisual Then Threading.Thread.Sleep(4000)

        time.Stop() 'Зупинка таймера.
        MatrixD(2, 1) = number 'Запис в матрицю MatrixD(2, 2) кількості перестановок.
        MatrixD(2, 2) = time.Elapsed.TotalMilliseconds 'Запис в матрицю MatrixD(2, 2) часу сортування.
    End Sub

    Private Sub Gnome() 'Метод сортування гнома "3".

        Dim r1 As Integer, r2 As Integer 'Змінна яка буде перебирати рядки.
        Dim SpecificAgent = "usual sorting method" 'Констання для методів сортування у яких подяються лише номери рядків у функцію порівняння.

        Debug.Print("*********************************************************************")
        Debug.Print("Gnome")
        MatrixD(3, 0) = 3 'Індекс методу сортування "3"
        time.Reset()
        time.Start() 'Старт таймера.
        r1 = 1 'Присвоєння індекса рядка.
        r2 = 2 'Присвоєння індекса рядка.
        number = 0 'Кількість перестановок.
        Do While r1 < Cize 'Цикл виконується доти, доки не пройде всі рядки тобто r1 < Cize.
            If Comparison(r1 - 1, r1, SpecificAgent) Then 'Звернення до функції Comparison для порівняння значень.
                Transposition(r1 - 1, r1) 'Звертаємося до функції Transposition аби фона поміняла місцями значенння.
                number = number + 1 'Кількість перестановок
                Debug.Print(number & "#" & time.Elapsed.TotalMilliseconds)
                r1 = r1 - 1 'Повернення на один рядок назад для перевірки порядку.
                If r1 = 0 Then 'Перевірка чи не дойшли до початку матриці, якщо так значить ідемо в кінець матриці.
                    r1 = r2 'Присвоєння індекс слідуючого рядка.
                    r2 = r2 + 1 'Перехід на один рядок вперед.
                End If 'Закінчення перевірки.
            Else 'При поверненні Comparison False, ідемо вперед до кінця матриці.
                r1 = r2 'Присвоєння індекс слідуючого рядка.
                r2 = r2 + 1 'Перехід на один рядок вперед.
            End If 'Закінчення перевірки.
        Loop 'Закінчення циклу
        If Calculation.isVisual Then Visualization.Creat()
        If Calculation.isVisual Then Threading.Thread.Sleep(4000)

        time.Stop() 'Зупинка таймера.
        MatrixD(3, 1) = number 'Запис в матрицю MatrixD(3, 2) кількості перестановок.
        MatrixD(3, 2) = time.Elapsed.TotalMilliseconds 'Запис в матрицю MatrixD(3, 2) часу сортування.
    End Sub

    Private Sub Shell() 'Метод сортування Шелла "4".

        Dim r1 As Integer, r2 As Integer 'Змінна яка буде перебирати рядки.
        Dim SpecificAgent = "usual sorting method" 'Констання для методів сортування у яких подяються лише номери рядків у функцію порівняння.
        Dim Half As Integer 'Змінна яка приймає індекс середнього рядка масиву BMatrixR(,).
        Dim Answer As Boolean 'Змміння яка приймає значення True або False

        Debug.Print("*********************************************************************")
        Debug.Print("Shell")
        MatrixD(4, 0) = 4 'Індекс методу сортування "4"
        time.Reset()
        time.Start() 'Старт таймера.
        Half = Cize \ 2 'Знаходження індексу середнього рядка масиву BMatrixR(,).
        number = 0 'Кількість перестановок.
        Do 'Заходимо в цикл.
            r1 = Half 'Присвоюємо значенню r1 індекса рядка значення індекса середнього рядка.
            Do 'Заходимо в цикл.
                r2 = r1 - Half 'Присвоюємо значенню r2 індекса рядка значення різниці r1 і індекса середнього рядка.
                Answer = True 'Присвоюємо зміній Answer початкове значення в циклі True.
                Do
                    If Comparison(r2, r2 + Half, SpecificAgent) Then 'Звернення до функції Comparison для порівняння значень.
                        Transposition(r2, r2 + Half) 'Звертаємося до функції Transposition аби фона поміняла місцями значенння.
                        number = number + 1 'Кількість перестановок
                        Debug.Print(number & "#" & time.Elapsed.TotalMilliseconds)
                    Else 'Якщо перевірка не виконалася тоді:
                        Answer = False 'Присвоюємо зміній Answer значення False.
                    End If 'Закінчення перевірки.
                    r2 = r2 - Half 'Присвоюємо значенню r2 індекса рядка значення різниці r2 і індекса середнього рядка.
                Loop While (r2 >= 0 And Answer) 'Закінчення циклу.
                r1 = r1 + 1 'Переходимо на наступий рядок.
            Loop While r1 <= Cize - 1 'Закінчення циклу.
            Half = Half \ 2 'Знаходимо індекс середнього рядка із Half.
        Loop While Half > 0 'Закінчення циклу.
        If Calculation.isVisual Then Visualization.Creat()
        If Calculation.isVisual Then Threading.Thread.Sleep(4000)

        time.Stop() 'Зупинка таймера.
        MatrixD(4, 1) = number 'Запис в матрицю MatrixD(4, 2) кількості перестановок.
        MatrixD(4, 2) = time.Elapsed.TotalMilliseconds 'Запис в матрицю MatrixD(4, 2) часу сортування.
    End Sub

End Module

'Пояснення:
'==================================================================================================================
'P... - Previous (Попередній)
'N... - Next (Слідуючий)
'Answer - Відповідь
'Value - Значення
'Number - Номер
'Half - Половина
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

'Індекси методів сортування:
'0 - Метод сортування бульбашкою "0".
'1 - Метод сортування вибором "1".
'2 - Метод сортування вставкою "2".
'3 - Метод сортування гнома "3".
'4 - Метод сортування Шелла "4".