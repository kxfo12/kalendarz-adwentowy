using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kalendarzAdwentowy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Day> days = new List<Day>();
        public MainWindow()
        {
            InitializeComponent();
            String timestamp = DateTimeOffset.Now.ToString("MMdd");
            days.Add(new Day(1, "2 w cenie 3!", "1201"));
            days.Add(new Day(2, "2 w cenie 3!", "1202"));
            days.Add(new Day(3, "2 w cenie 3!", "1203"));
            days.Add(new Day(4, "2 w cenie 3!", "1204"));
        }
        private void CreateCalendarUI()
        {
            var uniformGrid = new UniformGrid
            {
                Rows = 5,
                Columns = 5
            };
            foreach(var day in days)
            {
                var button = new Button
                {
                    Content = day.day.ToString(),
                    Tag = day,
                    Background = System.Windows.Media.Brushes.LightGreen
                };
                button.Click += DayButton_Click;
                uniformGrid.Children.Add(button);
            }
            MainGrid.Children.Add(uniformGrid);
        }
        private void DayButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button && button.Tag is Day day)
            {
                MessageBox.Show($"Otworzyłeś: {day.day}!\nTreść: {day.content}", "Kalendaez Adwentowy");
            }
        }
    }
}
