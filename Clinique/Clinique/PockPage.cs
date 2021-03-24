using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Clinique
{
	public class PockPage : ContentPage
	{
        public List<Pocket> Pockets { get; set; }
        public PockPage()
        {
            Title = "Пакеты услуг";
            Label header = new Label
            {
                Text = "Список пакетов услуг",
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Pockets = new List<Pocket>
        {
            new Pocket {Title="Женское здоровье", Description="специальное предложение" },
            new Pocket {Title="Наблюдение нормально-протекающей беременности",  Description="стандарт/премиум" },
            new Pocket {Title="Курс реабилитации",  Description="специальное предложение" },
            new Pocket {Title="Курс массажа",  Description="акция" },
            new Pocket {Title="Пакет полного обследования ''СТАНДАРТ''",  Description="специальное предложение" },
            new Pocket {Title="Пакет полного обследования ''ПРЕМИУМ''",  Description="специальное предложение"},
            new Pocket {Title="Плановая проверка",  Description="для постоянных клиентов"}

        };

            ListView listView = new ListView
            {

                HasUnevenRows = true,
                // Определяем источник данных
                ItemsSource = Pockets,

                // Определяем формат отображения данных
                ItemTemplate = new DataTemplate(() =>
                {
                    // привязка к свойству Name
                    Label titleLabel = new Label { FontSize = 16 };
                    titleLabel.SetBinding(Label.TextProperty, "Title");

                    // привязка к свойству Price
                    Label DescriptionLabel = new Label();
                    DescriptionLabel.SetBinding(Label.TextProperty, "Description");

                    // создаем объект ViewCell.
                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Padding = new Thickness(0, 5),
                            Orientation = StackOrientation.Vertical,
                            Children = { titleLabel, DescriptionLabel }
                        }
                    };
                })
            }; listView.SeparatorColor = Color.DeepSkyBlue;

            this.Content = new StackLayout { Children = { header, listView } };

         
		}
    }
    public class Pocket
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}