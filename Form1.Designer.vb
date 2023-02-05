<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Outputform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.outputDogInfogb = New System.Windows.Forms.GroupBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.dognamelbl = New System.Windows.Forms.Label()
        Me.genderlb = New System.Windows.Forms.Label()
        Me.lblSpayedNeutered = New System.Windows.Forms.Label()
        Me.breedlb = New System.Windows.Forms.Label()
        Me.colorlb = New System.Windows.Forms.Label()
        Me.specialmarklbl = New System.Windows.Forms.Label()
        Me.lblDogAge = New System.Windows.Forms.Label()
        Me.dognameoutputlbl = New System.Windows.Forms.Label()
        Me.breedoutputlbl = New System.Windows.Forms.Label()
        Me.coloroutputlbl = New System.Windows.Forms.Label()
        Me.specialmarkingsoutputlbl = New System.Windows.Forms.Label()
        Me.ageoutputlbl = New System.Windows.Forms.Label()
        Me.weightoutputlbl = New System.Windows.Forms.Label()
        Me.genderoutputlbl = New System.Windows.Forms.Label()
        Me.spayedoutputlbl = New System.Windows.Forms.Label()
        Me.outputownerInfogb = New System.Windows.Forms.GroupBox()
        Me.ownernamelb = New System.Windows.Forms.Label()
        Me.ownerphonelb = New System.Windows.Forms.Label()
        Me.owneremaillb = New System.Windows.Forms.Label()
        Me.owneraddresstxb = New System.Windows.Forms.TextBox()
        Me.owneremailtxb = New System.Windows.Forms.TextBox()
        Me.owneraddresslb = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ownernameoutputlbl = New System.Windows.Forms.Label()
        Me.phonenumberoutputlbl = New System.Windows.Forms.Label()
        Me.emaillbl = New System.Windows.Forms.Label()
        Me.addressoutputlbl = New System.Windows.Forms.Label()
        Me.outputvetInfogb = New System.Windows.Forms.GroupBox()
        Me.vetnamelb = New System.Windows.Forms.Label()
        Me.vetphonelb = New System.Windows.Forms.Label()
        Me.vetnameoutputlbl = New System.Windows.Forms.Label()
        Me.vetnumberoutputlbl = New System.Windows.Forms.Label()
        Me.vaccinationsoutputgb = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bordetellaoutputlbl = New System.Windows.Forms.Label()
        Me.Paraininfluenza = New System.Windows.Forms.Label()
        Me.leptospirosisotputlbl = New System.Windows.Forms.Label()
        Me.canineinfluenzaoutputlbl = New System.Windows.Forms.Label()
        Me.rabiesoutputlbl = New System.Windows.Forms.Label()
        Me.dewormpilloutputlbl = New System.Windows.Forms.Label()
        Me.heartwormpilloutoutlbl = New System.Windows.Forms.Label()
        Me.gbVetInfo = New System.Windows.Forms.GroupBox()
        Me.Vaccineinfodatelbl = New System.Windows.Forms.Label()
        Me.changedollarsignlbl = New System.Windows.Forms.Label()
        Me.changelbl = New System.Windows.Forms.Label()
        Me.payingamountdollarsignlbl = New System.Windows.Forms.Label()
        Me.payingamountlbl = New System.Windows.Forms.Label()
        Me.costdollarsignlbl = New System.Windows.Forms.Label()
        Me.costlbl = New System.Windows.Forms.Label()
        Me.outputinfocostbt = New System.Windows.Forms.Label()
        Me.outputinfopayamountlbl = New System.Windows.Forms.Label()
        Me.outputinfochangelbl = New System.Windows.Forms.Label()
        Me.outputinfodatelbl = New System.Windows.Forms.Label()
        Me.outputinfoexitbt = New System.Windows.Forms.Button()
        Me.outputDogInfogb.SuspendLayout()
        Me.outputownerInfogb.SuspendLayout()
        Me.outputvetInfogb.SuspendLayout()
        Me.vaccinationsoutputgb.SuspendLayout()
        Me.gbVetInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'outputDogInfogb
        '
        Me.outputDogInfogb.Controls.Add(Me.outputownerInfogb)
        Me.outputDogInfogb.Controls.Add(Me.spayedoutputlbl)
        Me.outputDogInfogb.Controls.Add(Me.genderoutputlbl)
        Me.outputDogInfogb.Controls.Add(Me.weightoutputlbl)
        Me.outputDogInfogb.Controls.Add(Me.ageoutputlbl)
        Me.outputDogInfogb.Controls.Add(Me.specialmarkingsoutputlbl)
        Me.outputDogInfogb.Controls.Add(Me.coloroutputlbl)
        Me.outputDogInfogb.Controls.Add(Me.breedoutputlbl)
        Me.outputDogInfogb.Controls.Add(Me.dognameoutputlbl)
        Me.outputDogInfogb.Controls.Add(Me.lblWeight)
        Me.outputDogInfogb.Controls.Add(Me.dognamelbl)
        Me.outputDogInfogb.Controls.Add(Me.genderlb)
        Me.outputDogInfogb.Controls.Add(Me.lblSpayedNeutered)
        Me.outputDogInfogb.Controls.Add(Me.breedlb)
        Me.outputDogInfogb.Controls.Add(Me.colorlb)
        Me.outputDogInfogb.Controls.Add(Me.specialmarklbl)
        Me.outputDogInfogb.Controls.Add(Me.lblDogAge)
        Me.outputDogInfogb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputDogInfogb.Location = New System.Drawing.Point(1, 3)
        Me.outputDogInfogb.Name = "outputDogInfogb"
        Me.outputDogInfogb.Size = New System.Drawing.Size(363, 492)
        Me.outputDogInfogb.TabIndex = 1
        Me.outputDogInfogb.TabStop = False
        Me.outputDogInfogb.Text = "Dog Information"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(6, 215)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(106, 19)
        Me.lblWeight.TabIndex = 0
        Me.lblWeight.Text = "Weight (lbs):"
        '
        'dognamelbl
        '
        Me.dognamelbl.AutoSize = True
        Me.dognamelbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dognamelbl.Location = New System.Drawing.Point(6, 47)
        Me.dognamelbl.Name = "dognamelbl"
        Me.dognamelbl.Size = New System.Drawing.Size(95, 19)
        Me.dognamelbl.TabIndex = 0
        Me.dognamelbl.Text = "Dog Name:"
        '
        'genderlb
        '
        Me.genderlb.AutoSize = True
        Me.genderlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderlb.Location = New System.Drawing.Point(6, 244)
        Me.genderlb.Name = "genderlb"
        Me.genderlb.Size = New System.Drawing.Size(70, 19)
        Me.genderlb.TabIndex = 0
        Me.genderlb.Text = "Gender:"
        '
        'lblSpayedNeutered
        '
        Me.lblSpayedNeutered.AutoSize = True
        Me.lblSpayedNeutered.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpayedNeutered.Location = New System.Drawing.Point(6, 272)
        Me.lblSpayedNeutered.Name = "lblSpayedNeutered"
        Me.lblSpayedNeutered.Size = New System.Drawing.Size(146, 19)
        Me.lblSpayedNeutered.TabIndex = 0
        Me.lblSpayedNeutered.Text = "Spayed/Neutered:"
        '
        'breedlb
        '
        Me.breedlb.AutoSize = True
        Me.breedlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breedlb.Location = New System.Drawing.Point(6, 86)
        Me.breedlb.Name = "breedlb"
        Me.breedlb.Size = New System.Drawing.Size(59, 19)
        Me.breedlb.TabIndex = 0
        Me.breedlb.Text = "Breed:"
        '
        'colorlb
        '
        Me.colorlb.AutoSize = True
        Me.colorlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colorlb.Location = New System.Drawing.Point(6, 122)
        Me.colorlb.Name = "colorlb"
        Me.colorlb.Size = New System.Drawing.Size(56, 19)
        Me.colorlb.TabIndex = 0
        Me.colorlb.Text = "Color:"
        '
        'specialmarklbl
        '
        Me.specialmarklbl.AutoSize = True
        Me.specialmarklbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialmarklbl.Location = New System.Drawing.Point(6, 155)
        Me.specialmarklbl.Name = "specialmarklbl"
        Me.specialmarklbl.Size = New System.Drawing.Size(138, 19)
        Me.specialmarklbl.TabIndex = 0
        Me.specialmarklbl.Text = "Special Markings:"
        '
        'lblDogAge
        '
        Me.lblDogAge.AutoSize = True
        Me.lblDogAge.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDogAge.Location = New System.Drawing.Point(6, 186)
        Me.lblDogAge.Name = "lblDogAge"
        Me.lblDogAge.Size = New System.Drawing.Size(44, 19)
        Me.lblDogAge.TabIndex = 0
        Me.lblDogAge.Text = "Age:"
        '
        'dognameoutputlbl
        '
        Me.dognameoutputlbl.AutoSize = True
        Me.dognameoutputlbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dognameoutputlbl.Location = New System.Drawing.Point(107, 47)
        Me.dognameoutputlbl.Name = "dognameoutputlbl"
        Me.dognameoutputlbl.Size = New System.Drawing.Size(141, 19)
        Me.dognameoutputlbl.TabIndex = 11
        Me.dognameoutputlbl.Text = "dognameoutput"
        '
        'breedoutputlbl
        '
        Me.breedoutputlbl.AutoSize = True
        Me.breedoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breedoutputlbl.Location = New System.Drawing.Point(68, 86)
        Me.breedoutputlbl.Name = "breedoutputlbl"
        Me.breedoutputlbl.Size = New System.Drawing.Size(97, 18)
        Me.breedoutputlbl.TabIndex = 12
        Me.breedoutputlbl.Text = "breedoutput"
        '
        'coloroutputlbl
        '
        Me.coloroutputlbl.AutoSize = True
        Me.coloroutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coloroutputlbl.Location = New System.Drawing.Point(68, 122)
        Me.coloroutputlbl.Name = "coloroutputlbl"
        Me.coloroutputlbl.Size = New System.Drawing.Size(94, 18)
        Me.coloroutputlbl.TabIndex = 13
        Me.coloroutputlbl.Text = "coloroutput"
        '
        'specialmarkingsoutputlbl
        '
        Me.specialmarkingsoutputlbl.AutoSize = True
        Me.specialmarkingsoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialmarkingsoutputlbl.Location = New System.Drawing.Point(150, 155)
        Me.specialmarkingsoutputlbl.Name = "specialmarkingsoutputlbl"
        Me.specialmarkingsoutputlbl.Size = New System.Drawing.Size(177, 18)
        Me.specialmarkingsoutputlbl.TabIndex = 14
        Me.specialmarkingsoutputlbl.Text = "specialmarkingsoutput"
        '
        'ageoutputlbl
        '
        Me.ageoutputlbl.AutoSize = True
        Me.ageoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageoutputlbl.Location = New System.Drawing.Point(56, 186)
        Me.ageoutputlbl.Name = "ageoutputlbl"
        Me.ageoutputlbl.Size = New System.Drawing.Size(82, 18)
        Me.ageoutputlbl.TabIndex = 15
        Me.ageoutputlbl.Text = "ageoutput"
        '
        'weightoutputlbl
        '
        Me.weightoutputlbl.AutoSize = True
        Me.weightoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weightoutputlbl.Location = New System.Drawing.Point(118, 215)
        Me.weightoutputlbl.Name = "weightoutputlbl"
        Me.weightoutputlbl.Size = New System.Drawing.Size(103, 18)
        Me.weightoutputlbl.TabIndex = 16
        Me.weightoutputlbl.Text = "weightoutput"
        '
        'genderoutputlbl
        '
        Me.genderoutputlbl.AutoSize = True
        Me.genderoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderoutputlbl.Location = New System.Drawing.Point(82, 244)
        Me.genderoutputlbl.Name = "genderoutputlbl"
        Me.genderoutputlbl.Size = New System.Drawing.Size(106, 18)
        Me.genderoutputlbl.TabIndex = 17
        Me.genderoutputlbl.Text = "genderoutput"
        '
        'spayedoutputlbl
        '
        Me.spayedoutputlbl.AutoSize = True
        Me.spayedoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spayedoutputlbl.Location = New System.Drawing.Point(159, 272)
        Me.spayedoutputlbl.Name = "spayedoutputlbl"
        Me.spayedoutputlbl.Size = New System.Drawing.Size(178, 18)
        Me.spayedoutputlbl.TabIndex = 18
        Me.spayedoutputlbl.Text = "spayed/neuteredoutput"
        '
        'outputownerInfogb
        '
        Me.outputownerInfogb.Controls.Add(Me.addressoutputlbl)
        Me.outputownerInfogb.Controls.Add(Me.emaillbl)
        Me.outputownerInfogb.Controls.Add(Me.phonenumberoutputlbl)
        Me.outputownerInfogb.Controls.Add(Me.ownernameoutputlbl)
        Me.outputownerInfogb.Controls.Add(Me.Label2)
        Me.outputownerInfogb.Controls.Add(Me.Label1)
        Me.outputownerInfogb.Controls.Add(Me.ownernamelb)
        Me.outputownerInfogb.Controls.Add(Me.ownerphonelb)
        Me.outputownerInfogb.Controls.Add(Me.owneremaillb)
        Me.outputownerInfogb.Controls.Add(Me.owneraddresstxb)
        Me.outputownerInfogb.Controls.Add(Me.owneremailtxb)
        Me.outputownerInfogb.Controls.Add(Me.owneraddresslb)
        Me.outputownerInfogb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputownerInfogb.Location = New System.Drawing.Point(0, 313)
        Me.outputownerInfogb.Name = "outputownerInfogb"
        Me.outputownerInfogb.Size = New System.Drawing.Size(363, 179)
        Me.outputownerInfogb.TabIndex = 2
        Me.outputownerInfogb.TabStop = False
        Me.outputownerInfogb.Text = "Owner Information"
        '
        'ownernamelb
        '
        Me.ownernamelb.AutoSize = True
        Me.ownernamelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ownernamelb.Location = New System.Drawing.Point(11, 47)
        Me.ownernamelb.Name = "ownernamelb"
        Me.ownernamelb.Size = New System.Drawing.Size(114, 19)
        Me.ownernamelb.TabIndex = 0
        Me.ownernamelb.Text = "Owner Name:"
        '
        'ownerphonelb
        '
        Me.ownerphonelb.AutoSize = True
        Me.ownerphonelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ownerphonelb.Location = New System.Drawing.Point(11, 80)
        Me.ownerphonelb.Name = "ownerphonelb"
        Me.ownerphonelb.Size = New System.Drawing.Size(126, 19)
        Me.ownerphonelb.TabIndex = 0
        Me.ownerphonelb.Text = "Phone Number:"
        '
        'owneremaillb
        '
        Me.owneremaillb.AutoSize = True
        Me.owneremaillb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.owneremaillb.Location = New System.Drawing.Point(11, 196)
        Me.owneremaillb.Name = "owneremaillb"
        Me.owneremaillb.Size = New System.Drawing.Size(48, 19)
        Me.owneremaillb.TabIndex = 0
        Me.owneremaillb.Text = "Email"
        '
        'owneraddresstxb
        '
        Me.owneraddresstxb.Location = New System.Drawing.Point(12, 295)
        Me.owneraddresstxb.Name = "owneraddresstxb"
        Me.owneraddresstxb.Size = New System.Drawing.Size(132, 34)
        Me.owneraddresstxb.TabIndex = 14
        '
        'owneremailtxb
        '
        Me.owneremailtxb.Location = New System.Drawing.Point(12, 216)
        Me.owneremailtxb.Name = "owneremailtxb"
        Me.owneremailtxb.Size = New System.Drawing.Size(132, 34)
        Me.owneremailtxb.TabIndex = 13
        '
        'owneraddresslb
        '
        Me.owneraddresslb.AutoSize = True
        Me.owneraddresslb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.owneraddresslb.Location = New System.Drawing.Point(11, 273)
        Me.owneraddresslb.Name = "owneraddresslb"
        Me.owneraddresslb.Size = New System.Drawing.Size(68, 19)
        Me.owneraddresslb.TabIndex = 0
        Me.owneraddresslb.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Address:"
        '
        'ownernameoutputlbl
        '
        Me.ownernameoutputlbl.AutoSize = True
        Me.ownernameoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ownernameoutputlbl.Location = New System.Drawing.Point(131, 47)
        Me.ownernameoutputlbl.Name = "ownernameoutputlbl"
        Me.ownernameoutputlbl.Size = New System.Drawing.Size(142, 18)
        Me.ownernameoutputlbl.TabIndex = 17
        Me.ownernameoutputlbl.Text = "ownernameoutput"
        '
        'phonenumberoutputlbl
        '
        Me.phonenumberoutputlbl.AutoSize = True
        Me.phonenumberoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonenumberoutputlbl.Location = New System.Drawing.Point(143, 80)
        Me.phonenumberoutputlbl.Name = "phonenumberoutputlbl"
        Me.phonenumberoutputlbl.Size = New System.Drawing.Size(157, 18)
        Me.phonenumberoutputlbl.TabIndex = 18
        Me.phonenumberoutputlbl.Text = "phonenumberoutput"
        '
        'emaillbl
        '
        Me.emaillbl.AutoSize = True
        Me.emaillbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emaillbl.Location = New System.Drawing.Point(72, 110)
        Me.emaillbl.Name = "emaillbl"
        Me.emaillbl.Size = New System.Drawing.Size(95, 18)
        Me.emaillbl.TabIndex = 19
        Me.emaillbl.Text = "emailoutput"
        '
        'addressoutputlbl
        '
        Me.addressoutputlbl.AutoSize = True
        Me.addressoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressoutputlbl.Location = New System.Drawing.Point(92, 138)
        Me.addressoutputlbl.Name = "addressoutputlbl"
        Me.addressoutputlbl.Size = New System.Drawing.Size(115, 18)
        Me.addressoutputlbl.TabIndex = 20
        Me.addressoutputlbl.Text = "addressoutput"
        '
        'outputvetInfogb
        '
        Me.outputvetInfogb.Controls.Add(Me.vetnumberoutputlbl)
        Me.outputvetInfogb.Controls.Add(Me.vetnameoutputlbl)
        Me.outputvetInfogb.Controls.Add(Me.vetnamelb)
        Me.outputvetInfogb.Controls.Add(Me.vetphonelb)
        Me.outputvetInfogb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputvetInfogb.Location = New System.Drawing.Point(1, 492)
        Me.outputvetInfogb.Name = "outputvetInfogb"
        Me.outputvetInfogb.Size = New System.Drawing.Size(363, 116)
        Me.outputvetInfogb.TabIndex = 2
        Me.outputvetInfogb.TabStop = False
        Me.outputvetInfogb.Text = "Veteranarian Information"
        '
        'vetnamelb
        '
        Me.vetnamelb.AutoSize = True
        Me.vetnamelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetnamelb.Location = New System.Drawing.Point(6, 49)
        Me.vetnamelb.Name = "vetnamelb"
        Me.vetnamelb.Size = New System.Drawing.Size(153, 19)
        Me.vetnamelb.TabIndex = 0
        Me.vetnamelb.Text = "Veterinarian Name:"
        '
        'vetphonelb
        '
        Me.vetphonelb.AutoSize = True
        Me.vetphonelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetphonelb.Location = New System.Drawing.Point(6, 78)
        Me.vetphonelb.Name = "vetphonelb"
        Me.vetphonelb.Size = New System.Drawing.Size(126, 19)
        Me.vetphonelb.TabIndex = 0
        Me.vetphonelb.Text = "Phone Number:"
        '
        'vetnameoutputlbl
        '
        Me.vetnameoutputlbl.AutoSize = True
        Me.vetnameoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetnameoutputlbl.Location = New System.Drawing.Point(165, 43)
        Me.vetnameoutputlbl.Name = "vetnameoutputlbl"
        Me.vetnameoutputlbl.Size = New System.Drawing.Size(118, 18)
        Me.vetnameoutputlbl.TabIndex = 1
        Me.vetnameoutputlbl.Text = "vetnameoutput"
        '
        'vetnumberoutputlbl
        '
        Me.vetnumberoutputlbl.AutoSize = True
        Me.vetnumberoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetnumberoutputlbl.Location = New System.Drawing.Point(139, 78)
        Me.vetnumberoutputlbl.Name = "vetnumberoutputlbl"
        Me.vetnumberoutputlbl.Size = New System.Drawing.Size(133, 18)
        Me.vetnumberoutputlbl.TabIndex = 2
        Me.vetnumberoutputlbl.Text = "vetnumberoutput"
        '
        'vaccinationsoutputgb
        '
        Me.vaccinationsoutputgb.Controls.Add(Me.heartwormpilloutoutlbl)
        Me.vaccinationsoutputgb.Controls.Add(Me.dewormpilloutputlbl)
        Me.vaccinationsoutputgb.Controls.Add(Me.rabiesoutputlbl)
        Me.vaccinationsoutputgb.Controls.Add(Me.canineinfluenzaoutputlbl)
        Me.vaccinationsoutputgb.Controls.Add(Me.leptospirosisotputlbl)
        Me.vaccinationsoutputgb.Controls.Add(Me.Paraininfluenza)
        Me.vaccinationsoutputgb.Controls.Add(Me.bordetellaoutputlbl)
        Me.vaccinationsoutputgb.Controls.Add(Me.Label3)
        Me.vaccinationsoutputgb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vaccinationsoutputgb.Location = New System.Drawing.Point(484, 3)
        Me.vaccinationsoutputgb.Name = "vaccinationsoutputgb"
        Me.vaccinationsoutputgb.Size = New System.Drawing.Size(416, 290)
        Me.vaccinationsoutputgb.TabIndex = 3
        Me.vaccinationsoutputgb.TabStop = False
        Me.vaccinationsoutputgb.Text = "Vaccinations"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Vaccines chosen:"
        '
        'bordetellaoutputlbl
        '
        Me.bordetellaoutputlbl.AutoSize = True
        Me.bordetellaoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bordetellaoutputlbl.Location = New System.Drawing.Point(10, 72)
        Me.bordetellaoutputlbl.Name = "bordetellaoutputlbl"
        Me.bordetellaoutputlbl.Size = New System.Drawing.Size(57, 18)
        Me.bordetellaoutputlbl.TabIndex = 1
        Me.bordetellaoutputlbl.Text = "Label1"
        '
        'Paraininfluenza
        '
        Me.Paraininfluenza.AutoSize = True
        Me.Paraininfluenza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paraininfluenza.Location = New System.Drawing.Point(10, 101)
        Me.Paraininfluenza.Name = "Paraininfluenza"
        Me.Paraininfluenza.Size = New System.Drawing.Size(57, 18)
        Me.Paraininfluenza.TabIndex = 2
        Me.Paraininfluenza.Text = "Label2"
        '
        'leptospirosisotputlbl
        '
        Me.leptospirosisotputlbl.AutoSize = True
        Me.leptospirosisotputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leptospirosisotputlbl.Location = New System.Drawing.Point(10, 130)
        Me.leptospirosisotputlbl.Name = "leptospirosisotputlbl"
        Me.leptospirosisotputlbl.Size = New System.Drawing.Size(57, 18)
        Me.leptospirosisotputlbl.TabIndex = 3
        Me.leptospirosisotputlbl.Text = "Label3"
        '
        'canineinfluenzaoutputlbl
        '
        Me.canineinfluenzaoutputlbl.AutoSize = True
        Me.canineinfluenzaoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.canineinfluenzaoutputlbl.Location = New System.Drawing.Point(10, 159)
        Me.canineinfluenzaoutputlbl.Name = "canineinfluenzaoutputlbl"
        Me.canineinfluenzaoutputlbl.Size = New System.Drawing.Size(57, 18)
        Me.canineinfluenzaoutputlbl.TabIndex = 4
        Me.canineinfluenzaoutputlbl.Text = "Label4"
        '
        'rabiesoutputlbl
        '
        Me.rabiesoutputlbl.AutoSize = True
        Me.rabiesoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rabiesoutputlbl.Location = New System.Drawing.Point(10, 186)
        Me.rabiesoutputlbl.Name = "rabiesoutputlbl"
        Me.rabiesoutputlbl.Size = New System.Drawing.Size(57, 18)
        Me.rabiesoutputlbl.TabIndex = 5
        Me.rabiesoutputlbl.Text = "Label5"
        '
        'dewormpilloutputlbl
        '
        Me.dewormpilloutputlbl.AutoSize = True
        Me.dewormpilloutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dewormpilloutputlbl.Location = New System.Drawing.Point(10, 215)
        Me.dewormpilloutputlbl.Name = "dewormpilloutputlbl"
        Me.dewormpilloutputlbl.Size = New System.Drawing.Size(57, 18)
        Me.dewormpilloutputlbl.TabIndex = 6
        Me.dewormpilloutputlbl.Text = "Label6"
        '
        'heartwormpilloutoutlbl
        '
        Me.heartwormpilloutoutlbl.AutoSize = True
        Me.heartwormpilloutoutlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heartwormpilloutoutlbl.Location = New System.Drawing.Point(10, 244)
        Me.heartwormpilloutoutlbl.Name = "heartwormpilloutoutlbl"
        Me.heartwormpilloutoutlbl.Size = New System.Drawing.Size(57, 18)
        Me.heartwormpilloutoutlbl.TabIndex = 7
        Me.heartwormpilloutoutlbl.Text = "Label7"
        '
        'gbVetInfo
        '
        Me.gbVetInfo.Controls.Add(Me.outputinfodatelbl)
        Me.gbVetInfo.Controls.Add(Me.outputinfochangelbl)
        Me.gbVetInfo.Controls.Add(Me.outputinfopayamountlbl)
        Me.gbVetInfo.Controls.Add(Me.outputinfocostbt)
        Me.gbVetInfo.Controls.Add(Me.Vaccineinfodatelbl)
        Me.gbVetInfo.Controls.Add(Me.changedollarsignlbl)
        Me.gbVetInfo.Controls.Add(Me.changelbl)
        Me.gbVetInfo.Controls.Add(Me.payingamountdollarsignlbl)
        Me.gbVetInfo.Controls.Add(Me.payingamountlbl)
        Me.gbVetInfo.Controls.Add(Me.costdollarsignlbl)
        Me.gbVetInfo.Controls.Add(Me.costlbl)
        Me.gbVetInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVetInfo.Location = New System.Drawing.Point(484, 316)
        Me.gbVetInfo.Name = "gbVetInfo"
        Me.gbVetInfo.Size = New System.Drawing.Size(416, 217)
        Me.gbVetInfo.TabIndex = 4
        Me.gbVetInfo.TabStop = False
        Me.gbVetInfo.Text = "Payment Information"
        '
        'Vaccineinfodatelbl
        '
        Me.Vaccineinfodatelbl.AutoSize = True
        Me.Vaccineinfodatelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vaccineinfodatelbl.Location = New System.Drawing.Point(7, 138)
        Me.Vaccineinfodatelbl.Name = "Vaccineinfodatelbl"
        Me.Vaccineinfodatelbl.Size = New System.Drawing.Size(96, 18)
        Me.Vaccineinfodatelbl.TabIndex = 378
        Me.Vaccineinfodatelbl.Text = "Today's date:"
        '
        'changedollarsignlbl
        '
        Me.changedollarsignlbl.AutoSize = True
        Me.changedollarsignlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changedollarsignlbl.Location = New System.Drawing.Point(76, 109)
        Me.changedollarsignlbl.Name = "changedollarsignlbl"
        Me.changedollarsignlbl.Size = New System.Drawing.Size(16, 18)
        Me.changedollarsignlbl.TabIndex = 377
        Me.changedollarsignlbl.Text = "$"
        '
        'changelbl
        '
        Me.changelbl.AutoSize = True
        Me.changelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changelbl.Location = New System.Drawing.Point(7, 109)
        Me.changelbl.Name = "changelbl"
        Me.changelbl.Size = New System.Drawing.Size(63, 18)
        Me.changelbl.TabIndex = 372
        Me.changelbl.Text = "Change:"
        '
        'payingamountdollarsignlbl
        '
        Me.payingamountdollarsignlbl.AutoSize = True
        Me.payingamountdollarsignlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payingamountdollarsignlbl.Location = New System.Drawing.Point(124, 80)
        Me.payingamountdollarsignlbl.Name = "payingamountdollarsignlbl"
        Me.payingamountdollarsignlbl.Size = New System.Drawing.Size(16, 18)
        Me.payingamountdollarsignlbl.TabIndex = 371
        Me.payingamountdollarsignlbl.Text = "$"
        '
        'payingamountlbl
        '
        Me.payingamountlbl.AutoSize = True
        Me.payingamountlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payingamountlbl.Location = New System.Drawing.Point(7, 80)
        Me.payingamountlbl.Name = "payingamountlbl"
        Me.payingamountlbl.Size = New System.Drawing.Size(111, 18)
        Me.payingamountlbl.TabIndex = 370
        Me.payingamountlbl.Text = "Paying Amount:"
        '
        'costdollarsignlbl
        '
        Me.costdollarsignlbl.AutoSize = True
        Me.costdollarsignlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costdollarsignlbl.Location = New System.Drawing.Point(63, 47)
        Me.costdollarsignlbl.Name = "costdollarsignlbl"
        Me.costdollarsignlbl.Size = New System.Drawing.Size(16, 18)
        Me.costdollarsignlbl.TabIndex = 369
        Me.costdollarsignlbl.Text = "$"
        '
        'costlbl
        '
        Me.costlbl.AutoSize = True
        Me.costlbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costlbl.Location = New System.Drawing.Point(6, 46)
        Me.costlbl.Name = "costlbl"
        Me.costlbl.Size = New System.Drawing.Size(51, 19)
        Me.costlbl.TabIndex = 368
        Me.costlbl.Text = "Cost:"
        '
        'outputinfocostbt
        '
        Me.outputinfocostbt.AutoSize = True
        Me.outputinfocostbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputinfocostbt.Location = New System.Drawing.Point(85, 46)
        Me.outputinfocostbt.Name = "outputinfocostbt"
        Me.outputinfocostbt.Size = New System.Drawing.Size(57, 18)
        Me.outputinfocostbt.TabIndex = 379
        Me.outputinfocostbt.Text = "Label8"
        '
        'outputinfopayamountlbl
        '
        Me.outputinfopayamountlbl.AutoSize = True
        Me.outputinfopayamountlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputinfopayamountlbl.Location = New System.Drawing.Point(146, 80)
        Me.outputinfopayamountlbl.Name = "outputinfopayamountlbl"
        Me.outputinfopayamountlbl.Size = New System.Drawing.Size(57, 18)
        Me.outputinfopayamountlbl.TabIndex = 380
        Me.outputinfopayamountlbl.Text = "Label9"
        '
        'outputinfochangelbl
        '
        Me.outputinfochangelbl.AutoSize = True
        Me.outputinfochangelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputinfochangelbl.Location = New System.Drawing.Point(98, 109)
        Me.outputinfochangelbl.Name = "outputinfochangelbl"
        Me.outputinfochangelbl.Size = New System.Drawing.Size(66, 18)
        Me.outputinfochangelbl.TabIndex = 381
        Me.outputinfochangelbl.Text = "Label10"
        '
        'outputinfodatelbl
        '
        Me.outputinfodatelbl.AutoSize = True
        Me.outputinfodatelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputinfodatelbl.Location = New System.Drawing.Point(109, 138)
        Me.outputinfodatelbl.Name = "outputinfodatelbl"
        Me.outputinfodatelbl.Size = New System.Drawing.Size(66, 18)
        Me.outputinfodatelbl.TabIndex = 382
        Me.outputinfodatelbl.Text = "Label11"
        '
        'outputinfoexitbt
        '
        Me.outputinfoexitbt.Location = New System.Drawing.Point(813, 611)
        Me.outputinfoexitbt.Name = "outputinfoexitbt"
        Me.outputinfoexitbt.Size = New System.Drawing.Size(75, 23)
        Me.outputinfoexitbt.TabIndex = 36
        Me.outputinfoexitbt.Text = "Exit"
        Me.outputinfoexitbt.UseVisualStyleBackColor = True
        '
        'Outputform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 640)
        Me.Controls.Add(Me.outputinfoexitbt)
        Me.Controls.Add(Me.gbVetInfo)
        Me.Controls.Add(Me.vaccinationsoutputgb)
        Me.Controls.Add(Me.outputvetInfogb)
        Me.Controls.Add(Me.outputDogInfogb)
        Me.Name = "Outputform"
        Me.Text = "OutputForm"
        Me.outputDogInfogb.ResumeLayout(False)
        Me.outputDogInfogb.PerformLayout()
        Me.outputownerInfogb.ResumeLayout(False)
        Me.outputownerInfogb.PerformLayout()
        Me.outputvetInfogb.ResumeLayout(False)
        Me.outputvetInfogb.PerformLayout()
        Me.vaccinationsoutputgb.ResumeLayout(False)
        Me.vaccinationsoutputgb.PerformLayout()
        Me.gbVetInfo.ResumeLayout(False)
        Me.gbVetInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents outputDogInfogb As GroupBox
    Friend WithEvents spayedoutputlbl As Label
    Friend WithEvents genderoutputlbl As Label
    Friend WithEvents weightoutputlbl As Label
    Friend WithEvents ageoutputlbl As Label
    Friend WithEvents specialmarkingsoutputlbl As Label
    Friend WithEvents coloroutputlbl As Label
    Friend WithEvents breedoutputlbl As Label
    Friend WithEvents dognameoutputlbl As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents dognamelbl As Label
    Friend WithEvents genderlb As Label
    Friend WithEvents lblSpayedNeutered As Label
    Friend WithEvents breedlb As Label
    Friend WithEvents colorlb As Label
    Friend WithEvents specialmarklbl As Label
    Friend WithEvents lblDogAge As Label
    Friend WithEvents outputownerInfogb As GroupBox
    Friend WithEvents ownernamelb As Label
    Friend WithEvents ownerphonelb As Label
    Friend WithEvents owneremaillb As Label
    Friend WithEvents owneraddresstxb As TextBox
    Friend WithEvents owneremailtxb As TextBox
    Friend WithEvents owneraddresslb As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents addressoutputlbl As Label
    Friend WithEvents emaillbl As Label
    Friend WithEvents phonenumberoutputlbl As Label
    Friend WithEvents ownernameoutputlbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents outputvetInfogb As GroupBox
    Friend WithEvents vetnumberoutputlbl As Label
    Friend WithEvents vetnameoutputlbl As Label
    Friend WithEvents vetnamelb As Label
    Friend WithEvents vetphonelb As Label
    Friend WithEvents vaccinationsoutputgb As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents canineinfluenzaoutputlbl As Label
    Friend WithEvents leptospirosisotputlbl As Label
    Friend WithEvents Paraininfluenza As Label
    Friend WithEvents bordetellaoutputlbl As Label
    Friend WithEvents heartwormpilloutoutlbl As Label
    Friend WithEvents dewormpilloutputlbl As Label
    Friend WithEvents rabiesoutputlbl As Label
    Friend WithEvents gbVetInfo As GroupBox
    Friend WithEvents Vaccineinfodatelbl As Label
    Friend WithEvents changedollarsignlbl As Label
    Friend WithEvents changelbl As Label
    Friend WithEvents payingamountdollarsignlbl As Label
    Friend WithEvents payingamountlbl As Label
    Friend WithEvents costdollarsignlbl As Label
    Friend WithEvents costlbl As Label
    Friend WithEvents outputinfodatelbl As Label
    Friend WithEvents outputinfochangelbl As Label
    Friend WithEvents outputinfopayamountlbl As Label
    Friend WithEvents outputinfocostbt As Label
    Friend WithEvents outputinfoexitbt As Button
End Class
