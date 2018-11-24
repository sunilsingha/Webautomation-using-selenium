Public Interface IWebAuto
    Sub LoadConfiguration(ByVal fileName As String)
    Sub SaveConfiguration()
    Sub SaveConfiguration(ByVal fileName As String)
    Sub LoadNewConfiguration()
    Sub Execute()
    Property Configuration() As Configuration
End Interface

