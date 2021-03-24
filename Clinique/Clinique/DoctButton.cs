using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Clinique
{
	public class DoctButton : ContentPage
	{
        public List<Doctor> Doctors { get; set; }
        public DoctButton ()
		{
            Title = "Врачи";
            Label header = new Label
            {
                Text = "Наши врачи",
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Doctors = new List<Doctor>
        {
            new Doctor {Name="Петренко Олег Иванович", ExtraInf="Хороший врач-терапевт" },
            new Doctor {Name="Жданова Василиса Сергеевна", ExtraInf="Так себе врач-окулист" },
            new Doctor {Name="Османова Мария Андреевна", ExtraInf="Нормальный врач травматолог" },
            new Doctor {Name="Санько Татьяна Константиновна", ExtraInf="Другой врач-терапевт плохой" },
            new Doctor {Name="Валери Асия Мамаевна", ExtraInf="Врач сидящий за окном МРТ-каб." },
            new Doctor {Name="Говорунов Ворчун Болтанович", ExtraInf="Врач выдающий левую справку" },
            new Doctor {Name="Симонов Сергей Сергеевич", ExtraInf="Врач который окончил Сеченова"},
            new Doctor {Name="Осипов Архип Остапович", ExtraInf="Врач которого мы заслужили"},
            new Doctor {Name="Последнев Врач Оставшевич", ExtraInf="Тот самый последний"},

        };

            ListView listView = new ListView
            {
                HasUnevenRows = true,
                // Определяем источник данных
                ItemsSource = Doctors,

                // Определяем формат отображения данных
                ItemTemplate = new DataTemplate(() =>
                {
                    // привязка к свойству Name
                    Label nameLabel = new Label { FontSize = 16 };
                    nameLabel.SetBinding(Label.TextProperty, "Name");

                    // привязка к свойству Price
                    Label extraInfLabel = new Label();
                    extraInfLabel.SetBinding(Label.TextProperty, "ExtraInf");

                    // создаем объект ViewCell.
                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Padding = new Thickness(0, 5),
                            Orientation = StackOrientation.Vertical,
                            Children = { nameLabel, extraInfLabel }
                        }
                    };
                })
            }; listView.SeparatorColor = Color.DeepSkyBlue;
            this.Content = new StackLayout { Children = { header, listView } };

				}
			};
    public class Doctor
    {
        public string Name { get; set; }
        public string ExtraInf { get; set; }
    }
}
	