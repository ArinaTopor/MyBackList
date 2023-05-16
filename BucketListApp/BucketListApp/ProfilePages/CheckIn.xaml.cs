using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BucketListApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckIn : ContentPage
    {
       //App app = new App();
        public CheckIn()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private void SignUp(object sender, EventArgs e)
        {
            if (password1.Text == password2.Text & login.Text != null)
            {
                //app.RegisterAccount(login.Text, password1.Text);
                Navigation.PushAsync(new ProfilePage());
            }
            else
            {
                DisplayAlert("Ошибка.", "Вы не ввели логин или пароли не совпадают.", "Ок");
            }

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LogIn());
        }
    }
}