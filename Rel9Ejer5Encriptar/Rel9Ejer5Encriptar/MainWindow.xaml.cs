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

namespace Rel9Ejer5Encriptar
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

        private void btnEncriptar_Click(object sender, RoutedEventArgs e)
        {
            Encriptar(txtBoxEncriptar.Text, comBoxNum.SelectedIndex);
            
        }

        private void Encriptar(string frase, int posiciones)
        {
            char[] original = frase.ToCharArray();
            char[] copia = frase.ToCharArray();
            int numero = 0;
            string fraseEncriptada = string.Empty;
            for (int i = 0; i < original.Length; i++)
            {
                numero = (int)original[i];
                if ((numero >= 97 && numero <= 122) || (numero >= 65 && numero <= 90))
                {
                    numero = EncriptarContar(numero, posiciones);
                }
                copia[i] = (char)numero;
            }
            for (int k = 0; k < copia.Length; k++)
            {
                fraseEncriptada += copia[k];
            }
            lblOriginal.Text = frase;
            lblEncriptada.Text = fraseEncriptada;
            Desencriptar(fraseEncriptada, posiciones);
        }

        private void Desencriptar(string frase, int posiciones)
        {
            char[] original = frase.ToCharArray();
            char[] copia = frase.ToCharArray();
            int numero = 0;
            string fraseDesencriptada = string.Empty;
            for (int i = 0; i < original.Length; i++)
            {
                numero = (int)original[i];
                if ((numero >= 97 && numero <= 122) || (numero >= 65 && numero <= 90))
                {
                    numero = DesencriptarContar(numero,posiciones);
                }
                copia[i] = (char)numero;
            }
            for (int k = 0; k < copia.Length; k++)
            {
                fraseDesencriptada += copia[k];
            }
            lblDesencriptada.Text = fraseDesencriptada;
        }

        private int EncriptarContar(int num, int posiciones)
        {
            if (num >= 97 && num <= 122)
            {
                for (int i = 0; i < posiciones; i++)
                {
                    num++;
                    if (num > 122)
                    {
                        num = 97;
                    }
                }
            }
            if (num >= 65 && num <= 90)
            {
                for (int i = 0; i < posiciones; i++)
                {
                    num++;
                    if (num > 90)
                    {
                        num = 65;
                    }
                }
            }
            return num;
        }

        private int DesencriptarContar(int num, int posiciones)
        {
            if (num >= 97 && num <= 122)
            {
                for (int i = 0; i < posiciones; i++)
                {
                    num--;
                    if (num > 122)
                    {
                        num = 97;
                    }
                    if (num < 97)
                    {
                        num = 122;
                    }
                }
            }
            if (num >= 65 && num <= 90)
            {
                for (int i = 0; i < posiciones; i++)
                {
                    num--;
                    if (num > 90)
                    {
                        num = 65;
                    }
                    if (num < 65)
                    {
                        num = 90;
                    }
                }
            }
            return num;
        }

    }
}
