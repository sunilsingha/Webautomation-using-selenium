Imports WebAutomation

Public Class Form1

    'Public Sub New()

    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.




    '    Me.SuspendLayout()
    '    '
    '    'WebBrowser1
    '    '
    '    WebAuto.GetInstance()
    '    WebAuto.WB.Location = New System.Drawing.Point(80, 12)
    '    WebAuto.WB.MinimumSize = New System.Drawing.Size(20, 20)
    '    WebAuto.WB.Name = "WebBrowser1"
    '    WebAuto.WB.Size = New System.Drawing.Size(922, 390)
    '    WebAuto.WB.TabIndex = 0
    '    '
    '    'Form1
    '    '
    '    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    '    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    '    Me.ClientSize = New System.Drawing.Size(1123, 435)
    '    Me.Controls.Add(WebAuto.WB)
    '    Me.Name = "Form1"
    '    Me.Text = "Form1"
    '    Me.ResumeLayout(False)

    'End Sub


    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Try
    '        Me.Button1.Enabled = False
    '        Me.Cursor = Cursors.WaitCursor
    '        WebAuto.Navigate("https://pmsalesdemo8.successfactors.com/login")
    '        WebAuto.TextToInputBox("NGDP2MTRANS", "company", "value")
    '        WebAuto.TextToInputBox("sfadmin", "username", "value")
    '        WebAuto.TextToInputBox("saphrngd", "password", "value")
    '        WebAuto.ClickButton("loginSubmitBtn")
    '        WebAuto.Navigate("https://pmsalesdemo8.successfactors.com/sf/admin?bplte_company=NGDP2MTRANS&_s.crb=uv5zc8cM9cHV16vRkXaSQA0IWyo%3d")


    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    Finally
    '        Me.Button1.Enabled = True
    '        Me.Cursor = Cursors.Default
    '    End Try


    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    WebAuto.Navigate("https://pmsalesdemo8.successfactors.com/acme?fbacme_o=admin&ap_param_action=form_routing_map&pess_old_admin=true&_s.crb=uv5zc8cM9cHV16vRkXaSQA0IWyo%253d&")
    '    WebAuto.Navigate("https://pmsalesdemo8.successfactors.com/acme?&bplte_company=NGDP2MTRANS&fbacme_o=admin&ap_param_action=form_routing_map&pess_old_admin=true&view=list&_s.crb=uv5zc8cM9cHV16vRkXaSQA0IWyo%3d")
    'End Sub
End Class
