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

namespace Rel9Ejer3AcertarNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        const int NUMEROMAXIMO = 100;
        int intentos = 0;
        bool error = false;

        public MainWindow()
        {
            InitializeComponent();
            txtblkNum.Visibility = Visibility.Hidden;
            btnProbar.IsEnabled = false;
        }

        private void btnGenerarNum_Click(object sender, RoutedEventArgs e)
        {
            txtblkNum.Text = rnd.Next(NUMEROMAXIMO).ToString();
            btnGenerarNum.IsEnabled = false;
            btnProbar.IsEnabled = true;
            txtblkFrase.Text = "¿Que numero es?";
            txtbxAcertarNum.Focus();
            intentos = 0;
        }

        private void cbxVerNum_Checked(object sender, RoutedEventArgs e)
        {
            txtblkNum.Visibility = Visibility.Visible;
        }

        private void cbxVerNum_Unchecked(object sender, RoutedEventArgs e)
        {
            txtblkNum.Visibility = Visibility.Hidden;
        }

        private void btnProbar_Click(object sender, RoutedEventArgs e)
        {
            int numero = 0;
            try
            {
                error = false;
                numero = int.Parse(txtbxAcertarNum.Text);
            }
            catch (Exception)
            {
                txtblkFrase.Text = "ERROR: no has indicado un numero.";
                error = true;
            }
            intentos += 1;
            if (numero == int.Parse(txtblkNum.Text.ToString()))
            {
                MessageBox.Show("Acertaste en " + intentos + " intentos");
                btnProbar.IsEnabled = false;
                btnGenerarNum.IsEnabled = true;
                txtblkFrase.Text = "";
            }
            else
            {
                if (!error)
                {
                    if (numero < int.Parse(txtblkNum.Text.ToString()))
                    {
                        txtblkFrase.Text = "NO, el numero buscado es MAYOR";
                    }
                    else
                    {
                        txtblkFrase.Text = "NO, el numero buscado es MENOR";
                    }
                }
            }
            txtbxAcertarNum.Text = "";
            txtbxAcertarNum.Focus();
        }
    }
}
