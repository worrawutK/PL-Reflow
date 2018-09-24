Public Class frmConfig

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        'm_01 = CBool(cb01.Text.Trim)
        'm_02 = CBool(cb02.Text.Trim)
        'm_03 = CBool(cb03.Text.Trim)
        'm_04 = CBool(cb04.Text.Trim)
        'm_05 = CBool(cb05.Text.Trim)
        'm_06 = CBool(cb06.Text.Trim)
        'm_70 = CBool(cb70.Text.Trim)
        'm_72 = CBool(cb72.Text.Trim)
        'm_99 = CBool(cb99.Text.Trim)

        If cbRunOffline.Text = "Online" Then
            m_SelfData.CellConState = _SelfConMode.Online
        Else
            m_SelfData.CellConState = _SelfConMode.Offline
        End If

        'If m_SelfData.CellConState = _SelfConMode.Online Then 'Online
        '    m_frmMain.lbStatusMC.BackColor = Color.Lime
        'Else 'Offline
        '    m_frmMain.lbStatusMC.BackColor = Color.Red
        'End If

        MsgBox("OK")

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cb01.Text = CStr(m_01)
        'cb02.Text = CStr(m_02)
        'cb03.Text = CStr(m_03)
        'cb04.Text = CStr(m_04)
        'cb05.Text = CStr(m_05)
        'cb06.Text = CStr(m_06)
        'cb70.Text = CStr(m_70)
        'cb72.Text = CStr(m_72)
        'cb99.Text = CStr(m_99)
        If m_SelfData.CellConState = _SelfConMode.Online Then
            cbRunOffline.Text = "Online"
        Else
            cbRunOffline.Text = "Offline"
        End If
    End Sub
    Dim m_frmMain As frmMain
    Public Sub New(ByVal frm As frmMain)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        m_frmMain = frm

    End Sub
End Class