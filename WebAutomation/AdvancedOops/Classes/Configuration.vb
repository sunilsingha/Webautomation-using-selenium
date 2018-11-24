Imports System.Xml.Serialization
<Serializable> _
Public Class Configuration
    Inherits BaseProperty
    Implements IConfigProperties

    Private _Processes As ListProcess = New ListProcess
    Property Processes As ListProcess
        Get
            Return _Processes
        End Get
        Set(value As ListProcess)
            _Processes = value
        End Set
    End Property


    Public Sub Execute()
        Dim objprocess As Process
        For Each objprocess In _Processes
            objprocess.Execute()
        Next
    End Sub

    Public Sub Execute(ByVal Index As Integer)
        Dim objprocess As Process
        For Each objprocess In _Processes
            If objprocess.Index = Index Then
                objprocess.Execute()
            End If
        Next
    End Sub

   
    Private _RootFolderPath As String = ""
    Public Property RootFolderPath As String Implements IConfigProperties.RootFolderPath
        Get
            Return _RootFolderPath
        End Get
        Set(value As String)
            _RootFolderPath = value
            Modified()
        End Set
    End Property

    Public Function CheckIndex() As Boolean
        Try
            For i As Integer = 0 To _Processes.Count - 1
                If _Processes(i).Index <> i Then
                    Return False
                End If
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function

    Private _ConfigFileName As String = String.Empty
    Property ConfigFileName As String
        Get
            Return _ConfigFileName
        End Get
        Set(value As String)
            _ConfigFileName = value
        End Set
    End Property

    Private _Saved As Boolean = True
    'should not be saved:
    <XmlIgnore()> _
    Property Saved() As Boolean
        Get
            Return _Saved
        End Get
        Set(ByVal value As Boolean)
            _Saved = value
            If value = False Then
                _Validated = False
            End If
        End Set
    End Property

    Private _Validated As Boolean = False
    Property Validated() As Boolean
        Get
            Return _Validated
        End Get
        Set(ByVal value As Boolean)
            _Validated = value
            Modified()

        End Set
    End Property

End Class

Public Interface IConfigProperties
    Property RootFolderPath() As String
    'Property DisplayWorkSheetsDuringProcess() As Boolean
    'ReadOnly Property ConfigProtected() As Boolean
    'Property DisplayLog() As Boolean
    'Property WriteLog() As Boolean
    ''Property LogRowWiseActions() As Boolean
    'Property LogDataElementValues() As Boolean
    'Property LogTimeOfExecution() As Boolean
End Interface
