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
        Me.doginfolb = New System.Windows.Forms.Label()
        Me.dognamelb = New System.Windows.Forms.Label()
        Me.dognametxb = New System.Windows.Forms.TextBox()
        Me.breedlb = New System.Windows.Forms.Label()
        Me.dogbreedtxb = New System.Windows.Forms.TextBox()
        Me.colorlb = New System.Windows.Forms.Label()
        Me.colortxb = New System.Windows.Forms.TextBox()
        Me.specialmarklb = New System.Windows.Forms.Label()
        Me.specialmarktxb = New System.Windows.Forms.TextBox()
        Me.dogagelb = New System.Windows.Forms.Label()
        Me.genderlb = New System.Windows.Forms.Label()
        Me.malerb = New System.Windows.Forms.RadioButton()
        Me.Femalerb = New System.Windows.Forms.RadioButton()
        Me.spayneurb = New System.Windows.Forms.RadioButton()
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
        Me.agedb = New System.Windows.Forms.ComboBox()
        Me.continuebt = New System.Windows.Forms.Button()
        Me.Resetbt = New System.Windows.Forms.Button()
        Me.Exitbt = New System.Windows.Forms.Button()
        CType(Me.GeneralInformationHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ownerpanel.SuspendLayout()
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
        'doginfolb
        '
        Me.doginfolb.AutoSize = True
        Me.doginfolb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doginfolb.Location = New System.Drawing.Point(12, 141)
        Me.doginfolb.Name = "doginfolb"
        Me.doginfolb.Size = New System.Drawing.Size(198, 29)
        Me.doginfolb.TabIndex = 1
        Me.doginfolb.Text = "Dog Information"
        '
        'dognamelb
        '
        Me.dognamelb.AutoSize = True
        Me.dognamelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dognamelb.Location = New System.Drawing.Point(14, 194)
        Me.dognamelb.Name = "dognamelb"
        Me.dognamelb.Size = New System.Drawing.Size(88, 19)
        Me.dognamelb.TabIndex = 2
        Me.dognamelb.Text = "Dog Name"
        '
        'dognametxb
        '
        Me.dognametxb.Location = New System.Drawing.Point(17, 216)
        Me.dognametxb.Name = "dognametxb"
        Me.dognametxb.Size = New System.Drawing.Size(129, 22)
        Me.dognametxb.TabIndex = 1
        '
        'breedlb
        '
        Me.breedlb.AutoSize = True
        Me.breedlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breedlb.Location = New System.Drawing.Point(13, 266)
        Me.breedlb.Name = "breedlb"
        Me.breedlb.Size = New System.Drawing.Size(52, 19)
        Me.breedlb.TabIndex = 4
        Me.breedlb.Text = "Breed"
        '
        'dogbreedtxb
        '
        Me.dogbreedtxb.Location = New System.Drawing.Point(17, 288)
        Me.dogbreedtxb.Name = "dogbreedtxb"
        Me.dogbreedtxb.Size = New System.Drawing.Size(129, 22)
        Me.dogbreedtxb.TabIndex = 2
        '
        'colorlb
        '
        Me.colorlb.AutoSize = True
        Me.colorlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colorlb.Location = New System.Drawing.Point(14, 333)
        Me.colorlb.Name = "colorlb"
        Me.colorlb.Size = New System.Drawing.Size(49, 19)
        Me.colorlb.TabIndex = 6
        Me.colorlb.Text = "Color"
        '
        'colortxb
        '
        Me.colortxb.Location = New System.Drawing.Point(17, 355)
        Me.colortxb.Name = "colortxb"
        Me.colortxb.Size = New System.Drawing.Size(129, 22)
        Me.colortxb.TabIndex = 3
        '
        'specialmarklb
        '
        Me.specialmarklb.AutoSize = True
        Me.specialmarklb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialmarklb.Location = New System.Drawing.Point(13, 402)
        Me.specialmarklb.Name = "specialmarklb"
        Me.specialmarklb.Size = New System.Drawing.Size(131, 19)
        Me.specialmarklb.TabIndex = 8
        Me.specialmarklb.Text = "Special Markings"
        '
        'specialmarktxb
        '
        Me.specialmarktxb.Location = New System.Drawing.Point(16, 424)
        Me.specialmarktxb.Name = "specialmarktxb"
        Me.specialmarktxb.Size = New System.Drawing.Size(128, 22)
        Me.specialmarktxb.TabIndex = 4
        '
        'dogagelb
        '
        Me.dogagelb.AutoSize = True
        Me.dogagelb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dogagelb.Location = New System.Drawing.Point(16, 470)
        Me.dogagelb.Name = "dogagelb"
        Me.dogagelb.Size = New System.Drawing.Size(37, 19)
        Me.dogagelb.TabIndex = 10
        Me.dogagelb.Text = "Age"
        '
        'genderlb
        '
        Me.genderlb.AutoSize = True
        Me.genderlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderlb.Location = New System.Drawing.Point(14, 547)
        Me.genderlb.Name = "genderlb"
        Me.genderlb.Size = New System.Drawing.Size(63, 19)
        Me.genderlb.TabIndex = 12
        Me.genderlb.Text = "Gender"
        '
        'malerb
        '
        Me.malerb.AutoSize = True
        Me.malerb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.malerb.Location = New System.Drawing.Point(18, 581)
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
        Me.Femalerb.Location = New System.Drawing.Point(17, 618)
        Me.Femalerb.Name = "Femalerb"
        Me.Femalerb.Size = New System.Drawing.Size(84, 23)
        Me.Femalerb.TabIndex = 7
        Me.Femalerb.TabStop = True
        Me.Femalerb.Text = "Female"
        Me.Femalerb.UseVisualStyleBackColor = True
        '
        'spayneurb
        '
        Me.spayneurb.AutoSize = True
        Me.spayneurb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spayneurb.Location = New System.Drawing.Point(18, 655)
        Me.spayneurb.Name = "spayneurb"
        Me.spayneurb.Size = New System.Drawing.Size(160, 23)
        Me.spayneurb.TabIndex = 8
        Me.spayneurb.TabStop = True
        Me.spayneurb.Text = "Spayed/Neutered"
        Me.spayneurb.UseVisualStyleBackColor = True
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
        'agedb
        '
        Me.agedb.FormattingEnabled = True
        Me.agedb.Location = New System.Drawing.Point(16, 492)
        Me.agedb.Name = "agedb"
        Me.agedb.Size = New System.Drawing.Size(130, 24)
        Me.agedb.TabIndex = 5
        '
        'continuebt
        '
        Me.continuebt.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.continuebt.Location = New System.Drawing.Point(400, 702)
        Me.continuebt.Name = "continuebt"
        Me.continuebt.Size = New System.Drawing.Size(84, 23)
        Me.continuebt.TabIndex = 15
        Me.continuebt.Text = "Continue"
        Me.continuebt.UseVisualStyleBackColor = True
        '
        'Resetbt
        '
        Me.Resetbt.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resetbt.Location = New System.Drawing.Point(522, 702)
        Me.Resetbt.Name = "Resetbt"
        Me.Resetbt.Size = New System.Drawing.Size(75, 23)
        Me.Resetbt.TabIndex = 16
        Me.Resetbt.Text = "Reset"
        Me.Resetbt.UseVisualStyleBackColor = True
        '
        'Exitbt
        '
        Me.Exitbt.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exitbt.Location = New System.Drawing.Point(631, 702)
        Me.Exitbt.Name = "Exitbt"
        Me.Exitbt.Size = New System.Drawing.Size(75, 23)
        Me.Exitbt.TabIndex = 17
        Me.Exitbt.Text = "Exit"
        Me.Exitbt.UseVisualStyleBackColor = True
        '
        'GeneralInformationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 737)
        Me.Controls.Add(Me.Exitbt)
        Me.Controls.Add(Me.Resetbt)
        Me.Controls.Add(Me.continuebt)
        Me.Controls.Add(Me.agedb)
        Me.Controls.Add(Me.ownerpanel)
        Me.Controls.Add(Me.spayneurb)
        Me.Controls.Add(Me.Femalerb)
        Me.Controls.Add(Me.malerb)
        Me.Controls.Add(Me.genderlb)
        Me.Controls.Add(Me.dogagelb)
        Me.Controls.Add(Me.specialmarktxb)
        Me.Controls.Add(Me.specialmarklb)
        Me.Controls.Add(Me.colortxb)
        Me.Controls.Add(Me.colorlb)
        Me.Controls.Add(Me.dogbreedtxb)
        Me.Controls.Add(Me.breedlb)
        Me.Controls.Add(Me.dognametxb)
        Me.Controls.Add(Me.dognamelb)
        Me.Controls.Add(Me.doginfolb)
        Me.Controls.Add(Me.GeneralInformationHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GeneralInformationForm"
        Me.Text = "General-Information"
        CType(Me.GeneralInformationHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ownerpanel.ResumeLayout(False)
        Me.ownerpanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GeneralInformationHeader As PictureBox
    Friend WithEvents doginfolb As Label
    Friend WithEvents dognamelb As Label
    Friend WithEvents dognametxb As TextBox
    Friend WithEvents breedlb As Label
    Friend WithEvents dogbreedtxb As TextBox
    Friend WithEvents colorlb As Label
    Friend WithEvents colortxb As TextBox
    Friend WithEvents specialmarklb As Label
    Friend WithEvents specialmarktxb As TextBox
    Friend WithEvents dogagelb As Label
    Friend WithEvents genderlb As Label
    Friend WithEvents malerb As RadioButton
    Friend WithEvents Femalerb As RadioButton
    Friend WithEvents spayneurb As RadioButton
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
    Friend WithEvents agedb As ComboBox
    Friend WithEvents vetnamelb As Label
    Friend WithEvents vetphonetxb As TextBox
    Friend WithEvents vetphonelb As Label
    Friend WithEvents vetnamtxb As TextBox
    Friend WithEvents continuebt As Button
    Friend WithEvents Resetbt As Button
    Friend WithEvents Exitbt As Button
End Class
