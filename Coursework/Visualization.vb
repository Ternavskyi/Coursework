Public Class Visualization

    Public wh As Integer, hh As Integer

    Private Sub Visualization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wh = General.wg
        hh = General.hg
        Me.Width = (wh / 3) * 2
        Me.Height = hh
        Me.Location = New Point(Home.Location.X + wh / 3, Home.Location.Y)
        Chart1.Width = Me.Width + 10
        Chart1.Height = Me.Height - 30
        Panel1.Location = New Point(Home.Location.X, Home.Location.Y)
        Panel1.Width = Me.Width
        Panel1.Height = Me.Height
        Panel2.Location = New Point(Home.Location.X, Home.Location.Y)
        Panel2.Width = Me.Width
        Panel2.Height = Me.Height
        Panel3.Location = New Point(Home.Location.X, Home.Location.Y)
        Panel3.Width = Me.Width
        Panel3.Height = Me.Height
        Panel4.Location = New Point(Home.Location.X, Home.Location.Y)
        Panel4.Width = Me.Width
        Panel4.Height = Me.Height
        Panel5.Location = New Point(Home.Location.X, Home.Location.Y)
        Panel5.Width = Me.Width
        Panel5.Height = Me.Height
        Panel6.Location = New Point(Home.Location.X, Home.Location.Y)
        Panel6.Width = Me.Width
        Panel6.Height = Me.Height
    End Sub

    Public Sub Creat()
        Dim i As Integer
        Dim workMethod As String
        Select Case Calculation.Work_Sort_Method
            Case 0
                workMethod = "Bubble"
            Case 1
                workMethod = "Selection"
            Case 2
                workMethod = "Insertion"
            Case 3
                workMethod = "Gnome"
            Case 4
                workMethod = "Shell"
        End Select
        Label2.Text = workMethod
        Label3.Text = CStr(Calculation.number)
        Label5.Text = CStr(Calculation.time.Elapsed.TotalMilliseconds)
        Threading.Thread.Sleep(Calculation.sleepTime)
        Chart1.Series("Series1").Points.Clear()
        For i = 0 To Calculation.Cize
            Chart1.Series("Series1").Points.AddXY(Convert.ToString(Calculation.BMatrixR(i, 0)), Calculation.BMatrixR(i, 1))
        Next
        Chart1.Update()
        Label1.Update()
        Label2.Update()
        Label3.Update()
        Label4.Update()
        Label5.Update()
        Label6.Update()
    End Sub

End Class