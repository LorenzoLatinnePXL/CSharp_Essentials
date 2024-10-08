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

namespace WpfAppBioscoop
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

        private void calculateButton(object sender, RoutedEventArgs e)
        {
            const float normalPrice = 9.10F;
            const float reductionPrice = 8.10F;
            const float studentPrice = 6.90F;

            bool isValidNormal = int.TryParse(normalTextBox.Text, out int normalAmount);
            bool isValidReduction = int.TryParse(reductionTextBox.Text, out int reductionAmount);
            bool isValidStudent = int.TryParse(studentTextBox.Text, out int studentAmount);

            if (!isValidNormal || !isValidReduction || !isValidStudent || normalAmount < 0 || reductionAmount < 0 || studentAmount < 0)
            {
                errorText.Visibility = Visibility.Visible;
                priceToPayTextBox.Text = "";
            } else
            {
                errorText.Visibility = Visibility.Hidden;
                priceToPayTextBox.Text = ((normalAmount * normalPrice) + (reductionAmount * reductionPrice) + (studentAmount * studentPrice)).ToString("0.00"); 
            }
        }
    }
}
