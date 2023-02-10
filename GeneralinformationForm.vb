Public Class GeneralInformationForm
    'Variables for the dog portion of the form.
    Public stDogName As String
    Public stDogBreed As String
    Public stDogColor As String
    Public stSpecialMark As String
    Public dbAge As Double
    Public dbWeight As Double
    Public stGender As String
    Public stSpayedNeutered As String
    'Variables for the owner portion of the form.
    Public stOwnerName As String
    Public dbOwnerNumber As String
    Public stAddress As String
    Public stEmail As String
    'Variables for the vereranarian portion of the form.
    Public stVetName As String
    Public dbVetNumber As String

    'code for the exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    'code for the reset button
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        dogbreedtxb.Clear()
        dognametxb.Clear()
        colortxb.Clear()
        rtbSpecialMarkings.Clear()
        Femalerb.Checked = False
        malerb.Checked = False
        rbYes.Checked = False
        rbNo.Checked = False
        nudWeight.ResetText()
        cbAge.ResetText()
        ownernametxb.Clear()
        mtbOwnerNum.Clear()
        owneraddresstxb.Clear()
        owneremailtxb.Clear()
        vetnametxb.Clear()
        mtbVetNum.Clear()

    End Sub


    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'error messages for General Information Form
        If dognametxb.Text = "" Then
            MessageBox.Show("Please enter the dog's name.")
            dognametxb.Focus()
            Exit Sub
        End If
        If dogbreedtxb.Text = "" Then
            MessageBox.Show("Please enter the dog's breed.")
            dogbreedtxb.Focus()
            Exit Sub
        End If
        If colortxb.Text = "" Then
            MessageBox.Show("Please enter the color of the dog.")
            colortxb.Focus()
            Exit Sub
        End If
        If rtbSpecialMarkings.Text = "" Then
            MessageBox.Show("Please describe the special markings on the dog.")
            rtbSpecialMarkings.Focus()
            Exit Sub
        End If
        If cbAge.Text = "" Then 'fix this
            MessageBox.Show("Please select the dog's age.")
            cbAge.Focus()
            Exit Sub
        End If
        If nudWeight.Text = "" Then
            MessageBox.Show("Please enter the dog's weight.")
            nudWeight.Focus()
            Exit Sub
        End If

        If rbYes.Checked = False And rbNo.Checked = False Then
            MessageBox.Show("Please state if the dog is spayed/neutered.")
        End If
        If Femalerb.Checked = False And malerb.Checked = False Then
            MessageBox.Show("Please select the dog's sex.")
        End If
        If ownernametxb.Text = "" Then
            MessageBox.Show("Please enter the name of the owner.")
            ownernametxb.Focus()
            Exit Sub
        End If
        If mtbOwnerNum.Text = "" Then
            MessageBox.Show("Please enter the owner's phone number.")
            mtbOwnerNum.Focus()
            Exit Sub
        End If
        If owneraddresstxb.Text = "" Then
            MessageBox.Show("Please Enter the Address")
            owneraddresstxb.Focus()
            Exit Sub
        End If
        If vetnametxb.Text = "" Then
            MessageBox.Show("Please Enter the Veterinarian's Name")
            vetnametxb.Focus()
            Exit Sub
        End If
        If mtbVetNum.Text = "" Then
            MessageBox.Show("Please Enter the Veterinarian's Number")
            mtbVetNum.Focus()
            Exit Sub
        End If
        'code for global variables
        stDogName = dognametxb.Text
        stDogBreed = dogbreedtxb.Text
        stDogColor = colortxb.Text
        stSpecialMark = rtbSpecialMarkings.Text
        'Code for the gender radio boxes.
        If Femalerb.Checked Then
            stGender = "Female"
        Else
            stGender = "Male"
        End If
        'Code for the Spayed/Neutered radio boxes.
        If rbYes.Checked Then
            stSpayedNeutered = "Yes"
        Else
            stSpayedNeutered = "No"
        End If

        dbWeight = nudWeight.Value
        dbAge = cbAge.SelectedItem

        'Code for owner information.
        stOwnerName = ownernametxb.Text
        dbOwnerNumber = mtbOwnerNum.Text
        stEmail = owneremailtxb.Text
        stAddress = owneraddresstxb.Text

        'Code for veteranarian information.
        stVetName = vetnametxb.Text
        dbVetNumber = mtbVetNum.Text

        VaccinationInformation.Show()
        Me.Hide()
    End Sub

    Private Sub GeneralInformationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class