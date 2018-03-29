

Public Class FrmKeyBoard

    Public TargetTextBox As TextBox

    Dim Key As String

    Private Sub ClickButtoN_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bt0.Click, Bt1.Click, Bt2.Click, Bt3.Click _
                                 , Bt4.Click, Bt5.Click, Bt6.Click, Bt7.Click, Bt8.Click, Bt9.Click, BtA.Click, BtB.Click, BtC.Click _
                                 , BtD.Click, BtE.Click, BtF.Click, BtG.Click, BtH.Click, BtI.Click, BtJ.Click, BtK.Click, BtL.Click _
                                 , BtM.Click, BtN.Click, BtO.Click, BtP.Click, BtQ.Click, BtR.Click, BtS.Click, Btt.Click, BtU.Click _
                                 , BtV.Click, BtW.Click, BtX.Click, BtY.Click, BtZ.Click, BtBS.Click, BtMinus.Click
        Dim Btn As Button = CType(sender, Button)
        Key = Btn.Text
        If Btn.Text = "BACKSPACE" Or Btn.Text = "CLEAR" Then
            Key = "{" & Btn.Text & "}"
        End If
        'Form1.CtlFocust.Focus()
        TargetTextBox.Focus()
        My.Computer.Keyboard.SendKeys(Key, True)
    End Sub

    Private Sub BtClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtClear.Click
        'Form1.CtlFocust.Text = ""
        TargetTextBox.Text = ""
    End Sub

    Private Sub BtLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtLeft.Click
        'Form1.CtlFocust.Focus()
        TargetTextBox.Focus()
        My.Computer.Keyboard.SendKeys("{LEFT}", True)
    End Sub

    Private Sub BtRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtRight.Click
        'Form1.CtlFocust.Focus()
        TargetTextBox.Focus()
        My.Computer.Keyboard.SendKeys("{RIGHT}", True)
    End Sub

    Private Sub BtPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtPlus.Click
        'Form1.CtlFocust.Focus()
        TargetTextBox.Focus()
        My.Computer.Keyboard.SendKeys("{ADD}", True)
    End Sub

    Private Sub BtEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtEnter.Click
        TargetTextBox.Focus()
        My.Computer.Keyboard.SendKeys("{ENTER}", True)
    End Sub
End Class