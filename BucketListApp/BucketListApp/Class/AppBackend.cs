using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using System.Diagnostics;
using BucketListApp.Class;
using System.IO;
using System.Security.Authentication.ExtendedProtection;

namespace BucketListApp
{
    public partial class App : Application
    {
        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "temp.txt");
        private readonly static List<string> motivationalPhrases = new List<string>() { };
        public static List<Category> categories;
        private static Profile defaultProfile;
        private static Profile currentProfile;
        public List<Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    categories = new List<Category>()
                    {
                        new Category("без категории")
                    };
                }
                return categories;
            }
            private set { }
        }

        private Profile DefaultProfile
        {
            get
            {
                if (defaultProfile == null)
                    defaultProfile = new Profile()
                    { Name = String.Empty, Login = null, Password = null, Goals = new GoalList() };
                return defaultProfile;
            }
        }

        private Profile CurrentProfile
        {
            get
            {
                if (currentProfile == null)
                    currentProfile = DefaultProfile;
                return currentProfile;
            }
        }

        public (int, int) TotalStatistics
        {
            get
            {
                return (CurrentProfile.Goals.InProgressRatio(),
                    CurrentProfile.Goals.CompletedRatio());
            } 
        }

        public (int CompletedGoals, (int Ratio, string Name) MostCompletedCategory) AnnualStatistics
        {
            get
            {
                return (CurrentProfile.Goals.CompletedPerYear(),
                    CurrentProfile.Goals.MostCompletedCategory());
            }
        }

        public string GetMotivationPhrase()
        {
            var random = new Random();
            return motivationalPhrases[random.Next(0, motivationalPhrases.Count)];
        }
    }
}
