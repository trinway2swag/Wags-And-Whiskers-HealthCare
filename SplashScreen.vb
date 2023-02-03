Public Class SplashScreen
    Private Sub tmrProgTimer_Tick(sender As Object, e As EventArgs) Handles tmrProgTimer.Tick
        If (pbProgBar.Value = pbProgBar.Maximum - 1) Then
            pbProgBar.Value += 1
            Me.Hide()
            WagsAndWhiskersLogin.Show()
        Else
            pbProgBar.PerformStep()
            pbPercent.Text = pbProgBar.Value & ("%")
        End If

    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrProgTimer.Start()
    End Sub


End Class