Public Class frmBookRental

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        InvoiceListBox.Items.Clear()
        txtCustName.Clear()
        txtQuantity.Clear()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintFormBooks.PrintAction = Printing.PrintAction.PrintToPreview
        PrintFormBooks.Print()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'declare
        Dim custname As String
        Dim quant As Double
        Dim counter1 As Double
        Dim bookname As String
        Dim timeout As Date
        Dim timeback As Date

        'input
        custname = txtCustName.Text
        quant = txtQuantity.Text

        counter1 = 0

        InvoiceListBox.Items.Add("Customer Name" & ControlChars.Tab & custname)
        InvoiceListBox.Items.Add("")
        InvoiceListBox.Items.Add("Book Name" & ControlChars.Tab & "Time Taken Out" & ControlChars.Tab & ControlChars.Tab & "Time Due")

        'math/output
        Do Until counter1 = quant
            bookname = InputBox("Enter book name")
            timeout = DateTime.Now
            timeback = DateTime.Now.AddHours(2)

            InvoiceListBox.Items.Add(bookname & ControlChars.Tab & ControlChars.Tab & timeout & ControlChars.Tab & timeback)
            counter1 = counter1 + 1
        Loop

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MainForm.Show()
        Me.Hide()
    End Sub
End Class