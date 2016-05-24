using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numeroUno = 0;
                int numeroDos = 10;
                //float resultado = numeroDos / numeroUno; //Excepcion

                //string dato = Console.ReadLine();
                //numeroDos = int.Parse(dato);

                //Documento.ImprimirStatic();

                Portafolio unPortafolio = new Portafolio();
                Documento unDocumento = new Documento();
                unPortafolio.listado.Add(unDocumento);
                //Exception nueva = new Exception(
                unPortafolio.ImprimirPortafolio();
            }
            catch (FormatException ex)
            {
                //ingrese un numero
                Console.WriteLine(ex.Message);
                
            }
            catch (DivideByZeroException ex)
            {
                //el segundo no puede ser cero
                Console.WriteLine(ex.Message);

            }

            catch (ImprimirException ex)
            {
                Console.WriteLine(ex.Message + ex.usuario);
                
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }

            

        }
    }
}
