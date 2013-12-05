Public Class frmReciept

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotals.Click
        'declare
        Dim hotsubtotal As Double
        Dim hottax As Double
        Dim hottotal As Double
        Dim coldsubtotal As Double
        Dim coldtax As Double
        Dim coldtotal As Double
        Dim pastriessubtotal As Double
        Dim pastriestax As Double
        Dim pastriestotal As Double
        Dim subtotal As Double
        Dim tax As Double
        Dim total As Double

        'inputs
        'Subtotal
        If frmHot.txtTotal.Text = "" Then
            hotsubtotal = 0
        Else
            hotsubtotal = frmHot.txtSubtotal.Text
        End If
        If frmCold.txtTotal.Text = "" Then
            coldsubtotal = 0
        Else
            coldsubtotal = frmCold.txtSubtotal.Text
        End If
        If frmPastries.txtTotal.Text = "" Then
            pastriessubtotal = 0
        Else
            pastriessubtotal = frmPastries.txtSubtotal.Text
        End If

        subtotal = hotsubtotal + coldsubtotal + pastriessubtotal

        'Tax
        If frmHot.txtTotal.Text = "" Then
            hottax = 0
        Else
            hottax = frmHot.txtTax.Text
        End If
        If frmCold.txtTotal.Text = "" Then
            coldtax = 0
        Else
            coldtax = frmCold.txtTax.Text
        End If
        If frmPastries.txtTotal.Text = "" Then
            pastriestax = 0
        Else
            pastriestax = frmPastries.txtTax.Text
        End If

        tax = hottax + coldtax + pastriestax

        'Total
        If frmHot.txtTotal.Text = "" Then
            hottotal = 0
        Else
            hottotal = frmHot.txtTotal.Text
        End If
        If frmCold.txtTotal.Text = "" Then
            coldtotal = 0
        Else
            coldtotal = frmCold.txtTotal.Text
        End If
        If frmPastries.txtTotal.Text = "" Then
            pastriestotal = 0
        Else
            pastriestotal = frmPastries.txtTotal.Text
        End If

        total = hottotal + coldtotal + pastriestotal

        'output
        lblCashierName.Text = frmDefaultCashier.lblCashierName.Text
        lblSubtotalPrice.Text = subtotal
        lblTaxPrice.Text = tax
        lblTotalPrice.Text = total

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashierHome.Click
        frmDefaultCashier.Show()
        Me.Hide()
    End Sub
End Class