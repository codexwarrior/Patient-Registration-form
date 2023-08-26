Imports System.Data.SqlClient

Public Class WardbedMaster
    Dim cmd As New SqlCommand
    Dim connection As New SqlConnection("Data Source=ANJULAP;Initial Catalog=Sparrow1;Integrated Security=True")
    Private da As SqlDataAdapter
    Private ds As Object
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection.Open()
        With cmd
            .CommandType = CommandType.Text
            .Connection = connection
            .CommandText = "insert into WardBedType(BedNo,BedID,WardTypeiD,Floorid) values('" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox2.Text & "','" & TextBox1.Text & "')"
            .ExecuteNonQuery()
            connection.Close()
            MsgBox("Created")
            TextBox3.Clear()
            TextBox3.Focus()
        End With
    End Sub

    Private Sub ComboBox1_GotFocus(sender As Object, e As EventArgs) Handles ComboBox1.GotFocus
        Try
            ComboBox1.Items.Clear()
            da = New SqlDataAdapter("select WardType from WardType order by WardType", connection)
            ds = New DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    ComboBox1.Items.Add(ds.Tables(0).Rows(i).Item(0))
                Next
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox2_GotFocus(sender As Object, e As EventArgs) Handles ComboBox2.GotFocus
        Try
            ComboBox2.Items.Clear()
            da = New SqlDataAdapter("select Floorno from FloorNo order by Floorno", connection)
            ds = New DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    ComboBox2.Items.Add(ds.Tables(0).Rows(i).Item(0))
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim str As String = ""
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet


        str = "select * from WardType where WardType= '" & ComboBox1.Text & "'"
        da = New SqlDataAdapter(str, connection)
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then

            ComboBox1.Text = ds.Tables(0).Rows(0).Item("WardType")
            TextBox1.Text = ds.Tables(0).Rows(0).Item("WardTypeid")

        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim str As String = ""
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        str = "select * from FloorNo where Floorno= '" & ComboBox2.Text & "'"

        da = New SqlDataAdapter(str, connection)
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            ComboBox2.Text = ds.Tables(0).Rows(0).Item("Floorno")
            TextBox2.Text = ds.Tables(0).Rows(0).Item("Floorid")

        End If
    End Sub

End Class
