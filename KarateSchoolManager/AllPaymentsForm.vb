Public Class frmAllPayments

    ' Close form
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Load All Payments form
    Private Sub frmAllPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PaymentsTableAdapter.Fill(Me.KarateDataSet.Payments)
    End Sub
End Class