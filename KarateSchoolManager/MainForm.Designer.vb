﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSchoolTitle = New System.Windows.Forms.Label()
        Me.lblAppTitle = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembershipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OneMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(48, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(390, 115)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblSchoolTitle)
        Me.Panel2.Location = New System.Drawing.Point(15, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 80)
        Me.Panel2.TabIndex = 0
        '
        'lblSchoolTitle
        '
        Me.lblSchoolTitle.AutoSize = True
        Me.lblSchoolTitle.Location = New System.Drawing.Point(34, 28)
        Me.lblSchoolTitle.Name = "lblSchoolTitle"
        Me.lblSchoolTitle.Size = New System.Drawing.Size(135, 16)
        Me.lblSchoolTitle.TabIndex = 0
        Me.lblSchoolTitle.Text = "Kyoshi Karate School"
        '
        'lblAppTitle
        '
        Me.lblAppTitle.AutoSize = True
        Me.lblAppTitle.Location = New System.Drawing.Point(13, 212)
        Me.lblAppTitle.Name = "lblAppTitle"
        Me.lblAppTitle.Size = New System.Drawing.Size(155, 16)
        Me.lblAppTitle.TabIndex = 1
        Me.lblAppTitle.Text = "Management System 1.0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MembershipToolStripMenuItem, Me.PaymentsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(514, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MembershipToolStripMenuItem
        '
        Me.MembershipToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListAllToolStripMenuItem, Me.FindMemberToolStripMenuItem, Me.AddNewMemberToolStripMenuItem})
        Me.MembershipToolStripMenuItem.Name = "MembershipToolStripMenuItem"
        Me.MembershipToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.MembershipToolStripMenuItem.Text = "Membership"
        '
        'ListAllToolStripMenuItem
        '
        Me.ListAllToolStripMenuItem.Name = "ListAllToolStripMenuItem"
        Me.ListAllToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ListAllToolStripMenuItem.Text = "List All"
        '
        'FindMemberToolStripMenuItem
        '
        Me.FindMemberToolStripMenuItem.Name = "FindMemberToolStripMenuItem"
        Me.FindMemberToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.FindMemberToolStripMenuItem.Text = "Find Member"
        '
        'AddNewMemberToolStripMenuItem
        '
        Me.AddNewMemberToolStripMenuItem.Name = "AddNewMemberToolStripMenuItem"
        Me.AddNewMemberToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AddNewMemberToolStripMenuItem.Text = "Add New Member"
        '
        'PaymentsToolStripMenuItem
        '
        Me.PaymentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllToolStripMenuItem, Me.OneMemberToolStripMenuItem})
        Me.PaymentsToolStripMenuItem.Name = "PaymentsToolStripMenuItem"
        Me.PaymentsToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.PaymentsToolStripMenuItem.Text = "Payments"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AllToolStripMenuItem.Text = "All"
        '
        'OneMemberToolStripMenuItem
        '
        Me.OneMemberToolStripMenuItem.Name = "OneMemberToolStripMenuItem"
        Me.OneMemberToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OneMemberToolStripMenuItem.Text = "One Member"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 237)
        Me.Controls.Add(Me.lblAppTitle)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karate School Manager"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSchoolTitle As Label
    Friend WithEvents lblAppTitle As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MembershipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OneMemberToolStripMenuItem As ToolStripMenuItem
End Class
