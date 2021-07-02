<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetImage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstManhole = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.btnAbort = New System.Windows.Forms.Button()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.btnCap = New System.Windows.Forms.Button()
        Me.lstCode = New System.Windows.Forms.ListBox()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manhole List (Location ID)"
        '
        'lstManhole
        '
        Me.lstManhole.FormattingEnabled = True
        Me.lstManhole.Location = New System.Drawing.Point(29, 34)
        Me.lstManhole.Name = "lstManhole"
        Me.lstManhole.Size = New System.Drawing.Size(145, 251)
        Me.lstManhole.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(180, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Manhole Code"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCode
        '
        Me.lblCode.BackColor = System.Drawing.Color.SteelBlue
        Me.lblCode.ForeColor = System.Drawing.Color.White
        Me.lblCode.Location = New System.Drawing.Point(286, 34)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(145, 19)
        Me.lblCode.TabIndex = 3
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LimeGreen
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(180, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ID"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.SkyBlue
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(286, 57)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(145, 19)
        Me.lblID.TabIndex = 5
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(180, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Photograph"
        '
        'picPhoto
        '
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Location = New System.Drawing.Point(180, 120)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(251, 165)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 7
        Me.picPhoto.TabStop = False
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(437, 262)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(75, 23)
        Me.btnSet.TabIndex = 8
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'btnAbort
        '
        Me.btnAbort.Location = New System.Drawing.Point(437, 233)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(75, 23)
        Me.btnAbort.TabIndex = 9
        Me.btnAbort.Text = "Abort"
        Me.btnAbort.UseVisualStyleBackColor = True
        '
        'dlgOpen
        '
        Me.dlgOpen.FileName = "*.jpg"
        Me.dlgOpen.Filter = "Photographs|*.jpg; *.bmp; *.png"
        '
        'btnCap
        '
        Me.btnCap.Location = New System.Drawing.Point(437, 120)
        Me.btnCap.Name = "btnCap"
        Me.btnCap.Size = New System.Drawing.Size(75, 23)
        Me.btnCap.TabIndex = 10
        Me.btnCap.Text = "Capture"
        Me.btnCap.UseVisualStyleBackColor = True
        '
        'lstCode
        '
        Me.lstCode.FormattingEnabled = True
        Me.lstCode.Location = New System.Drawing.Point(29, 371)
        Me.lstCode.Name = "lstCode"
        Me.lstCode.Size = New System.Drawing.Size(120, 56)
        Me.lstCode.TabIndex = 11
        Me.lstCode.Visible = False
        '
        'frmSetImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 319)
        Me.Controls.Add(Me.lstCode)
        Me.Controls.Add(Me.btnCap)
        Me.Controls.Add(Me.btnAbort)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.picPhoto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstManhole)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetImage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Manhole Image"
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstManhole As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents picPhoto As PictureBox
    Friend WithEvents btnSet As Button
    Friend WithEvents btnAbort As Button
    Friend WithEvents dlgOpen As OpenFileDialog
    Friend WithEvents btnCap As Button
    Friend WithEvents lstCode As ListBox
End Class
