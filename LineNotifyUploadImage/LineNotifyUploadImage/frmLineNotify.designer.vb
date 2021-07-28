<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLineNotify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLineNotify))
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.picData = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDeleteImg = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        CType(Me.picData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(83, 16)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessage.Size = New System.Drawing.Size(309, 186)
        Me.txtMessage.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Message"
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(412, 63)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(121, 39)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Exit Program"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSend.Image = CType(resources.GetObject("btnSend.Image"), System.Drawing.Image)
        Me.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSend.Location = New System.Drawing.Point(412, 16)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(121, 39)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send Data"
        Me.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'picData
        '
        Me.picData.BackColor = System.Drawing.Color.Gainsboro
        Me.picData.Image = CType(resources.GetObject("picData.Image"), System.Drawing.Image)
        Me.picData.Location = New System.Drawing.Point(83, 209)
        Me.picData.Name = "picData"
        Me.picData.Size = New System.Drawing.Size(309, 340)
        Me.picData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picData.TabIndex = 12
        Me.picData.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 14)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Image"
        '
        'btnDeleteImg
        '
        Me.btnDeleteImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteImg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDeleteImg.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnDeleteImg.Location = New System.Drawing.Point(293, 555)
        Me.btnDeleteImg.Name = "btnDeleteImg"
        Me.btnDeleteImg.Size = New System.Drawing.Size(99, 26)
        Me.btnDeleteImg.TabIndex = 72
        Me.btnDeleteImg.Text = "Delete Image"
        Me.btnDeleteImg.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBrowse.Location = New System.Drawing.Point(83, 555)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(99, 26)
        Me.btnBrowse.TabIndex = 71
        Me.btnBrowse.Text = "Select Image"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'frmLineNotify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 591)
        Me.Controls.Add(Me.btnDeleteImg)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picData)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMessage)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLineNotify"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Line Notify and Upload Image with VB.NET"
        CType(Me.picData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents picData As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDeleteImg As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button

End Class
