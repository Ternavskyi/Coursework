Public Class Visualization_Rectangles

    Public Sub Creat()
        Dim i As Integer
        Dim worMethod As String
        Select Case Calculation.workMethod
            Case 0
                worMethod = "Bubble"
            Case 1
                worMethod = "Selection"
            Case 2
                worMethod = "Insertion"
            Case 3
                worMethod = "Gnome"
            Case 4
                worMethod = "Shell"
        End Select
        Label2.Text = worMethod
        Label3.Text = CStr(Calculation.number)
        Label5.Text = CStr(Calculation.time.Elapsed.TotalMilliseconds)
        Threading.Thread.Sleep(Calculation.sleepTime)
        Chart1.Series("Series1").Points.Clear()
        For i = 1 To Calculation.Cize
            Chart1.Series("Series1").Points.AddXY(Convert.ToString(Calculation.BMatrixR(i, 0)), Calculation.BMatrixR(i, 1))
        Next
        Chart1.Update()
        Label2.Update()
        Label3.Update()
        Label5.Update()
        Label1.Update()
        Label4.Update()
        Label6.Update()
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class