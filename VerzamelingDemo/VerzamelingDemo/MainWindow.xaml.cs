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

namespace VerzamelingDemo
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

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            // input uit tekst element halen
            string input = inputTextBox.Text;

            // toevoegen aan combobox
            // 1. Maak een nieuw ComboBoxItem aan.
            ComboBoxItem newItem = new ComboBoxItem();
            // 2. set Content van item.
            newItem.Content = input;
            // 3. Voeg ComboBoxItem toe.
            vakkenComboBox.Items.Add(newItem);


            // LET OP:
            //vakkenComboBox.Items.Add(input);

            inputTextBox.Clear();

        }

        private void vakkenComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Haal de inhoud uit het geselecteerde element en plaats het in het tesktveld.

            ComboBoxItem geselecteerdItem = vakkenComboBox.SelectedItem as ComboBoxItem;
            // geforcerrd converteren naar ComboBoxItem (indien crash;, dan value = null)

            geselecteerdItem = (ComboBoxItem)vakkenComboBox.SelectedItem;
            // geforceerd converteren naar ComboBoxItem (risico op crash)

            string inhoudVanItem = geselecteerdItem.Content.ToString();

            inputTextBox.Text = inhoudVanItem;
        }
    }
}
