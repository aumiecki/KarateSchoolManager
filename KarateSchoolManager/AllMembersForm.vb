Public Class frmAllMembers
    ' Load All Members form
    Private Sub frmAllMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Loads data into the 'KarateDataSet.Members' table
        Me.MembersTableAdapter.Fill(Me.KarateDataSet.Members)

    End Sub

    ' Close form
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class