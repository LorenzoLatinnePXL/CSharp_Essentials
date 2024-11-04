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

namespace PlusMaalTabel
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

        private void maximumValueTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            maximumValueTextBox.Text = "10";
            maximumValueTextBox.Focus();
            maximumValueTextBox.SelectionStart = maximumValueTextBox.Text.Length;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            maximumValueTextBox.Text = "10";
            maximumValueTextBox.Focus();
            maximumValueTextBox.SelectionStart = maximumValueTextBox.Text.Length;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool isValidValue = int.TryParse(maximumValueTextBox.Text, out int maximumValue);

            if (!isValidValue || maximumValue < 1 || maximumValue > 20)
            {
                sb.AppendLine("Geef een geheel getal tussen 1 en 20 als maximale waarde.");
            }
            else
            {
                sb.Append("\t");
                for (int i = 1; i <= maximumValue; i++)
                {
                    sb.Append($"{i}\t");
                }
                sb.Append("\n\n");

                for (int i = 1; i <= maximumValue; i++)
                {
                    sb.Append($"{i}\t");

                    for (int j = 1; j <= maximumValue; j++)
                    {
                        sb.Append($"{i + j}\t");
                    }

                    sb.AppendLine();
                }
            }

            resultTextBox.Text = sb.ToString();
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool isValidValue = int.TryParse(maximumValueTextBox.Text, out int maximumValue);

            if (!isValidValue || maximumValue < 1 || maximumValue > 20)
            {
                sb.AppendLine("Geef een geheel getal tussen 1 en 20 als maximale waarde.");
            }
            else
            {
                sb.Append("\t");
                for (int i = 1; i <= maximumValue; i++)
                {
                    sb.Append($"{i}\t");
                }
                sb.Append("\n\n");

                for (int i = 1; i <= maximumValue; i++)
                {
                    sb.Append($"{i}\t");

                    for (int j = 1; j <= maximumValue; j++)
                    {
                        sb.Append($"{i * j}\t");
                    }

                    sb.AppendLine();
                }
            }

            resultTextBox.Text = sb.ToString();
        }
    }
}
