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

namespace Hardware_Monitor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Al primo avvio si mette da sola la schermata Generale

            // Crezione della schermata Generale
            SchermataGenerale visualizzazioneGenerale = new SchermataGenerale();

            // Mettiamola nel segnaposto
            ContenitoreSegnaposto.Content = visualizzazioneGenerale;


        }

        private void BtnSchermataGenerale_Click(object sender, RoutedEventArgs e)
        {
            SchermataGenerale visualizzazioneGenerale = new SchermataGenerale();
            ContenitoreSegnaposto.Content = visualizzazioneGenerale;

        }

        private void BtnSchermataCPU_Click(object sender, RoutedEventArgs e)
        {


        }

        private void BtnSchermataGPU_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSchermataRAM_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSchermataDischi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnRiduci_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnChiudi_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BarraTitolo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Se l'utente ha cliccato con il tasto sinistro del mouse...
            if (e.ChangedButton == MouseButton.Left)
            {
                // ...allora ordina alla finestra di seguire il movimento del cursore
                this.DragMove();
            }
        }
    }
}