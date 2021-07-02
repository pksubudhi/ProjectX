Imports GMap.NET.WindowsForms
Imports System.Data
Imports System.Data.SqlClient
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports DBLibrary
Public Class frmMapView
    Dim Con As SqlConnection
    Private Sub frmMapView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Con = DB.GetCon()
        DB.FillList("LocData", "LocDesc", lstLoc)

        If lstLoc.Items.Count > 0 Then
            lstLoc.SelectedIndex = 0
            ShowMap()
        End If


    End Sub

    Private Sub ShowMap()
        Dim lat, lng As Double

        Dim ds As DataSet = New DataSet()
        Dim da As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM LocData WHERE LocDesc='" & lstLoc.SelectedItem.ToString & "'", Con)
        da.Fill(ds, "co")
        lat = Double.Parse(ds.Tables("co").Rows(0).ItemArray(2).ToString())
        lng = Double.Parse(ds.Tables("co").Rows(0).ItemArray(3).ToString())

        gmMain.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance
        GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly
        'gmMain.SetPositionByKeywords("Mumbai, India")
        gmMain.Position = New GMap.NET.PointLatLng(38.89354200702568, -77.036612423591791)
        gmMain.Zoom = 16

        Dim lineo = New GMapOverlay()
        Dim liner = New GMapRoute("single")
        liner.Stroke = New Pen(Brushes.Red, 4)
        lineo.Routes.Add(liner)
        gmMain.Overlays.Add(lineo)
        liner.Points.Add(New GMap.NET.PointLatLng(38.892130978230632, -77.039480235107945))
        liner.Points.Add(New GMap.NET.PointLatLng(38.892081325437573, -77.032029091618909))
        gmMain.UpdateRouteLocalPosition(liner)

        gmMain.DragButton = MouseButtons.Left
        gmMain.ShowCenter = False
        gmMain.ReloadMap()

    End Sub

    Private Sub lstLoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLoc.SelectedIndexChanged
        If lstLoc.SelectedIndex >= 0 Then

            ShowMap()
        End If
    End Sub

    Private Sub gmMain_DoubleClick(sender As Object, e As EventArgs) Handles gmMain.DoubleClick

    End Sub

    Private Sub gmMain_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles gmMain.MouseDoubleClick
        Dim pt As GMap.NET.PointLatLng
        pt = gmMain.FromLocalToLatLng(e.X, e.Y)
        gmMain.Position = pt

        If e.Button = MouseButtons.Left Then
            gmMain.Zoom += 1
        End If
        If e.Button = MouseButtons.Right Then
            gmMain.Zoom -= 1
        End If
    End Sub

    Private Sub gmMain_OnMarkerClick(item As GMapMarker, e As MouseEventArgs) Handles gmMain.OnMarkerClick
        MsgBox("Marker Clicked")
    End Sub

    Private Sub gmMain_MouseDown(sender As Object, e As MouseEventArgs) Handles gmMain.MouseDown

    End Sub
End Class