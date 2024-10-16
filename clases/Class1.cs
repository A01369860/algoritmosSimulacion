using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmosSimulacion.clases
{
    public class Class1
    {
        public int Panel1 { get; set; }
        public int Panel2 { get; set; }

        public int Panel3 { get; set; }
        public int Panel4 { get; set; }
        public int Panel5 { get; set; }

        public int IdExp {  get; set; } 

        public int Valor {  get; set; }   

        public Class1()
        { 
        }
        public Class1 (Class1 class1)
        {
            Panel1 = class1.Panel1;
            Panel2 = class1.Panel2;
            Panel3 = class1.Panel3;
            Panel4 = class1.Panel4;
            Panel5 = class1.Panel5;
            IdExp = class1.IdExp;
            Valor = class1.Valor;
        }
    }
}
