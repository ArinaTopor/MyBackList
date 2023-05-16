using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BucketListApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);           
        }

        private void Button_Register(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CheckIn());
        }

        private void TapToLogIn(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LogIn());
        }
    }
}