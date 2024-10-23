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

namespace WpfAppStringBuilderDemo
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

            // FASE 1: INPUT + Declaraties
            // StringBuilder aanmaken;
            StringBuilder sb;
            sb = new StringBuilder();
            int getal = 1;

            // FASE 2: DATA BEWERKING/MANIPULATIE

            // StringBuilder leegmaken
            sb.Clear();

            for (int i = 0; i < 10; i++)
            {
                // Regel tekst toevoegen
                sb.AppendLine(getal.ToString());
                getal++;
            }

            // Append gebruikt geen new line achteraan
            sb.Append("!");
            sb.Append("!");

            // FASE 3: OUTPUT
            resultTextBox.Text = sb.ToString();

        }
    }
}
