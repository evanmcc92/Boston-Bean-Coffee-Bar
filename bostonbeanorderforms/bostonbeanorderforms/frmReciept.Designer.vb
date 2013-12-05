<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReciept
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReciept))
        Me.btnTotals = New System.Windows.Forms.Button()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.grpReciept = New System.Windows.Forms.GroupBox()
        Me.lblCashierName = New System.Windows.Forms.Label()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.lblThanks = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtotalPrice = New System.Windows.Forms.Label()
        Me.lblTaxPrice = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCashierHome = New System.Windows.Forms.Button()
        Me.grpReciept.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTotals
        '
        Me.btnTotals.Location = New System.Drawing.Point(12, 227)
        Me.btnTotals.Name = "btnTotals"
        Me.btnTotals.Size = New System.Drawing.Size(49, 23)
        Me.btnTotals.TabIndex = 0
        Me.btnTotals.Text = "Totals"
        Me.btnTotals.UseVisualStyleBackColor = True
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(91, 170)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalPrice.TabIndex = 1
        Me.lblTotalPrice.Text = " "
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(67, 227)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(91, 23)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(19, 170)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total"
        '
        'grpReciept
        '
        Me.grpReciept.Controls.Add(Me.lblCashierName)
        Me.grpReciept.Controls.Add(Me.lblCashier)
        Me.grpReciept.Controls.Add(Me.lblThanks)
        Me.grpReciept.Controls.Add(Me.lblTitle)
        Me.grpReciept.Controls.Add(Me.lblSubtotalPrice)
        Me.grpReciept.Controls.Add(Me.lblTaxPrice)
        Me.grpReciept.Controls.Add(Me.lblTax)
        Me.grpReciept.Controls.Add(Me.lblSubtotal)
        Me.grpReciept.Controls.Add(Me.lblTotal)
        Me.grpReciept.Controls.Add(Me.lblTotalPrice)
        Me.grpReciept.Location = New System.Drawing.Point(12, 12)
        Me.grpReciept.Name = "grpReciept"
        Me.grpReciept.Size = New System.Drawing.Size(200, 204)
        Me.grpReciept.TabIndex = 4
        Me.grpReciept.TabStop = False
        Me.grpReciept.Text = "Reciept"
        '
        'lblCashierName
        '
        Me.lblCashierName.AutoSize = True
        Me.lblCashierName.Location = New System.Drawing.Point(57, 67)
        Me.lblCashierName.Name = "lblCashierName"
        Me.lblCashierName.Size = New System.Drawing.Size(10, 13)
        Me.lblCashierName.TabIndex = 10
        Me.lblCashierName.Text = " "
        '
        'lblCashier
        '
        Me.lblCashier.AutoSize = True
        Me.lblCashier.Location = New System.Drawing.Point(6, 67)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(45, 13)
        Me.lblCashier.TabIndex = 9
        Me.lblCashier.Text = "Cashier:"
        '
        'lblThanks
        '
        Me.lblThanks.AutoSize = True
        Me.lblThanks.Location = New System.Drawing.Point(6, 43)
        Me.lblThanks.Name = "lblThanks"
        Me.lblThanks.Size = New System.Drawing.Size(134, 13)
        Me.lblThanks.TabIndex = 8
        Me.lblThanks.Text = "Thank You For Coming By!"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(39, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(121, 13)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Boston Bean Coffee Bar"
        '
        'lblSubtotalPrice
        '
        Me.lblSubtotalPrice.AutoSize = True
        Me.lblSubtotalPrice.Location = New System.Drawing.Point(91, 113)
        Me.lblSubtotalPrice.Name = "lblSubtotalPrice"
        Me.lblSubtotalPrice.Size = New System.Drawing.Size(10, 13)
        Me.lblSubtotalPrice.TabIndex = 7
        Me.lblSubtotalPrice.Text = " "
        '
        'lblTaxPrice
        '
        Me.lblTaxPrice.AutoSize = True
        Me.lblTaxPrice.Location = New System.Drawing.Point(91, 143)
        Me.lblTaxPrice.Name = "lblTaxPrice"
        Me.lblTaxPrice.Size = New System.Drawing.Size(10, 13)
        Me.lblTaxPrice.TabIndex = 6
        Me.lblTaxPrice.Text = " "
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(19, 143)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(25, 13)
        Me.lblTax.TabIndex = 5
        Me.lblTax.Text = "Tax"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(19, 113)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(46, 13)
        Me.lblSubtotal.TabIndex = 4
        Me.lblSubtotal.Text = "Subtotal"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(164, 227)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(49, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCashierHome
        '
        Me.btnCashierHome.Location = New System.Drawing.Point(12, 256)
        Me.btnCashierHome.Name = "btnCashierHome"
        Me.btnCashierHome.Size = New System.Drawing.Size(200, 23)
        Me.btnCashierHome.TabIndex = 6
        Me.btnCashierHome.Text = "Cashier Home"
        Me.btnCashierHome.UseVisualStyleBackColor = True
        '
        'frmReciept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(225, 286)
        Me.Controls.Add(Me.btnCashierHome)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpReciept)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnTotals)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReciept"
        Me.Text = "Boston Bean Cafe - Reciept"
        Me.grpReciept.ResumeLayout(False)
        Me.grpReciept.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTotals As System.Windows.Forms.Button
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents grpReciept As System.Windows.Forms.GroupBox
    Friend WithEvents lblSubtotalPrice As System.Windows.Forms.Label
    Friend WithEvents lblTaxPrice As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblThanks As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblCashierName As System.Windows.Forms.Label
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents btnCashierHome As System.Windows.Forms.Button
End Class
