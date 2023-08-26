
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles
Imports CroppingImageLibrary
Public Class From1
    Dim cmd As New SqlCommand
    'Dim locationpath As String
    'Dim c As New Cropping_image.CroppingImage
    Dim connection As New SqlConnection("Data Source=ANJULAP;Initial Catalog=Sparrow1;Integrated Security=True")
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'Dim fname As String = TextboxRegid.Text & ".jpg"
        'Dim folder As String
        If MsgBox("Do You Want To Save Modify", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            keyshortcut()
        End If

    End Sub
    Public Sub keyshortcut()
        connection.Open()
        Dim Regid As Integer
        Dim str As String = ""
        Dim da As New SqlDataAdapter
        'Dim lblpath As String
        Dim ds As New DataSet
        str = "select (isnull(MAX(Regid),0)+1) aa from registration "
        da = New SqlDataAdapter(str, connection)
        da.Fill(ds)
        'lblpath = "select (isnull(max(regid),0)+1)aa from registration"

        If ds.Tables(0).Rows.Count > 0 Then
            Regid = ds.Tables(0).Rows(0).Item("aa")
        End If

        Dim Regno As Integer
        Dim str1 As String = ""
        Dim da1 As New SqlDataAdapter
        Dim ds1 As New DataSet
        str1 = "select (isnull(MAX(Regno),0)+1) ss from registration "
        da1 = New SqlDataAdapter(str1, connection)
        da1.Fill(ds1)
        If ds1.Tables(0).Rows.Count > 0 Then
            Regno = ds1.Tables(0).Rows(0).Item("ss")
        End If
        With cmd
            .CommandType = CommandType.Text
            .Connection = connection
            If TextboxRegid.Text = "" Then
                .CommandText = "insert into hospitalFrom (Regid,Regno,IPD_No,Reg_Date,Reg_Time,Patient_Name,Gender,DOB,person_year,person_Month,MaritalStatus,
                FatherName,BloodGroup,Address1,Address2,State,City,PinCode,Case_type, Case_subType,Reffered,
                Reffered_By, Hospital_Name,Doctor_Name,Metal_Rod,Pregnancy_status,
                Admitted_for_same_Disease,Hospital_Name1,Doctor_Name2, Department,UnderDoctor, FloorNo, WardType, WardBedType, 
                Currently_taken_any_mediciene,Medicine,PatientType,Employee_ID,Medical_Insurance,Medicare_no,Valid_till, Insurance_Co, Insurance_NO, Valid_Till1,
                Card_Type, Insurance_Amount, Attendent_Name, Attendent_Age, Attendent_Gender, Attendent_Relation, Attendent_MobileNo,No_of_issue_pass, pass_Name ,
                Pass_Age, Pass_Gender, Pass_Relation,pass_mobile)values
                 (" & Regid & ",'" & Regno & "','" & TextBoxipdno.Text & "','" & DateTimedate.Text & "','" & DateTimetime.Text & "',
                 '" & TextBoxName.Text & "','" & ComboBoxgender.Text & "','" & DateTimedob.Text & "','" & TextBoxyear.Text & "',
                 '" & TextBoxmonth.Text & "','" & ComboBoxmaritalstatus.Text & "','" & TextBoxfathername.Text & "','" & TextBoxbloodgroup.Text & "',
                 '" & TextBoxaddress.Text & "','" & TextBoxaddress1.Text & "','" & TextBoxstate.Text & "',
                 '" & TextBoxcity.Text & "','" & TextBoxpincode.Text & "','" & TextBoxcaseType.Text & "','" & TextBoxcaseSubType.Text & "',
                 '" & TextBoxreffered.Text & "','" & TextBoxrefferedby.Text & "','" & TextBoxhostipalname.Text & "','" & TextBoxdoctorname.Text & "',
                 '" & TextBoxmetalrod.Text & "','" & TextBoxpregnancystatus.Text & "','" & ComboBoxdisease.Text & "','" & TextBoxhospitalname1.Text & "',
                 '" & TextBoxdoctorname1.Text & "','" & Gridadmissiondetails.GetData(1, 0) & "', '" & Gridadmissiondetails.GetData(1, 1) & "',
                 '" & Gridadmissiondetails.GetData(1, 2) & "', '" & Gridadmissiondetails.GetData(1, 3) & "', '" & Gridadmissiondetails.GetData(1, 4) & "','" & TextBoxmedicine.Text & "', '" & TextBoxmedicieneextra.Text & "', '" & TextBoxpatientType.Text & "',
                 '" & TextBoxEmployeeid.Text & "','" & TextBoxmedicalInsurance.Text & "', '" & TextBoxmedicine.Text & "','" & DateTimevalidtill.Text & "', 
                 '" & Insurancegrid.GetData(1, 0) & "',  '" & Insurancegrid.GetData(1, 1) & "',  '" & Insurancegrid.GetData(1, 2) & "',
                  '" & Insurancegrid.GetData(1, 3) & "', '" & Insurancegrid.GetData(1, 4) & "', '" & attendentdetailsgrid.GetData(1, 0) & "', 
                 '" & attendentdetailsgrid.GetData(1, 1) & "', '" & attendentdetailsgrid.GetData(1, 2) & "', '" & attendentdetailsgrid.GetData(1, 3) & "',
                 '" & attendentdetailsgrid.GetData(1, 4) & "',  '" & TextBoxpassissue.Text & "', 
                  '" & passgrid.GetData(1, 0) & "', '" & passgrid.GetData(1, 1) & "','" & passgrid.GetData(1, 2) & "','" & passgrid.GetData(1, 3) & "',
                  '" & passgrid.GetData(1, 4) & "')"


                .ExecuteNonQuery()
                MsgBox("Data Inserted")



            Else
                .CommandType = CommandType.Text
                .Connection = connection
                .CommandText = "Update  hospitalFrom  Set IPD_No ='" & TextBoxipdno.Text & "', Reg_Date='" & DateTimedate.Text & "',Reg_Time='" & DateTimetime.Text & "',
             Patient_Name='" & TextBoxName.Text & "',Gender= '" & ComboBoxgender.Text & "',DOB='" & DateTimedob.Text & "',person_year='" & TextBoxyear.Text & "',
             person_Month='" & TextBoxmonth.Text & "',MaritalStatus='" & ComboBoxmaritalstatus.Text & "', FatherName='" & TextBoxfathername.Text & "',
             BloodGroup='" & TextBoxbloodgroup.Text & "',Address1='" & TextBoxaddress.Text & "',Address2='" & TextBoxaddress1.Text & "',State='" & TextBoxstate.Text & "',City='" & TextBoxcity.Text & "',
             PinCode='" & TextBoxpincode.Text & "',Case_type='" & TextBoxcaseType.Text & "',Case_subType= '" & TextBoxcaseSubType.Text & "',
             Reffered='" & TextBoxreffered.Text & "',Reffered_By='" & TextBoxrefferedby.Text & "',Hospital_Name='" & TextBoxhostipalname.Text & "',
             Doctor_Name='" & TextBoxdoctorname.Text & "',Metal_Rod='" & TextBoxmetalrod.Text & "',Pregnancy_status='" & TextBoxpregnancystatus.Text & "',
             Admitted_for_same_Disease='" & ComboBoxdisease.Text & " ', Hospital_Name1='" & TextBoxhospitalname1.Text & "',Doctor_Name2='" & TextBoxdoctorname1.Text & "',
             Department=' " & Gridadmissiondetails.GetData(1, 0) & "',UnderDoctor=' " & Gridadmissiondetails.GetData(1, 1) & "',FloorNo=' " & Gridadmissiondetails.GetData(1, 2) & "',
             WardType=' " & Gridadmissiondetails.GetData(1, 3) & "',WardBedType=' " & Gridadmissiondetails.GetData(1, 4) & "',Currently_taken_any_mediciene='" & TextBoxmedicine.Text & "',Medicine='" & TextBoxmedicieneextra.Text & "',
             PatientType='" & TextBoxpatientType.Text & "',Employee_ID='" & TextBoxEmployeeid.Text & "',Medical_Insurance='" & TextBoxmedicalInsurance.Text & "',
             Medicare_no='" & TextBoxMedicareNo.Text & "',Valid_till='" & DateTimevalidtill.Text & "',Insurance_Co=' " & Insurancegrid.GetData(1, 0) & "',
             Insurance_No='" & Insurancegrid.GetData(1, 1) & "',Valid_Till1=' " & Insurancegrid.GetData(1, 2) & "',Card_Type=' " & Insurancegrid.GetData(1, 3) & "',
             Insurance_Amount=' " & Insurancegrid.GetData(1, 4) & "',Attendent_Name=' " & attendentdetailsgrid.GetData(1, 0) & "',
             Attendent_Age=' " & attendentdetailsgrid.GetData(1, 1) & "',Attendent_Gender=' " & attendentdetailsgrid.GetData(1, 2) & "',Attendent_Relation=' " & attendentdetailsgrid.GetData(1, 3) & "',
             Attendent_MobileNo=' " & attendentdetailsgrid.GetData(1, 4) & "',No_of_issue_pass='" & TextBoxpassissue.Text & "',
             pass_Name= '" & passgrid.GetData(1, 0) & "',pass_Age=' " & passgrid.GetData(1, 2) & "',
             pass_Gender='" & passgrid.GetData(1, 3) & "',pass_Relation=' " & passgrid.GetData(1, 4) & "',pass_mobile=' " & passgrid.GetData(1, 1) & "' where Regid='" & TextboxRegid.Text & "'"
                .ExecuteNonQuery()
                MsgBox("modify")

            End If


        End With
        With cmd
            .CommandType = CommandType.Text
            .Connection = connection
            .CommandText = "update  registration set Regid= " & Regid & ",Regno='" & Regno & "' "
            .ExecuteNonQuery()
            connection.Close()

        End With

    End Sub
    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextboxRegid.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextboxRegid.Show()
            TextBoxRegno.Focus()
        End If
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxRegno.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxRegno.Show()
            TextBoxipdno.Focus()
        End If
    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxipdno.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxipdno.Show()
            TextBoxName.Focus()
        End If
    End Sub



    Private Sub TextBox43_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxfathername.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxfathername.Show()
            TextBoxbloodgroup.Focus()
        End If
    End Sub

    Private Sub TextBox40_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxbloodgroup.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxbloodgroup.Show()
            TextBoxaddress.Focus()
        End If
    End Sub

    Private Sub TextBox30_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxaddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxaddress.Show()
            TextBoxaddress1.Focus()
        End If
    End Sub

    Private Sub TextBox39_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxaddress1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxaddress1.Show()
            TextBoxstate.Focus()
        End If
    End Sub

    Private Sub TextBox29_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxstate.KeyDown
        If e.KeyCode = Keys.Enter Then
            LblSelectMode.Text = "State"
            gridPanel.Show()
            TXTLIST.Focus()
        End If
    End Sub

    Private Sub TextBox28_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxcity.KeyDown
        If e.KeyCode = Keys.Enter Then
            LblSelectMode.Text = "City"
            gridPanel.Show()
            TXTLIST.Focus()
        ElseIf e.KeyCode = Keys.C AndAlso e.Modifiers = Keys.Alt Then
            CityMaster.Show()
        End If
    End Sub

    Private Sub TextBox31_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxName.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxName.Show()
            ComboBoxgender.Focus()
        End If
    End Sub

    Private Sub ComboBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBoxgender.KeyDown
        If e.KeyCode = Keys.Enter Then

            ComboBoxgender.Show()
            TextBoxyear.Focus()
        End If
    End Sub

    Private Sub TextBox42_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxmonth.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxmonth.Show()
            ComboBoxmaritalstatus.Focus()
        End If
    End Sub

    Private Sub TextBox41_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxyear.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxyear.Show()
            TextBoxmonth.Focus()
        End If
    End Sub

    Private Sub ComboBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBoxmaritalstatus.KeyDown
        If e.KeyCode = Keys.Enter Then

            ComboBoxmaritalstatus.Show()
            TextBoxfathername.Focus()
        End If
    End Sub

    Private Sub TextBox24_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxpincode.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxpincode.Show()
            TextBoxcaseType.Focus()
        End If
    End Sub

    Private Sub TextBox16_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxcaseType.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxcaseType.Show()
            LblSelectMode.Text = "Case_type"
            gridPanel.Show()
            TXTLIST.Focus()
        ElseIf e.KeyCode = Keys.C AndAlso e.Modifiers = Keys.Alt Then
            CaseTypeMaster.Show()
        End If
    End Sub

    Private Sub TextBox17_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxcaseSubType.KeyDown
        If e.KeyCode = Keys.Enter Then
            LblSelectMode.Text = "Case_subType"
            gridPanel.Show()
            TXTLIST.Focus()
            'TextBoxreffered.Focus()
        ElseIf e.KeyCode = Keys.C AndAlso e.Modifiers = Keys.Alt Then
            CaseSubTypeMaster.Show()
        End If
    End Sub

    Private Sub TextBox18_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxreffered.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxreffered.Show()
            TextBoxrefferedby.Focus()
        End If
    End Sub

    Private Sub TextBox19_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxrefferedby.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxrefferedby.Show()
            TextBoxhostipalname.Focus()
        End If
    End Sub

    Private Sub TextBox20_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxhostipalname.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxhostipalname.Show()
            TextBoxdoctorname.Focus()
        End If
    End Sub

    Private Sub TextBox21_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxdoctorname.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxdoctorname.Show()
            TextBoxmetalrod.Focus()
        End If
    End Sub

    Private Sub TextBox22_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxmetalrod.KeyDown

        If e.KeyCode = Keys.Enter Then

            TextBoxmetalrod.Show()
            TextBoxpregnancystatus.Focus()
        End If
    End Sub

    Private Sub TextBox23_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxpregnancystatus.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxpregnancystatus.Show()
            TextBoxhospitalname1.Focus()
        End If
    End Sub

    Private Sub TextBox25_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxhospitalname1.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxhospitalname1.Show()
            TextBoxdoctorname1.Focus()
        End If
    End Sub

    Private Sub TextBox26_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxdoctorname1.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxdoctorname1.Show()
            Gridadmissiondetails.Col() = 0
            Gridadmissiondetails.Focus()
        End If
    End Sub

    Private Sub Gridadmissiondetails_AfterEdit(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles Gridadmissiondetails.AfterEdit
        If Gridadmissiondetails.Col() = 0 Then
            Gridadmissiondetails.Col() = 1
            LblSelectMode.Text = "Department"
            gridPanel.Show()
            TXTLIST.Focus()
        ElseIf Gridadmissiondetails.Col() = 1 Then
            Gridadmissiondetails.Col() = 2
            LblSelectMode.Text = "UnderDoctor"
            gridPanel.Show()
            TXTLIST.Focus()
        ElseIf Gridadmissiondetails.Col() = 2 Then
            Gridadmissiondetails.Col() = 3
            LblSelectMode.Text = "FloorNo"
            gridPanel.Show()
            TXTLIST.Focus()
        ElseIf Gridadmissiondetails.Col() = 3 Then
            Gridadmissiondetails.Col() = 4
            LblSelectMode.Text = "WardType"
            gridPanel.Show()
            TXTLIST.Focus()
        ElseIf Gridadmissiondetails.Col = 4 Then
            LblSelectMode.Text = "WardBedType"
            gridPanel.Show()
            TXTLIST.Focus()
        End If



    End Sub

    Private Sub TXTLIST_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTLIST.KeyDown

        Try
            If e.KeyCode = Keys.Down Then
                GRDLIST.Focus()
                GRDLIST.Row = GRDLIST.TopRow
                TXTLIST.Clear()
            End If

            If e.KeyCode = Keys.Enter Then
                GrdListSet()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GrdListSet()
        Dim row As Integer
        If TXTLIST.Text = "" Then
            row = GRDLIST.Row
        Else
            row = Val(lbltext.Text)
        End If

        If LblSelectMode.Text = "State" Then
            TextBoxstate.Text = GRDLIST.GetData(row, 0)
            gridPanel.Hide()
            TextBoxcity.Focus()
        ElseIf LblSelectMode.Text = "City" Then
            TextBoxcity.Text = GRDLIST.GetData(row, 0)
            gridPanel.Hide()
            TextBoxpincode.Focus()
        ElseIf LblSelectMode.Text = "Case_type" Then
            TextBoxcaseType.Text = GRDLIST.GetData(row, 0)
            gridPanel.Hide()
            TextBoxcaseSubType.Focus()
        ElseIf LblSelectMode.Text = "Case_subType" Then
            TextBoxcaseSubType.Text = GRDLIST.GetData(row, 0)
            gridPanel.Hide()
            TextBoxreffered.Focus()
        ElseIf LblSelectMode.Text = "Department" Then
            Gridadmissiondetails.SetData(1, 0, GRDLIST.GetData(row, 0))
            gridPanel.Hide()
            Gridadmissiondetails.Col() = 1
            Gridadmissiondetails.Focus()
        ElseIf LblSelectMode.Text = "UnderDoctor" Then
            Gridadmissiondetails.SetData(1, 1, GRDLIST.GetData(row, 0))
            gridPanel.Hide()
            Gridadmissiondetails.Col() = 2
            Gridadmissiondetails.Focus()
        ElseIf LblSelectMode.Text = "FloorNo" Then
            Gridadmissiondetails.SetData(1, 2, GRDLIST.GetData(row, 0))
            gridPanel.Hide()
            Gridadmissiondetails.Col() = 3
            Gridadmissiondetails.Focus()
        ElseIf LblSelectMode.Text = "WardType" Then
            Gridadmissiondetails.SetData(1, 3, GRDLIST.GetData(row, 0))
            gridPanel.Hide()
            Gridadmissiondetails.Col() = 4
            Gridadmissiondetails.Focus()
        ElseIf LblSelectMode.Text = "WardBedType" Then
            Gridadmissiondetails.SetData(1, 4, GRDLIST.GetData(row, 0))
            gridPanel.Hide()
            TextBoxmedicine.Focus()
        ElseIf LblSelectMode.Text = "PatientType" Then
            TextBoxpatientType.Text = GRDLIST.GetData(row, 0)
            gridPanel.Hide()
            TextBoxEmployeeid.Focus()


        End If
    End Sub



    Private Sub GRDLIST_KeyDown(sender As Object, e As KeyEventArgs) 
        Try
            If e.KeyCode = Keys.Down Then
                GRDLIST.Focus()

                TXTLIST.Clear()
            End If

            If e.KeyCode = Keys.Enter Then
                GrdListSet()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBoxmediciene_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxmedicine.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxmedicine.Show()
            TextBoxmedicieneextra.Focus()
        End If
    End Sub

    Private Sub TextBoxpatientType_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxpatientType.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxpatientType.Show()
            LblSelectMode.Text = "PatientType"
            gridPanel.Show()
            TXTLIST.Focus()
        ElseIf e.KeyCode = Keys.C AndAlso e.Modifiers = Keys.Alt Then
            PatientMaster.Show()
        End If
    End Sub

    Private Sub TextBoxEmployeeid_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxEmployeeid.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxEmployeeid.Show()
            TextBoxmedicalInsurance.Focus()
        End If
    End Sub

    Private Sub TextBoxmedicalInsurance_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxmedicalInsurance.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxmedicalInsurance.Show()
            TextBoxMedicareNo.Focus()
        End If
    End Sub

    Private Sub TextBoxMedicareNo_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxMedicareNo.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxMedicareNo.Show()
            Insurancegrid.Col() = 0
            Insurancegrid.Focus()
        End If
    End Sub

    Private Sub TextBoxmedicieneextra_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxmedicieneextra.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxmedicieneextra.Show()
            TextBoxpatientType.Focus()
        End If
    End Sub

    Private Sub TXTLIST_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTLIST.KeyPress
        Try
            'If LblSelectMode.Text = "Customer Name" Or LblSelectMode.Text = "Mobile No" Or LblSelectMode.Text = "Cash Voucher" Or LblSelectMode.Text = "Section" Then

            Dim KeyAscii As Short = Asc(e.KeyChar)
            ''''' ----------------------------- Code--------------------------
            Dim txt As String = ""
            Dim d As Integer = 0
            d = 0
            GRDLIST.Redraw = False
            If Asc(e.KeyChar) = 8 And TXTLIST.Text <> "" Then
                txt = UCase(Microsoft.VisualBasic.Left(TXTLIST.Text, (Len(TXTLIST.Text) - 1)))
            Else
                txt = UCase(TXTLIST.Text & Chr(Asc(e.KeyChar)))
            End If

            If txt = "" Then
                Dim cs2 As C1.Win.C1FlexGrid.CellStyle = GRDLIST.Styles.Add("1")
                cs2.ForeColor = Drawing.Color.Black
                cs2.Font = New Font(FontHeight, 14)
                cs2.Font = New Font(Font, FontStyle.Bold)
                GRDLIST.Focus()
                TXTLIST.Focus()

                '-----------------
                Exit Sub
            End If

            Dim val As String = ""
            For i As Integer = 0 To GRDLIST.Rows.Count - 1
                val = UCase(GRDLIST.GetData(i, 4))
                If Microsoft.VisualBasic.InStr(val, txt) > 0 Then
                    d = 1
                    Exit For
                End If
            Next

            Dim cs1 As C1.Win.C1FlexGrid.CellStyle = GRDLIST.Styles.Add("1")
            cs1.ForeColor = Drawing.Color.Maroon
            cs1.Font = New Font(FontHeight, 14)
            cs1.Font = New Font(Font, FontStyle.Bold)

            If d = 0 Then
                e.Handled = True
                TXTLIST.Focus()
            Else
                For i As Integer = 0 To GRDLIST.Rows.Count - 1
                    val = UCase(GRDLIST.GetData(i, 4))
                    If Microsoft.VisualBasic.InStr(val, txt) > 0 Then
                        GRDLIST.Rows(i).Height = 20
                        cs1 = GRDLIST.Styles.Add("1")
                        GRDLIST.SetCellStyle(i, 0, cs1)
                    Else
                        GRDLIST.Rows(i).Height = 0
                    End If
                Next

                lbltext.Text = ""
                For i As Integer = 0 To GRDLIST.Rows.Count - 1
                    If GRDLIST.Rows(i).Height > 0 Then
                        lbltext.Text = i
                        Exit For
                    End If
                Next
            End If
            GRDLIST.Redraw = True


            'End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TXTLIST_GotFocus(sender As Object, e As EventArgs) Handles TXTLIST.GotFocus
        'Try
        Dim addall As String = ""
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        TXTLIST.Clear()
        gridPanel.Width = 250
        GRDLIST.Cols.Count = 5
        GRDLIST.Rows.Count = 1
        If LblSelectMode.Text = "State" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0
        ElseIf LblSelectMode.Text = "City" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0
        ElseIf LblSelectMode.Text = "Case_type" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0
        ElseIf LblSelectMode.Text = "Case_subType" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0
        ElseIf LblSelectMode.Text = "Department" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0
        ElseIf LblSelectMode.Text = "UnderDoctor" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0
        ElseIf LblSelectMode.Text = "FloorNo" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0
        ElseIf LblSelectMode.Text = "WardType" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0
        ElseIf LblSelectMode.Text = "WardBedType" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0
        ElseIf LblSelectMode.Text = "PatientType" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0

        End If

        'End If
        If LblSelectMode.Text = "State" Then
            Da = New SqlDataAdapter("Select StateName, stateID From state_list Order by StateName", connection)

        ElseIf LblSelectMode.Text = "City" Then
            Da = New SqlDataAdapter("Select cityname,CityID From City Order by cityname", connection)

        ElseIf LblSelectMode.Text = "Case_type" Then
            Da = New SqlDataAdapter("Select CaseType,CaseID From Case_type Order by CaseType", connection)
        ElseIf LblSelectMode.Text = "Case_subType" Then
            Da = New SqlDataAdapter("Select CasesubType,Casesubid From Case_subType Order by CasesubType", connection)
        ElseIf LblSelectMode.Text = "Department" Then
            Da = New SqlDataAdapter("Select DepartmentType,Departmentid From Department Order by DepartmentType", connection)
        ElseIf LblSelectMode.Text = "UnderDoctor" Then
            Da = New SqlDataAdapter("Select UnderDoctorType,UnderDoctorid From UnderDoctor Order by UnderDoctorType", connection)
        ElseIf LblSelectMode.Text = "FloorNo" Then
            Da = New SqlDataAdapter("Select Floorno,Floorid From FloorNo Order by Floorno", connection)
        ElseIf LblSelectMode.Text = "WardType" Then
            Da = New SqlDataAdapter("Select WardType,WardTypeid From WardType Order by WardTypeid", connection)
        ElseIf LblSelectMode.Text = "WardBedType" Then
            Da = New SqlDataAdapter("Select BedNo,BedID From WardBedType Order by BedNo", connection)
        ElseIf LblSelectMode.Text = "PatientType" Then
            Da = New SqlDataAdapter("Select PatientType,Patientid From PatientType Order by PatientType", connection)

        End If
        'Da = New DataSqlAdapater
        Ds = New DataSet
        Da.Fill(Ds)



        If Ds.Tables(0).Rows.Count > 0 Then
            With GRDLIST
                .Redraw = False

                For i As Integer = 0 To Ds.Tables(0).Rows.Count - 1
                    If LblSelectMode.Text = "State" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        .SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "City" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        .SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "Case_type" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        .SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "Case_subType" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        .SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)

                    ElseIf LblSelectMode.Text = "Department" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        .SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "UnderDoctor" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        .SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "FloorNo" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        .SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "WardType" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        .SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "WardBedType" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        .SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "PatientType" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        .SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)

                    End If
                Next
                .Redraw = True
            End With

        End If

        If GRDLIST.Rows.Count > 0 Then
            lbltext.Text = 0
            For i As Integer = 0 To GRDLIST.Rows.Count - 1
                If GRDLIST.Rows(i).Height > 0 Then
                    lbltext.Text = i
                    Exit For
                End If
            Next
        End If

        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub Insurancegrid_AfterEdit(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles Insurancegrid.AfterEdit
        If Insurancegrid.Col() = 0 Then
            Insurancegrid.Col() = 1
        ElseIf Insurancegrid.Col() = 1 Then
            Insurancegrid.Col() = 2
        ElseIf Insurancegrid.Col() = 2 Then
            Insurancegrid.Col() = 3
        ElseIf Insurancegrid.Col() = 3 Then
            Insurancegrid.Col() = 4
        ElseIf Insurancegrid.Col() = 4 Then
            attendentdetailsgrid.Focus()
        End If
    End Sub

    Private Sub attendentdetailsgrid_AfterEdit(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles attendentdetailsgrid.AfterEdit
        If attendentdetailsgrid.Col() = 0 Then
            attendentdetailsgrid.Col() = 1
        ElseIf attendentdetailsgrid.Col() = 1 Then
            attendentdetailsgrid.Col() = 2
        ElseIf attendentdetailsgrid.Col() = 2 Then
            attendentdetailsgrid.Col() = 3
        ElseIf attendentdetailsgrid.Col() = 3 Then
            attendentdetailsgrid.Col() = 4
        ElseIf attendentdetailsgrid.Col() = 4 Then
            TextBoxpassissue.Focus()
        End If
    End Sub

    Private Sub TextBoxpassissue_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxpassissue.KeyDown
        If e.KeyCode = Keys.Enter Then

            TextBoxpassissue.Show()
            passgrid.Focus()
        End If
    End Sub

    Private Sub passgrid_AfterEdit(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles passgrid.AfterEdit
        If passgrid.Col() = 0 Then
            passgrid.Col() = 1
        ElseIf passgrid.Col() = 1 Then
            passgrid.Col() = 2
        ElseIf passgrid.Col() = 2 Then
            passgrid.Col() = 3
        ElseIf passgrid.Col() = 3 Then
            passgrid.Col() = 4
        ElseIf passgrid.Col() = 4 Then
            passgrid.Focus()
        End If
    End Sub



    Private Sub Buttonedit_Click(sender As Object, e As EventArgs) Handles Buttonedit.Click

        If MsgBox("Do You Want To Edit", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            keyEditshortcut()
        End If
    End Sub

    Public Sub keyEditshortcut()
        With Me
            .Panel2.Enabled = True
            .Panel3.Enabled = True
            .Panel4.Enabled = True
            .Panel5.Enabled = True
            .Panel6.Enabled = True
            .Panel7.Enabled = True
            .Panel8.Enabled = True
            .Panel9.Enabled = True
        End With

    End Sub

    Private Sub Buttonsearch_Click(sender As Object, e As EventArgs) Handles Buttonsearch.Click
        If MsgBox("Do You Want To Search", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            IPDsearching.Show()
        End If

    End Sub

    Private Sub Buttonexit_Click(sender As Object, e As EventArgs) Handles Buttonexit.Click
        If MsgBox("Do You Want To Exit", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            exitkeyshortcut()
        End If

    End Sub
    Public Sub exitkeyshortcut()
        Me.Close()

    End Sub

    Private Sub Buttonclear_Click(sender As Object, e As EventArgs) Handles Buttonclear.Click
        If MsgBox("Do You Want To Clear", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            clearkeyshortcut()
        End If
        clearkeyshortcut()
    End Sub
    Public Sub clearkeyshortcut()
        TextboxRegid.Clear()
        TextBoxRegno.Clear()
        TextBoxipdno.Clear()
        TextBoxName.Clear()
        TextBoxyear.Clear()
        TextBoxmonth.Clear()
        TextBoxfathername.Clear()
        TextBoxbloodgroup.Clear()
        TextBoxaddress1.Clear()
        TextBoxstate.Clear()
        TextBoxcity.Clear()
        TextBoxpincode.Clear()
        TextBoxcaseType.Clear()
        TextBoxcaseSubType.Clear()
        TextBoxreffered.Clear()
        TextBoxrefferedby.Clear()
        TextBoxhostipalname.Clear()
        TextBoxdoctorname.Clear()
        TextBoxmetalrod.Clear()
        TextBoxpregnancystatus.Clear()
        TextBoxhospitalname1.Clear()
        TextBoxdoctorname1.Clear()
        Gridadmissiondetails.Clear()
        TextBoxmedicine.Clear()
        TextBoxpatientType.Clear()
        Insurancegrid.Clear()
        attendentdetailsgrid.Clear()
        TextBoxpassissue.Clear()
        passgrid.Clear()

    End Sub

    Private Sub From1_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
        Me.WindowState = FormWindowState.Maximized
        'Dim str As String = Application.StartupPath & "picture.jpg"
        'PictureBox1.Image = System.Drawing.Bitmap.FromFile(str)
        'PictureBox1.Image = System.Drawing.Bitmap.FromFile(str)
    End Sub

    Private Sub From1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            keyshortcut()
        ElseIf e.KeyCode = Keys.F2 Then
            If MsgBox("Do You Want To Search", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                IPDsearching.Show()
            End If
        ElseIf e.KeyCode = Keys.F3 Then
            clearkeyshortcut()
        ElseIf e.KeyCode = Keys.F4 Then
            keyEditshortcut()
        ElseIf e.KeyCode = Keys.Escape Then
            If gridPanel.Visible = True Then
                gridPanel.Hide()
            Else
                exitkeyshortcut()
            End If
        End If

    End Sub

    Private Sub Gridadmissiondetails_KeyDown(sender As Object, e As KeyEventArgs) Handles Gridadmissiondetails.KeyDown
        If e.KeyCode = Keys.C AndAlso e.Modifiers = Keys.Alt Then
            If Gridadmissiondetails.Col = 0 Then
                DepartmentMaster.Show()
            ElseIf Gridadmissiondetails.Col = 1 Then
                UnderDoctorMaster.Show()
            ElseIf Gridadmissiondetails.Col = 2 Then
                FloorMaster.Show()
            ElseIf Gridadmissiondetails.Col = 1 Then
                WardTypeMaster.Show()
            ElseIf Gridadmissiondetails.Col = 1 Then
                WardbedMaster.Show()
            End If
        End If
    End Sub

    'Private NameValid As Boolean

    'Private Sub TextBoxName_Leave(sender As Object, e As EventArgs) Handles TextBoxName.Leave

    '    If Not Regex.Match(TextBoxName.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then

    '        MessageBox.Show("Please Enter Alphabetic Characters Only!")

    '        TextBoxName.Focus()
    '        TextBoxName.Clear()

    '        NameValid = False
    '    Else

    '        NameValid = True

    '    End If

    'End Sub
    'Private Function inputValid(input As String)
    '    If Not IsNumeric(input) Then
    '        Return False
    '    Else
    '        Return True
    '    End If
    'End Function

    Private Sub TextBoxName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxyear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxyear.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxmonth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxmonth.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxaddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxaddress.KeyPress

    End Sub

    Private Sub TextBoxaddress1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxaddress1.KeyPress

    End Sub

    Private Sub TextBoxbloodgroup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxbloodgroup.KeyPress

    End Sub

    Private Sub TextBoxcaseSubType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxcaseSubType.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxcaseType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxcaseType.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxcity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxcity.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxdoctorname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxdoctorname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxdoctorname1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxdoctorname1.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxEmployeeid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxEmployeeid.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxfathername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxfathername.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxhospitalname1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxhospitalname1.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxhostipalname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxhostipalname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxipdno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxipdno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxMedicareNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMedicareNo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxmedicine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxmedicine.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxmetalrod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxmetalrod.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxpassissue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxpassissue.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxpatientType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxpatientType.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxpincode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxpincode.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxpregnancystatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxpregnancystatus.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxreffered_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxreffered.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxrefferedby_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxrefferedby.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxstate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxstate.KeyPress

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim K As New OpenFileDialog

        K.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If K.ShowDialog = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(K.FileName)
            'locationpath = K.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Me.Hide()
        CaptureImage.Show()
        CaptureImage.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connection.Open()

        Dim Regid As Integer
        Dim str As String = ""
        Dim da As New SqlDataAdapter
        'Dim lblpath As String
        Dim ds As New DataSet
        str = "select (isnull(MAX(Regid),0)+1) aa from registration "
        da = New SqlDataAdapter(str, connection)
        da.Fill(ds)
        'lblpath = "select (isnull(max(regid),0)+1)aa from registration"

        If ds.Tables(0).Rows.Count > 0 Then
            Regid = ds.Tables(0).Rows(0).Item("aa")
        End If

        Dim Regno As Integer
        Dim str1 As String = ""
        Dim da1 As New SqlDataAdapter
        Dim ds1 As New DataSet
        str1 = "select (isnull(MAX(Regno),0)+1) ss from registration "
        da1 = New SqlDataAdapter(str1, connection)
        da1.Fill(ds1)
        If ds1.Tables(0).Rows.Count > 0 Then
            Regno = ds1.Tables(0).Rows(0).Item("ss")
        End If
        If TextboxRegid.Text = "" Then

            Dim cmd As New SqlCommand("insert into hospitalfrom (image,Regid,Regno) values (@img," & Regid & ",'" & Regno & "')", connection)
            Dim ms As New MemoryStream
            Dim image As Image = PictureBox1.Image
            Dim bmpimage As New Bitmap(image)
            bmpimage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer
            Dim p As New SqlParameter("@img", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            connection.Close()
            MsgBox("image save successfully")
            PictureBox1.Image = Nothing
        Else
            Dim cmd As New SqlCommand("update  hospitalFrom set image =(@img) where Regid='" & TextboxRegid.Text & "'", connection)

            Dim ms As New MemoryStream
            Dim image As Image = PictureBox1.Image
            Dim bmpimage As New Bitmap(image)
            bmpimage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer
            Dim p As New SqlParameter("@img", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            connection.Close()
            MsgBox("image save successfully")
            PictureBox1.Image = Nothing
        End If
    End Sub

    Dim cropX As Integer
    Dim cropY As Integer
    Dim cropWidth As Integer
    Dim cropHeight As Integer

    Dim oCropX As Integer
    Dim oCropY As Integer
    Dim cropBitmap As Bitmap

    Public cropPen As Pen
    Public cropPenSize As Integer = 2 '2
    Public cropDashStyle As Drawing2D.DashStyle = Drawing2D.DashStyle.Solid
    Public cropPenColor As Color = Color.Red

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)

    End Sub
    Dim tmppoint As Point
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Try

            If e.Button = Windows.Forms.MouseButtons.Left Then

                cropX = e.X
                cropY = e.Y

                cropPen = New Pen(cropPenColor, cropPenSize)
                cropPen.DashStyle = DashStyle.DashDotDot
                Cursor = Cursors.Cross

            End If
            PictureBox1.Refresh()
        Catch exc As Exception
        End Try
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Try

            If PictureBox1.Image Is Nothing Then Exit Sub

            If e.Button = Windows.Forms.MouseButtons.Left Then

                PictureBox1.Refresh()
                cropWidth = e.X - cropX
                cropHeight = e.Y - cropY
                PictureBox1.CreateGraphics.DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight)
            End If
            ' GC.Collect()

        Catch exc As Exception

            If Err.Number = 5 Then Exit Sub
        End Try

    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        Try
            Cursor = Cursors.Default
            Try

                If cropWidth < 1 Then
                    Exit Sub
                End If

                Dim rect As Rectangle = New Rectangle(cropX, cropY, cropWidth, cropHeight)
                Dim bit As Bitmap = New Bitmap(PictureBox1.Image, PictureBox1.Width, PictureBox1.Height)
                'cropWidth = 345
                'cropHeight = 107
                cropBitmap = New Bitmap(cropWidth, cropHeight)
                Dim g As Graphics = Graphics.FromImage(cropBitmap)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
                g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel)
                ' g.DrawImage(bit, 0, 0, rect,GraphicsUnit.Pixel)
                PictureBox1.Image = cropBitmap

            Catch exc As Exception
            End Try
        Catch exc As Exception
        End Try
    End Sub


End Class