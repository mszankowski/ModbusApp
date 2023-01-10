Imports EasyModbus
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Modbus.Device      'for modbus master
Imports System.IO.Ports    'for controlling serial ports
Imports System.Management
Imports System.String
Imports System.Threading


Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' odczyt wartosci z pamieci
        txtIP.Text = My.Settings.AdresIP
        comboBoxSerialPorts.SelectedIndex = My.Settings.port2
        comboBoxBaudRate.SelectedIndex = My.Settings.baud2
        comboBoxParity.SelectedIndex = My.Settings.parity2
        comboBoxDataBits.SelectedIndex = My.Settings.DataBit2
        comboBoxStopBits.SelectedIndex = My.Settings.StopBit2
        comboBoxMode.SelectedIndex = My.Settings.groupBoxMode2
        txtboxREG10.Text = My.Settings.rejestr10
        txtboxREG11.Text = My.Settings.rejestr11
        txtboxREG12.Text = My.Settings.rejestr12
        txtboxREG13.Text = My.Settings.rejestr13
        txtboxREG14.Text = My.Settings.rejestr14
        txtboxILOSC.Text = My.Settings.iloscDoOdczytu
        txtboxOPIS10.Text = My.Settings.rejOpis10
        txtboxOPIS11.Text = My.Settings.rejOpis11
        txtboxOPIS12.Text = My.Settings.rejOpis12
        txtboxOPIS13.Text = My.Settings.rejOpis13
        txtboxOPIS14.Text = My.Settings.rejOpis14
        chbDecHex10.Checked = My.Settings.rejDecHex10
        chbDecHex11.Checked = My.Settings.rejDecHex11
        chbDecHex12.Checked = My.Settings.rejDecHex12
        chbDecHex13.Checked = My.Settings.rejDecHex13
        chbDecHex14.Checked = My.Settings.rejDecHex14

        ' okreslenie adresu IP aktualnego
        Try
            Dim strHostName As String
            Dim strIPAddress As String
            strHostName = System.Net.Dns.GetHostName()
            strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
            'strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()

            lblComputerAddressIP.Text = strIPAddress
            lblComputerNameIP.Text = strHostName
            'MessageBox.Show("Host Name: " & strHostName & "; IP Address: " & strIPAddress)
        Catch ex As Exception
            MessageBox.Show("bład odczytu adresu IP karty")
        End Try



        ' wyswietlenie poprawnego tekstu w check box
        Try
            If chbDecHex10.Checked = True Then
                chbDecHex10.Text = "HEX"
            Else chbDecHex10.Text = "DEC"
            End If

            If chbDecHex11.Checked = True Then
                chbDecHex11.Text = "HEX"
            Else chbDecHex11.Text = "DEC"
            End If

            If chbDecHex12.Checked = True Then
                chbDecHex12.Text = "HEX"
            Else chbDecHex12.Text = "DEC"
            End If

            If chbDecHex13.Checked = True Then
                chbDecHex13.Text = "HEX"
            Else chbDecHex13.Text = "DEC"
            End If

            If chbDecHex14.Checked = True Then
                chbDecHex14.Text = "HEX"
            Else chbDecHex14.Text = "DEC"
            End If

            If chbDecHex.Checked = True Then
                chbDecHex.Text = "HEX"
            Else chbDecHex.Text = "DEC"
            End If

        Catch ex As Exception
            MessageBox.Show("bład wyswietlania DEC/HEX")
        End Try

        Timer1.Interval = 500
        Timer1.Start() 'Timer starts functioning


        ' lista portow com -- ktotsza wersja
        lstCOM.Items.Clear()
        ' Show all available COM ports.
        For Each sp As String In My.Computer.Ports.SerialPortNames
            lstCOM.Items.Add(sp)
        Next



        ' wyswietlenie podpowiedzi - we wlasciwosciach elementu
        'ToolTip1.SetToolTip(btnConnect, "Kliknij zeby sie polaczyc")
        'ToolTip1.SetToolTip(btnDisconnect, "Kliknij zeby sie rozlaczyc")
        'ToolTip1.SetToolTip(txtStartReg2, "numer rejestru decymalnie")
        'ToolTip1.SetToolTip(txtStartReg2HEX, "numer rejestru hexadecymalnie")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'zapinie wartosci przy zamknieciu okna
        My.Settings.AdresIP = txtIP.Text
        My.Settings.port2 = comboBoxSerialPorts.SelectedIndex
        My.Settings.baud2 = comboBoxBaudRate.SelectedIndex
        My.Settings.parity2 = comboBoxParity.SelectedIndex
        My.Settings.DataBit2 = comboBoxDataBits.SelectedIndex
        My.Settings.StopBit2 = comboBoxStopBits.SelectedIndex
        My.Settings.groupBoxMode2 = comboBoxMode.SelectedIndex
        My.Settings.rejestr10 = txtboxREG10.Text
        My.Settings.rejestr11 = txtboxREG11.Text
        My.Settings.rejestr12 = txtboxREG12.Text
        My.Settings.rejestr13 = txtboxREG13.Text
        My.Settings.rejestr14 = txtboxREG14.Text
        My.Settings.iloscDoOdczytu = txtboxILOSC.Text
        My.Settings.rejOpis10 = txtboxOPIS10.Text
        My.Settings.rejOpis11 = txtboxOPIS11.Text
        My.Settings.rejOpis12 = txtboxOPIS12.Text
        My.Settings.rejOpis13 = txtboxOPIS13.Text
        My.Settings.rejOpis14 = txtboxOPIS14.Text
        My.Settings.rejDecHex10 = chbDecHex10.Checked
        My.Settings.rejDecHex11 = chbDecHex11.Checked
        My.Settings.rejDecHex12 = chbDecHex12.Checked
        My.Settings.rejDecHex13 = chbDecHex13.Checked
        My.Settings.rejDecHex14 = chbDecHex13.Checked
    End Sub


    Sub Connect_function()
        Try
            If comboBoxMode.Text = "ASCII" Or comboBoxMode.Text = "RTU" Then
                'get port properties
                serialPort.PortName = comboBoxSerialPorts.SelectedItem.ToString()
                serialPort.BaudRate = Integer.Parse(comboBoxBaudRate.SelectedItem.ToString())
                serialPort.DataBits = comboBoxDataBits.Text

                'get parity =None,Odd,Even,Mark,Space
                If comboBoxParity.SelectedIndex = 0 Then
                    serialPort.Parity = Parity.None
                ElseIf comboBoxParity.SelectedIndex = 1 Then
                    serialPort.Parity = Parity.Odd
                ElseIf comboBoxParity.SelectedIndex = 2 Then
                    serialPort.Parity = Parity.Even
                ElseIf comboBoxParity.SelectedIndex = 3 Then
                    serialPort.Parity = Parity.Mark
                Else
                    serialPort.Parity = Parity.Space
                End If

                'get stop bit
                If comboBoxStopBits.SelectedIndex = 0 Then
                    serialPort.StopBits = StopBits.None
                ElseIf comboBoxStopBits.SelectedIndex = 1 Then
                    serialPort.StopBits = StopBits.One
                ElseIf comboBoxStopBits.SelectedIndex = 2 Then
                    serialPort.StopBits = StopBits.Two
                Else
                    serialPort.StopBits = StopBits.OnePointFive
                End If

                serialPort.Open()

                If comboBoxMode.Text = "ASCII" Then
                    master = ModbusSerialMaster.CreateAscii(serialPort)
                ElseIf comboBoxMode.Text = "RTU" Then
                    master = ModbusSerialMaster.CreateRtu(serialPort)
                End If

                master.Transport.Retries = 0
                'master.Transport.ReadTimeout = 300  'millionsecs
                master.Transport.ReadTimeout = txtTimeout.Text
                If serialPort.IsOpen Then
                    lblStatus.Text = "Connected."
                    Console.WriteLine(DateTime.Now + "=>Open " + serialPort.PortName + " successfully.")
                End If

                groupBoxASCII_RTU.Enabled = False

            ElseIf comboBoxMode.Text = "TCP" Then
                ModClient.IPAddress = txtIP.Text
                ModClient.Port = txtPort.Text
                ModClient.UnitIdentifier = txtStationID.Text
                ModClient.ConnectionTimeout = txtTimeout.Text
                ModClient.NumberOfRetries = txtNoRetries.Text
                ModClient.Connect()
                If ModClient.Connected Then
                    lblStatus.Text = "Connected."
                    groupBoxTCP.Enabled = False
                End If
            End If

            btnConnect.Enabled = False
            btnDisconnect.Enabled = True
            grpRead.Enabled = True
            grpRead2.Enabled = True
            grpWrite.Enabled = True
            groupBoxMode.Enabled = False
            txtStationID.Enabled = False
            'grpVFD_ME300.Enabled = True
            'btnConnect.BackColor = Color.Transparent
            'btnDisconnect.BackColor = Color.FromArgb(225, 179, 186)
        Catch ex As Exception
            MsgBox("Error Connection open! " + vbNewLine + ex.Message)
        End Try

    End Sub
    Sub Disconnect_function()
        Try
            If comboBoxMode.Text = "ASCII" Or comboBoxMode.Text = "RTU" Then
                serialPort.Close()
                lblStatus.Text = "Disconnected ASCII/RTU."
                groupBoxASCII_RTU.Enabled = True
            ElseIf comboBoxMode.Text = "TCP" Then
                ModClient.Disconnect()
                lblStatus.Text = "Disconnected TCP."
                groupBoxTCP.Enabled = True
            End If

            btnConnect.Enabled = True
            btnDisconnect.Enabled = False
            grpRead.Enabled = False
            grpRead2.Enabled = False
            grpWrite.Enabled = False
            groupBoxMode.Enabled = True
            txtStationID.Enabled = True
            'grpVFD_ME300.Enabled = False
            'btnConnect.BackColor = Color.FromArgb(186, 255, 201)
            'btnDisconnect.BackColor = Color.Transparent

        Catch ex As Exception
            MsgBox("Error Connection close! " + vbNewLine + vbNewLine + ex.Message)
        End Try
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'skrot klawiszowy C
        'If e.KeyCode = Keys.C Then
        'Connect_function()
        'End If
        'If e.KeyCode = Keys.D Then
        'Disconnect_function()
        'End If
    End Sub











    Dim ModClient As New ModbusClient
    Dim ModClient2 As New ModbusClient
    Private serialPort As New SerialPort()   'declare object and create a new SerialPort object with default settings.
    Private master As ModbusSerialMaster

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Connect_function()
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        Disconnect_function()
    End Sub



    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Try
            Dim ValueToWrite As Int16
            If chbDecHex.Checked = False Then
                ValueToWrite = txtWriteValue.Text
            ElseIf chbDecHex.Checked = True Then
                ValueToWrite = Convert.ToInt32(txtWriteValue.Text, 16)
            End If


            If comboBoxMode.Text = "ASCII" Or comboBoxMode.Text = "RTU" Then
                master.WriteSingleRegister(txtStationID.Text, txtWriteReg.Text, ValueToWrite)
            ElseIf comboBoxMode.Text = "TCP" Then
                ModClient.WriteSingleRegister(txtWriteReg.Text, ValueToWrite)
            End If

        Catch ex As Exception
            MsgBox("Error Connection Write! " + vbNewLine + vbNewLine + ex.Message)
        End Try
    End Sub

    Private Sub btnRead2_Click(sender As Object, e As EventArgs) Handles btnRead2.Click
        Dim RegVals2 As Integer()
        Dim value2 As String = 0
        Dim holding_register As UShort()
        Dim nr_rejestr_odczytany As Integer

        'elementy do listy
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True
        Dim arr(2) As String
        Dim item1 As ListViewItem
        nr_rejestr_odczytany = txtStartReg2.Text

        Try

            If comboBoxMode.Text = "ASCII" Or comboBoxMode.Text = "RTU" Then
                holding_register = master.ReadHoldingRegisters(txtStationID.Text, txtStartReg2.Text, txtLengthReg2.Text)
                If holding_register.Length > 0 Then
                    ListView1.Items.Clear()

                    For Each value As UShort In holding_register

                        If RadioButtonDEC.Checked = True Then
                            value2 = value
                        ElseIf RadioButtonHEX.Checked = True Then
                            value2 = Hex(value)
                        ElseIf RadioButtonCHAR.Checked = True Then
                            'value2 = AscW(value)
                            value2 = ChrW(value)
                            value2 = value
                        End If

                        arr(0) = nr_rejestr_odczytany
                        arr(1) = value2
                        item1 = New ListViewItem(arr)
                        ListView1.Items.Add(item1)
                        nr_rejestr_odczytany = nr_rejestr_odczytany + 1

                    Next
                End If

            ElseIf comboBoxMode.Text = "TCP" Then
                RegVals2 = ModClient.ReadHoldingRegisters(txtStartReg2.Text, txtLengthReg2.Text)
                If RegVals2.Length > 0 Then
                    ListView1.Items.Clear()
                    For Each value As Integer In RegVals2
                        If RadioButtonDEC.Checked = True Then
                            value2 = value
                        ElseIf RadioButtonHEX.Checked = True Then
                            value2 = Hex(value)
                        ElseIf RadioButtonCHAR.Checked = True Then
                            'value2 = AscW(value)
                            'value2 = ChrW(value)
                            value2 = value
                        End If

                        arr(0) = nr_rejestr_odczytany
                        arr(1) = value2
                        item1 = New ListViewItem(arr)
                        ListView1.Items.Add(item1)
                        nr_rejestr_odczytany = nr_rejestr_odczytany + 1

                    Next
                End If
            End If


        Catch ex As Exception
            MsgBox("Error Connection Odczyt! " + vbNewLine + vbNewLine + ex.Message)
        End Try
    End Sub



    Dim second As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label19.Text = DateTime.Now.ToString

        Dim StatusPolaczenia As String
        Dim licznik2 As Integer





        If chbReadCyclic.Checked = True Then

            StatusPolaczenia = ModClient.Available(txtTimeout.Text)
            If StatusPolaczenia = False Then
                lblStatus2.Text = "brak polaczenia"
            Else
                lblStatus2.Text = "polaczenie OK"
            End If

            Dim RegVals2 As Integer()
            Dim value2 As String = 0

            Try
                RegVals2 = ModClient.ReadHoldingRegisters(txtStartReg2.Text, txtLengthReg2.Text)
                If RegVals2.Length > 0 Then
                    ListView1.Items.Clear()
                    licznik2 = 0
                    For Each value As Integer In RegVals2
                        If RadioButtonDEC.Checked = True Then
                            value2 = value
                        ElseIf RadioButtonHEX.Checked = True Then
                            value2 = Hex(value)
                        ElseIf RadioButtonCHAR.Checked = True Then
                            'value2 = AscW(value)
                            'value2 = ChrW(value)
                            'value2 = ConvertRegistersToString(value)
                            value2 = value
                        End If

                        ListView1.Items.Add(licznik2)
                        ListView1.Items(licznik2).SubItems.Add(value)
                        licznik2 = licznik2 + 1
                    Next
                End If

            Catch ex As Exception
                lblStatus.Text = "Error Read!"
            End Try
        End If

        'second = second + 1
        If second >= 10 Then
            Timer1.Stop() 'Timer stops functioning
            MsgBox("Timer Stopped....")
        End If

    End Sub

    Private Sub txtStartReg2HEX_TextChanged(sender As Object, e As EventArgs) Handles txtStartReg2HEX.TextChanged
        Try
            If txtStartReg2HEX.Text <> "" Then
                txtStartReg2.Text = CInt("&H" & txtStartReg2HEX.Text)
            End If
        Catch ex As Exception
            'txtStartReg2HEX.Text = "0"
            MsgBox("Enter correct number in HEX" + vbNewLine + ex.Message)
        End Try
    End Sub

    Private Sub txtStartReg2_TextChanged(sender As Object, e As EventArgs) Handles txtStartReg2.TextChanged
        'txtStartReg2HEX.Text = Hex(txtStartReg2.Text)
        Try
            If txtStartReg2.Text <> "" Then
                txtStartReg2HEX.Text = Hex(txtStartReg2.Text)
            End If
        Catch ex As Exception
            txtStartReg2HEX.Text = "0"
            MsgBox("Enter correct number in DEC" + vbNewLine + ex.Message)
        End Try
    End Sub

    Private Sub comboBoxMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxMode.SelectedIndexChanged
        If comboBoxMode.Text = "ASCII" Or comboBoxMode.Text = "RTU" Then
            groupBoxASCII_RTU.Enabled = True
            groupBoxTCP.Enabled = False
            lstCOM.Enabled = True
            btrReadCOM.Enabled = True
            btrReadCOM2.Enabled = True
        ElseIf comboBoxMode.Text = "TCP" Then
            groupBoxASCII_RTU.Enabled = False
            groupBoxTCP.Enabled = True
            lstCOM.Enabled = False
            btrReadCOM.Enabled = False
            btrReadCOM2.Enabled = False
        End If
        'btnConnect.Enabled = False
    End Sub


    ''UPDATE ME300
    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            Connect_function()
            master.WriteSingleRegister(txtStationID.Text, 2305, 384)
            Disconnect_function()
            serialPort.Close()
            lblStatus.Text = "Disconnected."
            groupBoxASCII_RTU.Enabled = True
            btnConnect.Enabled = True
            btnDisconnect.Enabled = False
            grpRead.Enabled = False
            grpRead2.Enabled = False
            grpWrite.Enabled = False
            groupBoxMode.Enabled = True
            txtStationID.Enabled = True
            comboBoxBaudRate.SelectedIndex = 2 '38,400
            MsgBox("zapis 09-01 = 38,400 -- OK")
        Catch ex As Exception
            MsgBox("Error" & vbCrLf & " zapisu 09-01 = 38,400")
        End Try

        Thread.Sleep(300)
        Connect_function()
        Try
            master.WriteSingleRegister(txtStationID.Text, 2308, 6)
            serialPort.Close()
            lblStatus.Text = "Disconnected."
            groupBoxASCII_RTU.Enabled = True
            btnConnect.Enabled = True
            btnDisconnect.Enabled = False
            grpRead.Enabled = False
            grpRead2.Enabled = False
            grpWrite.Enabled = False
            groupBoxMode.Enabled = True
            txtStationID.Enabled = True
            comboBoxBaudRate.SelectedIndex = 2 '38,400
            comboBoxParity.SelectedIndex = 0 'none
            comboBoxDataBits.SelectedIndex = 0 '8

            MsgBox("Zapis 09-04 = 6 (8N1 ascii) -- OK")
        Catch ex As Exception
            MsgBox("Error " & vbCrLf & " zapisu 09-04 = 6 (8N1 ascii)")
        End Try
    End Sub
    'format 00-02 = 10
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Connect_function()
            master.WriteSingleRegister(txtStationID.Text, 2, 10)
            serialPort.Close()
            lblStatus.Text = "Disconnected."
            groupBoxASCII_RTU.Enabled = True
            btnConnect.Enabled = True
            btnDisconnect.Enabled = False
            grpRead.Enabled = False
            grpRead2.Enabled = False
            grpWrite.Enabled = False
            groupBoxMode.Enabled = True
            txtStationID.Enabled = True
            comboBoxBaudRate.SelectedIndex = 5 '9,600
            comboBoxParity.SelectedIndex = 0 'none
            comboBoxDataBits.SelectedIndex = 1 '7

            MsgBox("Zapis 00-02 = 10 foramt -- OK")
        Catch ex As Exception
            MsgBox("ERROR " & vbCrLf & "zapisu 00-02 = 10 (format)")
        End Try
    End Sub



    'Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String,
    'ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
    'Private Const SW_SHOWNORMAL As Long = 1

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btrReadCOM.Click
        ' Show all available COM ports.
        'lstCOM.Items.Clear()
        'For Each sp As String In My.Computer.Ports.SerialPortNames
        'lstCOM.Items.Add(sp)
        'Next
        lstCOM.Items.Clear()
        lstCOM.Items.Add("TRWA ODCZYT...")
        MsgBox("TRWA ODCZYT..." & vbCrLf & "test nowej linii")

        Try
            Dim searcher As New ManagementObjectSearcher("root\cimv2", "SELECT * FROM Win32_SerialPort")
            lstCOM.Items.Clear()
            For Each queryObj As ManagementObject In searcher.Get()
                lstCOM.Items.Add(queryObj("Name"))
                'MsgBox(queryObj("Name"))
            Next

        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btrReadCOM2.Click
        ' Show all available COM ports.
        lstCOM.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            lstCOM.Items.Add(sp)
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnDeviceMenager.Click
        'uruchominie menadzera urzadzen
        Process.Start("devmgmt.msc")
    End Sub

    Private Sub btnNetworkConnection_Click(sender As Object, e As EventArgs) Handles btnNetworkConnection.Click
        'uruchomienie polaczen sieciowych
        Process.Start("ncpa.cpl")
    End Sub
    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        'uruchomienie kalkulatora
        Process.Start("calc.exe")
    End Sub



    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        If lstCOM.SelectedItem <> "" Then
            comboBoxSerialPorts.Text = lstCOM.SelectedItem
        End If
    End Sub





    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
    End Sub




    Private Sub btnReadRandomE_Click(sender As Object, e As EventArgs) Handles btnReadRandom.Click
        Dim RegVals2 As Integer()
        Dim value2 As String = 0
        Dim holding_register As UShort()
        'Dim nazwa_rejestru_odczytywanego As String
        Try
            ' element REG0
            If txtboxILOSC.Text >= 1 Then
                If comboBoxMode.Text = "ASCII" Or comboBoxMode.Text = "RTU" Then
                    holding_register = master.ReadHoldingRegisters(txtStationID.Text, txtboxREG10.Text, 1)
                    If holding_register.Length > 0 Then
                        For Each value As UShort In holding_register
                            If chbDecHex10.Checked = False Then
                                value2 = value
                            ElseIf chbDecHex10.Checked = True Then
                                value2 = Hex(value)
                            End If
                            txtboxVAL10.Text = value2
                        Next
                    End If
                ElseIf comboBoxMode.Text = "TCP" Then
                    RegVals2 = ModClient.ReadHoldingRegisters(txtboxREG10.Text, 1)
                    If RegVals2.Length > 0 Then
                        For Each value As Integer In RegVals2
                            If chbDecHex10.Checked = False Then
                                value2 = value
                            ElseIf chbDecHex10.Checked = True Then
                                value2 = Hex(value)
                            End If
                            txtboxVAL10.Text = value2
                        Next
                    End If
                End If
            End If

            ' element REG11
            If txtboxILOSC.Text >= 2 Then
                If comboBoxMode.Text = "ASCII" Or comboBoxMode.Text = "RTU" Then
                    holding_register = master.ReadHoldingRegisters(txtStationID.Text, txtboxREG11.Text, 1)
                    If holding_register.Length > 0 Then
                        For Each value As UShort In holding_register
                            If chbDecHex11.Checked = False Then
                                value2 = value
                            ElseIf chbDecHex11.Checked = True Then
                                value2 = Hex(value)
                            End If
                            txtboxVAL11.Text = value2
                        Next
                    End If
                ElseIf comboBoxMode.Text = "TCP" Then
                    RegVals2 = ModClient.ReadHoldingRegisters(txtboxREG11.Text, 1)
                    If RegVals2.Length > 0 Then
                        For Each value As Integer In RegVals2
                            If chbDecHex11.Checked = False Then
                                value2 = value
                            ElseIf chbDecHex11.Checked = True Then
                                value2 = Hex(value)
                            End If
                            txtboxVAL11.Text = value2
                        Next
                    End If
                End If
            End If

            ' element reg12
            If txtboxILOSC.Text >= 3 Then
                If comboBoxMode.Text = "ASCII" Or comboBoxMode.Text = "RTU" Then
                    holding_register = master.ReadHoldingRegisters(txtStationID.Text, txtboxREG12.Text, 1)
                    If holding_register.Length > 0 Then
                        For Each value As UShort In holding_register
                            If chbDecHex12.Checked = False Then
                                value2 = value
                            ElseIf chbDecHex12.Checked = True Then
                                value2 = Hex(value)
                            End If
                            txtboxVAL12.Text = value2
                        Next
                    End If
                ElseIf comboBoxMode.Text = "TCP" Then
                    RegVals2 = ModClient.ReadHoldingRegisters(txtboxREG12.Text, 1)
                    If RegVals2.Length > 0 Then
                        For Each value As Integer In RegVals2
                            If chbDecHex12.Checked = False Then
                                value2 = value
                            ElseIf chbDecHex12.Checked = True Then
                                value2 = Hex(value)
                            End If
                            txtboxVAL12.Text = value2
                        Next
                    End If
                End If
            End If


            ' element reg13
            If txtboxILOSC.Text >= 4 Then
                If comboBoxMode.Text = "ASCII" Or comboBoxMode.Text = "RTU" Then
                    holding_register = master.ReadHoldingRegisters(txtStationID.Text, txtboxREG13.Text, 1)
                    If holding_register.Length > 0 Then
                        For Each value As UShort In holding_register
                            If chbDecHex13.Checked = False Then
                                value2 = value
                            ElseIf chbDecHex13.Checked = True Then
                                value2 = Hex(value)
                            End If
                            txtboxVAL13.Text = value2
                        Next
                    End If
                ElseIf comboBoxMode.Text = "TCP" Then
                    RegVals2 = ModClient.ReadHoldingRegisters(txtboxREG13.Text, 1)
                    If RegVals2.Length > 0 Then
                        For Each value As Integer In RegVals2
                            If chbDecHex13.Checked = False Then
                                value2 = value
                            ElseIf chbDecHex13.Checked = True Then
                                value2 = Hex(value)
                            End If
                            txtboxVAL13.Text = value2
                        Next
                    End If
                End If
            End If

            ' element reg14
            If txtboxILOSC.Text >= 5 Then
                If comboBoxMode.Text = "ASCII" Or comboBoxMode.Text = "RTU" Then
                    holding_register = master.ReadHoldingRegisters(txtStationID.Text, txtboxREG14.Text, 1)
                    If holding_register.Length > 0 Then
                        For Each value As UShort In holding_register
                            If chbDecHex14.Checked = False Then
                                value2 = value
                            ElseIf chbDecHex14.Checked = True Then
                                value2 = Hex(value)
                            End If
                            txtboxVAL14.Text = value2
                        Next
                    End If
                ElseIf comboBoxMode.Text = "TCP" Then
                    RegVals2 = ModClient.ReadHoldingRegisters(txtboxREG14.Text, 1)
                    If RegVals2.Length > 0 Then
                        For Each value As Integer In RegVals2
                            If chbDecHex14.Checked = False Then
                                value2 = value
                            ElseIf chbDecHex14.Checked = True Then
                                value2 = Hex(value)
                            End If
                            txtboxVAL14.Text = value2
                        Next
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Error Connection Odczyt! " + vbNewLine + ex.Message)
        End Try

    End Sub

    '' ------------- przyciski WRITE
    Private Sub btnWrite10_Click(sender As Object, e As EventArgs) Handles btnWrite10.Click
        Try
            Dim ValueToWrite As Int16
            If chbDecHex10.Checked = False Then
                ValueToWrite = txtboxVAL10.Text
            ElseIf chbDecHex10.Checked = True Then
                ValueToWrite = Convert.ToInt32(txtboxVAL10.Text, 16)
            End If

            If comboBoxMode.Text = "ASCII" Or comboBoxMode.Text = "RTU" Then
                master.WriteSingleRegister(txtStationID.Text, txtboxREG10.Text, ValueToWrite)
            ElseIf comboBoxMode.Text = "TCP" Then
                ModClient.WriteSingleRegister(txtboxREG10.Text, ValueToWrite)
            End If
        Catch ex As Exception
            MsgBox("Error Connection Write! " + vbNewLine + ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles btnWrite11.Click
        Try
            Dim ValueToWrite As Int16
            If chbDecHex11.Checked = False Then
                ValueToWrite = txtboxVAL11.Text
            ElseIf chbDecHex11.Checked = True Then
                ValueToWrite = Convert.ToInt32(txtboxVAL11.Text, 16)
            End If

            If comboBoxMode.Text = "ASCII" Or comboBoxMode.Text = "RTU" Then
                master.WriteSingleRegister(txtStationID.Text, txtboxREG11.Text, ValueToWrite)
            ElseIf comboBoxMode.Text = "TCP" Then
                ModClient.WriteSingleRegister(txtboxREG11.Text, ValueToWrite)
            End If
        Catch ex As Exception
            MsgBox("Error Connection Write! " + vbNewLine + ex.Message)
        End Try
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnWrite12.Click
        Try
            Dim ValueToWrite As Int16
            If chbDecHex12.Checked = False Then
                ValueToWrite = txtboxVAL12.Text
            ElseIf chbDecHex12.Checked = True Then
                ValueToWrite = Convert.ToInt32(txtboxVAL12.Text, 16)
            End If

            If comboBoxMode.Text = "ASCII" Or comboBoxMode.Text = "RTU" Then
                master.WriteSingleRegister(txtStationID.Text, txtboxREG12.Text, ValueToWrite)
            ElseIf comboBoxMode.Text = "TCP" Then
                ModClient.WriteSingleRegister(txtboxREG12.Text, ValueToWrite)
            End If
        Catch ex As Exception
            MsgBox("Error Connection Write! " + vbNewLine + ex.Message)
        End Try
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnWrite13.Click
        Try
            Dim ValueToWrite As Int16
            If chbDecHex13.Checked = False Then
                ValueToWrite = txtboxVAL13.Text
            ElseIf chbDecHex13.Checked = True Then
                ValueToWrite = Convert.ToInt32(txtboxVAL13.Text, 16)
            End If

            If comboBoxMode.Text = "ASCII" Or comboBoxMode.Text = "RTU" Then
                master.WriteSingleRegister(txtStationID.Text, txtboxREG13.Text, ValueToWrite)
            ElseIf comboBoxMode.Text = "TCP" Then
                ModClient.WriteSingleRegister(txtboxREG13.Text, ValueToWrite)
            End If
        Catch ex As Exception
            MsgBox("Error Connection Write! " + vbNewLine + ex.Message)
        End Try
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnWrite14.Click
        Try
            Dim ValueToWrite As Int16
            If chbDecHex14.Checked = False Then
                ValueToWrite = txtboxVAL14.Text
            ElseIf chbDecHex14.Checked = True Then
                ValueToWrite = Convert.ToInt32(txtboxVAL14.Text, 16)
            End If

            If comboBoxMode.Text = "ASCII" Or comboBoxMode.Text = "RTU" Then
                master.WriteSingleRegister(txtStationID.Text, txtboxREG14.Text, ValueToWrite)
            ElseIf comboBoxMode.Text = "TCP" Then
                ModClient.WriteSingleRegister(txtboxREG14.Text, ValueToWrite)
            End If
        Catch ex As Exception
            MsgBox("Error Connection Write! " + vbNewLine + ex.Message)
        End Try
    End Sub


    '' ------------- pola check box
    Private Sub chbDecHex10_CheckedChanged(sender As Object, e As EventArgs) Handles chbDecHex10.CheckedChanged
        If chbDecHex10.Checked = True Then
            chbDecHex10.Text = "HEX"
        Else chbDecHex10.Text = "DEC"
        End If
    End Sub

    Private Sub chbDecHex11_CheckedChanged(sender As Object, e As EventArgs) Handles chbDecHex11.CheckedChanged
        If chbDecHex11.Checked = True Then
            chbDecHex11.Text = "HEX"
        Else chbDecHex11.Text = "DEC"
        End If
    End Sub

    Private Sub chbDecHex12_CheckedChanged(sender As Object, e As EventArgs) Handles chbDecHex12.CheckedChanged
        If chbDecHex12.Checked = True Then
            chbDecHex12.Text = "HEX"
        Else chbDecHex12.Text = "DEC"
        End If
    End Sub

    Private Sub chbDecHex13_CheckedChanged(sender As Object, e As EventArgs) Handles chbDecHex13.CheckedChanged
        If chbDecHex13.Checked = True Then
            chbDecHex13.Text = "HEX"
        Else chbDecHex13.Text = "DEC"
        End If
    End Sub
    Private Sub chbDecHex14_CheckedChanged(sender As Object, e As EventArgs) Handles chbDecHex14.CheckedChanged
        If chbDecHex14.Checked = True Then
            chbDecHex14.Text = "HEX"
        Else chbDecHex14.Text = "DEC"
        End If
    End Sub

    Private Sub txtboxILOSC_TextChanged(sender As Object, e As EventArgs) Handles txtboxILOSC.TextChanged
        Try
            If txtboxILOSC.Text >= 0 And txtboxILOSC.Text <6 Then
                If txtboxILOSC.Text >= 5 Then
                    txtboxOPIS10.BackColor = Color.FromArgb(225, 245, 255)
                    txtboxOPIS11.BackColor = Color.FromArgb(225, 245, 255)
                    txtboxOPIS12.BackColor = Color.FromArgb(225, 245, 255)
                    txtboxOPIS13.BackColor = Color.FromArgb(225, 245, 255)
                    txtboxOPIS14.BackColor = Color.FromArgb(225, 245, 255)
                ElseIf txtboxILOSC.Text >= 4 Then
                    txtboxOPIS10.BackColor = Color.FromArgb(225, 245, 255)
                    txtboxOPIS11.BackColor = Color.FromArgb(225, 245, 255)
                    txtboxOPIS12.BackColor = Color.FromArgb(225, 245, 255)
                    txtboxOPIS13.BackColor = Color.FromArgb(225, 245, 255)
                    txtboxOPIS14.BackColor = Color.White
                ElseIf txtboxILOSC.Text >= 3 Then
                    txtboxOPIS10.BackColor = Color.FromArgb(225, 245, 255)
                    txtboxOPIS11.BackColor = Color.FromArgb(225, 245, 255)
                    txtboxOPIS12.BackColor = Color.FromArgb(225, 245, 255)
                    txtboxOPIS13.BackColor = Color.White
                    txtboxOPIS14.BackColor = Color.White
                ElseIf txtboxILOSC.Text >= 2 Then
                    txtboxOPIS10.BackColor = Color.FromArgb(225, 245, 255)
                    txtboxOPIS11.BackColor = Color.FromArgb(225, 245, 255)
                    txtboxOPIS12.BackColor = Color.White
                    txtboxOPIS13.BackColor = Color.White
                    txtboxOPIS14.BackColor = Color.White
                ElseIf txtboxILOSC.Text >= 1 Then
                    txtboxOPIS10.BackColor = Color.FromArgb(225, 245, 255)
                    txtboxOPIS11.BackColor = Color.White
                    txtboxOPIS12.BackColor = Color.White
                    txtboxOPIS13.BackColor = Color.White
                    txtboxOPIS14.BackColor = Color.White
                Else
                    txtboxOPIS10.BackColor = Color.White
                    txtboxOPIS11.BackColor = Color.White
                    txtboxOPIS12.BackColor = Color.White
                    txtboxOPIS13.BackColor = Color.White
                    txtboxOPIS14.BackColor = Color.White

                End If
            ElseIf txtboxILOSC.Text < 0 Then
                txtboxILOSC.Text = 0
            ElseIf txtboxILOSC.Text > 5 Then
                txtboxILOSC.Text = 5
            End If
        Catch ex As Exception
            MsgBox("Wporadź poprawną wartość" + txtboxOPIS13.Text)
        End Try

    End Sub

    Private Sub chbDecHex_CheckedChanged(sender As Object, e As EventArgs) Handles chbDecHex.CheckedChanged
        If chbDecHex.Checked = True Then
            chbDecHex.Text = "HEX"
        Else chbDecHex.Text = "DEC"
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstCOM.SelectedIndexChanged
        If lstCOM.SelectedItem <> "" Then
            Dim zmienna11 As String
            zmienna11 = lstCOM.SelectedItem
            Dim testLen As Integer = Len(zmienna11)
            If testLen > 5 Then
                Label6.Text = LTrim(Mid(zmienna11, testLen - 4, 4))
                comboBoxSerialPorts.Text = LTrim(Mid(zmienna11, testLen - 4, 4))
            Else
                comboBoxSerialPorts.Text = zmienna11
                Label6.Text = zmienna11
            End If
        End If
    End Sub

    Private Sub btnPING_Click(sender As Object, e As EventArgs) Handles btnPING.Click
        Try
            If My.Computer.Network.Ping(txtIP.Text, txtTimeout.Text) Then
                'lblIPping.Text = "Connection ok"
                MsgBox("Connection ok")
            Else
                'lblIPping.Text = "No connection"
                MsgBox("No Connection" & vbCrLf & "test nowej linii")
            End If
        Catch ex As Exception
            MsgBox("Błąd PING sprawdz adres IP")
        End Try
    End Sub

    Private Sub btnTEST_Click(sender As Object, e As EventArgs) Handles btnTEST.Click
        Dim procID As Integer
        ' Run calculator.
        procID = Shell("C:\Windows\system32\calc.exe", AppWinStyle.NormalFocus)
        ' The preceding path is for Windows XP.
        ' The Windows 2000 path is C:\WINNT\system32\calc.exe.



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim psi As New ProcessStartInfo()
        'psi.Verb = "runas" ' aka run as administrator
        psi.FileName = "cmd.exe"
        'psi.Arguments = "/c " & TextBox1.Text & TextBox2.Text ' <- pass arguments for the command you want to run

        Try
            Process.Start(psi) ' <- run the process (user will be prompted to run with administrator access)
        Catch
            ' exception raised if user declines the admin prompt
        End Try
    End Sub
End Class