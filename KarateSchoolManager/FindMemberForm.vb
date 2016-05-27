Public Class frmFindMember

    ' Close form
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Load Find Member form
    Private Sub frmFindMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Find button handler to search by last name
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        ' Perform a wildcard search for the last name. 
        Me.MembersTableAdapter.FindMember(KarateDataSet.Members, txtLastName.Text)
    End Sub
End Class