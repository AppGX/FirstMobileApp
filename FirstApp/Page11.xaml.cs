using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page11 : ContentPage
    {
        public Page11()
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

            Content = new StackLayout{
                Orientation = StackOrientation.Vertical,
                Children = {
                    webView
                }
            };
        }
    }
}