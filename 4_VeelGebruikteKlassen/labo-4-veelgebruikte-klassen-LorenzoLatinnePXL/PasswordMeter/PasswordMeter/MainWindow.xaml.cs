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

namespace PasswordMeter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Input velden: userNameTextBox en passwordTextBox
        /// Output veld: resultTextBlock
        /// </summary>

        public MainWindow()
        {
            InitializeComponent();
        }

        private void passwordMeterButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: spaties weghalen
            string trimmedText = userNameTextBox.Text.Trim();
            userNameTextBox.Text = trimmedText;

            string trimmedPasswordText = passwordTextBox.Text.Trim();
            passwordTextBox.Text = trimmedPasswordText;


            // PasswordStrenght Booleans
            bool hasDigitInPassword = false;
            bool hasNotUsernameInPassword = false;
            bool isPasswordLengthTenOrGreater = false;

            int passwordStrenghtNumber = 0;


            // for (aanmaken van een teller; voorwaarde voor herhaling; verhoging)
            // { // code om te herhalen }

            string inputUserName = userNameTextBox.Text;
            string inputPassword = passwordTextBox.Text;

            // for -> letter per letter door het ww: om te controleren of het een cijfer is
            // Vb: 44PXLCSharp
            for (int i = 0; i < inputPassword.Length; i++)
            {
                string characterFromPassword = inputPassword.Substring(i, 1);
                // converteer karakter
                char character = char.Parse(characterFromPassword);

                if (char.IsDigit(character) && !hasDigitInPassword)
                {
                    hasDigitInPassword = true;
                    passwordStrenghtNumber++;
                }
            }

            hasNotUsernameInPassword = !inputPassword.Contains(inputUserName);
            if (hasNotUsernameInPassword)
            {
                passwordStrenghtNumber++;
            }

            isPasswordLengthTenOrGreater = inputPassword.Length >= 10;
            if (isPasswordLengthTenOrGreater)
            {
                passwordStrenghtNumber++;
            }


            // OUTPUT
            // switch (variabeleNaam)
            // {
            //      case waardeVanVariabelen:
            //          code om uit te voeren
            // }


            switch (passwordStrenghtNumber)
            {
                case 3:
                    resultTextBlock.Text = "Je hebt een sterk wachtwoord gekozen";
                    resultTextBlock.Background = Brushes.Green;
                    break;

                case 2:
                    resultTextBlock.Text = "Je hebt een matig wachtwoord gekozen";
                    resultTextBlock.Background = Brushes.Yellow;
                    break;


                default:
                    resultTextBlock.Text = "Je hebt een slecht wachtwoord gekozen";
                    resultTextBlock.Background = Brushes.Red;
                    break;
            }


        }
    }
}
