using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiExcepciones;

namespace MiBiblioteca
{
    public class Portafolio
    {
        public List<Documento> listado;

        public Portafolio()
        {
            listado = new List<Documento>();
        }

        public void ImprimirPortafolio()
        {
            try
            {
                foreach (Documento itemDocumento in listado)
                {
                    itemDocumento.ImprimirInstancia();
                }
            }
            catch (ImprimirException ex)
            {
                //ImprimirException nueva = new ImprimirException("Imprimir Portafolio", ex);
                MiExcepcion nueva = new MiExcepcion("Imprimir Portafolio", ex);
                //throw ex;
                throw nueva;
            }

            finally
            {
                Console.WriteLine("Finally Imprimir Portafolio");
            }
        }
    }
}
