Imports System.Data
Imports System.Data.SqlClient
Imports DBLibrary
Public Class frmMain
    Dim Con As SqlConnection
    Private Sub btnMap_Click(sender As Object, e As EventArgs) Handles btnMap.Click
        frmMapView.ShowDialog(Me)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Con.Open()
        Dim Cmd As SqlCommand
        Cmd = New SqlCommand()
        Cmd.Connection = Con
        Cmd.CommandText = "CreateDB"
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.ExecuteNonQuery()
        Con.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.ConStr = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjectXDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        Con = DB.GetCon()
    End Sub

    Private Sub btnPipeLines_Click(sender As Object, e As EventArgs) Handles btnPipeLines.Click
        frmPipeLines.ShowDialog(Me)

    End Sub

    Private Sub btnSetImage_Click(sender As Object, e As EventArgs) Handles btnSetImage.Click
        frmSetImage.ShowDialog(Me)
    End Sub

    Private Sub btnNewManhole_Click(sender As Object, e As EventArgs) Handles btnNewManhole.Click
        frmAddManhole.ShowDialog(Me)
    End Sub

    Private Sub btnInspRec_Click(sender As Object, e As EventArgs) Handles btnInspRec.Click
        frmAddInspections.ShowDialog(Me)
    End Sub
End Class
