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

namespace NETFLIX
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

       

        private void inicio(object sender, RoutedEventArgs e)
        {
            IniciarSesion.Visibility = System.Windows.Visibility.Collapsed;
            usuario.Visibility = System.Windows.Visibility.Collapsed;
            multimedia.Visibility = System.Windows.Visibility.Collapsed;
            contacto.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void iniciaeSes(object sender, RoutedEventArgs e)
        {
            IniciarSesion.Visibility = System.Windows.Visibility.Visible;
            IniciarSesion.Content = new InicioSesion();
            IniciarSesion.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            usuario.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void CambiarUsuario(object sender, RoutedEventArgs e)
        {
            usuario.Visibility = System.Windows.Visibility.Visible;
            usuario.Content = new Usuario();
            usuario.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }

        private void menu(object sender, RoutedEventArgs e)
        {
            usuario.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void VerSeries(object sender, RoutedEventArgs e)
        {
            multimedia.Content = new Series();
            multimedia.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            multimedia.Visibility = System.Windows.Visibility.Visible;
        }

        private void VerPelis(object sender, RoutedEventArgs e)
        {
            multimedia.Content = new Pelis();
            multimedia.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            multimedia.Visibility = System.Windows.Visibility.Visible;
        }

        private void VerDocumental(object sender, RoutedEventArgs e)
        {
            multimedia.Content = new Documentales();
            multimedia.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            multimedia.Visibility = System.Windows.Visibility.Visible;
        }

        private void VerFormulario(object sender, RoutedEventArgs e)
        {
            contacto.Content = new Formulario();
            contacto.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            contacto.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
