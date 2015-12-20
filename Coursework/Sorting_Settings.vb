Public Class Sorting_Settings

    Public wh As Integer, hh As Integer
    Public whc As Integer, hhc As Integer

    Private Sub Sorting_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wh = General.wg
        hh = General.hg
        whc = General.wgc
        hhc = General.hgc
        Me.Width = wh
        Me.Height = hh
        cbSorting_Setting.Location = New Point(wh / 2 - cbSorting_Setting.Width / 2, hh / 2 - cbSorting_Setting.Height / 2)
    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

End Class