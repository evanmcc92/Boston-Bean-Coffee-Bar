Public Class Payroll

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWednesday2.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTuesday2.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWednesday1.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTuesday1.TextChanged

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub cmdProcessIt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcessIt.Click
        Dim monday1 As Double
        Dim tuesday1 As Double
        Dim wednesday1 As Double
        Dim thursday1 As Double
        Dim friday1 As Double
        Dim saturday1 As Double
        Dim sunday1 As Double
        Dim monday2 As Double
        Dim tuesday2 As Double
        Dim wednesday2 As Double
        Dim thursday2 As Double
        Dim friday2 As Double
        Dim saturday2 As Double
        Dim sunday2 As Double
        Dim totalHoursWeek1 As Double
        Dim totalHoursWeek2 As Double

        Dim regHours1 As Double
        Dim regHours2 As Double
        Dim ovtHours1 As Double
        Dim ovtHours2 As Double
        Dim regAmount1 As Double
        Dim regAmount2 As Double
        Dim ovtAmount1 As Double
        Dim ovtAmount2 As Double

        Dim regularHours As Double
        Dim overtimeHours As Double
        Dim regularAmount As Double
        Dim overtimeAmount As Double
        Dim totalEarnings As Double

        Dim hourlySalary As Double

        ' Retrieve the hourly salary
        hourlySalary = CDbl(Me.txtHourlySalary.Text)
        ' Retrieve the time for each day
        ' First Week
        monday1 = CDbl(Me.txtMonday1.Text)
        tuesday1 = CDbl(Me.txtTuesday1.Text)
        wednesday1 = CDbl(Me.txtWednesday1.Text)
        thursday1 = CDbl(Me.txtThursday1.Text)
        friday1 = CDbl(Me.txtFriday1.Text)
        saturday1 = CDbl(Me.txtSaturday1.Text)
        sunday1 = CDbl(Me.txtSunday1.Text)

        ' Second Week
        monday2 = CDbl(Me.txtMonday2.Text)
        tuesday2 = CDbl(Me.txtTuesday2.Text)
        wednesday2 = CDbl(Me.txtWednesday2.Text)
        thursday2 = CDbl(Me.txtThursday2.Text)
        friday2 = CDbl(Me.txtFriday2.Text)
        saturday2 = CDbl(Me.txtSaturday2.Text)
        sunday2 = CDbl(Me.txtSunday2.Text)

        ' Calculate the total number of hours for each week
        totalHoursWeek1 = monday1 + tuesday1 + wednesday1 + thursday1 + friday1 + saturday1 + sunday1
        totalHoursWeek2 = monday2 + tuesday2 + wednesday2 + thursday2 + friday2 + saturday2 + sunday2

        ' The overtime is paid time and half
        Dim ovtSalary As Double

        ovtSalary = hourlySalary * 1.5

        ' If the employee worked under 40 hours, there is no overtime
        If totalHoursWeek1 < 40 Then
            regHours1 = totalHoursWeek1
            regAmount1 = hourlySalary * regHours1
            ovtHours1 = 0
            ovtAmount1 = 0
            ' If the employee worked over 40 hours, calculate the overtime
        ElseIf totalHoursWeek1 >= 40 Then
            regHours1 = 40
            regAmount1 = hourlySalary * 40
            ovtHours1 = totalHoursWeek1 - 40
            ovtAmount1 = ovtHours1 * ovtSalary
        End If

        If totalHoursWeek2 < 40 Then
            regHours2 = totalHoursWeek2
            regAmount2 = hourlySalary * regHours2
            ovtHours2 = 0
            ovtAmount2 = 0
        ElseIf totalHoursWeek2 >= 40 Then
            regHours2 = 40
            regAmount2 = hourlySalary * 40
            ovtHours2 = totalHoursWeek2 - 40
            ovtAmount2 = ovtHours2 * ovtSalary
        End If

        regularHours = regHours1 + regHours2
        overtimeHours = ovtHours1 + ovtHours2
        regularAmount = regAmount1 + regAmount2
        overtimeAmount = ovtAmount1 + ovtAmount2
        totalEarnings = regularAmount + overtimeAmount

        Me.txtRegularHours.Text = CStr(regularHours)
        Me.txtOvertimeHours.Text = CStr(overtimeHours)
        Me.txtRegularAmount.Text = regularAmount
        Me.txtOvertimeAmount.Text = overtimeAmount

        Me.txtNetPay.Text = totalEarnings


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SOrdering.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' First Week
        txtMonday1.Clear()
        txtTuesday1.Clear()
        txtWednesday1.Clear()

        txtThursday1.Clear()

        txtFriday1.Clear()

        txtSaturday1.Clear()

        txtSunday1.Clear()


        ' Second Week
        txtMonday2.Clear()

        txtTuesday2.Clear()

        txtWednesday2.Clear()

        txtThursday2.Clear()

        txtFriday2.Clear()

        txtSaturday2.Clear()

        txtSunday2.Clear()

        txtEmployeeName.Clear()
        txtHourlySalary.Clear()
        txtNetPay.Clear()
        txtOvertimeAmount.Clear()
        txtOvertimeHours.Clear()
        txtRegularAmount.Clear()
        txtRegularHours.Clear()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Benefits.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Supply2.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Inventory.Show()
        Me.Hide()

    End Sub
End Class
