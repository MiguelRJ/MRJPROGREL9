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

namespace Rel9Ejer12Color
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

        private void sld_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte rojo = byte.Parse(sldRojo.Value.ToString());
            byte verde = byte.Parse(sldVerde.Value.ToString());
            byte azul = byte.Parse(sldAzul.Value.ToString());
            panel.Background = new SolidColorBrush(Color.FromRgb(rojo, verde, azul));
        }
    }
}
