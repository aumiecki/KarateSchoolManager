Public Class frmAllInstructors

    ' Close form
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Load All Instructors form using LINQ
    Private Sub frmAllInstructors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New KarateClassesDataContext
        Dim query = From aPerson In db.Instructors
                    Order By aPerson.Last_Name
                    Select aPerson
        dgvAllInstructors.DataSource = query
    End Sub
End Class