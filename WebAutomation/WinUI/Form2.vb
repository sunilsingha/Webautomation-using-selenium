Imports AdvancedOops

Public Class Form2

    Private _WebAuto As New WebAuto

    Private _fileExtension As String = "config"

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        _WebAuto = New WebAuto
        _WebAuto.LoadNewConfiguration()
    End Sub

    Private Sub LoadConfigButton_Click(sender As Object, e As EventArgs) Handles LoadConfigButton.Click
        Try
            Dim opnDialog As New OpenFileDialog
            opnDialog.Filter = "Configuration(*." & _fileExtension & ")|*." & _fileExtension
            If opnDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                LoadConfig(opnDialog.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
       
    End Sub

    Sub LoadConfig(ByVal FileName As String)
        _WebAuto.LoadConfiguration(FileName)
        BindDatagrid()
    End Sub

    Private Sub Save1Button_Click(sender As Object, e As EventArgs) Handles Save1Button.Click
        If _WebAuto.Configuration Is Nothing Then
            Exit Sub
        End If
        If _WebAuto.Configuration.ConfigFileName.Length = 0 Then
            SaveAsButton_Click(Nothing, Nothing)
        Else
            SaveConfiguration()
        End If
    End Sub


    Private Sub SaveAsButton_Click(sender As Object, e As EventArgs) Handles SaveAsButton.Click
        If _WebAuto.Configuration Is Nothing Then
            Exit Sub
        End If
        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.Title = "Save as ..."
        SaveFileDialog1.Filter = "Configuration(*." & _fileExtension & ")|*." & _fileExtension
        If _WebAuto.Configuration.ConfigFileName.Length = 0 Then
            SaveFileDialog1.FileName = _WebAuto.Configuration.Name & "." & _fileExtension
        Else
            SaveFileDialog1.FileName = _WebAuto.Configuration.ConfigFileName
        End If

        If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            _WebAuto.Configuration.ConfigFileName = SaveFileDialog1.FileName
            SaveConfiguration()
        End If
    End Sub

    Sub SaveConfiguration()
        Try
            _WebAuto.SaveConfiguration(_WebAuto.Configuration.ConfigFileName)
            'Me.Text = _ApplicationTitle & " - " & _xlAuto.Configuration.Name
            _WebAuto.Configuration.Saved = True
            Save1Button.ForeColor = Color.Blue
            MsgBox(_WebAuto.Configuration.ConfigFileName & " saved.")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error while saving ...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnAddProcess_Click(sender As Object, e As EventArgs) Handles BtnAddProcess.Click
        Try
            Me.BtnAddProcess.Enabled = False

            Me.BtnSave.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub AddProcess(ByVal _Process As Process)
        _WebAuto.Configuration.Processes.AddProcess(_Process)
        Clear()
    End Sub

    Private Sub Clear()
        TxtDescription.Text = String.Empty
        TxtTargetValue.Text = String.Empty
        TxtValue.Text = String.Empty
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BtnSave.Enabled = False
        cmbCmdList.DataSource = [Enum].GetValues(GetType(ActionPool.enumCommandType))
        'CmbTargetList.DataSource = [Enum].GetValues(GetType(ActionPool.enumTargetType))
    End Sub

    Private Sub BtnDeleteLang_Click(sender As Object, e As EventArgs) Handles BtnDeleteLang.Click
        If _WebAuto.Configuration.Processes.Count > 0 Then
            If _WebAuto.Configuration.Processes.DeleteProcess(DGV.CurrentCell.RowIndex) Then
                Modified()
                BindDatagrid()
            End If
        End If
    End Sub

    Sub Modified()
        _WebAuto.Configuration.Saved = False
        Me.Save1Button.ForeColor = Color.Red
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Me.BtnSave.Enabled = False
        Dim DT As New Process
        DT.Name = TxtDescription.Text

        DT.Action = New ActionPool
        DT.Action.CommandType = CType(cmbCmdList.SelectedIndex, ActionPool.enumCommandType)
        ' DT.Action.TargetType = CType(CmbTargetList.SelectedIndex, ActionPool.enumTargetType)
        DT.Action.Value = TxtValue.Text
        DT.Action.ID = TxtTargetValue.Text
        _WebAuto.Configuration.Processes.AddProcess(DT)
        Clear()
        Me.BtnAddProcess.Enabled = True
        BindDatagrid()
    End Sub

    Sub BindDatagrid()
        DGV.DataSource = Nothing
        DGV.DataSource = GetBindedDatatable()
        For Each dgvc As DataGridViewColumn In DGV.Columns
            dgvc.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Function GetBindedDatatable() As DataTable
        Dim dt As New DataTable

        Dim Command = New DataColumn("Command", GetType(String))
        Dim Target = New DataColumn("Target", GetType(String))
        Dim Value = New DataColumn("Value", GetType(String))

        dt.Columns.Add(Command)
        dt.Columns.Add(Target)
        dt.Columns.Add(Value)

        For Each objProcess In _WebAuto.Configuration.Processes
            dt.Rows.Add(objProcess.Action.CommandType, "ID:" & objProcess.Action.ID, objProcess.Action.Value)
        Next
        Return dt
    End Function

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Dim p As Process = _WebAuto.Configuration.Processes(DGV.CurrentCell.RowIndex)
        TxtDescription.Text = p.Name
        TxtTargetValue.Text = p.Action.ID
        TxtValue.Text = p.Action.Value
        cmbCmdList.Text = p.Action.CommandType.ToString
        'CmbTargetList.Text = p.Action.TargetType.ToString
    End Sub

    Private Sub ExecuteThisCommandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExecuteThisCommandToolStripMenuItem.Click
        Try
            _WebAuto.Execute(DGV.CurrentCell.RowIndex)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnUP_Click(sender As Object, e As EventArgs) Handles BtnUP.Click
        Dim fromPosition As Integer
        Dim toPosition As Integer
        fromPosition = DGV.CurrentCell.RowIndex

        toPosition = fromPosition - 1

        If toPosition = -1 Then
            Exit Sub
        End If
        _WebAuto.Configuration.Processes.MoveProcess(fromPosition, toPosition)
        BindDatagrid()
        DGV.CurrentCell.Selected = False
        DGV.Rows(toPosition).Selected = True
        DGV.CurrentCell = DGV.Rows(toPosition).Cells(0)
    End Sub

    Private Sub BtnDown_Click(sender As Object, e As EventArgs) Handles BtnDown.Click
        Dim fromPosition As Integer
        Dim toPosition As Integer
        fromPosition = DGV.CurrentCell.RowIndex

        toPosition = fromPosition + 1

        If toPosition > _WebAuto.Configuration.Processes.Count - 1 Then
            Exit Sub
        End If

        _WebAuto.Configuration.Processes.MoveProcess(fromPosition, toPosition)
        BindDatagrid()
        DGV.CurrentCell.Selected = False
        DGV.Rows(toPosition).Selected = True
        DGV.CurrentCell = DGV.Rows(toPosition).Cells(0)

    End Sub


    Private Sub ExecuteButton_Click(sender As Object, e As EventArgs) Handles ExecuteButton.Click
        If BW.IsBusy <> True Then
            BW.RunWorkerAsync()
        End If
    End Sub

    Private Sub BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        _WebAuto.Execute()
    End Sub

    Private Sub BW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW.RunWorkerCompleted
        If e.[Error] IsNot Nothing Then
            MsgBox(e.[Error].Message, MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class