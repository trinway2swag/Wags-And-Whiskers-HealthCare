<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.pbProgBar = New System.Windows.Forms.ProgressBar()
        Me.pbPercent = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pbProgBar
        '
        Me.pbProgBar.Location = New System.Drawing.Point(13, 260)
        Me.pbProgBar.Name = "pbProgBar"
        Me.pbProgBar.Size = New System.Drawing.Size(597, 40)
        Me.pbProgBar.TabIndex = 0
        '
        'pbPercent
        '
        Me.pbPercent.AutoSize = True
        Me.pbPercent.BackColor = System.Drawing.Color.Transparent
        Me.pbPercent.Location = New System.Drawing.Point(541, 272)
        Me.pbPercent.Name = "pbPercent"
        Me.pbPercent.Size = New System.Drawing.Size(0, 17)
        Me.pbPercent.TabIndex = 1
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.newsplashscreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(622, 312)
        Me.Controls.Add(Me.pbPercent)
        Me.Controls.Add(Me.pbProgBar)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SplashScreen"
        Me.Text = "SplashScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbProgBar As ProgressBar
    Friend WithEvents pbPercent As Label
End Class
