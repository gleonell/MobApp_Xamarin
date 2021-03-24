using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Clinique
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Title = "Вход в аккаунт";
        }
        protected async void ToHeadPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HeadPage());
        }
    }
}
