Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET

Public Class frmAddManhole
    Dim markero = Nothing
    Dim marker
    Private Sub frmAddManhole_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        gmManhole.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance
        GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly
        'gmMain.SetPositionByKeywords("Mumbai, India")
        gmManhole.Position = New GMap.NET.PointLatLng(38.89354200702568, -77.036612423591791)
        gmManhole.Zoom = 8
        gmManhole.DragButton = MouseButtons.Left
        gmManhole.ShowCenter = False
        gmManhole.ReloadMap()
    End Sub

    Private Sub gmManhole_MouseDown(sender As Object, e As MouseEventArgs) Handles gmManhole.MouseDown

        If markero IsNot Nothing Then
            'gmManhole.Overlays.Remove(markero)
        End If
        markero = New GMapOverlay("marker")
        Dim Lat As Double
        Dim Lng As Double
        Lat = gmManhole.FromLocalToLatLng(e.X, e.Y).Lat
        Lng = gmManhole.FromLocalToLatLng(e.X, e.Y).Lng
        marker = New GMarkerGoogle(New PointLatLng(Lat, Lng), Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\RedDot.jpg"))
        markero.Markers.Add(marker)
        gmManhole.Overlays.Add(markero)

        lblLat.Text = Lat.ToString
        lblLng.Text = Lng.ToString
        gmManhole.Refresh()
        gmManhole.ReloadMap()
        'gmManhole.Overlays.Remove(markero)
    End Sub
End Class