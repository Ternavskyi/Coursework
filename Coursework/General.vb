Public Class General
    Public wg As Integer, hg As Integer
    Public wgc As Integer, hgc As Integer

    Private Sub General_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wg = Width - 20
        hg = Height - 67
        Home.Show()
        Home.MdiParent = Me
    End Sub

    Private Sub General_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        wgc = Width - 20
        hgc = Height - 67
    End Sub

    Public Sub Controller()
        Select Case Home.button_activate
            Case 0
                Input_Data.Show()
                Input_Data.MdiParent = Me
            Case 1
                Sorting_Settings.Show()
                Sorting_Settings.MdiParent = Me
            Case 2
                Output_Data.Show()
                Output_Data.MdiParent = Me
        End Select
    End Sub
End Class