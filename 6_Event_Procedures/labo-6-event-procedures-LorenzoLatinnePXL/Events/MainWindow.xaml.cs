using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Events;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }








    Random random = new Random();
    //Returns a random color every time it is called
    private Brush GetRandomColorBrush()
    {
        return new SolidColorBrush(Color.FromRgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255)));
    }

    private void showMessageButton_Click(object sender, RoutedEventArgs e)
    {
        Button button = (Button)sender;

        //Explicit casting: Forceert een conversie (met geheugenverlies)
        double a = 2.2;
        int b = (int)a;


        // Werkt niet: want 'object' heeft geen property Content.
        // string inhoud1 = sender.Content.ToString();

        // Werkt wel: Eerst explicit cast uitvoeren
        string inhoud = button.Content.ToString();

        // Deel 1
        // MessageBox.Show($"Er werd op de knop {inhoud} geklikt");

        // Deel 1 met naam
        MessageBox.Show($"De knop die geklikt is = {button.Name}");
    }

    private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        nameOutputLabel.Content = $"The key that was pressed is: {e.Key}";

        // Als F-toets, output: dan kleur aanpassen
        // Controle die valideert of de ingedrukte knop een functietoets is.
        if (e.Key >= Key.F1 && e.Key <= Key.F24)
        {
            nameTextBox.Background = GetRandomColorBrush();
        }

        if (e.Key == Key.Return)
        {
            MessageBox.Show(nameTextBox.Text);
        }
    }
}