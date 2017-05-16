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

namespace Rel9Ejer8PalindromoPrimo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            comboPalindromo.Items.Add("Elige un palindromo de la lista");
            comboPalindromo.Items.Add("Añora la Roña");
            comboPalindromo.Items.Add("Amor a Roma");
            comboPalindromo.Items.Add("La ruta natural");
            comboPalindromo.Items.Add("Se van sus naves");
            comboPalindromo.Items.Add("Anita lava la tina");
            comboPalindromo.Items.Add("Ana lava lana");
            comboPalindromo.Items.Add("Eva ya hay ave");
            comboPalindromo.Items.Add("Atar a la rata");
            comboPalindromo.Items.Add("Anula la luna");
            comboPalindromo.Items.Add("Sometamos o matemos");
            txtbxPalindormo.Text = "";
        }

        private void btnPalindromo_Click(object sender, RoutedEventArgs e)
        {
            if (EsPalindromo(ConvertirAMinus(txtbxPalindormo.Text)))
            {
                lblPalindromo.Content = "Si es palindromo";
            }
            else
            {
                lblPalindromo.Content = "No es palindromo";
            }
        }

        private string ConvertirAMinus(string s)
        {
            string nuevaFrase = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (65 <= (int)s[i] && (int)s[i] <= 90)
                {
                    nuevaFrase += (char)(((int)s[i]) + 32);
                }
                else
                {
                    nuevaFrase += s[i];
                }
            }
            return nuevaFrase;
        }

        /// <summary>
        /// quita los espacios a la frase que entre y determina si es un palindromo o no
        /// </summary>
        /// <param name="s">frase que entra para ser comprobada</param>
        /// <returns>TRUE si SI es palindromo, FALSE si NO es palindromo</returns>
        private bool EsPalindromo(string s)
        {
            string nuevaFrase = string.Empty;// nueva frase para quitar los espacios
            for (int i = 0; i < s.Length; i++)//recorremos la frase caracter a caracter
            {
                if (97 <= (int)s[i] && (int)s[i] <= 112)//si el caracter es distinto de espacio
                {
                    nuevaFrase += s[i];//entonces lo metemos en la nueva frase
                }
            }
            int segundocontador = nuevaFrase.Length - 1;//segundo contador porque no se puede hacer con un doble for porque el for aumenta hasta el final del segundo antes de aumentar el primero
            //este contador empieza por el final de la frase
            for (int i = 0; i < nuevaFrase.Length; i++)//recorremos la nueva frase ya sin espacios
            {//este contador empieza por el principio de la frase
                if (nuevaFrase[i] != nuevaFrase[segundocontador])//si el primer caracter es distinto del ultimo ( y asi sumando a un contador y restando a otro)
                {
                    return false;//devuelve false
                }
                segundocontador--;//quitamos uno al contador que cuenta desde el final
            }
            return true;//si llega hasta aqui entonces devuelve true porque es un palindromo
        }

        private void comboPalindromo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtbxPalindormo.Text = comboPalindromo.SelectedItem.ToString();
        }

        private void btnPrimo_Click(object sender, RoutedEventArgs e)
        {

            int numero = 0;
            try
            {
                numero = int.Parse(txtbxPrimo.Text);
                txtPrimoRes.Text = "";
                for (int i = 1; i < numero; i++)
                {
                    if (CalcularPrimo(i))
                    {
                        txtPrimoRes.Text += i.ToString() + ", ";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Numero no valido.");
            }
        }
        static bool CalcularPrimo(int numUsuario)
        {
            if (numUsuario == 1)//si el numero es 1 devuelve false
            {
                return false;//esto es necesario porque no entra en el for
            }
            for (int i = 2; i < numUsuario; i++)//calcula para el resto de numeros si hay otro divisor que no sea 1 o el mismo devuelve false, es decir no es primo
            {
                if (numUsuario % i == 0)
                {
                    return false;
                }
            }
            return true;//si no devuelve el false sale del for y envia true, es decir si es primo
        }

    }


}
