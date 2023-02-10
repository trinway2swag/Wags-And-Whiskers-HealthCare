Public Class WagsAndWhiskersLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Error messages for log in screen
        If usernametb.Text = "" Then
            MessageBox.Show("Please enter a valid username.")
            usernametb.Focus()
            Exit Sub
        End If
        If passwordtb.Text = "" Then
            MessageBox.Show("Please Enter a Password")
            passwordtb.Focus()
            Exit Sub
        End If
        Me.Hide()
        GeneralInformationForm.Show()

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub WagsAndWhiskersLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
