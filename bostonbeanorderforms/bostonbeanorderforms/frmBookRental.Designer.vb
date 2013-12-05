<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookRental
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookRental))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.grpButtons = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.grpOrderForm = New System.Windows.Forms.GroupBox()
        Me.grpInvoice = New System.Windows.Forms.GroupBox()
        Me.InvoiceListBox = New System.Windows.Forms.ListBox()
        Me.imgCoffee = New System.Windows.Forms.PictureBox()
        Me.PrintFormBooks = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpButtons.SuspendLayout()
        Me.grpOrderForm.SuspendLayout()
        Me.grpInvoice.SuspendLayout()
        CType(Me.imgCoffee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
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
        'grpButtons
        '
        Me.grpButtons.Controls.Add(Me.btnExit)
        Me.grpButtons.Controls.Add(Me.btnCalc)
        Me.grpButtons.Controls.Add(Me.btnPrint)
        Me.grpButtons.Controls.Add(Me.btnClear)
        Me.grpButtons.Location = New System.Drawing.Point(235, 337)
        Me.grpButtons.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpButtons.Size = New System.Drawing.Size(196, 94)
        Me.grpButtons.TabIndex = 16
        Me.grpButtons.TabStop = False
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
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(7, 53)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(89, 13)
        Me.lblQuantity.TabIndex = 4
        Me.lblQuantity.Text = "Number of Books"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(102, 50)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(116, 20)
        Me.txtQuantity.TabIndex = 5
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Location = New System.Drawing.Point(7, 20)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(82, 13)
        Me.lblCustName.TabIndex = 1
        Me.lblCustName.Text = "Customer Name"
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(102, 17)
        Me.txtCustName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(116, 20)
        Me.txtCustName.TabIndex = 3
        '
        'grpOrderForm
        '
        Me.grpOrderForm.Controls.Add(Me.lblQuantity)
        Me.grpOrderForm.Controls.Add(Me.txtQuantity)
        Me.grpOrderForm.Controls.Add(Me.lblCustName)
        Me.grpOrderForm.Controls.Add(Me.txtCustName)
        Me.grpOrderForm.Location = New System.Drawing.Point(12, 13)
        Me.grpOrderForm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpOrderForm.Name = "grpOrderForm"
        Me.grpOrderForm.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpOrderForm.Size = New System.Drawing.Size(419, 83)
        Me.grpOrderForm.TabIndex = 17
        Me.grpOrderForm.TabStop = False
        Me.grpOrderForm.Text = "Order Form"
        '
        'grpInvoice
        '
        Me.grpInvoice.Controls.Add(Me.InvoiceListBox)
        Me.grpInvoice.Location = New System.Drawing.Point(10, 104)
        Me.grpInvoice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpInvoice.Name = "grpInvoice"
        Me.grpInvoice.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpInvoice.Size = New System.Drawing.Size(419, 225)
        Me.grpInvoice.TabIndex = 18
        Me.grpInvoice.TabStop = False
        Me.grpInvoice.Text = "Invoice"
        '
        'InvoiceListBox
        '
        Me.InvoiceListBox.FormattingEnabled = True
        Me.InvoiceListBox.Location = New System.Drawing.Point(7, 21)
        Me.InvoiceListBox.Name = "InvoiceListBox"
        Me.InvoiceListBox.Size = New System.Drawing.Size(406, 186)
        Me.InvoiceListBox.TabIndex = 0
        '
        'imgCoffee
        '
        Me.imgCoffee.Image = CType(resources.GetObject("imgCoffee.Image"), System.Drawing.Image)
        Me.imgCoffee.Location = New System.Drawing.Point(10, 348)
        Me.imgCoffee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgCoffee.Name = "imgCoffee"
        Me.imgCoffee.Size = New System.Drawing.Size(84, 83)
        Me.imgCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCoffee.TabIndex = 19
        Me.imgCoffee.TabStop = False
        '
        'PrintFormBooks
        '
        Me.PrintFormBooks.DocumentName = "document"
        Me.PrintFormBooks.Form = Me
        Me.PrintFormBooks.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintFormBooks.PrinterSettings = CType(resources.GetObject("PrintFormBooks.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintFormBooks.PrintFileName = Nothing
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(124, 359)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 65)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Main Screen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmBookRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(448, 446)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grpButtons)
        Me.Controls.Add(Me.grpOrderForm)
        Me.Controls.Add(Me.grpInvoice)
        Me.Controls.Add(Me.imgCoffee)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBookRental"
        Me.Text = "Boston Bean Cafe - Book Rentals"
        Me.grpButtons.ResumeLayout(False)
        Me.grpOrderForm.ResumeLayout(False)
        Me.grpOrderForm.PerformLayout()
        Me.grpInvoice.ResumeLayout(False)
        CType(Me.imgCoffee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents grpButtons As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents grpOrderForm As System.Windows.Forms.GroupBox
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents lblCustName As System.Windows.Forms.Label
    Friend WithEvents txtCustName As System.Windows.Forms.TextBox
    Friend WithEvents grpInvoice As System.Windows.Forms.GroupBox
    Friend WithEvents imgCoffee As System.Windows.Forms.PictureBox
    Friend WithEvents InvoiceListBox As System.Windows.Forms.ListBox
    Friend WithEvents PrintFormBooks As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
