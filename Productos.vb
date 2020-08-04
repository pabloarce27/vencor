
Imports System.Net
Imports System.IO
Imports System.Text

Public Class Productos
    Public Property Response As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub TBPrueba_TextChanged(sender As Object, e As EventArgs) Handles TBPrueba.TextChanged
        Try
            Dim snh As System.Net.HttpWebRequest
            Dim url As New Uri("https://vencor.store/api/tipos-productos")
            snh = DirectCast(HttpWebRequest.Create(url), System.Net.HttpWebRequest)
            If (snh.GetResponse().ContentLength > 0) Then

                Dim str As New System.IO.StreamReader(snh.GetResponse().GetResponseStream())
                Response.write(str.ReadToEnd())
                str.Close()
                MsgBox(str)
            End If
        Catch ex As Exception
            'error
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Dim webClient As System.Net.HttpWebRequest
        ' Dim result As String = webClient.DownloadString("https://vencor.store/api/tipos-productos")
        ' ComboBox1.Text = result
    End Sub
End Class