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

namespace WpfAppDemoControls
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
            StringBuilder sb = new StringBuilder();

            if (isVIPCheckBox.IsChecked == true)
            {
                sb.AppendLine("Je bent een VIP");
            }

            if (film1RadioButton.IsChecked == true)
            {
                sb.AppendLine("Je bekijkt Film 1");
            }
            else if (film2RadioButton.IsChecked == true)
            {
                sb.AppendLine("Je bekijkt Film 2");
            }
            else
            {
                sb.AppendLine("Je bekijkt Film 3");
            }

            MessageBox.Show(sb.ToString());

        }
    }
}
