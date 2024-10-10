using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Weddeberekening
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

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            employeeNameTextBox.Clear();
            hoursTextBox.Clear();
            hourlyRateTextBox.Clear();
        }

        private void hourlyRateTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            double defaultHourlyRate = 17.85;
            hourlyRateTextBox.Text = defaultHourlyRate.ToString();
        }

        private void hoursTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            int defaultHours = 1686;
            hoursTextBox.Text = defaultHours.ToString();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            string employeeName = employeeNameTextBox.Text;
            float hourlyRate = float.Parse(hourlyRateTextBox.Text);
            int hours = int.Parse(hoursTextBox.Text);

            float brutojaarwedde = hourlyRate * hours;
            float belasting = brutojaarwedde * 0.3F;
            float nettojaarwedde = brutojaarwedde - belasting;

            outputTextBox.Text = $"LOONFICHE VAN {employeeName}\n" +
                $"\nAantal gewerkte uren: {hours}" +
                $"\nUurloon: € {hourlyRate}" +
                $"\nBrutojaarwedde: € {brutojaarwedde}" +
                $"\nBelasting: € {belasting}" +
                $"\nNettojaarwedde: € {nettojaarwedde}";
        }
    }
}
