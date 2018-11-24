<Serializable()> _
Public Class BaseProperty
    Inherits Base

    Private _Index As Integer
    Property Index As Integer
        Get
            Return _Index
        End Get
        Set(value As Integer)
            _Index = value
        End Set
    End Property

    Private _Name As String = ""
    Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
            Modified()
        End Set
    End Property
End Class

