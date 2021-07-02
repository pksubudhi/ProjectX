<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMapView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gmMain = New GMap.NET.WindowsForms.GMapControl()
        Me.lstLoc = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'gmMain
        '
        Me.gmMain.Bearing = 0!
        Me.gmMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gmMain.CanDragMap = True
        Me.gmMain.EmptyTileColor = System.Drawing.Color.Navy
        Me.gmMain.GrayScaleMode = False
        Me.gmMain.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.gmMain.LevelsKeepInMemmory = 5
        Me.gmMain.Location = New System.Drawing.Point(239, 12)
        Me.gmMain.MarkersEnabled = True
        Me.gmMain.MaxZoom = 18
        Me.gmMain.MinZoom = 2
        Me.gmMain.MouseWheelZoomEnabled = True
        Me.gmMain.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.gmMain.Name = "gmMain"
        Me.gmMain.NegativeMode = False
        Me.gmMain.PolygonsEnabled = True
        Me.gmMain.RetryLoadTile = 0
        Me.gmMain.RoutesEnabled = True
        Me.gmMain.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.gmMain.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.gmMain.ShowTileGridLines = False
        Me.gmMain.Size = New System.Drawing.Size(537, 411)
        Me.gmMain.TabIndex = 0
        Me.gmMain.Zoom = 13.0R
        '
        'lstLoc
        '
        Me.lstLoc.FormattingEnabled = True
        Me.lstLoc.Location = New System.Drawing.Point(24, 45)
        Me.lstLoc.Name = "lstLoc"
        Me.lstLoc.Size = New System.Drawing.Size(176, 342)
        Me.lstLoc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select location"
        '
        'frmMapView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstLoc)
        Me.Controls.Add(Me.gmMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMapView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMapView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gmMain As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents lstLoc As ListBox
    Friend WithEvents Label1 As Label
End Class
