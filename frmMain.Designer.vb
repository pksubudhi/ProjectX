<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnMap = New System.Windows.Forms.Button()
        Me.btnChart = New System.Windows.Forms.Button()
        Me.btnData = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnPipeLines = New System.Windows.Forms.Button()
        Me.btnSetImage = New System.Windows.Forms.Button()
        Me.btnNewManhole = New System.Windows.Forms.Button()
        Me.btnInspRec = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMap
        '
        Me.btnMap.Location = New System.Drawing.Point(608, 23)
        Me.btnMap.Name = "btnMap"
        Me.btnMap.Size = New System.Drawing.Size(167, 76)
        Me.btnMap.TabIndex = 0
        Me.btnMap.Text = "Map View"
        Me.btnMap.UseVisualStyleBackColor = True
        '
        'btnChart
        '
        Me.btnChart.Location = New System.Drawing.Point(608, 105)
        Me.btnChart.Name = "btnChart"
        Me.btnChart.Size = New System.Drawing.Size(167, 76)
        Me.btnChart.TabIndex = 1
        Me.btnChart.Text = "Chart View"
        Me.btnChart.UseVisualStyleBackColor = True
        '
        'btnData
        '
        Me.btnData.Location = New System.Drawing.Point(608, 187)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(167, 76)
        Me.btnData.TabIndex = 2
        Me.btnData.Text = "Data View"
        Me.btnData.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(32, 23)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(192, 23)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh Database"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnPipeLines
        '
        Me.btnPipeLines.Location = New System.Drawing.Point(608, 269)
        Me.btnPipeLines.Name = "btnPipeLines"
        Me.btnPipeLines.Size = New System.Drawing.Size(167, 76)
        Me.btnPipeLines.TabIndex = 4
        Me.btnPipeLines.Text = "Pipe Lines"
        Me.btnPipeLines.UseVisualStyleBackColor = True
        '
        'btnSetImage
        '
        Me.btnSetImage.Location = New System.Drawing.Point(33, 269)
        Me.btnSetImage.Name = "btnSetImage"
        Me.btnSetImage.Size = New System.Drawing.Size(167, 76)
        Me.btnSetImage.TabIndex = 5
        Me.btnSetImage.Text = "Set Manhole Images"
        Me.btnSetImage.UseVisualStyleBackColor = True
        '
        'btnNewManhole
        '
        Me.btnNewManhole.Location = New System.Drawing.Point(33, 187)
        Me.btnNewManhole.Name = "btnNewManhole"
        Me.btnNewManhole.Size = New System.Drawing.Size(167, 76)
        Me.btnNewManhole.TabIndex = 6
        Me.btnNewManhole.Text = "Add Manhole"
        Me.btnNewManhole.UseVisualStyleBackColor = True
        '
        'btnInspRec
        '
        Me.btnInspRec.Location = New System.Drawing.Point(33, 105)
        Me.btnInspRec.Name = "btnInspRec"
        Me.btnInspRec.Size = New System.Drawing.Size(167, 76)
        Me.btnInspRec.TabIndex = 7
        Me.btnInspRec.Text = "Inspection Record"
        Me.btnInspRec.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnInspRec)
        Me.Controls.Add(Me.btnNewManhole)
        Me.Controls.Add(Me.btnSetImage)
        Me.Controls.Add(Me.btnPipeLines)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnData)
        Me.Controls.Add(Me.btnChart)
        Me.Controls.Add(Me.btnMap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProjectX (Home Page)"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMap As Button
    Friend WithEvents btnChart As Button
    Friend WithEvents btnData As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnPipeLines As Button
    Friend WithEvents btnSetImage As Button
    Friend WithEvents btnNewManhole As Button
    Friend WithEvents btnInspRec As Button
End Class
