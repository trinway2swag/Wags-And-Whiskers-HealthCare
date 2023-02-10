Public Class Outputform

    Private Sub OutputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim AvailableVacc As String
        Dim PreviousVacc As String
        Dim TotalCost As String
        AvailableVacc = VaccinationInformation.stAvBor & " " & VaccinationInformation.stAvCanIn & " " & VaccinationInformation.stAvDeworm & " " & VaccinationInformation.stAvHeartWorm & " " & VaccinationInformation.stAvLep & " " & VaccinationInformation.stAvParIn & " " & VaccinationInformation.stAvRab
        lblPurchasedVacc.Text = AvailableVacc

        PreviousVacc = VaccinationInformation.stPreBor & " " & VaccinationInformation.stPreCanIn & " " & VaccinationInformation.stPreLep & " " & VaccinationInformation.stPreParIn & " " & VaccinationInformation.stPreRab
        lblPrevVaccines.Text = PreviousVacc

        TotalCost = VaccinationInformation.dbBor + VaccinationInformation.dbCanIn + VaccinationInformation.dbDeworm + VaccinationInformation.dbHeartworm + VaccinationInformation.dbLep + VaccinationInformation.dbParIn + VaccinationInformation.dbRab
        outputinfocostlbl.Text = "$" & TotalCost

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
        outputinfodatelbl.Text = VaccinationInformation.stDate
        Me.CenterToScreen()
    End Sub

    Private Sub btbExitOutput_Click(sender As Object, e As EventArgs) Handles btbExitOutput.Click
        Application.Exit()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub
End Class