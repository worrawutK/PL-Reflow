Option Strict Off
Imports System.Text
Imports System.Net
Imports System.Net.Sockets


Public Class UDPSocket

    Public Event ListeningStatusChanged(ByVal e As Boolean)

    Private sendbuf As Byte()


    Private objRecvUDP As UdpClient

    Private objSendUDP As UdpClient

    Private groupEP As IPEndPoint
    Private recvBytes As Byte()

    Private _IsListening As Boolean
    Public ReadOnly Property IsListening() As Boolean
        Get
            Return _IsListening
        End Get
    End Property

    Private _LocalPort As Integer
    Public Property LocalPort() As Integer
        Get

            Return Me._LocalPort
        End Get
        Set(ByVal value As Integer)
            Me._LocalPort = value
        End Set
    End Property


    Private _RemotePort As Integer
    Public Property RemotePort() As Integer
        Get
            Return Me._RemotePort
        End Get
        Set(ByVal value As Integer)
            Me._RemotePort = value
        End Set
    End Property


    Private _RemoteHost As String
    Public Property RemoteHost() As String
        Get
            Return Me._RemoteHost
        End Get
        Set(ByVal value As String)
            Me._RemoteHost = value
        End Set
    End Property

    Private Sub InitialVariables()

        Me._RemoteHost = ""
        Me._RemotePort = 5720
        Me._LocalPort = 5720
        'we must not set the localport to this object
        Me.objSendUDP = New UdpClient()


        'เราจะไม่ประกาศ LocalPort ให้ ตัวส่งเนื่องจากจะทำให้ตัวรับเปิด port ไม่ได้
        'และที่ต้องมี แยกทั้งตัวรับและตัวส่งนั้น เพราะว่า หากใช้คำสั่ง obj.Close จะทำให้ Object นั้นถุก Dispose
        'มีผลเมื่อตอนเราเรียกคำสั่ง Send จะเกิด Error : Can not access dispose object

        Me._IsListening = False

    End Sub

    Public Function GetUDPMessage() As String

        Dim ret As String = ""
        Me.recvBytes = Nothing
        'call block
        'waiting for message from network .....
        Me.recvBytes = objRecvUDP.Receive(groupEP)

        ret = groupEP.Address.ToString & "|" & Encoding.ASCII.GetString(recvBytes, 0, recvBytes.Length)

        'after receive message ... 
        Return ret

    End Function


    Public Sub StartListening()
        'for support change port at every time do this operation here
        Me.objRecvUDP = New UdpClient(Me.LocalPort) 'port is open after do this line
        Me.groupEP = New IPEndPoint(IPAddress.Any, Me.LocalPort)
        Me._IsListening = True
        RaiseEvent ListeningStatusChanged(Me._IsListening)

    End Sub

    Public Sub StopListening()

        'alway close socket : if use this command object will be destroyed
        Me.objRecvUDP.Close()

        Me._IsListening = False
        RaiseEvent ListeningStatusChanged(Me._IsListening)

    End Sub

    Sub New()
        Me.InitialVariables()
    End Sub

    Public Sub Send(ByVal message As String)

        Me.sendbuf = Encoding.ASCII.GetBytes(message)
        Me.objSendUDP.Send(Me.sendbuf, Me.sendbuf.Length, Me.RemoteHost, Me.RemotePort)

    End Sub

    Public Function GetHostAddr(ByVal hostname As String) As String

        Dim ret As String = ""

        Dim ips As IPAddress()
        ips = Dns.GetHostAddresses(hostname)
        ret = ips(0).ToString

        Return ret


    End Function


End Class



