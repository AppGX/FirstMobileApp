using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            Button btn = null;
            // checkBox1.IsChecked = true;
            // buttin1.Clicked += Buttin1_Clicked;
            for (int i = 0; i < 10; i++)
            {
                btn = new Button
                {
                    Text = $"Кнопка {i}",
                    BackgroundColor = Color.FromRgb(i*9, i*27, i*19),
                };
                btn.Clicked += Button_ClickedAsync;
                _stackLayout.Children.Add(btn);
            }
        }

        private async void Buttin1_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Header", "text...", "ok!?");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            await DisplayAlert("", $"{btn.Text}", "Ok");
        }

        //protected override void OnAppearing()
        //{
        //    StackLayout layout = new StackLayout();

        //    StackLayout horizontalStack = new StackLayout
        //    {
        //        Orientation = StackOrientation.Horizontal,
        //    };

        //    Label label1 = new Label();
        //    label1.Text = "Learn 1";
        //    label1.TextColor = Color.Cyan;
        //    label1.FontSize = 20;
        //    label1.FontAttributes = FontAttributes.Bold;
        //    label1.HorizontalOptions = LayoutOptions.Center;

        //    Entry input = new Entry();
        //    input.Placeholder = "пароль";
        //    input.IsPassword = true;

        //    Entry input1 = new Entry
        //    {
        //        IsEnabled = false,
        //        Text = "*что написано",
        //    };



        //    //---------------------------------
        //    Label sub = new Label
        //    {
        //        Text = "Подписаться",
        //        FontSize = 25,
        //        FontAttributes = FontAttributes.Bold
        //    };
        //    CheckBox checkBox = new CheckBox
        //    {
        //        IsChecked = true,
        //    };

        //    horizontalStack.Children.Add(sub);
        //    horizontalStack.Children.Add(checkBox);


        //    //-----------------------------------

        //    layout.Children.Add(label1);
        //    layout.Children.Add(input);
        //    layout.Children.Add(input1);
        //    layout.Children.Add(horizontalStack);

        //    Content = layout;

        //}
    }
}
