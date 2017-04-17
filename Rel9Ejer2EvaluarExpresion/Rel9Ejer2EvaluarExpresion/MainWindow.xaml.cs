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
            try
            {
                InitializeComponent();
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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            string expresion = string.Empty;
            string strNumero = "";
            double resultado = 0;
            double numero = 0;

            bool operacionSuma = false;
            bool operacionResta = false;
            bool operacionMultiplicacion = false;
            bool operacionDivision = false;

            expresion = txtboxExpresion.Text;

            for (int i = 0; i < expresion.Length; i++)
            {
                if ( 0 <= expresion[i] && expresion[i] <= 9)
                {
                    
                }
            }

            txtblkResultado.Text = resultado.ToString();
        }

        private void SwitchCalcular(char caracterAComprobar)
        {
            double suma = 0;
            string strNumero = "";
            bool operador = false;

            switch (caracterAComprobar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case ',':
                    strNumero += caracterAComprobar.ToString();
                    operador = false;
                    break;
                case '+':
                    if (operador)
                    {
                        throw new ExpresionMalFormadaException();
                    }
                    operador = true;
                    suma += double.Parse(strNumero);
                    break;
                case '-':
                    if (operador)
                    {
                        throw new ExpresionMalFormadaException();
                    }
                    operador = true;
                    suma -= double.Parse(strNumero);
                    break;
                case '*':
                    if (operador)
                    {
                        throw new ExpresionMalFormadaException();
                    }
                    operador = true;
                    suma *= double.Parse(strNumero);
                    break;
                case '/':
                    if (operador)
                    {
                        throw new ExpresionMalFormadaException();
                    }
                    operador = true;
                    suma /= double.Parse(strNumero);
                    break;
                default:
                    break;
            }
        }
    }
}
