Imports System.Data.SqlClient

Public Class UnderDoctorMaster
    Dim cmd As New SqlCommand
    Dim connection As New SqlConnection("Data Source=ANJULAP;Initial Catalog=Sparrow1;Integrated Security=True")
    Private da As SqlDataAdapter
    Private ds As Object
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = ""
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        str = "select * from  UnderDoctor where UnderDoctorType = '" & TextBox2.Text & "'"
        da = New SqlDataAdapter(str, connection)
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            TextBox2.Text = ds.Tables(0).Rows(0).Item("UnderDoctorType")
            TextBox1.Text = ds.Tables(0).Rows(0).Item("UnderDoctorid")
        End If
        connection.Open()
        With cmd
            .CommandType = CommandType.Text
            .Connection = connection
            .CommandText = "insert into UnderDoctor(UnderDoctorid,UnderDoctorType)values('" & TextBox1.Text & "','" & TextBox2.Text & "')"
            .ExecuteNonQuery()
            connection.Close()
            MsgBox("Created")
        End With
    End Sub
End Class