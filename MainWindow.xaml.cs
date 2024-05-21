using System.Security.Cryptography.X509Certificates;
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

namespace BuckVerwaltungssystem
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public List<Buch> Buecherliste = new List<Buch>();
        private void Hinzufügen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string titel = tbTitle.Text;
                string autor = tbAutor.Text;
                string isbn = tbISBN.Text;
                int erscheinungsjahr = int.Parse(tbErscheinungsjahr.Text);

                Buch neuesBuch = new Buch(titel, autor, isbn, erscheinungsjahr);
                Buecherliste.Add(neuesBuch);
                ReloadBuecherListe();
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte geben Sie ein gültiges Erscheinungsjahr ein.");
            }
        }
        private void ReloadBuecherListe()
        {
            lbBuecher.ItemsSource = null;
            lbBuecher.ItemsSource = Buecherliste;
        }
        private void lbBuecher_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Entfernen_Click(object sender, RoutedEventArgs e)
        {
            if (lbBuecher.SelectedItem is Buch ausgewaeltesBuch)
            {
                Buecherliste.Remove(ausgewaeltesBuch);
                ReloadBuecherListe();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie ein Buch zum Entfernen aus der Liste aus.");
            }
        }

        private void Anzeigen_Click(object sender, RoutedEventArgs e)
        {
            if (lbBuecher.SelectedItem is Buch ausgewaeltesBuch)
            {
                MessageBox.Show(ausgewaeltesBuch.AnzeigenVonInformationen());
                ReloadBuecherListe();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie ein Buch zum Entfernen aus der Liste aus.");
            }
        }

        private void tbErscheinungsjahr_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}