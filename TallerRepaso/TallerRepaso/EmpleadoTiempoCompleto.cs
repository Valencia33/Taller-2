using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerRepaso
{
    internal class EmpleadoTiempoCompleto : Empleado
    {
        private int salarioFijo;

        public EmpleadoTiempoCompleto(int _id, string _nombre, int _salario)
            : base(_id, _nombre)
        {
            salarioFijo = _salario;
        }

        public override int CalcularSalario()
        {
            return salarioFijo;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"[Tiempo Completo] ID: {Id}, Nombre: {Nombre}, Salario: {CalcularSalario()}");
        }
    }
}