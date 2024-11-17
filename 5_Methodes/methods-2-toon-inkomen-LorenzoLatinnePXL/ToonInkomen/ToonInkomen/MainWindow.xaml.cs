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

namespace ToonInkomen
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

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValidIncome = double.TryParse(yearlyTextBox.Text, out double yearSalary);
            bool isValidYears = int.TryParse(yearsTextBox.Text, out int years);
            double calculation = 0;

            if (!isValidIncome || !isValidYears)
            {
                salaryTextBox.Text = "Invalid input";
            }
            else
            {
                salaryTextBox.Text = ShowIncome(yearSalary, years, out calculation);
            }
            Console.WriteLine(calculation);
        }

        private string ShowIncome(double yearSalary, int years, out double calculation)
        {
            calculation = yearSalary * years;
            return "€ " + (yearSalary * years).ToString("N2");
        }
    }
}
