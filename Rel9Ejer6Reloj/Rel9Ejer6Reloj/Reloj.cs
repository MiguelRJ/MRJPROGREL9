using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------
using System.ComponentModel;
using System.Timers;
using System.Globalization;
using System.Windows.Input;
using Migue.RelayCommand;

namespace Rel9Ejer6Reloj
{

    public class Reloj : INotifyPropertyChanged
    {
        #region Campos
        Timer timer;
        const string NOMBRECULTURA = "es-ES";
        CultureInfo culture;
        //No neceisto campos porque las propiedades son solo get
        #endregion

        #region Propiedades de Fechas
        public string Cultura
        {
            get
            {
                return culture.NativeName;
            }
        }

        public DateTime FechaActual
        {
            get
            {
                return DateTime.Now;
            }
        }

        public string FechaLarga
        {
            get
            {
                return FechaActualDiaNombre + ", " + FechaActual.Day + " de " + FechaActualMesNombre + " de " + FechaActual.Year;
            }
        }

        public string FechaActualMesNombre
        {
            get
            {
                return culture.DateTimeFormat.GetMonthName(FechaActual.Month);
            }
        }

        public string FechaActualDiaNombre
        {
            get
            {
                return culture.DateTimeFormat.GetDayName(FechaActual.DayOfWeek);
            }
        }

        public string FechaActualHoras
        {
            get
            {
                if (FechaActual.Hour.ToString().Length == 1)
                {
                    return "0" + FechaActual.Hour;
                }
                else
                {
                    return FechaActual.Hour.ToString();
                }
            }
        }

        public string FechaActualMinutos
        {
            get 
            {
                if (FechaActual.Minute.ToString().Length == 1)
                {
                    return "0" + FechaActual.Minute;
                }
                else
                {
                    return FechaActual.Minute.ToString();
                }
            }
        }

        public string FechaActualSegundos
        {
            get
            {
                if (FechaActual.Second.ToString().Length == 1)
                {
                    return "0" + FechaActual.Second;
                }
                else
                {
                    return FechaActual.Second.ToString();
                }
            }
        }
        #endregion

        #region Propiedades

        public bool FalseIfRelojActivado
        {
            get
            {
                if (timer.Enabled)
                {
                    return false;
                }
                return true;
            }
        }

        public bool FalseIfRelojDetenido
        {
            get
            {
                if (!timer.Enabled)
                {
                    return false;
                }
                return true;
            }
        }

        #endregion

        public Reloj()
        {
            culture = new System.Globalization.CultureInfo(NOMBRECULTURA);
            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Elapsed += timer_Elapsed;
            RelojStart();
        }

        #region Eventos
        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            NotificarCambioPropiedad(null);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotificarCambioPropiedad(string propiedad)
        {
            PropertyChangedEventHandler manejador = PropertyChanged;
            if (manejador != null)
            {
                manejador(this, new PropertyChangedEventArgs(propiedad));
            }
        }
        #endregion

        public void RelojStart()
        {
            if (!timer.Enabled)
            {
                timer.Start();
                NotificarCambioPropiedad("FalseIfRelojActivado");
                NotificarCambioPropiedad("FalseIfRelojDetenido");
            }
        }

        public void RelojStop()
        {
            if (timer.Enabled)
            {
                timer.Stop();
                NotificarCambioPropiedad("FalseIfRelojActivado");
                NotificarCambioPropiedad("FalseIfRelojDetenido");
            }
        }

        public ICommand ActivarReloj
        {
            get
            {
                return new RelayCommand(o => RelojStart(), o => true);
            }
        }
        public ICommand DetenerReloj
        {
            get
            {
                return new RelayCommand(o => RelojStop(), o => true);
            }
        }
        public ICommand Salir
        {
            get
            {
                return new RelayCommand(o => App.Current.Shutdown(), o => true);
            }
        }

    }
}
