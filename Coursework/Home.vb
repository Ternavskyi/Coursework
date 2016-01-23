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
        pArrow.Location = New Point(bInput_Data.Location.X + bInput_Data.Width / 2 - pArrow.Width / 2, bInput_Data.Location.Y - pArrow.Height - 20)
        pVS.Location = New Point(Me.Width - pVS.Width - 20, 20)
        pIco.Location = New Point(pVS.Location.X - pIco.Width - 20, 20)
        pCoursework.Location = New Point(pIco.Location.X - pCoursework.Width - 20, 20)
        bExit.Location = New Point(12, 12)
    End Sub

    Private Sub bInput_Data_Click(sender As Object, e As EventArgs) Handles bInput_Data.Click
        button_activate = 0
        General.Controller_Home()
    End Sub

    Private Sub bSorting_Setting_Click(sender As Object, e As EventArgs) Handles bSorting_Setting.Click
        button_activate = 1
        General.Controller_Home()
    End Sub

    Private Sub pCoursework_Click(sender As Object, e As EventArgs) Handles pCoursework.Click
        button_activate = 3
        General.Controller_Home()
    End Sub

    Private Sub pIco_Click(sender As Object, e As EventArgs) Handles pIco.Click
        button_activate = 4
        General.Controller_Home()
    End Sub

    Private Sub pVS_Click(sender As Object, e As EventArgs) Handles pVS.Click
        button_activate = 5
        General.Controller_Home()
    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        General.Close()
    End Sub

    Private Sub bOutput_Data_Click(sender As Object, e As EventArgs) Handles bOutput_Data.Click
        button_activate = 2
        General.Controller_Home()
    End Sub
End Class