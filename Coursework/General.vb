Public Class General

    Public wg As Integer, hg As Integer
    Public button_activate As Integer

    Private Sub General_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wg = Width - 20
        hg = Height - 67
        Home.Show()
        Home.MdiParent = Me
    End Sub

    Private Sub ProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramToolStripMenuItem.Click
        Input_Data.Close()
        Output_Data.Close()
        Sorting_Settings.Close()
        About_Creator.Close()
        About_IDE.Close()
        About_Program.Close()
        button_activate = 3
        Controller_General()
    End Sub

    Private Sub CreatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreatorToolStripMenuItem.Click
        Input_Data.Close()
        Output_Data.Close()
        Sorting_Settings.Close()
        About_Creator.Close()
        About_IDE.Close()
        About_Program.Close()
        button_activate = 4
        Controller_General()
    End Sub

    Private Sub IDEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IDEToolStripMenuItem.Click
        Input_Data.Close()
        Output_Data.Close()
        Sorting_Settings.Close()
        About_Creator.Close()
        About_IDE.Close()
        About_Program.Close()
        button_activate = 5
        Controller_General()
    End Sub

    Public Sub Controller_Home()
        Select Case Home.button_activate
            Case 0
                Input_Data.Show()
                Input_Data.MdiParent = Me
            Case 1
                Sorting_Settings.Show()
                Sorting_Settings.MdiParent = Me
                Visualization.Show()
                Visualization.MdiParent = Me
            Case 2
                Output_Data.Show()
                Output_Data.MdiParent = Me
            Case 3
                About_Program.Show()
                About_Program.MdiParent = Me
            Case 4
                About_Creator.Show()
                About_Creator.MdiParent = Me
            Case 5
                About_IDE.Show()
                About_IDE.MdiParent = Me
        End Select
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub HomeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem1.Click
        Input_Data.Close()
        Output_Data.Close()
        Sorting_Settings.Close()
        About_Creator.Close()
        About_IDE.Close()
        About_Program.Close()
    End Sub

    Private Sub GenerateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateToolStripMenuItem.Click
        Input_Data.Close()
        Output_Data.Close()
        Sorting_Settings.Close()
        About_Creator.Close()
        About_IDE.Close()
        About_Program.Close()
        button_activate = 0
        Controller_General()
    End Sub

    Private Sub SortingSetingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortingSetingToolStripMenuItem.Click
        Input_Data.Close()
        Output_Data.Close()
        Sorting_Settings.Close()
        Visualization.Close()
        About_Creator.Close()
        About_IDE.Close()
        About_Program.Close()
        button_activate = 1
        Controller_General()
    End Sub

    Private Sub SortingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortingToolStripMenuItem.Click
        Input_Data.Close()
        Output_Data.Close()
        Sorting_Settings.Close()
        About_Creator.Close()
        About_IDE.Close()
        About_Program.Close()
        button_activate = 2
        Controller_General()
    End Sub

    Public Sub Controller_General()
        Select Case button_activate
            Case 0
                Input_Data.Show()
                Input_Data.MdiParent = Me
            Case 1
                Sorting_Settings.Show()
                Sorting_Settings.MdiParent = Me
                Visualization.Show()
                Visualization.MdiParent = Me
            Case 2
                Output_Data.Show()
                Output_Data.MdiParent = Me
            Case 3
                About_Program.Show()
                About_Program.MdiParent = Me
            Case 4
                About_Creator.Show()
                About_Creator.MdiParent = Me
            Case 5
                About_IDE.Show()
                About_IDE.MdiParent = Me
        End Select
    End Sub
End Class