Public Class Sorting_Settings
    Public wh As Integer, hh As Integer

    Private Sub Sorting_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wh = General.wg
        hh = General.hg
        Me.Width = wh
        Me.Height = hh
    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

End Class