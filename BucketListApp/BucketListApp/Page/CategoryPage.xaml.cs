using BucketListApp.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BucketListApp.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryPage : ContentPage
    {
        public CategoryPage()
        {
            InitializeComponent();
        }

        public async void Next(object sender, EventArgs e)
        {
            string name = "Выбрать категорию";
            Image image = new Image();

            if (One.IsChecked)
            {
                name = "Отдых";
                image = new Image { Source = "chill.jpg" };
            }
            else if (Two.IsChecked)
            {
                name = "Активности";
                image = new Image { Source = "activity.jpg" };
            }
            else if (Three.IsChecked)
            {
                name = "Путешествия";
                image = new Image { Source = "airplane.jpg" };
            }
            else if (Four.IsChecked)
            {
                name = "Челленджи";
                image = new Image { Source = "challange.jpg" };
            }
            else if (Five.IsChecked)
            {
                name = "Духовность";
                image = new Image { Source = "god.jpg" };
            }
            else if (Six.IsChecked)
            {
                name = "Другое";
                image = new Image { Source = "other.jpg" };
            }

            Category cate = new Category(name, image);
            MessagingCenter.Send<CategoryPage, Category>(this, "ChangeCat", cate);
            await Navigation.PopModalAsync();
        }
    }
}