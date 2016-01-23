Public Class About_Creator

    Public wh As Integer, hh As Integer

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub About_Creator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wh = General.wg
        hh = General.hg
        Me.Width = wh
        Me.Height = hh
        Me.Location = New Point(Home.Location.X, Home.Location.Y)
        txtAbout_Creator.Location = New Point(bClose.Location.X + bClose.Width + 20, bClose.Location.Y + bClose.Height + 20)
        txtAbout_Creator.Width = wh - bClose.Location.X - bClose.Width - 20 - 400
        txtAbout_Creator.Height = hh - bClose.Location.Y - bClose.Height - 20
    End Sub

End Class