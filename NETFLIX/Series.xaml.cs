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
    /// Lógica de interacción para Series.xaml
    /// </summary>
    public partial class Series : Page
    {
        public Series()
        {
            InitializeComponent();
        }

        private void iniciar(object sender, RoutedEventArgs e)
        {
            VideoWalking.Play();
        }
        

        private void Stop(object sender, MouseEventArgs e)
        {
            VideoWalking.Stop();
            VideoBreaking.Stop();
            VideoBoys.Stop();
            VideoGOT.Stop();
        }

        private void Parar(object sender, RoutedEventArgs e)
        {
            VideoWalking.Pause();

        }

        private void iniciar2(object sender, RoutedEventArgs e)
        {
            VideoBreaking.Play();
           
        }

        private void parar2(object sender, RoutedEventArgs e)
        {
            VideoBreaking.Pause();
            
        }

        private void iniciar3(object sender, RoutedEventArgs e)
        {
            VideoBoys.Play();
        }

        private void parar3(object sender, RoutedEventArgs e)
        {
            VideoBoys.Pause();
        }

        private void iniciar4(object sender, RoutedEventArgs e)
        {
            VideoGOT.Play();
        }

        private void parar4(object sender, RoutedEventArgs e)
        {
            VideoGOT.Pause();
        }
    }
}
