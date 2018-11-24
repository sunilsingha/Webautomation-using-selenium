<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.InsertNewCommandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExecuteThisCommandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtValue = New System.Windows.Forms.TextBox()
        Me.TxtTargetValue = New System.Windows.Forms.TextBox()
        Me.CmbTargetList = New System.Windows.Forms.ComboBox()
        Me.cmbCmdList = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.StatusStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.BW = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnAddProcess = New System.Windows.Forms.Button()
        Me.BtnDeleteLang = New System.Windows.Forms.Button()
        Me.BtnUP = New System.Windows.Forms.Button()
        Me.BtnDown = New System.Windows.Forms.Button()
        Me.ContinueButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.PauseButton = New System.Windows.Forms.Button()
        Me.ExecuteButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoadConfigButton = New System.Windows.Forms.Button()
        Me.SaveAsButton = New System.Windows.Forms.Button()
        Me.Save1Button = New System.Windows.Forms.Button()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(193, 6)
        '
        'InsertNewCommandToolStripMenuItem
        '
        Me.InsertNewCommandToolStripMenuItem.Name = "InsertNewCommandToolStripMenuItem"
        Me.InsertNewCommandToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.InsertNewCommandToolStripMenuItem.Text = "Insert New Command"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(193, 6)
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DeleteToolStripMenuItem.Text = "Copy"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.InsertToolStripMenuItem.Text = "Cut"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem1, Me.ToolStripSeparator1, Me.InsertNewCommandToolStripMenuItem, Me.ToolStripSeparator2, Me.ExecuteThisCommandToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(197, 148)
        '
        'ExecuteThisCommandToolStripMenuItem
        '
        Me.ExecuteThisCommandToolStripMenuItem.Name = "ExecuteThisCommandToolStripMenuItem"
        Me.ExecuteThisCommandToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ExecuteThisCommandToolStripMenuItem.Text = "Execute this Command"
        '
        'TxtValue
        '
        Me.TxtValue.Location = New System.Drawing.Point(81, 121)
        Me.TxtValue.Name = "TxtValue"
        Me.TxtValue.Size = New System.Drawing.Size(351, 20)
        Me.TxtValue.TabIndex = 20
        '
        'TxtTargetValue
        '
        Me.TxtTargetValue.Location = New System.Drawing.Point(81, 88)
        Me.TxtTargetValue.Name = "TxtTargetValue"
        Me.TxtTargetValue.Size = New System.Drawing.Size(351, 20)
        Me.TxtTargetValue.TabIndex = 21
        '
        'CmbTargetList
        '
        Me.CmbTargetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTargetList.FormattingEnabled = True
        Me.CmbTargetList.Location = New System.Drawing.Point(81, 148)
        Me.CmbTargetList.Name = "CmbTargetList"
        Me.CmbTargetList.Size = New System.Drawing.Size(149, 21)
        Me.CmbTargetList.TabIndex = 18
        Me.CmbTargetList.Visible = False
        '
        'cmbCmdList
        '
        Me.cmbCmdList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCmdList.FormattingEnabled = True
        Me.cmbCmdList.Location = New System.Drawing.Point(81, 56)
        Me.cmbCmdList.Name = "cmbCmdList"
        Me.cmbCmdList.Size = New System.Drawing.Size(351, 21)
        Me.cmbCmdList.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Value"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Command"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Target ID"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGV.Location = New System.Drawing.Point(29, 50)
        Me.DGV.MultiSelect = False
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(452, 164)
        Me.DGV.TabIndex = 13
        '
        'StatusStrip
        '
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(42, 17)
        Me.StatusStrip.Text = "Status:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusStrip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 408)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(570, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'BW
        '
        Me.BW.WorkerReportsProgress = True
        Me.BW.WorkerSupportsCancellation = True
        '
        'BtnAddProcess
        '
        Me.BtnAddProcess.Location = New System.Drawing.Point(295, 146)
        Me.BtnAddProcess.Name = "BtnAddProcess"
        Me.BtnAddProcess.Size = New System.Drawing.Size(64, 23)
        Me.BtnAddProcess.TabIndex = 22
        Me.BtnAddProcess.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.BtnAddProcess, "Start Automation")
        Me.BtnAddProcess.UseVisualStyleBackColor = True
        '
        'BtnDeleteLang
        '
        Me.BtnDeleteLang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDeleteLang.Font = New System.Drawing.Font("Wingdings 2", 24.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDeleteLang.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteLang.Location = New System.Drawing.Point(499, 170)
        Me.BtnDeleteLang.Name = "BtnDeleteLang"
        Me.BtnDeleteLang.Size = New System.Drawing.Size(47, 44)
        Me.BtnDeleteLang.TabIndex = 31
        Me.BtnDeleteLang.Text = "U"
        Me.ToolTip1.SetToolTip(Me.BtnDeleteLang, "Delete Language from list")
        Me.BtnDeleteLang.UseVisualStyleBackColor = True
        '
        'BtnUP
        '
        Me.BtnUP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUP.Font = New System.Drawing.Font("Wingdings 3", 20.0!, System.Drawing.FontStyle.Bold)
        Me.BtnUP.Location = New System.Drawing.Point(499, 50)
        Me.BtnUP.Name = "BtnUP"
        Me.BtnUP.Size = New System.Drawing.Size(47, 44)
        Me.BtnUP.TabIndex = 30
        Me.BtnUP.Text = "p"
        Me.ToolTip1.SetToolTip(Me.BtnUP, "Move Langue Up")
        Me.BtnUP.UseVisualStyleBackColor = True
        '
        'BtnDown
        '
        Me.BtnDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDown.Font = New System.Drawing.Font("Wingdings 3", 20.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDown.Location = New System.Drawing.Point(499, 107)
        Me.BtnDown.Name = "BtnDown"
        Me.BtnDown.Size = New System.Drawing.Size(47, 44)
        Me.BtnDown.TabIndex = 29
        Me.BtnDown.Text = "q"
        Me.ToolTip1.SetToolTip(Me.BtnDown, "Move Langauge Down")
        Me.BtnDown.UseVisualStyleBackColor = True
        '
        'ContinueButton
        '
        Me.ContinueButton.AutoSize = True
        Me.ContinueButton.Image = CType(resources.GetObject("ContinueButton.Image"), System.Drawing.Image)
        Me.ContinueButton.Location = New System.Drawing.Point(499, 227)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(47, 44)
        Me.ContinueButton.TabIndex = 92
        Me.ToolTip1.SetToolTip(Me.ContinueButton, "Continue")
        Me.ContinueButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Image = CType(resources.GetObject("StopButton.Image"), System.Drawing.Image)
        Me.StopButton.Location = New System.Drawing.Point(499, 271)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(47, 44)
        Me.StopButton.TabIndex = 93
        Me.ToolTip1.SetToolTip(Me.StopButton, "Terminate")
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'PauseButton
        '
        Me.PauseButton.Image = CType(resources.GetObject("PauseButton.Image"), System.Drawing.Image)
        Me.PauseButton.Location = New System.Drawing.Point(499, 315)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(47, 44)
        Me.PauseButton.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.PauseButton, "Pause")
        Me.PauseButton.UseVisualStyleBackColor = True
        '
        'ExecuteButton
        '
        Me.ExecuteButton.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ExecuteButton.Image = CType(resources.GetObject("ExecuteButton.Image"), System.Drawing.Image)
        Me.ExecuteButton.Location = New System.Drawing.Point(499, 359)
        Me.ExecuteButton.Name = "ExecuteButton"
        Me.ExecuteButton.Size = New System.Drawing.Size(47, 44)
        Me.ExecuteButton.TabIndex = 95
        Me.ToolTip1.SetToolTip(Me.ExecuteButton, "Execute")
        Me.ExecuteButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Target Type"
        Me.Label2.Visible = False
        '
        'LoadConfigButton
        '
        Me.LoadConfigButton.Location = New System.Drawing.Point(115, 12)
        Me.LoadConfigButton.Name = "LoadConfigButton"
        Me.LoadConfigButton.Size = New System.Drawing.Size(75, 23)
        Me.LoadConfigButton.TabIndex = 26
        Me.LoadConfigButton.Text = "Load"
        Me.LoadConfigButton.UseVisualStyleBackColor = True
        '
        'SaveAsButton
        '
        Me.SaveAsButton.Location = New System.Drawing.Point(277, 12)
        Me.SaveAsButton.Name = "SaveAsButton"
        Me.SaveAsButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveAsButton.TabIndex = 25
        Me.SaveAsButton.Text = "Save As"
        Me.SaveAsButton.UseVisualStyleBackColor = True
        '
        'Save1Button
        '
        Me.Save1Button.Location = New System.Drawing.Point(196, 12)
        Me.Save1Button.Name = "Save1Button"
        Me.Save1Button.Size = New System.Drawing.Size(75, 23)
        Me.Save1Button.TabIndex = 24
        Me.Save1Button.Text = "Save"
        Me.Save1Button.UseVisualStyleBackColor = True
        '
        'NewButton
        '
        Me.NewButton.Location = New System.Drawing.Point(29, 12)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(80, 23)
        Me.NewButton.TabIndex = 23
        Me.NewButton.Text = "New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Description"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtDescription)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnAddProcess)
        Me.GroupBox1.Controls.Add(Me.TxtValue)
        Me.GroupBox1.Controls.Add(Me.TxtTargetValue)
        Me.GroupBox1.Controls.Add(Me.CmbTargetList)
        Me.GroupBox1.Controls.Add(Me.cmbCmdList)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 220)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 184)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control"
        '
        'TxtDescription
        '
        Me.TxtDescription.Location = New System.Drawing.Point(81, 24)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(351, 20)
        Me.TxtDescription.TabIndex = 28
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(369, 146)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(64, 23)
        Me.BtnSave.TabIndex = 22
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 430)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.ExecuteButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.ContinueButton)
        Me.Controls.Add(Me.BtnDeleteLang)
        Me.Controls.Add(Me.BtnUP)
        Me.Controls.Add(Me.BtnDown)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LoadConfigButton)
        Me.Controls.Add(Me.SaveAsButton)
        Me.Controls.Add(Me.Save1Button)
        Me.Controls.Add(Me.NewButton)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Web Auto"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InsertNewCommandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExecuteThisCommandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TxtValue As System.Windows.Forms.TextBox
    Friend WithEvents TxtTargetValue As System.Windows.Forms.TextBox
    Friend WithEvents CmbTargetList As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCmdList As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnAddProcess As System.Windows.Forms.Button
    Friend WithEvents LoadConfigButton As System.Windows.Forms.Button
    Friend WithEvents SaveAsButton As System.Windows.Forms.Button
    Friend WithEvents Save1Button As System.Windows.Forms.Button
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents BtnDeleteLang As System.Windows.Forms.Button
    Friend WithEvents BtnUP As System.Windows.Forms.Button
    Friend WithEvents BtnDown As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ContinueButton As System.Windows.Forms.Button
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents PauseButton As System.Windows.Forms.Button
    Friend WithEvents ExecuteButton As System.Windows.Forms.Button
End Class
