using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BucketListApp.Custom
// Пример использования этой страницы
    //var ap = new AlertPage();
    //ap.ErrTxt.Text = "Название ошибки";
    //ap.Txt.Text = "Текст ошибки";
    //ap.Button1.Text = "Кнопка";
    //await Navigation.PushModalAsync(ap);
    //return;
// Строка выше - опциональна
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertPage : ContentPage
    {
        public Label ErrTxt
        {
            get => Up;
        }

        public Label Txt
        {
            get => Med;
        }

        public Button Button1
        {
            get => btn1;
        }

        public async void Pop(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        public AlertPage()
        {
            InitializeComponent();
        }
    }
}