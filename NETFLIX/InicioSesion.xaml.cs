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
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class InicioSesion : Page
    {
        public InicioSesion()
        {
            InitializeComponent();
        }
        private void ir(object sender, RoutedEventArgs e)
        {
            string User = this.usuario.Text;

            string Password = this.contraseña1.Password;



            if (User == "" || Password == "")

            {

                MessageBox.Show("Inserte el nombre del usuario o el Password");

                this.usuario.Focus();

                return;

            }

            else

            {

                if (usuario.Text != "Alumno" || contraseña1.Password != "1234")

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

        
    }
}
