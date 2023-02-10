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
        Me.owneraddresstxb = New System.Windows.Forms.TextBox()
        Me.owneremailtxb = New System.Windows.Forms.TextBox()
        Me.mtbOwnerNum = New System.Windows.Forms.MaskedTextBox()
        Me.ownernametxb = New System.Windows.Forms.TextBox()
        Me.gbVetInfo = New System.Windows.Forms.GroupBox()
        Me.vetnametxb = New System.Windows.Forms.TextBox()
        Me.mtbVetNum = New System.Windows.Forms.MaskedTextBox()
        Me.GeneralInformationHeader = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.gbDogInfo.SuspendLayout()
        Me.gbSpayedNeutered.SuspendLayout()
        CType(Me.nudWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOwnerInfo.SuspendLayout()
        Me.gbVetInfo.SuspendLayout()
        CType(Me.GeneralInformationHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dognamelbl
        '
        Me.dognamelbl.AutoSize = True
        Me.dognamelbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dognamelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dognamelbl.Location = New System.Drawing.Point(12, 47)
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
        Me.breedlb.Location = New System.Drawing.Point(8, 108)
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
        Me.colorlb.Location = New System.Drawing.Point(8, 174)
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
        Me.specialmarklbl.Location = New System.Drawing.Point(8, 237)
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
        Me.lblDogAge.Location = New System.Drawing.Point(12, 370)
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
        Me.sexlbl.Location = New System.Drawing.Point(231, 47)
        Me.sexlbl.Name = "sexlbl"
        Me.sexlbl.Size = New System.Drawing.Size(57, 22)
        Me.sexlbl.TabIndex = 0
        Me.sexlbl.Text = "*Sex"
        '
        'gbDogInfo
        '
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
        Me.gbDogInfo.Size = New System.Drawing.Size(396, 577)
        Me.gbDogInfo.TabIndex = 0
        Me.gbDogInfo.TabStop = False
        Me.gbDogInfo.Text = "Dog Information"
        '
        'gbSpayedNeutered
        '
        Me.gbSpayedNeutered.Controls.Add(Me.lblSpayedNeutered)
        Me.gbSpayedNeutered.Controls.Add(Me.rbYes)
        Me.gbSpayedNeutered.Controls.Add(Me.rbNo)
        Me.gbSpayedNeutered.Location = New System.Drawing.Point(0, 504)
        Me.gbSpayedNeutered.Name = "gbSpayedNeutered"
        Me.gbSpayedNeutered.Size = New System.Drawing.Size(200, 73)
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
        Me.malerb.Location = New System.Drawing.Point(234, 102)
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
        Me.Femalerb.Location = New System.Drawing.Point(234, 74)
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
        Me.nudWeight.Location = New System.Drawing.Point(16, 463)
        Me.nudWeight.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nudWeight.Name = "nudWeight"
        Me.nudWeight.Size = New System.Drawing.Size(120, 24)
        Me.nudWeight.TabIndex = 5
        '
        'cbAge
        '
        Me.cbAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAge.FormattingEnabled = True
        Me.cbAge.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
        Me.cbAge.Location = New System.Drawing.Point(12, 395)
        Me.cbAge.Name = "cbAge"
        Me.cbAge.Size = New System.Drawing.Size(121, 26)
        Me.cbAge.TabIndex = 4
        '
        'rtbSpecialMarkings
        '
        Me.rtbSpecialMarkings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbSpecialMarkings.Location = New System.Drawing.Point(12, 262)
        Me.rtbSpecialMarkings.Name = "rtbSpecialMarkings"
        Me.rtbSpecialMarkings.Size = New System.Drawing.Size(184, 96)
        Me.rtbSpecialMarkings.TabIndex = 3
        Me.rtbSpecialMarkings.Text = ""
        '
        'colortxb
        '
        Me.colortxb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colortxb.Location = New System.Drawing.Point(12, 199)
        Me.colortxb.Name = "colortxb"
        Me.colortxb.Size = New System.Drawing.Size(100, 24)
        Me.colortxb.TabIndex = 2
        '
        'dogbreedtxb
        '
        Me.dogbreedtxb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dogbreedtxb.Location = New System.Drawing.Point(12, 133)
        Me.dogbreedtxb.Name = "dogbreedtxb"
        Me.dogbreedtxb.Size = New System.Drawing.Size(100, 24)
        Me.dogbreedtxb.TabIndex = 1
        '
        'dognametxb
        '
        Me.dognametxb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dognametxb.Location = New System.Drawing.Point(12, 72)
        Me.dognametxb.Name = "dognametxb"
        Me.dognametxb.Size = New System.Drawing.Size(100, 24)
        Me.dognametxb.TabIndex = 0
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblWeight.Location = New System.Drawing.Point(12, 438)
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
        Me.ownernamelb.Location = New System.Drawing.Point(8, 47)
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
        Me.ownerphonelb.Location = New System.Drawing.Point(8, 108)
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
        Me.owneremaillb.Location = New System.Drawing.Point(11, 174)
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
        Me.owneraddresslb.Location = New System.Drawing.Point(6, 237)
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
        Me.vetnamelb.Location = New System.Drawing.Point(2, 35)
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
        Me.vetphonelb.Location = New System.Drawing.Point(8, 103)
        Me.vetphonelb.Name = "vetphonelb"
        Me.vetphonelb.Size = New System.Drawing.Size(149, 22)
        Me.vetphonelb.TabIndex = 0
        Me.vetphonelb.Text = "Phone Number"
        '
        'gbOwnerInfo
        '
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
        'owneraddresstxb
        '
        Me.owneraddresstxb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.owneraddresstxb.Location = New System.Drawing.Point(12, 262)
        Me.owneraddresstxb.Name = "owneraddresstxb"
        Me.owneraddresstxb.Size = New System.Drawing.Size(100, 24)
        Me.owneraddresstxb.TabIndex = 10
        '
        'owneremailtxb
        '
        Me.owneremailtxb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.owneremailtxb.Location = New System.Drawing.Point(12, 199)
        Me.owneremailtxb.Name = "owneremailtxb"
        Me.owneremailtxb.Size = New System.Drawing.Size(100, 24)
        Me.owneremailtxb.TabIndex = 9
        '
        'mtbOwnerNum
        '
        Me.mtbOwnerNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbOwnerNum.Location = New System.Drawing.Point(12, 133)
        Me.mtbOwnerNum.Mask = "(999) 000-0000"
        Me.mtbOwnerNum.Name = "mtbOwnerNum"
        Me.mtbOwnerNum.Size = New System.Drawing.Size(100, 24)
        Me.mtbOwnerNum.TabIndex = 8
        '
        'ownernametxb
        '
        Me.ownernametxb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ownernametxb.Location = New System.Drawing.Point(12, 73)
        Me.ownernametxb.Name = "ownernametxb"
        Me.ownernametxb.Size = New System.Drawing.Size(100, 24)
        Me.ownernametxb.TabIndex = 7
        '
        'gbVetInfo
        '
        Me.gbVetInfo.Controls.Add(Me.vetnametxb)
        Me.gbVetInfo.Controls.Add(Me.mtbVetNum)
        Me.gbVetInfo.Controls.Add(Me.vetnamelb)
        Me.gbVetInfo.Controls.Add(Me.vetphonelb)
        Me.gbVetInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVetInfo.ForeColor = System.Drawing.Color.DarkCyan
        Me.gbVetInfo.Location = New System.Drawing.Point(402, 479)
        Me.gbVetInfo.Name = "gbVetInfo"
        Me.gbVetInfo.Size = New System.Drawing.Size(416, 217)
        Me.gbVetInfo.TabIndex = 11
        Me.gbVetInfo.TabStop = False
        Me.gbVetInfo.Text = "Veteranarian Information"
        '
        'vetnametxb
        '
        Me.vetnametxb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetnametxb.Location = New System.Drawing.Point(12, 60)
        Me.vetnametxb.Name = "vetnametxb"
        Me.vetnametxb.Size = New System.Drawing.Size(100, 24)
        Me.vetnametxb.TabIndex = 12
        '
        'mtbVetNum
        '
        Me.mtbVetNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbVetNum.Location = New System.Drawing.Point(12, 128)
        Me.mtbVetNum.Mask = "(999) 000-0000"
        Me.mtbVetNum.Name = "mtbVetNum"
        Me.mtbVetNum.Size = New System.Drawing.Size(100, 24)
        Me.mtbVetNum.TabIndex = 13
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
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(12, 702)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 30)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(348, 702)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 30)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(709, 702)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(100, 30)
        Me.btnContinue.TabIndex = 14
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'GeneralInformationForm
        '
        Me.AcceptButton = Me.btnContinue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(821, 744)
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
        Me.gbSpayedNeutered.ResumeLayout(False)
        Me.gbSpayedNeutered.PerformLayout()
        CType(Me.nudWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOwnerInfo.ResumeLayout(False)
        Me.gbOwnerInfo.PerformLayout()
        Me.gbVetInfo.ResumeLayout(False)
        Me.gbVetInfo.PerformLayout()
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
End Class
