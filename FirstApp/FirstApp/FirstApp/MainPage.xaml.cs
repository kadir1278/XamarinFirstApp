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
            Device.StartTimer(new TimeSpan(), () =>
            {
                date.Text = "Tarih : " + DateTime.Now.ToString("dd.MM.yyyy");
                time.Text = "Saat : " + DateTime.Now.ToString("HH.mm.ss");
                return true;
            });
        }

        private async void loginUser(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "1234")
            {
                await DisplayAlert("Success", "", "Ok");
                await Navigation.PushModalAsync(new HelloWorld());
            }
            else
            {
                await DisplayAlert("Warning", "Wrong username or password", "Ok");
                username.Text = ("");
                password.Text = ("");
            }
        }

        private async void clearEntry(object sender, EventArgs e)
        {
            username.Text = ("");
            password.Text = ("");
        }

    }
}
