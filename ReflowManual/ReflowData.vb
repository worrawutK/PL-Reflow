
Public Class ReflowClass

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
    Private _inPcs As String
    Public Property Input() As String
        Get
            Return _inPcs
        End Get
        Set(ByVal value As String)
            _inPcs = value
        End Set
    End Property
    Private _outPcs As String

    Public Property Output() As String
        Get
            Return _outPcs
        End Get
        Set(ByVal value As String)
            _outPcs = value
        End Set
    End Property
    Private _pcs_frmstr As String
    Public Property Pcs_frm() As String
        Get
            Return _pcs_frmstr
        End Get
        Set(ByVal value As String)
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
    Private _order As Integer
    Public Property Order() As String
        Get
            Return _order
        End Get
        Set(ByVal value As String)
            _order = value
        End Set
    End Property
    Private _Status As String
    Public Property LotStatus() As String
        Get
            Return _Status
        End Get
        Set(ByVal value As String)
            _Status = value
        End Set
    End Property
    Private _TimeCountRun As Integer
    Public Property TimeCountRun() As String
        Get
            Return _TimeCountRun
        End Get
        Set(ByVal value As String)
            _TimeCountRun = value
        End Set
    End Property
    Private _TimeCountStop As Integer
    Public Property TimeCountStop() As String
        Get
            Return _TimeCountStop
        End Get
        Set(ByVal value As String)
            _TimeCountStop = value
        End Set
    End Property
    Private _TimeCountAlarm As Integer
    Public Property TimeCountAlarm() As String
        Get
            Return _TimeCountAlarm
        End Get
        Set(ByVal value As String)
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

    Private _CheckReload As Integer
    Public Property CheckReload() As String
        Get
            Return _CheckReload
        End Get
        Set(ByVal value As String)
            _CheckReload = value
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
    Private AlarmMes As String
    Public Property AlarmMessage() As String
        Get
            Return AlarmMes
        End Get
        Set(ByVal value As String)
            AlarmMes = value
        End Set
    End Property

    Private AlmID As String
    Public Property AlarmID() As String
        Get
            Return AlmID
        End Get
        Set(ByVal value As String)
            AlmID = value
        End Set
    End Property

    Private AlarmNoData As String
    Public Property AlarmNo() As String
        Get
            Return AlarmNoData
        End Get
        Set(ByVal value As String)
            AlarmNoData = value
        End Set
    End Property

    Private AlarmTotalData As Integer
    Public Property AlarmTotal() As Integer
        Get
            Return AlarmTotalData
        End Get
        Set(ByVal value As Integer)
            AlarmTotalData = value
        End Set
    End Property


    Public Sub DataClear()
        OpNo = ""
        LotNo = ""
        Package = ""
        Device = ""
        StartTime = ""
        StopTime = ""
        Input = "0"
        Output = "0"
        LotData = ""
        Pcs_frm = "0"
        LotInform = ""
        Group = ""
        Remark = ""
        MagazineNo = ""
        CheckReload = 0
        LbPageBG = ""
        LotStatus = "LOTREQUEST"

    End Sub


End Class
