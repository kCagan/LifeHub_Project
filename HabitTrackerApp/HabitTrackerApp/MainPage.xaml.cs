using System.Collections.ObjectModel;
using System.Windows.Input;

namespace HabitTrackerApp;

public partial class MainPage : ContentPage
{
    public ObservableCollection<HabitModel> Habits { get; set; } = new();

    // 🔹 ICommand tanımları
    public ICommand AddHabitCommand { get; }
    public ICommand ClearHabitsCommand { get; }
    public ICommand DeleteHabitCommand { get; }

    public MainPage()
    {
        InitializeComponent();

        // Command'ları bağla
        AddHabitCommand = new Command(AddHabit);
        ClearHabitsCommand = new Command(ClearAll);
        DeleteHabitCommand = new Command<HabitModel>(DeleteHabit);

        // XAML'den BindingContext = this
        BindingContext = this;

        habitList.ItemsSource = Habits;
    }

    private void AddHabit()
    {
        if (string.IsNullOrWhiteSpace(habitEntry.Text))
            return;

        Habits.Insert(0, new HabitModel
        {
            Name = habitEntry.Text,
            DateAdded = DateTime.Now,
            IsCompleted = false
        });

        habitEntry.Text = string.Empty;

        // En fazla 7 kayıt tut
        if (Habits.Count > 7)
            Habits.RemoveAt(Habits.Count - 1);
    }

    private void ClearAll()
    {
        if (Habits.Count > 0)
            Habits.Clear();
    }

    private void DeleteHabit(HabitModel habit)
    {
        if (habit != null && Habits.Contains(habit))
        {
            Habits.Remove(habit);
        }
    }
}