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
        int Dificultad = 99;
        int numSudoku;

        #region Inicializacion de arrays

        int cont = 0;
        List<List<int[]>> ListaCeldas;
        List<int[]> ListaCeldas0; int[] Celda00; int[] Celda01; int[] Celda02;
        List<int[]> ListaCeldas1; int[] Celda10; int[] Celda11; int[] Celda12;
        List<int[]> ListaCeldas2; int[] Celda20; int[] Celda21; int[] Celda22;

        List<int[]> ListaFilas;
        int[] Fila0; int[] Fila1; int[] Fila2;
        int[] Fila3; int[] Fila4; int[] Fila5;
        int[] Fila6; int[] Fila7; int[] Fila8;

        List<int[]> ListaColumnas;
        int[] Columna0; int[] Columna1; int[] Columna2;
        int[] Columna3; int[] Columna4; int[] Columna5;
        int[] Columna6; int[] Columna7; int[] Columna8;

        TextBox[] CeldasIndividuales;
        int[,] SudokusArr = new int[2, 81] { 
            {8,7,6,4,5,9,2,1,3,1,5,4,2,8,3,9,6,7,9,2,3,7,1,6,8,5,4,7,3,1,9,4,5,6,2,8,6,4,2,1,7,8,5,3,9,5,9,8,3,6,2,7,4,1,2,1,7,6,9,4,3,8,5,3,8,9,5,2,1,4,7,6,4,6,5,8,3,7,1,9,2},
            {9,2,1,4,6,5,8,3,7,8,5,3,2,1,7,6,9,4,7,6,4,3,8,9,5,2,1,5,4,8,9,2,3,7,1,6,1,3,2,8,7,6,4,5,9,6,7,9,1,5,4,2,8,3,3,9,5,6,4,2,1,7,8,4,1,7,5,9,8,3,6,2,2,8,6,7,3,1,9,4,5}
        };
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            CrearCeldasIndividuales();
            CrearTodosArrays();
            GridSudoku.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Modifica todos los textbox de una vez
        /// </summary>
        private void ModCeldasIndividuales()
        {
            for (int i = 0; i < CeldasIndividuales.Length; i++)
            {
                CeldasIndividuales[i].Background = new SolidColorBrush(Colors.White);
                CeldasIndividuales[i].Text = "";
                if (rnd.Next(0, 101) < Dificultad)
                {
                    CeldasIndividuales[i].Text = SudokusArr[numSudoku, i].ToString(); 
                }
                else
                {
                    CeldasIndividuales[i].Text = "";
                }
            }
        }

        #region Metodos de crear Arrays
        /// <summary>
        /// metodo que unifica los demas
        /// </summary>
        private void CrearTodosArrays()
        {
            CrearCeldasArrays();
            CrearFilasArrays();
            CrearColumnasArrays();
            CrearListaFilas();
            CrearListaColumnas();
            CrearListaCeldas();
        }

        private void CrearListaFilas()
        {
            ListaFilas = new List<int[]>();
            ListaFilas.Add(Fila0);
            ListaFilas.Add(Fila1);
            ListaFilas.Add(Fila2);
            ListaFilas.Add(Fila3);
            ListaFilas.Add(Fila4);
            ListaFilas.Add(Fila5);
            ListaFilas.Add(Fila6);
            ListaFilas.Add(Fila7);
            ListaFilas.Add(Fila8);
        }
        private void CrearListaColumnas()
        {
            ListaColumnas = new List<int[]>();
            ListaColumnas.Add(Columna0);
            ListaColumnas.Add(Columna1);
            ListaColumnas.Add(Columna2);
            ListaColumnas.Add(Columna3);
            ListaColumnas.Add(Columna4);
            ListaColumnas.Add(Columna5);
            ListaColumnas.Add(Columna6);
            ListaColumnas.Add(Columna7);
            ListaColumnas.Add(Columna8);
        }
        private void CrearListaCeldas()
        {
            ListaCeldas = new List<List<int[]>>();
                ListaCeldas0 = new List<int[]>();
                    ListaCeldas0.Add(Celda00);
                    ListaCeldas0.Add(Celda01);
                    ListaCeldas0.Add(Celda02);
                    ListaCeldas.Add(ListaCeldas0);
                ListaCeldas1 = new List<int[]>();
                    ListaCeldas1.Add(Celda10);
                    ListaCeldas1.Add(Celda11);
                    ListaCeldas1.Add(Celda12);
                    ListaCeldas.Add(ListaCeldas1);
                ListaCeldas2 = new List<int[]>();
                    ListaCeldas2.Add(Celda20);
                    ListaCeldas2.Add(Celda21);
                    ListaCeldas2.Add(Celda22);
                    ListaCeldas.Add(ListaCeldas2);
        }

        /// <summary>
        /// crea los array de las celdas de 3x3
        /// </summary>
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

        /// <summary>
        /// crea los array de las filas
        /// </summary>
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

        /// <summary>
        /// crea los array de las columnas
        /// </summary>
        private void CrearColumnasArrays()
        {
            Columna0 = new int[9] { int.Parse(C00tb00.Text), int.Parse(C00tb10.Text), int.Parse(C00tb20.Text),
                                          int.Parse(C10tb00.Text), int.Parse(C10tb10.Text), int.Parse(C10tb20.Text),
                                          int.Parse(C20tb00.Text), int.Parse(C20tb10.Text), int.Parse(C20tb20.Text)};
            Columna1 = new int[9] { int.Parse(C00tb01.Text), int.Parse(C00tb11.Text), int.Parse(C00tb21.Text),
                                          int.Parse(C10tb01.Text), int.Parse(C10tb11.Text), int.Parse(C10tb21.Text),
                                          int.Parse(C20tb01.Text), int.Parse(C20tb11.Text), int.Parse(C20tb21.Text)};
            Columna2 = new int[9] { int.Parse(C00tb02.Text), int.Parse(C00tb12.Text), int.Parse(C00tb22.Text),
                                          int.Parse(C10tb02.Text), int.Parse(C10tb12.Text), int.Parse(C10tb22.Text),
                                          int.Parse(C20tb02.Text), int.Parse(C20tb12.Text), int.Parse(C20tb22.Text)};

            Columna3 = new int[9] { int.Parse(C01tb02.Text), int.Parse(C01tb12.Text), int.Parse(C01tb22.Text),
                                          int.Parse(C11tb02.Text), int.Parse(C11tb12.Text), int.Parse(C11tb22.Text),
                                          int.Parse(C21tb02.Text), int.Parse(C21tb12.Text), int.Parse(C21tb22.Text)};
            Columna4 = new int[9] { int.Parse(C01tb02.Text), int.Parse(C01tb12.Text), int.Parse(C01tb22.Text),
                                          int.Parse(C11tb02.Text), int.Parse(C11tb12.Text), int.Parse(C11tb22.Text),
                                          int.Parse(C21tb02.Text), int.Parse(C21tb12.Text), int.Parse(C21tb22.Text)};
            Columna5 = new int[9] { int.Parse(C01tb02.Text), int.Parse(C01tb12.Text), int.Parse(C01tb22.Text),
                                          int.Parse(C11tb02.Text), int.Parse(C11tb12.Text), int.Parse(C11tb22.Text),
                                          int.Parse(C21tb02.Text), int.Parse(C21tb12.Text), int.Parse(C21tb22.Text)};

            Columna6 = new int[9] { int.Parse(C02tb02.Text), int.Parse(C02tb12.Text), int.Parse(C02tb22.Text),
                                          int.Parse(C12tb02.Text), int.Parse(C12tb12.Text), int.Parse(C12tb22.Text),
                                          int.Parse(C22tb02.Text), int.Parse(C22tb12.Text), int.Parse(C22tb22.Text)};
            Columna7 = new int[9] { int.Parse(C02tb02.Text), int.Parse(C02tb12.Text), int.Parse(C02tb22.Text),
                                          int.Parse(C12tb02.Text), int.Parse(C12tb12.Text), int.Parse(C12tb22.Text),
                                          int.Parse(C22tb02.Text), int.Parse(C22tb12.Text), int.Parse(C22tb22.Text)};
            Columna8 = new int[9] { int.Parse(C02tb02.Text), int.Parse(C02tb12.Text), int.Parse(C02tb22.Text),
                                          int.Parse(C12tb02.Text), int.Parse(C12tb12.Text), int.Parse(C12tb22.Text),
                                          int.Parse(C22tb02.Text), int.Parse(C22tb12.Text), int.Parse(C22tb22.Text)};
        }

        /// <summary>
        /// crea el array de todos los textbox juntos
        /// </summary>
        private void CrearCeldasIndividuales()
        {
            CeldasIndividuales = new TextBox[81] { C00tb00, C00tb01, C00tb02, C01tb00, C01tb01, C01tb02, C02tb00, C02tb01, C02tb02, 
                                                    C00tb10, C00tb11, C00tb12, C01tb10, C01tb11, C01tb12, C02tb10, C02tb11, C02tb12,
                                                    C00tb20, C00tb21, C00tb22, C01tb20, C01tb21, C01tb22, C02tb20, C02tb21, C02tb22, 

                                                    C10tb00, C10tb01, C10tb02, C11tb00, C11tb01, C11tb02, C12tb00, C12tb01, C12tb02, 
                                                    C10tb10, C10tb11, C10tb12, C11tb10, C11tb11, C11tb12, C12tb10, C12tb11, C12tb12, 
                                                    C10tb20, C10tb21, C10tb22, C11tb20, C11tb21, C11tb22, C12tb20, C12tb21, C12tb22, 

                                                    C20tb00, C20tb01, C20tb02, C21tb00, C21tb01, C21tb02, C22tb00, C22tb01, C22tb02, 
                                                    C20tb10, C20tb11, C20tb12, C21tb10, C21tb11, C21tb12, C22tb10, C22tb11, C22tb12, 
                                                    C20tb20, C20tb21, C20tb22, C21tb20, C21tb21, C21tb22, C22tb20, C22tb21, C22tb22};
            RellenarCeldasIndividuales();
        }
        private void RellenarCeldasIndividuales()
        {
            for (int i = 0; i < CeldasIndividuales.Length; i++)
            {
                CeldasIndividuales[i].Text = "-1";
            }
        }
        #endregion

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            numSudoku = rnd.Next(0, SudokusArr.GetLength(0));
            ModCeldasIndividuales();
            GridSudoku.Visibility = Visibility.Visible;
        }

        private void btnComprobar_Click(object sender, RoutedEventArgs e)
        {
            bool vacia = false;
            for (int i = 0; i < CeldasIndividuales.Length; i++)
            {
                if (CeldasIndividuales[i].Text=="")
                {
                    vacia = true;
                    CeldasIndividuales[i].Background = new SolidColorBrush(Colors.Beige);
                }
            }
            if (vacia)
            {
                MessageBox.Show("Quedan celdas vacias...");
            }
            else
            {
                for (int i = 0; i < CeldasIndividuales.Length; i++)
                {
                    if (CeldasIndividuales[i].Text.ToString() != SudokusArr[numSudoku,i].ToString())
                    {
                        MessageBox.Show("El sudoku no es correcto.");
                        CeldasIndividuales[i].Background = new SolidColorBrush(Colors.Tomato);
                    }
                }
            }
        }
    }
}

