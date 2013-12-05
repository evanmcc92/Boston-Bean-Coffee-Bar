Public Class frmHot

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtDiscount.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        txtSubtotal.Clear()
        txtTax.Clear()
        txtTotal.Clear()
        chkLoyalty.Checked = False
        chkCoco.Checked = False
        chkCappucino.Checked = False
        chkHotCoffee.Checked = False
        chkLatte.Checked = False
        chkExpresso.Checked = False

    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        'declare
        Dim price As Double
        Dim quant As Double
        Dim discount As Double
        Dim discountprice As Double
        Dim subtotal As Double
        Dim tax As Double
        Dim total As Double
        Dim coffee As Double
        Dim latte As Double
        Dim cappucino As Double
        Dim expresso As Double
        Dim coco As Double

        'inputs
        If chkHotCoffee.Checked = True Then
            coffee = InputBox("Enter Hot Coffee Price")
        Else
            coffee = 0
        End If
        If chkCappucino.Checked = True Then
            cappucino = InputBox("Enter Cappucino Price")
        Else
            cappucino = 0
        End If
        If chkLatte.Checked = True Then
            latte = InputBox("Enter Latte Price")
        Else
            latte = 0
        End If
        If chkExpresso.Checked = True Then
            expresso = InputBox("Enter Expresso Price")
        Else
            expresso = 0
        End If
        If chkCoco.Checked = True Then
            coco = InputBox("Enter Hot Chocolate Price")
        Else
            coco = 0
        End If

        'math
        price = coffee + latte + cappucino + expresso + coco
        txtPrice.Text = price
        quant = txtQuantity.Text

        If chkLoyalty.Checked = True Then
            discount = 0.2
        Else
            discount = 0
        End If

        subtotal = price * quant

        Select Case discount
            Case Is = 0.2
                discountprice = subtotal - (subtotal * discount)
                tax = discountprice * 0.065
                total = discountprice + tax
            Case Is = 0
                discountprice = 0
                tax = subtotal * 0.065
                total = subtotal + tax
        End Select

        'output
        txtSubtotal.Text = subtotal
        txtDiscount.Text = discountprice
        txtTax.Text = tax
        txtTotal.Text = total

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        frmReciept.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashierHome.Click
        frmDefaultCashier.Show()
        Me.Hide()
    End Sub

    Private Sub btnCold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCold.Click
        frmCold.Show()
        Me.Hide()
    End Sub

    Private Sub btnPastries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPastries.Click
        frmPastries.Show()
        Me.Hide()
    End Sub
End Class