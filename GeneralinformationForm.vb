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
    Public dbOwnerNumber As String 'idk ab this
    Public stAddress As String
    Public stEmail As String
    'Variables for the vereranarian portion of the form.
    Public stVetName As String
    Public dbVetNumber As String 'or this

    Private Sub GeneralInformationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'code for the exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    'code for the reset button
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        dogbreedtxb.Clear()
        dognametxb.Clear()
        colortxb.Clear()
        specialmarktxb.Clear()
        Femalerb.Checked = False
        malerb.Checked = False
        rbYes.Checked = False
        rbNo.Checked = False
        cbDogAge.ResetText()
        nudWeight.ResetText()
        ownernametxb.Clear()
        ownerphonetxb.Clear()
        owneraddresstxb.Clear()
        owneremailtxb.Clear()
        vetnamtxb.Clear()
        vetphonetxb.Clear()

    End Sub

    'Code for the continue button
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        stDogName = dognametxb.Text
        stDogBreed = dogbreedtxb.Text
        stDogColor = colortxb.Text
        stSpecialMark = specialmarktxb.Text
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

        dbAge = cbDogAge.SelectedItem
        dbWeight = nudWeight.Value

        'Code for owner information.
        stOwnerName = ownernametxb.Text
        dbOwnerNumber = ownerphonetxb.Text
        stEmail = owneremailtxb.Text
        stAddress = owneraddresstxb.Text

        'Code for veteranarian information.
        stVetName = vetnamtxb.Text
        dbVetNumber = vetphonetxb.Text

        VaccinationInformation.Show()
        Me.Hide()
    End Sub
End Class