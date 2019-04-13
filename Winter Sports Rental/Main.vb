Public Class Main

    Private Sub btnCalcTotal_Click(sender As Object, e As EventArgs) Handles btnCalcTotal.Click

        If is_valid_customer() Then
            Dim customer As Customer = New Customer
            set_price_labels(customer)
        Else
            MsgBox("Please make sure you've selected a product, you've signed the liability waiver, and that you've entered a deposit amount above 0.")
        End If


    End Sub

    Private Function is_valid_customer() As Boolean
        If lbProducts.SelectedItems.Count > 0 And cboxWaiver.Checked And txtDeposit.TextLength > 0 Then
            Return Convert.ToInt32(txtDeposit.Text) >= 0
        End If
        Return False
    End Function

    Private Function set_price_labels(customer As Customer)
        lblBalanceDue.Text = FormatCurrency(customer.calculate_total)
        lblEquipRentals.Text = FormatCurrency(customer.price_equipment_rental)
        lblInsurance.Text = FormatCurrency(customer.price_insurance)
        lblTax.Text = FormatCurrency(customer.price_tax)
        lblDeposit.Text = FormatCurrency(customer.depositAmount)
        Return vbNull
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub llblViewWeather_Click(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblViewWeather.LinkClicked
        Dim weatherForm = New currentWeather()
        weatherForm.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyDataSet.Equipment' table. You can move, or remove it, as needed.
        Me.EquipmentTableAdapter.Fill(Me.MyDataSet.Equipment)

    End Sub

    Private Sub btnGatherInfo_Click(sender As Object, e As EventArgs) Handles btnGatherInfo.Click
        selectionForm.Show()
    End Sub
End Class
