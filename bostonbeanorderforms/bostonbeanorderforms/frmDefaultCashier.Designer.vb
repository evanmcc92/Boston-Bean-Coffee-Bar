<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDefaultCashier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDefaultCashier))
        Me.btnCold = New System.Windows.Forms.Button()
        Me.btnHot = New System.Windows.Forms.Button()
        Me.btnPastries = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.lblCashierName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCold
        '
        Me.btnCold.Location = New System.Drawing.Point(11, 34)
        Me.btnCold.Name = "btnCold"
        Me.btnCold.Size = New System.Drawing.Size(114, 96)
        Me.btnCold.TabIndex = 0
        Me.btnCold.Text = "Iced Beverages"
        Me.btnCold.UseVisualStyleBackColor = True
        '
        'btnHot
        '
        Me.btnHot.Location = New System.Drawing.Point(131, 35)
        Me.btnHot.Name = "btnHot"
        Me.btnHot.Size = New System.Drawing.Size(112, 95)
        Me.btnHot.TabIndex = 1
        Me.btnHot.Text = "Hot Beverages"
        Me.btnHot.UseVisualStyleBackColor = True
        '
        'btnPastries
        '
        Me.btnPastries.Location = New System.Drawing.Point(249, 35)
        Me.btnPastries.Name = "btnPastries"
        Me.btnPastries.Size = New System.Drawing.Size(113, 95)
        Me.btnPastries.TabIndex = 2
        Me.btnPastries.Text = "Pastries"
        Me.btnPastries.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(11, 136)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(351, 35)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCashier
        '
        Me.lblCashier.AutoSize = True
        Me.lblCashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashier.Location = New System.Drawing.Point(12, 6)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(92, 25)
        Me.lblCashier.TabIndex = 4
        Me.lblCashier.Text = "Cashier:"
        '
        'lblCashierName
        '
        Me.lblCashierName.AutoSize = True
        Me.lblCashierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashierName.Location = New System.Drawing.Point(126, 7)
        Me.lblCashierName.Name = "lblCashierName"
        Me.lblCashierName.Size = New System.Drawing.Size(18, 25)
        Me.lblCashierName.TabIndex = 5
        Me.lblCashierName.Text = " "
        '
        'frmDefaultCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(370, 185)
        Me.Controls.Add(Me.lblCashierName)
        Me.Controls.Add(Me.lblCashier)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPastries)
        Me.Controls.Add(Me.btnHot)
        Me.Controls.Add(Me.btnCold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDefaultCashier"
        Me.Text = "Boston Bean Cafe - Customer Orders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCold As System.Windows.Forms.Button
    Friend WithEvents btnHot As System.Windows.Forms.Button
    Friend WithEvents btnPastries As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents lblCashierName As System.Windows.Forms.Label

End Class
