using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace learningxamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void getWeather_Clicked(object sender, EventArgs e)
        {
            const string apiKey = "c77db93519429fc7bad7fdb7feb1c182";
            string city = userInput.Text.Trim();
            if (city.Length < 2) 
            {
               await DisplayAlert("Error", "City name is to short", "ok");
               return;
            }
            string apiPath = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(apiPath);

            var json = JObject.Parse(response);
            double temp = double.Parse(json["main"]["temp"].ToString()) ;
            result.Text = "Current temperature is " + Math.Floor(temp)+"°";

        }
    }
}
