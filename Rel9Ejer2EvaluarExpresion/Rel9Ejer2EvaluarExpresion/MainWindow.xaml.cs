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

namespace Rel9Ejer2EvaluarExpresion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class ExpresionMalFormadaException : Exception { }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            string expresion = string.Empty;
            string strNumero = string.Empty;
            double resultado = 0;
            double suma = 0;
            char caracterAComprobar = ' ';
            bool operador = false;

            expresion = txtboxExpresion.Text;

            for (int i = 0; i < expresion.Length; i++)
            {
                caracterAComprobar = expresion[i];
                try
                {
                    
                }
                catch (ExpresionMalFormadaException)
                {
                    MessageBox.Show("ERROR EN LA EXPRESION");
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR");
                }
            }
            
            txtblkResultado.Text = resultado.ToString();
        }
    }
}
