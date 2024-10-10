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
            // Get employee name from TextBox
            string employeeName = employeeNameTextBox.Text;
            // Get hourly rate from TextBox
            bool isValidHourlyRate = float.TryParse(hourlyRateTextBox.Text, out float hourlyRate);
            bool isValidHours = int.TryParse(hoursTextBox.Text, out int hours);

            if (isValidHourlyRate && isValidHours) 
            {
                float brutojaarwedde = hourlyRate * hours;
                float belasting = brutojaarwedde * 0.3F;
                float nettojaarwedde = brutojaarwedde - belasting;

                outputTextBox.Text = $"LOONFICHE VAN {employeeName}\n" +
                                     $"\nAantal gewerkte uren: {hours}" +
                                     $"\nUurloon: € {hourlyRate}" +
                                     $"\nBrutojaarwedde: € {brutojaarwedde:N2}" +
                                     $"\nBelasting: € {belasting:N2}" +
                                     $"\nNettojaarwedde: € {nettojaarwedde:N2}";
            } else
            {
                outputTextBox.Text = "Invalid input.";
            }




        }
    }
}
