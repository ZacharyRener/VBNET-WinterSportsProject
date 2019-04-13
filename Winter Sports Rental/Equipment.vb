Public Class Equipment

    Private product_name As String
    Private product_prices As Array
    Private durationTime As String

    Public Sub New(product_name As String)

        Me.product_name = product_name
        Me.durationTime = Main.cbDuration.Text
        Me.product_prices = {
            {35.0, 45.0, 80.0, 150.0, 280.0},
            {55.0, 65.0, 100.0, 170.0, 300.0},
            {75.0, 85.0, 120.0, 190.0, 320.0},
            {15.0, 25.0, 60.0, 90.0, 200.0},
            {20.0, 30.0, 65.0, 130.0, 280.0},
            {25.0, 35.0, 70.0, 170.0, 340.0},
            {0, 0, 0, 0, 0}
        }

    End Sub

    Public Function get_price() As Double

        Return Me.product_prices(get_product_index(), get_price_index)

    End Function

    Private Function get_product_index() As Integer

        Select Case Me.product_name
            Case "Beginner Skis"
                Return 0
                Exit Select
            Case "Average Skis"
                Return 1
                Exit Select
            Case "Advanced Skis"
                Return 2
                Exit Select
            Case "Beginner Ski Boots"
                Return 3
                Exit Select
            Case "Average Ski Boots"
                Return 4
                Exit Select
            Case "Advanced Ski Boots"
                Return 5
                Exit Select
        End Select

        Return 6

    End Function

    Private Function get_price_index() As Integer

        Select Case Me.durationTime
            Case "1 Day"
                Return 0
                Exit Select
            Case "2 Days"
                Return 1
                Exit Select
            Case "3 Days"
                Return 2
                Exit Select
            Case "1 Week"
                Return 3
                Exit Select
            Case "2 Weeks"
                Return 4
                Exit Select
        End Select

        Return 0

    End Function

End Class
