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

namespace Reiskost
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

        private void flightClassTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            flightOptionTextBox.Visibility = Visibility.Visible;
            flightOptionTextBox.Text = $"1 = Businessclass \n2 = Standaard lijnvlucht \n3 = Charter ";
        }

        private void flightClassTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            flightOptionTextBox.Visibility = Visibility.Hidden;
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            string destination = destinationTextBox.Text;
            bool isValidBaseFlightPrice = float.TryParse(baseFlightTextBox.Text, out float baseFlightPrice);
            bool isValidBasePrice = float.TryParse(basePriceTextBox.Text, out float basePrice);
            bool isValidAmountOfDays = int.TryParse(numberOfDaysTextBox.Text, out int amountOfDays);
            bool isValidAmountOfPersons = int.TryParse(numberOfPersonsTextBox.Text, out int persons);
            bool isValidReductionPercantage = float.TryParse(reductionPercentageTextBox.Text, out float reduction);

            if (isValidBaseFlightPrice && isValidBasePrice && isValidAmountOfDays && isValidAmountOfPersons && isValidReductionPercantage)
            {
                float vluchtprijs = baseFlightPrice * persons;
                float verblijfprijs = basePrice * persons * amountOfDays;
                float reisprijs = vluchtprijs + verblijfprijs;
                float korting = reisprijs * (reduction / 100);
                float totaalPrijs = reisprijs - korting;
                resultTextBox.Text = $"REISKOST VOLGENS BESTEMMING NAAR {destination}\n" +
                    $"\n" +
                    $"Totale vluchtprijs: € {vluchtprijs:N2} \n" +
                    $"Totale verblijfprijs: € {verblijfprijs:N2}\n" +
                    $"Totale reisprijs: € {reisprijs:N2} \n" +
                    $"Korting: € {korting:N2} \n" +
                    $"\n" +
                    $"Te betalen: € {totaalPrijs:N2}";
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            destinationTextBox.Clear();
            baseFlightTextBox.Clear();
            flightClassTextBox.Clear();
            basePriceTextBox.Clear();
            numberOfDaysTextBox.Clear();
            numberOfPersonsTextBox.Clear();
            reductionPercentageTextBox.Clear();
            resultTextBox.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
