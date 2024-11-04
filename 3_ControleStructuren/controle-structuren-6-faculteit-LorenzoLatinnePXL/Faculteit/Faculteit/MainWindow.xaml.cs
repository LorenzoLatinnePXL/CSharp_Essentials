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

namespace Faculteit
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

        private void inputTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            inputTextBox.Text = "1";
            inputTextBox.Focus();
            inputTextBox.SelectionStart = inputTextBox.Text.Length;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBox.Clear();
            resultTextBox.Clear();
            inputTextBox.Focus();
            inputTextBox.Text = "1";
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValidInput = double.TryParse(inputTextBox.Text, out double input);
            int loopTimes = Convert.ToInt16(input);

            if (isValidInput)
            {

                for (int i = (loopTimes - 1); i > 1; i--)
                {
                    input *= i;
                }

                if (input == 0)
                {
                    resultTextBox.Text = "1";
                } else
                {
                    resultTextBox.Text = input.ToString();
                }             
            } 
            else
            {
                resultTextBox.Text = "Invalid input.";
            }
        }
    }
}
