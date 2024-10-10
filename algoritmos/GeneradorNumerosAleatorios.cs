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
        public List<Class1> CrearListaOrigen(int puntosTotales, double seed1, 
            double seed2)
        {
            List<Class1> listaClass1 = new List<Class1>(); 
            for (int i = 0; i < puntosTotales; i++){
          
                Class1 generador = new Class1();

                generador.Producto = (seed1 * seed2); 
                generador.ProdMedio = 
                generador.IdPunto = i;
                generador.Valor1 = 
                generador.Valor2 = 

                listaClass1.Add(generador);
            }
            return listaClass1;
        }   
    }
}
