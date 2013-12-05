<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnSorder = New System.Windows.Forms.Button()
        Me.btnSupply = New System.Windows.Forms.Button()
        Me.btnBenefits = New System.Windows.Forms.Button()
        Me.btnPayroll = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(155, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(421, 329)
        Me.ListBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(55, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Enter Information"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(55, 204)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 41)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Number of Items"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(55, 108)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(84, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(55, 251)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 41)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnSorder
        '
        Me.btnSorder.Location = New System.Drawing.Point(245, 360)
        Me.btnSorder.Name = "btnSorder"
        Me.btnSorder.Size = New System.Drawing.Size(89, 68)
        Me.btnSorder.TabIndex = 82
        Me.btnSorder.Text = "Beverage Orders"
        Me.btnSorder.UseVisualStyleBackColor = True
        '
        'btnSupply
        '
        Me.btnSupply.Location = New System.Drawing.Point(435, 360)
        Me.btnSupply.Name = "btnSupply"
        Me.btnSupply.Size = New System.Drawing.Size(89, 68)
        Me.btnSupply.TabIndex = 81
        Me.btnSupply.Text = "Supply Ordering"
        Me.btnSupply.UseVisualStyleBackColor = True
        '
        'btnBenefits
        '
        Me.btnBenefits.Location = New System.Drawing.Point(340, 360)
        Me.btnBenefits.Name = "btnBenefits"
        Me.btnBenefits.Size = New System.Drawing.Size(89, 68)
        Me.btnBenefits.TabIndex = 80
        Me.btnBenefits.Text = "Benefits"
        Me.btnBenefits.UseVisualStyleBackColor = True
        '
        'btnPayroll
        '
        Me.btnPayroll.Location = New System.Drawing.Point(150, 360)
        Me.btnPayroll.Name = "btnPayroll"
        Me.btnPayroll.Size = New System.Drawing.Size(89, 68)
        Me.btnPayroll.TabIndex = 79
        Me.btnPayroll.Text = "Payroll"
        Me.btnPayroll.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(55, 360)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(89, 68)
        Me.btnHome.TabIndex = 78
        Me.btnHome.Text = "Home Screen"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(596, 440)
        Me.Controls.Add(Me.btnSorder)
        Me.Controls.Add(Me.btnSupply)
        Me.Controls.Add(Me.btnBenefits)
        Me.Controls.Add(Me.btnPayroll)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Inventory"
        Me.Text = "Boston Bean Cafe - Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnSorder As System.Windows.Forms.Button
    Friend WithEvents btnSupply As System.Windows.Forms.Button
    Friend WithEvents btnBenefits As System.Windows.Forms.Button
    Friend WithEvents btnPayroll As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
End Class
