using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BucketListApp.Class
{
    public class SubTask
    {
        public string Description { get; private set; }
        public bool Status { get; private set; }

        public SubTask(string name)
        {
            Description = name;
            Status = false;
        }

        public static SubTask Create(string name) => new SubTask(name);

        public void ChangeState()
        {
            Status = !Status;
        }

        public void ChangeName(string description)
        {
            Description = description;
        }
        public override int GetHashCode()
        {
            return Description.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var subTask = obj as SubTask;
            return subTask != null
                && Description == subTask.Description
                && Status == subTask.Status;
        }

    }
}
