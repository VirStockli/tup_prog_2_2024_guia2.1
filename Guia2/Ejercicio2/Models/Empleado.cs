﻿using System;
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
        { get { return $"{Apellido}, {Nombre}"; } }
        public int AñoContrato { get; private set; }

        public double MontoBasicoNominal { get; set; }
        public int HorasExtras50 { get; set; }
        public int HorasExtras100 { get; set; }

        public Empleado (int dni, string apellido, string nombre, int añoContratado)
        {
            this.DNI = dni;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.AñoContrato = añoContratado;
        }

        public override string ToString() //ToString es con override y sin argumentos
        {
            return $"Empleado Registrado: " +
                $"\n\r DNI: {DNI} - {Apellido}, {Nombre} -" +
                $"\n\r Inicio contrato {AñoContrato}";
        }

    }
}
