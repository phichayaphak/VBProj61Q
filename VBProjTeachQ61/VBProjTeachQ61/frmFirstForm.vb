Public Class frmFirstForm

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'ค่าจ้าง (lblResult.text)  =  ชั่วโมงการทำงาน (txtHours.text)  * อัตราค่าจ้างต่อชั่วโมง  (txtPayRate.text) 
        'ภาษี = ค่าจ้าง * 0.03
        'ชั่วโมงการทำงาน  => txtHours.text
        'อัตราค่าจ้างต่อชั่วโมง => txtPayRate.text

        'lblResult.Text = Val(txtHours.Text) * Val(txtPayRate.Text)
        'lblTax.Text = lblResult.Text * 0.03
        ' int Hours
        Dim Hours As Integer
        Dim PayRate As Long
        Dim Result, Tax As Long

        Hours = Val(txtHours.Text)
        PayRate = Val(txtPayRate.Text)

        Result = Hours * PayRate
        Tax = Result * 0.03

        lblResult.Text = Result
        lblTax.Text = Tax

    End Sub

    

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

    End Sub


End Class
