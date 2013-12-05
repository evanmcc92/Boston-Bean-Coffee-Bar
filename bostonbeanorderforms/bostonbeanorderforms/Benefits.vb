Public Class Benefits

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Decleare variable

        Dim hours As Single
        Dim payrate As Single
        Dim sglmedical As Single
        Dim sgllife As Single
        Dim sgldental As Single

        Dim sglfee As Single

        Dim total As Single
        Dim grosspay As Integer
        Dim netpay As Single
        Dim benefits As Single
        Dim federal As Single



        'assigned value

        hours = txthours.Text
        payrate = txtpayrate.Text

        grosspay = hours * payrate

        'Select Case monthlytotal
        '    Case 1 To 3
        '        disc = 0.0
        '    Case 4 To 6
        '        disc = 0.05
        '    Case 7 To 9
        '        disc = 0.08
        '    Case 10 To 24
        '        disc = 0.1
        '    Case Else
        '        MessageBox.Show("You have entered the wrong number of months. Please try again", "Data Entry Error",
        '        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End Select

        If radnoplan.Checked Then
            sglfee = grosspay * 0.0
        ElseIf radretirement.Checked Then
            sglfee = grosspay * 0.05
        ElseIf rad401a.Checked Then
            sglfee = grosspay * 0.08
        End If

        If chkmedical.Checked = True Then
            sglmedical = 37.75
        End If

        If chklife.Checked = True Then
            sgllife = 18.35
        End If

        If chkdental.Checked = True Then
            sgldental = 4.0
        End If

        'choosing item
        federal = grosspay * 0.0765
        benefits = sglfee + (sglmedical + sgllife + sgldental)

        total = federal + benefits

        netpay = grosspay - total

        'output
        txtfederal.Text = federal.ToString("c")
        txtbenefits.Text = benefits.ToString("c")
        txtgrosspay.Text = grosspay.ToString("c")
        txtnetpay.Text = netpay.ToString("c")



    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Payroll.txtNetPay.Text = "" Then
            Payroll.Show()
        Else
            txtgrosspay.Text = Payroll.txtNetPay.Text
        End If
        If Payroll.txtEmployeeName.Text = "" Then
            Payroll.Show()
        Else
            TextBox1.Text = Payroll.txtEmployeeName.Text
        End If
        If Payroll.txtHourlySalary.Text = "" Then
            Payroll.Show()
        Else
            txtpayrate.Text = Payroll.txtHourlySalary.Text
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox8.Clear()
        txtbenefits.Clear()
        txtfederal.Clear()
        txtgrosspay.Clear()
        txthours.Clear()
        txtnetpay.Clear()
        txtpayrate.Clear()
        rad401a.Checked = False
        radnoplan.Checked = False
        radretirement.Checked = False
        chkdental.Checked = False
        chkmedical.Checked = False
        chklife.Checked = False

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub Benefits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Payroll.txtEmployeeName.Text = "" Then
            TextBox1.Text = ""
        Else
            TextBox1.Text = Payroll.txtEmployeeName.Text
        End If
        If Payroll.txtEmployeeName.Text = "" Then
            txtpayrate.Text = ""
        Else
            txtpayrate.Text = Payroll.txtHourlySalary.Text
        End If

    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
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

    Private Sub btnSupply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupply.Click
        Supply2.Show()
        Me.Hide()
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        Inventory.Show()
        Me.Hide()
    End Sub
End Class