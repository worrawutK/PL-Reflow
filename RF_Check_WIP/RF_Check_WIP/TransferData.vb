Public Class TransferData
    Private c_LotNo As String
    Public Property LotNo() As String
        Get
            Return c_LotNo
        End Get
        Set(ByVal value As String)
            c_LotNo = value
        End Set
    End Property
    Private c_CartNo As String
    Public Property CartNo() As String
        Get
            Return c_CartNo
        End Get
        Set(ByVal value As String)
            c_CartNo = value
        End Set
    End Property
    Private c_LotStartTime As Date
    Public Property LotStartTime() As Date
        Get
            Return c_LotStartTime
        End Get
        Set(ByVal value As Date)
            c_LotStartTime = value
        End Set
    End Property
    Private c_LotEndTime As String
    Public Property LotEndTime() As String
        Get
            Return c_LotEndTime
        End Get
        Set(ByVal value As String)
            c_LotEndTime = value
        End Set
    End Property
End Class
