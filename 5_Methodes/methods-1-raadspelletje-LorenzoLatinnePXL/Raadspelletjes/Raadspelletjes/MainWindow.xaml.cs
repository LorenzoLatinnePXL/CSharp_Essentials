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
using Microsoft.VisualBasic;

namespace Raadspelletjes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int maxNumber = 10;
        int tries = 0;
        int level = 1;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void startButton(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int winningNumber = rnd.Next(0, maxNumber + 1);
            tries = 0;

            StartCheck(winningNumber, maxNumber);

        }
        private void mainMenuLabel_Loaded(object sender, RoutedEventArgs e)
        {
            mainMenuLabel.Content =
                $"Raad het getal tussen 0 en {maxNumber}.\n" +
                $"Level: {level}";

        }

        private void sluitenButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StartCheck(int winningNumber, int maxNumber)
        {
            int inputGetal;
            do
            {
                tries++;
                inputGetal = GiveAnswer(maxNumber);
                CheckAnswer(inputGetal, winningNumber);
            } while (inputGetal != winningNumber);

            mainMenuLabel.Content =
                $"Raad het getal tussen 0 en {maxNumber}.\n" +
                $"Level: {level}";
        }

        private int GiveAnswer(int maxNumber)
        {
            bool isValidInput = false;
            int inputUser;
            int maximum = maxNumber;

            do
            {
                isValidInput = int.TryParse(Interaction.InputBox($"Geef een getal tussen 0 en {maximum}: ", "Raadspel", "0"), out inputUser);
            }
            while (!isValidInput);

            return inputUser;
        }

        private void CheckAnswer(int getal1, int getal2)
        {

            if (getal1 > getal2)
            {
                MessageBox.Show("Raad lager", "Raadspel", MessageBoxButton.OK);
            }
            else if (getal1 < getal2)
            {
                MessageBox.Show("Raad hoger", "Raadspel", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show($"Proficiat! U heeft het getal geraden in {tries} beurten");
                level++;
                maxNumber += 10;
            }

        }
    }
}
