﻿Public Class frmFirst

    
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'ค้าจ้าง = ชั่วโมงการทำงาน * อัตราค่าจ้าง
        'ชั่วโมงการทำงาน => txtHours.text
        'อัตราค่าจ้าง => txtPayrate.text
        'lblResult.text
        lblResult.Text = txtHours.Text * txtPayrate.Text



    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
