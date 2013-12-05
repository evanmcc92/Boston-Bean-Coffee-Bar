Public Class Inventory

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'decleare variables

        Dim itemamount As Double

        Dim counter1 As Double

        Dim itemname As String
        Dim numitems As Double

        Dim numberofitems As String
        'Dim totalperitem As Double


        'input
        'header
        ListBox1.Items.Add("Item Name" & ControlChars.Tab & "Number of Items Left" & ControlChars.Tab & "Order (Yes/No)")
        'use input box
        numitems = TextBox1.Text
        counter1 = 0
        Do
            itemname = InputBox("Enter Item Name")
            itemamount = InputBox("Enter Items Left")
            numberofitems = InputBox("Enter Yes/No if needs to be re-order")

            counter1 = counter1 + 1
            ListBox1.Items.Add(itemname & ControlChars.Tab & ControlChars.Tab & itemamount & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & numberofitems)

        Loop Until counter1 >= numitems


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.print()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        MainForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnPayroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayroll.Click
        Payroll.Show()
        Me.Hide()
    End Sub

    Private Sub btnSorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSorder.Click
        SOrdering.Show()
        Me.Hide()
    End Sub

    Private Sub btnBenefits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBenefits.Click
        Benefits.Show()
        Me.Hide()
    End Sub

    Private Sub btnSupply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupply.Click
        Supply2.Show()
        Me.Hide()
    End Sub
End Class