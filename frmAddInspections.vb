Imports DBLibrary
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class frmAddInspections
    Dim PhCount As Integer = 0
    Private Sub frmAddInspections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.FillCombo("ManholePoints", "mhId", cmbManhole)
    End Sub
    Private Sub Init()
        cmbManhole.Text = ""
        cmbManhole.SelectedIndex = -1
        txtLead.Clear()
        txtDetail.Clear()
        txtStaff.Clear()
        optGood.Checked = True
        dtpDate.Value = DateTime.Today
        pic2.Image = Nothing
        pic1.Image = Nothing
        pic3.Image = Nothing
    End Sub
    Private Sub txtLead_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStaff.KeyPress, txtLead.KeyPress, txtDetail.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub btnPick_Click(sender As Object, e As EventArgs) Handles btnPick.Click
        On Error GoTo QuitSub

        dlgOpen.ShowDialog()
        If PhCount < 3 Then
            Select Case PhCount
                Case 0
                    pic1.Image = Image.FromFile(dlgOpen.FileName)
                Case 1
                    pic2.Image = Image.FromFile(dlgOpen.FileName)
                Case 2
                    pic3.Image = Image.FromFile(dlgOpen.FileName)
            End Select
            PhCount = PhCount + 1
        Else
            MsgBox("You have already added required photographs! You cannot add more than 3 Photos")
        End If

QuitSub:

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Init()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbManhole.Text.Length > 0 Then


            Dim mc As Integer = DB.GetMax("MIData", "MiCode") + 1
            Dim mhCode As Integer = DB.GetCode("ManholePoints", "mhCode", "mhId", cmbManhole.Text)
            Dim Con As SqlConnection = DB.GetCon()
            Con.Open()
            Dim Cmd As SqlCommand
            Cmd = New SqlCommand("INSERT INTO MIData (MiCode, mhId, MiDate, LeadName, OthStaff, TechDet) VALUES(" & mc & ", " & mhCode & "," & dtpDate.Value.Date.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture) & ", '" & txtLead.Text & "','" & txtStaff.Text & "', '" & txtDetail.Text & "')", Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("Done")
        Else
        End If
    End Sub
    Private Sub SaveImage(mc As Integer, fldName As String, pic As PictureBox)
        Dim buffer() As Byte
        Dim fs As FileStream


        Dim Con As SqlConnection = DB.GetCon()
        Con.Open()
        Dim Cmd As SqlCommand
        Cmd = New SqlCommand("UPDATE MIData SET " & fldName & "=@photo WHERE MiCode=" & mc, Con)
        Cmd.Parameters.AddWithValue("@photo", SqlDbType.VarBinary).Value = buffer
    End Sub
End Class