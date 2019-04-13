<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cbDuration = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboxWaiver = New System.Windows.Forms.CheckBox()
        Me.cboxInsurance = New System.Windows.Forms.CheckBox()
        Me.btnCalcTotal = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEquipRentals = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.lblBalanceDue = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.llblViewWeather = New System.Windows.Forms.LinkLabel()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MyDataSet = New Winter_Sports_Rental.MyDataSet()
        Me.EquipmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipmentTableAdapter = New Winter_Sports_Rental.MyDataSetTableAdapters.EquipmentTableAdapter()
        Me.lbProducts = New System.Windows.Forms.ListBox()
        Me.btnGatherInfo = New System.Windows.Forms.Button()
        CType(Me.MyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbDuration
        '
        Me.cbDuration.DisplayMember = "j"
        Me.cbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDuration.FormattingEnabled = True
        Me.cbDuration.Items.AddRange(New Object() {"1 Day", "2 Days", "3 Days", "1 Week", "2 Weeks"})
        Me.cbDuration.Location = New System.Drawing.Point(180, 29)
        Me.cbDuration.Name = "cbDuration"
        Me.cbDuration.Size = New System.Drawing.Size(139, 21)
        Me.cbDuration.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Our Products:"
        '
        'cboxWaiver
        '
        Me.cboxWaiver.AutoSize = True
        Me.cboxWaiver.Location = New System.Drawing.Point(12, 132)
        Me.cboxWaiver.Name = "cboxWaiver"
        Me.cboxWaiver.Size = New System.Drawing.Size(202, 17)
        Me.cboxWaiver.TabIndex = 3
        Me.cboxWaiver.Text = "Yes, I have signed the liability waiver."
        Me.cboxWaiver.UseVisualStyleBackColor = True
        '
        'cboxInsurance
        '
        Me.cboxInsurance.AutoSize = True
        Me.cboxInsurance.Location = New System.Drawing.Point(12, 155)
        Me.cboxInsurance.Name = "cboxInsurance"
        Me.cboxInsurance.Size = New System.Drawing.Size(308, 17)
        Me.cboxInsurance.TabIndex = 4
        Me.cboxInsurance.Text = "Yes, I would like to purchase damage insurance (Extra 10%)"
        Me.cboxInsurance.UseVisualStyleBackColor = True
        '
        'btnCalcTotal
        '
        Me.btnCalcTotal.Location = New System.Drawing.Point(12, 178)
        Me.btnCalcTotal.Name = "btnCalcTotal"
        Me.btnCalcTotal.Size = New System.Drawing.Size(308, 23)
        Me.btnCalcTotal.TabIndex = 5
        Me.btnCalcTotal.Text = "&Calculate Total"
        Me.btnCalcTotal.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cost Breakdown:"
        '
        'lblEquipRentals
        '
        Me.lblEquipRentals.AutoSize = True
        Me.lblEquipRentals.Location = New System.Drawing.Point(117, 236)
        Me.lblEquipRentals.Name = "lblEquipRentals"
        Me.lblEquipRentals.Size = New System.Drawing.Size(31, 13)
        Me.lblEquipRentals.TabIndex = 7
        Me.lblEquipRentals.Text = "$???"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Equipment Rentals:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Insurance:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tax:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Less Deposit:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(178, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Balance Due:"
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Location = New System.Drawing.Point(117, 250)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(31, 13)
        Me.lblInsurance.TabIndex = 13
        Me.lblInsurance.Text = "$???"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(117, 263)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(31, 13)
        Me.lblTax.TabIndex = 14
        Me.lblTax.Text = "$???"
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Location = New System.Drawing.Point(117, 276)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(31, 13)
        Me.lblDeposit.TabIndex = 15
        Me.lblDeposit.Text = "$???"
        '
        'lblBalanceDue
        '
        Me.lblBalanceDue.AutoSize = True
        Me.lblBalanceDue.Location = New System.Drawing.Point(283, 213)
        Me.lblBalanceDue.Name = "lblBalanceDue"
        Me.lblBalanceDue.Size = New System.Drawing.Size(31, 13)
        Me.lblBalanceDue.TabIndex = 16
        Me.lblBalanceDue.Text = "$???"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(245, 276)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'llblViewWeather
        '
        Me.llblViewWeather.AutoSize = True
        Me.llblViewWeather.Location = New System.Drawing.Point(246, 260)
        Me.llblViewWeather.Name = "llblViewWeather"
        Me.llblViewWeather.Size = New System.Drawing.Size(74, 13)
        Me.llblViewWeather.TabIndex = 18
        Me.llblViewWeather.TabStop = True
        Me.llblViewWeather.Text = "View Weather"
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(181, 82)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(139, 20)
        Me.txtDeposit.TabIndex = 19
        Me.txtDeposit.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(179, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Deposit Amount:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(178, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Duration of Rental:"
        '
        'MyDataSet
        '
        Me.MyDataSet.DataSetName = "MyDataSet"
        Me.MyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EquipmentBindingSource
        '
        Me.EquipmentBindingSource.DataMember = "Equipment"
        Me.EquipmentBindingSource.DataSource = Me.MyDataSet
        '
        'EquipmentTableAdapter
        '
        Me.EquipmentTableAdapter.ClearBeforeFill = True
        '
        'lbProducts
        '
        Me.lbProducts.DataSource = Me.EquipmentBindingSource
        Me.lbProducts.DisplayMember = "ProductName"
        Me.lbProducts.FormattingEnabled = True
        Me.lbProducts.Location = New System.Drawing.Point(11, 29)
        Me.lbProducts.Name = "lbProducts"
        Me.lbProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbProducts.Size = New System.Drawing.Size(151, 95)
        Me.lbProducts.TabIndex = 23
        '
        'btnGatherInfo
        '
        Me.btnGatherInfo.Location = New System.Drawing.Point(198, 305)
        Me.btnGatherInfo.Name = "btnGatherInfo"
        Me.btnGatherInfo.Size = New System.Drawing.Size(122, 23)
        Me.btnGatherInfo.TabIndex = 24
        Me.btnGatherInfo.Text = "&Gather Customer Info"
        Me.btnGatherInfo.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 342)
        Me.Controls.Add(Me.btnGatherInfo)
        Me.Controls.Add(Me.lbProducts)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.llblViewWeather)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblBalanceDue)
        Me.Controls.Add(Me.lblDeposit)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblInsurance)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblEquipRentals)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCalcTotal)
        Me.Controls.Add(Me.cboxInsurance)
        Me.Controls.Add(Me.cboxWaiver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbDuration)
        Me.Name = "Main"
        Me.Text = "Winter Sports Rentals"
        CType(Me.MyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbDuration As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboxWaiver As CheckBox
    Friend WithEvents cboxInsurance As CheckBox
    Friend WithEvents btnCalcTotal As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEquipRentals As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblInsurance As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblDeposit As Label
    Friend WithEvents lblBalanceDue As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents llblViewWeather As LinkLabel
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MyDataSet As MyDataSet
    Friend WithEvents EquipmentBindingSource As BindingSource
    Friend WithEvents EquipmentTableAdapter As MyDataSetTableAdapters.EquipmentTableAdapter
    Friend WithEvents lbProducts As ListBox
    Friend WithEvents btnGatherInfo As Button
End Class
