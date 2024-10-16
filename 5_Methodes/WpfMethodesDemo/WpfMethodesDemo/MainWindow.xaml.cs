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

namespace WpfMethodesDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 2 parameter methode
            Plus(1, 2);

            // 3 parameter methode
            Plus(1, 2, 3);
        }

        // Method overloading = methodes die dezelfde naam hebben, maar andere parameters
        // -> kleine aanpassingen in gedrag

        private int Plus(int x, int y)
        {
            MessageBox.Show("2 parameter methode");
            return x + y;
        }

        private int Plus(int x, int y, int z)
        {
            MessageBox.Show("3 parameter methode");
            return x + y + z;
        }
    }
}
