<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEingabePW
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEingabePW))
        Me.lblPasswort = New System.Windows.Forms.Label()
        Me.txtPasswort = New System.Windows.Forms.TextBox()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.chkDauer = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblPasswort
        '
        Me.lblPasswort.AutoSize = True
        Me.lblPasswort.Location = New System.Drawing.Point(12, 13)
        Me.lblPasswort.Name = "lblPasswort"
        Me.lblPasswort.Size = New System.Drawing.Size(56, 13)
        Me.lblPasswort.TabIndex = 0
        Me.lblPasswort.Text = "&Password:"
        '
        'txtPasswort
        '
        Me.txtPasswort.Location = New System.Drawing.Point(75, 10)
        Me.txtPasswort.Name = "txtPasswort"
        Me.txtPasswort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswort.Size = New System.Drawing.Size(137, 20)
        Me.txtPasswort.TabIndex = 1
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(137, 60)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 2
        Me.cmdOk.Text = "OK"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'chkDauer
        '
        Me.chkDauer.AutoSize = True
        Me.chkDauer.Location = New System.Drawing.Point(75, 37)
        Me.chkDauer.Name = "chkDauer"
        Me.chkDauer.Size = New System.Drawing.Size(140, 17)
        Me.chkDauer.TabIndex = 3
        Me.chkDauer.Text = "Dauerhaft entschlüsseln"
        Me.chkDauer.UseVisualStyleBackColor = True
        '
        'FrmEingabePW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 89)
        Me.Controls.Add(Me.chkDauer)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtPasswort)
        Me.Controls.Add(Me.lblPasswort)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEingabePW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEingabePW"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPasswort As Label
    Friend WithEvents txtPasswort As TextBox
    Friend WithEvents cmdOk As Button
    Friend WithEvents chkDauer As CheckBox
End Class
