Public Class frmOneMember

    ' Close form
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Find button
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        ' Perform a wildcard search for the last name. 
        Me.MemberPaymentTableAdapter.FindPayment(KarateDataSet.MemberPayment, txtLastName.Text)
    End Sub
End Class