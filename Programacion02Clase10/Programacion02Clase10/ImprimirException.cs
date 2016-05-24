using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase10
{
    class ImprimirException:Exception
    {
        public string usuario;
        public string descripcion;
        public string mensaje;

        private ImprimirException(string mensaje)
            :base(mensaje)
        {
            this.mensaje = mensaje;
        }

        public ImprimirException(string mensaje, Exception inner)
            : base(mensaje, inner)
        {
            this.mensaje = mensaje;
        }

        public ImprimirException(string mensaje, string descripcion, string user)
            : this(mensaje)
        {
            this.descripcion = descripcion;
            this.usuario = user;

        }
    }
}
