Public Class WebAuto
    Implements IWebAuto

    Public Property Configuration As Configuration Implements IWebAuto.Configuration
        Get
            Return _configuration
        End Get
        Set(value As Configuration)
            _configuration = value
        End Set
    End Property
    Public Sub Execute() Implements IWebAuto.Execute
        Try
            _configuration.Execute()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Execute(ByVal Index As Integer)
        Try
            _configuration.Execute(Index)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private _configuration As Configuration
    Public Sub LoadConfiguration(fileName As String) Implements IWebAuto.LoadConfiguration

        Dim objXMl As New XMLMethod
        Try
            _configuration = objXMl.GetXML(fileName, GetType(Configuration), True)
        Catch ex As Exception
            Throw New Exception("Error while loading Configuratoin file" & vbNewLine & ex.Message)
        End Try
     
    End Sub

    Public Sub LoadNewConfiguration() Implements IWebAuto.LoadNewConfiguration
        _configuration = New Configuration
        _configuration.Name = "New Config"
    End Sub

    Public Sub SaveConfiguration() Implements IWebAuto.SaveConfiguration
        If _configuration.ConfigFileName.Length > 0 Then
            SaveConfiguration(_configuration.ConfigFileName)
        Else
            Throw New Exception("Configuration filename required")
        End If
    End Sub

    Public Sub SaveConfiguration(fileName As String) Implements IWebAuto.SaveConfiguration
        'Validations:
        '-------------
        Dim errorMsg As String = ""
        Dim commaSeperator As String = ""

        If fileName Is Nothing OrElse fileName.Trim.Length = 0 Then
            errorMsg &= commaSeperator & "File Name expected"
            commaSeperator = ", "
        End If
        If errorMsg.Length > 0 Then
            Throw New Exception("Validation Error: " & errorMsg)
        End If

        If Not fileName.Trim.ToLower.EndsWith(".config") Then
            fileName = fileName.Trim & ".config"
        End If


        Dim objXML As New XMLMethod
        objXML.SaveXML(fileName, _configuration, GetType(Configuration), False)
        _configuration.Saved = True

    End Sub

End Class
