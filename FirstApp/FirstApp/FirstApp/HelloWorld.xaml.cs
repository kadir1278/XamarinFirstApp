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
    public partial class HelloWorld : ContentPage
    {
        public HelloWorld()
        {
            InitializeComponent();
            Device.StartTimer(new TimeSpan(), () =>
            {
                date.Text = "Tarih : " + DateTime.Now.ToString("dd.MM.yyyy");
                time.Text = "Saat : " + DateTime.Now.ToString("HH.mm.ss");
                return true;
            });
            Device.StartTimer(new TimeSpan(0,0,5), () =>
            {
                loginModal.Children.Clear();
                return false;
            });
        }
    }
}