using algoritmosSimulacion.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace algoritmosSimulacion.algoritmos
{
    public class GeneradorNumerosAleatorios
    {
        public GeneradorNumerosAleatorios() { }
        
        
        public List<Class1> CrearListaOrigen(int puntosTotales, int seed1,
            int seed2)
        {
            List<Class1> listaClass1 = new List<Class1>(); 
           
                for (int i = 0; i < puntosTotales; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Class1 generador = new Class1();

                        generador.Producto = (seed1 * seed2);
                        int a = generador.Producto;
                        string b = a.ToString();

                        generador.ProdMedio = 
                        generador.IdPunto = j;
                        generador.Valor1 =
                        generador.Valor2 =

                        listaClass1.Add(generador);

                        // insertar en fila i
                    }
                }
            }
            return listaClass1;
        }   
    }
}
