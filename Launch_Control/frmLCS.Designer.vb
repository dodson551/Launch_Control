﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLCS
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLCS))
        Me.tlpRightSide = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAbort = New System.Windows.Forms.Button()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.Launch = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnIgnite = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDisarm = New System.Windows.Forms.Button()
        Me.btnArm = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnPing = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConsole = New System.Windows.Forms.TextBox()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpLeft = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.FlightControlComputerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveEventLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.dgvEvents = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.updateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.OpenVentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseVentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenMainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseMainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlpRightSide.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Launch.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.tlpLeft.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpRightSide
        '
        Me.tlpRightSide.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpRightSide.ColumnCount = 1
        Me.tlpRightSide.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRightSide.Controls.Add(Me.GroupBox3, 0, 3)
        Me.tlpRightSide.Controls.Add(Me.Launch, 0, 2)
        Me.tlpRightSide.Controls.Add(Me.GroupBox2, 0, 1)
        Me.tlpRightSide.Controls.Add(Me.GroupBox1, 0, 0)
        Me.tlpRightSide.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRightSide.Location = New System.Drawing.Point(1392, 3)
        Me.tlpRightSide.Name = "tlpRightSide"
        Me.tlpRightSide.RowCount = 4
        Me.tlpRightSide.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpRightSide.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpRightSide.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpRightSide.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpRightSide.Size = New System.Drawing.Size(509, 1035)
        Me.tlpRightSide.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel5)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(4, 882)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(501, 149)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Launch Control"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnAbort, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnLaunch, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 28)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(495, 118)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'btnAbort
        '
        Me.btnAbort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAbort.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbort.Location = New System.Drawing.Point(250, 3)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(242, 112)
        Me.btnAbort.TabIndex = 6
        Me.btnAbort.Text = "ABORT"
        Me.btnAbort.UseVisualStyleBackColor = True
        '
        'btnLaunch
        '
        Me.btnLaunch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLaunch.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaunch.Location = New System.Drawing.Point(3, 3)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(241, 112)
        Me.btnLaunch.TabIndex = 5
        Me.btnLaunch.Text = "LAUNCH"
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'Launch
        '
        Me.Launch.Controls.Add(Me.TableLayoutPanel4)
        Me.Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Launch.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Launch.Location = New System.Drawing.Point(4, 727)
        Me.Launch.Name = "Launch"
        Me.Launch.Size = New System.Drawing.Size(501, 148)
        Me.Launch.TabIndex = 2
        Me.Launch.TabStop = False
        Me.Launch.Text = "Ignition Control"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnCancel, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnIgnite, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 28)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(495, 117)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(250, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(242, 111)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnIgnite
        '
        Me.btnIgnite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnIgnite.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgnite.Location = New System.Drawing.Point(3, 3)
        Me.btnIgnite.Name = "btnIgnite"
        Me.btnIgnite.Size = New System.Drawing.Size(241, 111)
        Me.btnIgnite.TabIndex = 6
        Me.btnIgnite.Text = "IGNITE"
        Me.btnIgnite.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 623)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 97)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Safety"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnDisarm, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnArm, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 28)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(495, 66)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'btnDisarm
        '
        Me.btnDisarm.BackColor = System.Drawing.Color.Green
        Me.btnDisarm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDisarm.Location = New System.Drawing.Point(250, 3)
        Me.btnDisarm.Name = "btnDisarm"
        Me.btnDisarm.Size = New System.Drawing.Size(242, 60)
        Me.btnDisarm.TabIndex = 1
        Me.btnDisarm.Text = "DISARM"
        Me.btnDisarm.UseVisualStyleBackColor = False
        '
        'btnArm
        '
        Me.btnArm.BackColor = System.Drawing.Color.Yellow
        Me.btnArm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnArm.Enabled = False
        Me.btnArm.Location = New System.Drawing.Point(3, 3)
        Me.btnArm.Name = "btnArm"
        Me.btnArm.Size = New System.Drawing.Size(241, 60)
        Me.btnArm.TabIndex = 0
        Me.btnArm.Text = "ARMED"
        Me.btnArm.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 612)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Network Configuration"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtConsole, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 28)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(495, 581)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnDisconnect, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPing, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnConnect, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtIP, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPort, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(489, 197)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisconnect.Location = New System.Drawing.Point(247, 101)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(239, 43)
        Me.btnDisconnect.TabIndex = 5
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnPing
        '
        Me.btnPing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPing.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPing.Location = New System.Drawing.Point(3, 150)
        Me.btnPing.Name = "btnPing"
        Me.btnPing.Size = New System.Drawing.Size(238, 44)
        Me.btnPing.TabIndex = 6
        Me.btnPing.Text = "Ping Server"
        Me.btnPing.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConnect.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(3, 101)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(238, 43)
        Me.btnConnect.TabIndex = 4
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtIP
        '
        Me.txtIP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtIP.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP.Location = New System.Drawing.Point(247, 11)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(239, 26)
        Me.txtIP.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(247, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(239, 44)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Network Interface"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP Address:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPort
        '
        Me.txtPort.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtPort.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.Location = New System.Drawing.Point(247, 60)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(239, 26)
        Me.txtPort.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 49)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Port:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConsole
        '
        Me.txtConsole.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtConsole.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsole.ForeColor = System.Drawing.Color.Lime
        Me.txtConsole.Location = New System.Drawing.Point(3, 206)
        Me.txtConsole.Multiline = True
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConsole.Size = New System.Drawing.Size(489, 372)
        Me.txtConsole.TabIndex = 1
        Me.txtConsole.Text = "Network Console:"
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.0!))
        Me.tlpMain.Controls.Add(Me.tlpRightSide, 1, 0)
        Me.tlpMain.Controls.Add(Me.tlpLeft, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 1
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Size = New System.Drawing.Size(1904, 1041)
        Me.tlpMain.TabIndex = 0
        '
        'tlpLeft
        '
        Me.tlpLeft.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpLeft.ColumnCount = 1
        Me.tlpLeft.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLeft.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.tlpLeft.Controls.Add(Me.dgvEvents, 0, 2)
        Me.tlpLeft.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLeft.Location = New System.Drawing.Point(3, 3)
        Me.tlpLeft.Name = "tlpLeft"
        Me.tlpLeft.RowCount = 4
        Me.tlpLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.tlpLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.tlpLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.tlpLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpLeft.Size = New System.Drawing.Size(1383, 1035)
        Me.tlpLeft.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton2, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(1, 1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1381, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FlightControlComputerToolStripMenuItem, Me.SaveEventLogToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripDropDownButton1.Text = "Options"
        '
        'FlightControlComputerToolStripMenuItem
        '
        Me.FlightControlComputerToolStripMenuItem.Name = "FlightControlComputerToolStripMenuItem"
        Me.FlightControlComputerToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.FlightControlComputerToolStripMenuItem.Text = "Flight Control Computer"
        '
        'SaveEventLogToolStripMenuItem
        '
        Me.SaveEventLogToolStripMenuItem.Name = "SaveEventLogToolStripMenuItem"
        Me.SaveEventLogToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.SaveEventLogToolStripMenuItem.Text = "Save Event Log"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ExitToolStripMenuItem.Text = "Exit..."
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripButton1.Text = "Settings"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripButton2.Text = "Info"
        '
        'dgvEvents
        '
        Me.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEvents.Location = New System.Drawing.Point(4, 108)
        Me.dgvEvents.Name = "dgvEvents"
        Me.dgvEvents.Size = New System.Drawing.Size(1375, 663)
        Me.dgvEvents.TabIndex = 1
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.lblTime, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel8, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(4, 35)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1375, 66)
        Me.TableLayoutPanel7.TabIndex = 2
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.SystemColors.Control
        Me.lblTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTime.Font = New System.Drawing.Font("OCR A Extended", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTime.Location = New System.Drawing.Point(4, 1)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(1023, 64)
        Me.lblTime.TabIndex = 0
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'updateTimer
        '
        Me.updateTimer.Interval = 1000
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.btnBegin, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.btnReset, 1, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.TextBox1, 0, 1)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(1034, 4)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(337, 58)
        Me.TableLayoutPanel8.TabIndex = 1
        '
        'btnBegin
        '
        Me.btnBegin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBegin.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBegin.Location = New System.Drawing.Point(171, 3)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(163, 23)
        Me.btnBegin.TabIndex = 0
        Me.btnBegin.Text = "Begin Countdown"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReset.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(171, 32)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(163, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset Countdown"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Countdown Timer"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(162, 23)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenVentsToolStripMenuItem, Me.CloseVentsToolStripMenuItem, Me.OpenMainToolStripMenuItem, Me.CloseMainToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripDropDownButton2.Text = "Pre-Flight"
        '
        'OpenVentsToolStripMenuItem
        '
        Me.OpenVentsToolStripMenuItem.Name = "OpenVentsToolStripMenuItem"
        Me.OpenVentsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenVentsToolStripMenuItem.Text = "Open Vents"
        '
        'CloseVentsToolStripMenuItem
        '
        Me.CloseVentsToolStripMenuItem.Name = "CloseVentsToolStripMenuItem"
        Me.CloseVentsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseVentsToolStripMenuItem.Text = "Close Vents"
        '
        'OpenMainToolStripMenuItem
        '
        Me.OpenMainToolStripMenuItem.Name = "OpenMainToolStripMenuItem"
        Me.OpenMainToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenMainToolStripMenuItem.Text = "Open Main"
        '
        'CloseMainToolStripMenuItem
        '
        Me.CloseMainToolStripMenuItem.Name = "CloseMainToolStripMenuItem"
        Me.CloseMainToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseMainToolStripMenuItem.Text = "Close Main"
        '
        'frmLCS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.tlpMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLCS"
        Me.Text = "San Diego State Rocket Project Launch Control"
        Me.tlpRightSide.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Launch.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tlpMain.ResumeLayout(False)
        Me.tlpLeft.ResumeLayout(False)
        Me.tlpLeft.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpRightSide As TableLayoutPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btnAbort As Button
    Friend WithEvents btnLaunch As Button
    Friend WithEvents Launch As GroupBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnIgnite As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnDisarm As Button
    Friend WithEvents btnArm As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents btnPing As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtConsole As TextBox
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpLeft As TableLayoutPanel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents FlightControlComputerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveEventLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents dgvEvents As DataGridView
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents lblTime As Label
    Friend WithEvents updateTimer As Timer
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents btnBegin As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents OpenVentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseVentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenMainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseMainToolStripMenuItem As ToolStripMenuItem
End Class
