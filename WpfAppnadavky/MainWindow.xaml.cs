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

namespace WpfAppnadavky
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string nadavky = "kokot,kurva,jebať,čurák,piča,";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnObsahuje_Click(object sender, RoutedEventArgs e)
        {
           string[] zoznamNadavok = nadavky.Split(',');
            if (zoznamNadavok.Any(nadavka => txtTextPouzivatela.Text.Contains(nadavka, StringComparison.InvariantCultureIgnoreCase)))
            {
                MessageBox.Show("Text obsahuje nadávky.");
            }
            else
            {
                MessageBox.Show("Text neobsahuje nadávky.");
            }
        }
    }
}