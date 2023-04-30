<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMathTutor
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
        Me.grpAge = New System.Windows.Forms.GroupBox()
        Me.radUpperElementary = New System.Windows.Forms.RadioButton()
        Me.radEarlyElementary = New System.Windows.Forms.RadioButton()
        Me.btnGenerateList = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddition = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMultiplication = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpAge.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAge
        '
        Me.grpAge.Controls.Add(Me.radUpperElementary)
        Me.grpAge.Controls.Add(Me.radEarlyElementary)
        Me.grpAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAge.Location = New System.Drawing.Point(45, 40)
        Me.grpAge.Name = "grpAge"
        Me.grpAge.Size = New System.Drawing.Size(256, 175)
        Me.grpAge.TabIndex = 0
        Me.grpAge.TabStop = False
        Me.grpAge.Text = "Grade Level"
        '
        'radUpperElementary
        '
        Me.radUpperElementary.AutoSize = True
        Me.radUpperElementary.Location = New System.Drawing.Point(31, 98)
        Me.radUpperElementary.Name = "radUpperElementary"
        Me.radUpperElementary.Size = New System.Drawing.Size(151, 20)
        Me.radUpperElementary.TabIndex = 1
        Me.radUpperElementary.TabStop = True
        Me.radUpperElementary.Text = "Upper Elementary"
        Me.radUpperElementary.UseVisualStyleBackColor = True
        '
        'radEarlyElementary
        '
        Me.radEarlyElementary.AutoSize = True
        Me.radEarlyElementary.Location = New System.Drawing.Point(31, 55)
        Me.radEarlyElementary.Name = "radEarlyElementary"
        Me.radEarlyElementary.Size = New System.Drawing.Size(144, 20)
        Me.radEarlyElementary.TabIndex = 0
        Me.radEarlyElementary.TabStop = True
        Me.radEarlyElementary.Text = "Early Elementary"
        Me.radEarlyElementary.UseVisualStyleBackColor = True
        '
        'btnGenerateList
        '
        Me.btnGenerateList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateList.Location = New System.Drawing.Point(76, 249)
        Me.btnGenerateList.Name = "btnGenerateList"
        Me.btnGenerateList.Size = New System.Drawing.Size(119, 30)
        Me.btnGenerateList.TabIndex = 1
        Me.btnGenerateList.Text = "Generate List"
        Me.btnGenerateList.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 16
        Me.lstResults.Location = New System.Drawing.Point(339, 40)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(158, 292)
        Me.lstResults.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(598, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuClear.Size = New System.Drawing.Size(180, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddition, Me.mnuMultiplication})
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.ClearToolStripMenuItem.Text = "Operation"
        '
        'mnuAddition
        '
        Me.mnuAddition.Name = "mnuAddition"
        Me.mnuAddition.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAddition.Size = New System.Drawing.Size(193, 22)
        Me.mnuAddition.Text = "&Addition"
        '
        'mnuMultiplication
        '
        Me.mnuMultiplication.Name = "mnuMultiplication"
        Me.mnuMultiplication.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.mnuMultiplication.Size = New System.Drawing.Size(193, 22)
        Me.mnuMultiplication.Text = "&Multiplication"
        '
        'frmMathTutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(598, 400)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.btnGenerateList)
        Me.Controls.Add(Me.grpAge)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMathTutor"
        Me.Text = "Elementary Math Tutor"
        Me.grpAge.ResumeLayout(False)
        Me.grpAge.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpAge As GroupBox
    Friend WithEvents radUpperElementary As RadioButton
    Friend WithEvents radEarlyElementary As RadioButton
    Friend WithEvents btnGenerateList As Button
    Friend WithEvents lstResults As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAddition As ToolStripMenuItem
    Friend WithEvents mnuMultiplication As ToolStripMenuItem
End Class
