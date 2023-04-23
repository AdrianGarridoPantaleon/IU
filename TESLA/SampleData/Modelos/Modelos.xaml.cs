//      *********    NO MODIFIQUE ESTE ARCHIVO     *********
//      Este archivo se regenera mediante una herramienta de diseño.
//       Si realiza cambios en este archivo, puede causar errores.
namespace Expression.Blend.SampleData.Modelos
{
    using System; 
    using System.ComponentModel;

// Para reducir de forma significativa la superficie de los datos de ejemplo en la aplicación de producción, puede establecer
// la constante de compilación condicional DISABLE_SAMPLE_DATA y deshabilitar los datos de ejemplo en tiempo de ejecución.
#if DISABLE_SAMPLE_DATA
    internal class Modelos { }
#else

    public class Modelos : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Modelos()
        {
            try
            {
                Uri resourceUri = new Uri("ms-appx:/SampleData/Modelos/Modelos.xaml", UriKind.RelativeOrAbsolute);
                System.Windows.Application.LoadComponent(this, resourceUri);
            }
            catch
            {
            }
        }

        private ItemCollection _Collection = new ItemCollection();

        public ItemCollection Collection
        {
            get
            {
                return this._Collection;
            }
        }
    }

    public class Item : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _Models = string.Empty;

        public string Models
        {
            get
            {
                return this._Models;
            }

            set
            {
                if (this._Models != value)
                {
                    this._Models = value;
                    this.OnPropertyChanged("Models");
                }
            }
        }

        private System.Windows.Media.ImageSource _photo = null;

        public System.Windows.Media.ImageSource photo
        {
            get
            {
                return this._photo;
            }

            set
            {
                if (this._photo != value)
                {
                    this._photo = value;
                    this.OnPropertyChanged("photo");
                }
            }
        }
    }

    public class ItemCollection : System.Collections.ObjectModel.ObservableCollection<Item>
    { 
    }
#endif
}
