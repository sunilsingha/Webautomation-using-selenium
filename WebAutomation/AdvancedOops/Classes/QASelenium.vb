Imports OpenQA.Selenium
Imports OpenQA.Selenium.Support
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Firefox
Imports System.Text
Imports System
Imports System.Linq
Imports System.Collections.Generic


Public Class QASelenium

    Implements Iselenium

    Public Enum BrowserType
        IE
        Chrome
        FireFox
    End Enum


    Private driver As IWebDriver


    Public Sub New(Optional ByVal BT As BrowserType = BrowserType.IE)
        Select Case BT
            Case BrowserType.Chrome
                driver = New ChromeDriver
            Case BrowserType.FireFox
                driver = New FirefoxDriver
            Case BrowserType.IE
                'driver = New InternetExplorerDriver
        End Select
    End Sub


    Public Sub ClickByCSSelector(CssID As String, ErrMsg As String) Implements Iselenium.ClickByCSSelector
        Try
            driver.FindElement(By.CssSelector(CssID)).Click()
            driver.Manage.Timeouts.ImplicitlyWait(TimeSpan.FromSeconds(10))
        Catch ex As Exception
            Throw New Exception(ErrMsg & vbNewLine & ex.Message)
        End Try
    End Sub

    Public Sub ClickByID(ID As String, ErrMsg As String) Implements Iselenium.ClickByID
        Try
            driver.FindElement(By.Id(ID)).Click()
            driver.Manage.Timeouts.ImplicitlyWait(TimeSpan.FromSeconds(10))
        Catch ex As Exception
            Throw New Exception(ErrMsg & vbNewLine & ex.Message)
        End Try
    End Sub

    Public Sub ClickByLinkText(LinkText As String, ErrMsg As String) Implements Iselenium.ClickByLinkText
        Try
            driver.FindElement(By.LinkText(LinkText)).Click()
            driver.Manage.Timeouts.ImplicitlyWait(TimeSpan.FromSeconds(10))
        Catch ex As Exception
            Throw New Exception(ErrMsg & vbNewLine & ex.Message)
        End Try
    End Sub

    Public Sub Naviage(Url As String) Implements Iselenium.Naviage
        Try
            driver.Navigate.GoToUrl(Url)
            driver.Manage.Timeouts.ImplicitlyWait(TimeSpan.FromSeconds(10))
        Catch ex As Exception
            Throw New Exception("Cannot Navigat to Url: " & Url & vbNewLine & ex.Message)
        End Try
    End Sub

    Public Sub SetTextByID(ID As String, Value As String, ErrMsg As String) Implements Iselenium.SetTextByID
        Try
            driver.FindElement(By.Id(ID)).SendKeys(Value)
            driver.Manage.Timeouts.ImplicitlyWait(TimeSpan.FromSeconds(10))
        Catch ex As Exception
            Throw New Exception(ErrMsg & vbNewLine & ex.Message)
        End Try
    End Sub

    Public Sub SetTextByXpathID(xPathId As String, Value As String, ErrMsg As String) Implements Iselenium.SetTextByXpathID
        Try
            driver.FindElement(By.XPath(xPathId)).SendKeys(Value)
            driver.Manage.Timeouts.ImplicitlyWait(TimeSpan.FromSeconds(10))
        Catch ex As Exception
            Throw New Exception(ErrMsg & vbNewLine & ex.Message)
        End Try
    End Sub


    Private Function IsAlertPresent() As Boolean
        Try
            driver.SwitchTo().Alert()
            Return True
        Catch generatedExceptionName As NoAlertPresentException
            Return False
        End Try
    End Function

    Private acceptNextAlert As Boolean = True

    Private Function CloseAlertAndGetItsText() As String
        Try
            Dim alert As IAlert = driver.SwitchTo().Alert()
            Dim alertText As String = alert.Text
            If acceptNextAlert Then
                alert.Accept()
            Else
                alert.Dismiss()
            End If
            Return alertText
        Finally
            acceptNextAlert = True
        End Try
    End Function

End Class
