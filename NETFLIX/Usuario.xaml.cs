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
    /// Lógica de interacción para Usuario.xaml
    /// </summary>
    public partial class Usuario : Page
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void U2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("   Hola de nuevo Usuario2");
        }

        private void U3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("   Hola de nuevo Usuario3");
        }

        private void U1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No se puede cambiar de usuario, ya eres Usuario1");
        }
    }
}
