Public Class SOrdering

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'decreare variable
        Dim soption As Double
        Dim tnum As Double
        Dim sale As Double
        Dim sale1 As Double
        Dim sale2 As Double
        Dim sale3 As Double
        Dim sale4 As Double
        Dim sale5 As Double
        Dim sale6 As Double
        Dim sale7 As Double
        Dim sale8 As Double
        Dim sale9 As Double

        Dim sale10 As Double
        Dim sale11 As Double
        Dim sale12 As Double
        Dim sale13 As Double
        Dim sale14 As Double
        Dim sale15 As Double
        Dim sale16 As Double
        Dim sale17 As Double
        Dim sale18 As Double
        Dim sale19 As Double

        Dim subtotal As Double
        Dim taxes As Double
        Dim nettotal As Double

        'input

        If chkcolombian.Checked = True Then
            soption = InputBox("Enter the Price of the Colombian Coffee")
            tnum = InputBox("Enter Quantity")
            sale = soption * tnum
        End If

        If chkdecaf.Checked = True Then
            soption = InputBox("Enter the Price Decaf Coffee")
            tnum = InputBox("Enter Quantity")
            sale1 = soption * tnum
        End If

        If chkfrench.Checked = True Then
            soption = InputBox("Enter the Price of the Creamer(French Vanilla)")
            tnum = InputBox("Enter Quantity")
            sale2 = soption * tnum
        End If

        If Chkhalf.Checked = True Then
            soption = InputBox("Enter the Price of the Creamer(Half and Half)")
            tnum = InputBox("Enter Quantity")
            sale3 = soption * tnum
        End If

        If CheckBox2.Checked = True Then
            soption = InputBox("Enter the Price of the 2% Milk")
            tnum = InputBox("Enter Quantity")
            sale4 = soption * tnum
        End If

        If CheckBox1.Checked = True Then
            soption = InputBox("Enter the Price of Equal")
            tnum = InputBox("Enter Quantity")
            sale5 = soption * tnum
        End If

        If CheckBox6.Checked = True Then
            soption = InputBox("Enter the Price of Splenda")
            tnum = InputBox("Enter Quantity")
            sale6 = soption * tnum
        End If

        If CheckBox5.Checked = True Then
            soption = InputBox("Enter the Price of the Sugar")
            tnum = InputBox("Enter Quantity")
            sale7 = soption * tnum
        End If

        If CheckBox4.Checked = True Then
            soption = InputBox("Enter the Price of Sugar in the Raw")
            tnum = InputBox("Enter Quantity")
            sale8 = soption * tnum
        End If

        If CheckBox3.Checked = True Then
            soption = InputBox("Enter the Price of Whipped Cream")
            tnum = InputBox("Enter Quantity")
            sale9 = soption * tnum
        End If

        If CheckBox8.Checked = True Then
            soption = InputBox("Enter the Price of Donuts")
            tnum = InputBox("Enter Quantity")
            sale10 = soption * tnum
        End If

        If CheckBox7.Checked = True Then
            soption = InputBox("Enter the Price of Pastries")
            tnum = InputBox("Enter Quantity")
            sale11 = soption * tnum
        End If

        If CheckBox16.Checked = True Then
            soption = InputBox("Enter the Price of the Chocolate Syrup")
            tnum = InputBox("Enter Quantity")
            sale12 = soption * tnum
        End If

        If CheckBox15.Checked = True Then
            soption = InputBox("Enter the Price of the White Chocolate Syrup")
            tnum = InputBox("Enter Quantity")
            sale13 = soption * tnum
        End If

        If CheckBox14.Checked = True Then
            soption = InputBox("Enter the Price of the Caramel Syrup")
            tnum = InputBox("Enter Quantity")
            sale14 = soption * tnum
        End If

        If CheckBox13.Checked = True Then
            soption = InputBox("Enter the Price of the Chai Syrup")
            tnum = InputBox("Enter Quantity")
            sale15 = soption * tnum
        End If

        If CheckBox12.Checked = True Then
            soption = InputBox("Enter the Price of the Hazelnut Syrup")
            tnum = InputBox("Enter Quantity")
            sale16 = soption * tnum
        End If

        If CheckBox11.Checked = True Then
            soption = InputBox("Enter the Price of the Irish Cream Syrup")
            tnum = InputBox("Enter Quantity")
            sale17 = soption * tnum
        End If

        If CheckBox10.Checked = True Then
            soption = InputBox("Enter the Price of the Vanilla Syrup")
            tnum = InputBox("Enter Quantity")
            sale18 = soption * tnum
        End If

        If CheckBox9.Checked = True Then
            soption = InputBox("Enter the Price of the Rasberry Syrup")
            tnum = InputBox("Enter Quantity")
            sale19 = soption * tnum
        End If

        subtotal = sale + sale1 + sale2 + sale3 + sale4 + sale5 + sale6 + sale7 + sale8 + sale9 + sale10 + sale11 + sale12 + sale13 + sale14 + sale15 + sale16 + sale17 + sale18 + sale19
        taxes = subtotal * 0.063
        nettotal = subtotal + taxes

        'output

        TextBox1.Text = sale.ToString("c")
        TextBox2.Text = sale1.ToString("c")
        TextBox4.Text = sale2.ToString("c")
        TextBox3.Text = sale3.ToString("c")
        TextBox6.Text = sale4.ToString("c")
        TextBox5.Text = sale5.ToString("c")
        TextBox10.Text = sale6.ToString("c")
        TextBox9.Text = sale7.ToString("c")
        TextBox8.Text = sale8.ToString("c")
        TextBox7.Text = sale9.ToString("c")


        TextBox42.Text = sale10.ToString("c")
        TextBox41.Text = sale11.ToString("c")
        TextBox58.Text = sale12.ToString("c")
        TextBox57.Text = sale13.ToString("c")
        TextBox56.Text = sale14.ToString("c")
        TextBox55.Text = sale15.ToString("c")
        TextBox54.Text = sale16.ToString("c")
        TextBox53.Text = sale17.ToString("c")
        TextBox52.Text = sale18.ToString("c")
        TextBox48.Text = sale19.ToString("c")



        txttotal.Text = subtotal.ToString("c")
        txttaxes.Text = taxes.ToString("c")
        txtnet.Text = nettotal.ToString("c")

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub TextBox60_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox62_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox59_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox63_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox65_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox66_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox68_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox67_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox61_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox64_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox51_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox45_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox46_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox49_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox47_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox19_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        chkcolombian.Checked = False
        chkdecaf.Checked = False
        chkfrench.Checked = False

        Chkhalf.Checked = False

        CheckBox2.Checked = False
        CheckBox1.Checked = False
        CheckBox6.Checked = False

        CheckBox5.Checked = False

        CheckBox4.Checked = False

        CheckBox3.Checked = False

        CheckBox8.Checked = False

        CheckBox7.Checked = False
        CheckBox16.Checked = False
        CheckBox15.Checked = False
        CheckBox14.Checked = False
        CheckBox13.Checked = False
        CheckBox12.Checked = False
        CheckBox11.Checked = False
        CheckBox10.Checked = False
        CheckBox9.Checked = False
        TextBox1.Clear()

        TextBox2.Clear()

        TextBox4.Clear()

        TextBox3.Clear()

        TextBox6.Clear()

        TextBox5.Clear()

        TextBox10.Clear()

        TextBox9.Clear()

        TextBox8.Clear()

        TextBox7.Clear()

        TextBox42.Clear()

        TextBox41.Clear()

        TextBox58.Clear()

        TextBox57.Clear()

        TextBox56.Clear()

        TextBox55.Clear()

        TextBox54.Clear()

        TextBox53.Clear()

        TextBox52.Clear()

        TextBox48.Clear()




        txttotal.Clear()

        txttaxes.Clear()

        txtnet.Clear()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Payroll.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Inventory.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Benefits.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Supply2.Show()
        Me.Hide()
    End Sub
End Class