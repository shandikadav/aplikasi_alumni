Imports System.Data.SqlClient
Public Class pendaftaran_alumni
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Menu_utama.Show()
        Me.Hide()
    End Sub

    Private Sub pendaftaran_alumni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        databaru = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pesan, simpan As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Data belum lengkap!", vbExclamation)
            Exit Sub
        Else
            If databaru Then
                pesan = MsgBox("Apakah Anda ingin menyimpan Data ini?", vbYesNo + vbInformation)
                If pesan = vbNo Then
                    Exit Sub
                End If
                simpan = "INSERT INTO formulir VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "')"
                jalankansql(simpan)
                TextBox1.Focus()
                konfirmasi_pendaftaran.Label6.Text = TextBox2.Text
                konfirmasi_pendaftaran.Label7.Text = TextBox1.Text
                konfirmasi_pendaftaran.Show()
                Me.Hide()

            End If
        End If
    End Sub
End Class