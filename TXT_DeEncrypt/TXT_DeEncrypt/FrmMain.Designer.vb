<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuOpenWith = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Separator = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBeenden = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.ContextMenuStrip
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "NotifyIcon1"
        Me.NotifyIcon.Visible = True
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenWith, Me.mnuAbout, Me.Separator, Me.mnuBeenden})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(142, 76)
        '
        'mnuOpenWith
        '
        Me.mnuOpenWith.CheckOnClick = True
        Me.mnuOpenWith.Name = "mnuOpenWith"
        Me.mnuOpenWith.Size = New System.Drawing.Size(141, 22)
        Me.mnuOpenWith.Text = "Öffnen mit..."
        '
        'mnuAbout
        '
        Me.mnuAbout.Image = CType(resources.GetObject("mnuAbout.Image"), System.Drawing.Image)
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(141, 22)
        Me.mnuAbout.Text = "About"
        '
        'Separator
        '
        Me.Separator.Name = "Separator"
        Me.Separator.Size = New System.Drawing.Size(138, 6)
        '
        'mnuBeenden
        '
        Me.mnuBeenden.Image = CType(resources.GetObject("mnuBeenden.Image"), System.Drawing.Image)
        Me.mnuBeenden.Name = "mnuBeenden"
        Me.mnuBeenden.Size = New System.Drawing.Size(141, 22)
        Me.mnuBeenden.Text = "Beenden"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "door_out.ico")
        Me.ImageList.Images.SetKeyName(1, "cog.ico")
        '
        'tmrCheck
        '
        Me.tmrCheck.Interval = 800
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 28)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents ImageList As ImageList
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents Separator As ToolStripSeparator
    Friend WithEvents mnuBeenden As ToolStripMenuItem
    Friend WithEvents tmrCheck As Timer
    Friend WithEvents mnuOpenWith As ToolStripMenuItem
End Class
