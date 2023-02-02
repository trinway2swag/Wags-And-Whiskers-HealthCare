Public Class SplashScreen
    Private Sub pbProgBar_Tick(sender As Object, e As EventArgs) Handles pbProgBar.Tick
        If (pbProgBar.Value = pbProgBar.Maximum) Then
            pbProgBar.Stop()
            Me.Hide()
            WagsAndWhiskersLogin.Show()
        Else
            pbProgBar.PerformStep()
            pbPercent.Text = pbProgBar.Value & ("%")
        End If

    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbProgBar.Start()
    End Sub
End Class