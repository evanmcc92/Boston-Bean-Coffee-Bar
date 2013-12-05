<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPastries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPastries))
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
        Me.chkDanish = New System.Windows.Forms.CheckBox()
        Me.chkScone = New System.Windows.Forms.CheckBox()
        Me.chkCroissant = New System.Windows.Forms.CheckBox()
        Me.chkBagel = New System.Windows.Forms.CheckBox()
        Me.chkDonut = New System.Windows.Forms.CheckBox()
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.imgCoffee.TabIndex = 15
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
        Me.grpInvoice.TabIndex = 14
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
        Me.grpOrderForm.TabIndex = 13
        Me.grpOrderForm.TabStop = False
        Me.grpOrderForm.Text = "Order Form"
        '
        'grpSelections
        '
        Me.grpSelections.Controls.Add(Me.chkDanish)
        Me.grpSelections.Controls.Add(Me.chkScone)
        Me.grpSelections.Controls.Add(Me.chkCroissant)
        Me.grpSelections.Controls.Add(Me.chkBagel)
        Me.grpSelections.Controls.Add(Me.chkDonut)
        Me.grpSelections.Location = New System.Drawing.Point(246, 14)
        Me.grpSelections.Name = "grpSelections"
        Me.grpSelections.Size = New System.Drawing.Size(167, 133)
        Me.grpSelections.TabIndex = 11
        Me.grpSelections.TabStop = False
        Me.grpSelections.Text = "Selections"
        '
        'chkDanish
        '
        Me.chkDanish.AutoSize = True
        Me.chkDanish.Location = New System.Drawing.Point(6, 110)
        Me.chkDanish.Name = "chkDanish"
        Me.chkDanish.Size = New System.Drawing.Size(59, 17)
        Me.chkDanish.TabIndex = 16
        Me.chkDanish.Text = "Danish"
        Me.chkDanish.UseVisualStyleBackColor = True
        '
        'chkScone
        '
        Me.chkScone.AutoSize = True
        Me.chkScone.Location = New System.Drawing.Point(6, 88)
        Me.chkScone.Name = "chkScone"
        Me.chkScone.Size = New System.Drawing.Size(57, 17)
        Me.chkScone.TabIndex = 15
        Me.chkScone.Text = "Scone"
        Me.chkScone.UseVisualStyleBackColor = True
        '
        'chkCroissant
        '
        Me.chkCroissant.AutoSize = True
        Me.chkCroissant.Location = New System.Drawing.Point(6, 65)
        Me.chkCroissant.Name = "chkCroissant"
        Me.chkCroissant.Size = New System.Drawing.Size(72, 17)
        Me.chkCroissant.TabIndex = 14
        Me.chkCroissant.Text = "Croissant "
        Me.chkCroissant.UseVisualStyleBackColor = True
        '
        'chkBagel
        '
        Me.chkBagel.AutoSize = True
        Me.chkBagel.Location = New System.Drawing.Point(6, 42)
        Me.chkBagel.Name = "chkBagel"
        Me.chkBagel.Size = New System.Drawing.Size(53, 17)
        Me.chkBagel.TabIndex = 13
        Me.chkBagel.Text = "Bagel"
        Me.chkBagel.UseVisualStyleBackColor = True
        '
        'chkDonut
        '
        Me.chkDonut.AutoSize = True
        Me.chkDonut.Location = New System.Drawing.Point(6, 19)
        Me.chkDonut.Name = "chkDonut"
        Me.chkDonut.Size = New System.Drawing.Size(55, 17)
        Me.chkDonut.TabIndex = 12
        Me.chkDonut.Text = "Donut"
        Me.chkDonut.UseVisualStyleBackColor = True
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
        Me.grpButtons.TabIndex = 12
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
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(452, 203)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 65)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Cold Beverages"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(452, 109)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 65)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Hot Beverages"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(452, 19)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 65)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Cashier Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPastries
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(551, 446)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.imgCoffee)
        Me.Controls.Add(Me.grpInvoice)
        Me.Controls.Add(Me.grpOrderForm)
        Me.Controls.Add(Me.grpButtons)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPastries"
        Me.Text = "Boston Bean Cafe - Pastries"
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
    Friend WithEvents grpSelections As System.Windows.Forms.GroupBox
    Friend WithEvents chkCroissant As System.Windows.Forms.CheckBox
    Friend WithEvents chkBagel As System.Windows.Forms.CheckBox
    Friend WithEvents chkDonut As System.Windows.Forms.CheckBox
    Friend WithEvents chkDanish As System.Windows.Forms.CheckBox
    Friend WithEvents chkScone As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
