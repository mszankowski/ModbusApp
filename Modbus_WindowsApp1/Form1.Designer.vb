<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.grpWrite = New System.Windows.Forms.GroupBox()
        Me.chbDecHex = New System.Windows.Forms.CheckBox()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.txtWriteValue = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtWriteReg = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtStartReg2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLengthReg2 = New System.Windows.Forms.TextBox()
        Me.btnRead2 = New System.Windows.Forms.Button()
        Me.grpRead2 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBoxViewType = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDEC = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCHAR = New System.Windows.Forms.RadioButton()
        Me.RadioButtonHEX = New System.Windows.Forms.RadioButton()
        Me.txtStartReg2HEX = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chbReadCyclic = New System.Windows.Forms.CheckBox()
        Me.txtStationID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.groupBoxASCII_RTU = New System.Windows.Forms.GroupBox()
        Me.comboBoxStopBits = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.comboBoxDataBits = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.comboBoxParity = New System.Windows.Forms.ComboBox()
        Me.labelParity = New System.Windows.Forms.Label()
        Me.comboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.comboBoxSerialPorts = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.textBoxSlaveDelay = New System.Windows.Forms.TextBox()
        Me.groupBoxTCP = New System.Windows.Forms.GroupBox()
        Me.btnPING = New System.Windows.Forms.Button()
        Me.lblStatus2 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTimeout = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNoRetries = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblComputerAddressIP = New System.Windows.Forms.Label()
        Me.comboBoxMode = New System.Windows.Forms.ComboBox()
        Me.groupBoxMode = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btrReadCOM = New System.Windows.Forms.Button()
        Me.btnDeviceMenager = New System.Windows.Forms.Button()
        Me.grpVFD_ME300 = New System.Windows.Forms.GroupBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnNetworkConnection = New System.Windows.Forms.Button()
        Me.txtboxREG10 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtboxVAL10 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnReadRandom = New System.Windows.Forms.Button()
        Me.txtboxOPIS10 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtboxOPIS11 = New System.Windows.Forms.TextBox()
        Me.txtboxVAL11 = New System.Windows.Forms.TextBox()
        Me.txtboxREG11 = New System.Windows.Forms.TextBox()
        Me.txtboxOPIS12 = New System.Windows.Forms.TextBox()
        Me.txtboxVAL12 = New System.Windows.Forms.TextBox()
        Me.txtboxREG12 = New System.Windows.Forms.TextBox()
        Me.txtboxOPIS13 = New System.Windows.Forms.TextBox()
        Me.txtboxVAL13 = New System.Windows.Forms.TextBox()
        Me.txtboxREG13 = New System.Windows.Forms.TextBox()
        Me.grpRead = New System.Windows.Forms.GroupBox()
        Me.btnWrite14 = New System.Windows.Forms.Button()
        Me.chbDecHex14 = New System.Windows.Forms.CheckBox()
        Me.txtboxOPIS14 = New System.Windows.Forms.TextBox()
        Me.txtboxVAL14 = New System.Windows.Forms.TextBox()
        Me.txtboxREG14 = New System.Windows.Forms.TextBox()
        Me.btnWrite13 = New System.Windows.Forms.Button()
        Me.btnWrite12 = New System.Windows.Forms.Button()
        Me.btnWrite11 = New System.Windows.Forms.Button()
        Me.btnWrite10 = New System.Windows.Forms.Button()
        Me.chbDecHex13 = New System.Windows.Forms.CheckBox()
        Me.chbDecHex12 = New System.Windows.Forms.CheckBox()
        Me.chbDecHex11 = New System.Windows.Forms.CheckBox()
        Me.chbDecHex10 = New System.Windows.Forms.CheckBox()
        Me.txtboxILOSC = New System.Windows.Forms.TextBox()
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstCOM = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btrReadCOM2 = New System.Windows.Forms.Button()
        Me.lblComputerNameIP = New System.Windows.Forms.Label()
        Me.btnTEST = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpWrite.SuspendLayout()
        Me.grpRead2.SuspendLayout()
        Me.GroupBoxViewType.SuspendLayout()
        Me.groupBoxASCII_RTU.SuspendLayout()
        Me.groupBoxTCP.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxMode.SuspendLayout()
        Me.grpVFD_ME300.SuspendLayout()
        Me.grpRead.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP"
        '
        'txtIP
        '
        Me.txtIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtIP.Location = New System.Drawing.Point(30, 13)
        Me.txtIP.MaxLength = 15
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(99, 21)
        Me.txtIP.TabIndex = 1
        Me.txtIP.Text = "192.168.200.200"
        Me.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPort
        '
        Me.txtPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtPort.Location = New System.Drawing.Point(35, 38)
        Me.txtPort.MaxLength = 6
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(47, 21)
        Me.txtPort.TabIndex = 3
        Me.txtPort.Text = "502"
        Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port"
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConnect.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(155, 268)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(76, 38)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Connect"
        Me.ToolTip1.SetToolTip(Me.btnConnect, "Kliknij zeby polaczyc")
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'btnDisconnect
        '
        Me.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDisconnect.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnDisconnect.Location = New System.Drawing.Point(155, 316)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(76, 38)
        Me.btnDisconnect.TabIndex = 2
        Me.btnDisconnect.Text = "Disconnect"
        Me.ToolTip1.SetToolTip(Me.btnDisconnect, "Kliknij zeby rozlaczyc")
        Me.btnDisconnect.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(785, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Status :"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(785, 343)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(105, 13)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "---info o polaczeniu---"
        '
        'grpWrite
        '
        Me.grpWrite.Controls.Add(Me.chbDecHex)
        Me.grpWrite.Controls.Add(Me.btnWrite)
        Me.grpWrite.Controls.Add(Me.txtWriteValue)
        Me.grpWrite.Controls.Add(Me.Label8)
        Me.grpWrite.Controls.Add(Me.txtWriteReg)
        Me.grpWrite.Controls.Add(Me.Label7)
        Me.grpWrite.Enabled = False
        Me.grpWrite.Location = New System.Drawing.Point(504, 231)
        Me.grpWrite.Name = "grpWrite"
        Me.grpWrite.Size = New System.Drawing.Size(133, 110)
        Me.grpWrite.TabIndex = 9
        Me.grpWrite.TabStop = False
        Me.grpWrite.Text = "Write Single Register"
        '
        'chbDecHex
        '
        Me.chbDecHex.AutoSize = True
        Me.chbDecHex.Location = New System.Drawing.Point(3, 75)
        Me.chbDecHex.Name = "chbDecHex"
        Me.chbDecHex.Size = New System.Drawing.Size(54, 17)
        Me.chbDecHex.TabIndex = 103
        Me.chbDecHex.Text = "DeHe"
        Me.chbDecHex.UseVisualStyleBackColor = True
        '
        'btnWrite
        '
        Me.btnWrite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWrite.Location = New System.Drawing.Point(60, 71)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(65, 25)
        Me.btnWrite.TabIndex = 4
        Me.btnWrite.Text = "Write"
        Me.btnWrite.UseVisualStyleBackColor = False
        '
        'txtWriteValue
        '
        Me.txtWriteValue.Location = New System.Drawing.Point(60, 45)
        Me.txtWriteValue.MaxLength = 10
        Me.txtWriteValue.Name = "txtWriteValue"
        Me.txtWriteValue.Size = New System.Drawing.Size(65, 20)
        Me.txtWriteValue.TabIndex = 3
        Me.txtWriteValue.Text = "0"
        Me.txtWriteValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Value"
        '
        'txtWriteReg
        '
        Me.txtWriteReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtWriteReg.Location = New System.Drawing.Point(60, 19)
        Me.txtWriteReg.MaxLength = 10
        Me.txtWriteReg.Name = "txtWriteReg"
        Me.txtWriteReg.Size = New System.Drawing.Size(65, 20)
        Me.txtWriteReg.TabIndex = 1
        Me.txtWriteReg.Text = "0"
        Me.txtWriteReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Reg DEC"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(41, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "REGISTER in"
        '
        'txtStartReg2
        '
        Me.txtStartReg2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtStartReg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtStartReg2.Location = New System.Drawing.Point(45, 42)
        Me.txtStartReg2.MaxLength = 10
        Me.txtStartReg2.Name = "txtStartReg2"
        Me.txtStartReg2.Size = New System.Drawing.Size(65, 21)
        Me.txtStartReg2.TabIndex = 10
        Me.txtStartReg2.Text = "0"
        Me.txtStartReg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Length"
        '
        'txtLengthReg2
        '
        Me.txtLengthReg2.Location = New System.Drawing.Point(45, 94)
        Me.txtLengthReg2.MaxLength = 6
        Me.txtLengthReg2.Name = "txtLengthReg2"
        Me.txtLengthReg2.Size = New System.Drawing.Size(65, 20)
        Me.txtLengthReg2.TabIndex = 10
        Me.txtLengthReg2.Text = "10"
        Me.txtLengthReg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRead2
        '
        Me.btnRead2.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRead2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRead2.Location = New System.Drawing.Point(45, 127)
        Me.btnRead2.Name = "btnRead2"
        Me.btnRead2.Size = New System.Drawing.Size(65, 34)
        Me.btnRead2.TabIndex = 11
        Me.btnRead2.Text = "Read"
        Me.btnRead2.UseVisualStyleBackColor = False
        '
        'grpRead2
        '
        Me.grpRead2.BackColor = System.Drawing.SystemColors.Control
        Me.grpRead2.Controls.Add(Me.Label23)
        Me.grpRead2.Controls.Add(Me.btnRead2)
        Me.grpRead2.Controls.Add(Me.Label24)
        Me.grpRead2.Controls.Add(Me.Label22)
        Me.grpRead2.Controls.Add(Me.txtLengthReg2)
        Me.grpRead2.Controls.Add(Me.Label11)
        Me.grpRead2.Controls.Add(Me.GroupBoxViewType)
        Me.grpRead2.Controls.Add(Me.txtStartReg2)
        Me.grpRead2.Controls.Add(Me.txtStartReg2HEX)
        Me.grpRead2.Controls.Add(Me.ListView1)
        Me.grpRead2.Controls.Add(Me.Label12)
        Me.grpRead2.Enabled = False
        Me.grpRead2.Location = New System.Drawing.Point(242, 231)
        Me.grpRead2.Name = "grpRead2"
        Me.grpRead2.Size = New System.Drawing.Size(256, 279)
        Me.grpRead2.TabIndex = 14
        Me.grpRead2.TabStop = False
        Me.grpRead2.Text = "Read Holding Registers"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(14, 45)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(29, 13)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "DEC"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(33, 249)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 13)
        Me.Label24.TabIndex = 52
        Me.Label24.Text = "char nie dziala"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(14, 71)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 13)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "HEX"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBoxViewType
        '
        Me.GroupBoxViewType.Controls.Add(Me.RadioButtonDEC)
        Me.GroupBoxViewType.Controls.Add(Me.RadioButtonCHAR)
        Me.GroupBoxViewType.Controls.Add(Me.RadioButtonHEX)
        Me.GroupBoxViewType.Location = New System.Drawing.Point(36, 171)
        Me.GroupBoxViewType.Name = "GroupBoxViewType"
        Me.GroupBoxViewType.Size = New System.Drawing.Size(78, 74)
        Me.GroupBoxViewType.TabIndex = 51
        Me.GroupBoxViewType.TabStop = False
        Me.GroupBoxViewType.Text = "View type"
        '
        'RadioButtonDEC
        '
        Me.RadioButtonDEC.AutoSize = True
        Me.RadioButtonDEC.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButtonDEC.Checked = True
        Me.RadioButtonDEC.Location = New System.Drawing.Point(15, 14)
        Me.RadioButtonDEC.Name = "RadioButtonDEC"
        Me.RadioButtonDEC.Size = New System.Drawing.Size(47, 17)
        Me.RadioButtonDEC.TabIndex = 52
        Me.RadioButtonDEC.TabStop = True
        Me.RadioButtonDEC.Text = "DEC"
        Me.RadioButtonDEC.UseVisualStyleBackColor = False
        '
        'RadioButtonCHAR
        '
        Me.RadioButtonCHAR.AutoSize = True
        Me.RadioButtonCHAR.Location = New System.Drawing.Point(11, 52)
        Me.RadioButtonCHAR.Name = "RadioButtonCHAR"
        Me.RadioButtonCHAR.Size = New System.Drawing.Size(55, 17)
        Me.RadioButtonCHAR.TabIndex = 54
        Me.RadioButtonCHAR.Text = "CHAR"
        Me.RadioButtonCHAR.UseVisualStyleBackColor = True
        '
        'RadioButtonHEX
        '
        Me.RadioButtonHEX.AutoSize = True
        Me.RadioButtonHEX.Location = New System.Drawing.Point(15, 32)
        Me.RadioButtonHEX.Name = "RadioButtonHEX"
        Me.RadioButtonHEX.Size = New System.Drawing.Size(47, 17)
        Me.RadioButtonHEX.TabIndex = 53
        Me.RadioButtonHEX.Text = "HEX"
        Me.RadioButtonHEX.UseVisualStyleBackColor = True
        '
        'txtStartReg2HEX
        '
        Me.txtStartReg2HEX.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.txtStartReg2HEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtStartReg2HEX.Location = New System.Drawing.Point(45, 67)
        Me.txtStartReg2HEX.MaxLength = 10
        Me.txtStartReg2HEX.Name = "txtStartReg2HEX"
        Me.txtStartReg2HEX.Size = New System.Drawing.Size(65, 21)
        Me.txtStartReg2HEX.TabIndex = 14
        Me.txtStartReg2HEX.Text = "0"
        Me.txtStartReg2HEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(116, 16)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(134, 246)
        Me.ListView1.TabIndex = 47
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Reg"
        Me.ColumnHeader1.Width = 45
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Value"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 70
        '
        'chbReadCyclic
        '
        Me.chbReadCyclic.AutoSize = True
        Me.chbReadCyclic.Location = New System.Drawing.Point(797, 418)
        Me.chbReadCyclic.Name = "chbReadCyclic"
        Me.chbReadCyclic.Size = New System.Drawing.Size(103, 17)
        Me.chbReadCyclic.TabIndex = 41
        Me.chbReadCyclic.Text = "Czytaj cyklicznie"
        Me.chbReadCyclic.UseVisualStyleBackColor = True
        Me.chbReadCyclic.Visible = False
        '
        'txtStationID
        '
        Me.txtStationID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtStationID.Location = New System.Drawing.Point(96, 18)
        Me.txtStationID.MaxLength = 3
        Me.txtStationID.Name = "txtStationID"
        Me.txtStationID.Size = New System.Drawing.Size(34, 21)
        Me.txtStationID.TabIndex = 10
        Me.txtStationID.Text = "1"
        Me.txtStationID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 15)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Station ID"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'groupBoxASCII_RTU
        '
        Me.groupBoxASCII_RTU.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.groupBoxASCII_RTU.Controls.Add(Me.comboBoxStopBits)
        Me.groupBoxASCII_RTU.Controls.Add(Me.Label14)
        Me.groupBoxASCII_RTU.Controls.Add(Me.comboBoxDataBits)
        Me.groupBoxASCII_RTU.Controls.Add(Me.Label15)
        Me.groupBoxASCII_RTU.Controls.Add(Me.comboBoxParity)
        Me.groupBoxASCII_RTU.Controls.Add(Me.labelParity)
        Me.groupBoxASCII_RTU.Controls.Add(Me.comboBoxBaudRate)
        Me.groupBoxASCII_RTU.Controls.Add(Me.comboBoxSerialPorts)
        Me.groupBoxASCII_RTU.Controls.Add(Me.Label16)
        Me.groupBoxASCII_RTU.Controls.Add(Me.Label17)
        Me.groupBoxASCII_RTU.Location = New System.Drawing.Point(12, 104)
        Me.groupBoxASCII_RTU.Name = "groupBoxASCII_RTU"
        Me.groupBoxASCII_RTU.Size = New System.Drawing.Size(134, 158)
        Me.groupBoxASCII_RTU.TabIndex = 26
        Me.groupBoxASCII_RTU.TabStop = False
        Me.groupBoxASCII_RTU.Text = "ASCII/RTU"
        '
        'comboBoxStopBits
        '
        Me.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxStopBits.FormattingEnabled = True
        Me.comboBoxStopBits.Items.AddRange(New Object() {"None", "1 bit", "2 bit", "1.5 bit"})
        Me.comboBoxStopBits.Location = New System.Drawing.Point(58, 122)
        Me.comboBoxStopBits.Name = "comboBoxStopBits"
        Me.comboBoxStopBits.Size = New System.Drawing.Size(65, 21)
        Me.comboBoxStopBits.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Stop Bits"
        '
        'comboBoxDataBits
        '
        Me.comboBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxDataBits.FormattingEnabled = True
        Me.comboBoxDataBits.Items.AddRange(New Object() {"8", "7"})
        Me.comboBoxDataBits.Location = New System.Drawing.Point(58, 70)
        Me.comboBoxDataBits.Name = "comboBoxDataBits"
        Me.comboBoxDataBits.Size = New System.Drawing.Size(65, 21)
        Me.comboBoxDataBits.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Data Bits"
        '
        'comboBoxParity
        '
        Me.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxParity.FormattingEnabled = True
        Me.comboBoxParity.Items.AddRange(New Object() {"None", "Odd", "Even", "Mark", "Space"})
        Me.comboBoxParity.Location = New System.Drawing.Point(58, 96)
        Me.comboBoxParity.Name = "comboBoxParity"
        Me.comboBoxParity.Size = New System.Drawing.Size(65, 21)
        Me.comboBoxParity.TabIndex = 3
        '
        'labelParity
        '
        Me.labelParity.AutoSize = True
        Me.labelParity.Location = New System.Drawing.Point(22, 100)
        Me.labelParity.Name = "labelParity"
        Me.labelParity.Size = New System.Drawing.Size(33, 13)
        Me.labelParity.TabIndex = 22
        Me.labelParity.Text = "Parity"
        '
        'comboBoxBaudRate
        '
        Me.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxBaudRate.FormattingEnabled = True
        Me.comboBoxBaudRate.Items.AddRange(New Object() {"115200", "57600", "38400", "19200", "14400", "9600", "7200", "4800", "2400", "1800", "1200"})
        Me.comboBoxBaudRate.Location = New System.Drawing.Point(58, 44)
        Me.comboBoxBaudRate.Name = "comboBoxBaudRate"
        Me.comboBoxBaudRate.Size = New System.Drawing.Size(65, 21)
        Me.comboBoxBaudRate.TabIndex = 1
        '
        'comboBoxSerialPorts
        '
        Me.comboBoxSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxSerialPorts.FormattingEnabled = True
        Me.comboBoxSerialPorts.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15"})
        Me.comboBoxSerialPorts.Location = New System.Drawing.Point(58, 18)
        Me.comboBoxSerialPorts.Name = "comboBoxSerialPorts"
        Me.comboBoxSerialPorts.Size = New System.Drawing.Size(65, 21)
        Me.comboBoxSerialPorts.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(29, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Port"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Baud"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label18.Location = New System.Drawing.Point(1, 84)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 15)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Slave delay (ms)"
        '
        'textBoxSlaveDelay
        '
        Me.textBoxSlaveDelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textBoxSlaveDelay.Location = New System.Drawing.Point(96, 81)
        Me.textBoxSlaveDelay.Name = "textBoxSlaveDelay"
        Me.textBoxSlaveDelay.Size = New System.Drawing.Size(34, 21)
        Me.textBoxSlaveDelay.TabIndex = 13
        Me.textBoxSlaveDelay.Text = "1"
        Me.textBoxSlaveDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'groupBoxTCP
        '
        Me.groupBoxTCP.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.groupBoxTCP.Controls.Add(Me.txtPort)
        Me.groupBoxTCP.Controls.Add(Me.btnPING)
        Me.groupBoxTCP.Controls.Add(Me.Label1)
        Me.groupBoxTCP.Controls.Add(Me.txtIP)
        Me.groupBoxTCP.Controls.Add(Me.Label2)
        Me.groupBoxTCP.Location = New System.Drawing.Point(11, 268)
        Me.groupBoxTCP.Name = "groupBoxTCP"
        Me.groupBoxTCP.Size = New System.Drawing.Size(135, 73)
        Me.groupBoxTCP.TabIndex = 37
        Me.groupBoxTCP.TabStop = False
        Me.groupBoxTCP.Text = "TCP"
        '
        'btnPING
        '
        Me.btnPING.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnPING.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPING.Location = New System.Drawing.Point(83, 38)
        Me.btnPING.Name = "btnPING"
        Me.btnPING.Size = New System.Drawing.Size(47, 21)
        Me.btnPING.TabIndex = 94
        Me.btnPING.TabStop = False
        Me.btnPING.Text = " PING"
        Me.btnPING.UseVisualStyleBackColor = False
        '
        'lblStatus2
        '
        Me.lblStatus2.AutoSize = True
        Me.lblStatus2.BackColor = System.Drawing.SystemColors.Control
        Me.lblStatus2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblStatus2.ForeColor = System.Drawing.Color.Brown
        Me.lblStatus2.Location = New System.Drawing.Point(797, 437)
        Me.lblStatus2.Name = "lblStatus2"
        Me.lblStatus2.Size = New System.Drawing.Size(100, 15)
        Me.lblStatus2.TabIndex = 40
        Me.lblStatus2.Text = "Connection INFO"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(788, 264)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Data i godzina"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label20.Location = New System.Drawing.Point(10, 43)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 15)
        Me.Label20.TabIndex = 44
        Me.Label20.Text = "Timeout (ms)"
        '
        'txtTimeout
        '
        Me.txtTimeout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTimeout.Location = New System.Drawing.Point(96, 40)
        Me.txtTimeout.Name = "txtTimeout"
        Me.txtTimeout.Size = New System.Drawing.Size(34, 21)
        Me.txtTimeout.TabIndex = 11
        Me.txtTimeout.Text = "300"
        Me.txtTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 64)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 15)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Ilosc powtorzen"
        '
        'txtNoRetries
        '
        Me.txtNoRetries.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtNoRetries.Location = New System.Drawing.Point(96, 61)
        Me.txtNoRetries.Name = "txtNoRetries"
        Me.txtNoRetries.Size = New System.Drawing.Size(34, 21)
        Me.txtNoRetries.TabIndex = 12
        Me.txtNoRetries.Text = "2"
        Me.txtNoRetries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(788, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'lblComputerAddressIP
        '
        Me.lblComputerAddressIP.AutoSize = True
        Me.lblComputerAddressIP.Location = New System.Drawing.Point(788, 283)
        Me.lblComputerAddressIP.Name = "lblComputerAddressIP"
        Me.lblComputerAddressIP.Size = New System.Drawing.Size(100, 13)
        Me.lblComputerAddressIP.TabIndex = 53
        Me.lblComputerAddressIP.Text = "ComputerAddressIP"
        '
        'comboBoxMode
        '
        Me.comboBoxMode.BackColor = System.Drawing.SystemColors.Window
        Me.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.comboBoxMode.ForeColor = System.Drawing.Color.Black
        Me.comboBoxMode.FormattingEnabled = True
        Me.comboBoxMode.Items.AddRange(New Object() {"ASCII", "RTU", "TCP"})
        Me.comboBoxMode.Location = New System.Drawing.Point(9, 21)
        Me.comboBoxMode.Name = "comboBoxMode"
        Me.comboBoxMode.Size = New System.Drawing.Size(58, 24)
        Me.comboBoxMode.TabIndex = 28
        '
        'groupBoxMode
        '
        Me.groupBoxMode.BackColor = System.Drawing.SystemColors.Menu
        Me.groupBoxMode.Controls.Add(Me.comboBoxMode)
        Me.groupBoxMode.Location = New System.Drawing.Point(155, 196)
        Me.groupBoxMode.Name = "groupBoxMode"
        Me.groupBoxMode.Size = New System.Drawing.Size(76, 55)
        Me.groupBoxMode.TabIndex = 36
        Me.groupBoxMode.TabStop = False
        Me.groupBoxMode.Text = "Mode"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 118)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 27)
        Me.Button3.TabIndex = 202
        Me.Button3.Text = " Write 00-02 = 10"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btrReadCOM
        '
        Me.btrReadCOM.BackColor = System.Drawing.SystemColors.Control
        Me.btrReadCOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btrReadCOM.Location = New System.Drawing.Point(155, 104)
        Me.btrReadCOM.Name = "btrReadCOM"
        Me.btrReadCOM.Size = New System.Drawing.Size(76, 35)
        Me.btrReadCOM.TabIndex = 14
        Me.btrReadCOM.Text = "Read COM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dlugie"
        Me.ToolTip1.SetToolTip(Me.btrReadCOM, "Odczyt COM portow")
        Me.btrReadCOM.UseVisualStyleBackColor = False
        '
        'btnDeviceMenager
        '
        Me.btnDeviceMenager.Location = New System.Drawing.Point(6, 19)
        Me.btnDeviceMenager.Name = "btnDeviceMenager"
        Me.btnDeviceMenager.Size = New System.Drawing.Size(116, 27)
        Me.btnDeviceMenager.TabIndex = 56
        Me.btnDeviceMenager.Text = "DeviceMenager"
        Me.btnDeviceMenager.UseVisualStyleBackColor = True
        '
        'grpVFD_ME300
        '
        Me.grpVFD_ME300.BackColor = System.Drawing.SystemColors.Control
        Me.grpVFD_ME300.Controls.Add(Me.Label32)
        Me.grpVFD_ME300.Controls.Add(Me.Button4)
        Me.grpVFD_ME300.Controls.Add(Me.Label31)
        Me.grpVFD_ME300.Controls.Add(Me.Label30)
        Me.grpVFD_ME300.Controls.Add(Me.Button3)
        Me.grpVFD_ME300.Location = New System.Drawing.Point(654, 9)
        Me.grpVFD_ME300.Name = "grpVFD_ME300"
        Me.grpVFD_ME300.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpVFD_ME300.Size = New System.Drawing.Size(128, 203)
        Me.grpVFD_ME300.TabIndex = 57
        Me.grpVFD_ME300.TabStop = False
        Me.grpVFD_ME300.Text = "ME300 FW update"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(8, 165)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(113, 26)
        Me.Label32.TabIndex = 204
        Me.Label32.Text = "INFO:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bez przycisku connect"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 53)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 43)
        Me.Button4.TabIndex = 203
        Me.Button4.Text = "Write 09-01 = 38,4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Write 09-04 = 6"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(14, 20)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(100, 26)
        Me.Label31.TabIndex = 56
        Me.Label31.Text = "Ustaw ramkę " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(domyślnie 7N2 9.6)"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(30, 101)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(74, 13)
        Me.Label30.TabIndex = 53
        Me.Label30.Text = " FW UPDATE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(788, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Wersja v0.8"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Location = New System.Drawing.Point(797, 462)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(63, 28)
        Me.Button5.TabIndex = 59
        Me.Button5.TabStop = False
        Me.Button5.Text = " btn"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnNetworkConnection
        '
        Me.btnNetworkConnection.Location = New System.Drawing.Point(6, 49)
        Me.btnNetworkConnection.Name = "btnNetworkConnection"
        Me.btnNetworkConnection.Size = New System.Drawing.Size(116, 27)
        Me.btnNetworkConnection.TabIndex = 60
        Me.btnNetworkConnection.Text = "NetworkConnection"
        Me.btnNetworkConnection.UseVisualStyleBackColor = True
        '
        'txtboxREG10
        '
        Me.txtboxREG10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtboxREG10.Location = New System.Drawing.Point(104, 37)
        Me.txtboxREG10.MaxLength = 10
        Me.txtboxREG10.Name = "txtboxREG10"
        Me.txtboxREG10.Size = New System.Drawing.Size(65, 20)
        Me.txtboxREG10.TabIndex = 101
        Me.txtboxREG10.Text = "0"
        Me.txtboxREG10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(107, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 13)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Reg [DEC]"
        '
        'txtboxVAL10
        '
        Me.txtboxVAL10.Location = New System.Drawing.Point(174, 37)
        Me.txtboxVAL10.MaxLength = 10
        Me.txtboxVAL10.Name = "txtboxVAL10"
        Me.txtboxVAL10.Size = New System.Drawing.Size(65, 20)
        Me.txtboxVAL10.TabIndex = 61
        Me.txtboxVAL10.Text = "0"
        Me.txtboxVAL10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(183, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(95, 13)
        Me.Label26.TabIndex = 62
        Me.Label26.Text = " Value in Dec/Hex"
        '
        'btnReadRandom
        '
        Me.btnReadRandom.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReadRandom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReadRandom.Location = New System.Drawing.Point(173, 175)
        Me.btnReadRandom.Name = "btnReadRandom"
        Me.btnReadRandom.Size = New System.Drawing.Size(65, 30)
        Me.btnReadRandom.TabIndex = 14
        Me.btnReadRandom.Text = "Read"
        Me.btnReadRandom.UseVisualStyleBackColor = False
        '
        'txtboxOPIS10
        '
        Me.txtboxOPIS10.Location = New System.Drawing.Point(6, 37)
        Me.txtboxOPIS10.Name = "txtboxOPIS10"
        Me.txtboxOPIS10.Size = New System.Drawing.Size(95, 20)
        Me.txtboxOPIS10.TabIndex = 100
        Me.txtboxOPIS10.Text = "tekst"
        Me.txtboxOPIS10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(31, 18)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(35, 13)
        Me.Label28.TabIndex = 66
        Me.Label28.Text = " OPIS"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(31, 184)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(84, 13)
        Me.Label29.TabIndex = 67
        Me.Label29.Text = "Ilość do odczytu"
        '
        'txtboxOPIS11
        '
        Me.txtboxOPIS11.Location = New System.Drawing.Point(6, 65)
        Me.txtboxOPIS11.Name = "txtboxOPIS11"
        Me.txtboxOPIS11.Size = New System.Drawing.Size(95, 20)
        Me.txtboxOPIS11.TabIndex = 110
        Me.txtboxOPIS11.Text = "tekst"
        Me.txtboxOPIS11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxVAL11
        '
        Me.txtboxVAL11.Location = New System.Drawing.Point(174, 65)
        Me.txtboxVAL11.MaxLength = 10
        Me.txtboxVAL11.Name = "txtboxVAL11"
        Me.txtboxVAL11.Size = New System.Drawing.Size(65, 20)
        Me.txtboxVAL11.TabIndex = 71
        Me.txtboxVAL11.Text = "0"
        Me.txtboxVAL11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxREG11
        '
        Me.txtboxREG11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtboxREG11.Location = New System.Drawing.Point(104, 65)
        Me.txtboxREG11.MaxLength = 10
        Me.txtboxREG11.Name = "txtboxREG11"
        Me.txtboxREG11.Size = New System.Drawing.Size(65, 20)
        Me.txtboxREG11.TabIndex = 111
        Me.txtboxREG11.Text = "0"
        Me.txtboxREG11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxOPIS12
        '
        Me.txtboxOPIS12.Location = New System.Drawing.Point(6, 93)
        Me.txtboxOPIS12.Name = "txtboxOPIS12"
        Me.txtboxOPIS12.Size = New System.Drawing.Size(95, 20)
        Me.txtboxOPIS12.TabIndex = 120
        Me.txtboxOPIS12.Text = "tekst"
        Me.txtboxOPIS12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxVAL12
        '
        Me.txtboxVAL12.Location = New System.Drawing.Point(174, 93)
        Me.txtboxVAL12.MaxLength = 10
        Me.txtboxVAL12.Name = "txtboxVAL12"
        Me.txtboxVAL12.Size = New System.Drawing.Size(65, 20)
        Me.txtboxVAL12.TabIndex = 77
        Me.txtboxVAL12.Text = "0"
        Me.txtboxVAL12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxREG12
        '
        Me.txtboxREG12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtboxREG12.Location = New System.Drawing.Point(104, 93)
        Me.txtboxREG12.MaxLength = 10
        Me.txtboxREG12.Name = "txtboxREG12"
        Me.txtboxREG12.Size = New System.Drawing.Size(65, 20)
        Me.txtboxREG12.TabIndex = 121
        Me.txtboxREG12.Text = "0"
        Me.txtboxREG12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxOPIS13
        '
        Me.txtboxOPIS13.Location = New System.Drawing.Point(6, 121)
        Me.txtboxOPIS13.Name = "txtboxOPIS13"
        Me.txtboxOPIS13.Size = New System.Drawing.Size(95, 20)
        Me.txtboxOPIS13.TabIndex = 130
        Me.txtboxOPIS13.Text = "tekst"
        Me.txtboxOPIS13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxVAL13
        '
        Me.txtboxVAL13.Location = New System.Drawing.Point(174, 121)
        Me.txtboxVAL13.MaxLength = 10
        Me.txtboxVAL13.Name = "txtboxVAL13"
        Me.txtboxVAL13.Size = New System.Drawing.Size(65, 20)
        Me.txtboxVAL13.TabIndex = 83
        Me.txtboxVAL13.Text = "0"
        Me.txtboxVAL13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxREG13
        '
        Me.txtboxREG13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtboxREG13.Location = New System.Drawing.Point(104, 121)
        Me.txtboxREG13.MaxLength = 10
        Me.txtboxREG13.Name = "txtboxREG13"
        Me.txtboxREG13.Size = New System.Drawing.Size(65, 20)
        Me.txtboxREG13.TabIndex = 131
        Me.txtboxREG13.Text = "0"
        Me.txtboxREG13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpRead
        '
        Me.grpRead.BackColor = System.Drawing.SystemColors.Control
        Me.grpRead.Controls.Add(Me.btnWrite14)
        Me.grpRead.Controls.Add(Me.chbDecHex14)
        Me.grpRead.Controls.Add(Me.txtboxOPIS14)
        Me.grpRead.Controls.Add(Me.txtboxVAL14)
        Me.grpRead.Controls.Add(Me.txtboxREG14)
        Me.grpRead.Controls.Add(Me.btnWrite13)
        Me.grpRead.Controls.Add(Me.btnWrite12)
        Me.grpRead.Controls.Add(Me.btnWrite11)
        Me.grpRead.Controls.Add(Me.btnWrite10)
        Me.grpRead.Controls.Add(Me.chbDecHex13)
        Me.grpRead.Controls.Add(Me.chbDecHex12)
        Me.grpRead.Controls.Add(Me.chbDecHex11)
        Me.grpRead.Controls.Add(Me.chbDecHex10)
        Me.grpRead.Controls.Add(Me.txtboxILOSC)
        Me.grpRead.Controls.Add(Me.txtboxOPIS10)
        Me.grpRead.Controls.Add(Me.txtboxOPIS13)
        Me.grpRead.Controls.Add(Me.btnReadRandom)
        Me.grpRead.Controls.Add(Me.Label25)
        Me.grpRead.Controls.Add(Me.txtboxREG10)
        Me.grpRead.Controls.Add(Me.txtboxVAL10)
        Me.grpRead.Controls.Add(Me.Label26)
        Me.grpRead.Controls.Add(Me.txtboxVAL13)
        Me.grpRead.Controls.Add(Me.txtboxREG13)
        Me.grpRead.Controls.Add(Me.txtboxOPIS12)
        Me.grpRead.Controls.Add(Me.Label28)
        Me.grpRead.Controls.Add(Me.txtboxVAL12)
        Me.grpRead.Controls.Add(Me.txtboxREG11)
        Me.grpRead.Controls.Add(Me.txtboxREG12)
        Me.grpRead.Controls.Add(Me.Label29)
        Me.grpRead.Controls.Add(Me.txtboxVAL11)
        Me.grpRead.Controls.Add(Me.txtboxOPIS11)
        Me.grpRead.Enabled = False
        Me.grpRead.Location = New System.Drawing.Point(242, 12)
        Me.grpRead.Name = "grpRead"
        Me.grpRead.Size = New System.Drawing.Size(363, 213)
        Me.grpRead.TabIndex = 86
        Me.grpRead.TabStop = False
        Me.grpRead.Text = " Read/Write Register"
        '
        'btnWrite14
        '
        Me.btnWrite14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWrite14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWrite14.Location = New System.Drawing.Point(299, 148)
        Me.btnWrite14.Name = "btnWrite14"
        Me.btnWrite14.Size = New System.Drawing.Size(55, 23)
        Me.btnWrite14.TabIndex = 154
        Me.btnWrite14.Text = "Write"
        Me.btnWrite14.UseVisualStyleBackColor = False
        '
        'chbDecHex14
        '
        Me.chbDecHex14.AutoSize = True
        Me.chbDecHex14.Location = New System.Drawing.Point(245, 151)
        Me.chbDecHex14.Name = "chbDecHex14"
        Me.chbDecHex14.Size = New System.Drawing.Size(53, 17)
        Me.chbDecHex14.TabIndex = 142
        Me.chbDecHex14.Text = "DeHx"
        Me.chbDecHex14.UseVisualStyleBackColor = True
        '
        'txtboxOPIS14
        '
        Me.txtboxOPIS14.Location = New System.Drawing.Point(6, 149)
        Me.txtboxOPIS14.Name = "txtboxOPIS14"
        Me.txtboxOPIS14.Size = New System.Drawing.Size(95, 20)
        Me.txtboxOPIS14.TabIndex = 140
        Me.txtboxOPIS14.Text = "tekst"
        Me.txtboxOPIS14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxVAL14
        '
        Me.txtboxVAL14.Location = New System.Drawing.Point(174, 149)
        Me.txtboxVAL14.MaxLength = 10
        Me.txtboxVAL14.Name = "txtboxVAL14"
        Me.txtboxVAL14.Size = New System.Drawing.Size(65, 20)
        Me.txtboxVAL14.TabIndex = 99
        Me.txtboxVAL14.Text = "0"
        Me.txtboxVAL14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxREG14
        '
        Me.txtboxREG14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtboxREG14.Location = New System.Drawing.Point(104, 149)
        Me.txtboxREG14.MaxLength = 10
        Me.txtboxREG14.Name = "txtboxREG14"
        Me.txtboxREG14.Size = New System.Drawing.Size(65, 20)
        Me.txtboxREG14.TabIndex = 141
        Me.txtboxREG14.Text = "0"
        Me.txtboxREG14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnWrite13
        '
        Me.btnWrite13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWrite13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWrite13.Location = New System.Drawing.Point(299, 120)
        Me.btnWrite13.Name = "btnWrite13"
        Me.btnWrite13.Size = New System.Drawing.Size(55, 23)
        Me.btnWrite13.TabIndex = 153
        Me.btnWrite13.Text = "Write"
        Me.btnWrite13.UseVisualStyleBackColor = False
        '
        'btnWrite12
        '
        Me.btnWrite12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWrite12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWrite12.Location = New System.Drawing.Point(299, 92)
        Me.btnWrite12.Name = "btnWrite12"
        Me.btnWrite12.Size = New System.Drawing.Size(55, 23)
        Me.btnWrite12.TabIndex = 152
        Me.btnWrite12.Text = "Write"
        Me.btnWrite12.UseVisualStyleBackColor = False
        '
        'btnWrite11
        '
        Me.btnWrite11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWrite11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWrite11.Location = New System.Drawing.Point(299, 64)
        Me.btnWrite11.Name = "btnWrite11"
        Me.btnWrite11.Size = New System.Drawing.Size(55, 23)
        Me.btnWrite11.TabIndex = 151
        Me.btnWrite11.Text = "Write"
        Me.btnWrite11.UseVisualStyleBackColor = False
        '
        'btnWrite10
        '
        Me.btnWrite10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWrite10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWrite10.Location = New System.Drawing.Point(299, 36)
        Me.btnWrite10.Name = "btnWrite10"
        Me.btnWrite10.Size = New System.Drawing.Size(55, 23)
        Me.btnWrite10.TabIndex = 150
        Me.btnWrite10.Text = "Write"
        Me.btnWrite10.UseVisualStyleBackColor = False
        '
        'chbDecHex13
        '
        Me.chbDecHex13.AutoSize = True
        Me.chbDecHex13.Location = New System.Drawing.Point(245, 123)
        Me.chbDecHex13.Name = "chbDecHex13"
        Me.chbDecHex13.Size = New System.Drawing.Size(53, 17)
        Me.chbDecHex13.TabIndex = 132
        Me.chbDecHex13.Text = "DeHx"
        Me.chbDecHex13.UseVisualStyleBackColor = True
        '
        'chbDecHex12
        '
        Me.chbDecHex12.AutoSize = True
        Me.chbDecHex12.Location = New System.Drawing.Point(245, 95)
        Me.chbDecHex12.Name = "chbDecHex12"
        Me.chbDecHex12.Size = New System.Drawing.Size(53, 17)
        Me.chbDecHex12.TabIndex = 122
        Me.chbDecHex12.Text = "DeHx"
        Me.chbDecHex12.UseVisualStyleBackColor = True
        '
        'chbDecHex11
        '
        Me.chbDecHex11.AutoSize = True
        Me.chbDecHex11.Location = New System.Drawing.Point(245, 67)
        Me.chbDecHex11.Name = "chbDecHex11"
        Me.chbDecHex11.Size = New System.Drawing.Size(53, 17)
        Me.chbDecHex11.TabIndex = 112
        Me.chbDecHex11.Text = "DeHx"
        Me.chbDecHex11.UseVisualStyleBackColor = True
        '
        'chbDecHex10
        '
        Me.chbDecHex10.AutoSize = True
        Me.chbDecHex10.Location = New System.Drawing.Point(245, 39)
        Me.chbDecHex10.Name = "chbDecHex10"
        Me.chbDecHex10.Size = New System.Drawing.Size(53, 17)
        Me.chbDecHex10.TabIndex = 102
        Me.chbDecHex10.Text = "DeHx"
        Me.chbDecHex10.UseVisualStyleBackColor = True
        '
        'txtboxILOSC
        '
        Me.txtboxILOSC.Location = New System.Drawing.Point(121, 180)
        Me.txtboxILOSC.MaxLength = 3
        Me.txtboxILOSC.Name = "txtboxILOSC"
        Me.txtboxILOSC.Size = New System.Drawing.Size(40, 20)
        Me.txtboxILOSC.TabIndex = 86
        Me.txtboxILOSC.Text = "0"
        Me.txtboxILOSC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtboxILOSC, "zakres 0-5")
        '
        'btnCalculator
        '
        Me.btnCalculator.Location = New System.Drawing.Point(6, 79)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(116, 27)
        Me.btnCalculator.TabIndex = 87
        Me.btnCalculator.Text = "Caclulator"
        Me.btnCalculator.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.textBoxSlaveDelay)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtTimeout)
        Me.GroupBox1.Controls.Add(Me.txtNoRetries)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtStationID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 347)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 116)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Com.par"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(794, 392)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "- status timeout"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(788, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 13)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Wszystkie wartości 16 bit"
        '
        'lstCOM
        '
        Me.lstCOM.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lstCOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lstCOM.FormattingEnabled = True
        Me.lstCOM.Location = New System.Drawing.Point(12, 12)
        Me.lstCOM.Name = "lstCOM"
        Me.lstCOM.Size = New System.Drawing.Size(224, 82)
        Me.lstCOM.TabIndex = 92
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(193, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "COM99"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnDeviceMenager)
        Me.GroupBox2.Controls.Add(Me.btnNetworkConnection)
        Me.GroupBox2.Controls.Add(Me.btnCalculator)
        Me.GroupBox2.Location = New System.Drawing.Point(788, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(132, 152)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Skróty Windows"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 27)
        Me.Button1.TabIndex = 88
        Me.Button1.Text = "Command Line"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btrReadCOM2
        '
        Me.btrReadCOM2.BackColor = System.Drawing.SystemColors.Control
        Me.btrReadCOM2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btrReadCOM2.Location = New System.Drawing.Point(155, 145)
        Me.btrReadCOM2.Name = "btrReadCOM2"
        Me.btrReadCOM2.Size = New System.Drawing.Size(76, 35)
        Me.btrReadCOM2.TabIndex = 95
        Me.btrReadCOM2.Text = "Read COM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "krotkie"
        Me.ToolTip1.SetToolTip(Me.btrReadCOM2, "Odczyt COM portow")
        Me.btrReadCOM2.UseVisualStyleBackColor = False
        '
        'lblComputerNameIP
        '
        Me.lblComputerNameIP.AutoSize = True
        Me.lblComputerNameIP.Location = New System.Drawing.Point(788, 303)
        Me.lblComputerNameIP.Name = "lblComputerNameIP"
        Me.lblComputerNameIP.Size = New System.Drawing.Size(96, 13)
        Me.lblComputerNameIP.TabIndex = 96
        Me.lblComputerNameIP.Text = " Nazwa komputera"
        '
        'btnTEST
        '
        Me.btnTEST.BackColor = System.Drawing.Color.Transparent
        Me.btnTEST.Location = New System.Drawing.Point(868, 204)
        Me.btnTEST.Name = "btnTEST"
        Me.btnTEST.Size = New System.Drawing.Size(63, 21)
        Me.btnTEST.TabIndex = 97
        Me.btnTEST.TabStop = False
        Me.btnTEST.Text = " shell calc"
        Me.btnTEST.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 535)
        Me.Controls.Add(Me.btnTEST)
        Me.Controls.Add(Me.lblComputerNameIP)
        Me.Controls.Add(Me.btrReadCOM2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstCOM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpRead)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.grpVFD_ME300)
        Me.Controls.Add(Me.btrReadCOM)
        Me.Controls.Add(Me.lblComputerAddressIP)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.chbReadCyclic)
        Me.Controls.Add(Me.lblStatus2)
        Me.Controls.Add(Me.groupBoxTCP)
        Me.Controls.Add(Me.groupBoxMode)
        Me.Controls.Add(Me.groupBoxASCII_RTU)
        Me.Controls.Add(Me.grpRead2)
        Me.Controls.Add(Me.grpWrite)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modbus Read/Write"
        Me.grpWrite.ResumeLayout(False)
        Me.grpWrite.PerformLayout()
        Me.grpRead2.ResumeLayout(False)
        Me.grpRead2.PerformLayout()
        Me.GroupBoxViewType.ResumeLayout(False)
        Me.GroupBoxViewType.PerformLayout()
        Me.groupBoxASCII_RTU.ResumeLayout(False)
        Me.groupBoxASCII_RTU.PerformLayout()
        Me.groupBoxTCP.ResumeLayout(False)
        Me.groupBoxTCP.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxMode.ResumeLayout(False)
        Me.grpVFD_ME300.ResumeLayout(False)
        Me.grpVFD_ME300.PerformLayout()
        Me.grpRead.ResumeLayout(False)
        Me.grpRead.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents grpWrite As GroupBox
    Friend WithEvents btnWrite As Button
    Friend WithEvents txtWriteValue As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtWriteReg As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtStartReg2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLengthReg2 As TextBox
    Friend WithEvents btnRead2 As Button
    Friend WithEvents grpRead2 As GroupBox
    Friend WithEvents txtStationID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Timer1 As Timer
    Protected WithEvents groupBoxASCII_RTU As GroupBox
    Protected WithEvents comboBoxStopBits As ComboBox
    Protected WithEvents Label14 As Label
    Protected WithEvents comboBoxDataBits As ComboBox
    Protected WithEvents Label15 As Label
    Protected WithEvents comboBoxParity As ComboBox
    Protected WithEvents labelParity As Label
    Protected WithEvents comboBoxBaudRate As ComboBox
    Protected WithEvents comboBoxSerialPorts As ComboBox
    Protected WithEvents Label16 As Label
    Protected WithEvents Label17 As Label
    Protected WithEvents Label18 As Label
    Protected WithEvents textBoxSlaveDelay As TextBox
    Friend WithEvents groupBoxTCP As GroupBox
    Friend WithEvents lblStatus2 As Label
    Friend WithEvents chbReadCyclic As CheckBox
    Friend WithEvents Label19 As Label
    Protected WithEvents Label20 As Label
    Protected WithEvents txtTimeout As TextBox
    Protected WithEvents Label21 As Label
    Protected WithEvents txtNoRetries As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents txtStartReg2HEX As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label23 As Label
    Protected WithEvents RadioButtonHEX As RadioButton
    Protected WithEvents RadioButtonDEC As RadioButton
    Friend WithEvents GroupBoxViewType As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents lblComputerAddressIP As Label
    Protected WithEvents comboBoxMode As ComboBox
    Protected WithEvents groupBoxMode As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btrReadCOM As Button
    Friend WithEvents btnDeviceMenager As Button
    Friend WithEvents grpVFD_ME300 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents btnNetworkConnection As Button
    Friend WithEvents txtboxREG10 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtboxVAL10 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents btnReadRandom As Button
    Friend WithEvents txtboxOPIS10 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtboxOPIS11 As TextBox
    Friend WithEvents txtboxVAL11 As TextBox
    Friend WithEvents txtboxREG11 As TextBox
    Friend WithEvents txtboxOPIS12 As TextBox
    Friend WithEvents txtboxVAL12 As TextBox
    Friend WithEvents txtboxREG12 As TextBox
    Friend WithEvents txtboxOPIS13 As TextBox
    Friend WithEvents txtboxVAL13 As TextBox
    Friend WithEvents txtboxREG13 As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents grpRead As GroupBox
    Friend WithEvents btnCalculator As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtboxILOSC As TextBox
    Friend WithEvents chbDecHex10 As CheckBox
    Protected WithEvents RadioButtonCHAR As RadioButton
    Friend WithEvents chbDecHex13 As CheckBox
    Friend WithEvents chbDecHex12 As CheckBox
    Friend WithEvents chbDecHex11 As CheckBox
    Friend WithEvents btnWrite13 As Button
    Friend WithEvents btnWrite12 As Button
    Friend WithEvents btnWrite11 As Button
    Friend WithEvents btnWrite10 As Button
    Friend WithEvents btnWrite14 As Button
    Friend WithEvents chbDecHex14 As CheckBox
    Friend WithEvents txtboxOPIS14 As TextBox
    Friend WithEvents txtboxVAL14 As TextBox
    Friend WithEvents txtboxREG14 As TextBox
    Friend WithEvents chbDecHex As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lstCOM As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button4 As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents btnPING As Button
    Friend WithEvents btrReadCOM2 As Button
    Friend WithEvents lblComputerNameIP As Label
    Friend WithEvents btnTEST As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
