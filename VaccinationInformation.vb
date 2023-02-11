'Trinity Noble and Rigoberto Vellos, CS205A, Corozal Junior College, 10.02.2023
Public Class VaccinationInformation
    'declaration of global variables
    Public stPreBor As String
    Public stPreCanIn As String
    Public stPreLep As String
    Public stPreParIn As String
    Public stPreRab As String
    Public stAvBor As String
    Public stAvCanIn As String
    Public stAvLep As String
    Public stAvParIn As String
    Public stAvRab As String
    Public stAvDeworm As String
    Public stAvHeartWorm As String
    Public dbBor As Double
    Public dbCanIn As Double
    Public dbLep As Double
    Public dbParIn As Double
    Public dbRab As Double
    Public dbDeworm As Double
    Public dbHeartworm As Double
    Public stDate As String



    'code for the exit button
    Private Sub vaccineinfoexitbt_Click(sender As Object, e As EventArgs) Handles vaccineinfoexitbt.Click
        Application.Exit()
    End Sub

    'The code for the clear button
    Private Sub vaccineinforesetbt_Click(sender As Object, e As EventArgs) Handles vaccineinforesetbt.Click
        Dim prevacccheckbx As CheckBox = Nothing
        For Each xObject As Object In Me.gbPrevVacc.Controls
            If TypeOf xObject Is CheckBox Then
                prevacccheckbx = xObject
                prevacccheckbx.Checked = False
            End If
        Next
        Dim avvacccheckbx As CheckBox = Nothing
        For Each yObject As Object In Me.gbAvailableVacc.Controls
            If TypeOf yObject Is CheckBox Then
                avvacccheckbx = yObject
                avvacccheckbx.Checked = False
            End If
        Next
        mtbTodayDate.Clear()
    End Sub
    'code for the check boxes in the previous vaccination groupbox
    'code for the continue button
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles vaccineinfocontinuebt.Click
        stDate = mtbTodayDate.Text

        If prevbordetellacb.Checked Then
            stPreBor = "Bordetella"
        Else
            stPreBor = ""
        End If
        If prevcanineinfluenzacb.Checked Then
            stPreCanIn = "Canine Influenza"
        Else
            stPreCanIn = ""
        End If
        If prevleptospirosiscb.Checked Then
            stPreLep = "Leptospirosis"
        Else
            stPreLep = ""
        End If

        If prevparaininfluenzacb.Checked Then
            stPreParIn = "Parain Influenza"
        Else
            stPreParIn = ""
        End If

        If prevrabiescb.Checked Then
            stPreRab = "Rabies"
        Else
            stPreRab = ""
        End If
        'The code for the groupbox Available Vaccines. In addition, it also assigns a value to the variables which are used to calculate the total cost.
        If cbAvBordetellavacc.Checked Then
            stAvBor = "Boretella"
            dbBor = 20
        Else
            stAvBor = ""
            dbBor = 0
        End If

        If cbAvCanInflu.Checked Then
            stAvCanIn = "Canine Influenza"
            dbCanIn = 20
        Else
            stAvCanIn = ""
            dbCanIn = 0
        End If

        If cbAvDeworm.Checked Then
            stAvDeworm = "Deworming Pill"
            dbDeworm = 10
        Else
            stAvDeworm = ""
            dbDeworm = 0
        End If

        If cbAvHeartworm.Checked Then
            stAvHeartWorm = "Heartworm Preventative"
            dbHeartworm = 10
        Else
            stAvHeartWorm = ""
            dbHeartworm = 0
        End If
        If cbAvLepto.Checked Then
            stAvLep = "Leptospirosis"
            dbLep = 25
        Else
            stAvLep = ""
            dbLep = 0
        End If

        If cbAvParInflu.Checked Then
            stAvParIn = "Parain Influenza"
            dbParIn = 30
        Else
            stAvParIn = ""
            dbParIn = 0
        End If

        If cbAvRabies.Checked Then
            stAvRab = "Rabies"
            dbRab = 15
        Else
            stAvRab = ""
            dbRab = 0
        End If

        Outputform.Show()
        Me.Hide()
    End Sub

    'centering the form to the user's screen.
    Private Sub VaccinationInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class