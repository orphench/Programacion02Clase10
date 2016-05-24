using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase10
{
    public class Documento
    {
        public static void ImprimirStatic(Documento doc)
        {
            //int numeroUno = 0;
            //int numeroDos = 10;
            //float resultado = numeroDos / numeroUno;

            ImprimirException miex = new ImprimirException("no se pudo imprimir ", "no hay red para la impresora", "Carlitos");
            throw miex;


        }

        public void ImprimirInstancia()
        {
            try
            {
                Documento.ImprimirStatic(this);
            }
            catch (ImprimirException ex)
            {
                ImprimirException nueva = new ImprimirException("Imprimir Instancia", ex);
                //throw ex;
                throw nueva;
            }

            
        }
    }
}
