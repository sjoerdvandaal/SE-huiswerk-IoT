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

namespace SE_huiswerk_IoT
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
        private void AddPersonClicked(object sender, RoutedEventArgs e)
        {
            //TODO Add a person to the list persons
        }
        private void AddAnimalClicked(object sender, RoutedEventArgs e)
        {
            //TODO Add an animal to the person currently selected (week 2)
        }
        private void PersonSelected(object sender, SelectionChangedEventArgs e)
        {
            //TODO Respond on person click event
        }
    }
}