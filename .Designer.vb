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
        Me.GeneralInformationHeader = New System.Windows.Forms.PictureBox()
        Me.dognamelbl = New System.Windows.Forms.Label()
        Me.dognametxb = New System.Windows.Forms.TextBox()
        Me.breedlb = New System.Windows.Forms.Label()
        Me.dogbreedtxb = New System.Windows.Forms.TextBox()
        Me.colorlb = New System.Windows.Forms.Label()
        Me.colortxb = New System.Windows.Forms.TextBox()
        Me.specialmarklbl = New System.Windows.Forms.Label()
        Me.specialmarktxb = New System.Windows.Forms.TextBox()
        Me.lblDogAge = New System.Windows.Forms.Label()
        Me.genderlb = New System.Windows.Forms.Label()
        Me.malerb = New System.Windows.Forms.RadioButton()
        Me.Femalerb = New System.Windows.Forms.RadioButton()
        Me.gbDogInfo = New System.Windows.Forms.GroupBox()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.cbDogAge = New System.Windows.Forms.ComboBox()
        Me.rbYes = New System.Windows.Forms.RadioButton()
        Me.nudWeight = New System.Windows.Forms.NumericUpDown()
        Me.lblSpayedNeutered = New System.Windows.Forms.Label()
        Me.ownernamelb = New System.Windows.Forms.Label()
        Me.ownernametxb = New System.Windows.Forms.TextBox()
        Me.ownerphonelb = New System.Windows.Forms.Label()
        Me.ownerphonetxb = New System.Windows.Forms.TextBox()
        Me.owneremaillb = New System.Windows.Forms.Label()
        Me.owneremailtxb = New System.Windows.Forms.TextBox()
        Me.owneraddresslb = New System.Windows.Forms.Label()
        Me.owneraddresstxb = New System.Windows.Forms.TextBox()
        Me.vetnamelb = New System.Windows.Forms.Label()
        Me.vetnamtxb = New System.Windows.Forms.TextBox()
        Me.vetphonelb = New System.Windows.Forms.Label()
        Me.vetphonetxb = New System.Windows.Forms.TextBox()
        Me.gbOwnerInfo = New System.Windows.Forms.GroupBox()
        Me.gbVetInfo = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        CType(Me.GeneralInformationHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDogInfo.SuspendLayout()
        CType(Me.nudWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOwnerInfo.SuspendLayout()
        Me.gbVetInfo.SuspendLayout()
        Me.SuspendLayout()
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
        'dognamelbl
        '
        Me.dognamelbl.AutoSize = True
        Me.dognamelbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dognamelbl.Location = New System.Drawing.Point(6, 47)
        Me.dognamelbl.Name = "dognamelbl"
        Me.dognamelbl.Size = New System.Drawing.Size(88, 19)
        Me.dognamelbl.TabIndex = 0
        Me.dognamelbl.Text = "Dog Name"
        '
        'dognametxb
        '
        Me.dognametxb.Location = New System.Drawing.Point(10, 69)
        Me.dognametxb.Name = "dognametxb"
        Me.dognametxb.Size = New System.Drawing.Size(129, 34)
        Me.dognametxb.TabIndex = 1
        '
        'breedlb
        '
        Me.breedlb.AutoSize = True
        Me.breedlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breedlb.Location = New System.Drawing.Point(6, 121)
        Me.breedlb.Name = "breedlb"
        Me.breedlb.Size = New System.Drawing.Size(52, 19)
        Me.breedlb.TabIndex = 0
        Me.breedlb.Text = "Breed"
        '
        'dogbreedtxb
        '
        Me.dogbreedtxb.Location = New System.Drawing.Point(10, 143)
        Me.dogbreedtxb.Name = "dogbreedtxb"
        Me.dogbreedtxb.Size = New System.Drawing.Size(129, 34)
        Me.dogbreedtxb.TabIndex = 2
        '
        'colorlb
        '
        Me.colorlb.AutoSize = True
        Me.colorlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colorlb.Location = New System.Drawing.Point(6, 196)
        Me.colorlb.Name = "colorlb"
        Me.colorlb.Size = New System.Drawing.Size(49, 19)
        Me.colorlb.TabIndex = 0
        Me.colorlb.Text = "Color"
        '
        'colortxb
        '
        Me.colortxb.Location = New System.Drawing.Point(10, 218)
        Me.colortxb.Name = "colortxb"
        Me.colortxb.Size = New System.Drawing.Size(129, 34)
        Me.colortxb.TabIndex = 3
        '
        'specialmarklbl
        '
        Me.specialmarklbl.AutoSize = True
        Me.specialmarklbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialmarklbl.Location = New System.Drawing.Point(7, 273)
        Me.specialmarklbl.Name = "specialmarklbl"
        Me.specialmarklbl.Size = New System.Drawing.Size(131, 19)
        Me.specialmarklbl.TabIndex = 0
        Me.specialmarklbl.Text = "Special Markings"
        '
        'specialmarktxb
        '
        Me.specialmarktxb.Location = New System.Drawing.Point(10, 295)
        Me.specialmarktxb.Name = "specialmarktxb"
        Me.specialmarktxb.Size = New System.Drawing.Size(128, 34)
        Me.specialmarktxb.TabIndex = 4
        '
        'lblDogAge
        '
        Me.lblDogAge.AutoSize = True
        Me.lblDogAge.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDogAge.Location = New System.Drawing.Point(6, 347)
        Me.lblDogAge.Name = "lblDogAge"
        Me.lblDogAge.Size = New System.Drawing.Size(37, 19)
        Me.lblDogAge.TabIndex = 0
        Me.lblDogAge.Text = "Age"
        '
        'genderlb
        '
        Me.genderlb.AutoSize = True
        Me.genderlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderlb.Location = New System.Drawing.Point(227, 47)
        Me.genderlb.Name = "genderlb"
        Me.genderlb.Size = New System.Drawing.Size(63, 19)
        Me.genderlb.TabIndex = 0
        Me.genderlb.Text = "Gender"
        '
        'malerb
        '
        Me.malerb.AutoSize = True
        Me.malerb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.malerb.Location = New System.Drawing.Point(231, 101)
        Me.malerb.Name = "malerb"
        Me.malerb.Size = New System.Drawing.Size(64, 23)
        Me.malerb.TabIndex = 8
        Me.malerb.TabStop = True
        Me.malerb.Text = "Male"
        Me.malerb.UseVisualStyleBackColor = True
        '
        'Femalerb
        '
        Me.Femalerb.AutoSize = True
        Me.Femalerb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Femalerb.Location = New System.Drawing.Point(231, 72)
        Me.Femalerb.Name = "Femalerb"
        Me.Femalerb.Size = New System.Drawing.Size(84, 23)
        Me.Femalerb.TabIndex = 7
        Me.Femalerb.TabStop = True
        Me.Femalerb.Text = "Female"
        Me.Femalerb.UseVisualStyleBackColor = True
        '
        'gbDogInfo
        '
        Me.gbDogInfo.Controls.Add(Me.rbNo)
        Me.gbDogInfo.Controls.Add(Me.lblWeight)
        Me.gbDogInfo.Controls.Add(Me.cbDogAge)
        Me.gbDogInfo.Controls.Add(Me.rbYes)
        Me.gbDogInfo.Controls.Add(Me.nudWeight)
        Me.gbDogInfo.Controls.Add(Me.dognametxb)
        Me.gbDogInfo.Controls.Add(Me.dognamelbl)
        Me.gbDogInfo.Controls.Add(Me.genderlb)
        Me.gbDogInfo.Controls.Add(Me.malerb)
        Me.gbDogInfo.Controls.Add(Me.Femalerb)
        Me.gbDogInfo.Controls.Add(Me.lblSpayedNeutered)
        Me.gbDogInfo.Controls.Add(Me.breedlb)
        Me.gbDogInfo.Controls.Add(Me.dogbreedtxb)
        Me.gbDogInfo.Controls.Add(Me.colorlb)
        Me.gbDogInfo.Controls.Add(Me.colortxb)
        Me.gbDogInfo.Controls.Add(Me.specialmarklbl)
        Me.gbDogInfo.Controls.Add(Me.specialmarktxb)
        Me.gbDogInfo.Controls.Add(Me.lblDogAge)
        Me.gbDogInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDogInfo.Location = New System.Drawing.Point(0, 119)
        Me.gbDogInfo.Name = "gbDogInfo"
        Me.gbDogInfo.Size = New System.Drawing.Size(396, 577)
        Me.gbDogInfo.TabIndex = 0
        Me.gbDogInfo.TabStop = False
        Me.gbDogInfo.Text = "Dog Information"
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNo.Location = New System.Drawing.Point(231, 256)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(51, 23)
        Me.rbNo.TabIndex = 10
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(6, 431)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(99, 19)
        Me.lblWeight.TabIndex = 0
        Me.lblWeight.Text = "Weight (lbs)"
        '
        'cbDogAge
        '
        Me.cbDogAge.FormattingEnabled = True
        Me.cbDogAge.Location = New System.Drawing.Point(10, 369)
        Me.cbDogAge.Name = "cbDogAge"
        Me.cbDogAge.Size = New System.Drawing.Size(121, 37)
        Me.cbDogAge.TabIndex = 5
        '
        'rbYes
        '
        Me.rbYes.AutoSize = True
        Me.rbYes.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbYes.Location = New System.Drawing.Point(231, 227)
        Me.rbYes.Name = "rbYes"
        Me.rbYes.Size = New System.Drawing.Size(56, 23)
        Me.rbYes.TabIndex = 9
        Me.rbYes.TabStop = True
        Me.rbYes.Text = "Yes"
        Me.rbYes.UseVisualStyleBackColor = True
        '
        'nudWeight
        '
        Me.nudWeight.Location = New System.Drawing.Point(10, 453)
        Me.nudWeight.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudWeight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudWeight.Name = "nudWeight"
        Me.nudWeight.Size = New System.Drawing.Size(114, 34)
        Me.nudWeight.TabIndex = 6
        Me.nudWeight.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblSpayedNeutered
        '
        Me.lblSpayedNeutered.AutoSize = True
        Me.lblSpayedNeutered.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpayedNeutered.Location = New System.Drawing.Point(227, 196)
        Me.lblSpayedNeutered.Name = "lblSpayedNeutered"
        Me.lblSpayedNeutered.Size = New System.Drawing.Size(139, 19)
        Me.lblSpayedNeutered.TabIndex = 0
        Me.lblSpayedNeutered.Text = "Spayed/Neutered"
        '
        'ownernamelb
        '
        Me.ownernamelb.AutoSize = True
        Me.ownernamelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ownernamelb.Location = New System.Drawing.Point(11, 47)
        Me.ownernamelb.Name = "ownernamelb"
        Me.ownernamelb.Size = New System.Drawing.Size(107, 19)
        Me.ownernamelb.TabIndex = 0
        Me.ownernamelb.Text = "Owner Name"
        '
        'ownernametxb
        '
        Me.ownernametxb.Location = New System.Drawing.Point(15, 69)
        Me.ownernametxb.Name = "ownernametxb"
        Me.ownernametxb.Size = New System.Drawing.Size(132, 34)
        Me.ownernametxb.TabIndex = 11
        '
        'ownerphonelb
        '
        Me.ownerphonelb.AutoSize = True
        Me.ownerphonelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ownerphonelb.Location = New System.Drawing.Point(11, 121)
        Me.ownerphonelb.Name = "ownerphonelb"
        Me.ownerphonelb.Size = New System.Drawing.Size(119, 19)
        Me.ownerphonelb.TabIndex = 0
        Me.ownerphonelb.Text = "Phone Number"
        '
        'ownerphonetxb
        '
        Me.ownerphonetxb.Location = New System.Drawing.Point(12, 143)
        Me.ownerphonetxb.Name = "ownerphonetxb"
        Me.ownerphonetxb.Size = New System.Drawing.Size(132, 34)
        Me.ownerphonetxb.TabIndex = 12
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
        'owneraddresstxb
        '
        Me.owneraddresstxb.Location = New System.Drawing.Point(12, 295)
        Me.owneraddresstxb.Name = "owneraddresstxb"
        Me.owneraddresstxb.Size = New System.Drawing.Size(132, 34)
        Me.owneraddresstxb.TabIndex = 14
        '
        'vetnamelb
        '
        Me.vetnamelb.AutoSize = True
        Me.vetnamelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetnamelb.Location = New System.Drawing.Point(6, 49)
        Me.vetnamelb.Name = "vetnamelb"
        Me.vetnamelb.Size = New System.Drawing.Size(146, 19)
        Me.vetnamelb.TabIndex = 0
        Me.vetnamelb.Text = "Veterinarian Name"
        '
        'vetnamtxb
        '
        Me.vetnamtxb.Location = New System.Drawing.Point(10, 71)
        Me.vetnamtxb.Name = "vetnamtxb"
        Me.vetnamtxb.Size = New System.Drawing.Size(132, 34)
        Me.vetnamtxb.TabIndex = 15
        '
        'vetphonelb
        '
        Me.vetphonelb.AutoSize = True
        Me.vetphonelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetphonelb.Location = New System.Drawing.Point(6, 125)
        Me.vetphonelb.Name = "vetphonelb"
        Me.vetphonelb.Size = New System.Drawing.Size(119, 19)
        Me.vetphonelb.TabIndex = 0
        Me.vetphonelb.Text = "Phone Number"
        '
        'vetphonetxb
        '
        Me.vetphonetxb.Location = New System.Drawing.Point(10, 147)
        Me.vetphonetxb.Name = "vetphonetxb"
        Me.vetphonetxb.Size = New System.Drawing.Size(132, 34)
        Me.vetphonetxb.TabIndex = 16
        '
        'gbOwnerInfo
        '
        Me.gbOwnerInfo.Controls.Add(Me.ownernamelb)
        Me.gbOwnerInfo.Controls.Add(Me.ownernametxb)
        Me.gbOwnerInfo.Controls.Add(Me.ownerphonelb)
        Me.gbOwnerInfo.Controls.Add(Me.ownerphonetxb)
        Me.gbOwnerInfo.Controls.Add(Me.owneremaillb)
        Me.gbOwnerInfo.Controls.Add(Me.owneraddresstxb)
        Me.gbOwnerInfo.Controls.Add(Me.owneremailtxb)
        Me.gbOwnerInfo.Controls.Add(Me.owneraddresslb)
        Me.gbOwnerInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOwnerInfo.Location = New System.Drawing.Point(402, 119)
        Me.gbOwnerInfo.Name = "gbOwnerInfo"
        Me.gbOwnerInfo.Size = New System.Drawing.Size(416, 353)
        Me.gbOwnerInfo.TabIndex = 0
        Me.gbOwnerInfo.TabStop = False
        Me.gbOwnerInfo.Text = "Owner Information"
        '
        'gbVetInfo
        '
        Me.gbVetInfo.Controls.Add(Me.vetphonetxb)
        Me.gbVetInfo.Controls.Add(Me.vetnamelb)
        Me.gbVetInfo.Controls.Add(Me.vetphonelb)
        Me.gbVetInfo.Controls.Add(Me.vetnamtxb)
        Me.gbVetInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVetInfo.Location = New System.Drawing.Point(402, 479)
        Me.gbVetInfo.Name = "gbVetInfo"
        Me.gbVetInfo.Size = New System.Drawing.Size(416, 217)
        Me.gbVetInfo.TabIndex = 0
        Me.gbVetInfo.TabStop = False
        Me.gbVetInfo.Text = "Veteranarian Information"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 702)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(376, 702)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(725, 702)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(84, 23)
        Me.btnContinue.TabIndex = 19
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'GeneralInformationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        CType(Me.GeneralInformationHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDogInfo.ResumeLayout(False)
        Me.gbDogInfo.PerformLayout()
        CType(Me.nudWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOwnerInfo.ResumeLayout(False)
        Me.gbOwnerInfo.PerformLayout()
        Me.gbVetInfo.ResumeLayout(False)
        Me.gbVetInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GeneralInformationHeader As PictureBox
    Friend WithEvents dognamelbl As Label
    Friend WithEvents dognametxb As TextBox
    Friend WithEvents breedlb As Label
    Friend WithEvents dogbreedtxb As TextBox
    Friend WithEvents colorlb As Label
    Friend WithEvents colortxb As TextBox
    Friend WithEvents specialmarklbl As Label
    Friend WithEvents specialmarktxb As TextBox
    Friend WithEvents lblDogAge As Label
    Friend WithEvents genderlb As Label
    Friend WithEvents malerb As RadioButton
    Friend WithEvents Femalerb As RadioButton
    Friend WithEvents gbDogInfo As GroupBox
    Friend WithEvents lblSpayedNeutered As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents cbDogAge As ComboBox
    Friend WithEvents nudWeight As NumericUpDown
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbYes As RadioButton
    Friend WithEvents ownernamelb As Label
    Friend WithEvents ownernametxb As TextBox
    Friend WithEvents ownerphonelb As Label
    Friend WithEvents ownerphonetxb As TextBox
    Friend WithEvents owneremaillb As Label
    Friend WithEvents owneremailtxb As TextBox
    Friend WithEvents owneraddresslb As Label
    Friend WithEvents owneraddresstxb As TextBox
    Friend WithEvents vetnamelb As Label
    Friend WithEvents vetnamtxb As TextBox
    Friend WithEvents vetphonelb As Label
    Friend WithEvents vetphonetxb As TextBox
    Friend WithEvents gbOwnerInfo As GroupBox
    Friend WithEvents gbVetInfo As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnContinue As Button
End Class
