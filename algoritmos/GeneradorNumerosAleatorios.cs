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
                generador.Panel1 = aleatorio.Next(limiteInferior, limiteSuperior);
                generador.Panel2 = aleatorio.Next(limiteInferior, limiteSuperior);
                generador.Panel3 = aleatorio.Next(limiteInferior,limiteSuperior);
                generador.Panel4 = aleatorio.Next(limiteInferior, limiteSuperior);
                generador.Panel5 = aleatorio.Next(limiteInferior, limiteSuperior);
                generador.IdExp = i;
                int Uno = Convert.ToInt32(generador.Panel1);
                int Dos = Convert.ToInt32(generador.Panel2);
                int Tres = Convert.ToInt32(generador.Panel3);
                int Cuarto = Convert.ToInt32(generador.Panel4);
                int Quinto = Convert.ToInt32(generador.Panel5);
                List<int> list = new List<int>();
                list.Add(Uno);
                list.Add(Dos);
                list.Add(Tres);
                list.Add(Cuarto);
                list.Add(Quinto);
                list.Sort();
                generador.Valor = list[3];

                listaClass1.Add(generador);
            }
            return listaClass1;
        }   
    }
}
