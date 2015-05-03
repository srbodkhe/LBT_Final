<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Operator_Work
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Operator_Work))
        Me.Save_D = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SN = New System.Windows.Forms.TextBox()
        Me.PN = New System.Windows.Forms.TextBox()
        Me.PI = New System.Windows.Forms.TextBox()
        Me.QN = New System.Windows.Forms.TextBox()
        Me.PR = New System.Windows.Forms.TextBox()
        Me.TX = New System.Windows.Forms.TextBox()
        Me.TOTAL_T = New System.Windows.Forms.TextBox()
        Me.TT = New System.Windows.Forms.TextBox()
        Me.Calculation = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ED1 = New System.Windows.Forms.DateTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Save_D
        '
        Me.Save_D.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_D.ForeColor = System.Drawing.Color.MediumBlue
        Me.Save_D.Location = New System.Drawing.Point(385, 590)
        Me.Save_D.Name = "Save_D"
        Me.Save_D.Size = New System.Drawing.Size(165, 35)
        Me.Save_D.TabIndex = 0
        Me.Save_D.Text = "Save"
        Me.Save_D.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button1.Location = New System.Drawing.Point(574, 590)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button2.Location = New System.Drawing.Point(757, 590)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 35)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lavender
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(414, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Seller_Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lavender
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(414, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Product_Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Lavender
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(414, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Product_ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Lavender
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(414, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Lavender
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(414, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Lavender
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(414, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "LBT_Tax/ Product"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Lavender
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(414, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Total Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Lavender
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(414, 410)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Total_LBT/Tax"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Lavender
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(414, 521)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Entry_Date"
        '
        'SN
        '
        Me.SN.Location = New System.Drawing.Point(574, 130)
        Me.SN.Name = "SN"
        Me.SN.Size = New System.Drawing.Size(165, 20)
        Me.SN.TabIndex = 12
        '
        'PN
        '
        Me.PN.Location = New System.Drawing.Point(574, 170)
        Me.PN.Name = "PN"
        Me.PN.Size = New System.Drawing.Size(165, 20)
        Me.PN.TabIndex = 13
        '
        'PI
        '
        Me.PI.Location = New System.Drawing.Point(574, 210)
        Me.PI.Name = "PI"
        Me.PI.Size = New System.Drawing.Size(165, 20)
        Me.PI.TabIndex = 14
        '
        'QN
        '
        Me.QN.Location = New System.Drawing.Point(574, 250)
        Me.QN.Name = "QN"
        Me.QN.Size = New System.Drawing.Size(165, 20)
        Me.QN.TabIndex = 15
        '
        'PR
        '
        Me.PR.Location = New System.Drawing.Point(574, 290)
        Me.PR.Name = "PR"
        Me.PR.Size = New System.Drawing.Size(165, 20)
        Me.PR.TabIndex = 16
        '
        'TX
        '
        Me.TX.Location = New System.Drawing.Point(574, 330)
        Me.TX.Name = "TX"
        Me.TX.Size = New System.Drawing.Size(165, 20)
        Me.TX.TabIndex = 17
        '
        'TOTAL_T
        '
        Me.TOTAL_T.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL_T.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TOTAL_T.HideSelection = False
        Me.TOTAL_T.Location = New System.Drawing.Point(574, 370)
        Me.TOTAL_T.Name = "TOTAL_T"
        Me.TOTAL_T.ReadOnly = True
        Me.TOTAL_T.Size = New System.Drawing.Size(165, 23)
        Me.TOTAL_T.TabIndex = 18
        Me.TOTAL_T.TabStop = False
        '
        'TT
        '
        Me.TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TT.HideSelection = False
        Me.TT.Location = New System.Drawing.Point(574, 410)
        Me.TT.Name = "TT"
        Me.TT.ReadOnly = True
        Me.TT.Size = New System.Drawing.Size(165, 23)
        Me.TT.TabIndex = 19
        Me.TT.TabStop = False
        '
        'Calculation
        '
        Me.Calculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculation.ForeColor = System.Drawing.Color.Red
        Me.Calculation.Location = New System.Drawing.Point(574, 475)
        Me.Calculation.Name = "Calculation"
        Me.Calculation.Size = New System.Drawing.Size(165, 31)
        Me.Calculation.TabIndex = 21
        Me.Calculation.Text = "Calculate Tax"
        Me.Calculation.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(768, 370)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'ED1
        '
        Me.ED1.Location = New System.Drawing.Point(544, 521)
        Me.ED1.Name = "ED1"
        Me.ED1.Size = New System.Drawing.Size(229, 20)
        Me.ED1.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(0, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1368, 78)
        Me.Panel1.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(356, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(417, 37)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Operator Data Entry Form"
        '
        'Operator_Work
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1370, 686)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ED1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Calculation)
        Me.Controls.Add(Me.TT)
        Me.Controls.Add(Me.TOTAL_T)
        Me.Controls.Add(Me.TX)
        Me.Controls.Add(Me.PR)
        Me.Controls.Add(Me.QN)
        Me.Controls.Add(Me.PI)
        Me.Controls.Add(Me.PN)
        Me.Controls.Add(Me.SN)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Save_D)
        Me.Name = "Operator_Work"
        Me.Text = "Operator_Entry"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Save_D As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SN As System.Windows.Forms.TextBox
    Friend WithEvents PN As System.Windows.Forms.TextBox
    Friend WithEvents PI As System.Windows.Forms.TextBox
    Friend WithEvents QN As System.Windows.Forms.TextBox
    Friend WithEvents PR As System.Windows.Forms.TextBox
    Friend WithEvents TX As System.Windows.Forms.TextBox
    Friend WithEvents TOTAL_T As System.Windows.Forms.TextBox
    Friend WithEvents TT As System.Windows.Forms.TextBox
    Friend WithEvents Calculation As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ED1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
