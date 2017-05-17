using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Rel9Ejer19MatrizBotones
{
    class CBotones
    {
        public void CrearMatrizBotones(StackPanel stpBotones, ComboBox cmbFilas, ComboBox cmbColumnas)
        {
            stpBotones.Children.RemoveRange(0, stpBotones.Children.Count);
            int fila;
            int columna;
            fila = int.Parse(cmbFilas.SelectedItem.ToString());
            columna = int.Parse(cmbColumnas.SelectedItem.ToString());

            for (int i = 0; i < columna; i++)
            {
                WrapPanel wrpPanel = new WrapPanel();
                wrpPanel.Orientation = Orientation.Vertical;
                stpBotones.Children.Add(wrpPanel);
                for (int j = 0; j < fila; j++)
                {
                    Button tmpBoton = new Button();
                    Thickness margin = tmpBoton.Margin;
                    margin.Left = 10;
                    margin.Top = 10;
                    margin.Right = 10;
                    margin.Bottom = 10;
                    tmpBoton.Margin = margin;
                    tmpBoton.Content = "[" + j + "," + i + "]";
                    tmpBoton.Width = 40;
                    tmpBoton.Height = 25;
                    tmpBoton.MouseEnter += mouseover;
                    tmpBoton.MouseLeave += mouserLeave;
                    tmpBoton.Click += mouseclick;
                    wrpPanel.Children.Add(tmpBoton);
                }
            }
        }

        private void mouseclick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((sender as Button).Content.ToString());
        }

        private void mouserLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            (sender as Button).Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
        }

        private void mouseover(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Random rnd = new Random();
            byte rojo = byte.Parse(rnd.Next(255).ToString());
            byte verde = byte.Parse(rnd.Next(255).ToString());
            byte azul = byte.Parse(rnd.Next(255).ToString());
            (sender as Button).Background = new SolidColorBrush(Color.FromRgb(rojo,verde,azul));
        }
    }
}
