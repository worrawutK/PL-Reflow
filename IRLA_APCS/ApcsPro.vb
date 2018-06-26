Imports iLibrary
Imports Rohm.Common.Logging
<Serializable()>
Public Class ApcsPro
#Region "Apcs_Pro Valiable"
    Private c_LotNo As String
    Public Property LotNo() As String
        Get
            Return c_LotNo
        End Get
        Set(ByVal value As String)
            c_LotNo = value
        End Set
    End Property
    Private c_UserCode As String
    Public Property UserCode() As String
        Get
            Return c_UserCode
        End Get
        Set(ByVal value As String)
            c_UserCode = value
        End Set
    End Property
    Private c_MachineNo As String
    Public Property MachineNo() As String
        Get
            Return c_MachineNo
        End Get
        Set(ByVal value As String)
            c_MachineNo = value
        End Set
    End Property
    Private c_Recipe As String
    Public Property Recipe() As String
        Get
            Return c_Recipe
        End Get
        Set(ByVal value As String)
            c_Recipe = value
        End Set
    End Property
    'Private c_LotInfo As LotInfo
    'Public Property LotInfo() As LotInfo
    '    Get
    '        Return c_LotInfo
    '    End Get
    '    Set(ByVal value As LotInfo)
    '        c_LotInfo = value
    '    End Set
    'End Property
    'Private c_MachineInfo As MachineInfo
    'Public Property MachineInfo() As MachineInfo
    '    Get
    '        Return c_MachineInfo
    '    End Get
    '    Set(ByVal value As MachineInfo)
    '        c_MachineInfo = value
    '    End Set
    'End Property
    'Private c_UserInfo As UserInfo
    'Public Property UserInfo() As UserInfo
    '    Get
    '        Return c_UserInfo
    '    End Get
    '    Set(ByVal value As UserInfo)
    '        c_UserInfo = value
    '    End Set
    'End Property
    'Private c_Log As Logger = New Logger()
    'Public Property Log() As Logger
    '    Get
    '        Return c_Log
    '    End Get
    '    Set(ByVal value As Logger)
    '        c_Log = value
    '    End Set
    'End Property
    'Private c_ApcsProService As IApcsProService = New ApcsProService()
    'Public Property ApcsProService() As IApcsProService
    '    Get
    '        Return c_ApcsProService
    '    End Get
    '    Set(ByVal value As IApcsProService)
    '        c_ApcsProService = value
    '    End Set
    'End Property
    'Private c_DateTimeInfo As DateTimeInfo
    'Public Property DateTimeInfo() As DateTimeInfo
    '    Get
    '        Return c_DateTimeInfo
    '    End Get
    '    Set(ByVal value As DateTimeInfo)
    '        c_DateTimeInfo = value
    '    End Set
    'End Property
    Private c_PackageEnable As String
    Public Property PackageEnable() As String
        Get
            Return c_PackageEnable
        End Get
        Set(ByVal value As String)
            c_PackageEnable = value
        End Set
    End Property
    'Private c_LotUpdateInfo As LotUpdateInfo
    'Public Property LotUpdateInfo() As LotUpdateInfo
    '    Get
    '        Return c_LotUpdateInfo
    '    End Get
    '    Set(ByVal value As LotUpdateInfo)
    '        c_LotUpdateInfo = value
    '    End Set
    'End Property
#End Region
End Class
