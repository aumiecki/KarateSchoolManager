Public Class frmFindInstructor

    ' Close form
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Find button handler to search by last name
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim db As New KarateClassesDataContext
        ' Perform a wildcard search for the last name using LINQ
        Dim query = From aPerson In db.Instructors
                    Where aPerson.Last_Name Like txtLastName.Text & "*"
                    Order By aPerson.Last_Name
                    Select aPerson.ID, aPerson.Last_Name
        dgvInstructors.DataSource = query
        dgvInstructors.Columns(1).HeaderCell.Value = "Last Name"
    End Sub
End Class