using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace learningxamarin
{
    public partial class MainPage : ContentPage
    {

        Button button;

        public MainPage()
        {
            InitializeComponent();
        }


     /*   protected override void OnAppearing()
        {
            StackLayout stack = new StackLayout();

            Label label = new Label();
            label.Text = "hello world c#";
            label.TextTransform = TextTransform.Uppercase;
            label.FontSize = 25;

            button = new Button();
            button.Text = "Click me! C#";
            button.BackgroundColor = Color.Black;
            button.TextColor = Color.White;
            button.Clicked += Button_Clicked;

            stack.Children.Add(label);
            stack.Children.Add(button);

            Content = stack;
        }*/

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameField.Text))
                errorField.Text = "No name specified";
            else if (string.IsNullOrEmpty(emailField.Text))
                errorField.Text = "No email specified";
            else if (string.IsNullOrEmpty(passField.Text))
                errorField.Text = "No password specified";
            else if (!checkField.IsChecked)
                errorField.Text = "Check box incorrect";
            else
            {
                errorField.Text = "";
                buttonSend.Text = "OK";
                buttonSend.TextColor = Color.Green;
                await DisplayAlert("form data", "all data gainend", "OK");
            }

        }
    }
}
