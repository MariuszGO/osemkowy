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

namespace osemkowy
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

            int licz;
            String wyn= "";


            if (Int32.TryParse(liczba.Text, out licz))
            {
                while(licz != 0)
                {
                    wyn = Convert.ToString(licz % 8) + wyn;
                    licz = licz / 8;        
                }

                wynik.Content = wyn;

            }
            else
            {
                MessageBox.Show("Błąd");
            }

            

        }
    }
}