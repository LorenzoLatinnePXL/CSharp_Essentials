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

namespace WpfAppAdd
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            bool isValidNumber1 = double.TryParse(numberOneTextBox.Text, out double numberOne);
            bool isValidNumber2 = double.TryParse(numberTwoTextBox.Text, out double numberTwo);

            double result;
            char method = char.Parse(button.Content.ToString());

            if (isValidNumber1 && isValidNumber2)
            {
                switch (method)
                {
                    case ('+'):
                        result = numberOne + numberTwo;
                        resultTextBox.Text = result.ToString();
                        break;
                    case ('-'):
                        result = numberOne - numberTwo;
                        resultTextBox.Text = result.ToString();
                        break;
                    case ('*'):
                        result = numberOne * numberTwo;
                        resultTextBox.Text = result.ToString();
                        break;
                    case ('/'):
                        result = numberOne / numberTwo;
                        resultTextBox.Text = result.ToString();
                        break;
                    default:
                        resultTextBox.Text = "Invalid input";
                        break;
                }
            }
        }
    }
}
