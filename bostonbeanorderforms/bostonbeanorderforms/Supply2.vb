Public Class Supply2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'decreare variable
        Dim soption As Double
        Dim tnum As Double

        Dim sale1 As Double
        Dim sale2 As Double
        Dim sale3 As Double
        Dim sale4 As Double
        Dim sale5 As Double
        Dim sale6 As Double
        

        Dim subtotal As Double
        Dim taxes As Double
        Dim nettotal As Double

        'input
        If CheckBox1.Checked = True Then
            soption = InputBox("Enter the Price of Cups")
            tnum = InputBox("Enter Quantity")
            sale1 = soption * tnum
        End If
        If CheckBox2.Checked = True Then
            soption = InputBox("Enter the Price of the Napkins")
            tnum = InputBox("Enter Quantity")
            sale2 = soption * tnum
        End If

        
        If CheckBox3.Checked = True Then
            soption = InputBox("Enter the Price of the Stirrers")
            tnum = InputBox("Enter Quantity")
            sale3 = soption * tnum
        End If

        If CheckBox4.Checked = True Then
            soption = InputBox("Enter the Price of the Sleeves")
            tnum = InputBox("Enter Quantity")
            sale4 = soption * tnum
        End If
        If CheckBox5.Checked = True Then
            soption = InputBox("Enter the Price of the Utensils")
            tnum = InputBox("Enter Quantity")
            sale5 = soption * tnum
        End If

        If CheckBox6.Checked = True Then
            soption = InputBox("Enter the Price of the Lids")
            tnum = InputBox("Enter Quantity")
            sale6 = soption * tnum
        End If

        subtotal = sale1 + sale2 + sale3 + sale4 + sale5 + sale6
        taxes = subtotal * 0.063
        nettotal = subtotal + taxes

        'output

        TextBox1.Text = sale1.ToString("c")
        TextBox2.Text = sale2.ToString("c")
        TextBox3.Text = sale3.ToString("c")
        TextBox4.Text = sale4.ToString("c")
        TextBox5.Text = sale5.ToString("c")
        TextBox6.Text = sale6.ToString("c")
        


        txttotal.Text = subtotal.ToString("c")
        txttaxes.Text = taxes.ToString("c")
        txtnet.Text = nettotal.ToString("c")

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        txttotal.Text = ""
        txttaxes.Text = ""
        txtnet.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpayroll.Click
        Payroll.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninventory.Click
        Inventory.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbenefits.Click
        Benefits.Show()
        Me.Hide()
    End Sub

    Private Sub Orders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSOrders.Click
        SOrdering.Show()
        Me.Hide()
    End Sub
End Class