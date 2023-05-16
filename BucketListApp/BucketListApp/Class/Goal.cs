using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Xamarin.Forms;

namespace BucketListApp.Class
{
    public class Goal : INotifyPropertyChanged
    {
        public static Dictionary<string, Goal> ExampleGoals = new Dictionary<string, Goal>();
        private Image image;
        private string title;
        private string description;
        private Category category;
        private List<SubTask> subtasks;
        private bool status;
        private readonly DateTime creationDate;

        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                if (image != value)
                {
                    image = value;
                    OnPropertyChanged("Image");
                }
            } 
        }
        public string Title
        { 
            get
            {
                return title;
            } 
            set 
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged("Title");
                }
            } 
        }
        public string Description
        { 
            get 
            {
                return description;
            } 
            set 
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged("Description");
                }
            } 
        }
        public Category Category 
        { 
            get
            { 
                return category; 
            } 
            set
            {
                if (category != value)
                {
                    category = value;
                    OnPropertyChanged("Category");
                }
            } 
        }
        public List<SubTask> SubTasks
        { 
            get 
            {
                return subtasks; 
            } 
            set 
            {
                if (subtasks != value)
                {
                    subtasks = value;
                    OnPropertyChanged("Subtasks");
                }
            } 
        }
        public bool Status
        { 
            get
            { 
                return status; 
            } 
            set 
            {
                if (status != value)
                {
                    status = value;
                    OnPropertyChanged("Status");
                }
            } 
        }
        public DateTime CreationDate => creationDate;
        public (int InProgress, int Completed) Statistics
        {
            get
            {
                return (InProgress(), Completed());
            }
        }
        private int SubTasksCount => SubTasks.Count;
        public Goal(string title, string descript, Category category, List<SubTask> subTasks)
        {
            Image = category.Icon;
            Title = title;
            Description = descript;
            Category = category;
            SubTasks = subTasks;
            Status = false;
            creationDate = DateTime.Now;
        }

        public override int GetHashCode()
        {
            return ((Title.GetHashCode() ^ Description.GetHashCode()) * 1021
                ^ Category.GetHashCode()) * 1021;
        }

        public override bool Equals(object obj)
        {
            var goal = obj as Goal;
            return goal != null
                && Title == goal.Title
                && Status == goal.Status
                && Description == goal.Description
                && Category.Equals(goal.Category)
                && SubTasks.Equals(goal.SubTasks);
        }

        public void AddSubTask(SubTask subtask)
        {
            SubTasks.Add(subtask);
        }

        public void DeleteSubTask(SubTask subtask)
        {
            SubTasks.Remove(subtask);
        }

        public void ChangeCompletionState()
        {
            if (SubTasksCount == 0 || Statistics.InProgress == 0)
                Status = true;
        }

        private int Completed()
        {
            if (!SubTasks.Any())
                return 0;
            return SubTasks.Where(subTask => subTask.Status == true).Count();
        }

        private int InProgress()
        {
            if (!SubTasks.Any())
                return 0;
            return SubTasks.Where(subTask => subTask.Status == false).Count();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
