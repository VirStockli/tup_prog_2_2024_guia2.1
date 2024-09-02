using Ejercicio2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        Empresa empresa = new Empresa();
        public Form1()
        {
            InitializeComponent();

            empresa.AñoActual = 2010;
            
            empresa.RegistrarEmpleado(39031946, "Stockli", "Maria Virginia");
            empresa.RegistrarEmpleado(39159234, "Suarez", "Elías");
            empresa.RegistrarEmpleado(40035879, "Martinez", "Melina Giselle");

            
        }

        private void btnGenerarLiqui_Click(object sender, EventArgs e)
        {
            
            int año = 2024;
            int mes = 7;
            empresa.GenerarLiquidaciones(mes, año);

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            

            RegistrarEmpleado form = new RegistrarEmpleado();

            if (form.ShowDialog() == DialogResult.OK)
            {
                double montoBasico = 4000;
                int horaExt50 = 5;
                int horaExt100 = 4;

                string apellido = form.tbApellido.Text;
                string nombre = form.tbNombre.Text;
                int dni = Convert.ToInt32(form.tbDNI.Text);

                Empleado em = empresa.RegistrarEmpleado(dni, apellido, nombre);
                em.MontoBasicoNominal = montoBasico;
                em.HorasExtras50 = horaExt50;
                em.HorasExtras100 = horaExt100;

                tbVer.Text += $"{em}";
            }
        }

        private void btnMostrarLiqui_Click(object sender, EventArgs e)
        {
            tbVer.Clear();

            int año = 2024;
            int mes = 7;
            int n = 1;
            foreach (Liquidacion liquidacion in empresa.ListarLiquidaciones(mes, año))
            {
                tbVer.Text += $"---{n++}\r\n";
                tbVer.Text += liquidacion.VerImpreso();

            }
            tbVer.Text += "Total a liquidar en sueldos:";
            tbVer.Text += $" --${empresa.VerMontoLiquidacionTotal(mes, año)}";

        }
    }
}
