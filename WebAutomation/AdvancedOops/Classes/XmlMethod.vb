Imports System.Xml.Serialization
Imports System.Text
Imports System.IO
Imports System.Xml
Public Class XMLMethod

    Public Function SaveXML(ByVal FileName As String, ByVal DataToSerialize As Object, ByVal objType As Type, ByVal encrypt As Boolean) As Boolean

        'set up a blank namespace to eliminate unnecessary junk from the xml 
        Dim nsBlank As New XmlSerializerNamespaces
        nsBlank.Add("", "")

        'create an object for the xml settings to control how the xml is written and appears 
        Dim xSettings As New System.Xml.XmlWriterSettings
        With xSettings
            .Encoding = Encoding.UTF8
            .Indent = True
            .NewLineChars = Environment.NewLine
            .NewLineOnAttributes = False
            .ConformanceLevel = Xml.ConformanceLevel.Document
        End With

        Try
            'Encrypted Save:
            If encrypt = True Then

                'Dim XmlS As XmlSerializer = New XmlSerializer(DataToSerialize.GetType)
                'Dim sw As New StringWriter
                'Dim tw As New XmlTextWriter(sw)
                'XmlS.Serialize(tw, DataToSerialize)

                'Using sr As New StreamWriter(FileName)
                '    sr.Write(CryptoZ.Encrypt(sw.ToString, "mykey"))
                'End Using
            Else

                'create the xmlwriter object that will write the file out 
                Dim xw As System.Xml.XmlWriter = Xml.XmlWriter.Create(FileName, xSettings)

                'create the xmlserializer that will serialize the object to XML 
                Dim writer As New XmlSerializer(objType)

                'now write it out 
                writer.Serialize(xw, DataToSerialize, nsBlank)

                'be sure to close it or it will remain open 
                xw.Close()

            End If

            Return True

        Catch ex As Exception
            Throw New Exception(ex.InnerException.Message)

        End Try


    End Function

    Public Function GetXML(ByVal sFileName As String, ByVal objType As Type, ByVal encrypt As Boolean) As Object

        If My.Computer.FileSystem.FileExists(sFileName) Then
            If encrypt = True Then

                Try

                    Using sr As New StreamReader(sFileName)
                        'tb is a textbox for viewing
                        Dim str As String = sr.ReadToEnd
                        'str = CryptoZ.Decrypt(sr.ReadToEnd, "mykey")
                        Dim mStrm As MemoryStream = New MemoryStream(Encoding.UTF8.GetBytes(str))
                        'Dim mStrm As MemoryStream = New MemoryStream(Encoding.Unicode.GetBytes(str))
                        Dim xs As XmlSerializer = New XmlSerializer(objType)
                        'Dim obj As Object = CType(xs.Deserialize(mStrm), Object)
                        Dim obj As Configuration = xs.Deserialize(mStrm)
                        Return obj
                    End Using
                Catch ex As Exception
                    Throw New Exception(ex.InnerException.Message)
                End Try
            Else
                Dim fs As FileStream = New FileStream(sFileName, FileMode.Open)
                Dim xs As XmlSerializer = New XmlSerializer(objType)
                Dim obj As Object = CType(xs.Deserialize(fs), Object)
                fs.Close()
                Return obj
            End If


        Else
            Return Nothing
        End If

    End Function

    Sub EncryptXML(ByVal sFileName As String, ByVal outFileName As String)
        EncryptDecryptXML(sFileName, outFileName, True)
    End Sub
    Sub DecryptXML(ByVal sFileName As String, ByVal outFileName As String)
        EncryptDecryptXML(sFileName, outFileName, False)
    End Sub
    Sub EncryptDecryptXML(ByVal sFileName As String, ByVal outFileName As String, ByVal encrypt As Boolean)
        Dim objXMLMethod As New XMLMethod
        Dim objConfig As Object
        Try
            'objConfig = objXMLMethod.GetXML(sFileName, GetType(ExcelAutomation.Configuration), Not encrypt)
            'objXMLMethod.SaveXML(outFileName, objConfig, GetType(ExcelAutomation.Configuration), encrypt)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


End Class
