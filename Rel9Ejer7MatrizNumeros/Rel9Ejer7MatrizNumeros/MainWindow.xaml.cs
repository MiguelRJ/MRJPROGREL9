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

namespace Rel9Ejer7MatrizNumeros
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
            CrearElementos(ObtenerNumeros(txtBoxFilas),ObtenerNumeros(txtBoxColumnas));
        }

        private void CrearElementos(List<int> listaFila, List<int> listaColumna)
        {
            stpPanel.Children.RemoveRange(0, stpPanel.Children.Count);
            for (int i = 0; i < listaColumna.Count; i++)
            {
                WrapPanel wrpPnael = new WrapPanel();
                wrpPnael.Orientation = Orientation.Vertical;
                stpPanel.Children.Add(wrpPnael);
                for (int j = 0; j < listaFila.Count; j++)
                {
                    TextBlock txtBlock = new TextBlock();
                    txtBlock.Text = (listaFila[j] * listaColumna[i]).ToString();
                    Thickness margin = new Thickness();
                    margin.Left = 10;
                    margin.Top = 10;
                    margin.Right = 10;
                    margin.Bottom = 10;
                    txtBlock.Margin = margin;
                    txtBlock.Background = Brushes.Beige;
                    txtBlock.TextAlignment = TextAlignment.Center;
                    wrpPnael.Children.Add(txtBlock);
                }
            }
        }

        private List<int> ObtenerNumeros(TextBox caja)
        {
            
            string texto = caja.Text;
            string strNumero = string.Empty;
            List<int> listaNumeros = new List<int>();
            for (int i = 0; i < texto.Length; i++)
            {
                if (char.IsDigit(texto[i]))
                {
                    strNumero += texto[i];
                }
                else
                {
                    if (strNumero != string.Empty)
                    {
                        if (44 == (int)texto[i])
                        {
                            listaNumeros.Add(int.Parse(strNumero));
                            strNumero = string.Empty;
                        }
                    }
                }
            }
            if (strNumero != string.Empty)
            {
                listaNumeros.Add(int.Parse(strNumero));
            }
            return listaNumeros;
        }

    }
}
