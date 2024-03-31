Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Module Encrypt_Decrypt
    Public Function EncryptScript(clearText As String, EncryptionKey As String) As String 'Verschlüsseln
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H53, &H61, &H74, &H6F, &H73, &H68, &H69, &H20, &H4E, &H61, &H6B, &H61, &H6D, &H6F, &H74, &H6F})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)

            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function
    Public Function DecryptScript(cipherText As String, EncryptionKey As String) As String 'Entschlüsseln
        Try
            Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
            Using encryptor As Aes = Aes.Create()
                Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H53, &H61, &H74, &H6F, &H73, &H68, &H69, &H20, &H4E, &H61, &H6B, &H61, &H6D, &H6F, &H74, &H6F})
                encryptor.Key = pdb.GetBytes(32)
                encryptor.IV = pdb.GetBytes(16)

                Using ms As New MemoryStream()
                    Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                        cs.Write(cipherBytes, 0, cipherBytes.Length)
                        cs.Close()
                    End Using
                    cipherText = Encoding.Unicode.GetString(ms.ToArray())
                End Using
            End Using
            Return cipherText
        Catch ex As Exception
            MessageBox.Show("Falsches Passwort" & vbCrLf & "Programm beendet", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FrmMain.NotifyIcon.Visible = False
            FrmMain.NotifyIcon.Dispose()
            End
        End Try
    End Function
End Module

