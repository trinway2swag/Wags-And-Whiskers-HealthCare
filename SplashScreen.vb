Public NotInheritable Class SplashScreen

    'The splashscreen template was used, however we modified it to our liking.


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'The Application title was removed as the image used already contains the title.'

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
    End Sub

End Class
