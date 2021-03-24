using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Clinique
{
	public class ServicePage : ContentPage
	{
        public List<Service> ServiceList { get; set; }
        public ServicePage ()
		{
            Title = "Медицинские услуги и цены";
            Label header = new Label
            {
                Text = "Список услуг",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            ServiceList = new List<Service>
        {
            new Service {Title="Анализ крови (общий)", Price=1000 },
            new Service {Title="Консультация врача (первичный прием)", Price=3500 },
            new Service {Title="Повторная консультация врача", Price=2000 },
            new Service {Title="ЭКГ", Price=800 },
            new Service {Title="Дыхательный тест", Price=800 },
            new Service {Title="Кардиограмма", Price=1000 },
            new Service {Title="Услуги диагностики"},
            new Service {Title="Лечебные массажи"},
            new Service {Title="Стоматологические услуги"},
            
        };
            ListView listView = new ListView
            {
                HasUnevenRows = true,
                // Определяем источник данных
                ItemsSource = ServiceList,

                // Определяем формат отображения данных
                ItemTemplate = new DataTemplate(() =>
                {
                    // привязка к свойству Name
                    Label titleLabel = new Label { FontSize = 11 };
                    titleLabel.SetBinding(Label.TextProperty, "Title");

                    // привязка к свойству Price
                    Label priceLabel = new Label();
                    priceLabel.SetBinding(Label.TextProperty, "Price");

                    // создаем объект ViewCell.
                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Padding = new Thickness(0, 5),
                            Orientation = StackOrientation.Vertical,
                            Children = { titleLabel,  priceLabel }
                        }
                    };
                })
            };
            this.Content = new StackLayout { Children = { header, listView } };
        }
	}
    public class Service
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
}