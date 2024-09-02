using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Empresa
    {
        public int AñoActual { get; set; }

        public Empresa() { }

        ArrayList liquidaciones = new ArrayList();

        ArrayList empleados = new ArrayList();

        public Empleado RegistrarEmpleado( int dni, string apellido, string nombre)
        {
            Empleado nuevo = new Empleado (dni, apellido, nombre, AñoActual);
            empleados.Add(nuevo);
            return nuevo;
        }

        public void GenerarLiquidaciones(int mes, int año)
        {
            foreach (Empleado e in empleados)
            {
                Liquidacion liquidacion = new Liquidacion(e, año, mes);
                liquidacion.PorcObraSocial = 3d;
                liquidacion.PorcJubilacion = 18d;
                liquidacion.PorcGremial = 1.5d;

                liquidaciones.Add(liquidacion);
            }

        }

        public ArrayList ListarLiquidaciones(int mes, int año)
        {
            ArrayList lista = new ArrayList();
            for (int idx = 0; idx < liquidaciones.Count; idx++)
            {
                Liquidacion aux = liquidaciones[idx] as Liquidacion;
                if (aux.Año == año && aux.Mes == mes)
                    lista.Add(aux);
            }
            return lista;
        }

        public double VerMontoLiquidacionTotal(int mes, int año) 
        {
            double liquidaciontotal = 0;
            foreach (Liquidacion liq in liquidaciones)
            {
                //Liquidacion aux = liq as Liquidacion;
                if (liq.Año == año && liq.Mes == mes)
                {
                    liquidaciontotal += liq.ACobrar;
                }

            }
            return liquidaciontotal;
        }

        public string MostrarReciboSueldo(int año, int mes, int dni) 
        {
            string recibo = "";

            for (int idx = 0; idx < liquidaciones.Count; idx++)
            {
                Liquidacion aux = liquidaciones[idx] as Liquidacion;
                if (aux.Año == año && aux.Mes == mes && aux.Empleado.DNI == dni)
                    recibo = aux.VerImpreso();
            }
            return recibo;
        
        }


    }
}
