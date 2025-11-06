using System.Collections.ObjectModel;

namespace HabitTrackerApp;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Habit> Habits { get; set; } = new();

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private void OnAddHabitClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(habitEntry.Text))
        {
            Habits.Insert(0, new Habit
            {
                Name = habitEntry.Text,
                DateAdded = DateTime.Now,
                IsCompleted = false
            });

            if (Habits.Count > 7)
                Habits.RemoveAt(Habits.Count - 1);

            habitEntry.Text = string.Empty;
        }
    }
}
