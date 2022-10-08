<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtStreetNum = New System.Windows.Forms.TextBox()
        Me.txtHouseNum = New System.Windows.Forms.TextBox()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.txtPostcde = New System.Windows.Forms.TextBox()
        Me.txtCrdNum = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.cmdDetails = New System.Windows.Forms.Button()
        Me.cmdReceipt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Street Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "House Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Town/City:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Post Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Credit Card Number:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(139, 23)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 6
        '
        'txtStreetNum
        '
        Me.txtStreetNum.Location = New System.Drawing.Point(139, 66)
        Me.txtStreetNum.Name = "txtStreetNum"
        Me.txtStreetNum.Size = New System.Drawing.Size(100, 20)
        Me.txtStreetNum.TabIndex = 7
        '
        'txtHouseNum
        '
        Me.txtHouseNum.Location = New System.Drawing.Point(139, 111)
        Me.txtHouseNum.Name = "txtHouseNum"
        Me.txtHouseNum.Size = New System.Drawing.Size(100, 20)
        Me.txtHouseNum.TabIndex = 8
        '
        'txtTown
        '
        Me.txtTown.Location = New System.Drawing.Point(139, 157)
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(100, 20)
        Me.txtTown.TabIndex = 9
        '
        'txtPostcde
        '
        Me.txtPostcde.Location = New System.Drawing.Point(139, 196)
        Me.txtPostcde.Name = "txtPostcde"
        Me.txtPostcde.Size = New System.Drawing.Size(100, 20)
        Me.txtPostcde.TabIndex = 10
        '
        'txtCrdNum
        '
        Me.txtCrdNum.Location = New System.Drawing.Point(139, 236)
        Me.txtCrdNum.Name = "txtCrdNum"
        Me.txtCrdNum.Size = New System.Drawing.Size(100, 20)
        Me.txtCrdNum.TabIndex = 11
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.White
        Me.lblOutput.Location = New System.Drawing.Point(313, 23)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(100, 229)
        Me.lblOutput.TabIndex = 12
        '
        'cmdDetails
        '
        Me.cmdDetails.BackColor = System.Drawing.Color.Lime
        Me.cmdDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDetails.Location = New System.Drawing.Point(53, 327)
        Me.cmdDetails.Name = "cmdDetails"
        Me.cmdDetails.Size = New System.Drawing.Size(124, 23)
        Me.cmdDetails.TabIndex = 13
        Me.cmdDetails.Text = "Enter Details"
        Me.cmdDetails.UseVisualStyleBackColor = False
        '
        'cmdReceipt
        '
        Me.cmdReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReceipt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdReceipt.Location = New System.Drawing.Point(302, 327)
        Me.cmdReceipt.Name = "cmdReceipt"
        Me.cmdReceipt.Size = New System.Drawing.Size(97, 23)
        Me.cmdReceipt.TabIndex = 14
        Me.cmdReceipt.Text = "Print Receipt"
        Me.cmdReceipt.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(455, 386)
        Me.Controls.Add(Me.cmdReceipt)
        Me.Controls.Add(Me.cmdDetails)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtCrdNum)
        Me.Controls.Add(Me.txtPostcde)
        Me.Controls.Add(Me.txtTown)
        Me.Controls.Add(Me.txtHouseNum)
        Me.Controls.Add(Me.txtStreetNum)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Details and Receipt "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtStreetNum As TextBox
    Friend WithEvents txtHouseNum As TextBox
    Friend WithEvents txtTown As TextBox
    Friend WithEvents txtPostcde As TextBox
    Friend WithEvents txtCrdNum As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents cmdDetails As Button
    Friend WithEvents cmdReceipt As Button
End Class
