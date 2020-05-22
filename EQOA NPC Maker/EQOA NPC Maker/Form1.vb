Imports System.IO

Public Class Form1
    Private NPCFile As NPCFile001

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NPCFile = New NPCFile001
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        CreateFile()
    End Sub

    Private Sub CreateFile()
        If TextBox1.Text IsNot "" And _
            TextBox2.Text IsNot "" Then

            Dim line, file As String
            Dim sw As New IO.StreamWriter(file)
            sw.WriteLine(line)
            sw.Close()
        End If

    End Sub

End Class
