Imports System.Data.SqlClient
Public Class konfirmasi_pendaftaran
    Dim databaru As Boolean
    Private Sub jalankansql(ByVal sql As String)
        Dim sqlcmd As New SqlCommand
        Try
            konekdb()
            sqlcmd.Connection = konek
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.CommandText = sql
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            konek.Close()
        Catch ex As Exception
            MsgBox("error" & ex.Message)
        End Try
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim simpan As String
        simpan = "INSERT INTO login VALUES('" & Label6.Text & "','" & Label7.Text & "','" & Label8.Text & "')"
        jalankansql(simpan)
                Menu_utama.Show()
        Me.Hide()
    End Sub

    Private Sub konfirmasi_pendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        databaru = True
    End Sub
End Class