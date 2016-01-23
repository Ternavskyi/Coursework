Public Class Sorting_Settings

    Public wh As Integer, hh As Integer
    Public Matrix_Sort_Method(5, 2) As Integer
    Public Index_Max_Min As Integer

    Private Sub Sorting_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wh = General.wg
        hh = General.hg
        Me.Width = wh
        Me.Height = hh
        Me.Location = New Point(Home.Location.X, Home.Location.Y)
        iMax_Min.SelectedIndex = 0
    End Sub

    Private Sub bSent_Seting_Click(sender As Object, e As EventArgs) Handles bSent_Seting.Click

        Calculation.isVisual = cbVisualization.Checked
        Calculation.sleepTime = CInt(sleepTime.Text)

        Threading.Thread.Sleep(3000)
        If Calculation.isVisual Then Visualization.Show()

        Call Sort_Method()
        Call Sort_Method_Calculation()
        Calculation.Index_Max_Min = Index_Max_Min
        Call Sort()
        Home.bOutput_Data.Enabled = True
        Home.bOutput_Data.BackColor = Color.Aqua
        Home.pArrow.Location = New Point(Home.bOutput_Data.Location.X + Home.bOutput_Data.Width / 2 - Home.pArrow.Width / 2, Home.bOutput_Data.Location.Y - Home.pArrow.Height - 20)
        General.SortingToolStripMenuItem.Enabled = True
        General.SortingToolStripMenuItem.BackColor = Color.Aqua
        If cbVisualization.Checked = True Then
            Threading.Thread.Sleep(4000)
            Me.Close()
            Visualization.Close()
        Else
            Me.Close()
            Visualization.Close()
        End If

    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
        Visualization.Close()
    End Sub

    Public Sub Sort_Method()
        Matrix_Sort_Method(0, 0) = 0
        Matrix_Sort_Method(0, 1) = 0
        Matrix_Sort_Method(1, 0) = 0
        Matrix_Sort_Method(1, 1) = 0
        Matrix_Sort_Method(2, 0) = 0
        Matrix_Sort_Method(2, 1) = 0
        Matrix_Sort_Method(3, 0) = 0
        Matrix_Sort_Method(3, 1) = 0
        Matrix_Sort_Method(4, 0) = 0
        Matrix_Sort_Method(4, 1) = 0
        If cbBubble.Checked = True Then
            Matrix_Sort_Method(0, 1) = 1
        Else
            Matrix_Sort_Method(0, 1) = 0
        End If
        If cbSelection.Checked = True Then
            Matrix_Sort_Method(1, 1) = 1
        Else
            Matrix_Sort_Method(1, 1) = 0
        End If
        If cbInsertion.Checked = True Then
            Matrix_Sort_Method(2, 1) = 1
        Else
            Matrix_Sort_Method(2, 1) = 0
        End If
        If cbGnome.Checked = True Then
            Matrix_Sort_Method(3, 1) = 1
        Else
            Matrix_Sort_Method(3, 1) = 0
        End If
        If cbShell.Checked = True Then
            Matrix_Sort_Method(4, 1) = 1
        Else
            Matrix_Sort_Method(4, 1) = 0
        End If
    End Sub

    Private Sub cbVisualization_CheckedChanged(sender As Object, e As EventArgs) Handles cbVisualization.CheckedChanged

    End Sub

    Private Sub cbBubble_MouseEnter(sender As Object, e As EventArgs) Handles cbBubble.MouseEnter
        Visualization.Panel1.Visible = True
    End Sub

    Private Sub cbBubble_MouseLeave(sender As Object, e As EventArgs) Handles cbBubble.MouseLeave
        Visualization.Panel1.Visible = False
    End Sub

    Private Sub cbSelection_MouseEnter(sender As Object, e As EventArgs) Handles cbSelection.MouseEnter
        Visualization.Panel2.Visible = True
    End Sub

    Private Sub cbSelection_MouseLeave(sender As Object, e As EventArgs) Handles cbSelection.MouseLeave
        Visualization.Panel2.Visible = False
    End Sub

    Private Sub cbInsertion_MouseEnter(sender As Object, e As EventArgs) Handles cbInsertion.MouseEnter
        Visualization.Panel3.Visible = True
    End Sub

    Private Sub cbInsertion_MouseLeave(sender As Object, e As EventArgs) Handles cbInsertion.MouseLeave
        Visualization.Panel3.Visible = False
    End Sub

    Private Sub cbGnome_MouseEnter(sender As Object, e As EventArgs) Handles cbGnome.MouseEnter
        Visualization.Panel4.Visible = True
    End Sub

    Private Sub cbGnome_MouseLeave(sender As Object, e As EventArgs) Handles cbGnome.MouseLeave
        Visualization.Panel4.Visible = False
    End Sub

    Private Sub cbShell_MouseEnter(sender As Object, e As EventArgs) Handles cbShell.MouseEnter
        Visualization.Panel5.Visible = True
    End Sub

    Private Sub cbShell_MouseLeave(sender As Object, e As EventArgs) Handles cbShell.MouseLeave
        Visualization.Panel5.Visible = False
    End Sub

    Private Sub cbVisualization_MouseEnter(sender As Object, e As EventArgs) Handles cbVisualization.MouseEnter
        Visualization.Panel6.Visible = True
    End Sub

    Private Sub iMax_Min_SelectedIndexChanged(sender As Object, e As EventArgs) Handles iMax_Min.SelectedIndexChanged
        Select Case iMax_Min.SelectedIndex
            Case 0
                Index_Max_Min = 0
            Case 1
                Index_Max_Min = 1
        End Select
    End Sub

    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        Me.Close()
        Visualization.Close()
    End Sub

    Private Sub cbVisualization_MouseLeave(sender As Object, e As EventArgs) Handles cbVisualization.MouseLeave
        Visualization.Panel6.Visible = False
    End Sub
End Class