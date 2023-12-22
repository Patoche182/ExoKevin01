using System.Windows;

namespace ExoKevin01
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show(Calcul(), "Jour de semaine", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        private string Calcul()
        {
            string[] joursSemaine = { "Erreur", "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };

            string valeur = this.inputUser.Text;

            int indexJour;
            if (int.TryParse(valeur, out indexJour) && indexJour >= 1 && indexJour <= 7)
            {
                return joursSemaine[indexJour];
            }
            else
            {
                return joursSemaine[0]; // "Erreur" si la valeur n'est pas valide
            }
        }

    }
}