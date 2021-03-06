﻿using System;
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

namespace Rel9Ejer11Frases
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //this.Hide();
            new Window1().ShowDialog();
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            Style estilo = App.Current.FindResource("txtEnter") as Style;
            ((TextBlock)sender).Style = estilo;
        }

        private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            Style estilo = App.Current.FindResource("txt") as Style;
            ((TextBlock)sender).Style = estilo;
        }
    }
}
