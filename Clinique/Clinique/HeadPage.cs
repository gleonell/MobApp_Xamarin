using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Clinique
{
	public class HeadPage : ContentPage
	{
		public HeadPage ()
		{
            Title = "21Clinique";

            Button serviceButton = new Button
            {
                Text="Медицинские услуги и цены",
                BackgroundColor=Color.DeepSkyBlue,
                TextColor=Color.White
            };
            serviceButton.Clicked += ToServicePage;

            Button signButton = new Button
            {
                Text = "Запись на прием",
                BackgroundColor = Color.DeepSkyBlue,
                TextColor = Color.White
            };
            signButton.Clicked += ToSignPage;

            Button doctButton = new Button
            {
                Text = "Врачи",
                BackgroundColor = Color.DeepSkyBlue,
                TextColor = Color.White
            };
            doctButton.Clicked += ToDoctPage;

            Button pockButton = new Button
            {
                Text = "Пакеты услуг",
                BackgroundColor = Color.DeepSkyBlue,
                TextColor = Color.White
            };
            pockButton.Clicked += ToPockPage;

            Content = new StackLayout {
				Children = {
					serviceButton, signButton, doctButton, pockButton
				}
			};

            
        }

        private async void ToServicePage(object sender, EventArgs e)
        {
                await Navigation.PushAsync(new ServicePage());
        }
        
        private async void ToSignPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignPage());
        }

        private async void ToDoctPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DoctButton());
        }

        private async void ToPockPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PockPage());
        }
    }
}