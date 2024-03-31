Public NotInheritable Class FrmAbout
    Private Sub Frmabout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Info {0}", ApplicationTitle)
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description
        Me.AcceptButton = Me.OKButton
        TextBoxDescription.Text = ""
        TextBoxDescription.AppendText(ProName & vbCrLf)
        TextBoxDescription.AppendText("" & vbCrLf)
        TextBoxDescription.AppendText("Programmierung:" & Space(1) & "by TNG" & vbCrLf)
        TextBoxDescription.AppendText("nicos-alltag.blogspot.com" & vbCrLf)
        TextBoxDescription.AppendText("" & vbCrLf)
        TextBoxDescription.AppendText("Icons:" & vbCrLf)
        TextBoxDescription.AppendText("Mark James" & vbCrLf)
        TextBoxDescription.AppendText("famfamfam.com/" & vbCrLf)
        TextBoxDescription.AppendText("" & vbCrLf)
        TextBoxDescription.AppendText("icon-icons.com" & vbCrLf)
        TextBoxDescription.AppendText("Itzik Gur" & vbCrLf)
        TextBoxDescription.AppendText("" & vbCrLf)
        TextBoxDescription.AppendText("About Form by Microsoft" & vbCrLf)
        TextBoxDescription.AppendText("" & vbCrLf)
        TextBoxDescription.AppendText("Source darf mit dem Verweis auf" & vbCrLf)
        TextBoxDescription.AppendText("den Autor für eigene Projekte" & vbCrLf)
        TextBoxDescription.AppendText("verwendet werden" & vbCrLf)
        TextBoxDescription.AppendText("" & vbCrLf)
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
End Class
