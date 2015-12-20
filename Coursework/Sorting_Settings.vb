Public Class Sorting_Settings

    Public wh As Integer, hh As Integer
    Public whc As Integer, hhc As Integer
    Public method(5) As Integer

    Private Sub Sorting_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wh = General.wg
        hh = General.hg
        whc = General.wgc
        hhc = General.hgc
        Me.Width = wh
        Me.Height = hh
    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub cbSorting_Setting_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSorting_Setting.SelectedIndexChanged
        Dim custEnum As IEnumerator = cbSorting_Setting.SelectedItems.GetEnumerator
        custEnum.Reset()
        Dim thisChar As Object
        For i = 0 To 4
            method(i) = 0
        Next
        While custEnum.MoveNext()
            thisChar = custEnum.Current()
        End While
        Select Case thisChar
            Case "Bubble"
                If method(0) = 1 Then
                    method(0) = 0
                Else
                    method(0) = 1
                End If
            Case "Selection"
                If method(1) = 1 Then
                    method(1) = 0
                Else
                    method(1) = 1
                End If
            Case "Insertion"
                If method(2) = 1 Then
                    method(2) = 0
                Else
                    method(2) = 1
                End If
            Case "Gnome"
                If method(3) = 1 Then
                    method(3) = 0
                Else
                    method(3) = 1
                End If
            Case "Shell"
                If method(4) = 1 Then
                    method(4) = 0
                Else
                    method(4) = 1
                End If
        End Select
    End Sub
End Class