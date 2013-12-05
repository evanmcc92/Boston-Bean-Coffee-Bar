Public Class frmCold

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
        chkFruitSmoothie.Checked = False
        chkIcedCappucino.Checked = False
        chkIcedCoffee.Checked = False
        chkIcedLatte.Checked = False

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
        Dim smoothie As Double


        'input
        If chkIcedCoffee.Checked = True Then
            coffee = InputBox("Enter Iced Coffee Price")
        Else
            coffee = 0
        End If
        If chkIcedCappucino.Checked = True Then
            cappucino = InputBox("Enter Iced Cappucino Price")
        Else
            cappucino = 0
        End If
        If chkIcedLatte.Checked = True Then
            latte = InputBox("Enter Iced Latte Price")
        Else
            latte = 0
        End If
        If chkFruitSmoothie.Checked = True Then
            smoothie = InputBox("Enter Fruit Smoothie Price")
        Else
            smoothie = 0
        End If

        price = coffee + latte + cappucino + smoothie
        txtPrice.Text = price

        quant = txtQuantity.Text

        If chkLoyalty.Checked = True Then
            discount = 0.2
        Else
            discount = 0
        End If


        'math
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
        txtPrice.Text = price
        txtSubtotal.Text = subtotal
        txtDiscount.Text = discountprice
        txtTax.Text = tax
        txtTotal.Text = total

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        frmReciept.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmDefaultCashier.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmHot.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmPastries.Show()
        Me.Hide()
    End Sub
End Class