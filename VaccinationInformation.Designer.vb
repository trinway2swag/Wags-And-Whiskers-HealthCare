<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VaccinationInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VaccinationInformation))
        Me.prevbordetellacb = New System.Windows.Forms.CheckBox()
        Me.prevparaininfluenzacb = New System.Windows.Forms.CheckBox()
        Me.prevleptospirosiscb = New System.Windows.Forms.CheckBox()
        Me.prevcanineinfluenzacb = New System.Windows.Forms.CheckBox()
        Me.prevrabiescb = New System.Windows.Forms.CheckBox()
        Me.cbAvRabies = New System.Windows.Forms.CheckBox()
        Me.cbAvCanInflu = New System.Windows.Forms.CheckBox()
        Me.cbAvLepto = New System.Windows.Forms.CheckBox()
        Me.cbAvParInflu = New System.Windows.Forms.CheckBox()
        Me.cbAvBordetellavacc = New System.Windows.Forms.CheckBox()
        Me.cbAvDeworm = New System.Windows.Forms.CheckBox()
        Me.cbAvHeartworm = New System.Windows.Forms.CheckBox()
        Me.bordetellapricelbl = New System.Windows.Forms.Label()
        Me.paraininfluenzapricelbl = New System.Windows.Forms.Label()
        Me.leptospirosispricelbl = New System.Windows.Forms.Label()
        Me.canineinfluenzapricelbl = New System.Windows.Forms.Label()
        Me.rabiespricelbl = New System.Windows.Forms.Label()
        Me.dewormpillpricelbl = New System.Windows.Forms.Label()
        Me.heartwormpricelbl = New System.Windows.Forms.Label()
        Me.vaccineinfoexitbt = New System.Windows.Forms.Button()
        Me.vaccineinforesetbt = New System.Windows.Forms.Button()
        Me.vaccineinfocontinuebt = New System.Windows.Forms.Button()
        Me.Vaccineinfodatelbl = New System.Windows.Forms.Label()
        Me.gbPrevVacc = New System.Windows.Forms.GroupBox()
        Me.gbAvailableVacc = New System.Windows.Forms.GroupBox()
        Me.mtbTodayDate = New System.Windows.Forms.MaskedTextBox()
        Me.pbAvVacc = New System.Windows.Forms.PictureBox()
        Me.pbPrevVac = New System.Windows.Forms.PictureBox()
        Me.pbDate = New System.Windows.Forms.PictureBox()
        Me.pbVaccInfoLogo = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbPrevVacc.SuspendLayout()
        Me.gbAvailableVacc.SuspendLayout()
        CType(Me.pbAvVacc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPrevVac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVaccInfoLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prevbordetellacb
        '
        Me.prevbordetellacb.AutoSize = True
        Me.prevbordetellacb.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevbordetellacb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.prevbordetellacb.Location = New System.Drawing.Point(6, 83)
        Me.prevbordetellacb.Name = "prevbordetellacb"
        Me.prevbordetellacb.Size = New System.Drawing.Size(100, 22)
        Me.prevbordetellacb.TabIndex = 1
        Me.prevbordetellacb.Text = "Bordetella"
        Me.prevbordetellacb.UseVisualStyleBackColor = True
        '
        'prevparaininfluenzacb
        '
        Me.prevparaininfluenzacb.AutoSize = True
        Me.prevparaininfluenzacb.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevparaininfluenzacb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.prevparaininfluenzacb.Location = New System.Drawing.Point(6, 109)
        Me.prevparaininfluenzacb.Name = "prevparaininfluenzacb"
        Me.prevparaininfluenzacb.Size = New System.Drawing.Size(139, 22)
        Me.prevparaininfluenzacb.TabIndex = 2
        Me.prevparaininfluenzacb.Text = "Parain influenza"
        Me.prevparaininfluenzacb.UseVisualStyleBackColor = True
        '
        'prevleptospirosiscb
        '
        Me.prevleptospirosiscb.AutoSize = True
        Me.prevleptospirosiscb.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevleptospirosiscb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.prevleptospirosiscb.Location = New System.Drawing.Point(6, 133)
        Me.prevleptospirosiscb.Name = "prevleptospirosiscb"
        Me.prevleptospirosiscb.Size = New System.Drawing.Size(124, 22)
        Me.prevleptospirosiscb.TabIndex = 3
        Me.prevleptospirosiscb.Text = "Leptospirosis"
        Me.prevleptospirosiscb.UseVisualStyleBackColor = True
        '
        'prevcanineinfluenzacb
        '
        Me.prevcanineinfluenzacb.AutoSize = True
        Me.prevcanineinfluenzacb.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevcanineinfluenzacb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.prevcanineinfluenzacb.Location = New System.Drawing.Point(6, 161)
        Me.prevcanineinfluenzacb.Name = "prevcanineinfluenzacb"
        Me.prevcanineinfluenzacb.Size = New System.Drawing.Size(144, 22)
        Me.prevcanineinfluenzacb.TabIndex = 4
        Me.prevcanineinfluenzacb.Text = "Canine influenza"
        Me.prevcanineinfluenzacb.UseVisualStyleBackColor = True
        '
        'prevrabiescb
        '
        Me.prevrabiescb.AutoSize = True
        Me.prevrabiescb.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevrabiescb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.prevrabiescb.Location = New System.Drawing.Point(6, 189)
        Me.prevrabiescb.Name = "prevrabiescb"
        Me.prevrabiescb.Size = New System.Drawing.Size(76, 22)
        Me.prevrabiescb.TabIndex = 5
        Me.prevrabiescb.Text = "Rabies"
        Me.prevrabiescb.UseVisualStyleBackColor = True
        '
        'cbAvRabies
        '
        Me.cbAvRabies.AutoSize = True
        Me.cbAvRabies.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAvRabies.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbAvRabies.Location = New System.Drawing.Point(6, 139)
        Me.cbAvRabies.Name = "cbAvRabies"
        Me.cbAvRabies.Size = New System.Drawing.Size(76, 22)
        Me.cbAvRabies.TabIndex = 11
        Me.cbAvRabies.Text = "Rabies"
        Me.cbAvRabies.UseVisualStyleBackColor = True
        '
        'cbAvCanInflu
        '
        Me.cbAvCanInflu.AutoSize = True
        Me.cbAvCanInflu.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAvCanInflu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbAvCanInflu.Location = New System.Drawing.Point(6, 28)
        Me.cbAvCanInflu.Name = "cbAvCanInflu"
        Me.cbAvCanInflu.Size = New System.Drawing.Size(144, 22)
        Me.cbAvCanInflu.TabIndex = 7
        Me.cbAvCanInflu.Text = "Canine influenza"
        Me.cbAvCanInflu.UseVisualStyleBackColor = True
        '
        'cbAvLepto
        '
        Me.cbAvLepto.AutoSize = True
        Me.cbAvLepto.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAvLepto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbAvLepto.Location = New System.Drawing.Point(6, 56)
        Me.cbAvLepto.Name = "cbAvLepto"
        Me.cbAvLepto.Size = New System.Drawing.Size(124, 22)
        Me.cbAvLepto.TabIndex = 8
        Me.cbAvLepto.Text = "Leptospirosis"
        Me.cbAvLepto.UseVisualStyleBackColor = True
        '
        'cbAvParInflu
        '
        Me.cbAvParInflu.AutoSize = True
        Me.cbAvParInflu.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAvParInflu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbAvParInflu.Location = New System.Drawing.Point(6, 109)
        Me.cbAvParInflu.Name = "cbAvParInflu"
        Me.cbAvParInflu.Size = New System.Drawing.Size(139, 22)
        Me.cbAvParInflu.TabIndex = 10
        Me.cbAvParInflu.Text = "Parain influenza"
        Me.cbAvParInflu.UseVisualStyleBackColor = True
        '
        'cbAvBordetellavacc
        '
        Me.cbAvBordetellavacc.AutoSize = True
        Me.cbAvBordetellavacc.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAvBordetellavacc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbAvBordetellavacc.Location = New System.Drawing.Point(6, 83)
        Me.cbAvBordetellavacc.Name = "cbAvBordetellavacc"
        Me.cbAvBordetellavacc.Size = New System.Drawing.Size(100, 22)
        Me.cbAvBordetellavacc.TabIndex = 9
        Me.cbAvBordetellavacc.Text = "Bordetella"
        Me.cbAvBordetellavacc.UseVisualStyleBackColor = True
        '
        'cbAvDeworm
        '
        Me.cbAvDeworm.AutoSize = True
        Me.cbAvDeworm.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAvDeworm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbAvDeworm.Location = New System.Drawing.Point(6, 167)
        Me.cbAvDeworm.Name = "cbAvDeworm"
        Me.cbAvDeworm.Size = New System.Drawing.Size(131, 22)
        Me.cbAvDeworm.TabIndex = 12
        Me.cbAvDeworm.Text = "Deworming Pill"
        Me.cbAvDeworm.UseVisualStyleBackColor = True
        '
        'cbAvHeartworm
        '
        Me.cbAvHeartworm.AutoSize = True
        Me.cbAvHeartworm.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAvHeartworm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbAvHeartworm.Location = New System.Drawing.Point(6, 195)
        Me.cbAvHeartworm.Name = "cbAvHeartworm"
        Me.cbAvHeartworm.Size = New System.Drawing.Size(198, 22)
        Me.cbAvHeartworm.TabIndex = 13
        Me.cbAvHeartworm.Text = "Heartworm Preventative"
        Me.cbAvHeartworm.UseVisualStyleBackColor = True
        '
        'bordetellapricelbl
        '
        Me.bordetellapricelbl.AutoSize = True
        Me.bordetellapricelbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bordetellapricelbl.Location = New System.Drawing.Point(225, 111)
        Me.bordetellapricelbl.Name = "bordetellapricelbl"
        Me.bordetellapricelbl.Size = New System.Drawing.Size(35, 18)
        Me.bordetellapricelbl.TabIndex = 18
        Me.bordetellapricelbl.Text = "$20"
        '
        'paraininfluenzapricelbl
        '
        Me.paraininfluenzapricelbl.AutoSize = True
        Me.paraininfluenzapricelbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paraininfluenzapricelbl.Location = New System.Drawing.Point(225, 85)
        Me.paraininfluenzapricelbl.Name = "paraininfluenzapricelbl"
        Me.paraininfluenzapricelbl.Size = New System.Drawing.Size(35, 18)
        Me.paraininfluenzapricelbl.TabIndex = 19
        Me.paraininfluenzapricelbl.Text = "$20"
        '
        'leptospirosispricelbl
        '
        Me.leptospirosispricelbl.AutoSize = True
        Me.leptospirosispricelbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leptospirosispricelbl.Location = New System.Drawing.Point(225, 58)
        Me.leptospirosispricelbl.Name = "leptospirosispricelbl"
        Me.leptospirosispricelbl.Size = New System.Drawing.Size(35, 18)
        Me.leptospirosispricelbl.TabIndex = 20
        Me.leptospirosispricelbl.Text = "$25"
        '
        'canineinfluenzapricelbl
        '
        Me.canineinfluenzapricelbl.AutoSize = True
        Me.canineinfluenzapricelbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.canineinfluenzapricelbl.Location = New System.Drawing.Point(225, 30)
        Me.canineinfluenzapricelbl.Name = "canineinfluenzapricelbl"
        Me.canineinfluenzapricelbl.Size = New System.Drawing.Size(35, 18)
        Me.canineinfluenzapricelbl.TabIndex = 21
        Me.canineinfluenzapricelbl.Text = "$30"
        '
        'rabiespricelbl
        '
        Me.rabiespricelbl.AutoSize = True
        Me.rabiespricelbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rabiespricelbl.Location = New System.Drawing.Point(225, 141)
        Me.rabiespricelbl.Name = "rabiespricelbl"
        Me.rabiespricelbl.Size = New System.Drawing.Size(35, 18)
        Me.rabiespricelbl.TabIndex = 22
        Me.rabiespricelbl.Text = "$15"
        '
        'dewormpillpricelbl
        '
        Me.dewormpillpricelbl.AutoSize = True
        Me.dewormpillpricelbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dewormpillpricelbl.Location = New System.Drawing.Point(225, 169)
        Me.dewormpillpricelbl.Name = "dewormpillpricelbl"
        Me.dewormpillpricelbl.Size = New System.Drawing.Size(35, 18)
        Me.dewormpillpricelbl.TabIndex = 23
        Me.dewormpillpricelbl.Text = "$10"
        '
        'heartwormpricelbl
        '
        Me.heartwormpricelbl.AutoSize = True
        Me.heartwormpricelbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heartwormpricelbl.Location = New System.Drawing.Point(225, 197)
        Me.heartwormpricelbl.Name = "heartwormpricelbl"
        Me.heartwormpricelbl.Size = New System.Drawing.Size(35, 18)
        Me.heartwormpricelbl.TabIndex = 24
        Me.heartwormpricelbl.Text = "$10"
        '
        'vaccineinfoexitbt
        '
        Me.vaccineinfoexitbt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.vaccineinfoexitbt.Location = New System.Drawing.Point(386, 325)
        Me.vaccineinfoexitbt.Name = "vaccineinfoexitbt"
        Me.vaccineinfoexitbt.Size = New System.Drawing.Size(75, 23)
        Me.vaccineinfoexitbt.TabIndex = 18
        Me.vaccineinfoexitbt.Text = "Exit"
        Me.vaccineinfoexitbt.UseVisualStyleBackColor = True
        '
        'vaccineinforesetbt
        '
        Me.vaccineinforesetbt.Location = New System.Drawing.Point(763, 325)
        Me.vaccineinforesetbt.Name = "vaccineinforesetbt"
        Me.vaccineinforesetbt.Size = New System.Drawing.Size(75, 23)
        Me.vaccineinforesetbt.TabIndex = 16
        Me.vaccineinforesetbt.Text = "Reset"
        Me.vaccineinforesetbt.UseVisualStyleBackColor = True
        '
        'vaccineinfocontinuebt
        '
        Me.vaccineinfocontinuebt.Location = New System.Drawing.Point(900, 325)
        Me.vaccineinfocontinuebt.Name = "vaccineinfocontinuebt"
        Me.vaccineinfocontinuebt.Size = New System.Drawing.Size(90, 23)
        Me.vaccineinfocontinuebt.TabIndex = 15
        Me.vaccineinfocontinuebt.Text = "Continue"
        Me.vaccineinfocontinuebt.UseVisualStyleBackColor = True
        '
        'Vaccineinfodatelbl
        '
        Me.Vaccineinfodatelbl.AutoSize = True
        Me.Vaccineinfodatelbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vaccineinfodatelbl.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Vaccineinfodatelbl.Location = New System.Drawing.Point(624, 262)
        Me.Vaccineinfodatelbl.Name = "Vaccineinfodatelbl"
        Me.Vaccineinfodatelbl.Size = New System.Drawing.Size(125, 19)
        Me.Vaccineinfodatelbl.TabIndex = 367
        Me.Vaccineinfodatelbl.Text = "Today's date:"
        '
        'gbPrevVacc
        '
        Me.gbPrevVacc.Controls.Add(Me.prevbordetellacb)
        Me.gbPrevVacc.Controls.Add(Me.prevparaininfluenzacb)
        Me.gbPrevVacc.Controls.Add(Me.prevleptospirosiscb)
        Me.gbPrevVacc.Controls.Add(Me.prevcanineinfluenzacb)
        Me.gbPrevVacc.Controls.Add(Me.prevrabiescb)
        Me.gbPrevVacc.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPrevVacc.ForeColor = System.Drawing.Color.DarkCyan
        Me.gbPrevVacc.Location = New System.Drawing.Point(403, 12)
        Me.gbPrevVacc.Name = "gbPrevVacc"
        Me.gbPrevVacc.Size = New System.Drawing.Size(266, 247)
        Me.gbPrevVacc.TabIndex = 0
        Me.gbPrevVacc.TabStop = False
        Me.gbPrevVacc.Text = "*Please enter any previous vaccinations recieved."
        '
        'gbAvailableVacc
        '
        Me.gbAvailableVacc.Controls.Add(Me.cbAvBordetellavacc)
        Me.gbAvailableVacc.Controls.Add(Me.cbAvParInflu)
        Me.gbAvailableVacc.Controls.Add(Me.cbAvLepto)
        Me.gbAvailableVacc.Controls.Add(Me.cbAvCanInflu)
        Me.gbAvailableVacc.Controls.Add(Me.cbAvRabies)
        Me.gbAvailableVacc.Controls.Add(Me.cbAvDeworm)
        Me.gbAvailableVacc.Controls.Add(Me.cbAvHeartworm)
        Me.gbAvailableVacc.Controls.Add(Me.bordetellapricelbl)
        Me.gbAvailableVacc.Controls.Add(Me.paraininfluenzapricelbl)
        Me.gbAvailableVacc.Controls.Add(Me.leptospirosispricelbl)
        Me.gbAvailableVacc.Controls.Add(Me.canineinfluenzapricelbl)
        Me.gbAvailableVacc.Controls.Add(Me.rabiespricelbl)
        Me.gbAvailableVacc.Controls.Add(Me.dewormpillpricelbl)
        Me.gbAvailableVacc.Controls.Add(Me.heartwormpricelbl)
        Me.gbAvailableVacc.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAvailableVacc.ForeColor = System.Drawing.Color.DarkCyan
        Me.gbAvailableVacc.Location = New System.Drawing.Point(708, 12)
        Me.gbAvailableVacc.Name = "gbAvailableVacc"
        Me.gbAvailableVacc.Size = New System.Drawing.Size(266, 247)
        Me.gbAvailableVacc.TabIndex = 6
        Me.gbAvailableVacc.TabStop = False
        Me.gbAvailableVacc.Text = "*Available Vaccinations"
        '
        'mtbTodayDate
        '
        Me.mtbTodayDate.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbTodayDate.Location = New System.Drawing.Point(618, 284)
        Me.mtbTodayDate.Mask = "00/00/0000"
        Me.mtbTodayDate.Name = "mtbTodayDate"
        Me.mtbTodayDate.Size = New System.Drawing.Size(145, 26)
        Me.mtbTodayDate.TabIndex = 14
        Me.mtbTodayDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtbTodayDate.ValidatingType = GetType(Date)
        '
        'pbAvVacc
        '
        Me.pbAvVacc.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.syringe
        Me.pbAvVacc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbAvVacc.Location = New System.Drawing.Point(675, 12)
        Me.pbAvVacc.Name = "pbAvVacc"
        Me.pbAvVacc.Size = New System.Drawing.Size(33, 26)
        Me.pbAvVacc.TabIndex = 371
        Me.pbAvVacc.TabStop = False
        '
        'pbPrevVac
        '
        Me.pbPrevVac.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.syringe
        Me.pbPrevVac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbPrevVac.Location = New System.Drawing.Point(373, 12)
        Me.pbPrevVac.Name = "pbPrevVac"
        Me.pbPrevVac.Size = New System.Drawing.Size(33, 26)
        Me.pbPrevVac.TabIndex = 370
        Me.pbPrevVac.TabStop = False
        '
        'pbDate
        '
        Me.pbDate.BackgroundImage = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.calendar
        Me.pbDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbDate.Location = New System.Drawing.Point(585, 262)
        Me.pbDate.Name = "pbDate"
        Me.pbDate.Size = New System.Drawing.Size(33, 26)
        Me.pbDate.TabIndex = 369
        Me.pbDate.TabStop = False
        '
        'pbVaccInfoLogo
        '
        Me.pbVaccInfoLogo.Image = Global.Wags_And_Whiskers_HealthCare.My.Resources.Resources.vaccinfo
        Me.pbVaccInfoLogo.Location = New System.Drawing.Point(-18, 1)
        Me.pbVaccInfoLogo.Name = "pbVaccInfoLogo"
        Me.pbVaccInfoLogo.Size = New System.Drawing.Size(376, 364)
        Me.pbVaccInfoLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbVaccInfoLogo.TabIndex = 368
        Me.pbVaccInfoLogo.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(543, 325)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'VaccinationInformation
        '
        Me.AcceptButton = Me.vaccineinfocontinuebt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.vaccineinfoexitbt
        Me.ClientSize = New System.Drawing.Size(1002, 360)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pbAvVacc)
        Me.Controls.Add(Me.pbPrevVac)
        Me.Controls.Add(Me.pbDate)
        Me.Controls.Add(Me.mtbTodayDate)
        Me.Controls.Add(Me.Vaccineinfodatelbl)
        Me.Controls.Add(Me.gbAvailableVacc)
        Me.Controls.Add(Me.gbPrevVacc)
        Me.Controls.Add(Me.vaccineinfocontinuebt)
        Me.Controls.Add(Me.vaccineinforesetbt)
        Me.Controls.Add(Me.vaccineinfoexitbt)
        Me.Controls.Add(Me.pbVaccInfoLogo)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VaccinationInformation"
        Me.Text = "VaccinationInformation"
        Me.gbPrevVacc.ResumeLayout(False)
        Me.gbPrevVacc.PerformLayout()
        Me.gbAvailableVacc.ResumeLayout(False)
        Me.gbAvailableVacc.PerformLayout()
        CType(Me.pbAvVacc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPrevVac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVaccInfoLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents prevbordetellacb As CheckBox
    Friend WithEvents prevparaininfluenzacb As CheckBox
    Friend WithEvents prevleptospirosiscb As CheckBox
    Friend WithEvents prevcanineinfluenzacb As CheckBox
    Friend WithEvents prevrabiescb As CheckBox
    Friend WithEvents cbAvRabies As CheckBox
    Friend WithEvents cbAvCanInflu As CheckBox
    Friend WithEvents cbAvLepto As CheckBox
    Friend WithEvents cbAvParInflu As CheckBox
    Friend WithEvents cbAvBordetellavacc As CheckBox
    Friend WithEvents cbAvDeworm As CheckBox
    Friend WithEvents cbAvHeartworm As CheckBox
    Friend WithEvents bordetellapricelbl As Label
    Friend WithEvents paraininfluenzapricelbl As Label
    Friend WithEvents leptospirosispricelbl As Label
    Friend WithEvents canineinfluenzapricelbl As Label
    Friend WithEvents rabiespricelbl As Label
    Friend WithEvents dewormpillpricelbl As Label
    Friend WithEvents heartwormpricelbl As Label
    Friend WithEvents vaccineinfoexitbt As Button
    Friend WithEvents vaccineinforesetbt As Button
    Friend WithEvents vaccineinfocontinuebt As Button
    Friend WithEvents Vaccineinfodatelbl As Label
    Friend WithEvents pbVaccInfoLogo As PictureBox
    Friend WithEvents gbPrevVacc As GroupBox
    Friend WithEvents gbAvailableVacc As GroupBox
    Friend WithEvents mtbTodayDate As MaskedTextBox
    Friend WithEvents pbDate As PictureBox
    Friend WithEvents pbPrevVac As PictureBox
    Friend WithEvents pbAvVacc As PictureBox
    Friend WithEvents btnBack As Button
End Class
