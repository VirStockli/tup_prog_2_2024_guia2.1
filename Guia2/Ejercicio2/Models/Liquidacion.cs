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

        public Empleado Empleado { get; private set; }
        public double MontoBasico { get; set; }
        public double PorcAntiguedad 
        { get 
            {
                double porc = (Año - Empleado.AñoContrato) * 1.0 / 20 * 100;
                return porc;
            }  
        }

        public double MontoAntiguedad 
        { get 
            { 
                return MontoBasico * PorcAntiguedad / 100d;  
            }
        }
        public double HorasExtras50 { get; private set; }
        public double MontoExtras50 
        { get 
            { 
                return MontoBasico / 40d * HorasExtras50;
            }
        }
        public double HorasExtras100 { get; private set; }
        public double MontoExtras100
        {
            get
            {
                return MontoBasico / 40d * HorasExtras100;
            }
        }

        public double Nominal
        {
            get
            {
                return MontoBasico + MontoAntiguedad+MontoExtras50 + MontoExtras100;
            }
        }
        public double PorcObraSocial { get; set; }
        public double MontoObraSocial { get { return Nominal * 3d / 100; } }
        public double PorcJubilacion { get; set; }
        public double MontoJubilacion { get {return PorcJubilacion * 18d / 100;}        }
        public double PorcGremial { get; set; }
        public double MontoGremial { get { return PorcGremial / 100d * Nominal; } }
        public double Neto 
        {
            get
            /*ocurre bucle porque Neto es Nominal menos sí mismo,
             * así que vuelve a llamar a Neto para obtener un valor
             para calculr el Neto... infinitamente recursivo*/
            {
                return Nominal - MontoObraSocial - MontoJubilacion - MontoGremial;
            } 
        }
        public double Productividad { get { return Neto * 30d / 100; } }
        public double ACobrar
        {
            get
            {
                return Neto + Productividad;
            }
        }



        public Liquidacion(Empleado empleado, int año, int mes)
        {
            Empleado = empleado;
            this.Año = año;
            this.Mes = mes;
            MontoBasico = empleado.MontoBasicoNominal;
            HorasExtras50 = empleado.HorasExtras50;
            HorasExtras100 = empleado.HorasExtras100;
                    
        }

        public string VerImpreso()
        {
            string recibodesueldo = $@"
            Empleado {Empleado.ApellidoNombre}
            {"-".PadRight(70, '-')}
            Concepto {"Haberes",23}{"Descuentos",20}
            Básico {MontoBasico,29:f2}{" ",20}
            Antigüedad({PorcAntiguedad}){MontoAntiguedad,17:f2}{" ",20}
            Extras al 50%({HorasExtras50}){MontoExtras50,16:f2}{" ",20}
            Extras al 100% ({HorasExtras100}){MontoExtras100,13:f2}{" ",20}
            Obra Social ({PorcObraSocial}){" ",20}{MontoObraSocial,20:f2}
            Jubilación ({PorcJubilacion}){" ",20}{MontoJubilacion,21:f2}
            Ap. Gremiales({PorcGremial}){" ",20}{MontoGremial,15:f2}
            Productividad{Productividad,18}
            {"-".PadRight(70, '-')}
            {"Totales",30}     {Neto + Productividad,25:f2}{"",20}
            {"-".PadRight(70, '-')}
            {"A Cobrar",30}{ACobrar,29:f2}
            ";

            return recibodesueldo;
        }
    }
}
