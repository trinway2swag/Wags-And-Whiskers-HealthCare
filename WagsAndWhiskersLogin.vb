'Trinity Noble and Rigoberto Vellos, CS205A, Corozal Junior College, 10.02.2023
Public Class WagsAndWhiskersLogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Error messages for log in screen
        If usernametb.Text = "" Then
            MessageBox.Show("Please enter a username.", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            usernametb.Focus()
            Exit Sub
        End If
        If passwordtb.Text = "" Then
            MessageBox.Show("Please enter a password.", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            passwordtb.Focus()
            Exit Sub
        End If
        Me.Hide()
        GeneralInformationForm.Show()

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    'centering the form to the screen
    Private Sub WagsAndWhiskersLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
