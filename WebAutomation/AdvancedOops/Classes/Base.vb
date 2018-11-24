Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Public Class Base
    Implements INotifyPropertyChanged
    Implements ICloneable

    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

    Protected Function CheckPropertyChanged(Of T)(ByVal propertyName As String, ByRef oldValue As T, ByRef newValue As T) As Boolean
        If oldValue Is Nothing AndAlso newValue Is Nothing Then
            Return False
        End If

        If (oldValue Is Nothing AndAlso newValue IsNot Nothing) OrElse Not oldValue.Equals(DirectCast(newValue, T)) Then
            oldValue = newValue
            Modified(propertyName)
            Return True
        End If

        Return False
    End Function

    Protected Sub Modified()
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(""))
    End Sub

    Protected Sub Modified(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
    Public Overridable Function Clone() As Object Implements System.ICloneable.Clone
        Return MyBase.MemberwiseClone()
    End Function

End Class
