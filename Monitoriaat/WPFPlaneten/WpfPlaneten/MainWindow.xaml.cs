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

namespace WpfPlaneten
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

        private void calculate(object sender, RoutedEventArgs e)
        {
            const int MercuryDays = 88;
            const int VenusDays = 225;
            const int EarthDays = 365;
            const int MarsDays = 687;
            const int JupiterDays = 4333;
            const int SaturnDays = 10759;
            const int UranusDays = 30687;
            const int NeptuneDays = 60190;

            bool isValidAantalJaren = double.TryParse(TxtAantalJaren.Text, out double amountYears);
            if (isValidAantalJaren)
            {
                LblMecuryDays.Content = (amountYears * MercuryDays).ToString();
                LblVenusDays.Content = (amountYears * VenusDays).ToString();
                LblEarthDays.Content = (amountYears * EarthDays).ToString();
                LblMarsDays.Content = (amountYears * MarsDays).ToString();
                LblJupiterDays.Content = (amountYears * JupiterDays).ToString();
                LblSaturnDays.Content = (amountYears * SaturnDays).ToString();
                LblUranusDays.Content = (amountYears * UranusDays).ToString();
                LblNeptuneDays.Content = (amountYears * NeptuneDays).ToString();
            } else
            {
                amountYears = 0;
                LblMecuryDays.Content = "0";
                LblVenusDays.Content = "0";
                LblEarthDays.Content = "0";
                LblMarsDays.Content = "0";
                LblJupiterDays.Content = "0";
                LblSaturnDays.Content = "0";
                LblUranusDays.Content = "0";
                LblNeptuneDays.Content = "0";
            }
        }
    }
}
