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
    public partial class Page8 : ContentPage
    {
        public Page8()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            Content = new StackLayout
            {
                Margin = new Thickness(15),
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Label {Text="Слева", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.Start},
                    new Label {Text="По центру", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.Center},
                    new Label {Text="Справа", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.End},
                    new Label {Text="На всю ширину", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.Fill},
                },
            };
        }
    }
}