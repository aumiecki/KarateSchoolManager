Public Class frmAddMember

    ' Load Add Member form
    Private Sub frmAddMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AddNew.MembersBindingSource.AddNew()
        MembersBindingSource.AddNew()

        dtpDate.Value = Today ' Sets today's data
    End Sub

    ' Close form
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Close form while entering info in to form
    Private Sub frmAddMember_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MembersBindingSource.CancelEdit()
    End Sub

    ' Update button handler to perform Inser to the table
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