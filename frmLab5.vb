Public Class frmLab5
    Dim decTotal As Integer
    Dim decDiscount As Integer
    Dim decNet As Integer
    Dim decCredit As Integer

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
   
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        lblTotal.Text = FormatNumber(decTotal)


        If txtProduct.Text = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")

        End If

        If radMember.Checked = True And radPaid.Checked = True Then

            If decTotal < 1000 Then
                lblPaid.Text = FormatNumber(decTotal)

            ElseIf decTotal < 5000 Then
                decDiscount = decTotal * 0.05
                lblPaid.Text = decTotal - decDiscount
                lblDiscount.Text = FormatNumber(decDiscount)

            ElseIf decTotal < 10000 Then
                decDiscount = decTotal * 0.1
                lblPaid.Text = decTotal - decDiscount
                lblDiscount.Text = FormatNumber(decDiscount)

            ElseIf decTotal >= 10000 Then
                decDiscount = decTotal * 0.15
                lblPaid.Text = FormatNumber(decTotal - decDiscount)
                lblDiscount.Text = FormatNumber(decDiscount)



            End If

        End If
        If radCredit.Checked = True Then
            lblCreDit.Text = FormatNumber(decTotal)
        ElseIf radOther.Checked = True Then
            lblPaid.Text = FormatNumber(decTotal)
        End If


    End Sub

    Private Sub radMember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMember.CheckedChanged
        lblCreDit.Text = ""
        lblDiscount.Text = ""
        lblPaid.Text = ""
        radCredit.Enabled = True

    End Sub

    Private Sub radOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOther.CheckedChanged
        lblCredit.Text = ""
        lblDiscount.Text = ""
        lblPaid.Text = ""
        radCredit.Enabled = False
        radPaid.Checked = True

    End Sub

   
    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged

        Call btnCalculate_Click(sender, e)

    End Sub

    Private Sub txtUnit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnit.TextChanged
        Call btnCalculate_Click(sender, e)
    End Sub

    Private Sub radPaid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPaid.CheckedChanged
        lblCreDit.Text = ""
        lblDiscount.Text = ""
        lblPaid.Text = ""
    End Sub

    Private Sub radCredit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCredit.CheckedChanged
        lblCreDit.Text = ""
        lblDiscount.Text = ""
        lblPaid.Text = ""
    End Sub
End Class