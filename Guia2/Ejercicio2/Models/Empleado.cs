using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Empleado
    {
        public int DNI { get; private set; }
        public string Apellido { get; private set; }
        public string Nombre { get; private set; }
        public string ApellidoNombre 
        { get { return $"{Apellido}, {Nombre}"; } private set { } }
        public int AñoContrato { get; private set; }

        public double MontoBasicoNominal { get;}
        public int HorasExtras50 { get; }
        public int HorasExtras100 { get; }

        public Empleado (int dni, string apellido, string nombre, int añoContratado)
        {
            this.DNI = dni;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.AñoContrato = añoContratado;
        }

    }
}
