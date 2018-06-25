Module Module1

    Public m_SelfData As New ReflowData
    'Public m_01 As Boolean
    'Public m_02 As Boolean
    'Public m_03 As Boolean
    'Public m_04 As Boolean
    'Public m_05 As Boolean
    'Public m_06 As Boolean
    'Public m_70 As Boolean
    'Public m_71 As Boolean
    'Public m_72 As Boolean
    'Public m_99 As Boolean
    ' Public m_Offline As Integer

    Enum _StatusLot
        LotSetup = 1
        LotStart = 2
        LotAlarm = 3
        LotEnd = 4
        LotStop = 5
    End Enum

    Enum _SelfConMode
        Online
        Offline
    End Enum

    Enum _EquipmentState
        LOCK
        Unlock
    End Enum

    Enum _TDCMode
        NormalInput = 0
        Separated = 1
        SeparationEnd = 2

        NormalEnd = 1
        Reload = 3
        ReInput = 2
    End Enum




End Module

