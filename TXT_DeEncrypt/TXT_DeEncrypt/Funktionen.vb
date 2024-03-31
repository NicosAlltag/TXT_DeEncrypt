Imports System.IO
Imports System.Security.Principal
Imports System.Text
Imports System.Security.Cryptography
Imports Microsoft.Win32
Module Funktionen
    Public keyPath As String = ".txt\Shell\OpenWithMyApp"
    Public Class_ID As String = "1234567890!ABCDEFGHIJKLMNOPQRST"
    Public ProName As String = "TXT-DeEnCrypt"
    Public PWEingabe As String
    Public encryptAlways As Boolean = False
    Public saveTag As Boolean = False
    Public Function GetApplicationPath() As String
        Return Path.GetDirectoryName(Application.ExecutablePath)
    End Function
    Public Function IsRunningAsAdministrator() As Boolean
        Dim identity As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim principal As New WindowsPrincipal(identity)
        Return principal.IsInRole(WindowsBuiltInRole.Administrator)
    End Function
    Public Sub SpeichereStringInDatei(ByVal text As String, ByVal dateipfad As String)
        Try
            File.WriteAllText(dateipfad, text)
        Catch ex As Exception
        End Try
    End Sub
    Public Function LadeStringAusDatei(ByVal dateipfad As String) As String
        Try
            If File.Exists(dateipfad) Then
                Dim text As String = File.ReadAllText(dateipfad)
                Return text
            Else
                Return String.Empty
            End If
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function
    Public Function CalculateMD5Hash(input As String) As String
        Dim md5 As MD5 = MD5.Create()
        Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)
        Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)
        Dim sb As New StringBuilder()
        For Each b As Byte In hashBytes
            sb.Append(b.ToString("x2"))
        Next

        Return sb.ToString()
    End Function
    Public Function ReadCharactersFromFile(filePath As String, numCharacters As Integer) As String
        Dim content As String = ""

        If File.Exists(filePath) Then
            Using reader As New StreamReader(filePath)
                Dim buffer(numCharacters - 1) As Char
                reader.Read(buffer, 0, numCharacters)
                content = New String(buffer)
            End Using
        End If

        Return content
    End Function
    Public Sub RegisterApplicationInRegistry()
        Dim appPath As String = Application.ExecutablePath
        Dim command As String = String.Format("""{0}"" ""%1""", appPath)

        Dim key As RegistryKey = Registry.ClassesRoot.CreateSubKey(".txt\Shell\OpenWithMyApp\Command")
        key.SetValue("", command)

        Dim appKey As RegistryKey = Registry.ClassesRoot.CreateSubKey("Applications\" & Path.GetFileName(appPath) & "\shell\open\command")
        appKey.SetValue("", command)
    End Sub
    Public Sub RemoveApplicationFromRegistry()
        Registry.ClassesRoot.DeleteSubKeyTree(".txt\Shell\OpenWithMyApp")
        Registry.ClassesRoot.DeleteSubKeyTree("Applications\" & Path.GetFileName(Application.ExecutablePath))
    End Sub
    Public Function ReadTextFromFile(filePath As String, startPosition As Integer) As String
        Dim content As String = ""

        If File.Exists(filePath) Then
            Using reader As New StreamReader(filePath)
                reader.BaseStream.Seek(startPosition, SeekOrigin.Begin)
                content = reader.ReadToEnd()
            End Using
        Else
            MessageBox.Show("Die angegebene Datei existiert nicht.", "Datei nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return content
    End Function
    Public Function AppPrevInstance(Optional ByVal bShowMsg As Boolean = True,
Optional ByVal bAppActivate As Boolean = True) As Boolean

        If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then

            If bShowMsg Then MessageBox.Show("Anwendung wird bereits ausgeführt!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If bAppActivate Then
                AppActivate(Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName)(1).Id)
            End If

            Return True
        End If
    End Function
    Public Function RegistryKeyExists(ByVal keyPath As String) As Boolean
        Dim regKey As RegistryKey = Nothing
        Try
            regKey = Registry.ClassesRoot.OpenSubKey(keyPath)
            If regKey IsNot Nothing Then
                Return True
            Else
                Return False
            End If
        Finally
            If regKey IsNot Nothing Then
                regKey.Close()
            End If
        End Try
    End Function
    Public Function GetSubstringFromPositionToEnd(inputString As String, position As Integer) As String
        If position < 0 Or position >= inputString.Length Then
            Throw New ArgumentOutOfRangeException("position", "Die angegebene Position liegt außerhalb des Bereichs des Eingabestrings.")
        End If

        Return inputString.Substring(position)
    End Function
    Public Function GetFirstCharacters(inputString As String, count As Integer) As String
        If count < 0 Or count > inputString.Length Then
            Throw New ArgumentOutOfRangeException("count", "Die Anzahl der Zeichen ist ungültig.")
        End If

        Return inputString.Substring(0, count)
    End Function
End Module
