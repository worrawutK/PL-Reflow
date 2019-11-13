<Serializable()>
Public Class ReflowData
    Sub New()
        c_AlarmInfoDatas = New List(Of ReflowAlarmInfoData)
    End Sub
    Private c_AlarmInfoDatas As List(Of ReflowAlarmInfoData)
    Public Property AlarmInfoDatas() As List(Of ReflowAlarmInfoData)
        Get
            Return c_AlarmInfoDatas
        End Get
        Set(ByVal value As List(Of ReflowAlarmInfoData))
            c_AlarmInfoDatas = value
        End Set
    End Property
    Private _mcNum As String
    Public Property McNo() As String
        Get
            Return _mcNum
        End Get
        Set(ByVal value As String)
            _mcNum = value
        End Set
    End Property

    Private _OpNum As String
    Public Property OpNo() As String
        Get
            Return _OpNum
        End Get
        Set(ByVal value As String)
            _OpNum = value
        End Set
    End Property

    Private _lotNum As String
    Public Property LotNo() As String
        Get
            Return _lotNum
        End Get
        Set(ByVal value As String)
            _lotNum = value
        End Set
    End Property

    Private _Devic As String
    Public Property Device() As String
        Get
            Return _Devic
        End Get
        Set(ByVal value As String)
            _Devic = value
        End Set
    End Property

    Private _Packag As String
    Public Property Package() As String
        Get
            Return _Packag
        End Get
        Set(ByVal value As String)
            _Packag = value
        End Set
    End Property

    Private _inPcs As Integer
    Public Property Input() As Integer
        Get
            Return _inPcs
        End Get
        Set(ByVal value As Integer)
            _inPcs = value
        End Set
    End Property

    Private _outPcs As Integer
    Public Property Output() As Integer
        Get
            Return _outPcs
        End Get
        Set(ByVal value As Integer)
            _outPcs = value
        End Set
    End Property

    Private _NGQty As Integer
    Public Property NGQty() As Integer
        Get
            Return _NGQty
        End Get
        Set(ByVal value As Integer)
            _NGQty = value
        End Set
    End Property

    Private _pcs_frmstr As Integer
    Public Property Pcs_frm() As Integer
        Get
            Return _pcs_frmstr
        End Get
        Set(ByVal value As Integer)
            _pcs_frmstr = value
        End Set
    End Property

    Private _startT As String
    Public Property StartTime() As String
        Get
            Return _startT
        End Get
        Set(ByVal value As String)
            _startT = value
        End Set
    End Property

    Private _stopT As String
    Public Property StopTime() As String
        Get
            Return _stopT
        End Get
        Set(ByVal value As String)
            _stopT = value
        End Set
    End Property

    Private _IPAddr As String

    Public Property IPA() As String
        Get
            Return _IPAddr
        End Get
        Set(ByVal value As String)
            _IPAddr = value
        End Set
    End Property

    Private _data As String
    Public Property LotData() As String
        Get
            Return _data
        End Get
        Set(ByVal value As String)
            _data = value
        End Set
    End Property

    Private _lotInfor As String
    Public Property LotInform() As String
        Get
            Return _lotInfor
        End Get
        Set(ByVal value As String)
            _lotInfor = value
        End Set
    End Property

    Private _Status As Integer
    Public Property LotStatus() As Integer
        Get
            Return _Status
        End Get
        Set(ByVal value As Integer)
            _Status = value
        End Set
    End Property

    Private _TimeCountRun As Integer
    Public Property TimeCountRun() As Integer
        Get
            Return _TimeCountRun
        End Get
        Set(ByVal value As Integer)
            _TimeCountRun = value
        End Set
    End Property

    Private _TimeCountStop As Integer
    Public Property TimeCountStop() As Integer
        Get
            Return _TimeCountStop
        End Get
        Set(ByVal value As Integer)
            _TimeCountStop = value
        End Set
    End Property

    Private _TimeCountAlarm As Integer
    Public Property TimeCountAlarm() As Integer
        Get
            Return _TimeCountAlarm
        End Get
        Set(ByVal value As Integer)
            _TimeCountAlarm = value
        End Set
    End Property

    Private _Group As String
    Public Property Group() As String
        Get
            Return _Group
        End Get
        Set(ByVal value As String)
            _Group = value
        End Set
    End Property

    Private _Remark As String
    Public Property Remark() As String
        Get
            Return _Remark
        End Get
        Set(ByVal value As String)
            _Remark = value
        End Set
    End Property

    Private _MagazineNo As String
    Public Property MagazineNo() As String
        Get
            Return _MagazineNo
        End Get
        Set(ByVal value As String)
            _MagazineNo = value
        End Set
    End Property

    Private _UnloadMagazineNo As String
    Public Property UnloadMagazineNo() As String
        Get
            Return _UnloadMagazineNo
        End Get
        Set(ByVal value As String)
            _UnloadMagazineNo = value
        End Set
    End Property

    Private _LbPageBG As String
    Public Property LbPageBG() As String
        Get
            Return _LbPageBG
        End Get
        Set(ByVal value As String)
            _LbPageBG = value
        End Set
    End Property

    'Private AlmID As Integer
    'Public Property AlarmID() As Integer
    '    Get
    '        Return AlmID
    '    End Get
    '    Set(ByVal value As Integer)
    '        AlmID = value
    '    End Set
    'End Property

    'Private AlarmNoData As String
    'Public Property AlarmNo() As String
    '    Get
    '        Return AlarmNoData
    '    End Get
    '    Set(ByVal value As String)
    '        AlarmNoData = value
    '    End Set
    'End Property

    Private AlarmTotalData As Integer
    Public Property AlarmTotal() As Integer
        Get
            Return AlarmTotalData
        End Get
        Set(ByVal value As Integer)
            AlarmTotalData = value
        End Set
    End Property

    Private _LotStartMode As Integer
    Public Property LotStartMode() As Integer
        Get
            Return _LotStartMode
        End Get
        Set(ByVal value As Integer)
            _LotStartMode = value
        End Set
    End Property

    Private _LotEndMode As Integer
    Public Property LotEndMode() As Integer
        Get
            Return _LotEndMode
        End Get
        Set(ByVal value As Integer)
            _LotEndMode = value
        End Set
    End Property

    Private _LotSetOfSending As Boolean
    Public Property LotSetOfSending() As Boolean
        Get
            Return _LotSetOfSending
        End Get
        Set(ByVal value As Boolean)
            _LotSetOfSending = value
        End Set
    End Property

    Private _LeqLock As Integer
    Public Property LeqLock() As Integer
        Get
            Return _LeqLock
        End Get
        Set(ByVal value As Integer)
            _LeqLock = value
        End Set
    End Property

    Private c_CellConState As Integer
    Public Property CellConState() As Integer
        Get
            Return c_CellConState
        End Get
        Set(ByVal value As Integer)
            c_CellConState = value
        End Set
    End Property
End Class
Public Class TDCInfo
    Private _isPass As Boolean
    Public Property IsPass() As Boolean
        Get
            Return _isPass
        End Get
        Set(ByVal value As Boolean)
            _isPass = value
        End Set
    End Property

    Private _ErrorMessage As String
    Public Property ErrorMessage() As String
        Get
            Return _ErrorMessage
        End Get
        Set(ByVal value As String)
            _ErrorMessage = value
        End Set
    End Property
    Private _ErrorCode As String
    Public Property ErrorCode() As String
        Get
            Return _ErrorCode
        End Get
        Set(ByVal value As String)
            _ErrorCode = value
        End Set
    End Property
End Class
