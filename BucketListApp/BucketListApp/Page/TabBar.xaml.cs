using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TabbedPage = Xamarin.Forms.TabbedPage;

namespace BucketListApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabBar : TabbedPage
    {
        public TabBar()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            On<Android>().SetBarItemColor(Color.Gray);
            On<Android>().SetBarSelectedItemColor(Color.Black);
        }
        public async void ToCardGoalPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GoalCard());
        }

    }
}
