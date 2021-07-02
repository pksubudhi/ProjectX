<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddInspections
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLead = New System.Windows.Forms.TextBox()
        Me.txtStaff = New System.Windows.Forms.TextBox()
        Me.txtDetail = New System.Windows.Forms.TextBox()
        Me.optGood = New System.Windows.Forms.RadioButton()
        Me.optAvg = New System.Windows.Forms.RadioButton()
        Me.optBad = New System.Windows.Forms.RadioButton()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbManhole = New System.Windows.Forms.ComboBox()
        Me.btnFromMap = New System.Windows.Forms.Button()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.btnPick = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.ForestGreen
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Manhole"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.ForestGreen
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(42, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Inspection Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.ForestGreen
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(42, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lead Staff"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.ForestGreen
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(42, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Other Staff"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(411, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Photographs (Not more than 3)"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.ForestGreen
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(42, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Maintenance Detail"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.ForestGreen
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(42, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Rate your job"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLead
        '
        Me.txtLead.Location = New System.Drawing.Point(148, 89)
        Me.txtLead.MaxLength = 50
        Me.txtLead.Name = "txtLead"
        Me.txtLead.Size = New System.Drawing.Size(247, 20)
        Me.txtLead.TabIndex = 2
        '
        'txtStaff
        '
        Me.txtStaff.Location = New System.Drawing.Point(148, 115)
        Me.txtStaff.MaxLength = 200
        Me.txtStaff.Multiline = True
        Me.txtStaff.Name = "txtStaff"
        Me.txtStaff.Size = New System.Drawing.Size(247, 84)
        Me.txtStaff.TabIndex = 3
        '
        'txtDetail
        '
        Me.txtDetail.Location = New System.Drawing.Point(148, 205)
        Me.txtDetail.MaxLength = 200
        Me.txtDetail.Multiline = True
        Me.txtDetail.Name = "txtDetail"
        Me.txtDetail.Size = New System.Drawing.Size(247, 86)
        Me.txtDetail.TabIndex = 4
        '
        'optGood
        '
        Me.optGood.AutoSize = True
        Me.optGood.Checked = True
        Me.optGood.Location = New System.Drawing.Point(148, 297)
        Me.optGood.Name = "optGood"
        Me.optGood.Size = New System.Drawing.Size(51, 17)
        Me.optGood.TabIndex = 10
        Me.optGood.TabStop = True
        Me.optGood.Text = "Good"
        Me.optGood.UseVisualStyleBackColor = True
        '
        'optAvg
        '
        Me.optAvg.AutoSize = True
        Me.optAvg.Location = New System.Drawing.Point(220, 297)
        Me.optAvg.Name = "optAvg"
        Me.optAvg.Size = New System.Drawing.Size(65, 17)
        Me.optAvg.TabIndex = 11
        Me.optAvg.Text = "Average"
        Me.optAvg.UseVisualStyleBackColor = True
        '
        'optBad
        '
        Me.optBad.AutoSize = True
        Me.optBad.Location = New System.Drawing.Point(304, 297)
        Me.optBad.Name = "optBad"
        Me.optBad.Size = New System.Drawing.Size(44, 17)
        Me.optBad.TabIndex = 12
        Me.optBad.Text = "Bad"
        Me.optBad.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(148, 63)
        Me.dtpDate.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(166, 20)
        Me.dtpDate.TabIndex = 1
        '
        'cmbManhole
        '
        Me.cmbManhole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbManhole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbManhole.FormattingEnabled = True
        Me.cmbManhole.Location = New System.Drawing.Point(148, 36)
        Me.cmbManhole.Name = "cmbManhole"
        Me.cmbManhole.Size = New System.Drawing.Size(166, 21)
        Me.cmbManhole.TabIndex = 0
        '
        'btnFromMap
        '
        Me.btnFromMap.Location = New System.Drawing.Point(320, 34)
        Me.btnFromMap.Name = "btnFromMap"
        Me.btnFromMap.Size = New System.Drawing.Size(75, 49)
        Me.btnFromMap.TabIndex = 8
        Me.btnFromMap.Text = "Pick from Map"
        Me.btnFromMap.UseVisualStyleBackColor = True
        '
        'pic1
        '
        Me.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic1.Location = New System.Drawing.Point(414, 50)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(170, 84)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 16
        Me.pic1.TabStop = False
        '
        'pic2
        '
        Me.pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic2.Location = New System.Drawing.Point(414, 140)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(170, 84)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 17
        Me.pic2.TabStop = False
        '
        'pic3
        '
        Me.pic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic3.Location = New System.Drawing.Point(414, 230)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(170, 84)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 18
        Me.pic3.TabStop = False
        '
        'btnPick
        '
        Me.btnPick.Location = New System.Drawing.Point(602, 50)
        Me.btnPick.Name = "btnPick"
        Me.btnPick.Size = New System.Drawing.Size(75, 23)
        Me.btnPick.TabIndex = 5
        Me.btnPick.Text = "Pick Photo"
        Me.btnPick.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(602, 291)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(602, 262)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dlgOpen
        '
        Me.dlgOpen.FileName = "OpenFileDialog1"
        '
        'frmAddInspections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 343)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPick)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.btnFromMap)
        Me.Controls.Add(Me.cmbManhole)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.optBad)
        Me.Controls.Add(Me.optAvg)
        Me.Controls.Add(Me.optGood)
        Me.Controls.Add(Me.txtDetail)
        Me.Controls.Add(Me.txtStaff)
        Me.Controls.Add(Me.txtLead)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddInspections"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Inspection Data"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLead As TextBox
    Friend WithEvents txtStaff As TextBox
    Friend WithEvents txtDetail As TextBox
    Friend WithEvents optGood As RadioButton
    Friend WithEvents optAvg As RadioButton
    Friend WithEvents optBad As RadioButton
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cmbManhole As ComboBox
    Friend WithEvents btnFromMap As Button
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents pic3 As PictureBox
    Friend WithEvents btnPick As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dlgOpen As OpenFileDialog
End Class
