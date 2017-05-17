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
//----------


namespace Rel9Ejer19MatrizBotones
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CBotones botones = null;
        public MainWindow()
        {
            InitializeComponent();
            AnadirItemsAComboBox();
            botones = new CBotones();
        }

        private void AnadirItemsAComboBox()
        {
            for (int i = 0; i < 20; i++)
            {
                cmbFilas.Items.Add(i);
                cmbColumnas.Items.Add(i);
            }
            cmbFilas.SelectedIndex = 0;
            cmbColumnas.SelectedIndex = 0;
        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            botones.CrearMatrizBotones(stpBotones, cmbFilas, cmbColumnas);
        }

        
    }
}
