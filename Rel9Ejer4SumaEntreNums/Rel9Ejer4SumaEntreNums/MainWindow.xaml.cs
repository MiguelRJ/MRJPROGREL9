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

namespace Rel9Ejer4SumaEntreNums
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            long numInicial = 0;
            long numFinal = 0;
            long numSuma = 0;
            try
            {
                numInicial = long.Parse(txtbxInicial.Text);
                numFinal = long.Parse(txtbxFinal.Text);
                for (long i = numInicial; i <= numFinal; i++)
                {
                    numSuma += i;
                }
                lblResultado.Content = "La suma desde "+numInicial+" hasta "+numFinal+" es: "+numSuma;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
