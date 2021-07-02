Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports DBLibrary
Public Class frmSetImage
    Dim Con As SqlConnection
    Private Sub btnCap_Click(sender As Object, e As EventArgs) Handles btnCap.Click
        On Error GoTo QuitSub
        dlgOpen.ShowDialog()
        picPhoto.Image = Image.FromFile(dlgOpen.FileName)
QuitSub:
    End Sub

    Private Sub frmSetImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Con = DB.GetCon()
        DB.FillList("ManholePoints", "mhCode", lstCode)
        DB.FillList("ManholePoints", "mhID", lstManhole)

    End Sub


    Private Sub lstManhole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstManhole.SelectedIndexChanged
        If lstManhole.SelectedIndex >= 0 Then
            lblCode.Text = lstCode.Items(lstManhole.SelectedIndex).ToString()
            lblID.Text = lstManhole.SelectedItem.ToString()
        End If
    End Sub

    Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click
        lstManhole.SelectedIndex = -1
        lblID.Text = ""
        lblCode.Text = ""
        picPhoto.Image = Nothing

    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click

        If lblCode.Text.Length > 0 Then
            Me.Cursor = Cursors.WaitCursor
            Dim fs As FileStream
            fs = New FileStream(dlgOpen.FileName, FileMode.Open, FileAccess.Read)

            Dim br As BinaryReader
            br = New BinaryReader(fs)

            Dim buffer() As Byte
            buffer = br.ReadBytes(fs.Length)

            Con.Open()
            Dim Cmd As SqlCommand
            Cmd = New SqlCommand("UPDATE ManholePoints SET mhPhoto=@PhData WHERE mhCode=" & lblCode.Text, Con)
            Cmd.Parameters.Add("@PhData", SqlDbType.VarBinary).Value = buffer
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("Photo Saved!")
            lstManhole.SelectedIndex = -1
            lblID.Text = ""
            lblCode.Text = ""
            picPhoto.Image = Nothing
            Me.Cursor = Cursors.Default
        Else
            MsgBox("No Manhole point selected yet!")
        End If
    End Sub
End Class