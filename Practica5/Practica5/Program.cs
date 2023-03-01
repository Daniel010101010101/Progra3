using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Practica5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalendarioEntrada ce = new CalendarioEntrada();
            ce.FechaHoy = DateTime.Now;
            WriteLine(ce.FechaHoy);
          

            ReadKey();
        }
    }
    public class CalendarioEntrada
    {
        private DateTime Fecha;
        public DateTime FechaHoy 
        { 
            get
            {
                return Fecha;
            }
            set
            {
                if (value.Year > 1990 && value.Year <= DateTime.Today.Year)
                {
                    Fecha = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Fecha");
                }
            }
        }
        public string Dia;
        public void setFecha(string fechaString)
        {
            DateTime dt = Convert.ToDateTime(fechaString);
            if (dt.Year > 1990 && dt.Year <= DateTime.Today.Year)
            {
                Fecha = dt;
            }
            else
            {
                throw new ArgumentOutOfRangeException("fechaString");
            }
        }
        public TimeSpan GetTimeSpan(string fechaString) 
        {
            DateTime dt = Convert.ToDateTime(fechaString);
            if (dt.Ticks< Fecha.Ticks )
            {
                return Fecha - dt;
            }
            else
            {
                throw new ArgumentOutOfRangeException("fechaString");
            }

        }
    }
    public class CalendarioInicializado
    {
        public string Dia = "Lunes";

    }
    
}


