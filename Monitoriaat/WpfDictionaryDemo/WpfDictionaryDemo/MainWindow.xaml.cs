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

namespace WpfDictionaryDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Dictionary<ComboBox, Label> keuzeMenu;

        public MainWindow()
        {
            InitializeComponent();


            Dictionary<string, double> studentenScores;
                studentenScores = new Dictionary<string, double>();

            studentenScores.Add("Sander", 14);
            studentenScores.Add("Jos", 2);
            studentenScores.Add("Semih", 20);


            double scoreVanSemih = studentenScores["Semih"];

            bool isValidKey = studentenScores.TryGetValue("Semih", out  scoreVanSemih);

            // Linken van dropdown menus aan kleurpanels
            keuzeMenu = new Dictionary<ComboBox, Label>();
            keuzeMenu.Add(TestComboBox, TestLabel1);
            keuzeMenu.Add(TestComboBox2, TestLabel2);
            keuzeMenu.Add(TestComboBox3, TestLabel3);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox changedComboBox = sender as ComboBox;
            // ComboBox changedComboBox = (ComboBox)sender;
            Label labelOmAanTePassen = keuzeMenu[changedComboBox];

            if (changedComboBox == TestComboBox)
            {
                TestLabel1.Background = GetColorFromIndex(changedComboBox.SelectedIndex);
            } 
            else if (changedComboBox == TestComboBox2)
            {
                TestLabel2.Background = GetColorFromIndex(changedComboBox.SelectedIndex);
            }
            else
            {
                TestLabel3.Background = GetColorFromIndex(changedComboBox.SelectedIndex);
            }
        }

        private Brush GetColorFromIndex(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    return Brushes.Red;
                default:
                    return Brushes.Blue;
            }
        }
    }
}
