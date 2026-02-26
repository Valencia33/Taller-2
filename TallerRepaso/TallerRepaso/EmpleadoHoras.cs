using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerRepaso
{
    internal class EmpleadoHoras : Empleado
    {
        private int horasTrabajadas;
        private int valorHora;

        public EmpleadoHoras(int _id, string _nombre, int _horas, int _valor)
            : base(_id, _nombre)
        {
            horasTrabajadas = _horas;
            valorHora = _valor;
        }

        public override int CalcularSalario()
        {
            return horasTrabajadas * valorHora;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"[Por Horas] ID: {Id}, Nombre: {Nombre}, Salario: {CalcularSalario()}");
        }
    }
}