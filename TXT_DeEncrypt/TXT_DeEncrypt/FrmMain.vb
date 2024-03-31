
Public Class FrmMain
    Dim EditorProcess As New Process
    Dim filePath As String = ""
    Public Sub New()
        InitializeComponent()
        NotifyIcon.Text = ProName
        NotifyIcon.Visible = True
        Me.ShowInTaskbar = False
        Me.Visible = False
    End Sub
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ProName
        If AppPrevInstance() Then
            Application.Exit()
        End If
        If IsRunningAsAdministrator() = False Then
            MessageBox.Show("Das Programm muss als Administrator ausgeführt werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NotifyIcon.Visible = False
            NotifyIcon.Dispose()
            End
        End If

        If RegistryKeyExists(keyPath) = True Then
            mnuOpenWith.Checked = True
        Else
            mnuOpenWith.Checked = False
        End If

        If My.Application.CommandLineArgs.Count > 0 Then
            filePath = My.Application.CommandLineArgs(0)
            If ReadCharactersFromFile(filePath, 32) = CalculateMD5Hash(Class_ID) Then
                PWEingabe = ""
                saveTag = False
                FrmEingabePW.ShowDialog()
                If PWEingabe <> "" Then
                    Dim TempDecrypt As String = DecryptScript(ReadTextFromFile(filePath, 32), Class_ID & PWEingabe & PWEingabe)
                    If CalculateMD5Hash(Class_ID & PWEingabe & PWEingabe) = GetFirstCharacters(TempDecrypt, 32) Then
                        SpeichereStringInDatei(GetSubstringFromPositionToEnd(TempDecrypt, 32), filePath)
                        With EditorProcess.StartInfo
                            .FileName = "notepad.exe"
                            .Arguments = filePath
                            .UseShellExecute = False
                        End With
                        EditorProcess.Start()
                        tmrCheck.Enabled = True
                    Else
                        MessageBox.Show("Falsches Passwort" & vbCrLf & "Programm beendet", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        NotifyIcon.Visible = False
                        NotifyIcon.Dispose()
                        End
                    End If

                End If
            Else
                With EditorProcess.StartInfo
                    .FileName = "notepad.exe"
                    .Arguments = filePath
                    .UseShellExecute = False
                End With
                EditorProcess.Start()
                tmrCheck.Enabled = True
            End If
        Else

        End If

    End Sub
    Private Sub mnuBeenden_Click(sender As Object, e As EventArgs) Handles mnuBeenden.Click
        NotifyIcon.Visible = False
        NotifyIcon.Dispose()
        End
    End Sub
    Private Sub tmrCheck_Tick(sender As Object, e As EventArgs) Handles tmrCheck.Tick
        CheckProcessStatus()
    End Sub
    Private Sub CheckProcessStatus()
        If EditorProcess IsNot Nothing AndAlso Not EditorProcess.HasExited Then
        Else
            tmrCheck.Enabled = False
            saveTag = True
            FrmEingabePW.ShowDialog()
            If PWEingabe <> "" Then
                If Len(LadeStringAusDatei(filePath)) = 0 Then
                    NotifyIcon.Visible = False
                    NotifyIcon.Dispose()
                    End
                End If
                If encryptAlways = False Then
                    Dim TempEnCrypt As String = CalculateMD5Hash(Class_ID) & EncryptScript(CalculateMD5Hash(Class_ID & PWEingabe & PWEingabe) & LadeStringAusDatei(filePath), Class_ID & PWEingabe & PWEingabe)
                    SpeichereStringInDatei(TempEnCrypt, filePath)
                End If
                NotifyIcon.Visible = False
                NotifyIcon.Dispose()
                End
            End If
        End If
    End Sub
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        FrmAbout.ShowDialog()
    End Sub
    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        NotifyIcon.Visible = False
        NotifyIcon.Dispose()
    End Sub
    Private Sub mnuOpenWith_Click(sender As Object, e As EventArgs) Handles mnuOpenWith.Click
        If mnuOpenWith.Checked = True Then
            RegisterApplicationInRegistry()
        Else
            RemoveApplicationFromRegistry()
        End If
    End Sub
End Class
