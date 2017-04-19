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

namespace Rel9Ejer27Sudoku
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();

        #region Inicializacion de arrays
        int[] Celda00 = new int[9]; int[] Celda01 = new int[9]; int[] Celda02 = new int[9];
        int[] Celda10 = new int[9]; int[] Celda11 = new int[9]; int[] Celda12 = new int[9];
        int[] Celda20 = new int[9]; int[] Celda21 = new int[9]; int[] Celda22 = new int[9];

        int[] Fila0 = new int[9]; int[] Fila1 = new int[9]; int[] Fila2 = new int[9];
        int[] Fila3 = new int[9]; int[] Fila4 = new int[9]; int[] Fila5 = new int[9];
        int[] Fila6 = new int[9]; int[] Fila7 = new int[9]; int[] Fila8 = new int[9];

        int[] Columna0 = new int[9]; int[] Columna1 = new int[9]; int[] Columna2 = new int[9];
        int[] Columna3 = new int[9]; int[] Columna4 = new int[9]; int[] Columna5 = new int[9];
        int[] Columna6 = new int[9]; int[] Columna7 = new int[9]; int[] Columna8 = new int[9];
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            CrearTodosArrays();
        }

        #region Metodos de crear Arrays
        private void CrearTodosArrays()
        {
            CrearCeldasArrays();
            CrearFilasArrays();
            CrearColumnasArrays();
        }

        private void CrearCeldasArrays()
        {
            Celda00 = new int[9] {int.Parse(C00tb00.Text), int.Parse(C00tb01.Text), int.Parse(C00tb02.Text),
                                        int.Parse(C00tb10.Text), int.Parse(C00tb11.Text), int.Parse(C00tb12.Text),
                                        int.Parse(C00tb20.Text), int.Parse(C00tb21.Text), int.Parse(C00tb22.Text)};
            Celda01 = new int[9] {int.Parse(C01tb00.Text), int.Parse(C01tb01.Text), int.Parse(C01tb02.Text),
                                        int.Parse(C01tb10.Text), int.Parse(C01tb11.Text), int.Parse(C01tb12.Text),
                                        int.Parse(C01tb20.Text), int.Parse(C01tb21.Text), int.Parse(C01tb22.Text)};
            Celda02 = new int[9] {int.Parse(C02tb00.Text), int.Parse(C02tb01.Text), int.Parse(C02tb02.Text),
                                        int.Parse(C02tb10.Text), int.Parse(C02tb11.Text), int.Parse(C02tb12.Text),
                                        int.Parse(C02tb20.Text), int.Parse(C02tb21.Text), int.Parse(C02tb22.Text)};

            Celda10 = new int[9] {int.Parse(C10tb00.Text), int.Parse(C10tb01.Text), int.Parse(C10tb02.Text),
                                        int.Parse(C10tb10.Text), int.Parse(C10tb11.Text), int.Parse(C10tb12.Text),
                                        int.Parse(C10tb20.Text), int.Parse(C10tb21.Text), int.Parse(C10tb22.Text)};
            Celda11 = new int[9] {int.Parse(C11tb00.Text), int.Parse(C11tb01.Text), int.Parse(C11tb02.Text),
                                        int.Parse(C11tb10.Text), int.Parse(C11tb11.Text), int.Parse(C11tb12.Text),
                                        int.Parse(C11tb20.Text), int.Parse(C11tb21.Text), int.Parse(C11tb22.Text)};
            Celda12 = new int[9] {int.Parse(C12tb00.Text), int.Parse(C12tb01.Text), int.Parse(C12tb02.Text),
                                        int.Parse(C12tb10.Text), int.Parse(C12tb11.Text), int.Parse(C12tb12.Text),
                                        int.Parse(C12tb20.Text), int.Parse(C12tb21.Text), int.Parse(C12tb22.Text)};

            Celda20 = new int[9] {int.Parse(C20tb00.Text), int.Parse(C20tb01.Text), int.Parse(C20tb02.Text),
                                        int.Parse(C20tb10.Text), int.Parse(C20tb11.Text), int.Parse(C20tb12.Text),
                                        int.Parse(C20tb20.Text), int.Parse(C20tb21.Text), int.Parse(C20tb22.Text)};
            Celda21 = new int[9] {int.Parse(C21tb00.Text), int.Parse(C21tb01.Text), int.Parse(C21tb02.Text),
                                        int.Parse(C21tb10.Text), int.Parse(C21tb11.Text), int.Parse(C21tb12.Text),
                                        int.Parse(C21tb20.Text), int.Parse(C21tb21.Text), int.Parse(C21tb22.Text)};
            Celda22 = new int[9] {int.Parse(C22tb00.Text), int.Parse(C22tb01.Text), int.Parse(C22tb02.Text),
                                        int.Parse(C22tb10.Text), int.Parse(C22tb11.Text), int.Parse(C22tb12.Text),
                                        int.Parse(C22tb20.Text), int.Parse(C22tb21.Text), int.Parse(C22tb22.Text)};
        }

        private void CrearFilasArrays()
        {
            Fila0 = new int[9] {int.Parse(C00tb00.Text), int.Parse(C00tb01.Text), int.Parse(C00tb02.Text),
                                      int.Parse(C01tb00.Text), int.Parse(C01tb01.Text), int.Parse(C01tb02.Text),
                                      int.Parse(C02tb00.Text), int.Parse(C02tb01.Text), int.Parse(C02tb02.Text)};
            Fila1 = new int[9] {int.Parse(C00tb10.Text), int.Parse(C00tb11.Text), int.Parse(C00tb12.Text),
                                      int.Parse(C01tb10.Text), int.Parse(C01tb11.Text), int.Parse(C01tb12.Text),
                                      int.Parse(C02tb10.Text), int.Parse(C02tb11.Text), int.Parse(C02tb12.Text)};
            Fila2 = new int[9] {int.Parse(C00tb20.Text), int.Parse(C00tb21.Text), int.Parse(C00tb22.Text),
                                      int.Parse(C01tb20.Text), int.Parse(C01tb21.Text), int.Parse(C01tb22.Text),
                                      int.Parse(C02tb20.Text), int.Parse(C02tb21.Text), int.Parse(C02tb22.Text)};

            Fila3 = new int[9] {int.Parse(C10tb00.Text), int.Parse(C10tb01.Text), int.Parse(C10tb02.Text),
                                      int.Parse(C11tb00.Text), int.Parse(C11tb01.Text), int.Parse(C11tb02.Text),
                                      int.Parse(C12tb00.Text), int.Parse(C12tb01.Text), int.Parse(C12tb02.Text)};
            Fila4 = new int[9] {int.Parse(C10tb10.Text), int.Parse(C10tb11.Text), int.Parse(C10tb12.Text),
                                      int.Parse(C11tb10.Text), int.Parse(C11tb11.Text), int.Parse(C11tb12.Text),
                                      int.Parse(C12tb10.Text), int.Parse(C12tb11.Text), int.Parse(C12tb12.Text)};
            Fila5 = new int[9] {int.Parse(C10tb20.Text), int.Parse(C10tb21.Text), int.Parse(C10tb22.Text),
                                      int.Parse(C11tb20.Text), int.Parse(C11tb21.Text), int.Parse(C11tb22.Text),
                                      int.Parse(C12tb20.Text), int.Parse(C12tb21.Text), int.Parse(C12tb22.Text)};

            Fila6 = new int[9] {int.Parse(C20tb00.Text), int.Parse(C20tb01.Text), int.Parse(C20tb02.Text),
                                      int.Parse(C21tb00.Text), int.Parse(C21tb01.Text), int.Parse(C21tb02.Text),
                                      int.Parse(C22tb00.Text), int.Parse(C22tb01.Text), int.Parse(C22tb02.Text)};
            Fila7 = new int[9] {int.Parse(C20tb10.Text), int.Parse(C20tb11.Text), int.Parse(C20tb12.Text),
                                      int.Parse(C21tb10.Text), int.Parse(C21tb11.Text), int.Parse(C21tb12.Text),
                                      int.Parse(C22tb10.Text), int.Parse(C22tb11.Text), int.Parse(C22tb12.Text)};
            Fila8 = new int[9] {int.Parse(C20tb20.Text), int.Parse(C20tb21.Text), int.Parse(C20tb22.Text),
                                      int.Parse(C21tb20.Text), int.Parse(C21tb21.Text), int.Parse(C21tb22.Text),
                                      int.Parse(C22tb20.Text), int.Parse(C22tb21.Text), int.Parse(C22tb22.Text)};
        }

        private void CrearColumnasArrays()
        {
            int[] Columna0 = new int[9] { int.Parse(C00tb00.Text), int.Parse(C00tb10.Text), int.Parse(C00tb20.Text),
                                          int.Parse(C10tb00.Text), int.Parse(C10tb10.Text), int.Parse(C10tb20.Text),
                                          int.Parse(C20tb00.Text), int.Parse(C20tb10.Text), int.Parse(C20tb20.Text)};
            int[] Columna1 = new int[9] { int.Parse(C00tb01.Text), int.Parse(C00tb11.Text), int.Parse(C00tb21.Text),
                                          int.Parse(C10tb01.Text), int.Parse(C10tb11.Text), int.Parse(C10tb21.Text),
                                          int.Parse(C20tb01.Text), int.Parse(C20tb11.Text), int.Parse(C20tb21.Text)};
            int[] Columna2 = new int[9] { int.Parse(C00tb02.Text), int.Parse(C00tb12.Text), int.Parse(C00tb22.Text),
                                          int.Parse(C10tb02.Text), int.Parse(C10tb12.Text), int.Parse(C10tb22.Text),
                                          int.Parse(C20tb02.Text), int.Parse(C20tb12.Text), int.Parse(C20tb22.Text)};

            int[] Columna3 = new int[9] { int.Parse(C01tb02.Text), int.Parse(C01tb12.Text), int.Parse(C01tb22.Text),
                                          int.Parse(C11tb02.Text), int.Parse(C11tb12.Text), int.Parse(C11tb22.Text),
                                          int.Parse(C21tb02.Text), int.Parse(C21tb12.Text), int.Parse(C21tb22.Text)};
            int[] Columna4 = new int[9] { int.Parse(C01tb02.Text), int.Parse(C01tb12.Text), int.Parse(C01tb22.Text),
                                          int.Parse(C11tb02.Text), int.Parse(C11tb12.Text), int.Parse(C11tb22.Text),
                                          int.Parse(C21tb02.Text), int.Parse(C21tb12.Text), int.Parse(C21tb22.Text)};
            int[] Columna5 = new int[9] { int.Parse(C01tb02.Text), int.Parse(C01tb12.Text), int.Parse(C01tb22.Text),
                                          int.Parse(C11tb02.Text), int.Parse(C11tb12.Text), int.Parse(C11tb22.Text),
                                          int.Parse(C21tb02.Text), int.Parse(C21tb12.Text), int.Parse(C21tb22.Text)};

            int[] Columna6 = new int[9] { int.Parse(C02tb02.Text), int.Parse(C02tb12.Text), int.Parse(C02tb22.Text),
                                          int.Parse(C12tb02.Text), int.Parse(C12tb12.Text), int.Parse(C12tb22.Text),
                                          int.Parse(C22tb02.Text), int.Parse(C22tb12.Text), int.Parse(C22tb22.Text)};
            int[] Columna7 = new int[9] { int.Parse(C02tb02.Text), int.Parse(C02tb12.Text), int.Parse(C02tb22.Text),
                                          int.Parse(C12tb02.Text), int.Parse(C12tb12.Text), int.Parse(C12tb22.Text),
                                          int.Parse(C22tb02.Text), int.Parse(C22tb12.Text), int.Parse(C22tb22.Text)};
            int[] Columna8 = new int[9] { int.Parse(C02tb02.Text), int.Parse(C02tb12.Text), int.Parse(C02tb22.Text),
                                          int.Parse(C12tb02.Text), int.Parse(C12tb12.Text), int.Parse(C12tb22.Text),
                                          int.Parse(C22tb02.Text), int.Parse(C22tb12.Text), int.Parse(C22tb22.Text)};
        }
        #endregion
    }
}
