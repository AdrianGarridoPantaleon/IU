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

namespace TESLA
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menu(object sender, RoutedEventArgs e)
        {

        }

        private void abrirLog(object sender, RoutedEventArgs e)
        {
            Window windows2 = new LOG();
            windows2.Show();
        }

        private void MOD(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Muestra de todos los modelos de Tesla");
        }

        private void soporte(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Temas de actualidad");
        }

        private void invent(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¿No encuentra el Tesla que está buscando?");
        }

        private void precio(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("     Desde 80.000 €");
        }

        private void precio2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("     Desde 49.000 €");
        }

        private void precio3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("     Desde 90.000 €");
        }

        private void precio4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("     Desde 64.000 €");
        }
    }
}
