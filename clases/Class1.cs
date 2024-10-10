using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmosSimulacion.clases
{
    public class Class1
    {
        public double Producto {  get; set; }
        public double ProdMedio {  get; set; }

        public int IdPunto {  get; set; } 

        public double Valor1 { get; set; }
        public double Valor2 {  get; set; }

        public Class1()
        { 
        }
        public Class1 (Class1 class1)
        {
            Producto = class1.Producto;
            ProdMedio = class1.ProdMedio;
            Valor1 = class1.Valor1;
            Valor2 = class1.Valor2;
            IdPunto = class1.IdPunto;

        }
    }
}
