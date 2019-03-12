Public Class ReflowAlarmInfoData
    Private c_RecordTime As DateTime?
    Public Property RecordTime() As DateTime?
        Get
            Return c_RecordTime
        End Get
        Set(ByVal value As DateTime?)
            c_RecordTime = value
        End Set
    End Property
    Private c_AlarmId As Integer
    Public Property AlarmId() As Integer
        Get
            Return c_AlarmId
        End Get
        Set(ByVal value As Integer)
            c_AlarmId = value
        End Set
    End Property
    Private c_ClearTime As DateTime?
    Public Property ClearTime() As DateTime?
        Get
            Return c_ClearTime
        End Get
        Set(ByVal value As DateTime?)
            c_ClearTime = value
        End Set
    End Property
End Class
