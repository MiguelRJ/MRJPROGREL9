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

namespace Rel9Ejer1SumaNNumeros
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

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double numero = 0;
            double suma = 0;
            try
            {
                numero = double.Parse(txtboxCaja.Text);
                for (double i = numero; i > 0; i--)
                {
                    suma += numero;
                    numero--;
                }
                MessageBox.Show(" Resultado: " + suma);
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduce solo numeros");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                txtboxCaja.Text = "";
            }
        }
    }
}
