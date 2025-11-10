using System.Collections.ObjectModel;
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

namespace WpfApp3
{
    public class Person
    {
        public string MitarbeiterID { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Abteilung { get; set; }
        public string Status { get; set; }
        public double Gehalt { get; set; }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> MeineDatenListe { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            //Hier Datenbank Zugriff einbauen.
            MeineDatenListe = new ObservableCollection<Person>();
            MeineDatenListe.Add(new Person { MitarbeiterID = "01", Name = "Sehler", Vorname = "Patrick", Abteilung = "2.2", Status = "Azubi", Gehalt = 10000 });
            MeineDatenListe.Add(new Person { MitarbeiterID = "02", Name = "Michelakis", Vorname = "Nektarios", Abteilung = "2.2", Status = "Azubi", Gehalt = 10001 });
            DataContext = this;
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            //Hier Datenbank Zugriff einbauen.
            MeineDatenListe.Add(new Person { MitarbeiterID = "03", Name = "So wie mans halt schreibt", Vorname = "Jan", Abteilung = "2.2", Status = "Azubi", Gehalt = 10000 });
        }

        private void Bearbeiten_Button_Click(object sender, RoutedEventArgs e)
        {
            Mitarbeiter_Bearbeiten mitarbeiter_Bearbeiten = new Mitarbeiter_Bearbeiten();
            mitarbeiter_Bearbeiten.Show();
            Console.WriteLine("Welchen Mitarbeiter möchten Sie löschen?");
            string zubearbeitendePerson = Console.ReadLine();
            Console.WriteLine(zubearbeitendePerson);
            //Hier Datenbank Zugriff einbauen.
            //MeineDatenListe.Remove();
        }
    }
}