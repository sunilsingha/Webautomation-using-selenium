Imports System.Windows.forms
Imports mshtml

Public Class WebAuto

    Public Shared WithEvents WB As WebBrowser

    Private Shared _DocCompleted As Boolean = False

    Public Shared Function GetInstance() As WebBrowser
        If WB Is Nothing Then
            WB = New WebBrowser
            WB.ScriptErrorsSuppressed = True
        End If
        Return WB
    End Function


    Public Shared Sub Navigate(ByVal Url As String)
        Try
            GetInstance()
            WB.Navigate(Url)
            PerformEvents()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Shared Sub PerformEvents()
        Try
            Do While (WB.ReadyState <> WebBrowserReadyState.Complete Or WB.IsBusy = True)
                Application.DoEvents()
            Loop
        Catch ex As Exception
            Throw New Exception("@PerFormEvents" & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Shared Sub WaitForDocumenCompeted()
        Do While _DocCompleted = False
            Application.DoEvents()
            System.Threading.Thread.Sleep(200)
        Loop

    End Sub

    ''' <summary>
    ''' Input text in textbox control
    ''' </summary>
    ''' <param name="TextToInput"></param>
    ''' <param name="InputBoxID"></param>
    ''' <param name="AttributeID"></param>
    ''' <remarks></remarks>
    Public Shared Sub TextToInputBox(ByVal TextToInput As String, ByVal InputBoxID As String, ByVal AttributeID As String)
        Try

            GetInstance()

            Dim textElement As HtmlElement = WB.Document.All.GetElementsByName(InputBoxID)(0)

            textElement.SetAttribute(AttributeID, TextToInput)

            textElement.Focus()

            SendKeys.SendWait("{TAB}")

            PerformEvents()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Shared Sub ClickButton(ByVal ButtonId As String)
        Try

            _DocCompleted = False

            GetInstance()

            WB.Document.GetElementById(ButtonId).InvokeMember("click")

            PerformEvents()

            WaitForDocumenCompeted()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Shared Sub SelectItemFromList(ByVal ID As String)
        Try
            _DocCompleted = False

            Dim h As HtmlElement = WB.Document.GetElementById(ID)

            'For Each Helement In WB.Document.GetElementById(ID)
            '    Debug.Print(Helement.id)
            '    If Helement.name = "id" Then

            '    End If
            'Next

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Shared Sub WB_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WB.DocumentCompleted
        _DocCompleted = True
    End Sub

End Class
