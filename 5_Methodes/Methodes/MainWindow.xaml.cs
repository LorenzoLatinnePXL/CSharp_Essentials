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
            int number = int.Parse(totalSumTextBox.Text);
            number += 1;
            totalSumTextBox.Text = number.ToString();
        }

        private void secondAddButton_Click(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(totalSumTextBox.Text);
            number += 1;
            totalSumTextBox.Text = number.ToString();
        }

        private void thirdAddButton_Click(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(totalSumTextBox.Text);
            number += 1;
            totalSumTextBox.Text = number.ToString();
        }




        // Deel 3
        // ----------------
        // Paste code here!



        // Deel 4

    }
}