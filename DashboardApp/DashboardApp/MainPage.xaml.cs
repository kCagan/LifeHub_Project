namespace DashboardApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnHabitClicked(object sender, EventArgs e)
    {
        statusLabel.Text = "Opening Habit Tracker...";
    }

    private void OnMoodClicked(object sender, EventArgs e)
    {
        statusLabel.Text = "Opening Mood Journal...";
    }

    private void OnPlannerClicked(object sender, EventArgs e)
    {
        statusLabel.Text = "Opening Planner...";
    }
}
