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

namespace Rel9Ejer13TextoEnriquecido
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

        private void MenuItem_Color(object sender, RoutedEventArgs e)
        {
            if (HayAlgoSeleccionado())
            {
                
            }
        }

        private bool HayAlgoSeleccionado()
        {
            if (rtxtTexto.Selection.IsEmpty)
            {
                stbRunEstado.Text = "Nada seleccionado";
                return false;
            }
            else
            {
                stbRunEstado.Text = "Seleccionado";
                return true;
            }
        }
    }
}

//rtxtTexto.AppendText(rtxtTexto.Selection.Text); duplicar texto