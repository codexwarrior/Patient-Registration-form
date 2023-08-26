Imports System.Data.SqlClient
Imports Emgu.CV
Imports OpenTK.Graphics.ES11

Public Class IPDsearching
    Dim cmd As New SqlCommand
    Dim connection As New SqlConnection("Data Source=ANJULAP;Initial Catalog=Sparrow1;Integrated Security=True")
    Private Sub Buttonshow_Click(sender As Object, e As EventArgs) Handles Buttonshow.Click
        Dim str As String = ""
        Dim k As String = " "
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        If TextBoxpatientname.Text <> "" Then
            k = "and Patient_Name='" & TextBoxpatientname.Text & "'"
        End If
        If TextBoxbloodgroup.Text <> "" Then
            k = k & "and BloodGroup='" & TextBoxbloodgroup.Text & "'"
        End If
        If TextBoxcity.Text <> "" Then
            k = k & "and City ='" & TextBoxcity.Text & "'"
        End If
        If TextBoxstate.Text <> "" Then
            k = k & "and State='" & TextBoxstate.Text & "'"
        End If
        If TextBoxattendentname.Text <> "" Then
            k = k & "and Attendent_Name='" & TextBoxattendentname.Text & "'"
        End If
        If TextBoxcaseType.Text <> "" Then
            k = k & "and Case_type='" & TextBoxcaseType.Text & "'"
        End If
        If TextBoxcasesubType.Text <> "" Then
            k = k & "and Case_subType='" & TextBoxcasesubType.Text & "'"
        End If
        If TextBoxreffered.Text <> "" Then
            k = k & "and Reffered='" & TextBoxreffered.Text & "'"
        End If
        If TextBoxdepartment.Text <> "" Then
            k = k & "and Department='" & TextBoxdepartment.Text & "'"
        End If
        If TextBoxunderdoctor.Text <> "" Then
            k = k & "and UnderDoctor='" & TextBoxunderdoctor.Text & "'"
        End If
        If TextBoxfloorNo.Text <> "" Then
            k = k & "and FloorNo='" & TextBoxfloorNo.Text & "'"
        End If
        If TextBoxWardType.Text <> "" Then
            k = k & "and WardType='" & TextBoxWardType.Text & "'"
        End If
        If TextBoxpatienttype.Text <> "" Then
            k = k & "and PatientType='" & TextBoxpatienttype.Text & "'"
        End If
        str = "select * from hospitalFrom where 1=1 " & k & ""
        da = New SqlDataAdapter(str, connection)
        da.Fill(ds)

        With Griddetails
            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    .Rows.Add()
                    .SetData(.Rows.Count - 1, 0, ds.Tables(0).Rows(i).Item("Regno"))
                    .SetData(.Rows.Count - 1, 1, ds.Tables(0).Rows(i).Item("Patient_Name"))
                    .SetData(.Rows.Count - 1, 2, ds.Tables(0).Rows(i).Item("person_year"))
                    .SetData(.Rows.Count - 1, 3, ds.Tables(0).Rows(i).Item("BloodGroup"))
                    .SetData(.Rows.Count - 1, 4, ds.Tables(0).Rows(i).Item("City"))
                    .SetData(.Rows.Count - 1, 5, ds.Tables(0).Rows(i).Item("State"))
                    .SetData(.Rows.Count - 1, 6, ds.Tables(0).Rows(i).Item("Case_type"))
                    .SetData(.Rows.Count - 1, 7, ds.Tables(0).Rows(i).Item("Case_subType"))
                    .SetData(.Rows.Count - 1, 8, ds.Tables(0).Rows(i).Item("Reffered"))
                    .SetData(.Rows.Count - 1, 9, ds.Tables(0).Rows(i).Item("Department"))
                    .SetData(.Rows.Count - 1, 10, ds.Tables(0).Rows(i).Item("UnderDoctor"))
                    .SetData(.Rows.Count - 1, 11, ds.Tables(0).Rows(i).Item("FloorNo"))
                    .SetData(.Rows.Count - 1, 12, ds.Tables(0).Rows(i).Item("WardType"))
                    .SetData(.Rows.Count - 1, 13, ds.Tables(0).Rows(i).Item("WardBedType"))
                    .SetData(.Rows.Count - 1, 14, ds.Tables(0).Rows(i).Item("PatientType"))
                Next
            End If
        End With
    End Sub

    Private Sub TextBoxpatientname_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxpatientname.KeyDown
        If e.KeyCode = Keys.Enter Then
            LblSelectMode.Text = "Patient Name"
            Panelgrid.Show()
            TXTLIST.Focus()
        End If
    End Sub

    Private Sub TextBoxbloodgroup_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxbloodgroup.KeyDown
        If e.KeyCode = Keys.Enter Then
            LblSelectMode.Text = "Blood Group"
            Panelgrid.Show()
            TXTLIST.Focus()
        End If
    End Sub

    Private Sub TextBoxcity_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxcity.KeyDown
        If e.KeyCode = Keys.Enter Then
            LblSelectMode.Text = "city"
            Panelgrid.Show()
            TXTLIST.Focus()
        End If
    End Sub

    Private Sub TextBoxstate_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxstate.KeyDown
        If e.KeyCode = Keys.Enter Then
            LblSelectMode.Text = "State"
            Panelgrid.Show()
            TXTLIST.Focus()
        End If
    End Sub

    Private Sub TextBoxpatienttype_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxpatienttype.KeyDown
        If e.KeyCode = Keys.Enter Then
            LblSelectMode.Text = "PatientType"
            Panelgrid.Show()
            TXTLIST.Focus()
        End If
    End Sub

    Private Sub TextBoxattendentname_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxattendentname.KeyDown
        If e.KeyCode = Keys.Enter Then
            LblSelectMode.Text = "Attendent Name"
            Panelgrid.Show()
            TXTLIST.Focus()
        End If
    End Sub

    Private Sub TextBoxcaseType_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxcaseType.KeyDown
        If e.KeyCode = Keys.Enter Then
            LblSelectMode.Text = "Case Type"
            Panelgrid.Show()
            TXTLIST.Focus()
        End If
    End Sub

    Private Sub TextBoxcasesubType_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxcasesubType.KeyDown
        If e.KeyCode = Keys.Enter Then
            LblSelectMode.Text = "Case SubType"
            Panelgrid.Show()
            TXTLIST.Focus()
        End If
    End Sub

    Private Sub TextBoxreffered_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxreffered.KeyDown
        If e.KeyCode = Keys.Enter Then
            LblSelectMode.Text = "Reffered"
            Panelgrid.Show()
            TXTLIST.Focus()
        End If
    End Sub

    Private Sub TextBoxdepartment_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxdepartment.KeyDown
        If e.KeyCode = Keys.Enter Then
            LblSelectMode.Text = "Department"
            Panelgrid.Show()
            TXTLIST.Focus()
        End If
    End Sub

    Private Sub TextBoxunderdoctor_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxunderdoctor.KeyDown
        If e.KeyCode = Keys.Enter Then
            LblSelectMode.Text = "UnderDoctor"
            Panelgrid.Show()
            TXTLIST.Focus()
        End If
    End Sub

    Private Sub TextBoxfloorNo_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxfloorNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            LblSelectMode.Text = "FloorNo"
            Panelgrid.Show()
            TXTLIST.Focus()
        End If
    End Sub

    Private Sub TextBoxWardType_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxWardType.KeyDown
        If e.KeyCode = Keys.Enter Then
            LblSelectMode.Text = "WardType"
            Panelgrid.Show()
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
        If LblSelectMode.Text = "Patient Name" Then
            TextBoxpatientname.Text = GRDLIST.GetData(row, 0)
            Panelgrid.Hide()
            TextBoxbloodgroup.Focus()
        ElseIf LblSelectMode.Text = "Blood Group" Then
            TextBoxbloodgroup.Text = GRDLIST.GetData(row, 0)
            Panelgrid.Hide()
            TextBoxcity.Focus()
        ElseIf LblSelectMode.Text = "city" Then
            TextBoxcity.Text = GRDLIST.GetData(row, 0)
            Panelgrid.Hide()
            TextBoxstate.Focus()
        ElseIf LblSelectMode.Text = "State" Then
            TextBoxstate.Text = GRDLIST.GetData(row, 0)
            Panelgrid.Hide()
            TextBoxpatienttype.Focus()
        ElseIf LblSelectMode.Text = "PatientType" Then
            TextBoxpatienttype.Text = GRDLIST.GetData(row, 0)
            Panelgrid.Hide()
            TextBoxattendentname.Focus()
        ElseIf LblSelectMode.Text = "Attendent Name" Then
            TextBoxattendentname.Text = GRDLIST.GetData(row, 0)
            Panelgrid.Hide()
            TextBoxcaseType.Focus()
        ElseIf LblSelectMode.Text = "Case Type" Then
            TextBoxcaseType.Text = GRDLIST.GetData(row, 0)
            Panelgrid.Hide()
            TextBoxcasesubType.Focus()
        ElseIf LblSelectMode.Text = "Case SubType" Then
            TextBoxcasesubType.Text = GRDLIST.GetData(row, 0)
            Panelgrid.Hide()
            TextBoxreffered.Focus()
        ElseIf LblSelectMode.Text = "Reffered" Then
            TextBoxreffered.Text = GRDLIST.GetData(row, 0)
            Panelgrid.Hide()
            TextBoxdepartment.Focus()
        ElseIf LblSelectMode.Text = "Department" Then
            TextBoxdepartment.Text = GRDLIST.GetData(row, 0)
            Panelgrid.Hide()
            TextBoxunderdoctor.Focus()
        ElseIf LblSelectMode.Text = "UnderDoctor" Then
            TextBoxunderdoctor.Text = GRDLIST.GetData(row, 0)
            Panelgrid.Hide()
            TextBoxfloorNo.Focus()
        ElseIf LblSelectMode.Text = "FloorNo" Then
            TextBoxfloorNo.Text = GRDLIST.GetData(row, 0)
            Panelgrid.Hide()
            TextBoxWardType.Focus()
        ElseIf LblSelectMode.Text = "WardType" Then
            TextBoxWardType.Text = GRDLIST.GetData(row, 0)
            Panelgrid.Hide()
            'TextBoxunderdoctor.Focus()


        End If
        Throw New NotImplementedException()
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
        Dim addall As String = ""
        Dim Da As New SqlDataAdapter
        Dim Ds As New DataSet
        TXTLIST.Clear()
        Panelgrid.Width = 250
        GRDLIST.Cols.Count = 5
        GRDLIST.Rows.Count = 1
        If LblSelectMode.Text = "Patient Name" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0
        ElseIf LblSelectMode.Text = "Blood Group" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0
        ElseIf LblSelectMode.Text = "state" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0
        ElseIf LblSelectMode.Text = "city" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0
        ElseIf LblSelectMode.Text = "Attendent Name" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0
        ElseIf LblSelectMode.Text = "Case Type" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0
        ElseIf LblSelectMode.Text = "Case SubType" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0
        ElseIf LblSelectMode.Text = "Reffered" Then
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
        ElseIf LblSelectMode.Text = "PatientType" Then
            GRDLIST.Cols(0).DataType = GetType(Object)
            GRDLIST.Cols(0).Width = 220
            GRDLIST.Cols(1).Width = 0
            GRDLIST.Cols(2).Width = 0
            GRDLIST.Cols(3).Width = 0
            GRDLIST.Cols(4).Width = 0

        End If

        'End If
        If LblSelectMode.Text = "Patient Name" Then
            Da = New SqlDataAdapter("Select Patient_Name From  hospitalFrom Order by Patient_Name", connection)
        ElseIf LblSelectMode.Text = "Blood Group" Then
            Da = New SqlDataAdapter("Select BloodGroup From hospitalFrom Order by BloodGroup", connection)
        ElseIf LblSelectMode.Text = "State" Then
            Da = New SqlDataAdapter("Select State From hospitalFrom Order by State", connection)
        ElseIf LblSelectMode.Text = "city" Then
            Da = New SqlDataAdapter("Select City From hospitalFrom Order by City", connection)
        ElseIf LblSelectMode.Text = "Attendent Name" Then
            Da = New SqlDataAdapter("Select Attendent_Name From hospitalFrom Order by Attendent_Name", connection)
        ElseIf LblSelectMode.Text = "Case Type" Then
            Da = New SqlDataAdapter("Select Case_type From hospitalFrom Order by Case_type", connection)
        ElseIf LblSelectMode.Text = "Case SubType" Then
            Da = New SqlDataAdapter("Select Case_subType From hospitalFrom Order by Case_subType", connection)
        ElseIf LblSelectMode.Text = "Reffered" Then
            Da = New SqlDataAdapter("Select Reffered From hospitalFrom Order by Reffered", connection)
        ElseIf LblSelectMode.Text = "Department" Then
            Da = New SqlDataAdapter("Select Department From hospitalFrom Order by Department", connection)
        ElseIf LblSelectMode.Text = "UnderDoctor" Then
            Da = New SqlDataAdapter("Select UnderDoctor From hospitalFrom Order by UnderDoctor", connection)
        ElseIf LblSelectMode.Text = "FloorNo" Then
            Da = New SqlDataAdapter("Select FloorNo From hospitalFrom Order by FloorNo", connection)
        ElseIf LblSelectMode.Text = "WardType" Then
            Da = New SqlDataAdapter("Select WardType From WardType Order by WardType", connection)
        ElseIf LblSelectMode.Text = "PatientType" Then
            Da = New SqlDataAdapter("Select PatientType From PatientType Order by PatientType", connection)

        End If
        'Da = New DataSqlAdapater
        Ds = New DataSet
        Da.Fill(Ds)



        If Ds.Tables(0).Rows.Count > 0 Then
            With GRDLIST
                .Redraw = False

                For i As Integer = 0 To Ds.Tables(0).Rows.Count - 1
                    If LblSelectMode.Text = "Patient Name" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        '.SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "Blood Group" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        '.SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "State" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        '.SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "city" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        '.SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "Attendent Name" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        '.SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "Case Type" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        '.SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "Case SubType" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        '.SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "Reffered" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        '.SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "Department" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        '.SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "UnderDoctor" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        '.SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "FloorNo" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        '.SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "WardType" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        '.SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
                        addall = Ds.Tables(0).Rows(i).Item(0)
                        .SetData(.Rows.Count - 1, 4, addall)
                    ElseIf LblSelectMode.Text = "PatientType" Then
                        .Rows.Add()
                        .SetData(.Rows.Count - 1, 0, Ds.Tables(0).Rows(i).Item(0))
                        '.SetData(.Rows.Count - 1, 1, Ds.Tables(0).Rows(i).Item(1))
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

    End Sub

    Private Sub GRDLIST_KeyDown(sender As Object, e As KeyEventArgs) Handles GRDLIST.KeyDown
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBoxpatientname.Clear()
        TextBoxbloodgroup.Clear()
        TextBoxcity.Clear()
        TextBoxstate.Clear()
        TextBoxattendentname.Clear()
        TextBoxcaseType.Clear()
        TextBoxcasesubType.Clear()
        TextBoxdepartment.Clear()
        TextBoxunderdoctor.Clear()
        TextBoxfloorNo.Clear()
        TextBoxbloodgroup.Clear()
        TextBoxreffered.Clear()
        TextBoxpatienttype.Clear()
        Griddetails.Clear()

    End Sub


    Private Sub Griddetails_DoubleClick(sender As Object, e As EventArgs) Handles Griddetails.DoubleClick
        Dim str As String = ""
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim arrImage() As Byte
        str = "select * from  hospitalFrom where Patient_Name = '" & Griddetails.GetData(Griddetails.Row, 1) & "'"
        da = New SqlDataAdapter(str, connection)
        da.Fill(ds)
        With From1
            If ds.Tables(0).Rows.Count > 0 Then
                .TextboxRegid.Text = ds.Tables(0).Rows(0).Item("Regid")
                .TextBoxRegno.Text = ds.Tables(0).Rows(0).Item("Regno")
                .TextBoxipdno.Text = ds.Tables(0).Rows(0).Item("IPD_No")
                .DateTimedate.Text = ds.Tables(0).Rows(0).Item("Reg_Date")
                .DateTimetime.Text = ds.Tables(0).Rows(0).Item("Reg_Time")
                .TextBoxName.Text = ds.Tables(0).Rows(0).Item("Patient_Name")
                .ComboBoxgender.Text = ds.Tables(0).Rows(0).Item("Gender")
                .DateTimedob.Text = ds.Tables(0).Rows(0).Item("DOB")
                .TextBoxyear.Text = ds.Tables(0).Rows(0).Item("person_year")
                .TextBoxmonth.Text = ds.Tables(0).Rows(0).Item("person_Month")
                .ComboBoxmaritalstatus.Text = ds.Tables(0).Rows(0).Item("MaritalStatus")
                .TextBoxfathername.Text = ds.Tables(0).Rows(0).Item("FatherName")
                .TextBoxbloodgroup.Text = ds.Tables(0).Rows(0).Item("BloodGroup")
                .TextBoxaddress.Text = ds.Tables(0).Rows(0).Item("Address1")
                .TextBoxaddress1.Text = ds.Tables(0).Rows(0).Item("Address2")
                .TextBoxstate.Text = ds.Tables(0).Rows(0).Item("State")
                .TextBoxcity.Text = ds.Tables(0).Rows(0).Item("City")
                .TextBoxpincode.Text = ds.Tables(0).Rows(0).Item("Pincode")
                .TextBoxcaseType.Text = ds.Tables(0).Rows(0).Item("Case_type")
                .TextBoxcaseSubType.Text = ds.Tables(0).Rows(0).Item("Case_subType")
                .TextBoxreffered.Text = ds.Tables(0).Rows(0).Item("Reffered")
                .TextBoxrefferedby.Text = ds.Tables(0).Rows(0).Item("Reffered_By")
                .TextBoxhostipalname.Text = ds.Tables(0).Rows(0).Item("Hospital_Name")
                .TextBoxdoctorname.Text = ds.Tables(0).Rows(0).Item("Doctor_Name")
                .TextBoxmetalrod.Text = ds.Tables(0).Rows(0).Item("Metal_Rod")
                .TextBoxpregnancystatus.Text = ds.Tables(0).Rows(0).Item("Pregnancy_status")
                .ComboBoxdisease.Text = ds.Tables(0).Rows(0).Item("Admitted_for_same_Disease")
                .TextBoxhospitalname1.Text = ds.Tables(0).Rows(0).Item("Hospital_Name1")
                .TextBoxdoctorname1.Text = ds.Tables(0).Rows(0).Item("Doctor_Name2")
                .Gridadmissiondetails(1, 0) = ds.Tables(0).Rows(0).Item("Department")
                .Gridadmissiondetails(1, 1) = ds.Tables(0).Rows(0).Item("UnderDoctor")
                .Gridadmissiondetails(1, 2) = ds.Tables(0).Rows(0).Item("FloorNo")
                .Gridadmissiondetails(1, 3) = ds.Tables(0).Rows(0).Item("WardType")
                .Gridadmissiondetails(1, 4) = ds.Tables(0).Rows(0).Item("WardBedType")
                .TextBoxmedicine.Text = ds.Tables(0).Rows(0).Item("Currently_taken_any_mediciene")
                .TextBoxmedicieneextra.Text = ds.Tables(0).Rows(0).Item("Medicine")
                .TextBoxpatientType.Text = ds.Tables(0).Rows(0).Item("PatientType")
                .TextBoxEmployeeid.Text = ds.Tables(0).Rows(0).Item("Employee_ID")
                .TextBoxmedicalInsurance.Text = ds.Tables(0).Rows(0).Item("Medical_Insurance")
                .TextBoxMedicareNo.Text = ds.Tables(0).Rows(0).Item("Medicare_no")
                .DateTimevalidtill.Text = ds.Tables(0).Rows(0).Item("Valid_till")
                .Insurancegrid(1, 0) = ds.Tables(0).Rows(0).Item("Insurance_Co")
                .Insurancegrid(1, 1) = ds.Tables(0).Rows(0).Item("Insurance_No")
                .Insurancegrid(1, 2) = ds.Tables(0).Rows(0).Item("Valid_Till1")
                .Insurancegrid(1, 3) = ds.Tables(0).Rows(0).Item("Card_Type")
                .Insurancegrid(1, 4) = ds.Tables(0).Rows(0).Item("Insurance_Amount")
                .attendentdetailsgrid(1, 0) = ds.Tables(0).Rows(0).Item("Attendent_Name")
                .attendentdetailsgrid(1, 1) = ds.Tables(0).Rows(0).Item("Attendent_Age")
                .attendentdetailsgrid(1, 3) = ds.Tables(0).Rows(0).Item("Attendent_Gender")
                .attendentdetailsgrid(1, 2) = ds.Tables(0).Rows(0).Item("Attendent_Relation")
                .attendentdetailsgrid(1, 4) = ds.Tables(0).Rows(0).Item("Attendent_MobileNo")
                .TextBoxpassissue.Text = ds.Tables(0).Rows(0).Item("No_of_issue_pass")
                .passgrid(1, 1) = ds.Tables(0).Rows(0).Item("pass_Name")
                .passgrid(1, 0) = ds.Tables(0).Rows(0).Item("pass_Age")
                .passgrid(1, 2) = ds.Tables(0).Rows(0).Item("pass_Gender")
                .passgrid(1, 3) = ds.Tables(0).Rows(0).Item("pass_Relation")
                .passgrid(1, 4) = ds.Tables(0).Rows(0).Item("pass_mobile")
                If IsDBNull(ds.Tables(0).Rows(0).Item("image")) = True Then

                    MsgBox("no Image")
                Else
                    arrImage = ds.Tables(0).Rows(0).Item("image")
                    '.PictureBox1.Image = ds.Tables(0).Rows(0).Item("image")
                    Dim mstream As New System.IO.MemoryStream(arrImage)
                    .PictureBox1.Image = Image.FromStream(mstream)
                End If
            End If
            Me.Hide()
            From1.Show()
            From1.Focus()
            From1.Panel2.Enabled = False
            From1.Panel3.Enabled = False
            From1.Panel4.Enabled = False
            From1.Panel5.Enabled = False
            From1.Panel6.Enabled = False
            From1.Panel7.Enabled = False
            From1.Panel8.Enabled = False
            From1.Panel9.Enabled = False
            From1.Panel2.Enabled = True
            From1.Panel2.Enabled = True

        End With

    End Sub

    Private Sub IPDsearching_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panelgrid.Hide()
        Me.WindowState = FormWindowState.Maximized
    End Sub


End Class