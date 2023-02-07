﻿Public Class GeneralInformationForm
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
        rtbSpecialMarkings.Clear()
        Femalerb.Checked = False
        malerb.Checked = False
        rbYes.Checked = False
        rbNo.Checked = False
        cbDogAge.ResetText()
        nudWeight.ResetText()
        ownernametxb.Clear()
        mtbOwnerNum.Clear()
        owneraddresstxb.Clear()
        owneremailtxb.Clear()
        vetnamtxb.Clear()
        mtbVetNum.Clear()

    End Sub

    'Code for the continue button
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'error messages for General Information Form
        If dognametxb.Text = "" Then
            MessageBox.Show("Please Enter Your Dogs name")
            dognametxb.Focus()
            Exit Sub
        End If
        If dogbreedtxb.Text = "" Then
            MessageBox.Show("Please Enter Your Dogs Breed")
            dogbreedtxb.Focus()
            Exit Sub
        End If
        If colortxb.Text = "" Then
            MessageBox.Show("Please Enter the Color of your Dog")
            colortxb.Focus()
            Exit Sub
        End If
        If cbDogAge.Text = "" Then
            MessageBox.Show("Please Enter Your Dogs Age")
            cbDogAge.Focus()
            Exit Sub
        End If
        If nudWeight.Text = "" Then
            MessageBox.Show("Please Enter Your Dogs Weight")
            nudWeight.Focus()
            Exit Sub
        End If
        If ownernametxb.Text = "" Then
            MessageBox.Show("Please Enter the Owners Name")
            ownernametxb.Focus()
            Exit Sub
        End If
        If mtbOwnerNum.Text = "" Then
            MessageBox.Show("Please Enter the Owners Phone Number")
            mtbOwnerNum.Focus()
            Exit Sub
        End If
        If owneremailtxb.Text = "" Then
            MessageBox.Show("Please Enter the Owners Email")
            owneremailtxb.Focus()
            Exit Sub
        End If
        If owneraddresstxb.Text = "" Then
            MessageBox.Show("Please Enter the Address")
            owneraddresstxb.Focus()
            Exit Sub
        End If
        If vetnamtxb.Text = "" Then
            MessageBox.Show("Please Enter the Veterinarian's Name")
            vetnamtxb.Focus()
            Exit Sub
        End If
        If mtbVetNum.Text = "" Then
            MessageBox.Show("Please Enter the Veterinarian's Number")
            mtbVetNum.Focus()
            Exit Sub
        End If
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

        dbAge = cbDogAge.SelectedItem
        dbWeight = nudWeight.Value

        'Code for owner information.
        stOwnerName = ownernametxb.Text
        dbOwnerNumber = mtbOwnerNum.Text
        stEmail = owneremailtxb.Text
        stAddress = owneraddresstxb.Text

        'Code for veteranarian information.
        stVetName = vetnamtxb.Text
        dbVetNumber = mtbVetNum.Text

        VaccinationInformation.Show()
        Me.Hide()
    End Sub

    Private Sub nudWeight_ValueChanged(sender As Object, e As EventArgs) Handles nudWeight.ValueChanged

    End Sub
End Class