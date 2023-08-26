<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IPDsearching
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IPDsearching))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxWardType = New System.Windows.Forms.TextBox()
        Me.TextBoxfloorNo = New System.Windows.Forms.TextBox()
        Me.TextBoxunderdoctor = New System.Windows.Forms.TextBox()
        Me.TextBoxdepartment = New System.Windows.Forms.TextBox()
        Me.TextBoxreffered = New System.Windows.Forms.TextBox()
        Me.TextBoxcasesubType = New System.Windows.Forms.TextBox()
        Me.TextBoxcaseType = New System.Windows.Forms.TextBox()
        Me.TextBoxattendentname = New System.Windows.Forms.TextBox()
        Me.TextBoxpatienttype = New System.Windows.Forms.TextBox()
        Me.TextBoxstate = New System.Windows.Forms.TextBox()
        Me.TextBoxcity = New System.Windows.Forms.TextBox()
        Me.TextBoxbloodgroup = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxpatientname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Griddetails = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Buttonshow = New System.Windows.Forms.Button()
        Me.TextBoxipdsearching = New System.Windows.Forms.TextBox()
        Me.Panelgrid = New System.Windows.Forms.Panel()
        Me.GRDLIST = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TXTLIST = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lbltext = New System.Windows.Forms.Label()
        Me.LblSelectMode = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Griddetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panelgrid.SuspendLayout()
        CType(Me.GRDLIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TextBoxWardType)
        Me.Panel1.Controls.Add(Me.TextBoxfloorNo)
        Me.Panel1.Controls.Add(Me.TextBoxunderdoctor)
        Me.Panel1.Controls.Add(Me.TextBoxdepartment)
        Me.Panel1.Controls.Add(Me.TextBoxreffered)
        Me.Panel1.Controls.Add(Me.TextBoxcasesubType)
        Me.Panel1.Controls.Add(Me.TextBoxcaseType)
        Me.Panel1.Controls.Add(Me.TextBoxattendentname)
        Me.Panel1.Controls.Add(Me.TextBoxpatienttype)
        Me.Panel1.Controls.Add(Me.TextBoxstate)
        Me.Panel1.Controls.Add(Me.TextBoxcity)
        Me.Panel1.Controls.Add(Me.TextBoxbloodgroup)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBoxpatientname)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(4, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1514, 358)
        Me.Panel1.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(498, 28)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker2.TabIndex = 30
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(203, 26)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(426, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "TO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(829, 310)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 20)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "WardType"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(829, 265)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 20)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "FloorNo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(829, 213)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 20)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "UnderDoctor"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(829, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 20)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Department"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(829, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Reffered"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(829, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Case SubType"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(829, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 20)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Case Type"
        '
        'TextBoxWardType
        '
        Me.TextBoxWardType.Location = New System.Drawing.Point(1141, 308)
        Me.TextBoxWardType.Name = "TextBoxWardType"
        Me.TextBoxWardType.Size = New System.Drawing.Size(186, 22)
        Me.TextBoxWardType.TabIndex = 20
        '
        'TextBoxfloorNo
        '
        Me.TextBoxfloorNo.Location = New System.Drawing.Point(1141, 265)
        Me.TextBoxfloorNo.Name = "TextBoxfloorNo"
        Me.TextBoxfloorNo.Size = New System.Drawing.Size(186, 22)
        Me.TextBoxfloorNo.TabIndex = 19
        '
        'TextBoxunderdoctor
        '
        Me.TextBoxunderdoctor.Location = New System.Drawing.Point(1141, 213)
        Me.TextBoxunderdoctor.Name = "TextBoxunderdoctor"
        Me.TextBoxunderdoctor.Size = New System.Drawing.Size(186, 22)
        Me.TextBoxunderdoctor.TabIndex = 18
        '
        'TextBoxdepartment
        '
        Me.TextBoxdepartment.Location = New System.Drawing.Point(1141, 168)
        Me.TextBoxdepartment.Name = "TextBoxdepartment"
        Me.TextBoxdepartment.Size = New System.Drawing.Size(186, 22)
        Me.TextBoxdepartment.TabIndex = 17
        '
        'TextBoxreffered
        '
        Me.TextBoxreffered.Location = New System.Drawing.Point(1141, 119)
        Me.TextBoxreffered.Name = "TextBoxreffered"
        Me.TextBoxreffered.Size = New System.Drawing.Size(186, 22)
        Me.TextBoxreffered.TabIndex = 16
        '
        'TextBoxcasesubType
        '
        Me.TextBoxcasesubType.Location = New System.Drawing.Point(1141, 75)
        Me.TextBoxcasesubType.Name = "TextBoxcasesubType"
        Me.TextBoxcasesubType.Size = New System.Drawing.Size(186, 22)
        Me.TextBoxcasesubType.TabIndex = 15
        '
        'TextBoxcaseType
        '
        Me.TextBoxcaseType.Location = New System.Drawing.Point(1141, 28)
        Me.TextBoxcaseType.Name = "TextBoxcaseType"
        Me.TextBoxcaseType.Size = New System.Drawing.Size(186, 22)
        Me.TextBoxcaseType.TabIndex = 14
        '
        'TextBoxattendentname
        '
        Me.TextBoxattendentname.Location = New System.Drawing.Point(203, 308)
        Me.TextBoxattendentname.Name = "TextBoxattendentname"
        Me.TextBoxattendentname.Size = New System.Drawing.Size(186, 22)
        Me.TextBoxattendentname.TabIndex = 13
        '
        'TextBoxpatienttype
        '
        Me.TextBoxpatienttype.Location = New System.Drawing.Point(203, 267)
        Me.TextBoxpatienttype.Name = "TextBoxpatienttype"
        Me.TextBoxpatienttype.Size = New System.Drawing.Size(186, 22)
        Me.TextBoxpatienttype.TabIndex = 12
        '
        'TextBoxstate
        '
        Me.TextBoxstate.Location = New System.Drawing.Point(203, 213)
        Me.TextBoxstate.Name = "TextBoxstate"
        Me.TextBoxstate.Size = New System.Drawing.Size(186, 22)
        Me.TextBoxstate.TabIndex = 11
        '
        'TextBoxcity
        '
        Me.TextBoxcity.Location = New System.Drawing.Point(203, 158)
        Me.TextBoxcity.Name = "TextBoxcity"
        Me.TextBoxcity.Size = New System.Drawing.Size(186, 22)
        Me.TextBoxcity.TabIndex = 10
        '
        'TextBoxbloodgroup
        '
        Me.TextBoxbloodgroup.Location = New System.Drawing.Point(203, 108)
        Me.TextBoxbloodgroup.Name = "TextBoxbloodgroup"
        Me.TextBoxbloodgroup.Size = New System.Drawing.Size(186, 22)
        Me.TextBoxbloodgroup.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Attendent Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "PatientType"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "State"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "city"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Blood Group"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Patient Name"
        '
        'TextBoxpatientname
        '
        Me.TextBoxpatientname.Location = New System.Drawing.Point(203, 66)
        Me.TextBoxpatientname.Name = "TextBoxpatientname"
        Me.TextBoxpatientname.Size = New System.Drawing.Size(186, 22)
        Me.TextBoxpatientname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registration Date"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Griddetails)
        Me.Panel2.Location = New System.Drawing.Point(6, 412)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1761, 181)
        Me.Panel2.TabIndex = 2
        '
        'Griddetails
        '
        Me.Griddetails.BackColor = System.Drawing.Color.SkyBlue
        Me.Griddetails.ColumnInfo = resources.GetString("Griddetails.ColumnInfo")
        Me.Griddetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Griddetails.ForeColor = System.Drawing.Color.Black
        Me.Griddetails.Location = New System.Drawing.Point(-1, -1)
        Me.Griddetails.Margin = New System.Windows.Forms.Padding(4)
        Me.Griddetails.Name = "Griddetails"
        Me.Griddetails.Rows.Count = 1
        Me.Griddetails.Rows.DefaultSize = 20
        Me.Griddetails.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.Griddetails.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Griddetails.Size = New System.Drawing.Size(1759, 181)
        Me.Griddetails.StyleInfo = resources.GetString("Griddetails.StyleInfo")
        Me.Griddetails.TabIndex = 20
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Buttonshow)
        Me.Panel3.Location = New System.Drawing.Point(4, 593)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1755, 72)
        Me.Panel3.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(228, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(94, 46)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(118, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 47)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Buttonshow
        '
        Me.Buttonshow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Buttonshow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonshow.Location = New System.Drawing.Point(0, 0)
        Me.Buttonshow.Name = "Buttonshow"
        Me.Buttonshow.Size = New System.Drawing.Size(120, 47)
        Me.Buttonshow.TabIndex = 1
        Me.Buttonshow.Text = "SHOW"
        Me.Buttonshow.UseVisualStyleBackColor = False
        '
        'TextBoxipdsearching
        '
        Me.TextBoxipdsearching.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxipdsearching.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxipdsearching.Location = New System.Drawing.Point(4, 4)
        Me.TextBoxipdsearching.Multiline = True
        Me.TextBoxipdsearching.Name = "TextBoxipdsearching"
        Me.TextBoxipdsearching.Size = New System.Drawing.Size(1514, 48)
        Me.TextBoxipdsearching.TabIndex = 21
        Me.TextBoxipdsearching.Text = "Patient IPD Searching"
        '
        'Panelgrid
        '
        Me.Panelgrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panelgrid.Controls.Add(Me.GRDLIST)
        Me.Panelgrid.Controls.Add(Me.TXTLIST)
        Me.Panelgrid.Controls.Add(Me.Panel11)
        Me.Panelgrid.Location = New System.Drawing.Point(1524, 12)
        Me.Panelgrid.Name = "Panelgrid"
        Me.Panelgrid.Size = New System.Drawing.Size(221, 401)
        Me.Panelgrid.TabIndex = 22
        '
        'GRDLIST
        '
        Me.GRDLIST.AllowEditing = False
        Me.GRDLIST.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.GRDLIST.BackColor = System.Drawing.Color.White
        Me.GRDLIST.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.GRDLIST.ColumnInfo = "2,0,0,0,0,95,Columns:"
        Me.GRDLIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRDLIST.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRDLIST.ForeColor = System.Drawing.Color.Black
        Me.GRDLIST.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.GRDLIST.Location = New System.Drawing.Point(0, 66)
        Me.GRDLIST.Margin = New System.Windows.Forms.Padding(4)
        Me.GRDLIST.Name = "GRDLIST"
        Me.GRDLIST.Rows.Count = 2
        Me.GRDLIST.Rows.DefaultSize = 19
        Me.GRDLIST.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.GRDLIST.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.GRDLIST.Size = New System.Drawing.Size(219, 333)
        Me.GRDLIST.StyleInfo = resources.GetString("GRDLIST.StyleInfo")
        Me.GRDLIST.TabIndex = 158
        '
        'TXTLIST
        '
        Me.TXTLIST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTLIST.Dock = System.Windows.Forms.DockStyle.Top
        Me.TXTLIST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTLIST.Location = New System.Drawing.Point(0, 36)
        Me.TXTLIST.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTLIST.Name = "TXTLIST"
        Me.TXTLIST.Size = New System.Drawing.Size(219, 30)
        Me.TXTLIST.TabIndex = 147
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Panel11.Controls.Add(Me.lbltext)
        Me.Panel11.Controls.Add(Me.LblSelectMode)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(219, 36)
        Me.Panel11.TabIndex = 9
        '
        'lbltext
        '
        Me.lbltext.AutoSize = True
        Me.lbltext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltext.ForeColor = System.Drawing.Color.Black
        Me.lbltext.Location = New System.Drawing.Point(129, 10)
        Me.lbltext.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltext.Name = "lbltext"
        Me.lbltext.Size = New System.Drawing.Size(0, 20)
        Me.lbltext.TabIndex = 497
        Me.lbltext.Visible = False
        '
        'LblSelectMode
        '
        Me.LblSelectMode.AutoSize = True
        Me.LblSelectMode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSelectMode.ForeColor = System.Drawing.Color.White
        Me.LblSelectMode.Location = New System.Drawing.Point(23, 10)
        Me.LblSelectMode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSelectMode.Name = "LblSelectMode"
        Me.LblSelectMode.Size = New System.Drawing.Size(74, 17)
        Me.LblSelectMode.TabIndex = 140
        Me.LblSelectMode.Text = "Lblaname"
        '
        'IPDsearching
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1773, 758)
        Me.Controls.Add(Me.Panelgrid)
        Me.Controls.Add(Me.TextBoxipdsearching)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "IPDsearching"
        Me.Text = "ipdsearching"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Griddetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panelgrid.ResumeLayout(False)
        Me.Panelgrid.PerformLayout()
        CType(Me.GRDLIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxWardType As TextBox
    Friend WithEvents TextBoxfloorNo As TextBox
    Friend WithEvents TextBoxunderdoctor As TextBox
    Friend WithEvents TextBoxdepartment As TextBox
    Friend WithEvents TextBoxreffered As TextBox
    Friend WithEvents TextBoxcasesubType As TextBox
    Friend WithEvents TextBoxcaseType As TextBox
    Friend WithEvents TextBoxattendentname As TextBox
    Friend WithEvents TextBoxpatienttype As TextBox
    Friend WithEvents TextBoxstate As TextBox
    Friend WithEvents TextBoxcity As TextBox
    Friend WithEvents TextBoxbloodgroup As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxpatientname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Griddetails As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Buttonshow As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBoxipdsearching As TextBox
    Friend WithEvents Panelgrid As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lbltext As Label
    Friend WithEvents LblSelectMode As Label
    Friend WithEvents TXTLIST As TextBox
    Friend WithEvents GRDLIST As C1.Win.C1FlexGrid.C1FlexGrid
End Class
