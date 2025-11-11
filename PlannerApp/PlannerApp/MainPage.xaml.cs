using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PlannerApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<PlannerTask> Tasks { get; } = new();
        public ICommand AddTaskCommand { get; }
        public ICommand DeleteTaskCommand { get; }
        public ICommand ClearTasksCommand { get; }

        public MainPage()
        {
            BindingContext = this;
            AddTaskCommand = new Command(AddTask);
            DeleteTaskCommand = new Command<PlannerTask>(DeleteTask);
            ClearTasksCommand = new Command(() => Tasks.Clear());
            InitializeComponent();

            datePicker.MinimumDate = DateTime.Today;
            datePicker.MaximumDate = DateTime.Today.AddYears(1);
            datePicker.Date = DateTime.Today;
        }

        private async void AddTask()
        {
            var title = taskEntry.Text?.Trim();
            if (string.IsNullOrEmpty(title))
            {
                await DisplayAlert("Warning", "Enter a task.", "OK");
                return;
            }

            Tasks.Insert(0, new PlannerTask
            {
                Title = title,
                Date = datePicker.Date,
                CreatedAt = DateTime.Now
            });

            taskEntry.Text = string.Empty;
            if (Tasks.Count > 7)
                Tasks.RemoveAt(Tasks.Count - 1);
        }

        private void DeleteTask(PlannerTask task)
        {
            if (task != null) Tasks.Remove(task);
        }
    }

    public class PlannerTask
    {
        public string Title { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsCompleted { get; set; }
    }
}