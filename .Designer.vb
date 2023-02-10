<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GeneralInformationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeneralInformationForm))
        Me.dognamelbl = New System.Windows.Forms.Label()
        Me.breedlb = New System.Windows.Forms.Label()
        Me.colorlb = New System.Windows.Forms.Label()
        Me.specialmarklbl = New System.Windows.Forms.Label()
        Me.lblDogAge = New System.Windows.Forms.Label()
        Me.sexlbl = New System.Windows.Forms.Label()
        Me.gbDogInfo = New System.Windows.Forms.GroupBox()
        Me.pbSex = New System.Windows.Forms.PictureBox()
        Me.pbSpayNeu = New System.Windows.Forms.PictureBox()
        Me.pbWeight = New System.Windows.Forms.PictureBox()
        Me.pbAge = New System.Windows.Forms.PictureBox()
        Me.pbSpecMark = New System.Windows.Forms.PictureBox()
        Me.pbColor = New System.Windows.Forms.PictureBox()
        Me.pbBreed = New System.Windows.Forms.PictureBox()
        Me.pbDate = New System.Windows.Forms.PictureBox()
        Me.gbSpayedNeutered = New System.Windows.Forms.GroupBox()
        Me.lblSpayedNeutered = New System.Windows.Forms.Label()
        Me.rbYes = New System.Windows.Forms.RadioButton()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.malerb = New System.Windows.Forms.RadioButton()
        Me.Femalerb = New System.Windows.Forms.RadioButton()
        Me.nudWeight = New System.Windows.Forms.NumericUpDown()
        Me.cbAge = New System.Windows.Forms.ComboBox()
        Me.rtbSpecialMarkings = New System.Windows.Forms.RichTextBox()
        Me.colortxb = New System.Windows.Forms.TextBox()
        Me.dogbreedtxb = New System.Windows.Forms.TextBox()
        Me.dognametxb = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.ownernamelb = New System.Windows.Forms.Label()
        Me.ownerphonelb = New System.Windows.Forms.Label()
        Me.owneremaillb = New System.Windows.Forms.Label()
        Me.owneraddresslb = New System.Windows.Forms.Label()
        Me.vetnamelb = New System.Windows.Forms.Label()
        Me.vetphonelb = New System.Windows.Forms.Label()
        Me.gbOwnerInfo = New System.Windows.Forms.GroupBox()
        Me.pbAddress = New System.Windows.Forms.PictureBox()
        Me.pbOwnEmail = New System.Windows.Forms.PictureBox()
        Me.pbOwnNum = New System.Windows.Forms.PictureBox()
        Me.pbOwnName = New System.Windows.Forms.PictureBox()
        Me.owneraddresstxb = New System.Windows.Forms.TextBox()
        Me.owneremailtxb = New System.Windows.Forms.TextBox()
        Me.mtbOwnerNum = New System.Windows.Forms.MaskedTextBox()
        Me.ownernametxb = New System.Windows.Forms.TextBox()
        Me.gbVetInfo = New System.Windows.Forms.GroupBox()
        Me.pbVetPhone = New System.Windows.Forms.PictureBox()
        Me.pbVetName = New System.Windows.Forms.PictureBox()
        Me.vetnametxb = New System.Windows.Forms.TextBox()
        Me.mtbVetNum = New System.Windows.Forms.MaskedTextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.GeneralInformationHeader = New System.Windows.Forms.PictureBox()
        Me.gbDogInfo.SuspendLayout()
        CType(Me.pbSex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSpayNeu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSpecMark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBreed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSpayedNeutered.SuspendLayout()
        CType(Me.nudWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOwnerInfo.SuspendLayout()
        CType(Me.pbAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOwnEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOwnNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOwnName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbVetInfo.SuspendLayout()
        CType(Me.pbVetPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVetName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralInformationHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dognamelbl
        '
        Me.dognamelbl.AutoSize = True
        Me.dognamelbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dognamelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dognamelbl.Location = New System.Drawing.Point(45, 47)
        Me.dognamelbl.Name = "dognamelbl"
        Me.dognamelbl.Size = New System.Drawing.Size(120, 22)
        Me.dognamelbl.TabIndex = 0
        Me.dognamelbl.Text = "*Dog Name"
        '
        'breedlb
        '
        Me.breedlb.AutoSize = True
        Me.breedlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breedlb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.breedlb.Location = New System.Drawing.Point(45, 108)
        Me.breedlb.Name = "breedlb"
        Me.breedlb.Size = New System.Drawing.Size(77, 22)
        Me.breedlb.TabIndex = 0
        Me.breedlb.Text = "*Breed"
        '
        'colorlb
        '
        Me.colorlb.AutoSize = True
        Me.colorlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colorlb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.colorlb.Location = New System.Drawing.Point(45, 174)
        Me.colorlb.Name = "colorlb"
        Me.colorlb.Size = New System.Drawing.Size(71, 22)
        Me.colorlb.TabIndex = 0
        Me.colorlb.Text = "*Color"
        '
        'specialmarklbl
        '
        Me.specialmarklbl.AutoSize = True
        Me.specialmarklbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialmarklbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.specialmarklbl.Location = New System.Drawing.Point(45, 237)
        Me.specialmarklbl.Name = "specialmarklbl"
        Me.specialmarklbl.Size = New System.Drawing.Size(183, 22)
        Me.specialmarklbl.TabIndex = 0
        Me.specialmarklbl.Text = "*Special Markings"
        '
        'lblDogAge
        '
        Me.lblDogAge.AutoSize = True
        Me.lblDogAge.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDogAge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDogAge.Location = New System.Drawing.Point(45, 370)
        Me.lblDogAge.Name = "lblDogAge"
        Me.lblDogAge.Size = New System.Drawing.Size(134, 22)
        Me.lblDogAge.TabIndex = 0
        Me.lblDogAge.Text = "*Age (Years)"
        '
        'sexlbl
        '
        Me.sexlbl.AutoSize = True
        Me.sexlbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sexlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sexlbl.Location = New System.Drawing.Point(281, 47)
        Me.sexlbl.Name = "sexlbl"
        Me.sexlbl.Size = New System.Drawing.Size(57, 22)
        Me.sexlbl.TabIndex = 0
        Me.sexlbl.Text = "*Sex"
        '
        'gbDogInfo
        '
        Me.gbDogInfo.Controls.Add(Me.pbSex)
        Me.gbDogInfo.Controls.Add(Me.pbSpayNeu)
        Me.gbDogInfo.Controls.Add(Me.pbWeight)
        Me.gbDogInfo.Controls.Add(Me.pbAge)
        Me.gbDogInfo.Controls.Add(Me.pbSpecMark)
        Me.gbDogInfo.Controls.Add(Me.pbColor)
        Me.gbDogInfo.Controls.Add(Me.pbBreed)
        Me.gbDogInfo.Controls.Add(Me.pbDate)
        Me.gbDogInfo.Controls.Add(Me.gbSpayedNeutered)
        Me.gbDogInfo.Controls.Add(Me.malerb)
        Me.gbDogInfo.Controls.Add(Me.Femalerb)
        Me.gbDogInfo.Controls.Add(Me.nudWeight)
        Me.gbDogInfo.Controls.Add(Me.cbAge)
        Me.gbDogInfo.Controls.Add(Me.rtbSpecialMarkings)
        Me.gbDogInfo.Controls.Add(Me.colortxb)
        Me.gbDogInfo.Controls.Add(Me.dogbreedtxb)
        Me.gbDogInfo.Controls.Add(Me.dognametxb)
        Me.gbDogInfo.Controls.Add(Me.sexlbl)
        Me.gbDogInfo.Controls.Add(Me.lblWeight)
        Me.gbDogInfo.Controls.Add(Me.dognamelbl)
        Me.gbDogInfo.Controls.Add(Me.breedlb)
        Me.gbDogInfo.Controls.Add(Me.colorlb)
        Me.gbDogInfo.Controls.Add(Me.specialmarklbl)
        Me.gbDogInfo.Controls.Add(Me.lblDogAge)
        Me.gbDogInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDogInfo.ForeColor = System.Drawing.Color.DarkCyan
        Me.gbDogInfo.Location = New System.Drawing.Point(0, 119)
        Me.gbDogInfo.Name = "gbDogInfo"
        Me.gbDogInfo.Size = New System.Drawing.Size(396, 591)
        Me.gbDogInfo.TabIndex = 0
        Me.gbDogInfo.TabStop = False
        Me.gbDogInfo.Text = "Dog Information"
        '
        'pbSex
        '
        Me.pbSex.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.gender
        Me.pbSex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbSex.Location = New System.Drawing.Point(242, 43)
        Me.pbSex.Name = "pbSex"
        Me.pbSex.Size = New System.Drawing.Size(33, 26)
        Me.pbSex.TabIndex = 375
        Me.pbSex.TabStop = False
        '
        'pbSpayNeu
        '
        Me.pbSpayNeu.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.sterilization
        Me.pbSpayNeu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbSpayNeu.Location = New System.Drawing.Point(6, 504)
        Me.pbSpayNeu.Name = "pbSpayNeu"
        Me.pbSpayNeu.Size = New System.Drawing.Size(33, 26)
        Me.pbSpayNeu.TabIndex = 370
        Me.pbSpayNeu.TabStop = False
        '
        'pbWeight
        '
        Me.pbWeight.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.weight_scale
        Me.pbWeight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbWeight.Location = New System.Drawing.Point(6, 435)
        Me.pbWeight.Name = "pbWeight"
        Me.pbWeight.Size = New System.Drawing.Size(33, 26)
        Me.pbWeight.TabIndex = 374
        Me.pbWeight.TabStop = False
        '
        'pbAge
        '
        Me.pbAge.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.pets
        Me.pbAge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbAge.Location = New System.Drawing.Point(6, 366)
        Me.pbAge.Name = "pbAge"
        Me.pbAge.Size = New System.Drawing.Size(33, 26)
        Me.pbAge.TabIndex = 373
        Me.pbAge.TabStop = False
        '
        'pbSpecMark
        '
        Me.pbSpecMark.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.dog_nose
        Me.pbSpecMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbSpecMark.Location = New System.Drawing.Point(6, 233)
        Me.pbSpecMark.Name = "pbSpecMark"
        Me.pbSpecMark.Size = New System.Drawing.Size(33, 26)
        Me.pbSpecMark.TabIndex = 372
        Me.pbSpecMark.TabStop = False
        '
        'pbColor
        '
        Me.pbColor.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.pet_brush
        Me.pbColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbColor.Location = New System.Drawing.Point(6, 170)
        Me.pbColor.Name = "pbColor"
        Me.pbColor.Size = New System.Drawing.Size(33, 26)
        Me.pbColor.TabIndex = 370
        Me.pbColor.TabStop = False
        '
        'pbBreed
        '
        Me.pbBreed.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.card
        Me.pbBreed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbBreed.Location = New System.Drawing.Point(6, 104)
        Me.pbBreed.Name = "pbBreed"
        Me.pbBreed.Size = New System.Drawing.Size(33, 26)
        Me.pbBreed.TabIndex = 371
        Me.pbBreed.TabStop = False
        '
        'pbDate
        '
        Me.pbDate.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.collar
        Me.pbDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbDate.Location = New System.Drawing.Point(6, 43)
        Me.pbDate.Name = "pbDate"
        Me.pbDate.Size = New System.Drawing.Size(33, 26)
        Me.pbDate.TabIndex = 370
        Me.pbDate.TabStop = False
        '
        'gbSpayedNeutered
        '
        Me.gbSpayedNeutered.Controls.Add(Me.lblSpayedNeutered)
        Me.gbSpayedNeutered.Controls.Add(Me.rbYes)
        Me.gbSpayedNeutered.Controls.Add(Me.rbNo)
        Me.gbSpayedNeutered.Location = New System.Drawing.Point(45, 504)
        Me.gbSpayedNeutered.Name = "gbSpayedNeutered"
        Me.gbSpayedNeutered.Size = New System.Drawing.Size(213, 83)
        Me.gbSpayedNeutered.TabIndex = 10
        Me.gbSpayedNeutered.TabStop = False
        '
        'lblSpayedNeutered
        '
        Me.lblSpayedNeutered.AutoSize = True
        Me.lblSpayedNeutered.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpayedNeutered.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSpayedNeutered.Location = New System.Drawing.Point(-4, 0)
        Me.lblSpayedNeutered.Name = "lblSpayedNeutered"
        Me.lblSpayedNeutered.Size = New System.Drawing.Size(188, 22)
        Me.lblSpayedNeutered.TabIndex = 0
        Me.lblSpayedNeutered.Text = "*Spayed/Neutered"
        '
        'rbYes
        '
        Me.rbYes.AutoSize = True
        Me.rbYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbYes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbYes.Location = New System.Drawing.Point(16, 25)
        Me.rbYes.Name = "rbYes"
        Me.rbYes.Size = New System.Drawing.Size(54, 22)
        Me.rbYes.TabIndex = 6
        Me.rbYes.TabStop = True
        Me.rbYes.Text = "Yes"
        Me.rbYes.UseVisualStyleBackColor = True
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbNo.Location = New System.Drawing.Point(16, 53)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(49, 22)
        Me.rbNo.TabIndex = 7
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'malerb
        '
        Me.malerb.AutoSize = True
        Me.malerb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.malerb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.malerb.Location = New System.Drawing.Point(285, 104)
        Me.malerb.Name = "malerb"
        Me.malerb.Size = New System.Drawing.Size(61, 22)
        Me.malerb.TabIndex = 9
        Me.malerb.TabStop = True
        Me.malerb.Text = "Male"
        Me.malerb.UseVisualStyleBackColor = True
        '
        'Femalerb
        '
        Me.Femalerb.AutoSize = True
        Me.Femalerb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Femalerb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Femalerb.Location = New System.Drawing.Point(285, 75)
        Me.Femalerb.Name = "Femalerb"
        Me.Femalerb.Size = New System.Drawing.Size(78, 22)
        Me.Femalerb.TabIndex = 8
        Me.Femalerb.TabStop = True
        Me.Femalerb.Text = "Female"
        Me.Femalerb.UseVisualStyleBackColor = True
        '
        'nudWeight
        '
        Me.nudWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudWeight.Location = New System.Drawing.Point(12, 464)
        Me.nudWeight.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nudWeight.Name = "nudWeight"
        Me.nudWeight.Size = New System.Drawing.Size(216, 24)
        Me.nudWeight.TabIndex = 5
        '
        'cbAge
        '
        Me.cbAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAge.FormattingEnabled = True
        Me.cbAge.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
        Me.cbAge.Location = New System.Drawing.Point(12, 395)
        Me.cbAge.Name = "cbAge"
        Me.cbAge.Size = New System.Drawing.Size(216, 26)
        Me.cbAge.TabIndex = 4
        '
        'rtbSpecialMarkings
        '
        Me.rtbSpecialMarkings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbSpecialMarkings.Location = New System.Drawing.Point(12, 262)
        Me.rtbSpecialMarkings.Name = "rtbSpecialMarkings"
        Me.rtbSpecialMarkings.Size = New System.Drawing.Size(216, 96)
        Me.rtbSpecialMarkings.TabIndex = 3
        Me.rtbSpecialMarkings.Text = ""
        '
        'colortxb
        '
        Me.colortxb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colortxb.Location = New System.Drawing.Point(12, 199)
        Me.colortxb.MaxLength = 35
        Me.colortxb.Name = "colortxb"
        Me.colortxb.Size = New System.Drawing.Size(216, 24)
        Me.colortxb.TabIndex = 2
        '
        'dogbreedtxb
        '
        Me.dogbreedtxb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dogbreedtxb.Location = New System.Drawing.Point(12, 133)
        Me.dogbreedtxb.MaxLength = 35
        Me.dogbreedtxb.Name = "dogbreedtxb"
        Me.dogbreedtxb.Size = New System.Drawing.Size(216, 24)
        Me.dogbreedtxb.TabIndex = 1
        '
        'dognametxb
        '
        Me.dognametxb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dognametxb.Location = New System.Drawing.Point(12, 72)
        Me.dognametxb.MaxLength = 35
        Me.dognametxb.Name = "dognametxb"
        Me.dognametxb.Size = New System.Drawing.Size(216, 24)
        Me.dognametxb.TabIndex = 0
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblWeight.Location = New System.Drawing.Point(45, 439)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(142, 22)
        Me.lblWeight.TabIndex = 0
        Me.lblWeight.Text = "*Weight (lbs)"
        '
        'ownernamelb
        '
        Me.ownernamelb.AutoSize = True
        Me.ownernamelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ownernamelb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ownernamelb.Location = New System.Drawing.Point(42, 47)
        Me.ownernamelb.Name = "ownernamelb"
        Me.ownernamelb.Size = New System.Drawing.Size(143, 22)
        Me.ownernamelb.TabIndex = 0
        Me.ownernamelb.Text = "*Owner Name"
        '
        'ownerphonelb
        '
        Me.ownerphonelb.AutoSize = True
        Me.ownerphonelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ownerphonelb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ownerphonelb.Location = New System.Drawing.Point(42, 108)
        Me.ownerphonelb.Name = "ownerphonelb"
        Me.ownerphonelb.Size = New System.Drawing.Size(161, 22)
        Me.ownerphonelb.TabIndex = 0
        Me.ownerphonelb.Text = "*Phone Number"
        '
        'owneremaillb
        '
        Me.owneremaillb.AutoSize = True
        Me.owneremaillb.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.owneremaillb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.owneremaillb.Location = New System.Drawing.Point(42, 174)
        Me.owneremaillb.Name = "owneremaillb"
        Me.owneremaillb.Size = New System.Drawing.Size(63, 22)
        Me.owneremaillb.TabIndex = 0
        Me.owneremaillb.Text = "Email"
        '
        'owneraddresslb
        '
        Me.owneraddresslb.AutoSize = True
        Me.owneraddresslb.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.owneraddresslb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.owneraddresslb.Location = New System.Drawing.Point(42, 237)
        Me.owneraddresslb.Name = "owneraddresslb"
        Me.owneraddresslb.Size = New System.Drawing.Size(98, 22)
        Me.owneraddresslb.TabIndex = 0
        Me.owneraddresslb.Text = "*Address"
        '
        'vetnamelb
        '
        Me.vetnamelb.AutoSize = True
        Me.vetnamelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetnamelb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.vetnamelb.Location = New System.Drawing.Point(42, 35)
        Me.vetnamelb.Name = "vetnamelb"
        Me.vetnamelb.Size = New System.Drawing.Size(200, 22)
        Me.vetnamelb.TabIndex = 0
        Me.vetnamelb.Text = "*Veterinarian Name"
        '
        'vetphonelb
        '
        Me.vetphonelb.AutoSize = True
        Me.vetphonelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetphonelb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.vetphonelb.Location = New System.Drawing.Point(42, 103)
        Me.vetphonelb.Name = "vetphonelb"
        Me.vetphonelb.Size = New System.Drawing.Size(149, 22)
        Me.vetphonelb.TabIndex = 0
        Me.vetphonelb.Text = "Phone Number"
        '
        'gbOwnerInfo
        '
        Me.gbOwnerInfo.Controls.Add(Me.pbAddress)
        Me.gbOwnerInfo.Controls.Add(Me.pbOwnEmail)
        Me.gbOwnerInfo.Controls.Add(Me.pbOwnNum)
        Me.gbOwnerInfo.Controls.Add(Me.pbOwnName)
        Me.gbOwnerInfo.Controls.Add(Me.owneraddresstxb)
        Me.gbOwnerInfo.Controls.Add(Me.owneremailtxb)
        Me.gbOwnerInfo.Controls.Add(Me.mtbOwnerNum)
        Me.gbOwnerInfo.Controls.Add(Me.ownernametxb)
        Me.gbOwnerInfo.Controls.Add(Me.ownernamelb)
        Me.gbOwnerInfo.Controls.Add(Me.ownerphonelb)
        Me.gbOwnerInfo.Controls.Add(Me.owneremaillb)
        Me.gbOwnerInfo.Controls.Add(Me.owneraddresslb)
        Me.gbOwnerInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOwnerInfo.ForeColor = System.Drawing.Color.DarkCyan
        Me.gbOwnerInfo.Location = New System.Drawing.Point(402, 119)
        Me.gbOwnerInfo.Name = "gbOwnerInfo"
        Me.gbOwnerInfo.Size = New System.Drawing.Size(416, 353)
        Me.gbOwnerInfo.TabIndex = 6
        Me.gbOwnerInfo.TabStop = False
        Me.gbOwnerInfo.Text = "Owner Information"
        '
        'pbAddress
        '
        Me.pbAddress.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.pin
        Me.pbAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbAddress.Location = New System.Drawing.Point(10, 233)
        Me.pbAddress.Name = "pbAddress"
        Me.pbAddress.Size = New System.Drawing.Size(33, 26)
        Me.pbAddress.TabIndex = 373
        Me.pbAddress.TabStop = False
        '
        'pbOwnEmail
        '
        Me.pbOwnEmail.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.mail
        Me.pbOwnEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbOwnEmail.Location = New System.Drawing.Point(10, 170)
        Me.pbOwnEmail.Name = "pbOwnEmail"
        Me.pbOwnEmail.Size = New System.Drawing.Size(33, 26)
        Me.pbOwnEmail.TabIndex = 372
        Me.pbOwnEmail.TabStop = False
        '
        'pbOwnNum
        '
        Me.pbOwnNum.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.telephone
        Me.pbOwnNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbOwnNum.Location = New System.Drawing.Point(10, 104)
        Me.pbOwnNum.Name = "pbOwnNum"
        Me.pbOwnNum.Size = New System.Drawing.Size(33, 26)
        Me.pbOwnNum.TabIndex = 371
        Me.pbOwnNum.TabStop = False
        '
        'pbOwnName
        '
        Me.pbOwnName.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.id_card
        Me.pbOwnName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbOwnName.Location = New System.Drawing.Point(10, 43)
        Me.pbOwnName.Name = "pbOwnName"
        Me.pbOwnName.Size = New System.Drawing.Size(33, 26)
        Me.pbOwnName.TabIndex = 370
        Me.pbOwnName.TabStop = False
        '
        'owneraddresstxb
        '
        Me.owneraddresstxb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.owneraddresstxb.Location = New System.Drawing.Point(12, 262)
        Me.owneraddresstxb.MaxLength = 35
        Me.owneraddresstxb.Name = "owneraddresstxb"
        Me.owneraddresstxb.Size = New System.Drawing.Size(230, 24)
        Me.owneraddresstxb.TabIndex = 10
        '
        'owneremailtxb
        '
        Me.owneremailtxb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.owneremailtxb.Location = New System.Drawing.Point(12, 199)
        Me.owneremailtxb.MaxLength = 35
        Me.owneremailtxb.Name = "owneremailtxb"
        Me.owneremailtxb.Size = New System.Drawing.Size(230, 24)
        Me.owneremailtxb.TabIndex = 9
        '
        'mtbOwnerNum
        '
        Me.mtbOwnerNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbOwnerNum.Location = New System.Drawing.Point(12, 133)
        Me.mtbOwnerNum.Mask = "(999) 000-0000"
        Me.mtbOwnerNum.Name = "mtbOwnerNum"
        Me.mtbOwnerNum.Size = New System.Drawing.Size(230, 24)
        Me.mtbOwnerNum.TabIndex = 8
        '
        'ownernametxb
        '
        Me.ownernametxb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ownernametxb.Location = New System.Drawing.Point(12, 73)
        Me.ownernametxb.MaxLength = 35
        Me.ownernametxb.Name = "ownernametxb"
        Me.ownernametxb.Size = New System.Drawing.Size(230, 24)
        Me.ownernametxb.TabIndex = 7
        '
        'gbVetInfo
        '
        Me.gbVetInfo.Controls.Add(Me.pbVetPhone)
        Me.gbVetInfo.Controls.Add(Me.pbVetName)
        Me.gbVetInfo.Controls.Add(Me.vetnametxb)
        Me.gbVetInfo.Controls.Add(Me.mtbVetNum)
        Me.gbVetInfo.Controls.Add(Me.vetnamelb)
        Me.gbVetInfo.Controls.Add(Me.vetphonelb)
        Me.gbVetInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVetInfo.ForeColor = System.Drawing.Color.DarkCyan
        Me.gbVetInfo.Location = New System.Drawing.Point(402, 479)
        Me.gbVetInfo.Name = "gbVetInfo"
        Me.gbVetInfo.Size = New System.Drawing.Size(416, 227)
        Me.gbVetInfo.TabIndex = 11
        Me.gbVetInfo.TabStop = False
        Me.gbVetInfo.Text = "Veteranarian Information"
        '
        'pbVetPhone
        '
        Me.pbVetPhone.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.telephone1
        Me.pbVetPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbVetPhone.Location = New System.Drawing.Point(10, 99)
        Me.pbVetPhone.Name = "pbVetPhone"
        Me.pbVetPhone.Size = New System.Drawing.Size(33, 26)
        Me.pbVetPhone.TabIndex = 370
        Me.pbVetPhone.TabStop = False
        '
        'pbVetName
        '
        Me.pbVetName.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.id_card
        Me.pbVetName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbVetName.Location = New System.Drawing.Point(10, 31)
        Me.pbVetName.Name = "pbVetName"
        Me.pbVetName.Size = New System.Drawing.Size(33, 26)
        Me.pbVetName.TabIndex = 374
        Me.pbVetName.TabStop = False
        '
        'vetnametxb
        '
        Me.vetnametxb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetnametxb.Location = New System.Drawing.Point(12, 60)
        Me.vetnametxb.MaxLength = 35
        Me.vetnametxb.Name = "vetnametxb"
        Me.vetnametxb.Size = New System.Drawing.Size(230, 24)
        Me.vetnametxb.TabIndex = 12
        '
        'mtbVetNum
        '
        Me.mtbVetNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbVetNum.Location = New System.Drawing.Point(12, 128)
        Me.mtbVetNum.Mask = "(999) 000-0000"
        Me.mtbVetNum.Name = "mtbVetNum"
        Me.mtbVetNum.Size = New System.Drawing.Size(230, 24)
        Me.mtbVetNum.TabIndex = 13
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(12, 716)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 30)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(348, 716)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 30)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(709, 716)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(100, 30)
        Me.btnContinue.TabIndex = 14
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'GeneralInformationHeader
        '
        Me.GeneralInformationHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralInformationHeader.Image = CType(resources.GetObject("GeneralInformationHeader.Image"), System.Drawing.Image)
        Me.GeneralInformationHeader.Location = New System.Drawing.Point(0, 0)
        Me.GeneralInformationHeader.Name = "GeneralInformationHeader"
        Me.GeneralInformationHeader.Size = New System.Drawing.Size(818, 120)
        Me.GeneralInformationHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GeneralInformationHeader.TabIndex = 0
        Me.GeneralInformationHeader.TabStop = False
        '
        'GeneralInformationForm
        '
        Me.AcceptButton = Me.btnContinue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(821, 758)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbVetInfo)
        Me.Controls.Add(Me.GeneralInformationHeader)
        Me.Controls.Add(Me.gbOwnerInfo)
        Me.Controls.Add(Me.gbDogInfo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GeneralInformationForm"
        Me.Text = "General-Information"
        Me.gbDogInfo.ResumeLayout(False)
        Me.gbDogInfo.PerformLayout()
        CType(Me.pbSex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSpayNeu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSpecMark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBreed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSpayedNeutered.ResumeLayout(False)
        Me.gbSpayedNeutered.PerformLayout()
        CType(Me.nudWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOwnerInfo.ResumeLayout(False)
        Me.gbOwnerInfo.PerformLayout()
        CType(Me.pbAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOwnEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOwnNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOwnName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbVetInfo.ResumeLayout(False)
        Me.gbVetInfo.PerformLayout()
        CType(Me.pbVetPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVetName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralInformationHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GeneralInformationHeader As PictureBox
    Friend WithEvents dognamelbl As Label
    Friend WithEvents breedlb As Label
    Friend WithEvents colorlb As Label
    Friend WithEvents specialmarklbl As Label
    Friend WithEvents lblDogAge As Label
    Friend WithEvents sexlbl As Label
    Friend WithEvents gbDogInfo As GroupBox
    Friend WithEvents lblSpayedNeutered As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents ownernamelb As Label
    Friend WithEvents ownerphonelb As Label
    Friend WithEvents owneremaillb As Label
    Friend WithEvents owneraddresslb As Label
    Friend WithEvents vetnamelb As Label
    Friend WithEvents vetphonelb As Label
    Friend WithEvents gbOwnerInfo As GroupBox
    Friend WithEvents gbVetInfo As GroupBox
    Friend WithEvents rtbSpecialMarkings As RichTextBox
    Friend WithEvents colortxb As TextBox
    Friend WithEvents dogbreedtxb As TextBox
    Friend WithEvents dognametxb As TextBox
    Friend WithEvents cbAge As ComboBox
    Friend WithEvents nudWeight As NumericUpDown
    Friend WithEvents malerb As RadioButton
    Friend WithEvents Femalerb As RadioButton
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbYes As RadioButton
    Friend WithEvents ownernametxb As TextBox
    Friend WithEvents mtbOwnerNum As MaskedTextBox
    Friend WithEvents owneremailtxb As TextBox
    Friend WithEvents mtbVetNum As MaskedTextBox
    Friend WithEvents owneraddresstxb As TextBox
    Friend WithEvents vetnametxb As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnContinue As Button
    Friend WithEvents gbSpayedNeutered As GroupBox
    Friend WithEvents pbDate As PictureBox
    Friend WithEvents pbBreed As PictureBox
    Friend WithEvents pbColor As PictureBox
    Friend WithEvents pbSpecMark As PictureBox
    Friend WithEvents pbAge As PictureBox
    Friend WithEvents pbWeight As PictureBox
    Friend WithEvents pbSpayNeu As PictureBox
    Friend WithEvents pbOwnName As PictureBox
    Friend WithEvents pbSex As PictureBox
    Friend WithEvents pbOwnNum As PictureBox
    Friend WithEvents pbOwnEmail As PictureBox
    Friend WithEvents pbAddress As PictureBox
    Friend WithEvents pbVetPhone As PictureBox
    Friend WithEvents pbVetName As PictureBox
End Class