/*
/// <summary>
        /// Modifica todos los textbox de una vez
        /// </summary>
        private void ModCeldasIndividuales()
        {
            int numerornd;
            int finalnumerornd;
            int numColumna;
            int numFila;
            string nombreCelda;
            int primerNumCelda;
            int segunNumCelda;
            bool escrito;
            for (int i = 0; i < CeldasIndividuales.Length; i++)
            {
                numerornd = rnd.Next(1,10);
                finalnumerornd = numerornd;
                numColumna = Grid.GetColumn(CeldasIndividuales[i]);
                numFila = Grid.GetRow(CeldasIndividuales[i]);
                nombreCelda = CeldasIndividuales[i].Name;
                primerNumCelda = int.Parse(nombreCelda[1].ToString());
                segunNumCelda = int.Parse(nombreCelda[2].ToString());
                escrito = false;
                while (!escrito)
                {
                    if (BuscarNumero(finalnumerornd, numColumna, numFila, primerNumCelda, segunNumCelda))
                    {
                        CeldasIndividuales[i].Text = finalnumerornd.ToString();
                        ListaFilas[numFila][numColumna] = finalnumerornd;
                        ListaColumnas[numColumna][numFila] = finalnumerornd;   
                        ListaCeldas[primerNumCelda][primerNumCelda][cont] = finalnumerornd;
                        cont++;
                        if (cont==9)
                        {
                            cont = 0;
                        }
                        escrito = true;
                    }
                    else
                    {
                        if (finalnumerornd + 1 == 10)
                        {
                            finalnumerornd = 1;
                        }
                        else
                        {
                            finalnumerornd += 1;
                        }
                    }
                }
                
            }
        }

        private bool BuscarNumero(int numero, int columna, int fila, int primerNumCelda, int segunNumCelda)
        {
            if (!ListaFilas[fila].Contains<int>(numero))
            {
                if (!ListaColumnas[columna].Contains<int>(numero))
                {
                    if (!ListaCeldas[primerNumCelda][segunNumCelda].Contains<int>(numero))
                    {
                        return true;
                    }
                }
            }
            return false;
        } 
 */
