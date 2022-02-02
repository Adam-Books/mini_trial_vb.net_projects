Imports System.Data.SqlClient

Public Class form1

    Private Sub form1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox("hello", vbInformation, "title1")

    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn1 As New SqlConnection("datasource=DESKTOP-PP771IQ\SQLEXPRESS01;initial catalog=db001;integrated security=true")
        conn1.Open()
        Dim sqlcommand1 As New SqlCommand("select * from table_1")
        sqlcommand1.Connection = conn1



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)





    End Sub
End Class
