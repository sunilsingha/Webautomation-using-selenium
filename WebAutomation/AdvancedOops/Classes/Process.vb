Imports System.Xml.Serialization
Imports System.Text.RegularExpressions
<Serializable> _
Public Class Process
    Inherits BaseProperty

    Private _Skip As Boolean = False
    Property Skip As Boolean
        Get
            Return _Skip
        End Get
        Set(value As Boolean)
            _Skip = value
        End Set
    End Property

    Private _Action As ActionPool
    Property Action As ActionPool
        Get
            Return _Action
        End Get
        Set(value As ActionPool)
            _Action = value
        End Set
    End Property

    Public Sub Execute()
        Try

            Dim QA As QASelenium = SingletonBrowser.GetInstance

            Select Case _Action.CommandType
                Case ActionPool.enumCommandType.ClickByCSSelector
                    QA.ClickByCSSelector(_Action.ID, "Could not find ID: " & _Action.ID)
                Case ActionPool.enumCommandType.ClickByID
                    QA.ClickByID(_Action.ID, "Could not find ID: " & _Action.ID)
                Case ActionPool.enumCommandType.ClickByLinkText
                    QA.ClickByLinkText(_Action.ID, "Could not find ID: " & _Action.ID)
                Case ActionPool.enumCommandType.Navigate
                    QA.Naviage(_Action.Value)
                Case ActionPool.enumCommandType.SetTextByID
                    QA.SetTextByID(_Action.ID, _Action.Value, "Could not find ID: " & _Action.ID)
                Case ActionPool.enumCommandType.SetTextByXpathID
                    QA.SetTextByXpathID(_Action.ID, _Action.Value, "Could not find ID: " & _Action.ID)
                Case ActionPool.enumCommandType.CopyTextByID

            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

End Class

Public Class SingletonBrowser
    Public Shared MyBrowser As QASelenium 'Singleton implementation

    Public Shared Function GetInstance() As QASelenium
        If MyBrowser Is Nothing Then
            MyBrowser = New QASelenium(QASelenium.BrowserType.Chrome)
        End If
        Return MyBrowser
    End Function
End Class


Public Class ActionPool
    Public Enum enumCommandType
        Navigate
        ClickByID
        ClickByLinkText
        ClickByCSSelector
        SetTextByID
        SetTextByXpathID
        CopyTextByID
    End Enum

    'Public Enum enumTargetType
    '    ID
    '    'Xpath
    '    'CSS
    '    'None
    'End Enum

    Public Property CommandType As enumCommandType = enumCommandType.Navigate
    'Public Property TargetType As enumTargetType = enumTargetType.ID
    'Public Property TargetValue As String = ""
    Public Property Value As String = ""
    Public Property ID As String = ""
End Class


''' <summary>
''' Idea is to clean the index everytime when Add,Insert and Delete command is run
''' </summary>
''' <remarks></remarks>
Public Class ListProcess

    Inherits System.Collections.Generic.List(Of Process)

    Public Function AddProcess(ByVal _process As Process) As Boolean
        Try
            MyBase.Add(_process)
            CleanIndex()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function

    Sub MoveProcess(ByVal fromPosition As Integer, ByVal toPosition As Integer)
        Dim tmpProcess As Process
        tmpProcess = MyBase.Item(fromPosition)
        MyBase.RemoveAt(fromPosition)
        MyBase.Insert(toPosition, tmpProcess)
        CleanIndex()
    End Sub

    Public Function InsertProcessAt(ByVal Index As Integer, ByVal _process As Process) As Boolean
        Try
            MyBase.Insert(Index, _process)
            CleanIndex()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function

    Public Function DeleteProcess(ByVal Index As Integer) As Boolean
        Try
            Me.RemoveAll(Function(x) x.Index = Index)
            CleanIndex()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return True
    End Function

    Protected Sub CleanIndex()
        Try
            For i As Integer = 0 To Me.Count - 1
                Me(i).Index = i
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

End Class

