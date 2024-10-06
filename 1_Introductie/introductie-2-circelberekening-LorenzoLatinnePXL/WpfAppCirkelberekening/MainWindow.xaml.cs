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

namespace WpfAppCirkelberekening
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

        private void berekenKnop_Click(object sender, RoutedEventArgs e)
        {
            omtrekInput.Text = Math.Round(((Double.Parse(straalInput.Text) * 2) * Math.PI), 5).ToString();
            oppervlakteInput.Text = Math.Round(Double.Parse(straalInput.Text) * Double.Parse(straalInput.Text) * Math.PI, 5).ToString();
        }

        private void wisKnop_Click(object sender, RoutedEventArgs e)
        {
            straalInput.Clear();
            omtrekInput.Clear();
            oppervlakteInput.Clear();
        }
    }
}
