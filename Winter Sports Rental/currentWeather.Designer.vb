<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class currentWeather
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(currentWeather))
        Me.wbWeather = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.llblWeathercom = New System.Windows.Forms.LinkLabel()
        Me.llblAccu = New System.Windows.Forms.LinkLabel()
        Me.llblWeather = New System.Windows.Forms.LinkLabel()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtUrl = New System.Windows.Forms.ToolStripTextBox()
        Me.btnGo = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'wbWeather
        '
        Me.wbWeather.Location = New System.Drawing.Point(0, 0)
        Me.wbWeather.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbWeather.Name = "wbWeather"
        Me.wbWeather.ScriptErrorsSuppressed = True
        Me.wbWeather.Size = New System.Drawing.Size(998, 430)
        Me.wbWeather.TabIndex = 0
        Me.wbWeather.Url = New System.Uri("https://www.weatherbug.com/weather-forecast/now/", System.UriKind.Absolute)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 463)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Popular Weather Forcasts:"
        '
        'llblWeathercom
        '
        Me.llblWeathercom.AutoSize = True
        Me.llblWeathercom.Location = New System.Drawing.Point(246, 463)
        Me.llblWeathercom.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.llblWeathercom.Name = "llblWeathercom"
        Me.llblWeathercom.Size = New System.Drawing.Size(71, 13)
        Me.llblWeathercom.TabIndex = 2
        Me.llblWeathercom.TabStop = True
        Me.llblWeathercom.Text = "Weather.com"
        '
        'llblAccu
        '
        Me.llblAccu.AutoSize = True
        Me.llblAccu.Location = New System.Drawing.Point(323, 463)
        Me.llblAccu.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.llblAccu.Name = "llblAccu"
        Me.llblAccu.Size = New System.Drawing.Size(93, 13)
        Me.llblAccu.TabIndex = 3
        Me.llblAccu.TabStop = True
        Me.llblAccu.Text = "Accuweather.com"
        '
        'llblWeather
        '
        Me.llblWeather.AutoSize = True
        Me.llblWeather.Location = New System.Drawing.Point(151, 463)
        Me.llblWeather.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.llblWeather.Name = "llblWeather"
        Me.llblWeather.Size = New System.Drawing.Size(89, 13)
        Me.llblWeather.TabIndex = 4
        Me.llblWeather.TabStop = True
        Me.llblWeather.Text = "Weatherbug.com"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.wbWeather)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(998, 408)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, -1)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(998, 458)
        Me.ToolStripContainer1.TabIndex = 5
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtUrl, Me.btnGo, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(995, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripLabel1.Text = "Please Enter a Valid URL:"
        '
        'txtUrl
        '
        Me.txtUrl.AutoSize = False
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(500, 25)
        '
        'btnGo
        '
        Me.btnGo.AutoSize = False
        Me.btnGo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnGo.Image = CType(resources.GetObject("btnGo.Image"), System.Drawing.Image)
        Me.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(50, 23)
        Me.btnGo.Text = "&Go"
        '
        'btnExit
        '
        Me.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExit.AutoSize = False
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 23)
        Me.btnExit.Text = "E&xit"
        '
        'currentWeather
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 487)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.llblWeather)
        Me.Controls.Add(Me.llblAccu)
        Me.Controls.Add(Me.llblWeathercom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "currentWeather"
        Me.Text = "Current Weather"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents wbWeather As WebBrowser
    Friend WithEvents Label1 As Label
    Friend WithEvents llblWeathercom As LinkLabel
    Friend WithEvents llblAccu As LinkLabel
    Friend WithEvents llblWeather As LinkLabel
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtUrl As ToolStripTextBox
    Friend WithEvents btnGo As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class
