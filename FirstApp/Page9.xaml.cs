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
    public partial class Page9 : ContentPage
    {
        public Page9()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            StackLayout stackLayout = new StackLayout();

            Frame frame1 = new Frame
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new BoxView { Color = Color.Aqua },
                        new Label { Text = "1 elemnt", VerticalOptions = LayoutOptions.Center }
                    },
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 15,
                },
                BorderColor = Color.Red,
            };
            Frame frame2 = new Frame
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new BoxView { Color = Color.Cyan },
                        new Label { Text = "2 elemnt", VerticalOptions = LayoutOptions.Center }
                    },
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 15,
                },
                BorderColor = Color.Red,
            };
            Frame frame3 = new Frame
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new BoxView { Color = Color.Yellow },
                        new Label { Text = "3 elemnt", VerticalOptions = LayoutOptions.Center }
                    },
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 15,
                },
                BorderColor = Color.Red,
            };

            stackLayout.Children.Add(frame1);
            stackLayout.Children.Add(frame2);
            stackLayout.Children.Add(frame3);

            Content = stackLayout;
        }
    }
}