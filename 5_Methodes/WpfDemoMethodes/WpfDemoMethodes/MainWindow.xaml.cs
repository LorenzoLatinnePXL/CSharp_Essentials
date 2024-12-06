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

namespace WpfDemoMethodes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            DateTime vandaag = DateTime.Today;
            DateTime coronaDag = new DateTime(2019, 3, 19);
            DateTime nu = DateTime.Now;

            MessageBox.Show(nu.ToLongTimeString());
            MessageBox.Show(vandaag.Day.ToString());

            TimeSpan eenUur = new TimeSpan(1, 0, 0);

            TimeSpan tijdSindsCorona = nu - coronaDag;
            MessageBox.Show(tijdSindsCorona.TotalDays.ToString());

        }

        private void childTicketButton_Click(object sender, RoutedEventArgs e)
        {
            int leeftijd = 3; // Het kind is 3 jaar.
            MessageBox.Show(CalculatePrice(leeftijd).ToString());
        }

        private void teenTicketButton_Click(object sender, RoutedEventArgs e)
        {
            double price = CalculatePrice(12);
            MessageBox.Show(price.ToString());
        }

        private void adultTicketButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(CalculatePrice(20).ToString());

        }

        private double CalculatePrice(int leeftijd)
        {
            if (leeftijd <= 3)
            {
                return 0;
            } else if (leeftijd <= 18)
            {
                return 12;
            } else
            {
                return 20;
            }
        }
    }
}
