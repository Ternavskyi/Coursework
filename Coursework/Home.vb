Public Class Home
    Public wh As Integer, hh As Integer
    Public button_activate As Integer

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wh = General.wg
        hh = General.hg
        Me.Width = wh
        Me.Height = hh
        bInput_Data.Location = New Point(Me.Width / 2 - bInput_Data.Width / 2 - bSorting_Setting.Width - 100, Me.Height / 2 - bInput_Data.Height / 2)
        bSorting_Setting.Location = New Point(Me.Width / 2 - bSorting_Setting.Width / 2, Me.Height / 2 - bSorting_Setting.Height / 2)
        bOutput_Data.Location = New Point(Me.Width / 2 - bOutput_Data.Width / 2 + bSorting_Setting.Width + 100, Me.Height / 2 - bOutput_Data.Height / 2)
    End Sub

    Private Sub bInput_Data_Click(sender As Object, e As EventArgs) Handles bInput_Data.Click
        button_activate = 0
        General.Controller()
    End Sub

    Private Sub bSorting_Setting_Click(sender As Object, e As EventArgs) Handles bSorting_Setting.Click
        button_activate = 1
        General.Controller()
    End Sub

    Private Sub bOutput_Data_Click(sender As Object, e As EventArgs) Handles bOutput_Data.Click
        button_activate = 2
        General.Controller()
    End Sub
End Class