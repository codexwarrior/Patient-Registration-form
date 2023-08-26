Imports C1.Data.SchemaObjects
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles

Public Class CaseTypeMaster
    Dim cmd As New SqlCommand
    Dim connection As New SqlConnection("Data Source=ANJULAP;Initial Catalog=Sparrow1;Integrated Security=True")
    Private da As SqlDataAdapter
    Private ds As Object
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click

        connection.Open()

        With cmd
            .CommandType = CommandType.Text
            .Connection = connection
            .CommandText = "insert into Case_Type(CaseID,CaseType)values('" & TextBoxid.Text & "','" & TextBoxType.Text & "')"
            .ExecuteNonQuery()
            connection.Close()
            MsgBox("Created")

        End With
    End Sub


End Class