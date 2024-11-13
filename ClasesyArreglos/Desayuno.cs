using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesyArreglos
{
    public class Desayuno
    {
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Dias { get; set; }

        public override string ToString()
        {
            return $"Desayuno {Nombre} S/{Precio}, servicio los {Dias}";
        }

        public string[] ListaDias()
        {
            return Dias.Split(',');
        }
    }
}

