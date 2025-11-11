using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MoodJournalApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<MoodEntry> Entries { get; } = new();
        public ObservableCollection<string> MoodOptions { get; } =
            new() { "😊 Happy", "😐 Neutral", "😞 Sad", "😡 Angry" };

        public ICommand AddEntryCommand { get; }
        public ICommand ClearEntriesCommand { get; }
        public ICommand DeleteEntryCommand { get; }

        public MainPage()
        {
            BindingContext = this;
            AddEntryCommand = new Command(AddEntry);
            ClearEntriesCommand = new Command(() => Entries.Clear());
            DeleteEntryCommand = new Command<MoodEntry>(DeleteEntry);
            InitializeComponent();
        }

        private async void AddEntry()
        {
            var mood = moodPicker.SelectedItem as string;
            if (string.IsNullOrWhiteSpace(mood))
            {
                await DisplayAlert("Warning", "Select a mood.", "OK");
                return;
            }

            var note = string.IsNullOrWhiteSpace(noteEntry.Text)
                ? "No note"
                : noteEntry.Text;

            Entries.Insert(0, new MoodEntry
            {
                Mood = mood,
                Note = note,
                Date = DateTime.Now.ToString("g")
            });

            moodPicker.SelectedItem = null;
            noteEntry.Text = string.Empty;
            if (Entries.Count > 7)
                Entries.RemoveAt(Entries.Count - 1);
        }

        private void DeleteEntry(MoodEntry entry)
        {
            if (entry != null && Entries.Contains(entry))
            {
                Entries.Remove(entry);
            }
        }
    }

    public class MoodEntry
    {
        public string Mood { get; set; }
        public string Note { get; set; }
        public string Date { get; set; }
    }
}