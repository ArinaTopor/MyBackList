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
    public partial class GoalCard : ContentPage
    {
        public GoalCard()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void RetutnToGoalsPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabBar());
        }
    }
}
