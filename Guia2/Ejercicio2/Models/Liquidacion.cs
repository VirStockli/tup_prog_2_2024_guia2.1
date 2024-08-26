using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Liquidacion
    {
        public int Año { get; private set; }
        public int Mes { get; private set; }
        public double MontoBasico { get; private set; }
        public double PorcAntiguedad { get; private set; }
        public double MontoAntiguedad { get; private set; }
        public double HorasExtras50 { get; private set; }
        public double MontoExtras50 { get; private set; }
        public double HorasExtras100 { get; private set; }
        public double MontoExtras100 { get; private set; }

        public double Nominal { get
            {
                // Nominal = Empleado.MontoBasicoNominal
            }; private set { } }
        public double PorcObraSocial { get; set; }
        public double MontoObraSocial { get; private set; }
        public double PorcJubilacion { get; set; }
        public double MontoJubilacion { get; private set; }
        public double PorcGremial { get; set; }
        public double MontoGremial { get; private set; }
        public double Neto { get; private set; }
        public double Productividad { get; private set; }
        public double ACobrar { get; private set; }



        public Liquidacion(Empleado e, int año, int mes)
        {
            this.Año = año;
            this.Mes = mes;
                    
        }

        public string VerImpreso()
        {
            return $"Concepto        Haberes         Descuentos " +
                 $"\r\n Básico       {MontoBasico}" +
                 $"\r\n Antigüedad (0)       {MontoAntiguedad}" +
                 $"\r\n Extras al 50% (4)    {MontoExtras50}" +
                 $"\r\n Extras al 100% (4)    {MontoExtras100}" +
                 $"\r\n Obra Social (3%)         {MontoObraSocial}" +
                 $"\r\n Jubilación (10%)         {MontoJubilacion}" +
                 $"\r\n Ap. Gremiales(1,5%)          {MontoGremial}" +
                 $"\r\n Productividad        {Productividad}" +
                 $"\r\n -------------------------------------------------------" +
                 $"\r\n -------------------------------------------------------";

        }
    }
}
