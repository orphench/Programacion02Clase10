using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiExcepciones
{  
        public class MiExcepcion : Exception
        {
            public string mensaje;

            public MiExcepcion(string mensaje, Exception inner)
                : base(mensaje, inner)
            {
                this.mensaje = mensaje;
            }
        }
    
}
