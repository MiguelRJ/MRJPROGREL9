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

namespace Rel9Ejer11Frases
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new MainWindow().Show();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (GuardarDatos())
            {
                this.Close();
                new MainWindow().Show();
            }
        }

        private bool GuardarDatos()
        {
            object tamano = 0;
            object familia = null;
            Style estiloNuevo = new Style();
            FontSizeConverter convertidor = new FontSizeConverter();
            FontFamilyConverter conFami = new FontFamilyConverter();
            
            
            
            try
            {
                tamano = txtTamano.Text.ToString();
                familia = listFonts.SelectedItem.ToString();
                Setter Size = new Setter(FontSizeProperty, convertidor.ConvertFrom(tamano));
                Setter Family = new Setter(FontFamilyProperty, conFami.ConvertFrom(familia));
                Setter color = new Setter(ForegroundProperty, new SolidColorBrush(Color.FromRgb(byte.Parse(sldRojo.Value.ToString()), byte.Parse(sldVerde.Value.ToString()), byte.Parse(sldAzul.Value.ToString()))));
                estiloNuevo.Setters.Add(Size);
                estiloNuevo.Setters.Add(Family);
                estiloNuevo.Setters.Add(color);
                App.Current.Resources["txt"] = estiloNuevo;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: "+e.Message);
                return false;
            }
        }

        private void sld_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte rojo = byte.Parse(sldRojo.Value.ToString());
            byte verde = byte.Parse(sldVerde.Value.ToString());
            byte azul = byte.Parse(sldAzul.Value.ToString());
            panel.Background = new SolidColorBrush(Color.FromRgb(rojo, verde, azul));
        }
    }
}
