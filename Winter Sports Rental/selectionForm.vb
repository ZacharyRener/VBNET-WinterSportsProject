Public Class selectionForm

    Dim selectedRow As Integer = -1
    Dim currentIndex As Integer = 1
    Dim customerId As Integer = CInt(Math.Ceiling(Rnd() * 502)) + 1
    Dim invoiceId As Integer = CInt(Math.Ceiling(Rnd() * 931)) + 1

    Private Sub btnGo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub selectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyDataSet.FinalInvoices' table. You can move, or remove it, as needed.
        Me.FinalInvoicesTableAdapter.Fill(Me.MyDataSet.FinalInvoices)


    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.FinalInvoicesTableAdapter.FillBy(Me.MyDataSet.FinalInvoices, CType(IdNumberToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton_Click_1(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.FinalInvoicesTableAdapter.FillBy(Me.MyDataSet.FinalInvoices, CType(IdNumberToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.FinalInvoicesTableAdapter.FillBy1(Me.MyDataSet.FinalInvoices, CType(gbTxtLastName.Text, String))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim row As DataGridViewRow = FinalInvoicesDataGridView.Rows(0)
        lblFirstName.Text = row.Cells(2).Value.ToString
        lblLastNameFinal.Text = row.Cells(3).Value.ToString
        lblAddr.Text = row.Cells(4).Value.ToString
        lblCity.Text = row.Cells(5).Value.ToString
        lblState.Text = row.Cells(6).Value.ToString
        lblZip.Text = row.Cells(7).Value.ToString
        lblPhoneNumber.Text = row.Cells(8).Value.ToString
        lblRentalDate.Text = (Date.Today()).ToString("MM/dd/yyyy")

        Select Case Main.cbDuration.Text
            Case "1 Day"
                lblDueDate.Text = (DateAdd("d", 1, lblRentalDate.Text)).ToString("MM/dd/yyyy")
                Exit Select
            Case "2 Days"
                lblDueDate.Text = (DateAdd("d", 2, lblRentalDate.Text)).ToString("MM/dd/yyyy")
                Exit Select
            Case "3 Days"
                lblDueDate.Text = (DateAdd("d", 3, lblRentalDate.Text)).ToString("MM/dd/yyyy")
                Exit Select
            Case "1 Week"
                lblDueDate.Text = (DateAdd("d", 7, lblRentalDate.Text)).ToString("MM/dd/yyyy")
                Exit Select
            Case "2 Weeks"
                lblDueDate.Text = (DateAdd("d", 14, lblRentalDate.Text)).ToString("MM/dd/yyyy")
                Exit Select
        End Select

        Dim equipmentList As String = ""
        For Each item In Main.lbProducts.SelectedItems
            Dim row2 As DataRow = item.Row
            equipmentList += (Trim(row2("ProductName"))) + ", "
        Next

        lblRentedEquipment.Text = equipmentList
        lblSubTotal.Text = Main.lblEquipRentals.Text
        lblTax.Text = Main.lblTax.Text
        lblInsurance.Text = Main.lblInsurance.Text
        lblDeposit.Text = Main.lblDeposit.Text
        lblBalance.Text = Main.lblBalanceDue.Text.Substring(0, Main.lblBalanceDue.Text.Length - 1)
        Me.customerId = CInt(Math.Ceiling(Rnd() * 931)) + 1
        Me.invoiceId = CInt(Math.Ceiling(Rnd() * 502)) + 1
        lblCustomerId.Text = Me.customerId
        lblInvoiceNumber.Text = Me.invoiceId

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblFirstName.Text = txtFirstName.Text
        lblLastNameFinal.Text = txtLastName.Text
        lblAddr.Text = txtAddress.Text
        lblCity.Text = txtCity.Text
        lblState.Text = txtState.Text
        lblZip.Text = txtZip.Text
        lblPhoneNumber.Text = txtPhoneNum.Text
        lblRentalDate.Text = (Date.Today()).ToString("MM/dd/yyyy")

        Select Case Main.cbDuration.Text
            Case "1 Day"
                lblDueDate.Text = (DateAdd("d", 1, lblRentalDate.Text)).ToString("MM/dd/yyyy")
                Exit Select
            Case "2 Days"
                lblDueDate.Text = (DateAdd("d", 2, lblRentalDate.Text)).ToString("MM/dd/yyyy")
                Exit Select
            Case "3 Days"
                lblDueDate.Text = (DateAdd("d", 3, lblRentalDate.Text)).ToString("MM/dd/yyyy")
                Exit Select
            Case "1 Week"
                lblDueDate.Text = (DateAdd("d", 7, lblRentalDate.Text)).ToString("MM/dd/yyyy")
                Exit Select
            Case "2 Weeks"
                lblDueDate.Text = (DateAdd("d", 14, lblRentalDate.Text)).ToString("MM/dd/yyyy")
                Exit Select
        End Select

        Dim equipmentList As String = ""
        For Each item In Main.lbProducts.SelectedItems
            Dim row As DataRow = item.Row
            equipmentList += (Trim(row("ProductName"))) + ", "
        Next

        lblRentedEquipment.Text = equipmentList
        lblSubTotal.Text = Main.lblEquipRentals.Text
        lblTax.Text = Main.lblTax.Text
        lblInsurance.Text = Main.lblInsurance.Text
        lblDeposit.Text = Main.lblDeposit.Text
        lblBalance.Text = Main.lblBalanceDue.Text.Substring(0, Main.lblBalanceDue.Text.Length - 1)
        lblCustomerId.Text = Me.customerId
        lblInvoiceNumber.Text = Me.invoiceId
    End Sub

    Private Sub btnCancelInvoice_Click(sender As Object, e As EventArgs) Handles btnCancelInvoice.Click
        lblFirstName.Text = ""
        lblLastNameFinal.Text = ""
        lblAddr.Text = ""
        lblCity.Text = ""
        lblState.Text = ""
        lblZip.Text = ""
        lblPhoneNumber.Text = ""
        lblRentalDate.Text = ""
        lblRentedEquipment.Text = ""
        lblDueDate.Text = ""
        lblSubTotal.Text = ""
        lblTax.Text = ""
        lblInsurance.Text = ""
        lblDeposit.Text = ""
        lblBalance.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZip.Text = ""
        txtPhoneNum.Text = ""
    End Sub

    Private Sub btnSubmitInvoice_Click(sender As Object, e As EventArgs) Handles btnSubmitInvoice.Click

        Try
            Me.FinalInvoicesTableAdapter.InsertQuery(customerId, invoiceId, lblFirstName.Text, lblLastNameFinal.Text, lblAddr.Text, lblCity.Text, lblState.Text, lblZip.Text, lblPhoneNumber.Text, lblRentalDate.Text, lblRentedEquipment.Text, lblDueDate.Text, Main.lblEquipRentals.Text, Main.lblTax.Text, Main.lblInsurance.Text, Main.lblDeposit.Text, Main.lblBalanceDue.Text)
            Me.FinalInvoicesTableAdapter.Update(MyDataSet.FinalInvoices)
            Me.EquipmentTableAdapter1.UpdateQuery(1, lblCustomerId.Text, lblInvoiceNumber.Text)
            MsgBox("Your invoice has been successfully added to the database.")
            Main.lblEquipRentals.Text = "$???"
            Main.lblInsurance.Text = "$???"
            Main.lblTax.Text = "$???"
            Main.lblDeposit.Text = "$???"
            Main.lblBalanceDue.Text = "$???"
            Main.txtDeposit.Text = "0"
            Main.cboxWaiver.Checked = False
            Main.cboxInsurance.Checked = False
            Main.cbDuration.Text = ""
            Me.Close()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class