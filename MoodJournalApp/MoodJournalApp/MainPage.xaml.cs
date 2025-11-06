using System;
using System.Collections.ObjectModel;

namespace MoodJournalApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<MoodEntry> Entries { get; set; } = new();

        public MainPage()
        {
            InitializeComponent();
            entriesList.ItemsSource = Entries;
        }

        private void OnAddEntryClicked(object sender, EventArgs e)
        {
            string mood = moodEntry.Text;
            string note = noteEntry.Text;

            if (string.IsNullOrWhiteSpace(mood))
            {
                DisplayAlert("Warning", "Please enter your mood first.", "OK");
                return;
            }

            Entries.Add(new MoodEntry
            {
                Mood = mood,
                Note = string.IsNullOrWhiteSpace(note) ? "No note provided." : note,
                Date = DateTime.Now.ToString("g")
            });

            moodEntry.Text = string.Empty;
            noteEntry.Text = string.Empty;
        }
    }

    public class MoodEntry
    {
        public string Mood { get; set; }
        public string Note { get; set; }
        public string Date { get; set; }
    }
}
