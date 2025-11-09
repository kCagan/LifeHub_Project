namespace HabitTrackerApp;

public class HabitModel
{
    public string Name { get; set; } = string.Empty;
    public DateTime DateAdded { get; set; }
    public bool IsCompleted { get; set; }
}