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

namespace WpfAppKassa
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

        private void ClearInputs(object sender, RoutedEventArgs e)
        {
            VATNumberTextBox.Clear();
            checkNumberTextBox.Clear();
            priceTextBox.Clear();
            amountTextBox.Clear();
            amountToPayTextBox.Clear();
        }

        private void CloseProgram(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CheckNumber(object sender, RoutedEventArgs e)
        {
            if (VATNumberTextBox.Text.Length != 10)
            {
                invalidVATNumber.Visibility = Visibility.Visible;
                checkNumberTextBox.Clear();
                priceTextBox.Clear();
                amountTextBox.Clear();
                amountToPayTextBox.Clear();
            }
            else
            {
                invalidVATNumber.Visibility = Visibility.Hidden;
                double VATNumber = double.Parse(VATNumberTextBox.Text);
                double checkNumber = 97 - (VATNumber % 97);
                checkNumberTextBox.Text = checkNumber.ToString();
            }
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            if (checkNumberTextBox.Text != "")
            {
                invalidVATNumber.Visibility = Visibility.Hidden;
                string price = priceTextBox.Text;
                bool isValidPrice = double.TryParse(price, out double validPrice);
                if (!isValidPrice)
                {
                    invalidPrice.Visibility = Visibility.Visible;
                }
                else
                {
                    invalidPrice.Visibility= Visibility.Hidden;
                }
                string amount = amountTextBox.Text;
                bool isValidAmount = double.TryParse(amount, out double validAmount);
                if (!isValidAmount)
                {
                    invalidAmount.Visibility = Visibility.Visible;
                } else
                {
                    invalidAmount.Visibility = Visibility.Hidden;
                }
                double priceToPay = validPrice * validAmount;
                amountToPayTextBox.Text = priceToPay.ToString("0.00");
            }
            else
            {
                invalidVATNumber.Visibility = Visibility.Visible;
                checkNumberTextBox.Clear();
                priceTextBox.Clear();
                amountTextBox.Clear();
                amountToPayTextBox.Clear();
            }
        }
    }
}