<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPipeLines
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
        Me.components = New System.ComponentModel.Container()
        Me.gmPipe = New GMap.NET.WindowsForms.GMapControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLat = New System.Windows.Forms.Label()
        Me.lblLng = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMhId = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMhType = New System.Windows.Forms.Label()
        Me.ttpMap = New System.Windows.Forms.ToolTip(Me.components)
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gmPipe
        '
        Me.gmPipe.AutoScroll = True
        Me.gmPipe.Bearing = 0!
        Me.gmPipe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gmPipe.CanDragMap = True
        Me.gmPipe.EmptyTileColor = System.Drawing.Color.Navy
        Me.gmPipe.GrayScaleMode = False
        Me.gmPipe.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.gmPipe.LevelsKeepInMemmory = 5
        Me.gmPipe.Location = New System.Drawing.Point(41, 29)
        Me.gmPipe.MarkersEnabled = True
        Me.gmPipe.MaxZoom = 18
        Me.gmPipe.MinZoom = 2
        Me.gmPipe.MouseWheelZoomEnabled = True
        Me.gmPipe.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.gmPipe.Name = "gmPipe"
        Me.gmPipe.NegativeMode = False
        Me.gmPipe.PolygonsEnabled = True
        Me.gmPipe.RetryLoadTile = 0
        Me.gmPipe.RoutesEnabled = True
        Me.gmPipe.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.gmPipe.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.gmPipe.ShowTileGridLines = False
        Me.gmPipe.Size = New System.Drawing.Size(725, 378)
        Me.gmPipe.TabIndex = 0
        Me.gmPipe.Zoom = 12.0R
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(790, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Latitude"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(790, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Longitude"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLat
        '
        Me.lblLat.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblLat.ForeColor = System.Drawing.Color.Navy
        Me.lblLat.Location = New System.Drawing.Point(790, 52)
        Me.lblLat.Name = "lblLat"
        Me.lblLat.Size = New System.Drawing.Size(179, 19)
        Me.lblLat.TabIndex = 3
        Me.lblLat.Text = "0.00"
        Me.lblLat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLng
        '
        Me.lblLng.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblLng.ForeColor = System.Drawing.Color.Navy
        Me.lblLng.Location = New System.Drawing.Point(790, 98)
        Me.lblLng.Name = "lblLng"
        Me.lblLng.Size = New System.Drawing.Size(179, 19)
        Me.lblLng.TabIndex = 4
        Me.lblLng.Text = "0.00"
        Me.lblLng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Navy
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(790, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Manhole ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMhId
        '
        Me.lblMhId.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblMhId.ForeColor = System.Drawing.Color.Navy
        Me.lblMhId.Location = New System.Drawing.Point(790, 144)
        Me.lblMhId.Name = "lblMhId"
        Me.lblMhId.Size = New System.Drawing.Size(179, 19)
        Me.lblMhId.TabIndex = 6
        Me.lblMhId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Navy
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(790, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Type"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMhType
        '
        Me.lblMhType.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblMhType.ForeColor = System.Drawing.Color.Navy
        Me.lblMhType.Location = New System.Drawing.Point(790, 190)
        Me.lblMhType.Name = "lblMhType"
        Me.lblMhType.Size = New System.Drawing.Size(179, 19)
        Me.lblMhType.TabIndex = 8
        Me.lblMhType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ttpMap
        '
        Me.ttpMap.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ttpMap.ForeColor = System.Drawing.Color.White
        Me.ttpMap.IsBalloon = True
        Me.ttpMap.OwnerDraw = True
        Me.ttpMap.ShowAlways = True
        Me.ttpMap.StripAmpersands = True
        Me.ttpMap.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttpMap.ToolTipTitle = "Info."
        '
        'picPhoto
        '
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Location = New System.Drawing.Point(790, 289)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(179, 118)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 9
        Me.picPhoto.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(790, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Photograph"
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(726, 352)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(22, 23)
        Me.btnPlus.TabIndex = 11
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(726, 378)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(22, 23)
        Me.btnMinus.TabIndex = 12
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'frmPipeLines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 450)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.picPhoto)
        Me.Controls.Add(Me.lblMhType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblMhId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLng)
        Me.Controls.Add(Me.lblLat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gmPipe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPipeLines"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pipe lines"
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gmPipe As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLat As Label
    Friend WithEvents lblLng As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMhId As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblMhType As Label
    Friend WithEvents ttpMap As ToolTip
    Friend WithEvents picPhoto As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
End Class
