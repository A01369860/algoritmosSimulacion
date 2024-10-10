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
        public List<Class1> CrearListaOrigen(int puntosTotales, int limiteInferior, 
            int limiteSuperior)
        {
            List<Class1> listaClass1 = new List<Class1>(); 
            for (int i = 0; i < puntosTotales; i++){
                Random aleatorio = new Random(); // es pseudoaleatorio, checa el tiemmpo de compu
                Class1 generador = new Class1();
                generador.Latitud = aleatorio.Next(limiteInferior, limiteSuperior);
                generador.Longitud = aleatorio.Next(limiteInferior, limiteSuperior);
                generador.IdPunto = i;
                generador.Especie = i.ToString();
                generador.Activo = false;

                listaClass1.Add(generador);
            }
            return listaClass1;
        }   
    }
}
