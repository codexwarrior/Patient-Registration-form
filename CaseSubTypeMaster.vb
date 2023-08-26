Imports C1.Data.SchemaObjects
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CaseSubTypeMaster


    Dim cmd As New SqlCommand
    Dim connection As New SqlConnection("Data Source=ANJULAP;Initial Catalog=Sparrow1;Integrated Security=True")
        Private da As SqlDataAdapter
    Private ds As Object
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        connection.Open()
        With cmd
            .CommandType = CommandType.Text
            .Connection = connection
            .CommandText = "insert into Case_subType(casesubid,CasesubType)values('" & TextBoxid.Text & "','" & TextBoxtype.Text & "')"
            .ExecuteNonQuery()
            connection.Close()
            MsgBox("Created")

        End With
    End Sub
End Class