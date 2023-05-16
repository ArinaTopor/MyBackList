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
    public partial class LogIn : ContentPage
    {
        //App app = new App();
        public LogIn()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void Enter(object sender, EventArgs e)
        {
            if (login.Text != null && password1.Text != null)
            {
               //app.LoginAccount(login.Text, password1.Text);
                Navigation.PushAsync(new GoalsPage());

            }
            else
            {
                DisplayAlert("", "Неправильный логин или пароль", "ok");
            }
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CheckIn());
        }
    }
}