Public Interface Iselenium

    Sub Naviage(ByVal Url As String)
    Sub SetTextByID(ByVal ID As String, ByVal Value As String, ByVal ErrMsg As String)
    Sub SetTextByXpathID(ByVal xPathId As String, ByVal Value As String, ByVal ErrMsg As String)
    Sub ClickByLinkText(ByVal LinkText As String, ByVal ErrMsg As String)
    Sub ClickByCSSelector(ByVal CssID As String, ByVal ErrMsg As String)
    Sub ClickByID(ByVal ID As String, ByVal ErrMsg As String)

    Enum BrowserType
        IE
        Chrome
        FireFox
    End Enum


End Interface
