using System.Windows.Input;

namespace DashboardApp;

public partial class MainPage : ContentPage
{
    // 🔹 ICommand tanımı
    public ICommand OpenHabitCommand { get; }

    public MainPage()
    {
        InitializeComponent();

        // 🔹 XAML'deki Command buraya bağlanır
        OpenHabitCommand = new Command(OpenHabit);
        BindingContext = this; // olmazsa Command bağlanmaz
    }

    private void OpenHabit()
    {
        status.Text = "Opening Habit Tracker...";
        // İleride Shell navigation buraya gelecek
    }

    private void OnMoodClicked(object sender, EventArgs e)
    {
        status.Text = "Opening Mood Journal...";
    }

    private void OnPlannerClicked(object sender, EventArgs e)
    {
        status.Text = "Opening Planner...";
    }
}
