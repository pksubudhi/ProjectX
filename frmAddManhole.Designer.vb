<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddManhole
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
        Me.gmManhole = New GMap.NET.WindowsForms.GMapControl()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblLat = New System.Windows.Forms.Label()
        Me.lblLng = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'gmManhole
        '
        Me.gmManhole.AutoScroll = True
        Me.gmManhole.Bearing = 0!
        Me.gmManhole.CanDragMap = True
        Me.gmManhole.EmptyTileColor = System.Drawing.Color.Navy
        Me.gmManhole.GrayScaleMode = False
        Me.gmManhole.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.gmManhole.LevelsKeepInMemmory = 5
        Me.gmManhole.Location = New System.Drawing.Point(28, 25)
        Me.gmManhole.MarkersEnabled = True
        Me.gmManhole.MaxZoom = 18
        Me.gmManhole.MinZoom = 2
        Me.gmManhole.MouseWheelZoomEnabled = True
        Me.gmManhole.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.gmManhole.Name = "gmManhole"
        Me.gmManhole.NegativeMode = False
        Me.gmManhole.PolygonsEnabled = True
        Me.gmManhole.RetryLoadTile = 0
        Me.gmManhole.RoutesEnabled = True
        Me.gmManhole.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.gmManhole.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.gmManhole.ShowTileGridLines = False
        Me.gmManhole.Size = New System.Drawing.Size(549, 390)
        Me.gmManhole.TabIndex = 0
        Me.gmManhole.Zoom = 0R
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(597, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 20)
        Me.TextBox1.TabIndex = 1
        '
        'lblLat
        '
        Me.lblLat.AutoSize = True
        Me.lblLat.Location = New System.Drawing.Point(606, 146)
        Me.lblLat.Name = "lblLat"
        Me.lblLat.Size = New System.Drawing.Size(39, 13)
        Me.lblLat.TabIndex = 2
        Me.lblLat.Text = "Label1"
        '
        'lblLng
        '
        Me.lblLng.AutoSize = True
        Me.lblLng.Location = New System.Drawing.Point(606, 175)
        Me.lblLng.Name = "lblLng"
        Me.lblLng.Size = New System.Drawing.Size(39, 13)
        Me.lblLng.TabIndex = 3
        Me.lblLng.Text = "Label2"
        '
        'frmAddManhole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblLng)
        Me.Controls.Add(Me.lblLat)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.gmManhole)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddManhole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Manhole"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gmManhole As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblLat As Label
    Friend WithEvents lblLng As Label
End Class
