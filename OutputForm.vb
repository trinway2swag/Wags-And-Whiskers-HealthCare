Public Class Outputform

    Private Sub OutputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim stAllPrevVacc As String
        Dim stAllPurVacc As String
        Dim dbTotalCost As Double
        Dim test As String

        test = VaccinationInformation.stAvBor & " " & VaccinationInformation.stAvCanIn & " " & VaccinationInformation.stAvDeworm & " " & VaccinationInformation.stAvHeartWorm & " " & VaccinationInformation.stAvLep & " " & VaccinationInformation.stAvParIn & " " & VaccinationInformation.stAvRab
        lblPurchasedVacc.Text = test
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


    End Sub

    Private Sub btbExitOutput_Click(sender As Object, e As EventArgs) Handles btbExitOutput.Click
        Application.Exit()
    End Sub
End Class