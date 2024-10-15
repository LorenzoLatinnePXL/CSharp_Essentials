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

// Microsoft.VisualBasic Reference toevoegen en hierbij schrijven.
using Microsoft.VisualBasic;



namespace VeelGebruikteKlassenDemo3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // !!! hou InitializeComponent(); als eerste regel in MainWindow()
            // Vertaalt de XAML file (MainWindow) naar C# code en voert deze uit.
            InitializeComponent();

            // MessageBox
            // Parameters in MessageBox. (1e: Tekst in box, 2e: Tekst in titel, 3e: Tekst van knoppen, 4e: Image voor de tekst in window)
            // MessageBox.Show("Hello world", "Welkom", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            MessageBoxResult result = MessageBox.Show(
                "Wil je een rode kleur?", 
                "Welkom", 
                MessageBoxButton.YesNo, 
                MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                backgroundGrid.Background = Brushes.Red;
            } else
            {
                backgroundGrid.Background= Brushes.Blue;
            }


            string resultInteraction = 
                Interaction.InputBox(
                    "Kies een titel voor het venster", 
                    "Kies je titel", 
                    "MainWindow");
            this.Title = resultInteraction;
        }
    }
}
