Public Class FrmEingabePW
    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If chkDauer.Checked = False Then
            If Len(txtPasswort.Text) = 0 Then
                Exit Sub
            End If
        End If
        saveTag = False
        PWEingabe = txtPasswort.Text
        Me.Close()
    End Sub

    Private Sub FrmEingabePW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ProName
        If saveTag = True Then
            chkDauer.Visible = True
        Else
            chkDauer.Visible = False
        End If
        Me.AcceptButton = Me.cmdOk
    End Sub

    Private Sub chkDauer_CheckedChanged(sender As Object, e As EventArgs) Handles chkDauer.CheckedChanged
        encryptAlways = chkDauer.Checked
        txtPasswort.Enabled = Not chkDauer.Checked
    End Sub
    Private Sub FrmEingabePW_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    End Sub
End Class