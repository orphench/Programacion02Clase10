﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase10
{
    class MiExcepcion:Exception
    {


        public MiExcepcion(string mensaje, Exception inner):base(mensaje, inner)
        {
            
        }
    }
}
