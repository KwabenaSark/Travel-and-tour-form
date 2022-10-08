<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmdOrder = New System.Windows.Forms.Button()
        Me.cmdQuote = New System.Windows.Forms.Button()
        Me.optMalmo = New System.Windows.Forms.RadioButton()
        Me.optStockholm = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmblenght = New System.Windows.Forms.ComboBox()
        Me.optGothenburg = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.chkMeal = New System.Windows.Forms.CheckBox()
        Me.chkEbike = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOrder
        '
        Me.cmdOrder.BackColor = System.Drawing.Color.Red
        Me.cmdOrder.Font = New System.Drawing.Font("Myriad Set Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdOrder.Location = New System.Drawing.Point(264, 480)
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.Size = New System.Drawing.Size(156, 67)
        Me.cmdOrder.TabIndex = 8
        Me.cmdOrder.Text = "Order"
        Me.cmdOrder.UseVisualStyleBackColor = False
        '
        'cmdQuote
        '
        Me.cmdQuote.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdQuote.Font = New System.Drawing.Font("Myriad Set Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuote.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdQuote.Location = New System.Drawing.Point(27, 480)
        Me.cmdQuote.Name = "cmdQuote"
        Me.cmdQuote.Size = New System.Drawing.Size(152, 63)
        Me.cmdQuote.TabIndex = 9
        Me.cmdQuote.Text = "Quote"
        Me.cmdQuote.UseVisualStyleBackColor = False
        '
        'optMalmo
        '
        Me.optMalmo.AutoSize = True
        Me.optMalmo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMalmo.Location = New System.Drawing.Point(331, 30)
        Me.optMalmo.Name = "optMalmo"
        Me.optMalmo.Size = New System.Drawing.Size(61, 17)
        Me.optMalmo.TabIndex = 11
        Me.optMalmo.TabStop = True
        Me.optMalmo.Text = "Malmö"
        Me.optMalmo.UseVisualStyleBackColor = True
        '
        'optStockholm
        '
        Me.optStockholm.AutoSize = True
        Me.optStockholm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optStockholm.Location = New System.Drawing.Point(622, 30)
        Me.optStockholm.Name = "optStockholm"
        Me.optStockholm.Size = New System.Drawing.Size(84, 17)
        Me.optStockholm.TabIndex = 12
        Me.optStockholm.TabStop = True
        Me.optStockholm.Text = "Stockholm"
        Me.optStockholm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myriad Set Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "TOUR DESTINATION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Additional Products"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Myriad Set Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(485, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "TOUR LENGHT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Myriad Set Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "TOUR MONTH"
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(191, 222)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(140, 21)
        Me.cmbMonth.TabIndex = 2
        '
        'cmblenght
        '
        Me.cmblenght.FormattingEnabled = True
        Me.cmblenght.Location = New System.Drawing.Point(464, 222)
        Me.cmblenght.Name = "cmblenght"
        Me.cmblenght.Size = New System.Drawing.Size(140, 21)
        Me.cmblenght.TabIndex = 5
        '
        'optGothenburg
        '
        Me.optGothenburg.AutoSize = True
        Me.optGothenburg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optGothenburg.Location = New System.Drawing.Point(28, 30)
        Me.optGothenburg.Name = "optGothenburg"
        Me.optGothenburg.Size = New System.Drawing.Size(91, 17)
        Me.optGothenburg.TabIndex = 10
        Me.optGothenburg.TabStop = True
        Me.optGothenburg.Text = "Gothenburg"
        Me.optGothenburg.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optStockholm)
        Me.GroupBox1.Controls.Add(Me.optMalmo)
        Me.GroupBox1.Controls.Add(Me.optGothenburg)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(778, 80)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDisplay.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblDisplay.Location = New System.Drawing.Point(464, 267)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(331, 280)
        Me.lblDisplay.TabIndex = 20
        '
        'chkMeal
        '
        Me.chkMeal.AutoSize = True
        Me.chkMeal.Location = New System.Drawing.Point(16, 52)
        Me.chkMeal.Name = "chkMeal"
        Me.chkMeal.Size = New System.Drawing.Size(106, 17)
        Me.chkMeal.TabIndex = 21
        Me.chkMeal.Text = "Meal package"
        Me.chkMeal.UseVisualStyleBackColor = True
        '
        'chkEbike
        '
        Me.chkEbike.AutoSize = True
        Me.chkEbike.Location = New System.Drawing.Point(16, 16)
        Me.chkEbike.Name = "chkEbike"
        Me.chkEbike.Size = New System.Drawing.Size(122, 17)
        Me.chkEbike.TabIndex = 22
        Me.chkEbike.Text = "Electric bike hire"
        Me.chkEbike.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkEbike)
        Me.GroupBox2.Controls.Add(Me.chkMeal)
        Me.GroupBox2.Location = New System.Drawing.Point(41, 308)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(149, 89)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(813, 559)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdQuote)
        Me.Controls.Add(Me.cmdOrder)
        Me.Controls.Add(Me.cmblenght)
        Me.Controls.Add(Me.cmbMonth)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = " Sweden By Bike"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOrder As Button
    Friend WithEvents cmdQuote As Button
    Friend WithEvents optMalmo As RadioButton
    Friend WithEvents optStockholm As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents cmblenght As ComboBox
    Friend WithEvents optGothenburg As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDisplay As Label
    Friend WithEvents chkMeal As CheckBox
    Friend WithEvents chkEbike As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
