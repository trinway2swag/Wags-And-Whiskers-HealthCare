Public Class WagsAndWhiskersLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Error messages for log in screen
        If usernametb.Text = "" Then
            MessageBox.Show("Please Enter a Username")
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

    End Sub
End Class
