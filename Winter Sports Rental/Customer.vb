Public Class Customer

    Private selectedProducts As New List(Of Equipment)
    Private hasLiability As Boolean
    Private hasInsurance As Boolean
    Property depositAmount As Double

    Property price_equipment_rental As Double
    Property price_insurance As Double
    Property price_tax As Double

    Const insurance_rate As Double = 0.1
    Const tax_rate As Double = 0.865

    Public Sub New()


        For Each item In Main.lbProducts.SelectedItems
            Dim row As DataRow = item.Row
            Me.selectedProducts.Add(New Equipment(Trim(row("ProductName"))))
        Next

        Me.depositAmount = Main.txtDeposit.Text
        Me.hasLiability = Main.cboxWaiver.Checked
        Me.hasInsurance = Main.cboxInsurance.Checked

        Me.price_equipment_rental = 0.0
        Me.price_insurance = 0.0
        Me.price_tax = 0.0

    End Sub

    Public Function calculate_total()

        For Each product In selectedProducts
            Me.price_equipment_rental += product.get_price()
        Next

        If (Me.hasInsurance) Then
            price_insurance = Me.price_equipment_rental * insurance_rate
        End If

        price_tax = Math.Abs((Me.price_equipment_rental * tax_rate) - Me.price_equipment_rental)

        Return (Me.price_equipment_rental + Me.price_insurance + Me.price_tax) - Me.depositAmount

    End Function

End Class
