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

namespace Methodes
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

        // Deel 1
        private void firstAddButton_Click(object sender, RoutedEventArgs e)
        {
            // +1
            AddOperation(1);
        }

        private void secondAddButton_Click(object sender, RoutedEventArgs e)
        {
            // +2
            AddOperation(2);
        }

        private void thirdAddButton_Click(object sender, RoutedEventArgs e)
        {
            // +3
            AddOperation(3);
        }

        private void AddOperation(int numberToAdd)
        {
            // Auto format: eerst code selecteren, dan CTRL + K + F
            int number = int.Parse(totalSumTextBox.Text);
            number += numberToAdd;
            totalSumTextBox.Text = number.ToString();
        }




        // Deel 3
        // ----------------

        // Pass ByVal werkt niet op de variabele zelf, maar met de waarde hiervan.
        // Pass ByRef werkt wel degelijk op de variabele die als parameter wordt meegegeven en bewerkt dus de waarde hiervan.

        // Paste code here!
        private void subtractByValButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the current value from the textbox:
            int currentValue = int.Parse(resultByValTextBox.Text);
            // Pass the value to the subtractByVal method:
            subtractByVal(currentValue);
            // Display the new value in the textbox:
            resultByValTextBox.Text = currentValue.ToString();
        }

        private void subtractByVal(int currentValue)
        {
            // Subtract 1 from the value passed via the parameter:
            currentValue -= 1;
        }

        private void subtractByRefButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the current value from the textbox:
            int currentValue = int.Parse(resultByRefTextBox.Text);
            // Pass the value to the subtractByVal method:
            subtractByRef(ref currentValue);
            // Display the new value in the textbox:
            resultByRefTextBox.Text = currentValue.ToString();
        }

        private void subtractByRef(ref int currentValue)
        {
            // Subtract 1 from the value passed via the parameter:
            currentValue -= 1;
        }


        // Deel 4



        /// <summary>
        /// Bereken de prijs voor de familie die Phantasialand bezoekt.
        /// EN geef een verklaring voor de prijs.
        /// </summary>
        /// <param name="amountOfPeople"> Het aantal tickets dat ik moet aankopen </param> 
        /// <param name="description"> De verklaring van de prijs </param> 
        /// <returns> de prijs in double </returns>
        private double CalculatePricePhantasiaLand(int amountOfPeople, out string description)
        {
            double priceOfTicket = 35;
            if (amountOfPeople > 6)
            {
                description = "Je familie ontvangt 20% korting omwille van de grote familiekaart.";
                return amountOfPeople * priceOfTicket * 0.8;
            }
            else
            {
                description = "Je familie betaalt het standaard tarief.";
                return amountOfPeople * priceOfTicket;
            }
        }

        private bool ValidateInput(string input, out string errorMessage)
        {

            if (string.IsNullOrWhiteSpace(input))
            {
                errorMessage = "This text is empty.";
                return false;
            } 
            else
            {
                bool isADigit = int.TryParse(input, out int inputGetal);

                if (!isADigit)
                {
                    errorMessage = "This is not a valid number.";
                    return false;
                }
                else
                {
                    if (inputGetal > 100) 
                    {
                        errorMessage = "The number should be smaller than 100.";
                        return false;
                    } 
                    else if (inputGetal < 0)
                    {
                        errorMessage = "The number should be greater than 0.";
                        return false;
                    }
                    else
                    {
                        errorMessage = "";
                        return true;
                    }
                }
            }
        }

        private void validateButton_Click(object sender, RoutedEventArgs e)
        {
            string input = inputTextBox.Text;

            if (!ValidateInput(input, out string error))
            {
                MessageBox.Show(error, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}