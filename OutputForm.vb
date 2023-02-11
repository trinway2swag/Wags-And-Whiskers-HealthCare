'Trinity Noble and Rigoberto Vellos, CS205A, Corozal Junior College, 10.02.2023
Public Class Outputform
    'variables which will be used for the print button
    Dim g, mg As Graphics
    Dim bmp As Bitmap

    'code for all the output labels.
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
        'output for the dog's information.
        lblDogName.Text = GeneralInformationForm.stDogName
        breedoutputlbl.Text = GeneralInformationForm.stDogBreed
        weightoutputlbl.Text = GeneralInformationForm.dbWeight
        coloroutputlbl.Text = GeneralInformationForm.stDogColor
        specialmarkingsoutputlbl.Text = GeneralInformationForm.stSpecialMark
        ageoutputlbl.Text = GeneralInformationForm.dbAge
        genderoutputlbl.Text = GeneralInformationForm.stGender
        spayedoutputlbl.Text = GeneralInformationForm.stSpayedNeutered
        'output for the owner's information.
        ownernameoutputlbl.Text = GeneralInformationForm.stOwnerName
        phonenumberoutputlbl.Text = GeneralInformationForm.dbOwnerNumber
        emailoutputbl.Text = GeneralInformationForm.stEmail
        addressoutputlbl.Text = GeneralInformationForm.stAddress
        'output for the veteranarian's information.
        vetnameoutputlbl.Text = GeneralInformationForm.stVetName
        vetnumberoutputlbl.Text = GeneralInformationForm.dbVetNumber
        outputinfodatelbl.Text = VaccinationInformation.stDate
        Me.CenterToScreen()
    End Sub

    'The following lines contain the code used for the print button.
    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        g = CreateGraphics()
        bmp = New Bitmap(Size.Width, Size.Height, g)
        mg = Graphics.FromImage(bmp)
        mg.CopyFromScreen(Location.X, Location.Y, 0, 0, Size)
        PrintPreviewDialog.ShowDialog()
    End Sub

    Private Sub btbExitOutput_Click(sender As Object, e As EventArgs) Handles btbExitOutput.Click
        Application.Exit()
    End Sub


End Class