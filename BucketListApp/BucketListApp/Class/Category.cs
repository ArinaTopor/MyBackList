using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xamarin.Forms;

namespace BucketListApp.Class
{
    public class Category
    {
        private readonly string name;
        private readonly Image icon;
        public string Name => name;

        public Image Icon => icon;

        public Category(string name, string imageName = null)
        {
            this.name = name;
            this.icon = new Image() { Source = imageName };
        }

        public Category(string name, Image image)
        {
            this.name = name;
            this.icon = image;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var category = obj as Category;
            return category != null
                && Name == category.Name;
        }

        public static Category Create(string name, string imageName) => new Category(name, imageName);
    }
}
