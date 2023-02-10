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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Outputform))
        Me.outputDogInfogb = New System.Windows.Forms.GroupBox()
        Me.spayedoutputlbl = New System.Windows.Forms.Label()
        Me.genderoutputlbl = New System.Windows.Forms.Label()
        Me.weightoutputlbl = New System.Windows.Forms.Label()
        Me.ageoutputlbl = New System.Windows.Forms.Label()
        Me.specialmarkingsoutputlbl = New System.Windows.Forms.Label()
        Me.coloroutputlbl = New System.Windows.Forms.Label()
        Me.breedoutputlbl = New System.Windows.Forms.Label()
        Me.lblDogName = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.dognamelbl = New System.Windows.Forms.Label()
        Me.genderlb = New System.Windows.Forms.Label()
        Me.lblSpayedNeutered = New System.Windows.Forms.Label()
        Me.breedlb = New System.Windows.Forms.Label()
        Me.colorlb = New System.Windows.Forms.Label()
        Me.specialmarklbl = New System.Windows.Forms.Label()
        Me.lblDogAge = New System.Windows.Forms.Label()
        Me.outputownerInfogb = New System.Windows.Forms.GroupBox()
        Me.ownernameoutputlbl = New System.Windows.Forms.Label()
        Me.addressoutputlbl = New System.Windows.Forms.Label()
        Me.emailoutputbl = New System.Windows.Forms.Label()
        Me.phonenumberoutputlbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ownernamelb = New System.Windows.Forms.Label()
        Me.ownerphonelb = New System.Windows.Forms.Label()
        Me.owneremaillb = New System.Windows.Forms.Label()
        Me.owneraddresstxb = New System.Windows.Forms.TextBox()
        Me.owneremailtxb = New System.Windows.Forms.TextBox()
        Me.owneraddresslb = New System.Windows.Forms.Label()
        Me.outputvetInfogb = New System.Windows.Forms.GroupBox()
        Me.vetnumberoutputlbl = New System.Windows.Forms.Label()
        Me.vetnameoutputlbl = New System.Windows.Forms.Label()
        Me.vetnamelb = New System.Windows.Forms.Label()
        Me.vetphonelb = New System.Windows.Forms.Label()
        Me.vaccinationsoutputgb = New System.Windows.Forms.GroupBox()
        Me.lblPurchasedVacc = New System.Windows.Forms.Label()
        Me.lblPrevVaccines = New System.Windows.Forms.Label()
        Me.lblVaccPurchase = New System.Windows.Forms.Label()
        Me.lblVaccRecieve = New System.Windows.Forms.Label()
        Me.gbVetInfo = New System.Windows.Forms.GroupBox()
        Me.outputinfodatelbl = New System.Windows.Forms.Label()
        Me.outputinfocostlbl = New System.Windows.Forms.Label()
        Me.Vaccineinfodatelbl = New System.Windows.Forms.Label()
        Me.costdollarsignlbl = New System.Windows.Forms.Label()
        Me.costlbl = New System.Windows.Forms.Label()
        Me.btbExitOutput = New System.Windows.Forms.Button()
        Me.pbOutputHeader = New System.Windows.Forms.PictureBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.outputDogInfogb.SuspendLayout()
        Me.outputownerInfogb.SuspendLayout()
        Me.outputvetInfogb.SuspendLayout()
        Me.vaccinationsoutputgb.SuspendLayout()
        Me.gbVetInfo.SuspendLayout()
        CType(Me.pbOutputHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'outputDogInfogb
        '
        Me.outputDogInfogb.Controls.Add(Me.spayedoutputlbl)
        Me.outputDogInfogb.Controls.Add(Me.genderoutputlbl)
        Me.outputDogInfogb.Controls.Add(Me.weightoutputlbl)
        Me.outputDogInfogb.Controls.Add(Me.ageoutputlbl)
        Me.outputDogInfogb.Controls.Add(Me.specialmarkingsoutputlbl)
        Me.outputDogInfogb.Controls.Add(Me.coloroutputlbl)
        Me.outputDogInfogb.Controls.Add(Me.breedoutputlbl)
        Me.outputDogInfogb.Controls.Add(Me.lblDogName)
        Me.outputDogInfogb.Controls.Add(Me.lblWeight)
        Me.outputDogInfogb.Controls.Add(Me.dognamelbl)
        Me.outputDogInfogb.Controls.Add(Me.genderlb)
        Me.outputDogInfogb.Controls.Add(Me.lblSpayedNeutered)
        Me.outputDogInfogb.Controls.Add(Me.breedlb)
        Me.outputDogInfogb.Controls.Add(Me.colorlb)
        Me.outputDogInfogb.Controls.Add(Me.specialmarklbl)
        Me.outputDogInfogb.Controls.Add(Me.lblDogAge)
        Me.outputDogInfogb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputDogInfogb.ForeColor = System.Drawing.Color.DarkCyan
        Me.outputDogInfogb.Location = New System.Drawing.Point(12, 164)
        Me.outputDogInfogb.Name = "outputDogInfogb"
        Me.outputDogInfogb.Size = New System.Drawing.Size(391, 282)
        Me.outputDogInfogb.TabIndex = 1
        Me.outputDogInfogb.TabStop = False
        Me.outputDogInfogb.Text = "Dog Information"
        '
        'spayedoutputlbl
        '
        Me.spayedoutputlbl.AutoSize = True
        Me.spayedoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spayedoutputlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.spayedoutputlbl.Location = New System.Drawing.Point(169, 248)
        Me.spayedoutputlbl.Name = "spayedoutputlbl"
        Me.spayedoutputlbl.Size = New System.Drawing.Size(157, 18)
        Me.spayedoutputlbl.TabIndex = 18
        Me.spayedoutputlbl.Text = "spayed/neuteredoutput"
        Me.spayedoutputlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'genderoutputlbl
        '
        Me.genderoutputlbl.AutoSize = True
        Me.genderoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderoutputlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.genderoutputlbl.Location = New System.Drawing.Point(232, 220)
        Me.genderoutputlbl.Name = "genderoutputlbl"
        Me.genderoutputlbl.Size = New System.Drawing.Size(94, 18)
        Me.genderoutputlbl.TabIndex = 17
        Me.genderoutputlbl.Text = "genderoutput"
        Me.genderoutputlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'weightoutputlbl
        '
        Me.weightoutputlbl.AutoSize = True
        Me.weightoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weightoutputlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.weightoutputlbl.Location = New System.Drawing.Point(235, 191)
        Me.weightoutputlbl.Name = "weightoutputlbl"
        Me.weightoutputlbl.Size = New System.Drawing.Size(91, 18)
        Me.weightoutputlbl.TabIndex = 16
        Me.weightoutputlbl.Text = "weightoutput"
        Me.weightoutputlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ageoutputlbl
        '
        Me.ageoutputlbl.AutoSize = True
        Me.ageoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageoutputlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ageoutputlbl.Location = New System.Drawing.Point(253, 160)
        Me.ageoutputlbl.Name = "ageoutputlbl"
        Me.ageoutputlbl.Size = New System.Drawing.Size(73, 18)
        Me.ageoutputlbl.TabIndex = 15
        Me.ageoutputlbl.Text = "ageoutput"
        Me.ageoutputlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'specialmarkingsoutputlbl
        '
        Me.specialmarkingsoutputlbl.AutoSize = True
        Me.specialmarkingsoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialmarkingsoutputlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.specialmarkingsoutputlbl.Location = New System.Drawing.Point(170, 132)
        Me.specialmarkingsoutputlbl.Name = "specialmarkingsoutputlbl"
        Me.specialmarkingsoutputlbl.Size = New System.Drawing.Size(156, 18)
        Me.specialmarkingsoutputlbl.TabIndex = 14
        Me.specialmarkingsoutputlbl.Text = "specialmarkingsoutput"
        Me.specialmarkingsoutputlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'coloroutputlbl
        '
        Me.coloroutputlbl.AutoSize = True
        Me.coloroutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coloroutputlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.coloroutputlbl.Location = New System.Drawing.Point(234, 104)
        Me.coloroutputlbl.Name = "coloroutputlbl"
        Me.coloroutputlbl.Size = New System.Drawing.Size(92, 20)
        Me.coloroutputlbl.TabIndex = 13
        Me.coloroutputlbl.Text = "coloroutput"
        Me.coloroutputlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'breedoutputlbl
        '
        Me.breedoutputlbl.AutoSize = True
        Me.breedoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breedoutputlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.breedoutputlbl.Location = New System.Drawing.Point(240, 78)
        Me.breedoutputlbl.Name = "breedoutputlbl"
        Me.breedoutputlbl.Size = New System.Drawing.Size(86, 18)
        Me.breedoutputlbl.TabIndex = 12
        Me.breedoutputlbl.Text = "breedoutput"
        Me.breedoutputlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDogName
        '
        Me.lblDogName.AutoSize = True
        Me.lblDogName.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDogName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDogName.Location = New System.Drawing.Point(311, 50)
        Me.lblDogName.Name = "lblDogName"
        Me.lblDogName.Size = New System.Drawing.Size(15, 19)
        Me.lblDogName.TabIndex = 11
        Me.lblDogName.Text = "r"
        Me.lblDogName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblWeight.Location = New System.Drawing.Point(0, 188)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(139, 22)
        Me.lblWeight.TabIndex = 0
        Me.lblWeight.Text = "Weight (lbs):"
        '
        'dognamelbl
        '
        Me.dognamelbl.AutoSize = True
        Me.dognamelbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dognamelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dognamelbl.Location = New System.Drawing.Point(0, 44)
        Me.dognamelbl.Name = "dognamelbl"
        Me.dognamelbl.Size = New System.Drawing.Size(117, 22)
        Me.dognamelbl.TabIndex = 0
        Me.dognamelbl.Text = "Dog Name:"
        '
        'genderlb
        '
        Me.genderlb.AutoSize = True
        Me.genderlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderlb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.genderlb.Location = New System.Drawing.Point(0, 220)
        Me.genderlb.Name = "genderlb"
        Me.genderlb.Size = New System.Drawing.Size(87, 22)
        Me.genderlb.TabIndex = 0
        Me.genderlb.Text = "Gender:"
        '
        'lblSpayedNeutered
        '
        Me.lblSpayedNeutered.AutoSize = True
        Me.lblSpayedNeutered.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpayedNeutered.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSpayedNeutered.Location = New System.Drawing.Point(0, 245)
        Me.lblSpayedNeutered.Name = "lblSpayedNeutered"
        Me.lblSpayedNeutered.Size = New System.Drawing.Size(185, 22)
        Me.lblSpayedNeutered.TabIndex = 0
        Me.lblSpayedNeutered.Text = "Spayed/Neutered:"
        '
        'breedlb
        '
        Me.breedlb.AutoSize = True
        Me.breedlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breedlb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.breedlb.Location = New System.Drawing.Point(0, 74)
        Me.breedlb.Name = "breedlb"
        Me.breedlb.Size = New System.Drawing.Size(74, 22)
        Me.breedlb.TabIndex = 0
        Me.breedlb.Text = "Breed:"
        '
        'colorlb
        '
        Me.colorlb.AutoSize = True
        Me.colorlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colorlb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.colorlb.Location = New System.Drawing.Point(0, 102)
        Me.colorlb.Name = "colorlb"
        Me.colorlb.Size = New System.Drawing.Size(68, 22)
        Me.colorlb.TabIndex = 0
        Me.colorlb.Text = "Color:"
        '
        'specialmarklbl
        '
        Me.specialmarklbl.AutoSize = True
        Me.specialmarklbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialmarklbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.specialmarklbl.Location = New System.Drawing.Point(0, 132)
        Me.specialmarklbl.Name = "specialmarklbl"
        Me.specialmarklbl.Size = New System.Drawing.Size(180, 22)
        Me.specialmarklbl.TabIndex = 0
        Me.specialmarklbl.Text = "Special Markings:"
        '
        'lblDogAge
        '
        Me.lblDogAge.AutoSize = True
        Me.lblDogAge.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDogAge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDogAge.Location = New System.Drawing.Point(0, 160)
        Me.lblDogAge.Name = "lblDogAge"
        Me.lblDogAge.Size = New System.Drawing.Size(48, 19)
        Me.lblDogAge.TabIndex = 0
        Me.lblDogAge.Text = "Age:"
        '
        'outputownerInfogb
        '
        Me.outputownerInfogb.Controls.Add(Me.ownernameoutputlbl)
        Me.outputownerInfogb.Controls.Add(Me.addressoutputlbl)
        Me.outputownerInfogb.Controls.Add(Me.emailoutputbl)
        Me.outputownerInfogb.Controls.Add(Me.phonenumberoutputlbl)
        Me.outputownerInfogb.Controls.Add(Me.Label2)
        Me.outputownerInfogb.Controls.Add(Me.Label1)
        Me.outputownerInfogb.Controls.Add(Me.ownernamelb)
        Me.outputownerInfogb.Controls.Add(Me.ownerphonelb)
        Me.outputownerInfogb.Controls.Add(Me.owneremaillb)
        Me.outputownerInfogb.Controls.Add(Me.owneraddresstxb)
        Me.outputownerInfogb.Controls.Add(Me.owneremailtxb)
        Me.outputownerInfogb.Controls.Add(Me.owneraddresslb)
        Me.outputownerInfogb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputownerInfogb.ForeColor = System.Drawing.Color.DarkCyan
        Me.outputownerInfogb.Location = New System.Drawing.Point(12, 452)
        Me.outputownerInfogb.Name = "outputownerInfogb"
        Me.outputownerInfogb.Size = New System.Drawing.Size(391, 167)
        Me.outputownerInfogb.TabIndex = 2
        Me.outputownerInfogb.TabStop = False
        Me.outputownerInfogb.Text = "Owner Information"
        '
        'ownernameoutputlbl
        '
        Me.ownernameoutputlbl.AutoSize = True
        Me.ownernameoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ownernameoutputlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ownernameoutputlbl.Location = New System.Drawing.Point(199, 47)
        Me.ownernameoutputlbl.Name = "ownernameoutputlbl"
        Me.ownernameoutputlbl.Size = New System.Drawing.Size(127, 18)
        Me.ownernameoutputlbl.TabIndex = 17
        Me.ownernameoutputlbl.Text = "ownernameoutput"
        Me.ownernameoutputlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'addressoutputlbl
        '
        Me.addressoutputlbl.AutoSize = True
        Me.addressoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressoutputlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.addressoutputlbl.Location = New System.Drawing.Point(224, 137)
        Me.addressoutputlbl.Name = "addressoutputlbl"
        Me.addressoutputlbl.Size = New System.Drawing.Size(102, 18)
        Me.addressoutputlbl.TabIndex = 20
        Me.addressoutputlbl.Text = "addressoutput"
        Me.addressoutputlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'emailoutputbl
        '
        Me.emailoutputbl.AutoSize = True
        Me.emailoutputbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailoutputbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.emailoutputbl.Location = New System.Drawing.Point(242, 105)
        Me.emailoutputbl.Name = "emailoutputbl"
        Me.emailoutputbl.Size = New System.Drawing.Size(84, 18)
        Me.emailoutputbl.TabIndex = 19
        Me.emailoutputbl.Text = "emailoutput"
        Me.emailoutputbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'phonenumberoutputlbl
        '
        Me.phonenumberoutputlbl.AutoSize = True
        Me.phonenumberoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonenumberoutputlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.phonenumberoutputlbl.Location = New System.Drawing.Point(186, 77)
        Me.phonenumberoutputlbl.Name = "phonenumberoutputlbl"
        Me.phonenumberoutputlbl.Size = New System.Drawing.Size(140, 18)
        Me.phonenumberoutputlbl.TabIndex = 18
        Me.phonenumberoutputlbl.Text = "phonenumberoutput"
        Me.phonenumberoutputlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(0, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 22)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 22)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Email:"
        '
        'ownernamelb
        '
        Me.ownernamelb.AutoSize = True
        Me.ownernamelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ownernamelb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ownernamelb.Location = New System.Drawing.Point(0, 43)
        Me.ownernamelb.Name = "ownernamelb"
        Me.ownernamelb.Size = New System.Drawing.Size(140, 22)
        Me.ownernamelb.TabIndex = 0
        Me.ownernamelb.Text = "Owner Name:"
        '
        'ownerphonelb
        '
        Me.ownerphonelb.AutoSize = True
        Me.ownerphonelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ownerphonelb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ownerphonelb.Location = New System.Drawing.Point(0, 74)
        Me.ownerphonelb.Name = "ownerphonelb"
        Me.ownerphonelb.Size = New System.Drawing.Size(158, 22)
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
        'outputvetInfogb
        '
        Me.outputvetInfogb.Controls.Add(Me.vetnumberoutputlbl)
        Me.outputvetInfogb.Controls.Add(Me.vetnameoutputlbl)
        Me.outputvetInfogb.Controls.Add(Me.vetnamelb)
        Me.outputvetInfogb.Controls.Add(Me.vetphonelb)
        Me.outputvetInfogb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputvetInfogb.ForeColor = System.Drawing.Color.DarkCyan
        Me.outputvetInfogb.Location = New System.Drawing.Point(12, 625)
        Me.outputvetInfogb.Name = "outputvetInfogb"
        Me.outputvetInfogb.Size = New System.Drawing.Size(385, 97)
        Me.outputvetInfogb.TabIndex = 2
        Me.outputvetInfogb.TabStop = False
        Me.outputvetInfogb.Text = "Veteranarian Information"
        '
        'vetnumberoutputlbl
        '
        Me.vetnumberoutputlbl.AutoSize = True
        Me.vetnumberoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetnumberoutputlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.vetnumberoutputlbl.Location = New System.Drawing.Point(208, 67)
        Me.vetnumberoutputlbl.Name = "vetnumberoutputlbl"
        Me.vetnumberoutputlbl.Size = New System.Drawing.Size(118, 18)
        Me.vetnumberoutputlbl.TabIndex = 2
        Me.vetnumberoutputlbl.Text = "vetnumberoutput"
        Me.vetnumberoutputlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'vetnameoutputlbl
        '
        Me.vetnameoutputlbl.AutoSize = True
        Me.vetnameoutputlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetnameoutputlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.vetnameoutputlbl.Location = New System.Drawing.Point(221, 34)
        Me.vetnameoutputlbl.Name = "vetnameoutputlbl"
        Me.vetnameoutputlbl.Size = New System.Drawing.Size(105, 18)
        Me.vetnameoutputlbl.TabIndex = 1
        Me.vetnameoutputlbl.Text = "vetnameoutput"
        Me.vetnameoutputlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'vetnamelb
        '
        Me.vetnamelb.AutoSize = True
        Me.vetnamelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetnamelb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.vetnamelb.Location = New System.Drawing.Point(6, 30)
        Me.vetnamelb.Name = "vetnamelb"
        Me.vetnamelb.Size = New System.Drawing.Size(197, 22)
        Me.vetnamelb.TabIndex = 0
        Me.vetnamelb.Text = "Veterinarian Name:"
        '
        'vetphonelb
        '
        Me.vetphonelb.AutoSize = True
        Me.vetphonelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetphonelb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.vetphonelb.Location = New System.Drawing.Point(6, 58)
        Me.vetphonelb.Name = "vetphonelb"
        Me.vetphonelb.Size = New System.Drawing.Size(158, 22)
        Me.vetphonelb.TabIndex = 0
        Me.vetphonelb.Text = "Phone Number:"
        '
        'vaccinationsoutputgb
        '
        Me.vaccinationsoutputgb.Controls.Add(Me.lblPrevVaccines)
        Me.vaccinationsoutputgb.Controls.Add(Me.lblVaccRecieve)
        Me.vaccinationsoutputgb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vaccinationsoutputgb.ForeColor = System.Drawing.Color.DarkCyan
        Me.vaccinationsoutputgb.Location = New System.Drawing.Point(445, 175)
        Me.vaccinationsoutputgb.Name = "vaccinationsoutputgb"
        Me.vaccinationsoutputgb.Size = New System.Drawing.Size(443, 256)
        Me.vaccinationsoutputgb.TabIndex = 3
        Me.vaccinationsoutputgb.TabStop = False
        Me.vaccinationsoutputgb.Text = "Vaccinations"
        '
        'lblPurchasedVacc
        '
        Me.lblPurchasedVacc.AutoSize = True
        Me.lblPurchasedVacc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurchasedVacc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPurchasedVacc.Location = New System.Drawing.Point(462, 388)
        Me.lblPurchasedVacc.Name = "lblPurchasedVacc"
        Me.lblPurchasedVacc.Size = New System.Drawing.Size(156, 18)
        Me.lblPurchasedVacc.TabIndex = 19
        Me.lblPurchasedVacc.Text = "specialmarkingsoutput"
        Me.lblPurchasedVacc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPrevVaccines
        '
        Me.lblPrevVaccines.AutoSize = True
        Me.lblPrevVaccines.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevVaccines.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPrevVaccines.Location = New System.Drawing.Point(27, 78)
        Me.lblPrevVaccines.Name = "lblPrevVaccines"
        Me.lblPrevVaccines.Size = New System.Drawing.Size(156, 18)
        Me.lblPrevVaccines.TabIndex = 19
        Me.lblPrevVaccines.Text = "specialmarkingsoutput"
        Me.lblPrevVaccines.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVaccPurchase
        '
        Me.lblVaccPurchase.AutoSize = True
        Me.lblVaccPurchase.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVaccPurchase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblVaccPurchase.Location = New System.Drawing.Point(451, 339)
        Me.lblVaccPurchase.Name = "lblVaccPurchase"
        Me.lblVaccPurchase.Size = New System.Drawing.Size(243, 22)
        Me.lblVaccPurchase.TabIndex = 38
        Me.lblVaccPurchase.Text = "Vaccinations Purchased:"
        '
        'lblVaccRecieve
        '
        Me.lblVaccRecieve.AutoSize = True
        Me.lblVaccRecieve.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVaccRecieve.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblVaccRecieve.Location = New System.Drawing.Point(6, 36)
        Me.lblVaccRecieve.Name = "lblVaccRecieve"
        Me.lblVaccRecieve.Size = New System.Drawing.Size(231, 22)
        Me.lblVaccRecieve.TabIndex = 0
        Me.lblVaccRecieve.Text = "Vaccinations Recieved:"
        '
        'gbVetInfo
        '
        Me.gbVetInfo.Controls.Add(Me.outputinfodatelbl)
        Me.gbVetInfo.Controls.Add(Me.outputinfocostlbl)
        Me.gbVetInfo.Controls.Add(Me.Vaccineinfodatelbl)
        Me.gbVetInfo.Controls.Add(Me.costdollarsignlbl)
        Me.gbVetInfo.Controls.Add(Me.costlbl)
        Me.gbVetInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVetInfo.ForeColor = System.Drawing.Color.DarkCyan
        Me.gbVetInfo.Location = New System.Drawing.Point(445, 498)
        Me.gbVetInfo.Name = "gbVetInfo"
        Me.gbVetInfo.Size = New System.Drawing.Size(443, 148)
        Me.gbVetInfo.TabIndex = 4
        Me.gbVetInfo.TabStop = False
        Me.gbVetInfo.Text = "Payment Information"
        '
        'outputinfodatelbl
        '
        Me.outputinfodatelbl.AutoSize = True
        Me.outputinfodatelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputinfodatelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.outputinfodatelbl.Location = New System.Drawing.Point(188, 101)
        Me.outputinfodatelbl.Name = "outputinfodatelbl"
        Me.outputinfodatelbl.Size = New System.Drawing.Size(77, 18)
        Me.outputinfodatelbl.TabIndex = 382
        Me.outputinfodatelbl.Text = "dateoutput"
        Me.outputinfodatelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'outputinfocostlbl
        '
        Me.outputinfocostlbl.AutoSize = True
        Me.outputinfocostlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputinfocostlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.outputinfocostlbl.Location = New System.Drawing.Point(188, 47)
        Me.outputinfocostlbl.Name = "outputinfocostlbl"
        Me.outputinfocostlbl.Size = New System.Drawing.Size(78, 18)
        Me.outputinfocostlbl.TabIndex = 379
        Me.outputinfocostlbl.Text = "costoutput"
        Me.outputinfocostlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Vaccineinfodatelbl
        '
        Me.Vaccineinfodatelbl.AutoSize = True
        Me.Vaccineinfodatelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vaccineinfodatelbl.Location = New System.Drawing.Point(7, 101)
        Me.Vaccineinfodatelbl.Name = "Vaccineinfodatelbl"
        Me.Vaccineinfodatelbl.Size = New System.Drawing.Size(96, 18)
        Me.Vaccineinfodatelbl.TabIndex = 378
        Me.Vaccineinfodatelbl.Text = "Today's date:"
        '
        'costdollarsignlbl
        '
        Me.costdollarsignlbl.AutoSize = True
        Me.costdollarsignlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costdollarsignlbl.Location = New System.Drawing.Point(157, 47)
        Me.costdollarsignlbl.Name = "costdollarsignlbl"
        Me.costdollarsignlbl.Size = New System.Drawing.Size(16, 18)
        Me.costdollarsignlbl.TabIndex = 369
        Me.costdollarsignlbl.Text = "$"
        '
        'costlbl
        '
        Me.costlbl.AutoSize = True
        Me.costlbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costlbl.Location = New System.Drawing.Point(6, 47)
        Me.costlbl.Name = "costlbl"
        Me.costlbl.Size = New System.Drawing.Size(51, 19)
        Me.costlbl.TabIndex = 368
        Me.costlbl.Text = "Cost:"
        '
        'btbExitOutput
        '
        Me.btbExitOutput.BackColor = System.Drawing.Color.White
        Me.btbExitOutput.Location = New System.Drawing.Point(790, 686)
        Me.btbExitOutput.Name = "btbExitOutput"
        Me.btbExitOutput.Size = New System.Drawing.Size(98, 33)
        Me.btbExitOutput.TabIndex = 36
        Me.btbExitOutput.Text = "Exit"
        Me.btbExitOutput.UseVisualStyleBackColor = False
        '
        'pbOutputHeader
        '
        Me.pbOutputHeader.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.outputheader
        Me.pbOutputHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbOutputHeader.Location = New System.Drawing.Point(-3, -2)
        Me.pbOutputHeader.Name = "pbOutputHeader"
        Me.pbOutputHeader.Size = New System.Drawing.Size(903, 171)
        Me.pbOutputHeader.TabIndex = 37
        Me.pbOutputHeader.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(420, 686)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(104, 33)
        Me.btnPrint.TabIndex = 38
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Outputform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 731)
        Me.Controls.Add(Me.lblPurchasedVacc)
        Me.Controls.Add(Me.lblVaccPurchase)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.outputownerInfogb)
        Me.Controls.Add(Me.pbOutputHeader)
        Me.Controls.Add(Me.btbExitOutput)
        Me.Controls.Add(Me.vaccinationsoutputgb)
        Me.Controls.Add(Me.gbVetInfo)
        Me.Controls.Add(Me.outputvetInfogb)
        Me.Controls.Add(Me.outputDogInfogb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
        CType(Me.pbOutputHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents outputDogInfogb As GroupBox
    Friend WithEvents spayedoutputlbl As Label
    Friend WithEvents genderoutputlbl As Label
    Friend WithEvents weightoutputlbl As Label
    Friend WithEvents ageoutputlbl As Label
    Friend WithEvents specialmarkingsoutputlbl As Label
    Friend WithEvents coloroutputlbl As Label
    Friend WithEvents breedoutputlbl As Label
    Friend WithEvents lblDogName As Label
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
    Friend WithEvents emailoutputbl As Label
    Friend WithEvents phonenumberoutputlbl As Label
    Friend WithEvents ownernameoutputlbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents outputvetInfogb As GroupBox
    Friend WithEvents vetnumberoutputlbl As Label
    Friend WithEvents vetnameoutputlbl As Label
    Friend WithEvents vetnamelb As Label
    Friend WithEvents vetphonelb As Label
    Friend WithEvents vaccinationsoutputgb As GroupBox
    Friend WithEvents lblVaccRecieve As Label
    Friend WithEvents gbVetInfo As GroupBox
    Friend WithEvents Vaccineinfodatelbl As Label
    Friend WithEvents costdollarsignlbl As Label
    Friend WithEvents costlbl As Label
    Friend WithEvents outputinfodatelbl As Label
    Friend WithEvents outputinfocostlbl As Label
    Friend WithEvents btbExitOutput As Button
    Friend WithEvents pbOutputHeader As PictureBox
    Friend WithEvents lblVaccPurchase As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblPurchasedVacc As Label
    Friend WithEvents lblPrevVaccines As Label
End Class
