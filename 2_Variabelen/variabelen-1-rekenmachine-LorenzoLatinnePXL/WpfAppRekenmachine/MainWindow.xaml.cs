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

namespace WpfAppRekenmachine
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

        private void clearInput(object sender, RoutedEventArgs e)
        {
            firstNumberInput.Clear();
            secondNumberInput.Clear();
            resultOutput.Clear();
        }

        private void addNumbers(object sender, RoutedEventArgs e)
        {
            bool isNumber1Valid = double.TryParse(firstNumberInput.Text, out double number1);
            bool isNumber2Valid = double.TryParse(secondNumberInput.Text, out double number2);
            if (isNumber1Valid && isNumber2Valid)
            {
                double addition = number1 + number2;
                resultOutput.Text = addition.ToString();
            }
            else
            {
                resultOutput.Text = "Invalid numbers.";
            }
        }

        private void subtractNumbers(object sender, RoutedEventArgs e)
        {
            int number1 = int.Parse(firstNumberInput.Text);
            int number2 = int.Parse(secondNumberInput.Text);
            int subtractition = number1 - number2;
            resultOutput.Text = subtractition.ToString();
        }

        private void multiplyNumbers(object sender, RoutedEventArgs e)
        {
            float number1 = float.Parse(firstNumberInput.Text);
            float number2 = float.Parse(secondNumberInput.Text);
            float multiplyication = number1 * number2;
            resultOutput.Text = Math.Round(multiplyication, 2).ToString();
        }

        private void divideNumbers(object sender, RoutedEventArgs e)
        {
            float number1 = float.Parse(firstNumberInput.Text);
            float number2 = float.Parse(secondNumberInput.Text);
            float division = number1 / number2;
            resultOutput.Text = Math.Round(division, 2).ToString();
        }
    }
}
