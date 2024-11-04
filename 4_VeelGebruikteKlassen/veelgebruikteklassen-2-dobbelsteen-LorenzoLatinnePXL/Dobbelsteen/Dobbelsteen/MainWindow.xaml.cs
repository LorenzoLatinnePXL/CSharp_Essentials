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

namespace Dobbelsteen
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
            resultTextBox.Clear();
            startButton.Focus();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            int worp = 0;

            for (int i = 1; worp != 6; i++)
            {
                worp = rnd.Next(1, 7);
                sb.AppendLine($"Worp {i} geeft {worp}");
            }

            resultTextBox.Text = sb.ToString();
        }
    }
}
