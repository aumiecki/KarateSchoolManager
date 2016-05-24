Public Class frmAddMember

    Private Sub frmAddMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AddNew.MembersBindingSource.AddNew()
        MembersBindingSource.AddNew()

        dtpDate.Value = Today
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmAddMember_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MembersBindingSource.CancelEdit()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            MembersBindingSource.EndEdit()
            MembersTableAdapter.Update(KarateDataSet.Members)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
End Class