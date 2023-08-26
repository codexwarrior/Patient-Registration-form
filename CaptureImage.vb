'Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports Emgu.CV
Imports Emgu.Util
Public Class CaptureImage
    Dim captureimg As New Capture
    Dim cmd As New SqlCommand
    Dim connection As New SqlConnection("Data Source=ANJULAP;Initial Catalog=Sparrow1;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        captureimg.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            PictureBox1.Image = captureimg.QueryFrame.Bitmap
            From1.PictureBox1.Image = PictureBox1.Image
        Catch ex As Exception
            captureimg = New Capture
        End Try
    End Sub

    Private Sub CaptureImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'From1.PictureBox1.Image = PictureBox1.Image

        Me.Close()
    End Sub


End Class