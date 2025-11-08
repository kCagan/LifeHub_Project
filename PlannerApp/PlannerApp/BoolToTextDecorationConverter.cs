using System.Globalization;
using Microsoft.Maui.Controls;

namespace PlannerApp
{
    // Basit ve uyarısız imza (nullable yok)
    public class BoolToTextDecorationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var done = value is bool b && b;
            return done ? TextDecorations.Strikethrough : TextDecorations.None;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is TextDecorations d && d.HasFlag(TextDecorations.Strikethrough);
        }
    }
}
