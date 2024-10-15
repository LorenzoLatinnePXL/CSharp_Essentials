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


                    // indien passwoord == slecht, dan bouw een nieuw wachtwoord

                    StringBuilder passwordBuilder = new StringBuilder();
                    Random rng = new Random();

                    // voeg vijf letters toe van naam

                    // lus voor vijf letters uit gebruikersnaam
                    for (int i = 0; i < 5; i++)
                    {
                        // "gebruikersnaam".Substring(startIndex, lengte) // om een letter te selecteren
                        int willekeurigeIndex = rng.Next(0, inputUserName.Length);
                        string willekeurigeLetter = inputUserName.Substring(willekeurigeIndex, 1);

                        passwordBuilder.Append(willekeurigeLetter);
                    }

                    // voeg vijf random cijfers toe
                    for (int i = 0; i < 5; i++)
                    {
                        int willekeurigCijfer = rng.Next(0, 10);
                        passwordBuilder.Append(willekeurigCijfer);
                    }


                    // voeg twee letters toe van naam + maak er hoofdletters van
                    for (int i = 0; i < 2; i++)
                    {
                        int willekeurigeIndex = rng.Next(0, inputUserName.Length);
                        string willekeurigeLetter = inputUserName.Substring(willekeurigeIndex, 1);

                        passwordBuilder.Append(willekeurigeLetter.ToUpper());
                    }


                    // voeg 1 tot 5 uitroeptekens toe
                    int WillekeurigeHoeveelheidUitroepingstekens = rng.Next(1, 6);

                    for (int i = 0; i < WillekeurigeHoeveelheidUitroepingstekens; i++)
                    {
                        passwordBuilder.Append("!");
                    }

                    resultTextBlock.Text += $"\n\nJe kan beter {passwordBuilder.ToString()} gebruiken als wachtwoord.";

                    MessageBoxResult result = 
                        MessageBox.Show(
                            $"Wil je het voorgestelde wachtwoord: {passwordBuilder.ToString()} gebruiken?", 
                            "Voorgestelde wachtwoord", 
                            MessageBoxButton.YesNo, 
                            MessageBoxImage.Question);

                    if (result == MessageBoxResult.Yes)
                    {
                        passwordTextBox.Text = passwordBuilder.ToString();
                    }

                    break;
            }


        }
    }
}
