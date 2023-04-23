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
    /// Lógica de interacción para LOG.xaml
    /// </summary>
    public partial class LOG : Window
    {
        public LOG()
        {
            InitializeComponent();
        }

        private void logeo(object sender, RoutedEventArgs e)
        {
            string User = this.usuario.Text;

            string Password = this.pass.Password;



            if (User == "" || Password == "")

            {

                MessageBox.Show("Inserte el nombre del usuario o el Password");

                this.usuario.Focus();

                return;

            }

            else

            {

                if (usuario.Text != "Alumno" || pass.Password != "1234")

                {

                    MessageBox.Show("El nombre de usuario o el password es incorrecto");

                    this.usuario.Focus();

                    return;

                }

                else

                {

                    MessageBox.Show("Usuario Correcto");

                    return;

                }
            }
        }

        private void abrirMain(object sender, RoutedEventArgs e)
        {
            Window windows2 = new MainWindow();
            windows2.Show();
        }

        private void MOD(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Muestra de todos los modelos de Tesla");
        }

        private void ENERGY(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Convierta la luz solar en energía");
        }

        private void Soporte(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Temas de actualidad");
        }

        private void Invent(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¿No encuentra el Tesla que está buscando?");
        }

        private void InicioMain(object sender, RoutedEventArgs e)
        {
            Window windows3 = new MainWindow();
            windows3.Show();
        }

        private void tick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("         Registro realizado con exito");
        }

        private void inicio(object sender, RoutedEventArgs e)
        {
             Bienvenido windows4 = new Bienvenido();
            windows4.Show();
        }
    }
}

