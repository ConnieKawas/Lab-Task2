<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnClick = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SparePartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnClick
        '
        Me.BtnClick.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnClick.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClick.Location = New System.Drawing.Point(417, 567)
        Me.BtnClick.Name = "BtnClick"
        Me.BtnClick.Size = New System.Drawing.Size(143, 37)
        Me.BtnClick.TabIndex = 1
        Me.BtnClick.Text = "Click here"
        Me.BtnClick.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(592, 33)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SparePartToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(75, 29)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SparePartToolStripMenuItem
        '
        Me.SparePartToolStripMenuItem.Name = "SparePartToolStripMenuItem"
        Me.SparePartToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.SparePartToolStripMenuItem.Text = "Spare Part"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FeedbackToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(63, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(175, 30)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 51)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Spare Parts"
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(19, 567)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 47)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(592, 626)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClick)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClick As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SparePartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnExit As Button
End Class
