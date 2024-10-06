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

namespace WPFCursusgeld
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

        private void afsluitenButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void testNumeriekButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValidYear = int.TryParse(jaarTextBox.Text, out int year);
            if (isValidYear)
            {
                berekenenButton.IsEnabled = true;
                isNumeriekTextBlock.Text = "Is numeriek.";
                isNumeriekTextBlock.Visibility = Visibility.Visible;
            }
            else
            {
                berekenenButton.IsEnabled = false;
                isNumeriekTextBlock.Text = "Geef een correct jaartal!";
                isNumeriekTextBlock.Visibility = Visibility.Visible;
            }

            if (isValidYear)
            {

                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        isSchrikkeljaarTextBlock.Text = "Is een schrikkeljaar";
                        isSchrikkeljaarTextBlock.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        isSchrikkeljaarTextBlock.Text = "Is geen schrikkeljaar";
                        isSchrikkeljaarTextBlock.Visibility = Visibility.Visible;
                    }
                } else if (year % 4 == 0)
                {
                    isSchrikkeljaarTextBlock.Text = "Is een schrikkeljaar";
                    isSchrikkeljaarTextBlock.Visibility = Visibility.Visible;
                } else
                {
                    isSchrikkeljaarTextBlock.Text = "Is geen schrikkeljaar";
                    isSchrikkeljaarTextBlock.Visibility = Visibility.Visible;
                }
            }
            else
            {
                isSchrikkeljaarTextBlock.Visibility = Visibility.Hidden;
            }
        }
    }
}
