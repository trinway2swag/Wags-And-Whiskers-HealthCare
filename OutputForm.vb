Public Class Outputform
    Public stAllPrevVacc As String
    Public stAllPurVacc As String
    Public dbTotalCost As Double
    Private Sub OutputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDogName.Text = GeneralInformationForm.stDogName
        breedoutputlbl.Text = GeneralInformationForm.stDogBreed
        weightoutputlbl.Text = GeneralInformationForm.dbWeight
        coloroutputlbl.Text = GeneralInformationForm.stDogColor
        specialmarkingsoutputlbl.Text = GeneralInformationForm.stSpecialMark
        ageoutputlbl.Text = GeneralInformationForm.dbAge
        genderoutputlbl.Text = GeneralInformationForm.stGender
        spayedoutputlbl.Text = GeneralInformationForm.stSpayedNeutered

        ownernameoutputlbl.Text = GeneralInformationForm.stOwnerName
        phonenumberoutputlbl.Text = GeneralInformationForm.dbOwnerNumber
        emailoutputbl.Text = GeneralInformationForm.stEmail
        addressoutputlbl.Text = GeneralInformationForm.stAddress

        vetnameoutputlbl.Text = GeneralInformationForm.stVetName
        vetnumberoutputlbl.Text = GeneralInformationForm.dbVetNumber
        lblPrevVaccines.Text = VaccinationInformation.stAvBor & " " & VaccinationInformation.stAvCanIn & " " & VaccinationInformation.stAvDeworm & " " & VaccinationInformation.stAvHeartWorm & " " & VaccinationInformation.stAvLep & " " & VaccinationInformation.stAvParIn & " " & VaccinationInformation.stAvRab

    End Sub

    Private Sub btbExitOutput_Click(sender As Object, e As EventArgs) Handles btbExitOutput.Click
        Application.Exit()
    End Sub
End Class