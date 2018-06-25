Imports iLibrary
Imports Rohm.Common.Logging
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
    Private c_UserInfo As String
    Public Property UserCode() As String
        Get
            Return c_UserInfo
        End Get
        Set(ByVal value As String)
            c_UserInfo = value
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

#End Region
End Class
