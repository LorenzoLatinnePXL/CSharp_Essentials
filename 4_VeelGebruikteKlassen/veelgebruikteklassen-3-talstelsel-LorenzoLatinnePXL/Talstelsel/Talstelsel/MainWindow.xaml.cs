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

namespace Talstelsel
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

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            hexaTextBox.Clear();
            decTextBox.Clear();
            hexaTextBox.Focus();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            string input = hexaTextBox.Text;
            int convert = Convert.ToInt32(input, 16);
            string convertedValue = convert.ToString();

            decTextBox.Text = convert.ToString("N0");
        }
    }
}
