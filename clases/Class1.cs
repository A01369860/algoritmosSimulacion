using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmosSimulacion.clases
{
    public class Class1
    {
        public double Latitud {  get; set; }
        public double Longitud {  get; set; }

        public int IdPunto {  get; set; } 

        public bool Activo { get; set; }
        public string Especie {  get; set; }

        public Class1()
        { 
        }
        public Class1 (Class1 class1)
        {
            Longitud = class1.Longitud;
            Latitud = class1.Latitud;
            Activo = class1.Activo;
            Especie = class1.Especie;
            IdPunto = class1.IdPunto;

        }
    }
}
