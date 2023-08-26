Imports C1.Data.SchemaObjects
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CityMaster
    Dim cmd As New SqlCommand
    Dim connection As New SqlConnection("Data Source=ANJULAP;Initial Catalog=Sparrow1;Integrated Security=True")
    Private da As SqlDataAdapter
    Private ds As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = ""
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        str = "select * from state_list where StateName = '" & ComboBoxState.Text & "'"
        da = New SqlDataAdapter(str, connection)
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            ComboBoxState.Text = ds.Tables(0).Rows(0).Item("StateName")
            TextBoxStateID.Text = ds.Tables(0).Rows(0).Item("stateID")
        End If
        connection.Open()

        With cmd
            .CommandType = CommandType.Text
            .Connection = connection
            .CommandText = "insert into City(cityname,CityId,StateID)values('" & TextBoxCity.Text & "','" & TextBoxCityID.Text & "','" & TextBoxStateID.Text & "')"
            .ExecuteNonQuery()
            connection.Close()
            MsgBox("Created")

        End With
    End Sub

    Private Sub ComboBoxState_GotFocus(sender As Object, e As EventArgs) Handles ComboBoxState.GotFocus
        Try
            ComboBoxState.Items.Clear()
            da = New SqlDataAdapter("select stateName from state_list order by stateName", connection)
            ds = New DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    ComboBoxState.Items.Add(ds.Tables(0).Rows(i).Item(0))
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class