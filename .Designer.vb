<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneralInformationForm
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
        Me.ownerpanel = New System.Windows.Forms.Panel()
        Me.vetphonetxb = New System.Windows.Forms.TextBox()
        Me.vetphonelb = New System.Windows.Forms.Label()
        Me.vetnamtxb = New System.Windows.Forms.TextBox()
        Me.vetnamelb = New System.Windows.Forms.Label()
        Me.vetinfolb = New System.Windows.Forms.Label()
        Me.owneraddresstxb = New System.Windows.Forms.TextBox()
        Me.owneraddresslb = New System.Windows.Forms.Label()
        Me.owneremailtxb = New System.Windows.Forms.TextBox()
        Me.owneremaillb = New System.Windows.Forms.Label()
        Me.ownerphonetxb = New System.Windows.Forms.TextBox()
        Me.ownerphonelb = New System.Windows.Forms.Label()
        Me.ownernametxb = New System.Windows.Forms.TextBox()
        Me.ownernamelb = New System.Windows.Forms.Label()
        Me.ownerinfolb = New System.Windows.Forms.Label()
        Me.continuebt = New System.Windows.Forms.Button()
        Me.Resetbt = New System.Windows.Forms.Button()
        Me.Exitbt = New System.Windows.Forms.Button()
        Me.gbDogInfo = New System.Windows.Forms.GroupBox()
        Me.lblSpayedNeutered = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.rbYes = New System.Windows.Forms.RadioButton()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        CType(Me.GeneralInformationHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ownerpanel.SuspendLayout()
        Me.gbDogInfo.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dognamelbl.Location = New System.Drawing.Point(6, 30)
        Me.dognamelbl.Name = "dognamelbl"
        Me.dognamelbl.Size = New System.Drawing.Size(88, 19)
        Me.dognamelbl.TabIndex = 2
        Me.dognamelbl.Text = "Dog Name"
        '
        'dognametxb
        '
        Me.dognametxb.Location = New System.Drawing.Point(7, 52)
        Me.dognametxb.Name = "dognametxb"
        Me.dognametxb.Size = New System.Drawing.Size(129, 34)
        Me.dognametxb.TabIndex = 1
        '
        'breedlb
        '
        Me.breedlb.AutoSize = True
        Me.breedlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breedlb.Location = New System.Drawing.Point(6, 89)
        Me.breedlb.Name = "breedlb"
        Me.breedlb.Size = New System.Drawing.Size(52, 19)
        Me.breedlb.TabIndex = 4
        Me.breedlb.Text = "Breed"
        '
        'dogbreedtxb
        '
        Me.dogbreedtxb.Location = New System.Drawing.Point(6, 111)
        Me.dogbreedtxb.Name = "dogbreedtxb"
        Me.dogbreedtxb.Size = New System.Drawing.Size(129, 34)
        Me.dogbreedtxb.TabIndex = 2
        '
        'colorlb
        '
        Me.colorlb.AutoSize = True
        Me.colorlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colorlb.Location = New System.Drawing.Point(3, 148)
        Me.colorlb.Name = "colorlb"
        Me.colorlb.Size = New System.Drawing.Size(49, 19)
        Me.colorlb.TabIndex = 6
        Me.colorlb.Text = "Color"
        '
        'colortxb
        '
        Me.colortxb.Location = New System.Drawing.Point(6, 170)
        Me.colortxb.Name = "colortxb"
        Me.colortxb.Size = New System.Drawing.Size(129, 34)
        Me.colortxb.TabIndex = 3
        '
        'specialmarklbl
        '
        Me.specialmarklbl.AutoSize = True
        Me.specialmarklbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialmarklbl.Location = New System.Drawing.Point(3, 217)
        Me.specialmarklbl.Name = "specialmarklbl"
        Me.specialmarklbl.Size = New System.Drawing.Size(131, 19)
        Me.specialmarklbl.TabIndex = 8
        Me.specialmarklbl.Text = "Special Markings"
        '
        'specialmarktxb
        '
        Me.specialmarktxb.Location = New System.Drawing.Point(7, 239)
        Me.specialmarktxb.Name = "specialmarktxb"
        Me.specialmarktxb.Size = New System.Drawing.Size(128, 34)
        Me.specialmarktxb.TabIndex = 4
        '
        'lblDogAge
        '
        Me.lblDogAge.AutoSize = True
        Me.lblDogAge.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDogAge.Location = New System.Drawing.Point(6, 284)
        Me.lblDogAge.Name = "lblDogAge"
        Me.lblDogAge.Size = New System.Drawing.Size(37, 19)
        Me.lblDogAge.TabIndex = 10
        Me.lblDogAge.Text = "Age"
        '
        'genderlb
        '
        Me.genderlb.AutoSize = True
        Me.genderlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderlb.Location = New System.Drawing.Point(8, 357)
        Me.genderlb.Name = "genderlb"
        Me.genderlb.Size = New System.Drawing.Size(63, 19)
        Me.genderlb.TabIndex = 12
        Me.genderlb.Text = "Gender"
        '
        'malerb
        '
        Me.malerb.AutoSize = True
        Me.malerb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.malerb.Location = New System.Drawing.Point(7, 379)
        Me.malerb.Name = "malerb"
        Me.malerb.Size = New System.Drawing.Size(64, 23)
        Me.malerb.TabIndex = 6
        Me.malerb.TabStop = True
        Me.malerb.Text = "Male"
        Me.malerb.UseVisualStyleBackColor = True
        '
        'Femalerb
        '
        Me.Femalerb.AutoSize = True
        Me.Femalerb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Femalerb.Location = New System.Drawing.Point(7, 417)
        Me.Femalerb.Name = "Femalerb"
        Me.Femalerb.Size = New System.Drawing.Size(84, 23)
        Me.Femalerb.TabIndex = 7
        Me.Femalerb.TabStop = True
        Me.Femalerb.Text = "Female"
        Me.Femalerb.UseVisualStyleBackColor = True
        '
        'ownerpanel
        '
        Me.ownerpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ownerpanel.Controls.Add(Me.vetphonetxb)
        Me.ownerpanel.Controls.Add(Me.vetphonelb)
        Me.ownerpanel.Controls.Add(Me.vetnamtxb)
        Me.ownerpanel.Controls.Add(Me.vetnamelb)
        Me.ownerpanel.Controls.Add(Me.vetinfolb)
        Me.ownerpanel.Controls.Add(Me.owneraddresstxb)
        Me.ownerpanel.Controls.Add(Me.owneraddresslb)
        Me.ownerpanel.Controls.Add(Me.owneremailtxb)
        Me.ownerpanel.Controls.Add(Me.owneremaillb)
        Me.ownerpanel.Controls.Add(Me.ownerphonetxb)
        Me.ownerpanel.Controls.Add(Me.ownerphonelb)
        Me.ownerpanel.Controls.Add(Me.ownernametxb)
        Me.ownerpanel.Controls.Add(Me.ownernamelb)
        Me.ownerpanel.Controls.Add(Me.ownerinfolb)
        Me.ownerpanel.Location = New System.Drawing.Point(381, 119)
        Me.ownerpanel.Name = "ownerpanel"
        Me.ownerpanel.Size = New System.Drawing.Size(437, 559)
        Me.ownerpanel.TabIndex = 16
        '
        'vetphonetxb
        '
        Me.vetphonetxb.Location = New System.Drawing.Point(17, 520)
        Me.vetphonetxb.Name = "vetphonetxb"
        Me.vetphonetxb.Size = New System.Drawing.Size(132, 22)
        Me.vetphonetxb.TabIndex = 14
        '
        'vetphonelb
        '
        Me.vetphonelb.AutoSize = True
        Me.vetphonelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetphonelb.Location = New System.Drawing.Point(14, 498)
        Me.vetphonelb.Name = "vetphonelb"
        Me.vetphonelb.Size = New System.Drawing.Size(55, 19)
        Me.vetphonelb.TabIndex = 12
        Me.vetphonelb.Text = "Phone"
        '
        'vetnamtxb
        '
        Me.vetnamtxb.Location = New System.Drawing.Point(17, 449)
        Me.vetnamtxb.Name = "vetnamtxb"
        Me.vetnamtxb.Size = New System.Drawing.Size(132, 22)
        Me.vetnamtxb.TabIndex = 13
        '
        'vetnamelb
        '
        Me.vetnamelb.AutoSize = True
        Me.vetnamelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetnamelb.Location = New System.Drawing.Point(14, 427)
        Me.vetnamelb.Name = "vetnamelb"
        Me.vetnamelb.Size = New System.Drawing.Size(146, 19)
        Me.vetnamelb.TabIndex = 10
        Me.vetnamelb.Text = "Veterinarian Name"
        '
        'vetinfolb
        '
        Me.vetinfolb.AutoSize = True
        Me.vetinfolb.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetinfolb.Location = New System.Drawing.Point(12, 365)
        Me.vetinfolb.Name = "vetinfolb"
        Me.vetinfolb.Size = New System.Drawing.Size(328, 29)
        Me.vetinfolb.TabIndex = 9
        Me.vetinfolb.Text = "Veterinarian Information"
        '
        'owneraddresstxb
        '
        Me.owneraddresstxb.Location = New System.Drawing.Point(17, 305)
        Me.owneraddresstxb.Name = "owneraddresstxb"
        Me.owneraddresstxb.Size = New System.Drawing.Size(132, 22)
        Me.owneraddresstxb.TabIndex = 12
        '
        'owneraddresslb
        '
        Me.owneraddresslb.AutoSize = True
        Me.owneraddresslb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.owneraddresslb.Location = New System.Drawing.Point(14, 283)
        Me.owneraddresslb.Name = "owneraddresslb"
        Me.owneraddresslb.Size = New System.Drawing.Size(68, 19)
        Me.owneraddresslb.TabIndex = 7
        Me.owneraddresslb.Text = "Address"
        '
        'owneremailtxb
        '
        Me.owneremailtxb.Location = New System.Drawing.Point(17, 236)
        Me.owneremailtxb.Name = "owneremailtxb"
        Me.owneremailtxb.Size = New System.Drawing.Size(132, 22)
        Me.owneremailtxb.TabIndex = 11
        '
        'owneremaillb
        '
        Me.owneremaillb.AutoSize = True
        Me.owneremaillb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.owneremaillb.Location = New System.Drawing.Point(14, 214)
        Me.owneremaillb.Name = "owneremaillb"
        Me.owneremaillb.Size = New System.Drawing.Size(48, 19)
        Me.owneremaillb.TabIndex = 5
        Me.owneremaillb.Text = "Email"
        '
        'ownerphonetxb
        '
        Me.ownerphonetxb.Location = New System.Drawing.Point(17, 169)
        Me.ownerphonetxb.Name = "ownerphonetxb"
        Me.ownerphonetxb.Size = New System.Drawing.Size(132, 22)
        Me.ownerphonetxb.TabIndex = 10
        '
        'ownerphonelb
        '
        Me.ownerphonelb.AutoSize = True
        Me.ownerphonelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ownerphonelb.Location = New System.Drawing.Point(14, 147)
        Me.ownerphonelb.Name = "ownerphonelb"
        Me.ownerphonelb.Size = New System.Drawing.Size(55, 19)
        Me.ownerphonelb.TabIndex = 3
        Me.ownerphonelb.Text = "Phone"
        '
        'ownernametxb
        '
        Me.ownernametxb.Location = New System.Drawing.Point(17, 95)
        Me.ownernametxb.Name = "ownernametxb"
        Me.ownernametxb.Size = New System.Drawing.Size(132, 22)
        Me.ownernametxb.TabIndex = 9
        '
        'ownernamelb
        '
        Me.ownernamelb.AutoSize = True
        Me.ownernamelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ownernamelb.Location = New System.Drawing.Point(13, 73)
        Me.ownernamelb.Name = "ownernamelb"
        Me.ownernamelb.Size = New System.Drawing.Size(107, 19)
        Me.ownernamelb.TabIndex = 1
        Me.ownernamelb.Text = "Owner Name"
        '
        'ownerinfolb
        '
        Me.ownerinfolb.AutoSize = True
        Me.ownerinfolb.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ownerinfolb.Location = New System.Drawing.Point(12, 20)
        Me.ownerinfolb.Name = "ownerinfolb"
        Me.ownerinfolb.Size = New System.Drawing.Size(256, 29)
        Me.ownerinfolb.TabIndex = 0
        Me.ownerinfolb.Text = "Owner Information"
        '
        'continuebt
        '
        Me.continuebt.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.continuebt.Location = New System.Drawing.Point(12, 702)
        Me.continuebt.Name = "continuebt"
        Me.continuebt.Size = New System.Drawing.Size(84, 23)
        Me.continuebt.TabIndex = 15
        Me.continuebt.Text = "Continue"
        Me.continuebt.UseVisualStyleBackColor = True
        '
        'Resetbt
        '
        Me.Resetbt.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resetbt.Location = New System.Drawing.Point(349, 702)
        Me.Resetbt.Name = "Resetbt"
        Me.Resetbt.Size = New System.Drawing.Size(75, 23)
        Me.Resetbt.TabIndex = 16
        Me.Resetbt.Text = "Reset"
        Me.Resetbt.UseVisualStyleBackColor = True
        '
        'Exitbt
        '
        Me.Exitbt.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exitbt.Location = New System.Drawing.Point(728, 702)
        Me.Exitbt.Name = "Exitbt"
        Me.Exitbt.Size = New System.Drawing.Size(75, 23)
        Me.Exitbt.TabIndex = 17
        Me.Exitbt.Text = "Exit"
        Me.Exitbt.UseVisualStyleBackColor = True
        '
        'gbDogInfo
        '
        Me.gbDogInfo.Controls.Add(Me.rbNo)
        Me.gbDogInfo.Controls.Add(Me.rbYes)
        Me.gbDogInfo.Controls.Add(Me.lblWeight)
        Me.gbDogInfo.Controls.Add(Me.ComboBox1)
        Me.gbDogInfo.Controls.Add(Me.NumericUpDown1)
        Me.gbDogInfo.Controls.Add(Me.lblSpayedNeutered)
        Me.gbDogInfo.Controls.Add(Me.dognametxb)
        Me.gbDogInfo.Controls.Add(Me.dognamelbl)
        Me.gbDogInfo.Controls.Add(Me.breedlb)
        Me.gbDogInfo.Controls.Add(Me.dogbreedtxb)
        Me.gbDogInfo.Controls.Add(Me.colorlb)
        Me.gbDogInfo.Controls.Add(Me.Femalerb)
        Me.gbDogInfo.Controls.Add(Me.colortxb)
        Me.gbDogInfo.Controls.Add(Me.malerb)
        Me.gbDogInfo.Controls.Add(Me.specialmarklbl)
        Me.gbDogInfo.Controls.Add(Me.genderlb)
        Me.gbDogInfo.Controls.Add(Me.specialmarktxb)
        Me.gbDogInfo.Controls.Add(Me.lblDogAge)
        Me.gbDogInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDogInfo.Location = New System.Drawing.Point(0, 119)
        Me.gbDogInfo.Name = "gbDogInfo"
        Me.gbDogInfo.Size = New System.Drawing.Size(388, 559)
        Me.gbDogInfo.TabIndex = 18
        Me.gbDogInfo.TabStop = False
        Me.gbDogInfo.Text = "Dog Information"
        '
        'lblSpayedNeutered
        '
        Me.lblSpayedNeutered.AutoSize = True
        Me.lblSpayedNeutered.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpayedNeutered.Location = New System.Drawing.Point(3, 450)
        Me.lblSpayedNeutered.Name = "lblSpayedNeutered"
        Me.lblSpayedNeutered.Size = New System.Drawing.Size(139, 19)
        Me.lblSpayedNeutered.TabIndex = 13
        Me.lblSpayedNeutered.Text = "Spayed/Neutered"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(206, 64)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(114, 34)
        Me.NumericUpDown1.TabIndex = 14
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(7, 306)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 37)
        Me.ComboBox1.TabIndex = 15
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(202, 31)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(99, 19)
        Me.lblWeight.TabIndex = 16
        Me.lblWeight.Text = "Weight (lbs)"
        '
        'rbYes
        '
        Me.rbYes.AutoSize = True
        Me.rbYes.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbYes.Location = New System.Drawing.Point(7, 472)
        Me.rbYes.Name = "rbYes"
        Me.rbYes.Size = New System.Drawing.Size(56, 23)
        Me.rbYes.TabIndex = 17
        Me.rbYes.TabStop = True
        Me.rbYes.Text = "Yes"
        Me.rbYes.UseVisualStyleBackColor = True
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNo.Location = New System.Drawing.Point(6, 501)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(51, 23)
        Me.rbNo.TabIndex = 18
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'GeneralInformationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 737)
        Me.Controls.Add(Me.gbDogInfo)
        Me.Controls.Add(Me.Exitbt)
        Me.Controls.Add(Me.Resetbt)
        Me.Controls.Add(Me.continuebt)
        Me.Controls.Add(Me.ownerpanel)
        Me.Controls.Add(Me.GeneralInformationHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GeneralInformationForm"
        Me.Text = "General-Information"
        CType(Me.GeneralInformationHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ownerpanel.ResumeLayout(False)
        Me.ownerpanel.PerformLayout()
        Me.gbDogInfo.ResumeLayout(False)
        Me.gbDogInfo.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ownerpanel As Panel
    Friend WithEvents vetinfolb As Label
    Friend WithEvents owneraddresstxb As TextBox
    Friend WithEvents owneraddresslb As Label
    Friend WithEvents owneremailtxb As TextBox
    Friend WithEvents owneremaillb As Label
    Friend WithEvents ownerphonetxb As TextBox
    Friend WithEvents ownerphonelb As Label
    Friend WithEvents ownernametxb As TextBox
    Friend WithEvents ownernamelb As Label
    Friend WithEvents ownerinfolb As Label
    Friend WithEvents vetnamelb As Label
    Friend WithEvents vetphonetxb As TextBox
    Friend WithEvents vetphonelb As Label
    Friend WithEvents vetnamtxb As TextBox
    Friend WithEvents continuebt As Button
    Friend WithEvents Resetbt As Button
    Friend WithEvents Exitbt As Button
    Friend WithEvents gbDogInfo As GroupBox
    Friend WithEvents lblSpayedNeutered As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbYes As RadioButton
End Class
