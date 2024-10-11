using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows;

namespace VersenyzoGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Scores_TextChanged(object sender, TextChangedEventArgs e)
        {
            var line = Scores.Text.Trim();
            var numbers = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var intNumbers = numbers.Select(int.Parse).ToList();

            numbersCount.Content = $"{intNumbers.Count()} db";

            var minVal = 0;
            var maxVal = 0;

            if (intNumbers.Count() == 6)
            {
                minVal = intNumbers.Min();
                maxVal = intNumbers.Max();
                
            }
            else
            {
                minVal = 0;
                maxVal = 0;
            }

            minScore.Content = minVal;
            maxScore.Content = maxVal;

            overallScore.Content = (intNumbers.Sum() < 3 ? "0" : intNumbers.Sum() - minVal - maxVal);

            

        }
    }
}