﻿Public Class MainForm

    ' Load main form
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Close form
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Open List All Members form
    Private Sub ListAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListAllToolStripMenuItem.Click
        frmAllMembers.ShowDialog()
    End Sub

    ' Open Add New Member form
    Private Sub AddNewMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewMemberToolStripMenuItem.Click
        frmAddMember.ShowDialog()
    End Sub

    ' Open Find Member form
    Private Sub FindMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindMemberToolStripMenuItem.Click
        frmFindMember.ShowDialog()
    End Sub

    ' Open All Payments form
    Private Sub AllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllToolStripMenuItem.Click
        frmAllPayments.ShowDialog()
    End Sub

    ' Open One Member form
    Private Sub OneMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OneMemberToolStripMenuItem.Click
        frmOneMember.ShowDialog()
    End Sub
End Class
