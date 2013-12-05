Public Class frmPastries

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
        chkBagel.Checked = False
        chkCroissant.Checked = False
        chkDonut.Checked = False
        chkDanish.Checked = False
        chkScone.Checked = False

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
        Dim bagel As Double
        Dim donut As Double
        Dim croissant As Double
        Dim scone As Double
        Dim danish As Double

        'input
        If chkBagel.Checked = True Then
            bagel = InputBox("Enter Bagel Price")
        Else
            bagel = 0
        End If
        If chkDonut.Checked = True Then
            donut = InputBox("Enter Donut Price")
        Else
            donut = 0
        End If
        If chkCroissant.Checked = True Then
            croissant = InputBox("Enter Croissant Price")
        Else
            croissant = 0
        End If
        If chkScone.Checked = True Then
            scone = InputBox("Enter Scone Price")
        Else
            scone = 0
        End If
        If chkDanish.Checked = True Then
            danish = InputBox("Enter Danish Price")
        Else
            danish = 0
        End If

        price = bagel + donut + croissant + scone + danish
        txtPrice.Text = price
        quant = txtQuantity.Text

        'math
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
        frmCold.Show()
        Me.Hide()
    End Sub
End Class