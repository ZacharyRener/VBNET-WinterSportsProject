Public Class currentWeather
    Private Sub llblWeathercom_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblWeathercom.LinkClicked
        wbWeather.Navigate(New Uri("https://weather.com/weather/tenday/l/75670:4:US"))
    End Sub

    Private Sub llblAccu_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblAccu.LinkClicked
        wbWeather.Navigate(New Uri("https://www.accuweather.com/en/us/marshall-tx/75670/weather-radar/335922"))
    End Sub

    Private Sub llblWeather_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblWeather.LinkClicked
        wbWeather.Navigate(New Uri("https://www.weatherbug.com/weather-forecast/now/"))
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        wbWeather.Navigate(New Uri(txtUrl.Text.ToString()))

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class