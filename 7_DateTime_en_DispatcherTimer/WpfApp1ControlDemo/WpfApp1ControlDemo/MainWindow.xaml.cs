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
using System.Windows.Threading;

namespace WpfApp1ControlDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // DATETIME een object dat een moment in tijd kan opslaan.

            DateTime nu = DateTime.Now;
            DateTime vandaag = DateTime.Today;

            DateTime coronaDag = new DateTime(2019, 3, 19); // Gebruikt een constructor.

            coronaDag = coronaDag.AddDays(1);

            outputTextBlock.Text = $"{nu.ToLongTimeString()}\n" +
                $"{vandaag.ToLongDateString()}\n" +
                $"{coronaDag.ToShortDateString()}\n" +
                $"{nu}";


            // TimeSpan: een object dat de tijdsduur aangeeft
            TimeSpan tijdsduur = new TimeSpan(1, 0, 0);

            TimeSpan tijdSindsCovid = vandaag - coronaDag;

            outputTextBlock.Text += $"\n{tijdSindsCovid.TotalDays}";


            // hoe kan ik live de tijd tonen?
            // -> met een DispatcherTimer

            // heeft de volgende namespace nodig: using System.Windows.Threading;
            DispatcherTimer mijnEersteDispatcherTimer = new DispatcherTimer();
            // 1. INTERVAL: TimeSpan toekennen (om de hoeveel tijd moet er iets gebeuren?)
            mijnEersteDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            mijnEersteDispatcherTimer.Interval = TimeSpan.FromMilliseconds(500);
            // 2. TICK: Wat moet er gebeuren?
            mijnEersteDispatcherTimer.Tick += MijnEersteDispatcherTimer_Tick;

            // 3. Start() de timer.
            mijnEersteDispatcherTimer.Start();

        }

        private void MijnEersteDispatcherTimer_Tick(object sender, EventArgs e)
        {
            outputTextBlock.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
