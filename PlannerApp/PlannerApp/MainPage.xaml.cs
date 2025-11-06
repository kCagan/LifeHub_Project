using System;
using System.Collections.ObjectModel;

namespace PlannerApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<PlannerTask> Tasks { get; set; } = new();

        public MainPage()
        {
            InitializeComponent();
            taskList.ItemsSource = Tasks;
        }

        private void OnAddTaskClicked(object sender, EventArgs e)
        {
            string task = taskEntry.Text;
            DateTime date = taskDatePicker.Date;

            if (string.IsNullOrWhiteSpace(task))
            {
                DisplayAlert("Warning", "Please enter a task.", "OK");
                return;
            }

            Tasks.Add(new PlannerTask
            {
                Task = task,
                Date = date.ToString("D")
            });

            taskEntry.Text = string.Empty;
        }
    }

    public class PlannerTask
    {
        public string Task { get; set; }
        public string Date { get; set; }
    }
}
