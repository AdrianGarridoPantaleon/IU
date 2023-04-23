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
using System.Windows.Shapes;

namespace TESLA
{
    /// <summary>
    /// Lógica de interacción para Bienvenido.xaml
    /// </summary>
    public partial class Bienvenido : Window
    {
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void volveraTesla(object sender, RoutedEventArgs e)
        {
            MainWindow windows5 = new MainWindow();
            windows5.Show();
        }
    }
}
