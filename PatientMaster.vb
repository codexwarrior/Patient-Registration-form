﻿Imports C1.Data.SchemaObjects
Imports System.Data.SqlClient

Public Class PatientMaster
    Dim cmd As New SqlCommand
    Dim connection As New SqlConnection("Data Source=ANJULAP;Initial Catalog=Sparrow1;Integrated Security=True")
    Private da As SqlDataAdapter
    Private ds As Object
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        connection.Open()
        With cmd
            .CommandType = CommandType.Text
            .Connection = connection
            .CommandText = "insert into Patient_Type(Patientid,PatientType)values('" & TextBoxid.Text & "','" & TextBoxType.Text & "')"
            .ExecuteNonQuery()
            connection.Close()
            MsgBox("Created")

        End With
    End Sub
End Class