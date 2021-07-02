Imports System.Data
Imports System.Data.SqlClient
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports DBLibrary
Imports System.IO
Public Class frmPipeLines
    Dim Con As SqlConnection
    Dim ZoomLevel As Integer = 17
    Private Sub frmPipeLines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Con = DB.GetCon()

        gmPipe.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance
        GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly

        gmPipe.Position = New GMap.NET.PointLatLng(38.896221280868872, -76.998373907764062)
        gmPipe.Zoom = ZoomLevel
        Dim dt As DataTable = New DataTable()
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter("SELECT plCode, plId, upstr, dnstr, thickness FROM Pipelines", Con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim lineo
            Dim liner
            Dim markero
            Dim marker

            markero = New GMapOverlay("marker")
            For Each dr As DataRow In dt.Rows
                lineo = New GMapOverlay()
                liner = New GMapRoute("single")

                marker = New GMarkerGoogle(GetLatLng(Integer.Parse(dr.ItemArray(2).ToString())), Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\RedDot.jpg"))

                markero.Markers.Add(marker)
                marker = New GMarkerGoogle(GetLatLng(Integer.Parse(dr.ItemArray(3).ToString())), Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\GreenDot.jpg"))
                markero.Markers.Add(marker)

                'gmPipe.Overlays.Add(markero)
                If Integer.Parse(dr.ItemArray(4).ToString().Trim()) <= 300 Then
                    liner.Stroke = New Pen(Brushes.Blue, 2)
                Else
                    If Integer.Parse(dr.ItemArray(4).ToString().Trim()) <= 600 Then
                        liner.Stroke = New Pen(Brushes.Green, 4)
                    Else
                        liner.Stroke = New Pen(Brushes.Red, 6)
                    End If
                End If

                lineo.Routes.Add(liner)
                gmPipe.Overlays.Add(lineo)

                liner.Points.Add(GetLatLng(Integer.Parse(dr.ItemArray(2).ToString().Trim())))
                liner.Points.Add(GetLatLng(Integer.Parse(dr.ItemArray(3).ToString().Trim())))
                gmPipe.UpdateRouteLocalPosition(liner)
            Next
            gmPipe.Overlays.Add(markero)
            gmPipe.ReloadMap()
            gmPipe.ShowCenter = False
            gmPipe.DragButton = MouseButtons.Left
        Else
            MsgBox("No record")
        End If
    End Sub
    Private Function GetLatLng(mCode As Integer) As GMap.NET.PointLatLng
        Dim dt As DataTable = New DataTable()
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter("SELECT mhLat, mhLng FROM ManholePoints WHERE mhCode=" & mCode, Con)
        da.Fill(dt)
        Return New GMap.NET.PointLatLng(Double.Parse(dt.Rows(0).ItemArray(0).ToString().Trim()), Double.Parse(dt.Rows(0).ItemArray(1).ToString().Trim()))
    End Function

    Private Sub gmPipe_OnRouteClick(item As GMapRoute, e As MouseEventArgs) Handles gmPipe.OnRouteClick

    End Sub

    Private Sub gmPipe_OnMarkerClick(item As GMapMarker, e As MouseEventArgs) Handles gmPipe.OnMarkerClick


    End Sub

    Private Sub gmPipe_OnMarkerEnter(item As GMapMarker) Handles gmPipe.OnMarkerEnter
        Dim dt As DataTable = New DataTable()
        Dim da As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM ManholePoints WHERE mhLat='" & item.Position.Lat.ToString().Trim() & "' AND MhLng='" & item.Position.Lng.ToString().Trim() & "'", Con)
        da.Fill(dt)
        lblLat.Text = item.Position.Lat.ToString()
        lblLng.Text = item.Position.Lng.ToString()

        lblMhId.Text = dt.Rows(0).ItemArray(1).ToString().Trim()
        If Integer.Parse(dt.Rows(0).ItemArray(4).ToString().Trim()) = 0 Then
            lblMhType.Text = "Broad"
        Else
            lblMhType.Text = "Thin"
        End If
        ShowPhoto(Integer.Parse(dt.Rows(0).ItemArray(0).ToString().Trim()))
        ttpMap.SetToolTip(gmPipe, "Lat: " & item.Position.Lat & vbLf & "Lng: " & item.Position.Lng & vbLf & "ID: " & dt.Rows(0).ItemArray(1).ToString().Trim() & vbLf & "Code: " & dt.Rows(0).ItemArray(0).ToString().Trim())
        ttpMap.BackColor = Color.Navy
    End Sub
    Private Sub ShowPhoto(mCode As Integer)

        picPhoto.Image = Nothing
        Me.Cursor = Cursors.WaitCursor
        Dim dt As DataTable = New DataTable
        Dim da As SqlDataAdapter = New SqlDataAdapter("SELECT mhPhoto FROM ManholePoints WHERE mhCode=" & mCode, Con)
        da.Fill(dt)

        Dim buffer() As Byte
        buffer = dt.Rows(0).ItemArray(0)

        Dim ms As MemoryStream
        ms = New MemoryStream(buffer, 0, buffer.Length)

        ms.Write(buffer, 0, buffer.Length)

        Dim im As Image
        im = Image.FromStream(ms, True)
        picPhoto.Image = im
        ms.Close()
        im = Nothing
        Me.Cursor = Cursors.Default
        buffer = Nothing
        dt.Clear()
    End Sub
    Private Sub gmPipe_MouseDown(sender As Object, e As MouseEventArgs) Handles gmPipe.MouseDown

    End Sub

    Private Sub gmPipe_OnMarkerLeave(item As GMapMarker) Handles gmPipe.OnMarkerLeave
        lblLat.Text = "0.00"
        lblLng.Text = "0.00"
        lblMhId.Text = ""
        lblMhType.Text = ""
    End Sub

    Private Sub gmPipe_OnRouteEnter(item As GMapRoute) Handles gmPipe.OnRouteEnter
        'ttpMap.SetToolTip(gmPipe, "Data")
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        ZoomLevel = gmPipe.Zoom
        If ZoomLevel < 18 Then
            ZoomLevel = ZoomLevel + 1
            gmPipe.Zoom = ZoomLevel
        End If

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        ZoomLevel = gmPipe.Zoom
        If ZoomLevel > 2 Then
            ZoomLevel = ZoomLevel - 1
            gmPipe.Zoom = ZoomLevel
        End If
    End Sub
End Class