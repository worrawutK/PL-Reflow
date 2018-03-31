
Public Class TmpTDC

    Private _startT As String
    Public Property StartTime() As String
        Get
            Return _startT
        End Get
        Set(ByVal value As String)
            _startT = value
        End Set
    End Property

End Class
