Public Class frmDefaultCashier


    Private Sub btnCold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCold.Click
        frmCold.Show()
        Me.Hide()
    End Sub

    Private Sub btnHot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHot.Click
        frmHot.Show()
        Me.Hide()
    End Sub

    Private Sub btnPastries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPastries.Click
        frmPastries.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub frmDefault_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'declare
        Dim employee As String

        'input
        employee = InputBox("Enter Employee Name")

        'output
        lblCashierName.Text = employee
    End Sub
End Class
