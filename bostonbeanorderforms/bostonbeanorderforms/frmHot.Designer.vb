<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHot))
        Me.imgCoffee = New System.Windows.Forms.PictureBox()
        Me.grpInvoice = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.grpOrderForm = New System.Windows.Forms.GroupBox()
        Me.grpSelections = New System.Windows.Forms.GroupBox()
        Me.chkExpresso = New System.Windows.Forms.CheckBox()
        Me.chkCoco = New System.Windows.Forms.CheckBox()
        Me.chkLatte = New System.Windows.Forms.CheckBox()
        Me.chkCappucino = New System.Windows.Forms.CheckBox()
        Me.chkHotCoffee = New System.Windows.Forms.CheckBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.chkLoyalty = New System.Windows.Forms.CheckBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.grpButtons = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintForm2 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnPastries = New System.Windows.Forms.Button()
        Me.btnCold = New System.Windows.Forms.Button()
        Me.btnCashierHome = New System.Windows.Forms.Button()
        CType(Me.imgCoffee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInvoice.SuspendLayout()
        Me.grpOrderForm.SuspendLayout()
        Me.grpSelections.SuspendLayout()
        Me.grpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgCoffee
        '
        Me.imgCoffee.Image = CType(resources.GetObject("imgCoffee.Image"), System.Drawing.Image)
        Me.imgCoffee.Location = New System.Drawing.Point(14, 349)
        Me.imgCoffee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgCoffee.Name = "imgCoffee"
        Me.imgCoffee.Size = New System.Drawing.Size(84, 83)
        Me.imgCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCoffee.TabIndex = 11
        Me.imgCoffee.TabStop = False
        '
        'grpInvoice
        '
        Me.grpInvoice.Controls.Add(Me.lblTotal)
        Me.grpInvoice.Controls.Add(Me.txtTotal)
        Me.grpInvoice.Controls.Add(Me.lblTax)
        Me.grpInvoice.Controls.Add(Me.txtTax)
        Me.grpInvoice.Controls.Add(Me.lblDiscount)
        Me.grpInvoice.Controls.Add(Me.txtDiscount)
        Me.grpInvoice.Controls.Add(Me.lblSubtotal)
        Me.grpInvoice.Controls.Add(Me.txtSubtotal)
        Me.grpInvoice.Location = New System.Drawing.Point(14, 176)
        Me.grpInvoice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpInvoice.Name = "grpInvoice"
        Me.grpInvoice.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpInvoice.Size = New System.Drawing.Size(419, 154)
        Me.grpInvoice.TabIndex = 10
        Me.grpInvoice.TabStop = False
        Me.grpInvoice.Text = "Invoice"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(8, 124)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(150, 122)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(116, 20)
        Me.txtTotal.TabIndex = 13
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(8, 89)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(25, 13)
        Me.lblTax.TabIndex = 10
        Me.lblTax.Text = "Tax"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(150, 86)
        Me.txtTax.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(116, 20)
        Me.txtTax.TabIndex = 11
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(7, 53)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(88, 13)
        Me.lblDiscount.TabIndex = 8
        Me.lblDiscount.Text = "Discounted Price"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(149, 50)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(116, 20)
        Me.txtDiscount.TabIndex = 9
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(8, 20)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(46, 13)
        Me.lblSubtotal.TabIndex = 6
        Me.lblSubtotal.Text = "Subtotal"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(149, 16)
        Me.txtSubtotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(116, 20)
        Me.txtSubtotal.TabIndex = 7
        '
        'grpOrderForm
        '
        Me.grpOrderForm.Controls.Add(Me.grpSelections)
        Me.grpOrderForm.Controls.Add(Me.lblQuantity)
        Me.grpOrderForm.Controls.Add(Me.txtQuantity)
        Me.grpOrderForm.Controls.Add(Me.chkLoyalty)
        Me.grpOrderForm.Controls.Add(Me.lblPrice)
        Me.grpOrderForm.Controls.Add(Me.txtPrice)
        Me.grpOrderForm.Location = New System.Drawing.Point(16, 14)
        Me.grpOrderForm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpOrderForm.Name = "grpOrderForm"
        Me.grpOrderForm.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpOrderForm.Size = New System.Drawing.Size(419, 154)
        Me.grpOrderForm.TabIndex = 9
        Me.grpOrderForm.TabStop = False
        Me.grpOrderForm.Text = "Order Form"
        '
        'grpSelections
        '
        Me.grpSelections.Controls.Add(Me.chkExpresso)
        Me.grpSelections.Controls.Add(Me.chkCoco)
        Me.grpSelections.Controls.Add(Me.chkLatte)
        Me.grpSelections.Controls.Add(Me.chkCappucino)
        Me.grpSelections.Controls.Add(Me.chkHotCoffee)
        Me.grpSelections.Location = New System.Drawing.Point(246, 14)
        Me.grpSelections.Name = "grpSelections"
        Me.grpSelections.Size = New System.Drawing.Size(167, 133)
        Me.grpSelections.TabIndex = 10
        Me.grpSelections.TabStop = False
        Me.grpSelections.Text = "Selections"
        '
        'chkExpresso
        '
        Me.chkExpresso.AutoSize = True
        Me.chkExpresso.Location = New System.Drawing.Point(6, 108)
        Me.chkExpresso.Name = "chkExpresso"
        Me.chkExpresso.Size = New System.Drawing.Size(69, 17)
        Me.chkExpresso.TabIndex = 16
        Me.chkExpresso.Text = "Expresso"
        Me.chkExpresso.UseVisualStyleBackColor = True
        '
        'chkCoco
        '
        Me.chkCoco.AutoSize = True
        Me.chkCoco.Location = New System.Drawing.Point(6, 88)
        Me.chkCoco.Name = "chkCoco"
        Me.chkCoco.Size = New System.Drawing.Size(94, 17)
        Me.chkCoco.TabIndex = 15
        Me.chkCoco.Text = "Hot Chocolate"
        Me.chkCoco.UseVisualStyleBackColor = True
        '
        'chkLatte
        '
        Me.chkLatte.AutoSize = True
        Me.chkLatte.Location = New System.Drawing.Point(6, 65)
        Me.chkLatte.Name = "chkLatte"
        Me.chkLatte.Size = New System.Drawing.Size(50, 17)
        Me.chkLatte.TabIndex = 14
        Me.chkLatte.Text = "Latte"
        Me.chkLatte.UseVisualStyleBackColor = True
        '
        'chkCappucino
        '
        Me.chkCappucino.AutoSize = True
        Me.chkCappucino.Location = New System.Drawing.Point(6, 42)
        Me.chkCappucino.Name = "chkCappucino"
        Me.chkCappucino.Size = New System.Drawing.Size(77, 17)
        Me.chkCappucino.TabIndex = 13
        Me.chkCappucino.Text = "Cappucino"
        Me.chkCappucino.UseVisualStyleBackColor = True
        '
        'chkHotCoffee
        '
        Me.chkHotCoffee.AutoSize = True
        Me.chkHotCoffee.Location = New System.Drawing.Point(6, 19)
        Me.chkHotCoffee.Name = "chkHotCoffee"
        Me.chkHotCoffee.Size = New System.Drawing.Size(77, 17)
        Me.chkHotCoffee.TabIndex = 12
        Me.chkHotCoffee.Text = "Hot Coffee"
        Me.chkHotCoffee.UseVisualStyleBackColor = True
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(7, 53)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 4
        Me.lblQuantity.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(71, 50)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(116, 20)
        Me.txtQuantity.TabIndex = 5
        '
        'chkLoyalty
        '
        Me.chkLoyalty.AutoSize = True
        Me.chkLoyalty.Location = New System.Drawing.Point(10, 95)
        Me.chkLoyalty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkLoyalty.Name = "chkLoyalty"
        Me.chkLoyalty.Size = New System.Drawing.Size(146, 17)
        Me.chkLoyalty.TabIndex = 4
        Me.chkLoyalty.Text = "Loyalty Member (20% Off)"
        Me.chkLoyalty.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(7, 20)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 1
        Me.lblPrice.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(71, 20)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(116, 20)
        Me.txtPrice.TabIndex = 3
        '
        'grpButtons
        '
        Me.grpButtons.Controls.Add(Me.btnExit)
        Me.grpButtons.Controls.Add(Me.btnCalc)
        Me.grpButtons.Controls.Add(Me.btnPrint)
        Me.grpButtons.Controls.Add(Me.btnClear)
        Me.grpButtons.Location = New System.Drawing.Point(239, 338)
        Me.grpButtons.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpButtons.Size = New System.Drawing.Size(196, 94)
        Me.grpButtons.TabIndex = 8
        Me.grpButtons.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(101, 59)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 28)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(7, 23)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(87, 28)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(101, 23)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(87, 28)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Reciept"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(7, 59)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 28)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintForm2
        '
        Me.PrintForm2.DocumentName = "document"
        Me.PrintForm2.Form = Me
        Me.PrintForm2.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm2.PrinterSettings = CType(resources.GetObject("PrintForm2.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm2.PrintFileName = Nothing
        '
        'btnPastries
        '
        Me.btnPastries.Location = New System.Drawing.Point(452, 199)
        Me.btnPastries.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPastries.Name = "btnPastries"
        Me.btnPastries.Size = New System.Drawing.Size(87, 65)
        Me.btnPastries.TabIndex = 25
        Me.btnPastries.Text = "Pastries"
        Me.btnPastries.UseVisualStyleBackColor = True
        '
        'btnCold
        '
        Me.btnCold.Location = New System.Drawing.Point(452, 105)
        Me.btnCold.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCold.Name = "btnCold"
        Me.btnCold.Size = New System.Drawing.Size(87, 65)
        Me.btnCold.TabIndex = 24
        Me.btnCold.Text = "Cold Beverages"
        Me.btnCold.UseVisualStyleBackColor = True
        '
        'btnCashierHome
        '
        Me.btnCashierHome.Location = New System.Drawing.Point(452, 15)
        Me.btnCashierHome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCashierHome.Name = "btnCashierHome"
        Me.btnCashierHome.Size = New System.Drawing.Size(87, 65)
        Me.btnCashierHome.TabIndex = 23
        Me.btnCashierHome.Text = "Cashier Home"
        Me.btnCashierHome.UseVisualStyleBackColor = True
        '
        'frmHot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(551, 446)
        Me.Controls.Add(Me.btnPastries)
        Me.Controls.Add(Me.btnCold)
        Me.Controls.Add(Me.btnCashierHome)
        Me.Controls.Add(Me.imgCoffee)
        Me.Controls.Add(Me.grpInvoice)
        Me.Controls.Add(Me.grpOrderForm)
        Me.Controls.Add(Me.grpButtons)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHot"
        Me.Text = "Boston Bean Cafe - Hot Beverages"
        CType(Me.imgCoffee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInvoice.ResumeLayout(False)
        Me.grpInvoice.PerformLayout()
        Me.grpOrderForm.ResumeLayout(False)
        Me.grpOrderForm.PerformLayout()
        Me.grpSelections.ResumeLayout(False)
        Me.grpSelections.PerformLayout()
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgCoffee As System.Windows.Forms.PictureBox
    Friend WithEvents grpInvoice As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents grpOrderForm As System.Windows.Forms.GroupBox
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents chkLoyalty As System.Windows.Forms.CheckBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents grpButtons As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintForm2 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents grpSelections As System.Windows.Forms.GroupBox
    Friend WithEvents chkExpresso As System.Windows.Forms.CheckBox
    Friend WithEvents chkCoco As System.Windows.Forms.CheckBox
    Friend WithEvents chkLatte As System.Windows.Forms.CheckBox
    Friend WithEvents chkCappucino As System.Windows.Forms.CheckBox
    Friend WithEvents chkHotCoffee As System.Windows.Forms.CheckBox
    Friend WithEvents btnPastries As System.Windows.Forms.Button
    Friend WithEvents btnCold As System.Windows.Forms.Button
    Friend WithEvents btnCashierHome As System.Windows.Forms.Button
End Class
