using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Clinique
{
	public class SignPage : ContentPage
	{
        Label header;
        Picker picker;
        Label label;
        DatePicker datePicker;
        public SignPage ()
		{
            Title = "Запись";
            //doct choice list and description the action
            header = new Label
            {
                Text = "Выберите врача",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            };

            picker = new Picker
            {
                Title = "Список врачей"
            };

            picker.Items.Add("Хороший врач-терапевт");
            picker.Items.Add("Так себе врач-окулист");
            picker.Items.Add("Нормальный врач травматолог");
            picker.Items.Add("Другой врач-терапевт плохой");
            picker.Items.Add("Врач сидящий за окном МРТ-каб.");
            picker.Items.Add("Врач выдающий левую справку");
            picker.Items.Add("Врач который окончил Сеченова");
            picker.Items.Add("Врач которого мы заслужили");
            picker.Items.Add("Выбери себе уже хоть какого-то врача!!!");

            picker.SelectedIndexChanged += picker_SelectedIndexChanged;

            // data set and description the action
            label = new Label { Text = "Выберите дату и время" };
            datePicker = new DatePicker
            {
                Format = "D",
                MaximumDate = DateTime.Now.AddDays(5),
                MinimumDate = DateTime.Now.AddDays(-5)
            };
            datePicker.DateSelected += datePicker_DateSelected;
            //Time set
            TimePicker timePicker = new TimePicker() { Time = new TimeSpan(17, 0, 0) };

            //save action
            Button signButton = new Button
            {
                Text = "Записаться",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center
            };
            signButton.Clicked += SignButton_Clicked;

            // stack initianilization 
            StackLayout stack = new StackLayout { Children = { header, picker, label, datePicker, timePicker, signButton } };
            this.Content = stack;

           
        }

        void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            header.Text = "Вы выбрали: " + picker.Items[picker.SelectedIndex];
        }

        private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            label.Text = "Вы выбрали " + e.NewDate.ToString("dd/MM/yyyy");
        }
        private async void SignButton_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", "Записаться на это время?", "Да", "Нет");
            await DisplayAlert("Запись прошла успешно", "Просьба бахилы с собой!", "OK");
        }
    }
}