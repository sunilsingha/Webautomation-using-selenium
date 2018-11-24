

Imports OpenQA.Selenium
Imports OpenQA.Selenium.Support
Imports OpenQA.Selenium.IE
Imports AdvancedOops

<TestClass()> Public Class TestWebAuto


    'Dim ieLocation As String = "C:\Sunil backup\SAP Projects\CopyPaste IE Automation\WebAutomation\packages\Selenium.WebDriver.IEDriver64.2.48.0.1\driver\IEDriverServer64.exe"
    'Dim opt As InternetExplorerOptions

    'Private Property wb As Object

    '<TestInitialize> Public Sub Initialize()
    '    opt.InitialBrowserUrl = "https://pmsalesdemo8.successfactors.com/login"
    '    opt.IntroduceInstabilityByIgnoringProtectedModeSettings = True
    '    Dim wb = New InternetExplorerDriver(ieLocation, opt)
    '    wb.Navigate()
    'End Sub



    ''<TestMethod> Public Sub Login()
    ''    ' wb.FindElement(By.Id("company")).SendKeys("NGDP2MTRANS")
    ''End Sub

    ''<TestCleanup> Public Sub clean()
    ''    wb.Quit()
    ''End Sub

    Dim rootfolder As String = "C:\Users\C5195092\Desktop\ios\test.config"


    <TestMethod> _
    Sub TestMethod1()

        Dim xm As New XMLMethod

        Dim config As New Configuration

        Dim DT As New Process
        DT.Name = "Navigate to SFSF"
        DT.Action = New ActionPool

        DT.Action.CommandType = ActionPool.enumCommandType.Navigate
        ' DT.Action.TargetType = ActionPool.enumTargetType.None
        DT.Action.Value = "https://pmsalesdemo8.successfactors.com/"
        config.Processes.AddProcess(DT)


        DT = New Process
        DT.Name = "Enter Company"
        DT.Action = New ActionPool
        DT.Action.CommandType = ActionPool.enumCommandType.SetTextByID
        ' DT.Action.TargetType = ActionPool.enumTargetType.ID
        DT.Action.ID = "company"
        DT.Action.Value = "NGDP2MTRANS"
        config.Processes.AddProcess(DT)

        DT = New Process
        DT.Name = "Enter username"
        DT.Action = New ActionPool
        DT.Action.CommandType = ActionPool.enumCommandType.SetTextByID
        ' DT.Action.TargetType = ActionPool.enumTargetType.ID
        DT.Action.ID = "username"
        DT.Action.Value = "sfadmin"
        config.Processes.AddProcess(DT)

        DT = New Process
        DT.Name = "Click on password"
        DT.Action = New ActionPool
        DT.Action.CommandType = ActionPool.enumCommandType.ClickByID
        ' DT.Action.TargetType = ActionPool.enumTargetType.ID
        DT.Action.ID = "passwordHints"
        config.Processes.AddProcess(DT)

        DT = New Process
        DT.Name = "Enter Login"
        DT.Action = New ActionPool
        DT.Action.CommandType = ActionPool.enumCommandType.SetTextByXpathID
        ' DT.Action.TargetType = ActionPool.enumTargetType.Xpath
        DT.Action.ID = "//*[@id='password']"
        DT.Action.Value = "saphrngd"
        config.Processes.AddProcess(DT)

        DT = New Process
        DT.Name = "Click on Login button"
        DT.Action = New ActionPool
        DT.Action.CommandType = ActionPool.enumCommandType.ClickByID
        '  DT.Action.TargetType = ActionPool.enumTargetType.ID
        DT.Action.ID = "loginSubmitBtn"
        config.Processes.AddProcess(DT)

        config.Name = "test"
        config.RootFolderPath = rootfolder

        xm.SaveXML(config.RootFolderPath, config, GetType(Configuration), False)

        Dim objConfig As New Configuration

        objConfig = xm.GetXML(rootfolder, GetType(Configuration), True)

        objConfig.Execute()

        Assert.AreEqual(False, objConfig.CheckIndex)

    End Sub

    <TestMethod> _
    Sub TestAddNewConfiguration()
        Dim objWebAuto As New WebAuto
        objWebAuto.LoadNewConfiguration()

        objWebAuto.Configuration.ConfigFileName = rootfolder
        objWebAuto.SaveConfiguration()

    End Sub

End Class