using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace FirstApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page12 : ContentPage
    {
        public Page12()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            WebView webView = new WebView
            {
                Source = "https://www.youtube.com/embed/CvIUHArus8I",
                WidthRequest = 720,
                HeightRequest = 480,
                MinimumHeightRequest = 240,
                MinimumWidthRequest = 360,

            };

            Button but = new Button
            {
                Text = "Open Url",
            };
            but.Clicked += But_Clicked;

            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = {
                    webView,
                    but
                }
            };
        }

        private async void But_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.youtube.com/embed/r-lIGGkZ2Lg");

            await Browser.OpenAsync(uri);
        }
    }
}