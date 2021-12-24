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
    public partial class Page7 : ContentPage
    {
        public Page7()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            StackLayout layout = new StackLayout
            {
                Children = {
                    new Label { Text = "Основные цвета", Margin = new Thickness(0, 0, 0, 10)},
                    new BoxView { Color = Color.Red},
                    new BoxView { Color = Color.Green},
                    new BoxView { Color = Color.Blue},
                    new Label { Text = "Смесовые цвета", Margin = new Thickness(0, 30, 0, 10)},
                    new BoxView { Color = Color.Yellow},
                    new BoxView { Color = Color.Orange},
                    new BoxView { Color = Color.Purple},
                },
                Spacing = 0,
            };
            
            // Content = layout;

        }
    }
}