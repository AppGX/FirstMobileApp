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
    public partial class Page10 : ContentPage
    {
        public Page10()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            BackgroundColor = Color.Pink;

            StackLayout stackLayout = new StackLayout
            {
                BackgroundColor = Color.Green,
                Margin = new Thickness(5, 10, 15, 20),
                Padding = new Thickness(25, 30, 35, 40),
                Children =
                {
                    new BoxView
                    {
                        BackgroundColor = Color.Yellow,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                    },
                    new BoxView
                    {
                        BackgroundColor = Color.LimeGreen,
                        Margin = new Thickness(0, 30, 0, 0),
                        VerticalOptions = LayoutOptions.FillAndExpand,
                    }
                }
            };

            Content = stackLayout;
        }
    }
}