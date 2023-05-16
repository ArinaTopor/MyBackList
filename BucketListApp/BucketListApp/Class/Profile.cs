using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BucketListApp.Class
{
    public class Profile
    {
        [PrimaryKey, AutoIncrement]
        private int Id { get; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public GoalList Goals { get; set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var profile = obj as Profile;
            return Login == profile.Login && Password == profile.Password;
        }
    }
}
