using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerRepaso
{
    internal abstract class Empleado : InterfazNoSeQuePonerle
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }

        protected Empleado(int _id, string _nombre)
        {
            Id = _id;
            Nombre = _nombre;
        }

        public abstract int CalcularSalario();

        public abstract void MostrarInformacion();
    }
}